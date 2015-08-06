from Crypto import Random
from Crypto.Cipher import AES
import Tkinter
import tkFileDialog
import tkMessageBox

key = b'\xbf\xc0\x85)\x10nc\x94\x02)j\xdf\xcb\xc4\x94\x9d(\x9e[EX\xc8\xd5\xbfI{\xa2$\x05(\xd5\x18'

def pad(s):
    return s + b"\0" * (AES.block_size - len(s) % AES.block_size)


def encrypt(message, key, key_size=256):
	message = pad(message)
	iv = Random.new().read(AES.block_size)
	cipher = AES.new(key, AES.MODE_CBC, iv)
	return iv + cipher.encrypt(message)


def decrypt(ciphertext, key):
	iv = ciphertext[:AES.block_size]
	cipher = AES.new(key, AES.MODE_CBC, iv)
	plaintext = cipher.decrypt(ciphertext[AES.block_size:])
	return plaintext.rstrip(b"\0")


filename = None

def encrypt_file(filename, key):
	with open(filename, 'rb') as f:
		plaintext = f.read()
	enc = encrypt(plaintext, key)
	with open(filename + ".enc", 'wb') as f:
		f.write(enc)


def decrypt_file(filename, key):
	with open(filename, 'rb') as f:
		ciphertext = f.read()
	dec = decrypt(ciphertext, key)
	with open(filename[:-4], 'wb') as f:
		f.write(dec)


def load_file():
	global key, filename, verEncDec
	text_file = tkFileDialog.askopenfile(filetypes=[('Text Files', 'txt')])
	if text_file.name != None:
		filename = text_file.name
        

def encrypt_the_file():
	global filename, key
	if filename != None:
		encrypt_file(filename, key)
	else:
		messagebox.showerror(title="Error:", message="There was no file loaded to encrypt")


def decrypt_the_file():
	global filename, key
	if filename != None:
		fname = filename + ".enc"
		decrypt_file(fname, key)
	else:
		messagebox.showerror(title="Error:", message="There was no file loaded to decrypt")


root = Tkinter.Tk()
root.title("Cryptofile By Adnan and Farhan")
root.geometry('344x144')


lblKey = Tkinter.Label(root, text='Key:')
lblKey.place(relx=0.050, rely=0.10, relwidth=0.069, relheight=0.09)

txtKey = Tkinter.Entry(root)
txtKey.place(relx=0.144, rely=0.08, relwidth=0.796, relheight=0.124)
txtKey.insert(0,key)

btnLoadFile = Tkinter.Button(root, text="Load Text File", command=load_file)
btnLoadFile.place(relx=0.204, rely=0.268, relwidth=0.734, relheight=0.193)


btnEnc = Tkinter.Button(root, text='Encryption', command=encrypt_the_file)
btnEnc.place(relx=0.204, rely=0.502, relwidth=0.354, relheight=0.193)
        
btnDec = Tkinter.Button(root, text='Decryption', command=decrypt_the_file)
btnDec.place(relx=0.584, rely=0.502, relwidth=0.354, relheight=0.193)


root.mainloop()
