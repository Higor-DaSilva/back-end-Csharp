string[] frutas = {"Melancia", "Carambola", "Maracujá", "Morango", "Limão", "Jabuticaba", "Abacate", "Kiwi", "Acerola", "Pinha",
"lichia", "Pitaya", "Pêssego", "Banana"};

Console.Write($"Sua sacola contém {frutas.Length} frutas: ");

foreach(string f in frutas)
{
    System.Console.Write($"{f}, ");
}
