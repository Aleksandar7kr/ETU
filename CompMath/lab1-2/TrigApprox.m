function TrigApprox(T,s,r,n)
    
    X = 0 : T/n : (T-T/n);
    Y0 = testFunc(X,T);
    Y = Y0 + s*randn(1,n);
    Z = fft(Y);
    
    for R=1:n/2-1
        Z1 = Z.*((1:n<=R+1)|(1:n>=n-R+1));
        Y1 = ifftn(Z1);

        sn(R)    = sqrt(sum(abs(Y-Y1)).^2)/(n-2*R-1);
        delta(R) = sqrt(sum(abs(Y0-Y1).^2/n));
    
        if (r==R)
            plot(X,Y0,'-', X,Y,'r.', X,Y1,'g.');
        end;
    end
    S = sn(r) 
    D = delta(r)
    figure; plot(1:n/2-1,delta,'.', 1:n/2-1,sn, '-.'); grid;