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
