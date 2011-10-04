#########################################################
# Labs MO
# Krasilnikov A, Drozdov A
# group 9301
#########################################################


#include <iostream>

#include "methods.h"
#include "functions.h"

using namespace std;

int main()
{
    // lab #1
//    cout << "fibonacci_2 minimum = " << fibonacci_2(f1_4, swenn_1(f1_4, 2)) << endl;

    // lab #2
    cout << "bolzano minimum = " << bolzano(f2_4,swenn_1(f2_4,0.4)) << endl;
    cout << "powell  minimum = " <<  powell(f2_4,swenn_1(f2_4,0.4)) << endl;

}

