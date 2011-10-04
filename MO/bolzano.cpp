#include "methods.h"

double bolzano(double (*f)(double), Interval interval)
{
    double a   = interval.a;
    double b   = interval.b;
    double eps = myEPS;
    double x   = (a+b)/2;
    size_t k   = 0;
    double df  = derevative(f,x);

    for(; !((df < eps) && (fabs(b-a)) < eps);)
    {
        if (df > 0)
        {
            b = x;
        }
        else
        {
            a = x;
        }
         x=(a+b)/2, k++, df=derevative(f,x);
    }
    cout << "itertions = " << k << endl;
    return x;
}
