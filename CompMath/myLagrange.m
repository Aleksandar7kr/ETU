function myLagrange(X,Y,x0)

    n = length(X);
    T = min(X) : (max(X)-min(X))/100 : max(X);

    X_dist = sort(abs(X-x0));                                  
    for j=1:n
        for i=1:n
            if (abs(X(i)-x0))==X_dist(j)
                X_Lagrange(j) = X(i); 
                Y_Lagrange(j) = Y(i);
            end
        end  
    end

    for number=2:4
        hold on; grid;
        j = 0;
        sum = 0;
    
        for k=1:number
            j = j+1;    
            for i=1:number
                if (i <  j)   Xj(i) = X_Lagrange(i);   end
                if (i == j)   xj = X_Lagrange(i);      end
                if (i >  j)   Xj(i-1) = X_Lagrange(i); end 
            end
        
            qj  = poly(Xj)/prod(xj-Xj);
            sum = sum + qj*Y_Lagrange(k);
        end 
   
        Qj = polyval(sum,T);      
        plot(T,Qj);
        
        f_x0 = polyval(sum,x0)
        plot(x0,f_x0,'or');
    end
end