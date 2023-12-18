using DesafioPOO.Models;


Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "91234-5678", modelo: "Lumia 1320", imei: "123456789", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Signal");

Console.WriteLine();

Console.WriteLine("iPhone:");
Smartphone iphone = new Iphone(numero: "98765-4321", modelo: "iPhone SE", imei: "987654321", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Wild Rift");