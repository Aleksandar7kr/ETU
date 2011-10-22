#ifndef NVECTOR_H
#define NVECTOR_H

#include <vector>

class nVector
{
    private:
    public:
        std::vector <double> coord;
        unsigned size;
    public:
        nVector(const std::vector <double> &input);
        virtual ~nVector();

        double  GetSize()            const;

        nVector operator  +(const nVector&) const;
        void    operator +=(const nVector&);
        bool    operator ==(const nVector&) const;
        nVector operator * (double )  const;  //multiplication by a scalar
        void    operator *=(double );
        nVector&   operator  =(const nVector&);
};

#endif // NVECTOR_H
