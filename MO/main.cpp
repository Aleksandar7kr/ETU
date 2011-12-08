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

using namespace std;

int main()
{
    double aa[] = {1,2,3,4,5,6,7,8};
//    double bb[] = {1,1,1,1,1,1,1,1,1};
    Matrix a(aa, 2, 4);
    cout << -a;

    return 0;
}
