using System.Diagnostics.CodeAnalysis;
using Construtores.Classes;
System.Console.Clear();
int escolha = 0;

// Construtores
Aluno2 higor = new Aluno2("Higor Silva");
Aluno2 maionese = new Aluno2("Lucas mainente");
Aluno2 bryan = new Aluno2("Bryan Inacio");
Aluno2 pedro = new Aluno2("Perdro Miranda", 345);

Console.WriteLine(higor.Nome);
Console.WriteLine(higor.CPF);
Console.WriteLine(maionese.Nome);
Console.WriteLine(maionese.CPF);
Console.WriteLine(bryan.Nome);
Console.WriteLine(bryan.CPF);
Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.CPF);




// Veiculo carro1 = new Veiculo("Ford", "Ka", 2000, "Vermelho");
// Veiculo carro2 = new Veiculo("FOrd", "Mustang", 1995, "Preto");
// Aluno al1= new Aluno("Wesley", 14, "sim");
// Aluno al2= new Aluno("Dreziano", 19, "não");
// Jogo gm1 = new Jogo("Bananex", "25 de Abril", "Ação", 12.50f);
// Jogo gm2 = new Jogo("Palco", "25 de Dezembro", "Comedia", 11.50f);
// Jogo gm3 = new Jogo("MOrtal", "19 de Março", "Combate", 112.50f);
// Jogo gm4 = new Jogo("Shadow", "21 de Novembro", "Aventura", 59.99f);


// //Exibir os dados dos carros
// carro1.ExibirDados();
// carro2.ExibirDados();

// al1.MediaFinal();
// al2.MediaFinal();

// gm1.ImprimirJogo();
// gm2.ImprimirJogo();


// EStoqueJogos.Add(gm1);
// EStoqueJogos.Add(gm2);
// EStoqueJogos.Add(gm3);
// EStoqueJogos.Add(gm4);
// foreach (var jogo in EStoqueJogos)
// {
//     jogo.ImprimirJogo();

// }





List<Jogo> EStoqueJogos = new List<Jogo>();
// do
// {
//     Console.WriteLine(@$"-Menu de opções
//  1) Cadastrar Jogo
//  2) Lista de Jogos
//  3) Sair");
//     escolha = int.Parse(Console.ReadLine());
//     if (escolha == 1)
//     {
//          Console.WriteLine($"Digite o nome do jogo: ");
//                 string nome = Console.ReadLine()!;
                
//                 Console.WriteLine($"Digite o gênero do jogo: ");
//                 string genero = Console.ReadLine()!;

//                 Console.WriteLine($"Data de Lançamento do jogo: ");
//                 string lancamento = Console.ReadLine()!;
                
//                 Console.WriteLine($"Digite o preço do jogo: ");
//                 float preco = float.Parse(Console.ReadLine()!);

//                 Jogo novoJogo = new Jogo(nome,lancamento, genero, preco);
//                 EStoqueJogos.Add(novoJogo);

//                 Console.WriteLine($"Jogo '{nome}' cadastrado com sucesso!");

//     }
//     else if (escolha == 2)
//     {
//         foreach (var jogo in EStoqueJogos)
//         {
//             jogo.ImprimirJogo();
//         }
//     }

// } while (escolha <= 2 && escolha >= 0);
// Console.WriteLine($"Você saiu do Menu de Opções 👍");
