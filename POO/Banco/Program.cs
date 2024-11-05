using Banco.Classes;

System.Console.Clear();

Console.WriteLine("Bem Vindo ao Bradescuss");
Console.WriteLine();

ContaCorrente agiota = new ContaCorrente();
ContaCorrente contaLucas = new ContaCorrente();

agiota.Titular = "Wesley";
agiota.Depositar(100000f);

contaLucas.Titular = "Lucas";
contaLucas.Depositar(10f);

Console.WriteLine($"Conta do {agiota.Titular} tem R${agiota.Saldo}");
Console.WriteLine($"Conta do {contaLucas.Titular} tem R${contaLucas.Saldo}");
Console.WriteLine();


agiota.Sacar(1000f);
Console.WriteLine($"Você sacou e sua conta ficou com {agiota.Saldo}");
Console.WriteLine();

Console.WriteLine($"Conta do {agiota.Titular} tem R${agiota.Saldo}");
Console.WriteLine($"Conta do {contaLucas.Titular} tem R${contaLucas.Saldo}");
Console.WriteLine();




