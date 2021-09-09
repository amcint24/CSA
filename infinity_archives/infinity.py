import shutil
import zipfile, re, io, os

for i in range(1,1000):

    fn = str(i) + ".zip"

    zfile = zipfile.ZipFile(fn)
    zfile.extractall(".")
    dir = "C:\\Dev\\CSA\\infinity_archives"


    shutil.move("{2}\\{0}\\{1}.zip".format(str(i),str(i+1),dir), '.')
    shutil.move("{2}\\{0}\\{0}\\{0}".format(str(i),str(i+1),dir), '.\\{0}.txt'.format(str(i)))