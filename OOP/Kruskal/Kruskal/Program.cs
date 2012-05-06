using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kruskal
{
    class Program
    {
        static void Main(string[] args)
        {

            SquareMatrix2d wm = new SquareMatrix2d("g46.txt");
            SquareMatrix2d minSpanTree = Algorithms.MakeMinSpannedTree(wm);
            SquareMatrix2d K = Algorithms.MakeKirchhoffMatrix(wm);
            double det = new SquareMatrix2d(K.Cofactor(1, 1)).Determinant();

            Console.WriteLine("Source matrix\n");
            Console.WriteLine(wm);
            Console.WriteLine("Kirchhoff matrix\n");
            Console.WriteLine(K.ToString());
            Console.WriteLine("determinant   of Kirchhoff matrix: {0}\n", det);
            Console.WriteLine("Min spanned tree matrix\n");
            Console.WriteLine(minSpanTree);

            Console.ReadKey();
        }
    }
}
