clc;
clear;

%plain_input = 'AESUSESAMATRIXZZ';
%plain_input = [0,4,18,20;18,4,18,0;12,0,19,17;08,35,25,25];
plain_input = '00041214120412000C00131108231919';
%cipher_key = [36,117,162,179;52,117,86,136;49,226,18,0;19,170,84,135];
cipher_key =  '2475A2B33475568831E2120013AA5487';
% plain_input = [32,88,31,E0;43,5A,31,37;F6,30,98,07;A8,8D,A2,34];
% cipher_key = [2B,28,AB,09;7E,AE,F7,CF;15,D2,14,4F;16,A6,88,3C];

key = convState(cipher_key);
[subBytes,rcons,w] = makingTables(key');

fprintf('######################## ENCRYPTION ########################\n');
fprintf('============= Initial State =============\n');
state = convState(plain_input);
showHex(state);

fprintf('------------- PreRound Transformation -------------\n');
fprintf('============= Output State =============\n');
state = doAddKey(w(1:4,:),state);
showHex(state);

fprintf('============= Round Key =============\n');
showHex(w(1:4,:)');

for n = 1 : 10
    if(n ~= 10)
        fprintf('------------- Round %d Transformations -------------\n',n);
        state = doSubBytes(state,subBytes);
        fprintf('============= After SubBytes =============\n');
        showHex(state);
        state = doShifting(state,'left');
        fprintf('============= After Shifiting Rows =============\n');
        showHex(state);
        state = doMixColumn(state);
        fprintf('============= After Mixing Columns =============\n');
        showHex(state);
        state = doAddKey(w((4*n)+1:(4*n)+4,:),state);
        fprintf('============= Round Key =============\n');
        showHex(w((4*n)+1:(4*n)+4,:)');
        fprintf('============= After Add Round Key =============\n');
        showHex(state);
    else
        fprintf('------------- Round %d And Last Transformations -------------\n',n);
        state = doSubBytes(state,subBytes);
        fprintf('============= After SubBytes =============\n');
        showHex(state);
        state = doShifting(state,'left');
        fprintf('============= After Shifiting Rows =============\n');
        showHex(state);
        state = doAddKey(w((4*n)+1:(4*n)+4,:),state);
        fprintf('============= Round Key =============\n');
        showHex(w((4*n)+1:(4*n)+4,:)');
        fprintf('============= After Add Round Key =============\n');
        showHex(state);
        fprintf('============= Cipher Text =============\n');
        showHex(state);
    end
end

% sbox = subBytesTable;
% state = doSubBytes(state,sbox);
% state = doShifting(state,'left');
% state = doMixColumn(state);


%cipher_key = [36,52,48,19;117,117,226,170;162,86,18,84;179,136,0,135];
%plain_input = [0,4,18,20;18,4,18,0;12,0,19,17;08,35,25,25];
%plain_input = plain_input.';