#ifndef NVECTOR_H
#define NVECTOR_H

#include <vector>

class nVector
{
    private:
 //   public:
        std::vector <double> coord;

    public:
        nVector(const std::vector <double> &input);
        nVector(double input[],const unsigned n);
        virtual ~nVector();

        double  GetSize()            const;

        // operators
        friend nVector operator+  (const nVector &a, const nVector &b);
        nVector&       operator+= (const nVector&);
        bool           operator== (const nVector&) const;
        friend nVector operator*  (const nVector&,double );
        nVector&       operator*= (double );
        nVector&       operator=  (const nVector&);
};

#endif // NVECTOR_H
