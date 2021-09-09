import base64
from PIL import Image
with open("Hiddensight.jpg", 'rb') as image:
    string1 = image.read()

string2 = ""
for c in string1:
    if 31 < c < 127:
        string2 = string2 + chr(c)
print(string1.hex())

print(string1.find(b'PK',221218))

