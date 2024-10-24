Console.WriteLine(@"
   +--------------------------------------+
   |              placar do jogo          |
   + -------------------------------------+
   ");

Console.WriteLine("Gols do Sport");
float sport = float.Parse(Console.ReadLine()!);

Console.WriteLine("Gols do Santos");
float santos = float.Parse(Console.ReadLine()!);

if(sport > santos)
{
    Console.WriteLine($"O Sport ganhou do Santos com o placar de {sport} x {santos}");
}
else if (sport < santos)
{
     Console.WriteLine($"O Santos ganhou do Sport com o placar de {santos} x {sport}");
}
else
{
     Console.WriteLine($"Os times empataram com o placar de {sport} x {santos}");
}