clc; clear;
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
% idz #1 - interpolation lab

% input parametrs for variant #9
X  = [0.0000, 0.5000, 1.0000, 1.5000, 2.0000];
Y  = [0.8360, 1.8335, 1.6771, 1.2335, 1.2154];
x0 = 0.64;

%myLagrange(X,Y,x0);
%myNewton  (X,Y);


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
% idz #2 - aproximation lab

% input patametrs for variant #9
koef_3 = [1.2, -2.2, 3.5];
koef_2 = [1.3, 2.8]; 
x_min = -0.5; x_max = 1.5;   
n = 50;    
s = 2.3
%myApproximation(koef_2,x_min,x_max,n,s);


