#include "nVector.h"

nVector::nVector(const std::vector <double> &input):coord(input)
{;}

nVector::nVector( double input[], const size_t sizeN)
{
    for (unsigned i=0; i< sizeN; i++)  coord.push_back(input[i]);
}

nVector::~nVector()
{;}

double nVector::GetSize() const
{
    return coord.size();
}

nVector operator +(const nVector &a, const nVector &b)
{
    /*if ( a == b)
    {
        std::vector <double> summ;
        for (unsigned i=0; i < b.GetSize(); i++)
        {
            summ.push_back(a.coord.at(i) + b.coord.at(i));
        }
        return nVector(summ);
    }*/
    nVector summ(a);
    return nVector(summ+=b);
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
//    std::vector <double> result;
//    for (unsigned i=0; i < a.GetSize(); i++)
//    {
//        result.push_back(a.coord.at(i)*scalar);
//    }
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
        return *this;
    }
};
