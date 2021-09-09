

from PIL import Image
i = Image.open("flag.png")

pixels = i.load() # this is not a list, nor is it list()'able
width, height = i.size

all_pixels = []
for y in range(height):
    row = []
    for x in range(width):
        cpixel = pixels[x, y]
        row.append(cpixel)
    all_pixels.append(row)

for r in all_pixels:
    print(r)