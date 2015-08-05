function stateout = doMixColumn(statein)

%Constant Matrix
 C = {'02','03','01','01';'01','02','03','01';'01','01','02','03';'03','01','01','02'};
%State
 %X = {'63','C9','FE','30';'F2','63','26','F2';'7D','D4','C9','C9';'D4','FA','63','82'};
 X = statein;
 %X = {'D4','E0','B8','1E';'BF','B4','41','27';'5D','52','11','98';'30','AE','F1','E5'};
% tC = C(1,:);
% tX = X(:,1);
tempVal = 0;
iprime = bin2dec('100011011');
%state = cell(4);
state = zeros(4);

for i = 1 : 4
    for j = 1 : 4
        for k = 1 : 4
            a = hex2dec(C(j,k));
            b = X(k,i);
            tempVal = bitxor(tempVal, polyMultiplication(a , b , iprime));
        end
        %state(j,i) = {dec2hex(tempVal,2)};
        state(j,i) = tempVal;
        tempVal = 0;
    end
end
stateout = state;


% for i = 1 : 4
%     for j = 1 : 4
%         for k = 1 : 4
%             t = gf(hex2dec(C(j,k)),8,283) * gf(hex2dec(X(k,i)),8,283);
%             t = double(t.x);
%             tempVal = bitxor(tempVal, t);
%         end
%         state(j,i) = {dec2hex(tempVal,2)};
%         tempVal = 0;
%     end
% end

% for i = 1 : 4
%     for j = 1 : 4
%         for k = 1 : 4
%             for l = 1 : 8
%                 if bitget(hex2dec(C(j,k)), l)
%                     t = bitshift(hex2dec(X(k,i)), l - 1);
%                     tempVal = bitxor(tempVal,t);
%                 end
%             end
%             t = 0;
%             for m = 16 : -1 : 9
%                 if bitget(tempVal, m)
%                     t = bitshift(iprime,m-9);
%                     tempVal = bitxor(tempVal,t);
%                 end
%             end
%         end
%         state(j,i) = {dec2hex(tempVal,2)};
%         tempVal = 0;
%     end
% end

% for i = 1 : 4
%     for j = 1 : 4
%         for k = 1 : 4
%             t = hex2dec(C(j,k)) * hex2dec(X(k,i));
%             if (t >= 255)
%                 t = gf(hex2dec(C(j,k)),8,283) * gf(hex2dec(X(k,i)),8,283);
%                 t = double(t.x);
%                 tempVal = bitxor(tempVal, t);
%             else
%                 tempVal = bitxor(tempVal, t);
%             end
%         end
%         state(j,i) = double(tempVal);
%         tempVal = 0;
%     end
% end

end

