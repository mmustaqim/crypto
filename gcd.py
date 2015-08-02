# This is the code that calculates gcd for 2 numbers!!!!!!!!!!!!!

print ("Great Common Divisor Calculator ")

#def getInteger():
	a = int(raw_input("Please, enter a first integer: "))
	b = int(raw_input("please, enter a second integer:"))
#	return a 		
#def gcd(a,b):
#	a = int(raw_input("enter "a" number: "))
#	b = int(raw_input("enter "b" number: "))
	if b == 0:
	return a
	else:
	return gcd(b,a%b) 
