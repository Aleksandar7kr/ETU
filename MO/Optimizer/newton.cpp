#include "methods.h"

Matrix newton(Parser parser, const Matrix& x)
{
    Matrix x0(x);
    Matrix x1(x);
    Matrix p(x);
    unsigned k = 0;
    do
    {
        k++;
        x0 = x1;

        p = -1*hessian(parser,x0).inv()*grad(parser,x0);

        double alpha = powell(parser,x0,p,swenn_1(parser, x0,p,1));
        x1 = x0 + p*alpha;
    }    while(k < 2 && x1.norm() > myEPS);

    qDebug() << "iteration = " << k;
    return x1;
}
