function [state_out] = doAddKey(w, state_in)

key = w;

state_out = bitxor(state_in,key.');

end

