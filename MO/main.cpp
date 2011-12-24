////////////////////////////////////////
// Labs MO
// Krasilnikov A, Drozdov A
// group 9301
// variant 4
////////////////////////// /////////////

#include <iostream>

#include "methods.h"
#include "functions.h"
#include "nVector.h"
#include "Matrix.h"

int main()
{
   double test[] = {1,1};
 //   double test[] = {1.5,2};
  //  double test[] = {-1.2,1};

  //double test[] = {-1,-1};
    Matrix x0(test,2);
    std::cout << "x0 = " << std::endl << x0.t() << std::endl;
    powell(test7, x0);

    return 0;
}
