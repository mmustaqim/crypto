function [ state_out ] = showHex(state_in)
    [m, n] = size(state_in);
    a_hex = dec2hex(state_in);
    z = reshape(a_hex.',1,numel(a_hex));
    z_split = reshape(cellstr(reshape(z,2,[])'),[1,length(a_hex)]);
    state_out = reshape(z_split,[m,n]);
    disp(state_out);
end

