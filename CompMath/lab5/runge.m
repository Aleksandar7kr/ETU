function runge()
%    
clc; clear;

    x0 = -2;       y0 = [1;-3];    
    
    h1 = 0.01;     h2 = h1/2;          

    x = x0;
    y = y0;
    h = h1;
    
    X1 = [];
    Y1 = [;];
    
    for t=1: 80
        X1(t) = x;
        Y1(1,t) = y(1);
        Y1(2,t) = y(2);
        
        Z1 = f268k(x,     y,      h);
        Z2 = f268k(x+h/2, y+Z1/2, h);
        Z3 = f268k(x+h/2, y+Z2/2, h);
        Z4 = f268k(x+h  , y+Z3  , h);
        
        x = x + h;
        y = y + (Z1 + 2*Z2 + 2*Z3 + Z4)/6;
    end;
   
    x = x0;
    y = y0;
    h = h2;
    
    for t=1:160    
        X2(t) = x;
        Y2(1,t) = y(1);
        Y2(2,t) = y(2);
        
        k1 = f268k(x,     y,      h);
        k2 = f268k(x+h/2, y+k1/2, h);
        k3 = f268k(x+h/2, y+k2/2, h);
        k4 = f268k(x+h  , y+k3  , h);
        
        x = x + h;
        y = y + (k1 + 2*k2 + 2*k3 + k4)/6;
    end;
 
    
    t=1:2:160;
    Yhh = Y2(:,t);
        
   % plot(X1,Y1(1,:),X2,Y2(1,:),'m--'); grid;
    
    d_runge = abs(Y1(1,:)  - Yhh(1,:))/15;
    d_real  = abs(answer(X1) - Yhh(1,:));
    
    plot(X1,d_runge,X1,d_real,'r*');