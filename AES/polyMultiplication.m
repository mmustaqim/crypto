function product = polyMultiplication(a , b , iprime)
product = 0;
    for l = 1 : 8
        if bitget(a , l)
            s = bitshift(b , l - 1);
            product = bitxor(product,s);
        end
    end
    for m = 16 : -1 : 9
        if bitget(product, m)
            t = bitshift(iprime,m-9);
            product = bitxor(product,t);
        end
    end
end

