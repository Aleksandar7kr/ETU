#include "optimizer.h"

double * optimizer::SetArg(QString args, int &size)
{
    QMap <QString, double> arg;
    QString argStr = args;
    QStringList argList;
    QStringList curArg;
    argList = argStr.split(",");
    size = argList.size();
    double * arr = new double[size];
    for(int i = 0; i < argList.size(); ++i)
    {
        curArg = argList.at(i).split("=");
        double a = (curArg.at(1).at(0) != '-') ? curArg.at(1).toDouble() : -curArg.at(1).split("-").at(0).toDouble();
        arg.insert(curArg.at(0).trimmed(), a);
        arr[i] = a;
    }
    return arr;
}

optimizer::optimizer(QTabWidget *parent): QTabWidget(parent)
{
    InitLibrary();
    InitGUI();

    connect(libView,SIGNAL(itemClicked(QTreeWidgetItem*,int)),this,SLOT(toWorkspace(QTreeWidgetItem*,int)));
    connect(runButton,SIGNAL(clicked()),this,SLOT(runLabs()));
}

void optimizer::InitGUI()
{
    label1 = new QLabel(tr("test test test"));
    QLabel * funcLabel   = new QLabel(tr("function:"));
    QLabel * paramLabel  = new QLabel(tr("arguments:"));
    QLabel * resultLabel = new QLabel(tr("result:"));

    metodsBox = new QComboBox();
    metodsBox->addItem(QString("labs #6 - newton"), 6);
    metodsBox->addItem(QString("labs #7 - mc_cormick"), 7);
    metodsBox->addItem(QString("labs #8 - dixon"), 8);
    metodsBox->addItem(QString("labs #9 - powell-1 "), 9);
    metodsBox->addItem(QString("work 14 - hooke-jeeves"),10);
    //   metodsBox->addItem(QString("work 15 - nelder-mead"),11);



    inputFuncText  = new QLineEdit;
    inputParamText = new QLineEdit;
    resultText     = new QTextEdit;
    resultText->setText("this is read only test");
    resultText->setReadOnly(true);
    runButton      = new QPushButton(tr("run"));
    saveButton     = new QPushButton(tr("add to library"));

    QHBoxLayout * buttonLayout = new QHBoxLayout();
    buttonLayout->addWidget(runButton);
    buttonLayout->addWidget(saveButton);

    QVBoxLayout *workLayout = new QVBoxLayout();
    workLayout->addWidget(funcLabel);
    workLayout->addWidget(inputFuncText);
    workLayout->addWidget(paramLabel);
    workLayout->addWidget(inputParamText);
    workLayout->addWidget(metodsBox);
    workLayout->addLayout(buttonLayout);
    workLayout->addWidget(resultLabel);
    workLayout->addWidget(resultText);

    QVBoxLayout *libLayout = new QVBoxLayout();
    libLayout->addWidget(libView);

    workTab = new QWidget();
    workTab->setLayout(workLayout);
    libTab =  new QWidget();
    libTab->setLayout(libLayout);
    helpTab = new QWidget();

    addTab(workTab,"workspace");
    addTab(libTab ,"library");
    addTab(helpTab,"help");
}

void optimizer::InitLibrary()
{
    QStringList labels;
    labels << QObject::tr("terms") << QObject::tr("pages");
    libView = new QTreeWidget;
    libView->setHeaderLabels(labels);
    libView->setColumnWidth(0,libView->width()/2);
    QFile f("library.txt");
    DomParser(&f,libView);
}

// SLOTS:
void optimizer::toWorkspace(QTreeWidgetItem * item, int)
{
    inputFuncText ->setText(item->text(0));
    inputParamText->setText(item->text(1));
}

void optimizer::runLabs()
{
    qDebug() << "ok!";
    Parser parser(inputFuncText->text());
    parser.SetArg(inputParamText->text());

    int size = 0;
    int nLabs = metodsBox->currentIndex();

    double *x = SetArg(inputParamText->text(), size);

    const Matrix x0(x,size);
    Matrix res(x0);

    switch (nLabs)
    {
        case 0: res =  newton(parser,x0); resultText->append("\nnewton_min:");break;
        case 1: res =  mc_cormick(parser,x0); resultText->append("\nmc_cormick_min:"); break;
        case 2: res =  dixon (parser,x0); resultText->append("\ndixon_min:");break;
        case 3: res =  powell(parser,x0); resultText->append("\npowell-1_min:");break;
        case 4: res =  hooke_jeeves(parser,x0); resultText->append("\nhooke-jeeves_min:");break;
        case 5: res =  nelder_mead(parser,x0); resultText->append("\nnelder-mead_min:");break;
    }

    for (unsigned i = 0; i < res.GetSizeY(); i++)
    {
        QVariant str(res.at(0,i));
        str = "[" + str.toString() + "]";
        resultText->append(str.toString());
    }
    QVariant str(parser.f(res));
    resultText->append("f(minimum) = " + str.toString() + "\n");
    qDebug() << nLabs;
}
