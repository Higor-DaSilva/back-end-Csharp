using Calculator.classes;

Calculadora calc = new Calculadora();

Console.WriteLine($"Digite o primeiro número:");
calc.num1 = float.Parse(Console.ReadLine()!);
System.Console.WriteLine();
Console.WriteLine($"Digite o segundo número: ");
calc.num2 = float.Parse(Console.ReadLine()!);
System.Console.WriteLine();




calc.Somar();
calc.Subtrair();
calc.Multiplicar();
calc.Dividir();
