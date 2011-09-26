#include <iostream>
#include "header.h"

using namespace std;

int main()
{
    Interval i = swen_method_1(f4,-5);
    cout << i.a << " " << i.b;
}
