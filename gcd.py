import random
Number1=int(raw_input('1st no \n'))
Number2=int(raw_input('2nd no \n'))
#Number1 = random.randint(1, 100)
#Number2 = random.randint(1, 50)
T0 = 0
T1 = 1
T = 0
print("Number1 = " , Number1)
print("Number2 = " ,Number2)
Quotient = 0
Remainder = 0
while (Number2 != 0):
    Quotient = int(Number1 / Number2);
    T = T0 - int(T1 * Quotient);
    Remainder = Number1 % Number2;
    #print("Quotient =" , Quotient , "\tNumber1 =" , Number1 , "\tNumber2 = " , Number2 , "\tRemainder = " , Remainder , "\tT0 = " , T0 , "\tT1 = " , T1 , "  \tT = " , T)
    Number1 = Number2;
    Number2 = Remainder;
    T0 = T1;
    T1 = T;
    
print("GCD is " , Number1);
if (Number1 == 1 ):
    print("Since GCD = 1 ; So Multiplicative Inverse Exists.");
    if(T0<0):
        print("Multiplicative Inverse =  " , (T0 + T1));
    elif(T1 < 0):
        print("Multiplicative Inverse =  " , (T0));
else:
    print("Since GCD != 1 ; So Multiplicative Inverse Does Not Exist.");
