string = "6YuT67K867yD76Gp7JuE7q+16LCN6bmw77KP5aaS6J+S56GX6ruq6bG85aaz6LuC"

import sys
import socket
import time


challenge_hostname = "cant-be-cracked.ctf.fifthdoma.in"
challenge_port = 13379

def decode_message(m):
    return m.decode("utf-8")

def encode_message(m):
    return m.encode("utf-8")

# Connect to challenge
sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
sock.connect((challenge_hostname,challenge_port))
# Recieve first message
data= decode_message(sock.recv(1024))
print(data)

for i in range(len(string)-1):
    string = string[1:] + string[0]
    sock.send(bytes(string, 'ascii'))
    sock.send(b'\n')
    data = decode_message(sock.recv(1024))
    print(data)