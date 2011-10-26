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
        friend nVector operator-  (const nVector &a, const nVector &b);
        friend nVector operator*  (const nVector&,double );
        friend nVector operator*  (const nVector&,const nVector&);
        nVector&       operator+= (const nVector&);
        bool           operator== (const nVector&) const;
        nVector&       operator*= (double );
        nVector&       operator=  (const nVector&);
        double         operator[] (const unsigned n) const;
        nVector&       operator-  ()const;
};

#endif // NVECTOR_H
