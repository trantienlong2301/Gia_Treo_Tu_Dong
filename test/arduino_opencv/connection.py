import cv2

url = 'http://http://192.168.1.36/stream'  # URL của video stream từ ESP32-CAM
cap = cv2.VideoCapture(url)

if not cap.isOpened():
    print("Cannot open URL")
    exit()

while True:
    ret, frame = cap.read()
    if not ret:
        print("Failed to grab frame")
        break

    cv2.imshow('frame', frame)

    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

cap.release()
cv2.destroyAllWindows()
