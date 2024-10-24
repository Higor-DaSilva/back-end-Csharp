//faca um programa que rode 10 vezes e pergunte o sexo da pessoa e ao final informe
//qunatidade de pessoas de sexo feminino e masculino

int homem= 0;
int mulher = 0;


Console.WriteLine(@"
   +--------------------------------------+
   |          contador de pessoas         |
   + -------------------------------------+
   ");

for (int n = 1; n <= 10; n++)
{
    Console.WriteLine("INforme seu sexo(masculino ou feminino):");
    string sexo = Console.ReadLine()!;

    if(sexo == "masculino")
    {
        homem ++;
    }
    else
    {
        mulher ++;
    }
}

Console.WriteLine($"A quantidade de homens é {homem}");
Console.WriteLine($"A quantidade de mulheres é {mulher}");
