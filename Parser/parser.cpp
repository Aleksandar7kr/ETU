#include "parser.h"

Parser::Parser(QString input): sourceStr(input)
{
    RPN();
}

void Parser::RPN()
{
    if (sourceStr.at(0) == '-') sourceStr = "0"+sourceStr;
    sourceStr.replace("(-","(0-");
    sourceStr.replace("( -","(0-");
    sourceStr.replace("+"," + ");
    sourceStr.replace("-"," - ");
    sourceStr.replace("*"," * ");
    sourceStr.replace("/"," / ");
    sourceStr.replace("^"," ^ ");
    sourceStr.replace(")"," ) ");
    sourceStr.replace("("," ( ");
    QStringList tokens;
    QStringList op;
    op << "+" << "-" << "*" << "/" << "^";

    QStack <QString> stack;
    rpnStr = "";
    tokens = sourceStr.split(QRegExp("\\s+"));

    qDebug() << "tokens: " << tokens;

    for (int it = 0; it < tokens.size(); ++it)
    {
        qDebug() << "rpnStr: " << rpnStr ;
        if ((tokens.at(it).at(0) >='0' && tokens.at(it).at(0) <='9')
                ||
                (tokens.at(it).at(0) >='a' && tokens.at(it).at(0) <='z') )
        {
            rpnStr += tokens.at(it); rpnStr += " "; continue;
        }
        if (tokens.at(it) == "(")
        {
            stack.push(tokens.at(it)); continue;
        }
        if (tokens.at(it) == ")")
        {
            while (stack.top() != "(")
            {
                rpnStr += stack.pop(); rpnStr += " ";
            }
            stack.pop(); continue;
        }
        if (op.indexOf(tokens.at(it)) >= 0)
        {
            if (tokens.at(it) == "^")
            {
                stack.push(tokens.at(it)); continue;
            }
            if (tokens.at(it) == "*" || tokens.at(it) == "/")
            {
                if (!stack.isEmpty())
                {
                    while(!stack.isEmpty() && (stack.top() == "^") )
                    {
                        rpnStr += stack.pop(); rpnStr += " ";
                    }
                }
                stack.push(tokens.at(it)); continue;
            }
            if (tokens.at(it) == "+" || tokens.at(it) == "-")
            {
                if (!stack.isEmpty())
                {
                    while(!stack.isEmpty() && (stack.top() == "^" || stack.top() == "/" || stack.top() == "*" || stack.top() == "+" || stack.top() == "-"))
                    {
                        rpnStr += stack.pop(); rpnStr += " ";
                    }
                }
                stack.push(tokens.at(it)); continue;
            }
        }
    }
    while (!stack.empty())
    {
        rpnStr += stack.pop(); rpnStr += " ";
    }
    qDebug() << "rpnStr: " << rpnStr ;
    qDebug() << "source: " << sourceStr;
}

void Parser::SetArg(QString args)
{
    argStr = args;
    QStringList argList;
    QStringList curArg;
    argList = argStr.split(",");

    for(int i = 0; i < argList.size(); ++i)
    {
        curArg = argList.at(i).split("=");
        double a = (curArg.at(1).at(0) != '-') ? curArg.at(1).toDouble() : -curArg.at(1).split("-").at(0).toDouble();
        arg.insert(curArg.at(0).trimmed(), a);
    }
    qDebug() << "argList" << argList;
    qDebug() << "argMap" << arg;

}

double Parser::CalcFunc()
{
    QStringList tokens;
    tokens = rpnStr.split(QRegExp("\\s+"));
    QStack <double> stack;

    for (int it = 0; it < tokens.size(); ++it)
    {
        qDebug() << stack;
        if ( (tokens.at(it).at(0) >= '0' && tokens.at(it).at(0) <= '9'))
        {
            stack.push(tokens.at(it).toDouble()); continue;
        }
        if ( tokens.at(it).at(0) >= 'a' && tokens.at(it).at(0) <= 'z')
        {
            stack.push(arg.value(tokens.at(it))); continue;
        }
        if ( tokens.at(it) == "+")
        {
            double a = stack.pop();
            double b = stack.pop();
            stack.push(a+b);
        }
        if ( tokens.at(it) == "-")
        {
            double a = stack.pop();
            double b = stack.pop();
            stack.push(-a+b);
        }
        if ( tokens.at(it) == "*")
        {
            double a = stack.pop();
            double b = stack.pop();
            stack.push(a*b);
        }
        if ( tokens.at(it) == "/")
        {
            double a = stack.pop();
            double b = stack.pop();
            stack.push(b/a);
        }
        if ( tokens.at(it) == "^")
        {
            double a = stack.pop();
            double b = stack.pop();
            stack.push(qPow(b,a));
        }
    }
    qDebug() << stack.top();
    return stack.pop();
}

double Parser::f(double * a, unsigned sz)
{
    QStringList tokens;
    tokens = rpnStr.split(QRegExp("\\s+"));
    QStack <double> stack;

    for (int it = 0; it < tokens.size(); ++it)
    {
        qDebug() << stack;
        if ( (tokens.at(it).at(0) >= '0' && tokens.at(it).at(0) <= '9'))
        {
            stack.push(tokens.at(it).toDouble()); continue;
        }
        if ( tokens.at(it).at(0) >= 'a' && tokens.at(it).at(0) <= 'z')
        {
            QMap<QString, double>::iterator i = arg.begin();
            unsigned j = 0;
            while (i != arg.end())
            {
                if (i.key() == tokens.at(it))
                    stack.push(a[j]);
                j++;
                ++i;
            }
            continue;
        }
        if ( tokens.at(it) == "+")
        {
            double a = stack.pop();
            double b = stack.pop();
            stack.push(a+b);
        }
        if ( tokens.at(it) == "-")
        {
            double a = stack.pop();
            double b = stack.pop();
            stack.push(-a+b);
        }
        if ( tokens.at(it) == "*")
        {
            double a = stack.pop();
            double b = stack.pop();
            stack.push(a*b);
        }
        if ( tokens.at(it) == "/")
        {
            double a = stack.pop();
            double b = stack.pop();
            stack.push(b/a);
        }
        if ( tokens.at(it) == "^")
        {
            double a = stack.pop();
            double b = stack.pop();
            stack.push(qPow(b,a));
        }
    }
    qDebug() << stack.top();
    return stack.pop();
}
