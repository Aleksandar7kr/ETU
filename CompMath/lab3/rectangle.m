clc; clear;

a = 0; b = 4;
n = [20, 40, 80, 160]; 
disp('реальное значение');
I_real = quad('f',a,b)     

for k=1:max(size(n))
    
    h = (b-a)/n(k);    
   
    X2 = a:h/2:b;        
    X  = a:h:b;         
  
    disp('для h:');
    Ih  = h  * sum(f((2*X +h) /2))   
    disp('для h/2');
    Ih2 = h/2 * sum(f((2*X2+h/2)/2))   
    
    disp('реальная погрешность');
    err(k)  = abs( I_real - Ih2)
    disp('погрешность по рунге');
    errR(k) = abs( Ih - Ih2 )    
end

plot(n, err, n, errR,'r--'); grid;
