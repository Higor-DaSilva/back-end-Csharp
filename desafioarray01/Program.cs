// Faça um programa que carregue 1 array tamanho 6 com números inteiros. 
// Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.
Console.WriteLine(@"
   +--------------------------------------+
   |      Bem-Vindo as industrias C.T.    |
   + -------------------------------------+
   ");

int par = 0;
int impar = 0;
int[] num = new int[6];

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"Digite um número: ");
    num[i] = int.Parse(Console.ReadLine());

    if (num[i] % 2 == 0)
    {
        par++;
    }else{
        impar++;
    }
}

Console.WriteLine();


Console.WriteLine($"Numeros pares: {par} ");

for (var i = 0; i < num.Length; i++)
{
    if (num[i] % 2 == 0)
    {
        Console.Write($"{num[i]} ");
        
    }
}


Console.WriteLine();


Console.WriteLine($"Numeros impares: {impar}");

for (var i = 0; i < num.Length; i++)
{
    if (num[i] % 2 == 1)
    {
        Console.Write($"{num[i]} ");
        
    }
}
