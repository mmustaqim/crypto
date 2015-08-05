function stateout = doShifting(statein,direction)
    if(strcmp(direction,'left'))
        j = 3;
        for i = 2 : 4   
            tmp = statein(i,:);
            statein(i,:) = circshift(tmp,[1 (i-j)]);
            j = j + 2;
        end
    end
    stateout = statein;
end

