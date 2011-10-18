#include <iostream>
#include <vector>
#include <math.h>

#include "nVector.h"

using namespace std;

// global additional types, const and methods
struct Interval
{
    double a;
    double b;
};

static double myEPS = 0.0000001;

// swen.cpp
Interval swenn_1(double (*f)(double), double x1);
Interval swenn_2(double (*f)(double), double x1);

// gold.cpp
double gold_ratio_1(double (*f)(double), Interval interval);
double gold_ratio_2(double (*f)(double), Interval interval);

// fibonacci.cpp
double fibonacci_1(double (*f)(double), Interval interval);
double fibonacci_2(double (*f)(double), Interval interval);

// bolzano.cpp
double bolzano(double (*f)(double), Interval interval);

// powell.cpp
double powell(double (*f)(double), Interval interval);


static double derevative(double (*f)(double),double x)
{
    return (f(x+myEPS/2)-f(x-myEPS/2))/myEPS;
}




static double form1(double (*f)(double),double a,double b, double c)
{
    return 0.5*(f(a)*(b*b-c*c) + f(b)*(c*c-b*b) + f(c)*(a*a-b*b))/(f(a)*(b-c) + f(b)*(c-b) + f(c)*(a-b));
}

static double form2(double (*f)(double),double a,double b, double c)
{
    return 0.5*((f(a)-f(b))*(b-c)*(c-a))/(f(a)*(b-c)+f(b)*(c-a)+f(c)*(a-b)) + (a+b)/2;
}
