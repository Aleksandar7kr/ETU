#include "parser.h"
#include <QString>

#include <QDebug>
#include <qmath.h>

double f(double x1,  double x2, double x3,  double x4)
{
    return (x1*x1 - 2*x1*x2 + x2*x2 - 6*x1 - 6);
}

int main()
{
  //  QString test("0 -1-1");
    QString test ("x1+x2+x3");
    QString param("x1=1,x2=1,x3=3,x4=10");
    Parser parser(test.trimmed());
    parser.SetArg(param);
    parser.CalcFunc();
    double a[] = {1,1,3,10};

    parser.f(a,4);
    qDebug() << f(1,1,3,10);

    return 0;
}
