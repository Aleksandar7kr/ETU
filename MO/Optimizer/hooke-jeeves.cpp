#include "methods.h"

Matrix research(Parser parser, const Matrix &x, double &h)
{
    double y_min = parser.f(x);
    Matrix x_min(x);
    for (unsigned i = 0; i < x.GetSizeY(); i++)
    {
        Matrix dh(h,i,x.GetSizeY());
        if ( parser.f(x+dh) < y_min)
        {
            y_min = parser.f(x+dh);
            x_min = (x+dh);
        }
        if ( parser.f(x-dh) < y_min)
        {
            y_min = parser.f(x-dh);
            x_min = (x-dh);
        }
    }
    qDebug() << "fx = " << parser.f(x) << " fx_min = " << parser.f(x_min);
    return x_min;
}


Matrix hooke_jeeves(Parser parser, const Matrix &x0)
{
    double beta = 10;
    double h = 0.1;
    Matrix x1(x0);
    unsigned k = 0;

    Matrix x2(x0);
    Matrix x3(x0);
    Matrix x4(x0);

    while (h > myEPS)
    {
        x2 = research(parser,x1,h);
        while ( !(x2-x1).norm() && h > myEPS)
        {
            h /= beta;
            research(parser, x1,h);
        }
        x3 = 2*x2 - x1;
        x1 = x2;
        x4 = research(parser, x3,h);
        if ( parser.f(x4) < parser.f(x2) )
        {
            x2 = x4;
            while (parser.f(x4) < parser.f(x1))
            {
                x4 = 2*x4 - x1;
                x1 = x2;
                x2 = x4;
            }
        }
        k++;
    }
    qDebug() << "hooke-jeeves iterations = " << k;
    return x1;
}
