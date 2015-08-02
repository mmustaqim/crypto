from Crypto.PublicKey import RSA
from Crypto import Random
random_generator = Random.new() .read
key = RSA.generate(1024, random_generator)
print key # key generation Algorithm #

key.can_encrypt()
key.can_sign()
key.has_private()

public_key = key.publickey()    # Encryption #
enc_data = public_key.encrypt ('abcdegh', 32)
print enc_data

print key.decrypt (enc_data) # Decryption #


