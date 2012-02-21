#include "nVector.h"
typedef unsigned size_t;

nVector::nVector(const std::vector <double> &input):coord(input)
{;}

nVector::nVector( double input[], const size_t sizeN)
{
    for (unsigned i=0; i< sizeN; i++)  coord.push_back(input[i]);
}

nVector::nVector(unsigned ortN, double ortL, unsigned n)
{
    for (unsigned i = 0; i < n; ++i)
    {
        coord.push_back( (i==ortN) ? ortL : 0 );
    }
}

nVector::~nVector()
{;}

unsigned nVector::GetSize() const
{
    return coord.size();
}

double nVector::GetNorm() const
{
    double norm = 0;
    for (unsigned i = 0; i < GetSize(); ++i)
    {
        norm+=(coord.at(i)*coord.at(i));
    }
    return sqrt(norm);
}

nVector operator +(const nVector &a, const nVector &b)
{
    nVector summ(a);
    return nVector(summ+=b);
}

nVector operator-  (const nVector &a, const nVector &b)
{
    nVector res(a);
    res += b*(-1);
    return res;
}

nVector& nVector::operator +=(const nVector& b)
{
    if ( *this == b)
    {
        for (unsigned i=0; i < b.GetSize(); i++)
        {
            coord.at(i) += b.coord.at(i);
        }
    }
    return *this;
}

bool nVector::operator ==(const nVector& b) const
{
    return ( GetSize() == b.GetSize()) ? true : false;
}

nVector operator *(const nVector &a,double scalar)
{
    nVector result(a);
    return nVector(result*=scalar);
}

nVector& nVector::operator *=(double scalar)
{
    for (unsigned i=0; i < GetSize(); i++)
    {
        coord.at(i)*=scalar;
    }
    return *this;
}

nVector& nVector::operator =(const nVector &b)
{
    if ( *this == b)
    {
        coord = b.coord;
    }
    return *this;
};

double nVector::operator [](const unsigned n) const
{
    return coord.at(n);
}
