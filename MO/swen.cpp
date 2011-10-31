#include "methods.h"
#include <iostream>
#include <math.h>

Interval swenn_1(double (*f)(nVector),const nVector &arg0,const nVector &p, double alpha)
{
    double x1 = alpha;
    double h = (x1 ? 0.001*fabs(x1) : 0.001);
    double x2 = x1 + h;
    double f1 = f(arg0+p*x1);
    double f2 = f(arg0+p*x2);
    Interval i;
    unsigned k = 0;

    if (f2 > f1)
    {
        h = -h; x2 = x1 + h;
        f2 = f(arg0+p*x2);
    }
    while(f2 < f1)
    {
        h = 2*h;
        i.a = x1;
        x1 = x2; x2 = x1 + h;
        f1 = f2; f2 = f(arg0+p*x2);
        k++;
    }

    if (i.a > x2)
    {
        i.b = i.a; i.a = x2;
    }
    else
    {
        i.b = x2;
    }
    //std::cout << k << std::endl;
    return i;


}

Interval swenn_1(double (*f)(double), double x1)
{
    double h = (x1 ? 0.001*fabs(x1) : 0.001);
    double x2 = x1 + h;
    double f1 = f(x1);
    double f2 = f(x2);
    Interval i;

    unsigned k = 0;

    if (f2 > f1)
    {
        h = -h; x2 = x1 + h;
        f2 = f(x2);
    }

    while(f2 < f1)
    {
        h = 2*h;
        i.a = x1;
        x1 = x2; x2 = x1 + h;
        f1 = f2; f2 = f(x2);
        k++;
    }

    if (i.a > x2)
    {
        i.b = i.a; i.a = x2;
    }
    else
    {
        i.b = x2;
    }
    //std::cout << k << std::endl;
    return i;
}

Interval swenn_2(double (*f)(double),double x1)
{
    double h = 0.001*fabs(x1);
    double x2 = x1 + h;
    double df1 = derevative(f,x1);
    double df2 = derevative(f,x2);

    if  (df2 > df1)
    {
        h = -h;
        x2 = x1 + h;
    }

    while ( df1*df2 > 0)
    {
        h *= 2;
        x1 = x2;
        df1 = df2;
        x2 = x1+h;
        df2 = derevative(f,x2);
    }
    Interval i;
    i.a = x1;
    i.b = x2;

    if (i.a > x2)
    {
        i.b = i.a; i.a = x2;
    }
    else
    {
        i.b = x2;
    }
    //std::cout << k << std::endl;
    return i;

}

