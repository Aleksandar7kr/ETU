#include "methods.h"

double powell(double (*f)(double), Interval interval)
{
    double a = interval.a;
    double c = interval.b;
    double b = (a+c)/2;
    double d = form1(f,a,b,c);
    unsigned k = 1;

    while( (myEPS <= fabs(d-b)/fabs(b)) && (myEPS <= fabs(f(d)-f(b))/fabs(f(b))) )
    {
        if ( f(b)<f(d) )
        {
            if (b<d) c=d;
            else     a=d; // b = b;
        }
        else
        {
            if (b<d) a=b;
            else     c=b;
            b=d;
        }
        d = form2(f,a,b,c);
        k++;
    }
    cout << "itertions = " << k << endl;
    return d;
}
