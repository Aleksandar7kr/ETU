// for debug
#include <iostream>
#include <vector>
#include <math.h>
using namespace std;


// global additional types and methods
struct Interval
{
    double a;
    double b;
};

// swen.cpp
Interval swenn_1(double (*f)(double), double x1);

// gold.cpp
double gold_ratio_2(double (*f)(double), Interval interval);

// fibonacci.cpp
double fibonacci_1(double (*f)(double), Interval interval);
double fibonacci_2(double (*f)(double), Interval interval);


