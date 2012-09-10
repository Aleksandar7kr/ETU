using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    class BinaryTree
    {
        public BinaryTree() // конструктор
        {
            data = "";
            left = null;
            right = null;
        }

        public void addLeftChild(BinaryTree element) // добавление левого потомка
        {
            if (element != null)
            {
                left = element;
            }
        }

        public void addRightChild(BinaryTree element) // добавление правого потомка
        {
            if (element != null)
            {
                right = element;
            }
        }

        public void setData(String data) // установка информационной части
        {
            this.data = data;
        }

        public String getData() // доступ к информационной части
        {
            return data;
        }

        public BinaryTree getLeft() // доступ к левому потомку
        {
            return left;
        }

        public BinaryTree getRight() // доступ к правому потомку
        {
            return right;
        }

        private string data; // информационная часть
        private BinaryTree left; // левый потомок
        private BinaryTree right; // правый потомок

    }
}
