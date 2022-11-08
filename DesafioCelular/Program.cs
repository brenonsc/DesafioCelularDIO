using DesafioCelular.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("(11) 99999-9999", "Nokia", "imeiNokia", 4);
Iphone iphone = new Iphone("(11) 99999-9999", "Iphone", "imeiIphone", 8);

//Testes Nokia
Console.WriteLine("TESTES NOKIA");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("NMaps");

//Testes Iphone
Console.WriteLine("\n\nTESTES IPHONE");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iCloud");