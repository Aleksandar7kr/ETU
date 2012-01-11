clc; clear;

a = 0; b = 4;
n = [20, 40, 80, 160];   

for k=1:max(size(n))
    
    h = (b-a) / n(k);           
   
    X  = a : h   : b-h;     
    X2 = a : h/2 : b-h/2;       
       
    df_h  = (f(X+h)    - f(X) ) / h;
    df_h2 = (f(X2+h/2) - f(X2)) / (h/2);
        
    t=1:2:n(k)*2; df_h_2 = df_h2(t);
    
    err  = abs(df_h2 - df(X2));
    errR = abs(df_h  - df_h_2 ); 
    
    figure; plot(X2, err, X, errR,'r--'); grid;
    
   % figure; plot(X2, df(X2), X, df_h,'r*'); grid;
end