

namespace RPGPOO.classes
{
    public class Personagem
    {
        public string nome, armadura, IA;
        public int idade, escolha;


        public void Atacar()
        {
            Console.WriteLine($"O personagem, {nome}, atacou ");

        }
        public void Defender()
        {
            Console.WriteLine($"O personagam, {nome}, Defendeu");

        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"O personagem, {nome}, restaurou sua armadura, {armadura}");

        }
    }
}