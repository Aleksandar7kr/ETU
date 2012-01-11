function res = f1_dx(x,y)
    res = y.^sec(x.*y).^2-2*x;
end