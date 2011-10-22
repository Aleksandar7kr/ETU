////////////////////////////////////////
// Labs MO
// Krasilnikov A, Drozdov A
// group 9301
// variant 4
/////////////////////////// /////////////

#include <iostream>

//#include "methods.h"
//#include "functions.h"
#include <vector>

#include "nVector.h"


using namespace std;


int main()
{
    // lab #1
//    cout << "fibonacci_2 minimum = " << fibonacci_2(ff, swenn_1(ff, 100000)) << endl;

    // lab #2
//    cout << "bolzano minimum = " << bolzano(ff,swenn_1(ff,1)) << endl;
//    cout << "powell  minimum = " <<  powell(ff,swenn_1(ff,1)) << endl;


    double x1[] = {1,2,3,4,5};
    double x2[] = {1,1,1,1,1};

    nVector point1(vector <double>(x1, x1+sizeof(x1)/sizeof(double)));
    nVector point2(vector <double>(x2, x2+sizeof(x2)/sizeof(double)));

 //   nVector point3(point1*10);
 //   point1 +=point2;
    point2=point1;
    for (unsigned i = 0; i < point2.GetSize(); i++)
    {
        cout << point2.coord[i] << " ";
    }
return 0;
}
