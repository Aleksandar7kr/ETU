#include "functions.h"

double parabola(double x)
{
    return x*x;
}

// lab #1 variant 4
double f1_4(double x)
{
    return x*x*x*x-14*x*x*x+60*x*x-70*x;
};
// lab #2 variant 4 // function 5 lab #1
double f2_4(double x)
{
    return x >= 0 ? 4*x*x*x - 3*x*x*x*x : 4*x*x*x + 3*x*x*x*x;
}

double f1_7(double x)
{
return 2*x*x + 16/x;
}

double ff(double x)
{
    return x*x*x*x;
}

double f3_13(double x1,double x2)
{
    return pow(x1-2,4)+pow(x1-2*x2,2);
}

