//faca um programa que rode 10 vezes e pergunte o sexo da pessoa e ao final informe
//qunatidade de pessoas de sexo feminino e masculino

int homem = 0;
int mulher = 0;
int sport = 0;
int naogosta = 0;


Console.WriteLine(@"
   +--------------------------------------+
   |          contador de pessoas         |
   + -------------------------------------+
   ");

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int pessoas = int.Parse(Console.ReadLine()!);


for (int n = 1; n <= pessoas; n++)
{
    Console.WriteLine("INforme seu sexo(m / f)");
    string sexo = Console.ReadLine()!;
    Console.WriteLine("voce gosta de esportes(s/n)?");
    string esporte = Console.ReadLine()!;


    if (sexo == "m")
    {
        homem++;
    }
    else
    {
        mulher++;
    }

    if (esporte == "s")
    {
        sport++;
    }
    else
    {
        naogosta++;
    }


}
int entrevistados = (mulher + homem);
float percentual = (100 * sport) / entrevistados;

Console.WriteLine($"A quantidade de homens é {homem}");
Console.WriteLine($"A quantidade de mulheres é {mulher}");
Console.WriteLine($"A quantidade de pessoa que gostam de esporte é {sport}");
Console.WriteLine($"A quantidade de pessoa que nao gostam de esporte é {naogosta}");
Console.WriteLine($"A quantidade de entrevistados é {entrevistados}");
Console.WriteLine($"Percentual de pessoa que gostam de esportes é {percentual}%");

