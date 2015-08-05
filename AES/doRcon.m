function [ rconTable ] = doRcon

    rconTable = zeros(10,4);
    iprime = bin2dec('100011011');
    rconTable(1,1) = 1;
    for i = 2 : 10
        rconTable(i,1) = polyMultiplication(rconTable(i-1),2,iprime);
    end

end

