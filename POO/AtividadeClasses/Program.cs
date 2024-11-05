using System.Net.Http.Headers;
using AtividadeClasses.Classes;

Veiculos carro = new Veiculos();
Veiculos carro2 = new Veiculos();

carro.marca = "Toyota";
carro.modelo = "Supra MK4";
carro.cor = "laranja";
carro.potencia = "326 cavalos";
carro.qtdPortas = 2; 

carro.Acelerar("4,6s");
carro.Ligar();
carro.Desligar();
carro.Freiar();

Console.WriteLine($"Qual a marca do veiculo?");
carro2.marca = Console.ReadLine();	

Console.WriteLine($"Qual o modelo do veiculo?");
carro2.modelo = Console.ReadLine();	

Console.WriteLine($"Qual a cor do veiculo?");
carro2.cor = Console.ReadLine();	

Console.WriteLine($"Qual a potencia do veiculo?");
carro2.potencia = Console.ReadLine();

Console.WriteLine($"Qual a quantidade de portas do veiculo?");
carro2.qtdPortas = int.Parse(Console.ReadLine());	

System.Console.WriteLine($"{carro2.marca}");
System.Console.WriteLine($"{carro2.modelo}");
System.Console.WriteLine($"{carro2.cor}");
System.Console.WriteLine($"{carro2.potencia}");
System.Console.WriteLine($"{carro2.qtdPortas}");


carro2.Acelerar();
carro2.Ligar();
carro2.Desligar();
carro2.Freiar();




