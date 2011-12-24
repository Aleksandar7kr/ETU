#include "expressor.h"

double abs(double arg)
{
    return (arg > 0 ? arg : -arg);
}

unsigned CheckGrammar()
{
    QString str = "x11+x3-y6*yy5/cos(H6777-54 - 44.33)";
    unsigned pos = 0;
    QRegExp exp("[a-z]{1,1}\\d+|\\(|\\d+|\\d+\.\\d+|cos\\(|sin\\(|tg\\(");
    qDebug() << exp.indexIn(str);
}

expressor::expressor(QString _ex, QString _param): ex(_ex), param(_param)
{
    unFunc = new  QMap <QString, double (*)(double)>();
    unFunc->insert("cos", qCos);
    unFunc->insert("sin", qSin);
    unFunc->insert("tan", qTan);

    unFunc->insert("acos", qAcos);
    unFunc->insert("asin", qAsin);
    unFunc->insert("atan", qAtan);

    unFunc->insert("ln"  , qLn);
    unFunc->insert("sqrt", qSqrt);
    unFunc->insert("exp" , qExp);
    unFunc->insert("abs",  abs);

    CheckGrammar();
  //  QString str = "x11+x3-y6*yy5/cos(H6777-54 - 44.33)";
    str.replace(QRegExp("(([a-z]|[A-Z]){1,1}\\d+)|(\\d+)|(\\d*\\.\\d+)"),QString("@"));
  //  qDebug() << str;
}

unsigned expressor::Verify()
{
    return 0;
}
