using DesafioPOO.Models;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(
    numero: "12345", modelo: "77889", imei: "56894", 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(
    numero: "6789", modelo: "5544", imei: "8945", 128
);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");