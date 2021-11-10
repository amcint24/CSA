import sys
import socket
import time

challenge_hostname = "aes_ecb.ctf.fifthdoma.in"
challenge_port = 13378

def decode_message(m):
    return m.decode("utf-8")

def encode_message(m):
    return m.encode("utf-8")

# Connect to challenge
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
sock.connect((challenge_hostname,challenge_port))
# Recieve first message
data= decode_message(sock.recv(1024))





fifteen_zeros = "000000000000000"


# Get ct for 15 zeros + first character of key
sock.send(bytes(fifteen_zeros, 'ascii'))
sock.send(b'\n')
ct_fl = decode_message(sock.recv(1024))[42:64]
print(ct_fl)
for i in range(33, 125):



    m = str.encode(fifteen_zeros) + str.encode(chr(i))

    sock.send(m)
    sock.send(b'\n')
    ct_test = decode_message(sock.recv(1024))
    r = ct_test[42:64]
    if r == ct_fl:
        print(chr(i))
        break






