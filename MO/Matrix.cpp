#include "Matrix.h"

Matrix::Matrix(double input[], const unsigned n, const unsigned m): x_size(n),y_size(m)
{
    data = new double[y_size*x_size];

    for (unsigned i = 0; i < y_size*x_size; ++i) data[i] = input[i];
}

Matrix::Matrix(double vector[], const unsigned size): x_size(1), y_size(size)
{
    data = new double[y_size];
    for (unsigned i = 0; i < y_size; ++i) data[i] = vector[i];
}

Matrix::Matrix(const Matrix & cm)
{
    this->x_size = cm.x_size;
    this->y_size = cm.y_size;
    this->data = new double [cm.x_size*cm.y_size];
    *this = cm;
}

Matrix::~Matrix() {delete data;
}

unsigned Matrix::GetSizeX() const {return x_size;}
unsigned Matrix::GetSizeY() const {return y_size;}

Matrix Matrix::t() const
{
    double * t = new double[y_size*x_size];
    for (unsigned j = 0; j < x_size; j++)
    {
        for ( unsigned i = 0; i < y_size; i++)
        {
            t[j*y_size+i] = data[i*x_size + j];
        }
    }
    return Matrix(t, y_size, x_size);
}

double Matrix::at(unsigned i, unsigned j) const
{
    if (i <= x_size && j <= y_size)
    {
        return data[i*x_size + j];
    }
}

Matrix& Matrix::operator +=(const Matrix &a)
{
    if (x_size == a.x_size && y_size == a.y_size)
    {
        for (unsigned i = 0; i < a.x_size*a.y_size; ++i)
        {
            data[i] += a.data[i];
        }
    }
    return *this;
}

Matrix& Matrix::operator -=(const Matrix &a)
{
    if (x_size == a.x_size && y_size == a.y_size)
    {
        for (unsigned i = 0; i < a.x_size*a.y_size; ++i)
        {
            data[i] -= a.data[i];
        }
    }
    return *this;
}

Matrix& Matrix::operator *=(const double scalar)
{
    for (unsigned i = 0; i < x_size*y_size; ++i)
    {
        data[i] *= scalar;
    }
    return *this;
}

Matrix& Matrix::operator /=(const double scalar)
{
    if (scalar)
    {
        for (unsigned i = 0; i < x_size*y_size; ++i)
        {
            data[i] /= scalar;
        }
    }
    return *this;
}

Matrix& Matrix::operator  =(const Matrix &a)
{
    if (x_size == a.x_size && y_size == a.y_size)
    {
        for (unsigned i = 0; i < a.x_size*a.y_size; ++i)
        {
            data[i] = a.data[i];
        }
    }
    return *this;
}

Matrix operator + (const Matrix &a, const Matrix &b)
{
    Matrix c(a.data,a.x_size,a.y_size);
    c += b;
    return c;
}

Matrix operator - (const Matrix &a, const Matrix &b)
{
    Matrix c = a;
    c -= b;
    return c;
}

Matrix operator * (const Matrix &a, const double scalar)
{
    Matrix c = a;
    c *= scalar;
    return c;
}

Matrix operator / (const Matrix &a, const double scalar)
{
    Matrix c = a;
    c /= scalar;
    return c;
}

Matrix Matrix::operator -()const
{
    Matrix a(*this);
    a*=(-1);
    return a;
}

Matrix Matrix::operator +() const
{
    return *this;
}

Matrix operator * (const Matrix &a, const Matrix &b)
{
    if (a.x_size == b.y_size)
    {
        double *mult = new double[b.x_size*a.y_size];
        for (unsigned i = 0; i < b.x_size*a.y_size; ++i) mult[i] = 0;


        for (unsigned i = 0; i < a.y_size; ++i)
        {
            for (unsigned j = 0; j < b.x_size; ++j)
            {
                for (unsigned k = 0; k < a.x_size; ++k)
                {
                    mult[i*b.x_size+j] += a.data[i*a.x_size+k] * b.data[k*b.x_size+j];
                }
            }
        }
        Matrix c(mult, b.x_size, a.y_size);
        delete mult;
        return c;
    }
    return a;
}

std::ostream& operator << (std::ostream &stream, const Matrix &m)
{
    for (unsigned i = 0; i < m.GetSizeY(); ++i)
    {
        for (unsigned j = 0; j < m.GetSizeX(); ++j)
        {
            stream << m.data[i*m.GetSizeX()+j]  << " ";
        }
        stream << std::endl;
    }
    return stream;
}
