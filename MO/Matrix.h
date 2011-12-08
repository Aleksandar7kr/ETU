#ifndef MATRIX_H
#define MATRIX_H

#include <vector>
#include <iostream>

class Matrix
{
private:
    double *data;
    size_t x_size;
    size_t y_size;

public:
    Matrix(const Matrix&);
    Matrix(double  input[], const unsigned, const unsigned);
    Matrix(double vector[], const unsigned);
    Matrix();

    virtual ~Matrix();

    unsigned GetSizeX() const;
    unsigned GetSizeY() const;
    Matrix t() const;
    double at(unsigned, unsigned) const;

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
    friend Matrix operator / (const Matrix&, const double);
    friend Matrix operator * (const Matrix&, const Matrix&);
    friend std::ostream& operator << (std::ostream &, const Matrix &);

protected:

};

#endif // MATRIX_H
