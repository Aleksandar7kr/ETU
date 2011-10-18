function myNewton(X,Y)
    

    T = min(X): (max(X)-min(X))/100 :max(X);  
    
    hold on; grid;

    for k=2:length(X)
        for i=1:k
        X_Nyuton(i) = X(i);
        Y_Nyuton(i) = Y(i);
        end
    
        size(X_Nyuton)
        P = polyfit(X_Nyuton, Y_Nyuton, k-1);
        Z = polyval(P, T);
    
        plot(T, Z, X, Y,'or');
    end  
end
    