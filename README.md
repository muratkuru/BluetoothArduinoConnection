# BluetoothArduinoConnection
An example about bluetooth communication between C# and Arduino HC-06.

### Arduino Codes
```ino
const int LED1 = 10;
const int LED2 = 11;

void setup()
{
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  
  Serial.begin(9600);  
}
 
 
void loop()
{ 
  if (Serial.available() > 0)
  {
    byte data = Serial.read();
    digitalWrite(data, digitalRead(data) == HIGH ? LOW : HIGH);
  }
}
```
