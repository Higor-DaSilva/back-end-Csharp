 Console.WriteLine(@"
   +--------------------------------------+
   |      bem vindo ao banco CT           |
   + -------------------------------------+
   ");

 
Console.WriteLine("Digite seu salario");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o total gasto");
float totalGasto = float.Parse(Console.ReadLine()!);

if(salario >= totalGasto)
{
    Console.WriteLine("Gastos dentro do orcamento");
}
else
{
    Console.WriteLine("Orcamento estourado");
}