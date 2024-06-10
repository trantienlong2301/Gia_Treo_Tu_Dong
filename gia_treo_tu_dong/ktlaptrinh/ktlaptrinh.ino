#include <Stepper.h>
#define sensorPower 7
#define sensorPin 13
int vegoc = 0;
int g45 = 255;
const int stepsPerRevolution = 2038; // số bước quay hết 1 vòng 360 độ
Stepper myStepper  = Stepper(stepsPerRevolution, 8, 10, 9, 11);
const int stepsToZero = 100;
void setup() {
  Serial.begin(9600);
  pinMode(sensorPower, OUTPUT);
  digitalWrite(sensorPower, LOW);
}
void loop() {
  String dulieu = "";
  while(Serial.available()>0)
  {
    char c = Serial.read();
    dulieu +=c;
    delay(5);
  }
  dulieu.trim();// lấy dữ liệu từ serial
  if (dulieu == "1"){ 
    myStepper.setSpeed(15);
    myStepper.step(g45-vegoc);
    vegoc = g45;
    delay(1000);  
  }
  if (dulieu == "2"){
    myStepper.setSpeed(15);
    myStepper.step(g45*2-vegoc);
    vegoc = g45*2;
    delay(1000);
  }
  if (dulieu == "3"){
    myStepper.setSpeed(15);
    myStepper.step(g45*3-vegoc);
    vegoc = g45*3;
    delay(1000);
  }

  if (dulieu == "goc"){
    myStepper.setSpeed(15);
    myStepper.step(-vegoc);
    vegoc = 0;
    delay(1000);
  }
  int val = readSensor();//tín hiệu digital 1=clear, 0=raining
  if (val == 0) {
    myStepper.setSpeed(15);
    myStepper.step(-vegoc);
    delay(1000);
    vegoc = 0;
  }
}
int readSensor() {
    digitalWrite(sensorPower, HIGH);    // Turn the sensor ON
    delay(10);                // Allow power to settle
    int val = digitalRead(sensorPin);    // Read the sensor output
    digitalWrite(sensorPower, LOW);        // Turn the sensor OFF
    return val;                // Return the value
}