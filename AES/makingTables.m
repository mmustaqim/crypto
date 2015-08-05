function [subBytes,rconTable,keyexpand] = makingTables(cipher_key)

%SubBytes Table Generation
fprintf('-------------- SubBytes Table --------------\n');
subBytes = zeros(1,256);
inverse = 0;
iprime = bin2dec('100011011');
X = [1,0,0,0,1,1,1,1;
    1,1,0,0,0,1,1,1;
    1,1,1,0,0,0,1,1;
    1,1,1,1,0,0,0,1;
    1,1,1,1,1,0,0,0;
    0,1,1,1,1,1,0,0;
    0,0,1,1,1,1,1,0;
    0,0,0,1,1,1,1,1];
y = [1;1;0;0;0;1;1;0];

for i = 0 : 255
    c = zeros(8,1);
    for j = 0 : 255
        product = polyMultiplication(i,j,iprime);
        if (product == 1)
            inverse = j;
            %fprintf('Multiplicative Inverse of %d is %d \n',i,j);
            break;
        end
    end
    
    inverse = dec2bin(inverse,8);
    inverse = flipud(str2double(cellstr(reshape(inverse,1,[])')));
    
    for k = 1 : 8
        for l = 1 : 8
            c(k) = xor(X(k,l)*inverse(l),c(k));
        end
    end
    
    d = bin2dec(strrep(num2str(flipud(bitxor(c,y))'),' ',''));
    
    subBytes(i+1) = d;
end
    
    %Showing SubBytes Table
    showHex(reshape(subBytes,[16,16])');

%RCon Table Generation
fprintf('-------------- RCons Table --------------\n');
rconTable = zeros(10,4);
iprime = bin2dec('100011011');
rconTable(1,1) = 1;
for i = 2 : 10
    rconTable(i,1) = polyMultiplication(rconTable(i-1),2,iprime);
end
    showHex(rconTable);

%Key Expansion Generation
%fprintf('-------------- KeyExpansion Table --------------\n');
keyexpand = cipher_key;
a = 4;
for i = 5 : 44
    if(mod(i,4) == 1)
        t = keyexpand(i-1,:);
        t = circshift(t, [1 -1]);
        for j = 1 : 4
            t(1,j) = subBytes(t(j)+1);
        end
        t = bitxor(t,rconTable(i-a,:));
        t = bitxor(t,keyexpand(i-4,:));
        keyexpand(i,:) = t;
        a = a + 3;
    else
        keyexpand(i,:) = bitxor(keyexpand(i-4,:),keyexpand((i-1),:));
    end
end


end

