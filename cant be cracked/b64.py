import base64

def byte_xor(ba1, ba2):
    return bytes([_a ^ _b for _a, _b in zip(ba1, ba2)])

filebytes = b''
file = open("file.enc", "rb")
byte = file.read(1)
while byte:
    filebytes += byte
    byte = file.read(1)
# File from CC print(len(base64.b64decode(b'6YuT67K867yD76Gp7JuE7q+16LCN6bmw77KP5aaS6J+S56GX6ruq6bG85aaz6LuC')))
#print(len(filebytes))
#file64 = base64.b64encode(filebytes)
#print(file64)

fb_1 = filebytes[:16]
fb_2 = filebytes[16:32]

zeros = base64.b64decode(b'iTRm1e7qbBxJiMoFHj0pKSdqrSpAtKfj59YB+rBj4tYnaq0qQLSn4+fWAfqwY+LW')

zeros_1 = zeros[:16]
zeros_2 = zeros[16:32]
zeros_3 = zeros[32:48]

IV = byte_xor(zeros_1,zeros_2)

fb_1 = filebytes[:16]
fb_2 = filebytes[16:32]


print(fb_1.hex())
print(fb_2.hex())

bs = base64.b64decode(b'o3nvZ3bncE+7xRG8T5O1KSxiLtGz2t5JHwzjBlRQqepf+T8A8kT42ww8AaKMAcL3')
bsct = base64.b64decode(b'bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb')
test = byte_xor(bs[16:32], bsct[:16])
test2 = byte_xor(bs[16:32], bsct[16:32])
print(test2 == test)