using DesafioPOO.Models;

// Realizando os testes com a classe Iphone
Iphone Iphone1 = new Iphone ("111111111", "15 Pro", "1234", 256);
Iphone1.Ligar();
Iphone1.ReceberLigacao();
Iphone1.InstalarAplicativo("Whatssapp");
Console.WriteLine($"Número: {Iphone1.Numero}");
Iphone1.Numero = "222222222";
Console.WriteLine($"Número: {Iphone1.Numero}\n");

// Realizando os testes com a classe Nokia
Nokia Nokia1 = new Nokia ("333333333","G60", "5678", 64);
Nokia1.Ligar();
Nokia1.ReceberLigacao();
Nokia1.InstalarAplicativo("Facebook");
Console.WriteLine($"Número: {Nokia1.Numero}");