using RPGPOO.classes;
System.Console.Clear();

Personagem persona = new Personagem();

Console.WriteLine($"Qual o nome do seu persongam?🧐");
persona.nome = Console.ReadLine()!;
Console.WriteLine($"Qual a idade do {persona.nome}?🧐");
persona.idade = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Qual o nome da armadura do {persona.nome}?🧐");
persona.armadura = Console.ReadLine()!;
Console.WriteLine($"Qual IA ajuda {persona.nome}🧐");
persona.IA = Console.ReadLine()!;

System.Console.WriteLine();

Console.WriteLine($@"{persona.nome},
{persona.idade},
{persona.armadura},
{persona.IA}");

System.Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Qual ação {persona.nome} irá fazer");
    Console.WriteLine($@"
1- Atacar
2- Defender
3- Restaurar a Armadura");
    persona.escolha = int.Parse(Console.ReadLine()!);
    if (persona.escolha == 1)
    {
        persona.Atacar();
    }
    else if (persona.escolha == 2)
    {
        persona.Defender();
    }
    else if (persona.escolha == 3)
    {
        persona.RestaurarArmadura();
    }
System.Console.WriteLine();
}


