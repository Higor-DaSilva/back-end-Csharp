// Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se

// elas gostaram um determinado produto lançado. Para isso forneceu o sexo do

// entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:

// O número de pessoas que responderam SIM;
// O número de pessoas que responderam NÃO;
// O número de mulheres que responderam SIM;
// A porcentagem de homens que responderam NÃO entre todos os homens analisados

int homem = 0;
int homemnao = 0;
int mulher = 0;
int mulhersim = 0;
int respostasim = 0;
int respostanao = 0;

Console.WriteLine(@"
   +--------------------------------------+
   |      Bem-Vindo as industrias C.T     |
   + -------------------------------------+
   ");

for (int n = 1; n <=10; n++)
{
    Console.WriteLine($"Qual seu sexo? m/f");
    string sexo = Console.ReadLine()!;

    Console.WriteLine($"Você gostou do produto? s/n");
    string resposta = Console.ReadLine()!;

    if(sexo == "m")
    {
        homem ++;
    }
    else 
    {
        mulher ++;
    }

    if(sexo == "f" && resposta == "s")
    {
        mulhersim ++;
    }
    if(sexo == "m" && resposta == "n")
    {
        homemnao ++;
    }

    if (resposta == "s")
    {
        respostasim ++;
    }
    else{
        respostanao ++;
    }
}
float percentual = (100 * homemnao) / homem;

Console.WriteLine($"Total de pessoas que dizeram 'sim' é {respostasim}");
Console.WriteLine($"Total de pessoas que dizeram 'não' é {respostanao}");
Console.WriteLine($"Total de mulheres que dizeram 'sim' é {mulhersim}");
Console.WriteLine($"Percentual de homens que dizeram 'não' é {percentual}%");

