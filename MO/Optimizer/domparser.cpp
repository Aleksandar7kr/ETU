#include "domparser.h"

DomParser::DomParser(QIODevice *device, QTreeWidget * tree)
{
    treeWidget = tree;
    QString errorStr;
    int errorLine;
    int errorColumn;
    QDomDocument doc;
    if (!doc.setContent(device, true, &errorStr, &errorLine, &errorColumn))
    {
        //qWarning("Line %d, column  errorLine, errorColumn, errorStr.ascii());
        return;
    }

    QDomElement root = doc.documentElement();
    if (root.tagName() != "library") return;

    QDomNode node = root.firstChild();
    while (!node.isNull())
    {
        if (node.toElement().tagName() == "record")
            parseEntry(node.toElement(), 0);
        node = node.nextSibling();
    }
}

void DomParser::parseEntry(const QDomElement &element, QTreeWidgetItem * parent)
{
    QTreeWidgetItem *item;

    if (parent) item = new QTreeWidgetItem(parent);
    else        item = new QTreeWidgetItem(treeWidget);

    item->setText(0, element.attribute("func"));

    QDomNode node = element.firstChild();
    while (!node.isNull())
    {
        if (node.toElement().tagName() == "param")
        {
            QDomNode childNode = node.firstChild();
            while (!childNode.isNull())
            {
                if (childNode.nodeType() == QDomNode::TextNode)
                {
                    item->setText(1, childNode.toText().data());
                    break;
                }
                childNode = childNode.nextSibling();
            }
        }
        node = node.nextSibling();
    }
}
