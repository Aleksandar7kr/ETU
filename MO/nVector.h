#ifndef NVECTOR_H
#define NVECTOR_H

#include <vector>

class nVector
{
    public:
        nVector(std::vector <double>);
        virtual ~nVector();
    protected:
    public:
        std::vector <double> coord;
        size_t size;

};

#endif // NVECTOR_H
