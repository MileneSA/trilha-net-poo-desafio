using DesafioPOO.Models;

//  Implementado

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero:"1234", modelo:"Nokia 5", imei:"321", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Linkedin");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");

Smartphone iphone = new Iphone(numero:"9999", modelo:"Iphone x", imei:"1111", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");