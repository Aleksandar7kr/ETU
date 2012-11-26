//COMPLEX.H


#if !defined(__COMPLEX_H)
#define __COMPLEX_H


#include <math.h>

class  complex {

public:
    // constructors
    complex(double __re_val, double __im_val = 0);
    complex();

    // complex manipulations
    friend double real(complex &);   // the real part
    friend double imag(complex &);   // the imaginary part
    friend double abs(complex &);  // the module
    friend double arg(complex &);    // the angle


    // Binary Operator Functions
    friend complex operator+(complex &, complex &);
    friend complex operator+(double, complex &);
    friend complex operator+(complex &, double);
    friend complex operator-(complex &, complex &);
    friend complex operator-(double, complex &);
    friend complex operator-(complex &, double);
    friend complex operator*(complex &, complex &);
    friend complex operator*(complex &, double);
    friend complex operator*(double, complex &);
    friend complex operator/(complex &, complex &);
    friend complex operator/(complex &, double);
    friend complex operator/(double, complex &);
    friend int operator==(complex &, complex &);
    friend int operator!=(complex &, complex &);
    complex & operator+=(complex &);
    complex & operator+=(double);
    complex & operator-=(complex &);
    complex & operator-=(double);
    complex & operator*=(complex &);
    complex & operator*=(double);
    complex & operator/=(complex &);
    complex & operator/=(double);
    complex operator+();
    complex operator-();
// Implementation
private:
        double re, im;
};


// Inline complex functions

inline complex::complex(double __re_val, double __im_val)
{
    re = __re_val;
    im = __im_val;
}

inline complex::complex()
{
}

inline complex complex::operator+()
{
    return *this;
}

inline complex complex::operator-()
{
    return complex(-re, -im);
}

// Definitions of compound-assignment operator member functions

inline complex & complex::operator+=(complex & __z2)
{
    re += __z2.re;
    im += __z2.im;
    return *this;
}

inline complex & complex::operator+=(double __re_val2)
{
    re += __re_val2;
    return *this;
}

inline complex & complex::operator-=(complex & __z2)
{
    re -= __z2.re;
    im -= __z2.im;
    return *this;
}

inline complex & complex::operator-=(double __re_val2)
{
    re -= __re_val2;
    return *this;
}

inline complex & complex::operator*=(complex & __z2)    //ins
{
    double r = re*__z2.re - im*__z2.im;
    im = re*__z2.im + im*__z2.re;
    re = r;
    return *this;
}

inline complex & complex::operator*=(double __re_val2)
{
    re *= __re_val2;
    im *= __re_val2;
    return *this;
}

inline complex & complex::operator/=(complex & __z2)   //ins
{
    double d=__z2.re*__z2.re + __z2.im*__z2.im;
    double r =(re*__z2.re + im*__z2.im)/d;
    im =(im*__z2.re - re*__z2.im)/d;
    re =r;
    return *this;
}

inline complex & complex::operator/=(double __re_val2)
{
    re /= __re_val2;
    im /= __re_val2;
    return *this;
}


// Definitions of non-member complex functions

inline double  real(complex & __z)
{
    return __z.re;
}

inline double imag(complex & __z)
{
    return __z.im;
}

inline double abs(complex & __z)
{
    return sqrt(__z.re*__z.re +__z.im*__z.im);
}

inline double arg(complex & __z)
{
    return atan2(__z.im, __z.re);
}


// Definitions of non-member binary operator functions

inline complex operator+(complex & __z1, complex & __z2)
{
    return complex(__z1.re + __z2.re, __z1.im + __z2.im);
}

inline complex operator+(double __re_val1, complex  & __z2)
{
    return complex(__re_val1 + __z2.re, __z2.im);
}

inline complex operator+(complex & __z1, double __re_val2)
{
    return complex(__z1.re + __re_val2, __z1.im);
}

inline complex operator-(complex & __z1, complex & __z2)
{
    return complex(__z1.re - __z2.re, __z1.im - __z2.im);
}

inline complex  operator-(double __re_val1, complex & __z2)
{
    return complex(__re_val1 - __z2.re, -__z2.im);
}

inline complex  operator-(complex  & __z1, double __re_val2)
{
    return complex(__z1.re - __re_val2, __z1.im);
}



inline complex  operator*(complex & __z1, complex  & __z2)  // ins
{
    return complex(__z1.re*__z2.re - __z1.im*__z2.im,
                   __z1.re*__z2.im + __z1.im*__z2.re);
}

inline complex  operator*(complex & __z1, double __re_val2)  // ins
{
    return complex(__z1.re*__re_val2 , __z1.im*__re_val2);
}

inline complex  operator*(double __re_val1, complex  & __z2)
{
    return complex(__z2.re*__re_val1, __z2.im*__re_val1);
}

inline complex  operator/(complex  & __z1, complex & __z2)  //ins
{
    double d=__z2.re*__z2.re + __z2.im*__z2.im;
    return complex((__z1.re*__z2.re +__z1.im*__z2.im)/d,
                   (__z1.im*__z2.re -__z1.re*__z2.im)/d);
}

inline complex  operator/(double __re_val1, complex & __z2)  //ins
{
    double d=__z2.re*__z2.re + __z2.im*__z2.im;
    return complex(__re_val1*__z2.re /d, - __re_val1*__z2.im/d);
}
inline complex  operator/(complex  & __z1, double __re_val2)
{
    return complex(__z1.re/__re_val2, __z1.im/__re_val2);
}

inline int  operator==(complex  & __z1, complex  & __z2)
{
    return __z1.re == __z2.re && __z1.im == __z2.im;
}

inline int  operator!=(complex & __z1, complex & __z2)
{
    return __z1.re != __z2.re || __z1.im != __z2.im;
}


#endif  // __COMPLEX_H
