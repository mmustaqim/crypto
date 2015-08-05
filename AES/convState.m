function [state] = convState(plain_text)
    state = zeros(4);
%     a = double(plain_text);
%     a_hex = dec2hex(a);
     z = reshape(plain_text.',1,numel(plain_text));
     z_split = reshape(cellstr(reshape(z,2,[])'),[1,16]);
%     %z_split
    b = reshape(z_split,[4,4]);
    [m , n] = size(b);
    for i = 1 : m
        for j = 1 : n
            state(i, j) = hex2dec(b(i, j));
        end
    end
    %state = {'00','12','0C','08';'04','04','00','23';'12','12','13','19';'14','00','11','19'};
    %state = [0,18,12,8;4,4,0,35;18,18,19,25;20,0,17,25];
    %state = [0,4,18,20;18,4,18,0;12,0,19,17;08,35,25,25];
    %state = plain_text.';
end

