function myLagrange(X,Y, x_control)
    
    n = length(X);        %  
    max = max(X);         %   
    min = min(X);         %    
    step = (max-min)/100; % 

T = min:step:max;     %  ,     


X_distance = sort(abs(X-x_control)); %     
                                     %    *
X_Lagrange = []; %,  ,        
                 % X_distance 
Y_Lagrange = []; %,  ,       Y 
                 % X_distance
Xj = [];

for j=1:n
    for i=1:n
        if (abs(X(i)-x_control))==X_distance(j)
            X_Lagrange(j) = X(i); %  , Y,   
            Y_Lagrange(j) = Y(i); %    *
            continue
        end
    end  
end

for number=2:4
 %   hold on; grid;
    j = 0;
    sum = 0;
    
    for k=1:number
        j = j+1;
        
        for i=1:number
            if (i<j)
                Xj(i) = X_Lagrange(i);
            end
            if (i==j)
                xj = X_Lagrange(i);
            end
            if (i>j)
                Xj(i-1) = X_Lagrange(i);
            end 
        end
        
        qj = poly(Xj)/prod(xj-Xj);
        sum = sum + qj*Y_Lagrange(k);
    end 
   
    Qj = polyval(sum,T);      
%    plot(T,Qj);
    
    control = polyval(sum,x_control)
%    plot(x_control,control,'*g');

    for m=1:number
        point = polyval(sum,X_Lagrange(m));
       % plot(X_Lagrange(m),point,'*r',X,Y,'o');
    end
end

end