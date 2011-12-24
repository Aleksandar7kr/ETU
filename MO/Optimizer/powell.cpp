#include "methods.h"

double form1(Parser parser, const Matrix &x1, const Matrix &p ,double a,double b, double c)
{
    return 0.5*(parser.f(x1+p*a)*(b*b-c*c) + parser.f(x1+p*b)*(c*c-b*b) + parser.f(x1+p*c)*(a*a-b*b))/(parser.f(x1+p*a)*(b-c) + parser.f(x1+p*b)*(c-b) + parser.f(x1+p*c)*(a-b));
}

double form2(Parser parser,const Matrix &x1, const Matrix &p ,double a,double b, double c)
{
    return 0.5*((parser.f(x1+p*a)-parser.f(x1+p*b))*(b-c)*(c-a))/
            (parser.f(x1+p*a)*(b-c)+parser.f(x1+p*b)*(c-a)+parser.f(x1+p*c)*(a-b)) + (a+b)/2;
}


Matrix powell(Parser parser, const Matrix& x0)
{
    qDebug("powell");
    Matrix x1(x0);
    std::vector <Matrix> e;
    for (unsigned i = 0; i < x1.GetSizeY(); i++) e.push_back(Matrix(1.0,i,x1.GetSizeY()));
    unsigned k = 0;
    unsigned it = 0;
    Matrix x2(x1);

    while( k < x0.GetSizeY() +1)
    {
        x1 = x2;
        for (unsigned i = 0; i < x1.GetSizeY(); i++)
        {
            if (x2.norm() < myEPS) return x2;
            double alpha = powell(parser,x2,e.at(i), swenn_1(parser,x2,e.at(i),1));

            x2 += e.at(i)*alpha;
            it++;
        }
        Matrix d(x2-x1);
        x2 += d*powell(parser,x2,d, swenn_1(parser,x2,d,1));

        e[k] = d;
        k++;
    }

    std::cout << "powell min = " << std::endl << x2.t();
    std::cout << "f(min) = " << parser.f(x2) << std::endl;
    std::cout << "iteratration = " << it <<std::endl;
    return x2;
}

double powell(Parser parser, const Matrix& x1,const Matrix& p, Interval interval)
{
    qDebug("powell lin");
    double a = interval.a;
    double c = interval.b;
    double b = (a+c)/2;
    if ( fabs(b-a) < myEPS) return a;
    double d = form1(parser,x1,p,a,b,c);
    unsigned k = 1;


    while( (myEPS <= fabs(d-b)/fabs(b)) && (myEPS <= fabs(parser.f(x1+p*d)-parser.f(x1+p*b))/fabs(parser.f(x1+p*b))) )
    {
        if ( fabs(b-a) < myEPS) return a;
        if ( parser.f(x1+p*b)<parser.f(x1+p*d) )
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
        d = form2(parser,x1,p,a,b,c);
        k++;
    }
    cout << "itertions = " << k << endl;
    return d;
}
