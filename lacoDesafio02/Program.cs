// Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
// Total de Homens;
// Total de Mulheres;
// Média de idade dos Homens;
// Média de idade das mulheres.

Console.WriteLine(@"
   +--------------------------------------+
   |      Bem-Vindo as industrias C.T.    |
   + -------------------------------------+
   ");

int homem = 0;
int mulher = 0;
float idadehomem = 0;
float idademulher = 0;

for (int n = 1; n <= 10; n++)
{
    Console.WriteLine($"Qual seu sexo? m/f");
    string sexo = Console.ReadLine()!;

    Console.WriteLine($"Qual sua idade?");
    float idade = float.Parse(Console.ReadLine());

    // Console.WriteLine($"Qual seu peso:");
    // float peso = float.Parse(Console.ReadLine());


    if (sexo == "m")
    {
        homem++;
        idadehomem += idade;
    }
    else d
    {
        mulher++;
        idademulher += idade;
    }

}

float mediahomem = (idadehomem / homem);
float mediamulher = (idademulher / mulher);

Console.WriteLine($"Total de homens é {homem}");
Console.WriteLine($"Total de mulheres é {mulher}");
Console.WriteLine($"A media de idade dos homens é {mediahomem}");
Console.WriteLine($"A media de idade das mulheres é {mediamulher}");
