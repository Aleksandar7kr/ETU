using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    class Method
    {
        private double a, b;
        private double alpha = 0.0, beta = 0.0;
        private double eps;
        private int k = 0;
        private List<double> x1, x2;
        private List<double> p1, p2;
        private CalculationTree ct;

        public Method(CalculationTree ct, List<double> args, double eps)
        {
            this.ct  = ct;
            x1 = new List<double>(args);
            x2 = new List<double>(x1);
            p1 = new List<double>(x1);
            p2 = new List<double>(x1);
            this.eps = eps;
        }

        public void Rosenbrock()
        {
            List<double> tmp = new List<double>(x1);
            double n = 0;
            while (true)
            {
                for (int i = 0; i < ct.getVar().Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        Grad(p1);
                    }
                    else
                    {
                        Grad(p2);
                        beta = getBeta();
                        setP();
                    }
                }
                alpha = getAlpha();
                dot(alpha);
                setTMP(tmp);
                n = norm(tmp);
                if ((n * n <= eps && ct.getResult(x2) - ct.getResult(x1) <= eps) || k >= 50) return;
                k++;
                x1 = x2.ToList();
            }
        }
              
        private void setP()
        {
            for (int i = 0; i < p1.Count; i++)
            {
                p1[i] = p2[i] + beta * p1[i];
            }
        }

        private void Grad(List<Double> p) 
        { 
            for (int i = 0; i < p.Count; i++)
                p[i] = -ct.getDerevative(x2, eps, i);
        }

        private double getBeta()
        {
            double n2 = norm(x2);
            double n1 = norm(x1);
            return (n2 * n2) / (n1 * n1);
        }

        private void setTMP(List<double> list)
        {
            for (int i = 0; i < x1.Count; i++)
            {
                list[i] = x2[i] - x1[i];
            }
        }

        private void setP(int n)
        {
            for (int i = 0; i < p1.Count; i++)
            {
                if (i == n)
                {
                    p1[i] = ct.getDerevative(x2, eps, i);
                }
                else
                {
                    p1[i] = 0;
                }
            }
        }

        private double norm(List<Double> x) // подсчет нормы вектора
        {
            double tmp = 0D;
            for (int i = 0; i < x.Count; i++)
            {
                tmp += x[i] * x[i];
            }
            return Math.Abs(tmp);
        }

        private void dot(double alpha) // покоординатный спуск в след. точку 
        {
            for (int i = 0; i < x1.Count; i++)
            {
                x2[i] = x1[i] + alpha * p1[i];
            }
        }

        private double df(double alpha) // подсчет численной част производной для метода Свенна
        {
            dot(alpha);
            return ct.getGradient(x2, p1, eps);
        }

        private void swann()
        {
            double h = 0.01;
            double x = alpha;
            double y = x;
            int i = 0;
            if (df(x) > 0) h = -h;

            while (true)
            {
                x += h;
                h *= 2;
                i++;
                double xz = (df(x) * df(y));
                if (xz < 0) break; 
                if (i == 100) break;
            }

            a = x - h;
            b = x;

            if (a > b)
            {
                double tmp = b;
                b = a;
                a = tmp;
            }
        }

        private double boltcano() // метод поиска одномерного минимума
        {
            int i = 0;
            double x = 0;
            double a = this.a, b = this.b;
            while (true)
            {
                x = (a + b) / 2;
                if (Math.Abs(df(x)) <= eps && Math.Abs(b - a) <= eps) break;
                if (df(x) > 0) b = x;
                else a = x;
                if (i >= 300) return x;
                i++;
            }
            return x;
        }

        private double getAlpha()
        {
            swann();
            double alpha = boltcano();
            return alpha;
        }

        public List<Double> getRes()
        {   
            return x2;
        }

        public int getK()
        {
            return k;
        }
    }
}
