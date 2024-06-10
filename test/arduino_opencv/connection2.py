import cv2
import numpy as np
import matplotlib.pyplot as plt
import mediapipe as mp
import serial

DataSerial = serial.Serial('COM8',9600)
count = {'RIGHT': 0, 'LEFT': 0}
def input_Arduino(data):
    DataSerial.write(data.encode())



mp_hands = mp.solutions.hands

hands_videos = mp_hands.Hands(static_image_mode=False, max_num_hands=2, min_detection_confidence=0.5)

mp_drawing = mp.solutions.drawing_utils

def detectHandsLandmarks(image,hands):
    output_image = image.copy()
    imgRGB = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)
    results = hands.process(imgRGB)

    if results.multi_hand_landmarks :
        for hand_landmarks in results.multi_hand_landmarks:
# result.multi_hand_landmarks trả về một list gồm các phần tử, mỗi phần tử đại diện cho một bàn tay được nhận diện trong ảnh
            mp_drawing.draw_landmarks(image = output_image, landmark_list = hand_landmarks,
                                      connections = mp_hands.HAND_CONNECTIONS,
                                      landmark_drawing_spec=mp_drawing.DrawingSpec(color=(255,255,255),
                                                                                   thickness=2, circle_radius=2),
                                      connection_drawing_spec=mp_drawing.DrawingSpec(color=(0,255,0),
                                                                                     thickness=2, circle_radius=2))
    return output_image, results


def countFingers(image, results, draw=True):
    height, width, _ = image.shape
    output_image = image.copy()
    global  count
    count = {'RIGHT': 0, 'LEFT': 0}

    fingers_tips_ids = [mp_hands.HandLandmark.INDEX_FINGER_TIP, mp_hands.HandLandmark.MIDDLE_FINGER_TIP,
                        mp_hands.HandLandmark.RING_FINGER_TIP, mp_hands.HandLandmark.PINKY_TIP]

    fingers_statuses = {'RIGHT_THUMB': False, 'RIGHT_INDEX': False, 'RIGHT_MIDDLE': False, 'RIGHT_RING': False,
                        'RIGHT_PINKY': False, 'LEFT_THUMB': False, 'LEFT_INDEX': False, 'LEFT_MIDDLE': False,
                        'LEFT_RING': False, 'LEFT_PINKY': False}

    for hand_index, hand_info in enumerate(results.multi_handedness):
        '''
        results.multi_handedness là một danh sách (list) các phần tử, mỗi phần tử trong danh sách đại diện cho một bàn tay được nhận dạng
        trong hình ảnh. Mỗi phần tử này chứa thông tin về phân loại của bàn tay, bao gồm label (nhãn) và score (điểm số độ tin cậy).
        '''
        hand_label = hand_info.classification[0].label  # trả về right hoặc left
        hand_landmarks = results.multi_hand_landmarks[hand_index]
        for tip_index in fingers_tips_ids:

            finger_name = tip_index.name.split("_")[0]

            if (hand_landmarks.landmark[tip_index].y < hand_landmarks.landmark[tip_index - 2].y):
                fingers_statuses[hand_label.upper() + "_" + finger_name] = True

                count[hand_label.upper()] += 1

        thumb_tip_x = hand_landmarks.landmark[mp_hands.HandLandmark.THUMB_TIP].x
        thumb_mcp_x = hand_landmarks.landmark[mp_hands.HandLandmark.THUMB_TIP - 1].x

        if (hand_label == 'Right' and (thumb_tip_x < thumb_mcp_x)) or (
                hand_label == 'Left' and (thumb_tip_x > thumb_mcp_x)):
            fingers_statuses[hand_label.upper() + "_THUMB"] = True

            count[hand_label.upper()] += 1
    if draw:
        cv2.putText(output_image, str(sum(count.values())), (width // 2 - 150, 240), cv2.FONT_HERSHEY_SIMPLEX,
                    8.9, (20, 255, 155), 10, 10)

    return output_image, fingers_statuses

def main():
    camera_video = cv2.VideoCapture(0)
    cv2.namedWindow('Fingers Counter', cv2.WINDOW_NORMAL)
    camera_video.set(3, 1280)
    camera_video.set(4, 960)
    while camera_video.isOpened():

        ok, frame = camera_video.read()

        if not ok:
            continue
        frame = cv2.flip(frame, 1)
        frame, results = detectHandsLandmarks(frame, hands_videos)

        if results.multi_hand_landmarks:
            frame, fingers_statuses= countFingers(frame, results)

        cv2.imshow('Fingers Counter', frame)

        data = str(sum(count.values()))
        data = data + '\r'
        input_Arduino(data)
        k = cv2.waitKey(1) & 0xFF


        if (k == 27):
            break


    camera_video.release()
    cv2.destroyAllWindows()

if __name__ == "__main__":
    main()