//Faça um programa que carregue dois vetores de 10 elementos numéricos cada um e imprima a intercalação desses dois
Console.WriteLine(@"
   +--------------------------------------+
   |      Bem-Vindo as industrias C.T.    |
   + -------------------------------------+
   ");

int [] vetor1 ={1, 3, 5, 7, 9, 11, 13, 15, 17, 19};
int [] vetor2 = {0, 2, 4, 6, 8, 10, 12, 14, 16, 18};

for (var i = 0; i < vetor1.Length; i++)
{
    Console.WriteLine(vetor1[i]);

    Console.WriteLine(vetor2[i]);
}
