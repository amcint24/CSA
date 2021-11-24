import base64
f = "12345"
def string_to_bin_good(s):
    binary_str = ""
    for c in s:
        byte_array = c.encode()
        binary_int = int.from_bytes(byte_array, "big")
        char_str = bin(binary_int)
        binary_str += '0'
        binary_str += char_str[2:]
        binary_str += " "
    return binary_str

def string_to_bin_bad(s):
    binary_str = ""
    for c in s:
        byte_array = c.encode()
        binary_int = int.from_bytes(byte_array, "big")
        char_str = bin(binary_int)
        binary_str += '0'
        binary_str += char_str[2:]
    return binary_str

def string_to_dec_good(s):
    dec_string = ""
    for c in s:
        dec_string += str(ord(c))
        dec_string += " "
    return dec_string

def string_to_dec_bad(s):
    dec_string = ""
    for c in s:
        dec_string += str(ord(c))
    return dec_string

def string_to_hex_good(s):
    hex_string = ""
    for c in s:
        hex_string += str(hex(ord(c)))[2:].upper()
        hex_string += " "
    return hex_string

def string_to_b64_weird(s):
    b64_string = ""
    for c in s:
        b64_string += str(base64.b64encode(bytes(c, 'ascii')))[2:-1]
        b64_string += " "
    return b64_string

def string_to_b64_good(s):
    return str(base64.b64encode(bytes(s, 'ascii')))[2:-1]



print("\n\nConvert '{0}' to binary... nicely".format(f))
print(string_to_bin_good(f))

print("\n\nConvert '{0}' to decimal... nicely".format(f))
print(string_to_dec_good(f))

print("\n\nConvert '{0}' to hex... nicely".format(f))
print(string_to_hex_good(f))

print("\n\nConvert '{0}' to b64... weirdly".format(f))
print(string_to_b64_weird(f))

print("\n\nUltimately '{0}' is just a number, in binary that number is:".format(f))
print(string_to_bin_bad(f))
print("\n\nIn decimal that number is not:")
print("{0}, the seperated byte values smushed together...".format(string_to_dec_bad(f)))
print("It is:")
print(int(string_to_bin_bad(f), 2))
print("The base 10 value of the binary bytes smushed together")
print("\n\nWe can represent that number in different bases")
print("In Base16 aka hex it is:")
print(hex(int("01100110011011000110000101100111", 2))[2:])
print("\n\nIn Base64 it is:")
print(string_to_b64_good("flag"))