// exibir os números de 1 a 10 - while, do while e for
Console.WriteLine("Com While");
Console.WriteLine();
int numero = 1;//11
while (numero <= 10)
{
    Console.WriteLine(numero);
    numero++;
}

//Console.WriteLine(numero);//qual é o valor do número nesta linha? R11

Console.WriteLine("Com Do While");
Console.WriteLine();

numero = 1;//resetando a variável para 1
do
{
    Console.WriteLine(numero);
    numero++;
    
} while (numero <= 10);

Console.WriteLine("Com For");
Console.WriteLine();

for (int n = 1; n <= 10; n++)
{
    Console.WriteLine(n);
}
