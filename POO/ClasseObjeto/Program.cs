//Importando as classes de dentro da pasta Classes
using System.Net.Http.Headers;
using ClasseObjeto.Classes;

//cria o objeto/variavel animal
Animal cachorro = new Animal();
Gato gato = new Gato();

cachorro.name = "Apollo";
cachorro.raca = "Labrador";
cachorro.cor = "Amarelo";
cachorro.idade = 4 ;

gato.name = "Bolota";
gato.raca = "Rua";
gato.cor = "Branca com manchas";
gato.idade = 6 ;

Console.WriteLine($"Nome do cachorro: {cachorro.name}");
Console.WriteLine($"Raça do {cachorro.name}: {cachorro.raca}");
Console.WriteLine($"Cor do {cachorro.name}: {cachorro.cor}");
Console.WriteLine($"Idade do {cachorro.name}: {cachorro.idade}");

System.Console.WriteLine();

Console.WriteLine($"Nome do Gata: {gato.name}");
Console.WriteLine($"Nome do {gato.name}: {gato.cor}");
Console.WriteLine($"Nome do {gato.name}: {gato.idade}");
Console.WriteLine($"Nome do {gato.name}: {gato.raca}");

