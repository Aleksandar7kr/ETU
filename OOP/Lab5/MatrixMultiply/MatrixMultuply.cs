using System;

namespace MatrixMultiply
{
    class MatrixMultuply
    {
        public int[,] Multily(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
            {
                throw new System.Exception("impossible to multiply matrices: A[m1*n1], B[m2*n2] where n1 must be equal m2 !!!\n");
            }
            else
            {
                int[,] c = new int[a.GetLength(0), b.GetLength(1)];

                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        int elem = 0;
                        for (int k = 0; k < a.GetLength(1); k++)
                        {
                            elem += (a[i, k] * b[k, j]);
                        }
                        c[i, j] = elem;
                    }
                }
                return c;
            }   
        }

        public void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        public void InitMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void Main(String[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];

            Console.WriteLine("Enter the values of matrix A elements");
            InitMatrix(a);
            Console.WriteLine("Enter the values of matrix B elements");
            InitMatrix(b);

            Console.Clear();

            Console.WriteLine("matrix A");
            PrintMatrix(a);
            Console.WriteLine("");

            Console.WriteLine("matrix B");
            PrintMatrix(b);
            Console.WriteLine("");

            try
            {
                int[,] res = Multily(a, b);
                Console.WriteLine("matrix C = A*B");
                PrintMatrix(res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
