using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kruskal
{
    class SquareMatrix2d : Matrix2d
    {
        #region constructors

        public SquareMatrix2d(int n, double defaultValue)
            : base(n, n, defaultValue)
        {
        }

        public SquareMatrix2d(string fileName)
            : base(fileName)
        {
        }

        public SquareMatrix2d(SquareMatrix2d m)
            : base(m)
        {
        }

        public SquareMatrix2d(Matrix2d m)
            : base(m)
        {
        }

        /// <summary>
        /// Calculate a determinant of square matrix
        /// http://en.wikipedia.org/wiki/Determinant
        /// </summary>
        /// <returns>det of matrix</returns>
        public double Determinant()
        {
            double det = 1;
            double EPS = 0.00000000001;

            SquareMatrix2d m = new SquareMatrix2d(this);

            int n = XSize;

            for (int i = 0; i < n; i++)
            {
                int k = i;
                for (int j = i + 1; j < n; ++j)
                    if (Math.Abs(m[j, i]) > Math.Abs(m[k, i])) k = j;

                if (Math.Abs(m[k, i]) < EPS) return 0;

                for (int it = 0; it < n; ++it)
                {
                    double temp = m[i, it];
                    m[i, it] =  m[k, it];
                    m[k, it] = temp;
                }

                if (i != k) det = -det;
                det *= m[i, i];

                for (int j = i + 1; j < n; ++j)
                    m[i, j] = m[i, j] / m[i, i];

                for (int j = 0; j < n; ++j)
                    if (j != i && Math.Abs(m[j, i]) > EPS)
                        for (k = i + 1; k < n; ++k)
                            m[j, k] =  m[j, k] - (m[i, k] * m[j, i]);
            }

            return det;
        }

        #endregion
    }
}
