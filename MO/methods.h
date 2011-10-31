#ifndef METHODS_H
#define METHODS_H

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

static double myEPS = 0.000001;

// swen.cpp
Interval swenn_1(double (*f)(nVector),const nVector &arg,const nVector &p, double x1);
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

// davidon.cpp
double davidon(double (*f)(double), Interval interval, unsigned iter = -1);


static double derevative(double (*f)(double) ,double x);
static double derevative(double (*f)(nVector),const nVector &arg, const nVector& p, double alpha);
static double partDer(double (*f)(nVector), nVector arg, unsigned n);
static nVector grad(double (*f)(nVector), nVector arg);

static double derevative(double (*f)(double),double x)
{
    return (f(x+myEPS/2)-f(x-myEPS/2))/myEPS;
}

static double derevative(double (*f)(nVector),const nVector &arg, const nVector& p, double alpha)
{
    return (f(arg+p*(alpha+myEPS/2)) - f(arg+p*(alpha-myEPS/2)));
}

static nVector grad(double (*f)(nVector), nVector arg)
{
    std::vector <double> result;
    for (unsigned i = 0; i < arg.GetSize();++i)
    {
        result.push_back(partDer(f,arg,i));
    }
    return nVector(result);
}

static double partDer(double (*f)(nVector), nVector arg, unsigned n)
{
    vector <double> eps;
    for (unsigned i = 0; i < arg.GetSize(); ++i)
    {
         eps.push_back(i == n ? myEPS:0);
    }
    nVector EPS(eps);
    return (f(arg+EPS)-f(arg-EPS))/myEPS;
}


static double form1(double (*f)(double),double a,double b, double c)
{
    return 0.5*(f(a)*(b*b-c*c) + f(b)*(c*c-b*b) + f(c)*(a*a-b*b))/(f(a)*(b-c) + f(b)*(c-b) + f(c)*(a-b));
}

static double form2(double (*f)(double),double a,double b, double c)
{
    return 0.5*((f(a)-f(b))*(b-c)*(c-a))/(f(a)*(b-c)+f(b)*(c-a)+f(c)*(a-b)) + (a+b)/2;
}

#endif
