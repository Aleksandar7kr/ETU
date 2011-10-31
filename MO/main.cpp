////////////////////////////////////////
// Labs MO
// Krasilnikov A, Drozdov A
// group 9301
// variant 4
/////////////////////////// /////////////

#include <iostream>

#include "methods.h"
#include "functions.h"
#include <vector>

#include "nVector.h"


using namespace std;
/*
double x0[] = {4,-1,1};
double p0[]  = {0,0,0};
double ee1[] = {1,0,0};
double ee2[] = {0,1,0};

double ee3[] = {0,0,1};

//double x0[] = {0,0};
//double p0[] = {1,0};
nVector x1(x0,3);
nVector x2(x1);
nVector p(p0,3);
nVector e1(ee1,3);
nVector e2(ee2,3);
nVector e3(ee3,3);

double y(double alpha)
{
  //  return f3_13(x1+p*alpha) ;
  return test6(x1+p*alpha);
}
*/
double test(nVector arg)
{
        return 2*arg[0]*arg[0]-2*arg[0]*arg[1]+ 2*arg[1]*arg[1] - 6*arg[1] -6;
}

int main()
{
/*      cout << "lab #1" << endl;
      double x1[5] = {2,100,-10000,0.1,-1};
      myEPS =0.001;
      for (unsigned i = 0; i < 5; i++)
      {
          cout << "x1 = " << x1[i] << " eps = " << myEPS << " ";
          cout << "fibonacci_2 minimum = " << fibonacci_2(f1_4, swenn_1(f1_4, x1[i])) << endl << endl;
          myEPS/=10;
      }


      cout << "lab #2" << endl;
      double x1[5] = {0.4,-1.1,100,0.1,-1};
      myEPS =0.001;
      for (unsigned i = 0; i < 5; i++)
      {
          cout << "x1 = " << x1[i] << " eps = " << myEPS << " ";
          cout << "bolzano minimum = " << bolzano(f2_4,swenn_1(f2_4,x1[i])) << endl;
          cout << "powell  minimum = " <<  powell(f2_4,swenn_1(f2_4,x1[i])) << endl << endl;
          myEPS/=10;
      }
*/

/*  //lab #3
    double alpha = 1;

    Interval i = swenn_1(y,alpha);
    cout << i.a << " " << i.b << endl;

    x2 = x1+p*davidon(y,i,10);
    cout << "davidon minimum = [" << x2[0] << " " << x2[1] << "]" << endl;

    x2 = x1+p*fibonacci_1(y,i);
    cout << "fibanacci_1 minimum = [" << x2[0] << " " << x2[1] << "]";
*/
    double x4_1[]  = {8,9,2};
    double x4_2[]  = {0,0};
    nVector x22_1(x4_1, sizeof(x4_1)/sizeof(x4_1[0]));
    nVector x22_2(x4_2, sizeof(x4_2)/sizeof(x4_2[0]));

    //gauss_seidel(f22,x22_1);

    partan1(test6,x22_1);



}
