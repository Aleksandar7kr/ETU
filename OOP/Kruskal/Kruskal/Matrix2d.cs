using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Kruskal
{
    class Matrix2d
    {
        #region fields

        private double[,] elems;
        private readonly int _xSize;
        private readonly int _ySize;
        private Exception sizeError;

        #endregion

        #region constructors

        /// <summary>
        /// general ctor (protected);
        /// </summary>
        /// <param name="n">x size</param>
        /// <param name="m">y size</param>
        protected Matrix2d(int n, int m)
        {
            _xSize = n; _ySize = m;
            elems = new double[n, m];
            sizeError = new Exception("action on the matrices of this size can not be performed");
        }

        /// <summary>
        /// ctor with default value for all elements
        /// </summary>
        /// <param name="n">x size</param>
        /// <param name="m">y size</param>
        /// <param name="defaultValue">default value, set [0] or [1]  or [??] matrix</param>
        public Matrix2d(int n, int m, double defaultValue)
            : this(n, m)
        {
            for (int i = 0; i < XSize; ++i)
            {
                for (int j = 0; j < YSize; ++j)
                {
                    elems[i, j] = defaultValue;
                }
            }
        }

        /// <summary>
        /// copy ctor
        /// </summary>
        /// <param name="m">Matrix2d for copy</param>
        public Matrix2d(Matrix2d m)
            : this(m.XSize, m.YSize)
        {
            for (int i = 0; i < YSize; ++i)
            {
                for (int j = 0; j < XSize; ++j)
                {
                    elems[j, i] = m[j, i];
                }
            }
        }

        /// <summary>
        /// ctor, elem are the read from file
        /// </summary>
        /// <param name="fileName">string parametr - name of file</param>
        public Matrix2d(string fileName)
            : this(0, 0)
        {
            StreamReader f = new StreamReader(fileName);
            _xSize = Convert.ToInt32(f.ReadLine());
            _ySize = Convert.ToInt32(f.ReadLine());

            elems = new double[XSize, YSize];

            for (int i = 0; i < YSize; ++i)
            {
                string[] s = f.ReadLine().Split();
                for (int j = 0; j < XSize; ++j)
                {
                    elems[j, i] = double.Parse(s[j]);
                }
            }
            f.Close();
        }

        #endregion

        #region Properties

        public int XSize { get { return _xSize; } }
        public int YSize { get { return _ySize; } }

        /// <summary>
        /// indexator for access M[i,j]
        /// </summary>
        /// <param name="i">x index</param>
        /// <param name="j">y index</param>
        /// <returns>M[i,j]</returns>
        public double this[int i, int j]
        {
            get
            {
                if (i < XSize && j < YSize)
                {
                    return elems[i, j];
                }
                throw new IndexOutOfRangeException("out of Matrix range");
            }
            set
            {
                if (i < XSize && j < YSize)
                {
                    elems[i, j] = value;
                }
                else 
                    throw new IndexOutOfRangeException("out of Matrix range");
            }

        }

        #endregion


        #region Methods

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < YSize; ++i)
            {
                for (int j = 0; j < XSize; ++j)
                {
                    str += this[j, i].ToString() + " ";
                }
                str += "\n";
            }
            return str;
        }

        public static Matrix2d operator +(Matrix2d A, Matrix2d B)
        {
            if (A.XSize != B.XSize || A.YSize != B.YSize)
            {
                throw A.sizeError;
            }
            else
            {
                Matrix2d C = new Matrix2d(A.XSize, A.YSize);
                for (int i = 0; i < C.YSize; i++)
                {
                    for (int j = 0; j < C.XSize; j++)
                    {
                        C[j, i] = A[j, i] + B[j, i];
                    }
                }
                return C;
            }
        }

        public static Matrix2d operator -(Matrix2d A, Matrix2d B)
        {
            if (A.XSize != B.XSize || A.YSize != B.YSize)
            {
                throw A.sizeError;
            }
            else
            {
                Matrix2d C = new Matrix2d(A.XSize, A.YSize);
                for (int i = 0; i < C.YSize; i++)
                {
                    for (int j = 0; j < C.XSize; j++)
                    {
                        C[j, i] = A[j, i] - B[j, i];
                    }
                }
                return C;
            }
        }

        public static Matrix2d operator *(Matrix2d B, Matrix2d A)
        {
            if (A.YSize != B.XSize)
            {
                throw new System.Exception("impossible to multiply matrices: A[m1*n1], B[m2*n2] where n1 must be equal m2 !!!\n");
            }
            else
            {
                Matrix2d C = new Matrix2d(A.XSize, B.YSize);

                for (int i = 0; i < C.XSize; i++)
                {
                    for (int j = 0; j < C.YSize; j++)
                    {
                        double elem = 0;
                        for (int k = 0; k < A.YSize; k++)
                        {
                            elem += (A[i, k] * B[k, j]);
                        }
                        C[i, j] = elem;
                    }
                }
                return C;
            }
        }

        public static Matrix2d operator *(double scalar, Matrix2d A)
        {
                Matrix2d C = new Matrix2d(A.XSize, A.YSize);

                for (int i = 0; i < C.YSize; i++)
                {
                    for (int j = 0; j < C.XSize; j++)
                    {
                        C[j, i] = (A[j,i]*scalar);
                    }
                }
                return C;
        }

        /// <summary>
        /// Created a Cofactor
        /// http://en.wikipedia.org/wiki/Cofactor_(linear_algebra)
        /// </summary>
        /// <param name="x">x index</param>
        /// <param name="y">y index</param>
        /// <returns>Matrix of cofactor</returns>
        public Matrix2d Cofactor(int x, int y)
        {
            Matrix2d C = new Matrix2d(this.XSize -1 , this.YSize-1 );

            int ci = 0, cj = 0;

            for (int i = 0; i < YSize; i++)
            {
                cj = 0;
                for (int j = 0; j < XSize; j++)
                {
                    if (j != x && i != y)
                    {
                        C[cj, ci] = this[j, i];
                        cj++;
                    }
                }
                if (i != y) ci++;
            }
            return C;
        }

        /// <summary>
        /// Create a transpose matrix
        /// http://en.wikipedia.org/wiki/Transpose
        /// </summary>
        /// <returns>Tranpose matrix</returns>
        public Matrix2d Tranpose()
        {
            Matrix2d t = new Matrix2d(this.YSize, this.XSize);

            for (int i = 0; i < YSize; ++i)
            {
                for (int j = 0; j < XSize; ++j)
                {
                    t[i,j] = this[j,i];
                }
            }
            return t;
        }

        #endregion
    }

}
