using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "11256462626", modelo: "Modelo 1", imei:"00013232545", memoria: 128);
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("Criando o iphone");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "Iphone 11", imei:"02315466", memoria: 256);
iphone.InstalarAplicativo("ClashOfClans");
iphone.ReceberLigacao();
iphone.Ligar();