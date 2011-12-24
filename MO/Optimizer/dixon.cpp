#include "methods.h"

double getScalarPr(const Matrix& a,const Matrix& b)
{
    double res = 0;
    for (unsigned i = 0; i < a.GetSizeX(); i++)
    {
        res += a.at(0,i)+b.at(0,i);
    }
    return res;
}

Matrix dixon(Parser parser, const Matrix& x)
{
    Matrix x0(x);
    Matrix x1(x);
    Matrix p(x);
    unsigned k = 0;
    do
    {
        k++;
        x0 = x1;
        if (k == 1)
        {
            p = -1*grad(parser, x0);
        }
        else
        {
            double beta = -pow(grad(parser,x0).norm(),2)/getScalarPr(p,-p);
            p = -1*grad(parser, x0) + beta*p;
        }
        double alpha = powell(parser,x0,p,swenn_1(parser, x0,p,1));
        x1 = x0 + p*alpha;
    }    while(k < 100 && grad(parser,x0).norm() > myEPS && myEPS && fabs(parser.f(x0)-parser.f(x1))>myEPS);

    qDebug() << "iteration = " << k;
    return x1;
}
