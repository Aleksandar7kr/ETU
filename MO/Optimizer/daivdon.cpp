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

double CaclZ(Parser parser,const Matrix &arg, const Matrix &p, double a, double b)
{
    return derevative(parser,arg,p,a)+derevative(parser,arg,p,b)+3*(parser.f(arg+p*a)-parser.f(arg+p*b))/(b-a);
}
double CalcW(Parser parser,const Matrix &arg, const Matrix &p, double a, double b)
{
    double z=CaclZ(parser,arg,p,a,b);
    return sqrt(z*z - derevative(parser,arg,p,a)*derevative(parser,arg,p,b));
}

double CalcR(Parser parser,const Matrix &arg, const Matrix &p, double a, double b)
{
    double z=CaclZ(parser,arg,p,a,b);
    double w = CalcW(parser,arg,p,a,b);

    double res =  (b-a)*(z-derevative(parser,arg,p,a)+w);
    double res1 = (derevative(parser,arg,p,b)-derevative(parser,arg,p,a)+2*w);
    res  = (res  > 1e-305) ? res  : 1e-305;
    res1 = (res1 > 1e-305) ? res1 : 1e-305;
    qDebug() << "res " << res << "res1" << res1;

    return  a +res/res1;
}

double CalcZ(double (*y)(double), double a, double b)
{
    return derevative(y,a) + derevative(y,b)+ 3*(y(a)-y(b))/(b-a);
}
double CalcW(double (*y)(double), double a, double b)
{
    double z = CalcZ(y,a,b);
    return sqrt(fabs(z*z - derevative(y,a)*derevative(y,b)));
}
double CalcR(double (*y)(double), double a, double b)
{
    double z = CalcZ(y,a,b);
    double w = CalcW(y,a,b);
    double res =  a+(b-a)*(z-derevative(y,a)+w)/(derevative(y,b)-derevative(y,a)+2*w + myEPS);
    qDebug() << "res " << res;
    return res;
}

double davidon(double (*f)(double), Interval interval, unsigned iter)
{
    qDebug("davinon");
    double a = interval.a, b = interval.b;
    if (fabs(b-a) < myEPS) return a;
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

double davidon(Parser parser, const Matrix &arg, Matrix& p, Interval interval, unsigned iter)
{
    qDebug("davidon");
    double a = interval.a, b = interval.b;
    if (fabs(b-a) < myEPS) return (a+b)/2;

    double r = CalcR(parser,arg,p,a,b);
    return r;
    unsigned k = 1;
    double df;
    for ( ; (fabs(df=derevative(parser,arg,p,r)) > myEPS) && (fabs(a-b) > myEPS) && (k < iter) ; ++k)
    {
        (df < 0 ? a:b) = r ;
        r= CalcR(parser,arg,p,a,b);
    }
    std::cout << " davidon iterations = " << k << std::endl;
    return r;
}

