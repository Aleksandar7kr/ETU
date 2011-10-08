////////////////////////////////////////
// Labs MO
// Krasilnikov A, Drozdov A
// group 9301
// variant 4
////////////////////////////////////////


#include <iostream>

#include "methods.h"
#include "functions.h"

using namespace std;

int main()
{
    // lab #1

//    cout << "fibonacci_2 minimum = " << fibonacci_2(ff, swenn_1(ff, 100000)) << endl;

    // lab #2
//    cout << "bolzano minimum = " << bolzano(ff,swenn_1(ff,1)) << endl;
//    cout << "powell  minimum = " <<  powell(ff,swenn_1(ff,1)) << endl;

      Interval i = swenn_1(parabola, 1000);
      cout << i.a << " " << i.b;

}

