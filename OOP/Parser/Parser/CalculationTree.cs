using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Parser
{
    class CalculationTree
    {
        public CalculationTree(BinaryTree tree) // конструктор класса
        {
            this.tree = tree;
            getCountVariables(tree); // подсчет кол-ва переменных
        }

        public double getResult(List<double> args) 
        {
            if (args.Count == var.Count) // если размерности массива переменных и их значений совпадают
            {
                res = calculateTree(tree, args); // вычисляем дерево
                return res;
            }
            else
                throw new Exception("Input data incorrect");
        }

        public double getGradient(List<double> args, List<double> p, double eps) // подсчет градиента
        {
            // считается по формуле: grad = (f(x + eps) - f(x))/eps
            double grad = 0;
            List<double> res = new List<double>();
            List<double> tmp = new List<double>(args);
            for (int i = 0; i < tmp.Count; i++)
            {
                tmp[i] =  tmp[i] + eps;
                res.Add(getResult(tmp));
                tmp[i] = tmp[i] - eps;
                res[i] = res[i] - getResult(tmp);
                res[i] = res[i] / eps;
            }

            for (int i = 0; i < res.Count; i++)
                grad += res[i] * p[i];
            return grad;
        }

        public double getDerevative(List<double> args, double eps, int n) // подсчет численного значения в производной
        {
            // считается по формуле: der = (f(x + eps) - f(x - eps))/(2*eps)
            List<Double> res = new List<double>();
            List<Double> tmp = new List<double>(args);
            for (int i = 0; i < tmp.Count; i++)
            {
                tmp[i] = tmp[i] + eps;
                res.Add(getResult(tmp));
                tmp[i] = tmp[i] - 2 * eps;
                res[i] = res[i] - getResult(tmp);
                res[i] = res[i] / (2 * eps);
            }
            return res[n];
        }

        private double calculateTree(BinaryTree tree, List<double> args) // вычисление дерева
        {
            double left = 0, right = 0, res = 0;
            if (tree.getData().Equals("+"))
            {
                left = calculate(tree.getLeft(), args); // считаем левую часть
                right = calculate(tree.getRight(), args); // считаем правую часть
                res = left + right;
            }
            else if (tree.getData().Equals("-"))
            {
                left = calculate(tree.getLeft(), args); // считаем левую часть
                right = calculate(tree.getRight(), args); // считаем правую часть
                res = left - right;
            }
            else if (tree.getData().Equals("*"))
            {
                left = calculate(tree.getLeft(), args); // считаем левую часть
                right = calculate(tree.getRight(), args); // считаем правую часть
                res = left * right;
            }
            else if (tree.getData().Equals("/"))
            {
                left = calculate(tree.getLeft(), args); // считаем левую часть
                right = calculate(tree.getRight(), args); // считаем правую часть
                res = left / right;
            }
            else if (tree.getData().Equals("^"))
            {
                left = calculate(tree.getLeft(), args); // считаем левую часть
                right = calculate(tree.getRight(), args); // считаем правую часть
                res = Math.Pow(left, right);
            }
            else if (tree.getData().Equals("cos"))
            {
                left = calculate(tree.getLeft(), args); // считаем левую часть
                res = Math.Cos(left);
            }
            else if (tree.getData().Equals("sin"))
            {
                left = calculate(tree.getLeft(), args); // считаем левую часть
                res = Math.Sin(left);
            }
            else if (tree.getData().Equals("exp"))
            {
                left = calculate(tree.getLeft(), args); // считаем левую часть
                res = Math.Exp(left);
            }
            else if (tree.getData().Equals("log"))
            {
                left = calculate(tree.getLeft(), args); // считаем левую часть
                res = Math.Log(left);
            }
            return res;
        }

        private Double calculate(BinaryTree tree, List<double> args) // вычисление узла дерева
        {
            double tmp = 0;
            if (isSign(tree.getData())) // если это знак
            {
                tmp = calculateTree(tree, args); // то вычисляем поддерево
            }
            else if (isVariable(tree.getData())) // если переменная, то заменяем ее на соответствущее ей входное значение
            {
                for (int i = 0; i < var.Count; i++)
                {
                    if (var[i].Equals(tree.getData()))
                    {
                        tmp = args[i];
                        break;
                    }
                }
            }
            else if (isDigit(tree.getData())) // если число, то парсим его
            {
                tmp = double.Parse(tree.getData());
            }
            return tmp;
        }

        private void getCountVariables(BinaryTree tree) // подсчет кол-ва переменных в дереве
        {
            if (tree.getLeft() != null) getCountVariables(tree.getLeft());
            if (tree.getRight() != null) getCountVariables(tree.getRight());

            if (isVariable(tree.getData()) && !isMathFunction(tree.getData()))
            {
                for (int i = 0; i < var.Count; i++)
                {
                    if (var[i].Equals(tree.getData())) // если такая переменная уже была посчитана
                    {
                        return;
                    }
                }
                var.Add(tree.getData()); // иначе добавляем ее
            }
        }

        private bool isDigit(string data) // регулярное выражение, определяющее является ли строка вещественным числом
        {
            try
            {
                double tmp = double.Parse(data);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool isVariable(string data) // регулярное выражение, определяющее является ли строка переменной
        {
            Match match = Regex.Match(data, "[a-z]+[0-9]*");
            if (match.Success && match.Length == data.Length)
                return true;
            return false;
        }

        private bool isSign(String data) // регулярное выражение, определяющее является ли строка матем. знаком
        {
            if (data.Equals("+") || data.Equals("-") || data.Equals("*") ||
                    data.Equals("/") || data.Equals("^") || data.Equals("cos") ||
                    data.Equals("sin") || data.Equals("log") || data.Equals("exp"))
                return true;
            return false;
        }

        private bool isMathFunction(String data) // регулярное выражение, определяющее является ли строка матем. функцией
        {
            if (data.Equals("cos") || data.Equals("sin") ||
                    data.Equals("exp") || data.Equals("log"))
                return true;
            return false;
        }

        public List<String> getVar() // доступ к массиву переменных
        {
            return var;
        }

        private double res = 0D; // результат подсчета
        private List<string> var = new List<string>(); // массив переменных
        private BinaryTree tree; // дерево разбора

    }
}
