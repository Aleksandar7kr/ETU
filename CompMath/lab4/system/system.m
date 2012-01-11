clc; clear; format long
 
a = -1;  b = 1;

x = a:0.01:b; 
y = x;

Y1 = f1(x,y);
Y2 = f2(x,y);
x0 = [1;1];
%plot3(x,y,Y1, x,y,Y2); grid;

hold on;
x = a:0.02:b; y = x;
[X, Y] = meshgrid(x);
Z = f1(X, Y);
contour(X, Y, Z, [0,0]);
Z = f2(X, Y);
contour(X, Y, Z, [0, 0]);
grid;
hold off;
pause;

x1 = x0;
x2 = x1 + 1;

eps = 10^(-6); out1 = []; i = 1;   

while (norm(x2 - x1) > eps)
    x1 = x2;
    Y = [f1_dx(x1(1), x1(2)), f1_dy(x1(1), x1(2));
         f2_dx(x1(1), x1(2)), f2_dy(x1(1), x1(2))];
     
    tmp = [f1(x1(1), x1(2));  f2(x1(1), x1(2))];
    x2 = x1 - Y^(-1)*tmp;      
    out1(i) = x2(1) - x1(1);   
    i = i+1;
end
x2   
i    

x1 = x0; x2 = x1 + 1;
eps = 10^(-6);
Y = [f1_dx(x2(1), x2(2)), f1_dy(x2(1), x2(2)); 
     f2_dx(x2(1), x2(2)), f2_dy(x2(1), x2(2))];
out2 = []; i = 1;
while (norm(x2 - x1) > eps)
    x1 = x2;
    tmp = [f1(x1(1), x1(2)) ;f2(x1(1), x1(2))];
    x2 = x1 - Y^(-1)*tmp;
    out2(i) = x2(1) - x1(1); 
    i = i+1;
end
x2  
i    

temp1  = (size(out1));
temp2  = (size(out2));

%figure; loglog(a:(b-a)/(temp1(2)-1):b, out1,a:(b-a)/(temp2(2)-1):b, out2, 'r--'); grid;