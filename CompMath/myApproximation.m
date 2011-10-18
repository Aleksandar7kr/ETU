function myApproximation(Koef,a,b,N, s)
   K = []; size_k = length(Koef);  
   for i=1:size_k
       K(i) = Koef(size_k-i+1);
   end
   K;
   
   X = a:(b-a)/N:b;
   Y = polyval(K,X) + (s * randn(length(X),1))';
      polyfit(X,Y,2)
end