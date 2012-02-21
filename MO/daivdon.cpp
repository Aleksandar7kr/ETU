#include "methods.h"

double CaclZ(double (*f)(nVector),const nVector &arg, const nVector &p, double a, double b)
{
    return derevative(f,arg,p,a)+derevative(f,arg,p,b)+3*(f(arg+p*a)-f(arg+p*b))/(b-a);
}
double CalcW(double (*f)(nVector),const nVector &arg, const nVector &p, double a, double b)
{
    double z=CaclZ(f,arg,p,a,b);
    return sqrt(z*z - derevative(f,arg,p,a)*derevative(f,arg,p,b));
}

double CalcR(double (*f)(nVector),const nVector &arg, const nVector &p, double a, double b)
{
    double z=CaclZ(f,arg,p,a,b);
    double w = CalcW(f,arg,p,a,b);
    return a+(b-a)*(z-derevative(f,arg,p,a)+w)/(derevative(f,arg,p,b)-derevative(f,arg,p,a)+2*w);
}

double CaclZ(double (*f)(const Matrix&),const Matrix &arg, const Matrix &p, double a, double b)
{
    return derevative(f,arg,p,a)+derevative(f,arg,p,b)+3*(f(arg+p*a)-f(arg+p*b))/(b-a);
}
double CalcW(double (*f)(const Matrix&),const Matrix &arg, const Matrix &p, double a, double b)
{
    double z=CaclZ(f,arg,p,a,b);
    return sqrt(z*z - derevative(f,arg,p,a)*derevative(f,arg,p,b));
}

double CalcR(double (*f)(const Matrix&),const Matrix &arg, const Matrix &p, double a, double b)
{
    double z=CaclZ(f,arg,p,a,b);
    double w = CalcW(f,arg,p,a,b);
    return a+(b-a)*(z-derevative(f,arg,p,a)+w)/(derevative(f,arg,p,b)-derevative(f,arg,p,a)+2*w);
}

double CalcZ(double (*y)(double), double a, double b)
{
    return derevative(y,a) + derevative(y,b)+ 3*(y(a)-y(b))/(b-a);
}
double CalcW(double (*y)(double), double a, double b)
{
    double z = CalcZ(y,a,b);
    return sqrt(z*z - derevative(y,a)*derevative(y,b));
}
double CalcR(double (*y)(double), double a, double b)
{
    double z = CalcZ(y,a,b);
    double w = CalcW(y,a,b);
    return a+(b-a)*(z-derevative(y,a)+w)/(derevative(y,b)-derevative(y,a)+2*w);
}

double davidon(double (*f)(double), Interval interval, unsigned iter)
{
    double a = interval.a, b = interval.b;
    double r = CalcR(f,a,b);
    unsigned k = 1;
    double df;
    for ( ; (fabs(df=derevative(f,r)) > myEPS) && (fabs(a-b) > myEPS) && (k < iter) ; ++k)
    {
        (df < 0 ? a:b) = r = CalcR(f,a,b);
    }
    std::cout << " davidon iterations = " << k << std::endl;
    return r;
}

double davidon(double (*f)(nVector), nVector &arg, nVector& p, Interval interval, unsigned iter)
{
    double a = interval.a, b = interval.b;
    double r = CalcR(f,arg,p,a,b);
    unsigned k = 1;
    double df;
    for ( ; (fabs(df=derevative(f,arg,p,r)) > myEPS) && (fabs(a-b) > myEPS) && (k < iter) ; ++k)
    {
        (df < 0 ? a:b) = r ;
        r= CalcR(f,arg,p,a,b);
    }
    std::cout << " davidon iterations = " << k << std::endl;
    return r;
}

double davidon(double (*f)(const Matrix&), const Matrix &arg, Matrix& p, Interval interval, unsigned iter)
{
    double a = interval.a, b = interval.b;
    double r = CalcR(f,arg,p,a,b);
    return r;
    unsigned k = 1;
    double df;
    for ( ; (fabs(df=derevative(f,arg,p,r)) > myEPS) && (fabs(a-b) > myEPS) && (k < iter) ; ++k)
    {
        (df < 0 ? a:b) = r ;
        r= CalcR(f,arg,p,a,b);
    }
    std::cout << " davidon iterations = " << k << std::endl;
    return r;
}

