
// 4) Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário.     A     senha     válida     é     o     número     1234.    Devem     ser    impressas     as    seguintes     mensagens:     

//    - ACESSO    PERMITIDO    caso    a    senha    seja    válida.     
//    - ACESSO    NEGADO    caso    a    senha    seja    inválida

Console.WriteLine(@"
   +--------------------------------------+
   |                 Sua senha            |
   + -------------------------------------+
   ");

Console.WriteLine("senha");
float senha1 = float.Parse(Console.ReadLine()!);

Console.WriteLine("confirme sua senha");
float senha2 = float.Parse(Console.ReadLine()!);

if(senha1 == senha2)
{
    Console.WriteLine($"Acesso Permitido");
}
else
{
     Console.WriteLine($"Acesso Negado");
}