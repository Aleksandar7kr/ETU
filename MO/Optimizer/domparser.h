#ifndef DOMPARSER_H
#define DOMPARSER_H

#include <QtXml/qdom.h>
#include <QtGui>
#include <QtCore>
#include <QDebug>

class DomParser
{
public:
  DomParser(QIODevice *device, QTreeWidget * tree);
    QTreeWidget * treeWidget;

private:
  void parseEntry(const QDomElement &element, QTreeWidgetItem * parent);

};

#endif // DOMPARSER_H
