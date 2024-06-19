#include <Stepper.h>
#include <SoftwareSerial.h>
#define sensorPower 13
#define sensorPin 7
int vegoc = 0;
int g45 = 255;
const int stepsPerRevolution = 2038; // số bước quay hết 1 vòng 360 độ
Stepper myStepper = Stepper(stepsPerRevolution, 8, 10, 9, 11);
SoftwareSerial bluetoothSerial(2, 3);
void setup() {
  Serial.begin(9600);//kết nối UART chân Tx truyền Rx nhận
  bluetoothSerial.begin(9600);  // Khởi tạo cổng nối tiếp ảo cho mô-đun Bluetooth
  pinMode(sensorPower, OUTPUT);
  digitalWrite(sensorPower, LOW);
}
void loop() {
  char dulieu;
  if (bluetoothSerial.available()) {
    char dulieu = bluetoothSerial.read();  // Đọc dữ liệu từ cổng nối tiếp ảo
    if (dulieu == '1'){ 
        myStepper.setSpeed(15);
        myStepper.step(g45-vegoc);
        vegoc = g45;
        delay(1000);  
        Serial.println("1");
        bluetoothSerial.println("1");
      }
    else if (dulieu == '2'){
        myStepper.setSpeed(15);
        myStepper.step(g45*2-vegoc);
        vegoc = g45*2;
        delay(1000);
        Serial.println("1");
        bluetoothSerial.println("1");
      }
    else if (dulieu == '3'){
        myStepper.setSpeed(15);
        myStepper.step(g45*3-vegoc);
        vegoc = g45*3;
        delay(1000);
        Serial.println("1");
        bluetoothSerial.println("1");
      }
    else if (dulieu == '4'){
        myStepper.setSpeed(15);
        myStepper.step(g45*4-vegoc);
        vegoc = g45*4;
        delay(1000);
        Serial.println("1");
        bluetoothSerial.println("1");
      }
      else if (dulieu == '5'){
        myStepper.setSpeed(15);
        myStepper.step(-vegoc);
        delay(1000);
        vegoc=0;
        Serial.println("0");
        bluetoothSerial.println("0");
      }
      else if (dulieu == '9'){//dulieu == "a"
        Serial.println("nhanduoc");
        while (1){
          String pyData = "";
    
          while(Serial.available()>0)
            {
              char c = Serial.read();
              pyData +=c;
              delay(5);
            }
          pyData.trim();
          if (pyData == "1"){ 
            myStepper.setSpeed(15);
            myStepper.step(g45-vegoc);
          vegoc = g45;
          bluetoothSerial.println("1");
          delay(1000);  
        }
        if (pyData == "2"){
          myStepper.setSpeed(15);
          myStepper.step(g45*2-vegoc);
          vegoc = g45*2;
          bluetoothSerial.println("1");
          delay(1000);
        }
        if (pyData == "3"){
          myStepper.setSpeed(15);
          myStepper.step(g45*3-vegoc);
          vegoc = g45*3;
          bluetoothSerial.println("1");
          delay(1000);
        }
        if (pyData == "goc"){
          myStepper.setSpeed(15);
          myStepper.step(-vegoc);
          vegoc = 0;
          bluetoothSerial.println("0");
          delay(1000);
        }
        char dulieu1;
        while(bluetoothSerial.available())
        {
          dulieu1 = bluetoothSerial.read();
          // if (dulieu1 == '8') break;
        }
        if (dulieu1 == '8') break;
        int van = readSensor();//tín hiệu digital 1=clear, 0=raining
        if (van == 0) {
          myStepper.setSpeed(15);
          myStepper.step(-vegoc);
          delay(1000);
          vegoc = 0;
          bluetoothSerial.println("0");
          break;
        }
    }
  }
  }
  int val = readSensor();//tín hiệu digital 1=clear, 0=raining
  if (val == 0) {
    myStepper.setSpeed(15);
    myStepper.step(-vegoc);
    delay(1000);
    vegoc = 0;
    Serial.println("0");
    bluetoothSerial.println("0");
  }
}
int readSensor() {
    digitalWrite(sensorPower, HIGH);    // Turn the sensor ON
    delay(10);                // Allow power to settle
    int val = digitalRead(sensorPin);    // Read the sensor output
    digitalWrite(sensorPower, LOW);        // Turn the sensor OFF
    return val;                // Return the value
}