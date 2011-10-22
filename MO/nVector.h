#ifndef NVECTOR_H
#define NVECTOR_H

#include <vector>

class nVector
{
    private:
        std::vector <double> coord;
        unsigned size;
    public:
        nVector(const std::vector <double> &input);
        virtual ~nVector();

        double  GetSize()            const;

        nVector operator  +(nVector) const;
        void    operator +=(nVector);
        bool    operator ==(nVector) const;
        nVector operator * (double )  const;  //multiplication by a scalar
        void    operator *=(double);

};

#endif // NVECTOR_H
