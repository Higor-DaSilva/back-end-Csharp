
namespace PilaresPOO.Classes.Apredizagem
{
    public abstract class Veiculos
    {
        public string Marca;
        public string Modelo;
        public string Potencia;
        public int QtdPassageiro;

        public void Ligar()
        {
            Console.WriteLine($"O {Modelo} está ligando");
            
        }
        public void Desligar()
        {
            Console.WriteLine($"O {Modelo} está Desligando");
        }
        public void Buzinar()
        {
            Console.WriteLine($"O {Modelo} está Buzinando");

        }
    }
}