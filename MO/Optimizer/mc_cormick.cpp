#include "methods.h"

Matrix gamma( Parser parser, const Matrix &a,const Matrix &b)
{
    return grad(parser,b)-grad(parser,a);
}

Matrix S(const Matrix &A,const Matrix &b)
{
    return A.t()*b;
}

double scalar(const Matrix & a)
{
    return a.at(0,0);
}

Matrix Ak(Parser parser, const Matrix &x0, const Matrix &x1, const Matrix &A0)
{
    return A0+ (x1-x0)*(x1-x0).t()/scalar((x1-x0).t()*gamma(parser,x0,x1))
            - (S(A0,gamma(parser,x0,x1))*(x1-x0).t())/scalar((x0-x1).t()*gamma(parser,x0,x1));
}

Matrix mc_cormick(Parser parser, const Matrix &x)
{
    Matrix x0(x);
    Matrix x1(x0+myEPS*x0);
    Matrix A0(x0.GetSizeY(), x0.GetSizeY());
    Matrix A1(x0.GetSizeY(), x0.GetSizeY());
    int i = 0;
    do
    {
        Matrix p(x0);
        A1 = Ak(parser, x0, x1, A0);
        p = -A1*grad(parser,x1);
        x1 = x0 + davidon(parser,x1,p, swenn_1(parser,x1,p,1))*p;
        i++;
        x0 = x1;
        A0 = A1;
    }
    while (x1.norm() > myEPS && i < 50);
    return x1;
}
