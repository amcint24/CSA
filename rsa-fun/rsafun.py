import socket
import sys
import base64
import math



hostname = 'fun_with_rsa.ctf.fifthdoma.in'
port = 2143

sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
sock.connect((hostname,port))

data = sock.recv(4096).decode('utf-8')
print(data)

def InttoString(i):
    h = hex(i)
    s = ""
    i = 2
    j = 4
    while j <= len(h):
        hex_chr = "0x" + h[i:j]
        int_chr = int(hex_chr, base=16)
        s += chr(int_chr)
        i+=2
        j+=2
    return s


def getModInverse(a, m):
    if math.gcd(a, m) != 1:
        return None
    u1, u2, u3 = 1, 0, a
    v1, v2, v3 = 0, 1, m

    while v3 != 0:
        q = u3 // v3
        v1, v2, v3, u1, u2, u3 = (
            u1 - q * v1), (u2 - q * v2), (u3 - q * v3), v1, v2, v3
    return u1 % m

def dec(p,q,e,ct):

    n = p*q

    # compute n
    n = p * q

    # Compute phi(n)
    phi = (p - 1) * (q - 1)

    # Compute modular inverse of e
    d = getModInverse(e, phi)



    # Decrypt ciphertext
    pt = pow(ct, d, n)
    return int(pt)




def parse_p(m):
    i = m.find("p") + 4
    j = m.find("\n", i + 1)
    return int(m[i:j])

def parse_q(m):
    i = m.find("q") + 4
    j = m.find("\n", i + 1)
    return int(m[i:j])

def parse_e(m):
    i = m.find("e") + 4
    j = m.find("\n", i + 1)
    return int(m[i:j])

def parse_ct(m):
    i = m.find("ciphertext") + 13
    j = m.find("\n", i + 1)
    return int(m[i:j])

while True:
    p1 = parse_p(data)
    q1 = parse_q(data)
    e1 = parse_e(data)

    ct1 = parse_ct(data)
    pt_int = dec(p1,q1,e1,ct1)
    pt_str = InttoString(pt_int)
    print(pt_int)
    print(pt_str)
    sock.send(bytes(pt_str, 'utf-8'))
    sock.send(b'\n')
    data = sock.recv(4096).decode('utf-8')
    print(data)

