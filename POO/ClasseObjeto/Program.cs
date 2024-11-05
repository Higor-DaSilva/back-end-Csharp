//Importando as classes de dentro da pasta Classes
using System.Net.Http.Headers;
using ClasseObjeto.Classes;

Console.Clear();

//cria o objeto/variavel animal
Animal cachorro = new Animal();
Animal gato = new Animal();

cachorro.name = "Apollo";
cachorro.raca = "Labrador";
cachorro.cor = "Amarelo";
cachorro.idade = 4 ;

gato.name = "Bolota";
gato.raca = "Siamês";
gato.cor = "Branca com manchas";
gato.idade = 6 ;


cachorro.FazerBarulho("Woof");
Console.WriteLine($"Idade do {cachorro.name}: {cachorro.idade}");
cachorro.Envelhecer();
Console.WriteLine($"Nova idade de {cachorro.name} é {cachorro.idade}");

System.Console.WriteLine();

gato.FazerBarulho("Moew");
Console.WriteLine($"idade da {gato.name}: {gato.idade}");
gato.Envelhecer();
Console.WriteLine($"Nova idade de {gato.name} é {gato.idade}");
