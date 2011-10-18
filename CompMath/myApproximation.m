function myApproximation(Koef,x_min,x_max,n, s)
       hold on; grid;
   size_k = length(Koef);  
   for i=1:size_k K(i) = Koef(size_k-i+1); end
     
   X = x_min:(x_max-x_min)/n:x_max;
   Y_real = polyval(K,X);
   
   Y_eps  = Y_real + (s * randn(1,length(X)));
   Y_comp = polyval(polyfit(X,Y_eps,size_k-1),X);
   
   for i = 1:size_k
       for j = 1:size_k;
           B(i,j) = sum(X.^(i+j-2));
       end
   end;
   for i=1:size_k
       C(i)=sum(X.^(i-1).*Y_eps);
   end;
   Q = (B^-1)*C';         
     
   for i=1:size_k QQ(size_k+1-i)=Q(i); end;
   
   Y_calc = polyval(QQ,X);   
   r = Y_calc - Y_eps;
   S = sqrt(sum(r.^2)/((n+1)-size_k))
   
   if ( size_k == 2)
       x_m = mean(X);
       y_m = mean(Y_eps);
       
       cov_XY = mean((X-x_m).*(Y_eps-y_m));
       disp_X = mean((X-x_m).^2);
       Y_appr = y_m + cov_XY/disp_X * (X - x_m);
       gamma = 0.95; t_gamma = 1,96;
       f_gamma = t_gamma*S/sqrt(n+1)*(1+((X-x_m)/disp_X).^2)
       F_top =    Y_comp + f_gamma;
       F_bottom = Y_comp - f_gamma;
       plot(X,Y_appr, 'y'  ); 
       plot(X,F_top, '-r'); plot(X,F_bottom, '-r');
   end

   plot(X,Y_real, '+g');                
   plot(X,Y_eps , '*r' );         
   plot(X,Y_comp, 'g'  );        
   plot(X,Y_calc, 'm'  );

end