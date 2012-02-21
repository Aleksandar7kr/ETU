#include "Matrix.h"

Matrix::Matrix(double * input, const unsigned n, const unsigned m): x_size(n),y_size(m)
{
    data = new double[y_size*x_size];
    for (unsigned i = 0; i < y_size*x_size; ++i) data[i] = input[i];
}

Matrix::Matrix(double * vector, const unsigned size): x_size(1), y_size(size)
{
    data = new double[y_size];
    for (unsigned i = 0; i < y_size; ++i) data[i] = vector[i];
}

Matrix::Matrix(const unsigned x, const unsigned y): x_size(x), y_size(y)
{
    data = new double[x_size*y_size];

    for (unsigned i = 0; i < y_size; ++i)
    {
        for (unsigned j = 0; j < x_size; ++j)
        {
            data[i*x_size+j] = (i==j) ? 1:0;
        }
    }
}

Matrix::Matrix(double ortLength, unsigned coord, unsigned vectSize): x_size(1), y_size(vectSize)
{
    data = new double[y_size];
    for (unsigned i = 0; i < y_size; ++i)
        data[i] = (i == coord) ? ortLength : 0;
}

Matrix::Matrix(const Matrix & cm)
{
    this->x_size = cm.x_size;
    this->y_size = cm.y_size;
    this->data = new double [cm.x_size*cm.y_size];
    *this = cm;
}

Matrix::Matrix()
{;}

Matrix::~Matrix()
{
    delete data;
}

unsigned Matrix::GetSizeX() const
{
    return x_size;
}
unsigned Matrix::GetSizeY() const
{
    return y_size;
}

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
    // if (i <= x_size && j <= y_size)
       return data[i*x_size + j];
    // exception
}

void Matrix::set(unsigned i, unsigned j, double val)
{
    data[i*x_size + j] = val;
}

double Matrix::norm() const
{
    double summ = 0;
    for (unsigned i = 0; i < GetSizeY(); ++i)
    {
        summ += at(0,i);
    }
    return sqrt(summ);
}

double Matrix::det() const
{
    if (x_size != y_size) return 0;
    unsigned n = x_size;
    double det = 1;
    double EPS = 0.000000001;
    Matrix m(*this);

    for (unsigned i=0; i<n; ++i)
    {
        unsigned k = i;
        for (unsigned j=i+1; j<n; ++j)
            if (fabs(m.at(j,i)) > fabs(m.at(k,i))) k = j;

        if (fabs (m.at(k,i)) < EPS) return 0;

        for (unsigned it = 0; it < x_size; ++it)
            std::swap(m.data[i*x_size+it], m.data[k*x_size+it]);

        if (i != k) det = -det;
        det *= m.at(i,i);

        for (unsigned j = i+1; j<n; ++j)
            m.data[i*x_size+j] /= m.at(i,i);

        for (unsigned j=0; j<n; ++j)
            if (j != i && fabs(m.at(j,i)) > EPS)
                for (unsigned k=i+1; k<n; ++k)
                    m.data[j*x_size+k] -= m.at(i,k) * m.at(j,i);
    }
    return det;
}

Matrix Matrix::inv() const
{
    unsigned size = this->GetSizeY();
    Matrix a(*this);
    Matrix res(size,size);

    for (unsigned mid = 0; mid < size; mid++)
    {
        if (a.at(mid,mid) == 0.0 && mid != size-1)
        {
            bool isDone = 0;
            for (unsigned y = mid+1; y<size; y++)
            {
                for (unsigned x = mid; x<size; x++)
                {
                    if (a.at(y,x) != 0.0)
                    {
                        for (unsigned i=0; i<size; i++)
                        {
                            double temp = a.at(mid,i);
                            a.set(mid,i, a.at(y,i));
                            a.set(y,i,temp);

                            temp = res.at(mid,i);
                            res.set(mid,i, res.at(y,i));
                            res.set(y,i,temp);

                            temp = a.at(i,mid);
                            a.set(i,mid, a.at(i,x));
                            a.set(i,x,temp);

                            temp = res.at(i,mid);
                            res.set(i,mid, res.at(i,x));
                            res.set(i,x,temp);
                        }
                        isDone = 1;
                        break;
                    }
                }
                if (isDone) break;
                // "!!!!!" << endl;
            }
        }
        double ToOne = a.at(mid,mid);

        for (unsigned x=0; x<size; x++)
        {
            a.set(mid,x, a.at(mid,x)/ ToOne);
            res.set(mid,x, res.at(mid,x)/ ToOne);
        }
        for (unsigned y=0; y<size; y++)
        {
            if (y!=mid)
            {
                double ToZero = a.at(y,mid);

                for (unsigned x=0; x<size; x++)
                {
                    a.set(y,x, a.at(y,x)- a.at(mid,x)*ToZero);
                    res.set(y,x, res.at(y,x)- res.at(mid,x)*ToZero);
                }
            }
        }
    }
    return res;

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
    Matrix c(a);
    c *= scalar;
    return c;
}

Matrix operator * (const double scalar, const Matrix& a)
{
    Matrix c(a);
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
        stream << "[ ";
        for (unsigned j = 0; j < m.GetSizeX(); ++j)
        {
            stream << m.data[i*m.GetSizeX()+j]  << " ";
        }
        stream << " ]" << std::endl;
    }
    return stream;
}
