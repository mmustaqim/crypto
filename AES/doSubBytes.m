function state = doSubBytes(statein,sbox)
    
    state = statein;
    [m , n] = size(state);
    
    for i = 1 : m
        for j = 1 : n
            state(i,j) = sbox(state(i,j)+1);
        end
    end
    
end

