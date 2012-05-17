using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kruskal
{
    class Algorithms
    {
        /// <summary>
        /// Make Adjacency matrix for undirected weighted graph
        /// http://en.wikipedia.org/wiki/Adjacency_matrix
        /// </summary>
        /// <param name="m">square matrix of weighted graph</param>
        /// <returns>square adj matrix</returns>
        public static SquareMatrix2d MakeAdjacencyMatrix(SquareMatrix2d m)
        {
            SquareMatrix2d am = new SquareMatrix2d(m.XSize, m.YSize);

            for (int i = 0; i < m.XSize; i++)
            {
                for (int j = 0; j < m.YSize; j++)
                {
                    am[i, j] = ((m[i, j] != 0) ? ((i ==j)? 0:1) : 0);
                }
            }
            return am;
        }

        /// <summary>
        /// Make Incedented matrix for undirected weighted graph
        /// </summary>
        /// <param name="m">square matrix of weighted graph</param>
        /// <returns>Incedented matrix</returns>
        public static Matrix2d MakeIncedenceMatrix(SquareMatrix2d m)
        {
            int x = 0;
            for (int i = 0; i < m.YSize-1; i++)
            {
                for (int j = i+1; j < m.XSize; j++)
                {
                    if (m[j,i] != 0)
                        x++;
                }
            }
            Matrix2d im = new Matrix2d(x, m.YSize,0);

            int it = 0;
            for (int i = 0; i < m.YSize-1; i++)
            {
                for (int j = i+1; j < m.XSize; j++)
                {
                    if (m[j, i] != 0)
                    {
                        im[it, i] = 1;
                        im[it, j] = 1;
                        it++;
                    }
                }
            }

            return im;
        }

        /// <summary>
        /// Make Kirchhoff matrix for undirected weighted graph
        /// http://en.wikipedia.org/wiki/Incidence_matrix
        /// </summary>
        /// <param name="wm">square matrix of weighted graph</param>
        /// <returns>square Kirchhoff matrix</returns>
        public static SquareMatrix2d MakeKirchhoffMatrix(SquareMatrix2d wm)
        {
            Matrix2d im = Algorithms.MakeIncedenceMatrix(wm);
            SquareMatrix2d am = Algorithms.MakeAdjacencyMatrix(wm);

            return new SquareMatrix2d((im * im.Tranpose()) - (2 * am));
        }

        /// <summary>
        /// Make min spanned tree for undirected weighted graph 
        /// realise of Kruskal's algorithm
        /// http://en.wikipedia.org/wiki/Kruskal%27s_algorithm
        /// </summary>
        /// <param name="m">square matrix of weighted graphs</param>
        /// <returns>square matrix of min spanned tree</returns>
        public static SquareMatrix2d MakeMinSpannedTree(SquareMatrix2d m)
        {
            SquareMatrix2d res = new SquareMatrix2d(m.YSize, 0);

            List<int> vertex = new List<int>();
            for (int i = 0; i < m.YSize; i++) vertex.Add(i);

            List<KeyValuePair<double, KeyValuePair<int, int>>> a;
            a = new List<KeyValuePair<double, KeyValuePair<int, int>>>();
            for (int i = 0; i < m.YSize - 1; i++)
            {
                for (int j = i + 1; j < m.XSize; j++)
                {
                    if (m[j, i] != 0) a.Add(new KeyValuePair<double, KeyValuePair<int,int>> (m[j,i], new KeyValuePair<int, int>(i,j)));
                }
            }
            a.Sort(new SortByLength());

            for (int i = 0; i < a.Count; i++)
            {
                double l = a.ElementAt(i).Key;
                int v1 = a.ElementAt(i).Value.Key; int v2 = a.ElementAt(i).Value.Value;

                if (vertex[v1] != vertex[v2])
                {
                    res[v1, v2] = res[v2, v1] = l;
                    int oldVertex = vertex[v2]; int newVertex = vertex[v1];
                    for (int j = 0; j < vertex.Count; j++)
                    {
                        if (vertex[j] == oldVertex) vertex[j] = newVertex;
                    }
                }
            }
            return res;
        }
    }

    public class SortByLength : IComparer<KeyValuePair<double, KeyValuePair<int, int>>>
    {
        public int Compare(KeyValuePair<double, KeyValuePair<int, int>> a, KeyValuePair<double, KeyValuePair<int, int>> b)
        {
            return a.Key.CompareTo(b.Key);
        }
    }
}
