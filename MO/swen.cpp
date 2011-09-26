#include "header.h"

void swen_method_1(double (*f)(double), double x1, double &a, double &b)
{
    double h = 0.01;
    double x2 = x1 + h;
    double f1 = f(x1);
    double f2 = f(x2);

    if (f2 > f1)
    {
        h = -h; x2 = x1 + h;
        f2 = f(x2);
    }

    while(f2 < f1)
    {
        h = 2*h;
        a = x1;
        x1 = x2; x2 = x1 + h;
        f1 = f2; f2 = f(x2);
    }

    if (a > x2)
    {
        b = a; a = x2;
    }
    else
    {
        b = x2;
    }
}
