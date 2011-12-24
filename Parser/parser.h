#ifndef PARSER_H
#define PARSER_H

#include <QString>
#include <QStringList>
#include <QStack>
#include <QMap>

#include <QRegExp>

#include <qmath.h>

#include <qdebug.h>

class Parser
{
public:
    Parser(QString);

    void SetArg(QString);
    double CalcFunc();
    double f(double * x, unsigned sz);

private:
    QMap <QString, double> arg;
    QMap <QString, int> priority;
    QString sourceStr;
    QString rpnStr;
    QString argStr;

    void RPN();



};

#endif // PARSER_H
