#!/usr/bin/python3
import sys
import os
from Crypto.Cipher import AES
from base64 import b64encode

bs = 16 # blocksize
flag = str.encode(open("flag.txt").read())

key = b"" # hidden. (my usual password)

def enc(pt):
    cipher = AES.new(key, AES.MODE_ECB)
    ct = cipher.encrypt(pad(pt+key))
    res = b64encode(ct).decode("utf-8")
    return res

def pad(pt):
    while len(pt) % bs:
        pt += b'0'
    return (pt)

def main():
    print("AES-128")
    while(1):
        msg = input("Enter plaintext:\n").strip()
        pt = flag + str.encode(msg)
        ct = enc(pt)
        print(ct)
