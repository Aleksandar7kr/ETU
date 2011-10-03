#include "methods.h"



size_t GetN(double L1, double Ln, vector <double>& fib)
{
    double L = L1/Ln;
    short unsigned int N = 1;
    fib.push_back(0);
    fib.push_back(1);

    while ( fib[N] <  L)
    {
        fib.push_back( fib[N] + fib[N-1] );
        N++;
    }
    return N;
}

double fibonacci_1(double (*f)(double), Interval interval)
{
    vector <double> fib;
    double a = interval.a;
    double b = interval.b;
    double L = fabs(b-a);
    size_t n = GetN(L, 0.000001, fib);
    size_t k = 0;
    double eps = L/(fib[n-1]+fib[n]);
    double la,mu;
    double f_la, f_mu;

    la = a + fib[n-2]/fib[n]*L; f_la = f(la);
    mu = a + fib[n-1]/fib[n]*L; f_mu = f(mu);

    while(k != n-1)
    {
        if ( f_la < f_mu )
        {
            b  = mu; mu = la;
            la = a + fib[n-k-2]/fib[n-k]*fabs(b-a);
            f_mu = f_la; f_la = f(la);
        }
        else
        {
            a  = la; la = mu;
            mu = a + fib[n-k-1]/fib[n-k]*fabs(b-a);
            f_la = f_mu; f_mu = f(mu);
        }
        ++k;
    }
    mu = la + eps; f_mu = f(mu);
    cout << "itertions = " << k << endl;

    return f_la < f_mu ? (a+mu)/2 : (la+b)/2;
}

double fibonacci_2(double (*f)(double), Interval interval)
{
    vector <double> fib;
    double a = interval.a;
    double b = interval.b;
    double L = fabs(b-a);
    size_t n = GetN(L, 0.000001, fib);
    size_t k = 0;
    double eps = L/(fib[n-1]+fib[n]);

    double f1, f2;

    double L2 = fib[n-1]/fib[n]*L + pow(-1,n)/fib[n]*eps;

    double x1 = a + L2; f1 = f(x1);
    double x2 = b - L2; f2 = f(x2);

    while (k != n)
    {
        if (f1 < f2)
        {
            if (x1 < x2)
            {
                b = x2; x2 ; f2 = f(x2);
            }
            else
            {
                a = x2; x2 ; f2 = f(x2);
            }
        }
        else
        {
            if (x1 < x2)
            {
                a = x1; x1 ; f1 = f(x1);
            }
            else
            {
                b = x1; x1 ; f1 = f(x1);
            }
        }
        cout << " x1= " << x1 << " x2= " << x2 << endl;
        ++k;
    }
    cout << "itertions = " << k << endl;
    return x1;

}
