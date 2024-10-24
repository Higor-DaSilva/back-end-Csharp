Console.WriteLine(@"
   +--------------------------------------+
   |      Bem-Vindo as industrias C.T.    |
   + -------------------------------------+
   ");


string[] carros = new string[3]; //array tamanho 3 (vai de 0 a 2 ) - vazio

for (int n = 0; n <= 2; n++)
{
Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
carros[n] = Console.ReadLine()!;
}

for (int n = 0; n <= 2; n++)
{
System.Console.WriteLine($"O carro cadastrado é {carros[n]}");
}
