#include "methods.h"

double GetSigma(Parser parser, QVector <Matrix> &X)
{
    double y_mead = 0;
    for (int i = 0; i < X.size(); i++)
    {
        y_mead += parser.f(X[i]);
    }
    y_mead /= X.size();

    double sigma = 0;
    for (int i = 0; i < X.size(); i++)
    {
        sigma += (parser.f(X[i]) - y_mead)*(parser.f(X[i]) - y_mead);
    }
    sigma /= X.size();
    sigma = qSqrt(sigma);
    qDebug() << "sigma = " << sigma;
    return sigma;
}

void compaction(Parser parser, QVector <Matrix> &X, Matrix &xr, Matrix &x0)
{
    unsigned n = xr.GetSizeY();
    Matrix x_beta(xr);
    x_beta = x_beta = x0 + 1/2*(X[n] - x0);
    if ( parser.f(x_beta) < parser.f(xr))
    {
        X[n] = x_beta;
    }
    else
    {
        x_beta = x0 + 1/2*(X[n] - x0);
        if (parser.f(x_beta) < parser.f(xr))
        {
            X[n] = x_beta;
        }

        else
        {
            for (unsigned i = 1; i < n+1; i++)
            {
                X[i] = (X[0]+X[i])/2;
            }
        }
    }
}

Matrix nelder_mead(Parser parser, const Matrix &x)
{
    unsigned n = x.GetSizeY();
    unsigned M = 1.65 * n + 0.05*n*n;
    unsigned k = 0;
    double h = 0.1;

    double beta = 1/2;
    double gamma = 2;


    QVector <Matrix> X;
    QVector <double> fx;
    fx.push_back(parser.f(x));
    X.push_back(Matrix(x));
    for (unsigned i = 0; i < n; i++)
    {
        Matrix ort(h,i,n);
        X.push_back(Matrix(x+ort));
        fx.push_back(parser.f(x+ort));
    }

    double sigma = GetSigma(parser, X);

    while (sigma > myEPS)
    {
        k++;
        QVector <double> fx;
        for (unsigned i = 0; i < n+1; i++)
        {
            for (unsigned j = 0; j < n+1; j++)
            {
                if (parser.f(X.at(j)) >  parser.f(X.at(i)))
                {
                    Matrix temp(X.at(i));
                    X[i] = X[j]; X[j] = temp;
                }
            }
        }
        for (unsigned i = 0; i < n+1; i++)
        {
            fx.push_back(parser.f(X[i]));
        }

        Matrix x0(x);
        for (unsigned i = 0; i < n; i++) x0 += X[i];
        x0 /= n;

        Matrix xr(x);
        xr = 2*x0 - X.at(n);

        Matrix x_beta(x);
        Matrix x_gamma(x);

        if (parser.f(xr) <= parser.f(X[0]))
        {
            x_gamma = 3*x0 - 2*X.at(n);
            X[n] = (parser.f(x_gamma) < parser.f(xr)) ? x_gamma : xr; GetSigma(parser, X);
            continue;
        }
        if (parser.f(xr) > parser.f(X[0]) && parser.f(xr) < parser.f(X[n-1]))
        {
            X[n] = xr; GetSigma(parser, X);
            compaction(parser, X, xr, x0);     GetSigma(parser, X); continue;
        }
        if (parser.f(xr) > parser.f(X[n-1]) && parser.f(xr) < parser.f(X[n]))
        {
            Matrix temp(X[n]); X[n] = xr; xr = temp;
            compaction(parser, X, xr, x0);
                GetSigma(parser, X); continue;
        }
        if (parser.f(xr) >= parser.f(X[n]))
        {
            compaction(parser, X, xr, x0); continue;
        }
    }
    return X[0];
}
