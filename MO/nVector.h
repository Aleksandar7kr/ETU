#ifndef NVECTOR_H
#define NVECTOR_H

#include <math.h>
#include <vector>

class nVector
{
    private:
        std::vector <double> coord;

    public:
        nVector(const std::vector <double> &input);
        nVector(double input[],const unsigned n);
        nVector(unsigned ortN, double ortL, unsigned n = 1);
        virtual ~nVector();

        unsigned GetSize()            const;
        double  GetNorm()            const;

        // operators
        friend nVector operator+  (const nVector &a, const nVector &b);
        friend nVector operator-  (const nVector &a, const nVector &b);
        friend nVector operator*  (const nVector&,double );

        nVector&       operator+= (const nVector&);
        bool           operator== (const nVector&) const;
        nVector&       operator*= (double );
        nVector&       operator=  (const nVector&);
        double         operator[] (const unsigned n) const;
};

#endif // NVECTOR_H
