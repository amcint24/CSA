from PIL import Image
i = Image.open("Rock_n_Roll.jpg")

pixels = i.load() # this is not a list, nor is it list()'able
width, height = i.size

all_pixels = []
for y in range(height):
    row = []
    for x in range(width):
        cpixel = pixels[x, y]
        row.append(cpixel)

    all_pixels.append(row)

s= ""



for r in all_pixels:
    for p in r:
        for v in p:
            if 64 < v < 123:
                s = s + chr(v)
s2 =""
i = 630932
while i < len(s)-1:
    s2 = s2 + s[i]
    i += 14
print(s2)
exit(1)
g=0
while g > -1:
    f = s.find("f", g)
    l = s.find("l", f)
    a = s.find("a",l)
    g = s.find("g",a)
    if l-f == a-l and l-f == g-a:
        print(s[630932])
