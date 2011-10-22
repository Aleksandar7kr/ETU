#include "nVector.h"

nVector::nVector(const std::vector <double> &input):coord(input)
{

}

nVector::~nVector()
{
    //dtor
}

double nVector::GetSize() const
{
    return coord.size();
}

nVector nVector::operator +(const nVector & b) const
{
    if ( *this == b)
    {
        std::vector <double> summ;
        for (unsigned i=0; i < b.GetSize(); i++)
        {
            summ.push_back(coord.at(i) + b.coord.at(i));
        }
        return nVector(summ);
    }
}

void nVector::operator +=(const nVector& b)
{
    if ( *this == b)
    {
        for (unsigned i=0; i < b.GetSize(); i++)
        {
            coord.at(i) += b.coord.at(i);
        }
    }
}

bool nVector::operator ==(const nVector& b) const
{
    return ( GetSize() == b.GetSize()) ? true : false;
}

nVector nVector::operator *(double scalar) const
{
    std::vector <double> result;
    for (unsigned i=0; i < GetSize(); i++)
    {
        result.push_back(coord.at(i)*scalar);
    }
    return nVector(result);
}

void nVector::operator *=(double scalar)
{
    for (unsigned i=0; i < GetSize(); i++)
    {
        coord.at(i)*=scalar;
    }
}

nVector& nVector::operator =(const nVector &b)
{
    coord = b.coord;
    return *this;
}
