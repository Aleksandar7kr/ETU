#include "methods.h"

nVector partan1(double (*f)(nVector), nVector x1)
{
    nVector x2(x1);
    nVector x3(x1);
    nVector p (x1);
    unsigned k = 1;
    double alpha = 1;
    Interval interval;

        p = grad(f,x1)*(-1);
        interval  = swenn_1(f,x1,p,1);
        alpha  = davidon(f,x1,p,interval,1);
        x2 = x1 + p*alpha;
        p = grad(f,x2)*(-1);
    do
    {
        interval  = swenn_1(f,x2,p,1);
        alpha  = davidon(f,x2,p,interval,1);
        x3 = x2+p*alpha;
        p  = x3-x1;
        x1 = x2;
        x2 = x3+p*alpha;
        k++;
    }
    while ( p.GetNorm() > myEPS);

    cout << "minimum = [ ";
    for (unsigned i =0; i < x1.GetSize(); i++) cout << x2[i] << " ";
    cout << "]" << endl;
    cout << "f(minimum) = " << f(x2) << endl;
    cout << "iterations = " << k << endl;

    return x2;
}
