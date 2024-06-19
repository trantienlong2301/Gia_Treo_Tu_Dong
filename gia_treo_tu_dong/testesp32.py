import urllib.request
import cv2
import numpy as np
import time
url='http://192.168.1.36/cam-lo.jpg'

fps = 1  # Lưu ảnh mỗi giây
count =0

while True:
    imgResp=urllib.request.urlopen(url)
    imgNp=np.array(bytearray(imgResp.read()),dtype=np.uint8)
    img=cv2.imdecode(imgNp,-1)
    time.sleep(1)
    if count % fps == 0:
        cv2.imwrite('image_{}.jpg'.format(count), img)

    count += 1
    # all the opencv processing is done here
    cv2.imshow('test',img)
    if ord('q')==cv2.waitKey(10):
        exit(0)


