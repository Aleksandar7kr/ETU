function myApproximation(Koef,x_min,x_max,n, s)
   K = []; size_k = length(Koef);  
   for i=1:size_k
       K(i) = Koef(size_k-i+1);
   end
   K;
   
   X = x_min:(x_max-x_min)/n:x_max;
   Y = polyval(K,X) + (s * randn(length(X),1))';
      polyfit(X,Y,2);
      
   
end