using PilaresPOO.Classes.Pilares;
System.Console.Clear();

ContaCorrente ctEdu  = new ContaCorrente();
ctEdu.Titular = "Eduardo";
ctEdu.Depositar (1200f);

Console.WriteLine($"Titular da conta: {ctEdu.Titular}");
Console.WriteLine($"Saldo da Conta: {ctEdu.getSaldo()}");

float valorSacado = ctEdu.Sacar(1200f);
Console.WriteLine($"Valor do saldo: {valorSacado}");
Console.WriteLine($"Novo Saldo: R${ctEdu.getSaldo()}");



