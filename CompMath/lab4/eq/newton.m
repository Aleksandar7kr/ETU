clc; clear; format long;

a = 0.01; b = 2;    
t = a:0.01:b; Y = f(t);
plot(t,Y); grid;

x0 = 2;

x1 = x0; x2 = x1;                            
eps = 10^(-6); delta = 1;
out1 = []; i = 1;  
while (delta > eps)
    x1 = x2; 
    x2 = x1 - f(x1)/df(x1); 
    delta = abs(x2 - x1);
    out1(i) = x2 - x1;
    i = i + 1;
end
disp('minimum: ');          x2   
disp('число итераций');     i   

x1 = x0; x2 = x1;
const = df(x1);
eps = 10^(-6); delta = 1;
out2 = []; i = 1; 
while (delta > eps)
    x1 = x2;
    x2 = x1 - f(x1)/const;
    delta = abs(x2 - x1);
    out2(i) = x2 - x1; 
    i = i + 1;
end
disp('minimum: ');          x2   
disp('число итераций');     i    

temp1  = size(out1);
temp2  = size(out2);

figure; fplot('f2',[a b]); grid;
fzero('f', x0)
figure; loglog(a:(b-a)/(temp1(2)-1):b, out1,a:(b-a)/(temp2(2)-1):b, out2, 'r--'); grid;
