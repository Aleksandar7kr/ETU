using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Parser
{
    class Parser
    {
        public BinaryTree getTree(String function) // получение дерева разбора из входной строки
        {
            function = deleteAllSpace(function); // удаляем все пробелы
            tree.setData(function); // устанавливаем функцию в вершину
            countMinus(tree); // считаем кол-во минусов
            parse(tree); // парсим функцию
            setZero(tree); // устанавливаем 0 для случаев: например, -2*х <=> 0-2*х
            return tree;
        }

        private void countMinus(BinaryTree tree) // считает кол-во минусов
        {
            List<SignPriority> list = findAllSignes(tree); // найдем все знаки в дереве
            for (int i = 0; i < list.Count; i++)
                if (list[i].getSign().Equals("-") && list[i].isPriority())
                    CountMinus++;
        }

        private void parse(BinaryTree tree) // основной метод разбора дерева
        {
            bool findCos = tree.getData().Contains("cos"); // ищем тригонометрические функции
            bool findSin = tree.getData().Contains("sin");
            bool findLog = tree.getData().Contains("log");
            bool findExp = tree.getData().Contains("exp");

            int posOpenBracket = tree.getData().IndexOf("("); // ищем позиции ( и )
            int posCloseBracket = tree.getData().IndexOf(")");

            if ((findCos || findSin || findLog || findExp) &&
                    posOpenBracket != -1 && posCloseBracket != -1)
            {
                // это функция, содержащаю тригонометрические функции
                parseMathFunction(tree);
            }
            else if (posOpenBracket != -1 && posCloseBracket == -1)
            {
                // удаляем (
                deleteBrackets(tree, "(");
                parse(tree);
            }
            else if (posOpenBracket == -1 && posCloseBracket != -1)
            {
                // удаляем )
                deleteBrackets(tree, ")");
                parse(tree);
            }
            else if (posOpenBracket != -1 && posCloseBracket != -1)
            {
                // это функци со скобками
                simplifyFunction(tree); // упрощаем его
                List<SignPriority> list = findAllSignes(tree); // находим все знаки
                SignPriority sp = sort(tree, list); // сортируем по знакам
                if (list.Count == 0 && sp == null) // если нет знаков, то во входной функции лишние скобки
                {
                    deleteBrackets(tree, "("); // удаляем их
                    deleteBrackets(tree, ")");
                    parse(tree); // продолжаем парсить входную строку
                }
                else
                {
                    string sign = sp.getSign(); // получаем самый приоритетный знак
                    int pos = sp.getPos(); // получаем его позицию во входной строке
                    parseNext(tree, sign, pos); 
                }
            }
            else if (posOpenBracket == -1 && posCloseBracket == -1)
            {
                // это функция без скобок
                if (CountMinus > 1) // если минусов больше, чем 1, то самый приоритетный знак - минус
                {
                    findMathSign(tree, "-");
                    findMathSign(tree, "+");
                    findMathSign(tree, "*");
                    findMathSign(tree, "/");
                    findMathSign(tree, "^");
                }
                else
                {
                    findMathSign(tree, "+");
                    findMathSign(tree, "-");
                    findMathSign(tree, "*");
                    findMathSign(tree, "/");
                    findMathSign(tree, "^");
                }
            }
        }

        private void parseMathFunction(BinaryTree tree) // парсинг мат функции, содержащей тригонометрические функции
        {
            if (tree != null)
            {
                List<SignPriority> list = findAllSignes(tree); // находим знаки
                SignPriority sp = sort(tree, list); // сортируем их по приоритетам
                int pos = 0;
                if (sp != null)
                {
                    pos = sp.getPos();
                    String sign = sp.getSign();
                    parseNext(tree, sign, pos);
                }
                else
                {
                    pos = findPosMathFunction(tree);
                    parseTrigFunction(tree, pos);
                }
            }
        }

        private int findPosMathFunction(BinaryTree tree) // нахождение позиции тригонометрической функции
        {
            int posLog = tree.getData().IndexOf("log");
            int posCos = tree.getData().IndexOf("cos");
            int posSin = tree.getData().IndexOf("sin");
            int posExp = tree.getData().IndexOf("exp");
            if (posLog == 0)
                return posLog;
            else if (posCos == 0)
                return posCos;
            else if (posSin == 0)
                return posSin;
            else if (posExp == 0)
                return posExp;
            return -1;
        }

        private void parseTrigFunction(BinaryTree tree, int pos) // добавление к дереву триг функции
        {
            String tmp = tree.getData();
            BinaryTree left = new BinaryTree();
            tree.setData(tmp.Substring(pos, 3)); // триг функцию добавляем в вершину
            left.setData(tmp.Substring(pos + 3)); // а аргумент в левого потомка
            tree.addLeftChild(left);
            parse(tree.getLeft()); // парсим левого потомка
        }

        private void simplifyFunction(BinaryTree tree) // упрощение функции
        {
            String function = tree.getData();
            bool check = false;
            int battery = 0;
            int pos = 0;
            List<SignPriority> list = findAllSignes(tree); // находим все знаки
            //System.out.println(list);
            SignPriority sp = sort(tree, list); // сортируем их
            if (sp != null)
            { // если есть приоритеный знак
                pos = sp.getPos();
                for (int i = 0; i < pos; i++) // считаем кол-во скобочек
                {
                    if (function[i] == '(') battery++;
                    else if (function[i] == ')') battery--;
                }
                if (pos != -1) 
                {
                    for (int i = pos; i < function.Length; i++) 
                    {
                        if (isSign(tree, i))
                            check = true;
                    }
                }
                else
                {
                    for (int i = 0; i < function.Length; i++)
                    {
                        if (function[i] == '(') battery++;
                        else if (function[i] == ')') battery--;
                    }
                    if (battery > 0) deleteBrackets(tree, "(");
                    else if (battery < 0) deleteBrackets(tree, ")");
                    return;
                }
            }
            if (battery > 0 && !check)
            {
                deleteBrackets(tree, "(");
                deleteBrackets(tree, ")");
            }
        }

        private List<SignPriority> findAllSignes(BinaryTree tree) // нахождение всех ариф знаков во входной строке
        {
            List<SignPriority> list = new List<SignPriority>(); 
            String function = tree.getData(); 
            int battery = 0;
            int someLength = function.Length - 2;
            for (int i = 0; i < someLength; i++)
            {
                if (function[i] == '(') // считаем кол-во скобочек
                    battery++;
                else if (function[i] == ')')
                    battery--;

                if (function[i] == '(' && i != 0) // скобка стоит не в начале, 
                {
                    if (isSign(tree, i - 1))
                    {
                        if (battery == 0) // знак приоритетен
                            list.Add(new SignPriority(i - 1, function.Substring(i - 1, 1), true));
                        else // знак не приоритетен
                            list.Add(new SignPriority(i - 1, function.Substring(i - 1, 1), false));
                    }
                }
                else if (function[i] == ')' && function[i + 2] == '(' && isSign(tree, i + 1) && battery == 0) // добавление приоритетного знака между скобками
                {
                    list.Add(new SignPriority(i + 1, function.Substring(i + 1, 1), true));
                    i += 2;
                    battery++;
                }
                else if (function[i] == ')' && i != function.Length - 1 && isSign(tree, i + 1)) // добавление знака, стоящего после )
                {
                    if (battery == 0)
                        list.Add(new SignPriority(i + 1, function.Substring(i + 1, 1), true));
                    else
                        list.Add(new SignPriority(i + 1, function.Substring(i + 1, 1), false));
                    i++;
                }
                else if (isSign(tree, i) && battery == 0)
                    list.Add(new SignPriority(i, function.Substring(i, 1), true));
            }
            if (someLength > 0 && isSign(tree, someLength) && battery == 0) // для случая x+2
                list.Add(new SignPriority(someLength, function.Substring(someLength, 1), true));
            return list;
        }

        private SignPriority sort(BinaryTree tree, List<SignPriority> list) // сортировка пузырьком ариф знаков входной функции
        {
            if (list.Count == 0) return null;
            else
            {
                for (int i = 0; i < list.Count - i - 1; i++)
                    for (int j = 0; j < list.Count - 1; j++)
                        if (compareTo(list, j))
                            swap(list, j, j + 1);

                countMinus(tree); // считаем кол-во минусов
                if (CountMinus > 1)
                { // нахождение самого последнего приоритетного минуса
                    SignPriority tmp = new SignPriority();
                    int pos = 0, maxPos = 0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].getSign().Equals("-"))
                        {
                            pos = list[i].getPos();
                            if (pos > maxPos)
                            {
                                maxPos = pos;
                                tmp = list[i];
                            }
                        }
                    }
                    CountMinus = 0;
                    return tmp;
                }
                return list[0];
            }
        }

        private bool compareTo(List<SignPriority> list, int i) // определение приоритетного знака
        {
            /*
             * приоритеты:
             * +,-,*,/,^
             */
            if (list[i].getSign().Equals("+") && list[i + 1].Equals("-"))
                return true;
            else if (list[i].getSign().Equals("*") &&
                (list[i + 1].getSign().Equals("-")) ||
                 list[i + 1].getSign().Equals("+"))
                return true;
            else if (list[i].getSign().Equals("/") &&
                    (list[i + 1].getSign().Equals("-") ||
                     list[i + 1].getSign().Equals("+") ||
                     list[i + 1].getSign().Equals("*")))
                return true;
            else if (list[i].getSign().Equals("^") &&
                    (list[i + 1].getSign().Equals("-") ||
                     list[i + 1].getSign().Equals("+") ||
                     list[i + 1].getSign().Equals("*") ||
                     list[i + 1].getSign().Equals("/")))
                return true;
            return false;
        }

        private void swap(List<SignPriority> list, int i, int j)
        {
            SignPriority sp = new SignPriority();
            sp = list[i];
            list[i] = list[j];
            list[j] =  sp;
        }

        private void deleteBrackets(BinaryTree tree, String sign) // удаление скобочек
        {
            StringBuilder tmp = new StringBuilder(tree.getData());
            if (sign.Equals("("))
                tmp = tmp.Remove(tree.getData().IndexOf("("), 1);
            else if (sign.Equals(")"))
                tmp = tmp.Remove(tree.getData().LastIndexOf(")"), 1);
            tree.setData(tmp.ToString());
        }

        private void findMathSign(BinaryTree tree, String sign) // поиск мат знака
        {
            int pos = 0;
            if (tree != null)
            {
                if (tree.getLeft() == null && tree.getRight() == null)
                {
                    if (sign.Equals("-") && CountMinus > 1) // если - и их больше 1
                    {
                        pos = tree.getData().LastIndexOf(sign);
                        CountMinus--;
                    }
                    else
                        pos = tree.getData().IndexOf(sign);
                    if (pos != -1 && !isVariable(tree.getData()) && !isDigit(tree.getData()))
                        parseNext(tree, sign, pos);
                }
                else if (tree.getLeft() != null && tree.getRight() != null)
                {
                    findMathSign(tree.getLeft(), sign);
                    findMathSign(tree.getRight(), sign);
                }
                else
                    throw new Exception("Ошибка при построении дерева!");
            }
        }

        private void parseNext(BinaryTree tree, String sign, int pos) // добавление потомков и последующий парсинг левого и правого потомков
        {
            addChilds(tree, sign, pos);
            parse(tree.getLeft());
            parse(tree.getRight());
        }

        private void addChilds(BinaryTree tree, String sign, int pos) // добавление потомков
        {
            String tmp = tree.getData();
            tree.setData(sign);
            BinaryTree left = new BinaryTree(); // добавление левого потомка
            left.setData(tmp.Substring(0, pos));
            tree.addLeftChild(left);

            BinaryTree right = new BinaryTree(); // добавление правого потомка
            right.setData(tmp.Substring(pos + 1));
            tree.addRightChild(right);
        }

        private bool isDigit(string data) // регулярное выражение, определяющее является ли строка вещественным числом
        {
            Match match = Regex.Match(data, "[-]?[0-9]+[[.][0-9]+]?");
            if (match.Success && match.Length == data.Length)
                return true;
            return false;
        }

        private bool isVariable(string data) // регулярное выражение, определяющее является ли строка переменной
        {
            Match match = Regex.Match(data, "[a-z]+[0-9]*");
            if (match.Success && match.Length == data.Length)
                return true;
            return false;
        }

        private bool isSign(BinaryTree tree, int pos) // регулярное выражение, определяющее является ли строка мат. знаком
        {
            string function = tree.getData();
            if (function[pos] == '+' || function[pos] == '-' || function[pos] == '*' ||
                    function[pos] == '/' || function[pos] == '^')
                return true;
            return false;
        }

        private String deleteAllSpace(String function) // удаление всех пробелов их входной строки
        {
            return function = function.Replace(" ", "");
        }

        private void setZero(BinaryTree tree) // добавляет нули вместо пустой строки в дереве разбора
        {
            if (tree.getLeft()  != null)  setZero(tree.getLeft());
            if (tree.getRight() != null) setZero(tree.getRight());

            if (tree.getData().Equals(""))
                tree.setData("0");
        }

        private int CountMinus = 0; // кол-во минусов
        private BinaryTree tree = new BinaryTree(); // дерево разбора

    }
}
