#include <QtGui>

#include "optimizer.h"


int main(int argc, char ** argv)
{
    QApplication app(argc, argv);

    optimizer opt;
    opt.resize(640,480);
    opt.setWindowTitle("optimizer");
    opt.show();

    return app.exec();
}
