
# Xmas Ligths
[original aquí](https://kata-log.rocks/christmas-lights-kata)
Te encantan la navidad, mucho, es lo que más te gusta y opr ello siempre quieres ser el que mas lo demuestra poniendo el que mas luces, ningún vecino te va a ganar.
Así pues te has montado una placa arduino que controla 1000x1000 de luces 
El panel de lunes empieza en el 0x0 y acaba en el 999x999 con lo que las esquinas son 
| 0.0 |0.999 |
| 999.0 |999.999 |
Las instrucciones son 
**turnOn 0.0 999,999** encendera (o dejara como esta) todas las lueces
**turnOff 499.499 500.500** apagara (o dejara como esta) las 4 luces del medio del panel.
**toggle 0.0 999.0** alternará las luces de la primera line, esto es apagará las encendidas y encenderá las apagadas

Si ejecutamos las instrucciones siguientes, cuantas luces están encedidas

turnOn 887.9 959.629
turnOn 454.398 844.448
turnOff 539.243 559.965
turnOff 370.819 676.868
turnOff 145.40 370.997
turnOff 301.3 808.453
turnOn 351.678 951.908
toggle 720.196 897.994
toggle 831.394 904.860
