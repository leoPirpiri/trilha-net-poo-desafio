using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\nSmartphone iPhone:");
Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI654321", 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
