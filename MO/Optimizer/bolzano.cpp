#include "methods.h"

double bolzano(double (*f)(double), Interval interval)
{
    double a   = interval.a;
    double b   = interval.b;
    double x   = (a+b)/2;
    size_t k   = 0;
    double df  = derevative(f,x);

    for( ; !((df < myEPS) && (fabs(b-a)) < myEPS); ++k)
    {
        (df > 0 ? b:a) = x;
         x=(a+b)/2, df=derevative(f,x);
    }
    cout << "itertions = " << k << endl;
    return x;
}

double bolzano(Parser f, const Matrix &x0 , const Matrix &p, Interval interval)
{
    double a   = interval.a;
    double b   = interval.b;
    double x   = (a+b)/2;
    size_t k   = 0;
    double df  = derevative(f,x0+x*p,p,1);

    for( ; !((df < myEPS) && (fabs(b-a)) < myEPS); ++k)
    {
        (df > 0 ? b:a) = x;
         x=(a+b)/2, df=derevative(f,x0+x*p,p,1);
    }
    cout << "itertions = " << k << endl;
    return x;
}
