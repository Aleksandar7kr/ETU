#include "methods.h"
#include <iostream>
#include <math.h>

Interval swenn_1(double (*f)(double), double x1)
{
    double h = 0.001*fabs(x1);
    double x2 = x1 + h;
    double f1 = f(x1);
    double f2 = f(x2);
    Interval i;

    int k = 0;

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
