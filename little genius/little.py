import base64
import zlib
from PIL import Image
with open("LittleGenius.png", 'rb') as image:
    string1 = image.read()

string2 = ""
for c in string1:
    if 31 < c < 127:
        string2 = string2 + chr(c)

#print(string2)
print(string1.hex())



