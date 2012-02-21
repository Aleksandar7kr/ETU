clc; clear;

    x0 = -2;  
    x1 = -1.1;   
    y0 = [ 1, -3];        

    [x, y] = ode45('f268', [x0,x1], y0);

    x_answer = [x0 : 0.01 : x1];
    y_answer = answer(x_answer);

    hold on;
  %  plot(x_answer,y_answer, x,y(:,1),'r*'); grid;

    runge();
    