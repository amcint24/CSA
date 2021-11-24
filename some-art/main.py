from PIL import Image


# Get the pixel values into a table
image = Image.open('pm.png')
pixels = list(image.getdata())
width, height = image.size
pixels = [pixels[i * width:(i + 1) * width] for i in range(height)]
print(pixels[0])
print(pixels[1])
print(pixels[2])

exit(0)




















# Confirm 192, 255, and 0 are the only values in the top row
top_row = pixels[0]
off_values = 0
for n in top_row:
    if n not in [0, 192, 255]:
        off_values += 1
        print(n)
print("\n \nFound {0} off values".format(off_values))

exit(0)




















# Get indices of zeros
indicies = []
for i in range(len(top_row)-1):
    if top_row[i] == 0:
        indicies.append(i)
print("\n \nZeros occur at the following indicies:")
print(indicies)
print("There is a total of {0} zeros".format(len(indicies)))

exit(0)




















# Get gaps between indicies
print("We add 0 to the start of the list of indicies so we can count the fist 'gap'")
indicies = [0] + indicies
print(indicies)
gaps = []
for i in range(1, len(indicies)-1):
    gaps.append(indicies[i] - (indicies[i-1] + 1))
print("\n \nThe gaps between zero index locations are:")
print(gaps)

exit(0)




















# Force integer division by 3 on each gap
floored_gaps = []
for n in gaps:
    n = n//3
    floored_gaps.append(n)
print("\n \nThe gaps, divided by three and rounded down to the nearest integer are:")
print(floored_gaps)

exit(0)

# Print the character value of the numbers that aren't zero:
print("\n \nConverting the rounded and divide gap sizes to characters yields:")
output = ""
for n in floored_gaps:
    if n != 0:
        output += chr(n)
print(output)



