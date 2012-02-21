#include "methods.h"

nVector gauss_seidel(double (*f)(nVector),nVector x1)
{
    unsigned k = 0;
    unsigned j = 0;
    unsigned sizeN= x1.GetSize();
    double alpha = 1;
    nVector p(x1);
    nVector x2(x1);
    Interval interval;
    std::vector<nVector> e;
    for (unsigned i = 0; i < sizeN; i++) e.push_back(nVector(i,1,sizeN));

    do
    {
        x1 = x2;
        p = e[j%sizeN]*-partDer(f, x1, j%sizeN);
        interval = swenn_1(f,x1,p,1);
        alpha = davidon(f,x1,p,interval,1);
        x2 = x1 + p*alpha;
        //cout << "p = " << "[ " << p[0] << " " << p[1] << " " << p[2] << "]"<<endl;
        k++;j++;
    }
    while ( ( (x2-x1).GetNorm() > myEPS ) && fabs( f(x2)-f(x1))> myEPS);
    cout << "minimum = [ ";
    for (unsigned i =0; i < sizeN; i++)
    {
        cout << x2[i] << " ";
    }
    cout << "]" << endl;
    cout << "f(minimum) = " << f(x2);
    return x2;
}
