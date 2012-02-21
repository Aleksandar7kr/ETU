#ifndef METHODS_H
#define METHODS_H

#include <iostream>
#include <vector>
#include <math.h>

#include "nVector.h"
#include "Matrix.h"

using namespace std;

// global additional types, const and methods
struct Interval
{
    double a;
    double b;
};

static double myEPS = 0.000000001;

// swen.cpp
Interval swenn_1(double (*f)(nVector),const nVector &arg,const nVector &p, double x1);
Interval swenn_1(double (*f)(const Matrix&),const Matrix &arg0,const Matrix &p, double alpha);
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
double powell(double (*f)(const Matrix&), const Matrix& x1,const Matrix& p, Interval interval);
Matrix powell(double (*f)(const Matrix&), const Matrix& x1);

// davidon.cpp
double davidon(double (*f)(double), Interval interval, unsigned iter = -1);
double davidon(double (*f)(nVector), nVector &arg, nVector& p, Interval interval, unsigned iter=-1);
double davidon(double (*f)(const Matrix&), const Matrix &arg, Matrix& p, Interval interval, unsigned iter=-1);


// gauss_zeidel.cpp
nVector gauss_seidel(double (*f)(nVector),nVector x1);

// partan.cpp
nVector partan1(double (*f)(nVector), nVector x1);

inline static double derevative(double (*f)(double) ,double x);

inline static double derevative(double (*f)(nVector),const nVector &arg, const nVector& p, double alpha);
inline static double partDer(double (*f)(nVector),const nVector &arg, unsigned n);
inline static nVector grad(double (*f)(nVector), nVector arg);

inline static double derevative(double (*f)(const Matrix&), const Matrix &arg, const Matrix & p, double alpha);
inline static double partDer(double (*f)(const Matrix &), const Matrix& arg, unsigned n);
inline static Matrix grad(double (*f)(const Matrix&),const Matrix& arg);


inline static double derevative(double (*f)(double),double x)
{
    return (f(x+myEPS/2)-f(x-myEPS/2))/myEPS;
}

inline static double derevative(double (*f)(nVector),const nVector &arg, const nVector& p, double alpha)
{
    return (f(arg+p*(alpha+myEPS/2)) - f(arg+p*(alpha-myEPS/2)))/myEPS;
}

inline static double derevative(double (*f)(const Matrix&), const Matrix &arg, const Matrix & p, double alpha)
{
    return (f(arg+p*(alpha+myEPS)) - f(arg+p*(alpha-myEPS)))/(2*myEPS);
}

inline static nVector grad(double (*f)(nVector), nVector arg)
{
    std::vector <double> result;
    for (unsigned i = 0; i < arg.GetSize();++i)
    {
        result.push_back(partDer(f,arg,i));
    }
    return nVector(result);
}

inline static Matrix grad(double (*f)(const Matrix&),const Matrix& arg)
{
    double * result = new double [arg.GetSizeY()];

    for (unsigned i = 0; i < arg.GetSizeX(); ++i)
    {
        result[i] = partDer(f,arg,i);
    }
    return Matrix(result, arg.GetSizeX());

}

inline static double partDer(double (*f)(nVector),const nVector &arg, unsigned n)
{
    nVector EPS(n, myEPS, arg.GetSize());
    return (f(arg+EPS)-f(arg-EPS))/(2*myEPS);
}

inline static double partDer(double (*f)(const Matrix &), const Matrix& arg, unsigned n)
{
    Matrix ortEPS(myEPS, n, arg.GetSizeY());
    return (f(arg+ortEPS) - f(arg-ortEPS))/(2*myEPS);
}

inline static double form1(double (*f)(double),double a,double b, double c)
{
    return 0.5*(f(a)*(b*b-c*c) + f(b)*(c*c-b*b) + f(c)*(a*a-b*b))/(f(a)*(b-c) + f(b)*(c-b) + f(c)*(a-b));
}

inline static double form2(double (*f)(double),double a,double b, double c)
{
    return 0.5*((f(a)-f(b))*(b-c)*(c-a))/(f(a)*(b-c)+f(b)*(c-a)+f(c)*(a-b)) + (a+b)/2;
}

#endif
