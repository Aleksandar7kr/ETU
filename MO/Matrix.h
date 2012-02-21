#ifndef MATRIX_H
#define MATRIX_H

#include <iostream>
#include <math.h>

class Matrix
{
private:
    double *data;
    size_t x_size;
    size_t y_size;

public:

    Matrix(const Matrix&);                                     // copy c_tor
    Matrix(double *  input, const unsigned, const unsigned);   // base matrix init c_tor
    Matrix(double * vector, const unsigned);                   // base vector c_tor
    Matrix(const unsigned,  const unsigned);                   // set size and nulled matrix
    Matrix(double ortLength, unsigned coord, unsigned Size);   // make ort-vector
    Matrix();

    virtual ~Matrix();

    unsigned GetSizeX() const;
    unsigned GetSizeY() const;
    Matrix t() const;
    double at(unsigned, unsigned) const;
    double det() const;
    double norm() const;

    Matrix& operator += (const Matrix&);
    Matrix& operator -= (const Matrix&);
    Matrix& operator *= (const double);
    Matrix& operator /= (const double);
    Matrix& operator  = (const Matrix&);
    Matrix  operator  - () const;
    Matrix  operator  + () const;

    friend Matrix operator + (const Matrix&, const Matrix&);
    friend Matrix operator - (const Matrix&, const Matrix&);
    friend Matrix operator * (const Matrix&, const double);
    friend Matrix operator * (const double,  const Matrix&);
    friend Matrix operator / (const Matrix&, const double);
    friend Matrix operator * (const Matrix&, const Matrix&);
    friend std::ostream& operator << (std::ostream &, const Matrix &);


protected:

};

#endif // MATRIX_H
