#ifndef OPTIMIZER_H
#define OPTIMIZER_H

#include <QtGui>

#include "domparser.h"
#include "parser.h"
#include "methods.h"
#include "Matrix.h"
#include "functions.h"

class optimizer : public QTabWidget
{
    Q_OBJECT

public:
    optimizer(QTabWidget *parent = 0);
        Parser *pars;

public slots:
    void toWorkspace(QTreeWidgetItem*,int);
    void runLabs();

private:
    QLabel * label1;

    QPushButton * runButton;
    QPushButton * saveButton;

    QLineEdit * inputFuncText;
    QLineEdit * inputParamText;
    QTextEdit * resultText;

    QWidget * workTab;
    QWidget * libTab;
    QWidget * helpTab;

    QTreeWidget * libView;
    QComboBox * metodsBox;



    void InitLibrary();
    void InitGUI();

    double * SetArg(QString args, int &size);
};

#endif // OPTIMIZER_H
