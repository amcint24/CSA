import socket
import sys
import base64


hostname = 'mr-basebot.ctf.fifthdoma.in'
port = 9567

sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
sock.connect((hostname,port))

data = sock.recv(1024).decode('utf-8')

print(data)

def parse_base(m):
    i = m.find("Base") + 4
    j = i + 2
    return m[i:j]

def parse_text(m):
    i = m.find("\'")
    j = m.find("\'",i+1 )
    return m[i+1:j]
count = 1
while True:

    if data.find("flag") > 0:
        print(data)
        exit(0)
    base = parse_base(data)
    text = parse_text(data)
    if base == "64":
        b64_str = base64.b64encode(bytes(parse_text(data),'utf-8'))
        sock.send(b64_str)
        sock.send(b'\n')
    if base == "32":
        b32_str = base64.b32encode(bytes(parse_text(data),'utf-8'))
        sock.send(b32_str)
        sock.send(b'\n')
    if count % 10 == 0:
        print("Count: {0} - Base: {1} - Text: {2}".format(count, base,text))
    if count > 620:
        exit(1)
    data = sock.recv(1024).decode('utf-8')
    count += 1


