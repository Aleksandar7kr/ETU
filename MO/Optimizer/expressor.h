#ifndef EXPRESSOR_H
#define EXPRESSOR_H

#include <QString>
#include <QMap>

#include <qmath.h>
#include <QtGlobal>
#include <QDebug>
#include <QRegExp>

class expressor
{
public:
    expressor(QString, QString);
private:
    QString ex;        // expression to evaluate
    QString param;     // input parametrs
    QString RPN;       // Reverse Polish Notation

    QMap <QString, double (*)(double arg)> * unFunc;

    bool     toRPN();      // tranlate inpun exptression to RPN;
    unsigned Verify();     // Analyzy input exp and param
};

#endif // EXPRESSOR_H
