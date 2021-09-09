import base64

with open("1.jpg", 'rb') as image:
    string1 = image.read()



with open("2.jpg", 'rb') as image:
    string2 = image.read()



with open("3.jpg", 'rb') as image:
    string3 = image.read()



with open("4.jpg", 'rb') as image:
    string4 = image.read()

for i in range(len(string1)-1):
    if string3[i] != string2 [i]:
        print(str(i) + "  str1: " + str(string3[i]) + "   str2: " + str(string2[i]))
out = ""
for i in range(1,37):
    fn = str(i) + ".jpg"
    with open(fn, 'rb') as image:
        string = image.read()
    out = out + chr(string[37743])
    print(out)


