#include "methods.h"

double form1(double (*f)(const Matrix&), const Matrix &x1, const Matrix &p ,double a,double b, double c)
{
    return 0.5*(f(x1+p*a)*(b*b-c*c) + f(x1+p*b)*(c*c-b*b) + f(x1+p*c)*(a*a-b*b))/(f(x1+p*a)*(b-c) + f(x1+p*b)*(c-b) + f(x1+p*c)*(a-b));
}

double form2(double (*f)(const Matrix&),const Matrix &x1, const Matrix &p ,double a,double b, double c)
{
    return 0.5*((f(x1+p*a)-f(x1+p*b))*(b-c)*(c-a))/(f(x1+p*a)*(b-c)+f(x1+p*b)*(c-a)+f(x1+p*c)*(a-b)) + (a+b)/2;
}

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

double powell(double (*f)(const Matrix&), const Matrix& x1,const Matrix& p, Interval interval)
{
    double a = interval.a;
    double c = interval.b;
    double b = (a+c)/2;
    double d = form1(f,x1,p,a,b,c);
    unsigned k = 1;

    while( (myEPS <= fabs(d-b)/fabs(b)) && (myEPS <= fabs(f(x1+p*d)-f(x1+p*b))/fabs(f(x1+p*b))) )
    {
        if ( f(x1+p*b)<f(x1+p*d) )
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
        d = form2(f,x1,p,a,b,c);
        k++;
    }
    //  cout << "itertions = " << k << endl;
    return d;
}

Matrix powell(double (*f)(const Matrix&), const Matrix& x0)
{
    Matrix x1(x0);
    std::vector <Matrix> e;
    for (unsigned i = 0; i < x1.GetSizeY(); i++) e.push_back(Matrix(1.0,i,x1.GetSizeY()));
    unsigned k = 0;
    unsigned it = 0;
    Matrix x2(x1);

    while( k < x0.GetSizeY() +1)//&& grad(f,x2).norm() > myEPS)
    {
        x1 = x2;
        for (unsigned i = 0; i < x1.GetSizeY(); ++i)
        {
            x2 += e.at(i)*davidon(f,x2,e.at(i), swenn_1(f,x2,e.at(i),1));
            it++;
        }
        Matrix d(x2-x1);
        x2 += d*davidon(f,x2,d, swenn_1(f,x2,d,1));

        e[k] = d;
        k++;
    }

    std::cout << "powell min = " << std::endl << x2.t();
    std::cout << "f(min) = " << f(x2) << std::endl;
    std::cout << "iteratration = " << it <<std::endl;
    return x2;
}
