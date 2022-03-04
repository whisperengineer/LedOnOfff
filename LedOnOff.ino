int led=13;

void setup() {
  pinMode(led,OUTPUT);
  Serial.begin(9600);
}

void loop() {
  if(Serial.available()) //seri haberleşme var ise komutlarıişlemeye başlar
  {int a=Serial.read();  //okunan değeri a değerine atadık
  if(a=='1')

 {digitalWrite(led,HIGH);}//a=1 ise LedOn

 else if (a=='0')
 {digitalWrite(led,LOW);} //a=0 ise LedOff
  }
}
