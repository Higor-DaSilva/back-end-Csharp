using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeClasses.Classes
{
    public class Veiculos
    {
        public string marca;
        public string modelo;
        public string cor;
        public string potencia;
        public int qtdPortas;

        public void Acelerar(string acelerar = null)
        {
            Console.WriteLine($"O {modelo} faz de 0 a 100 em {acelerar}");
            
        }
        public void Ligar()
        {
            System.Console.WriteLine($"{modelo} está ligado");
        }
        public void Desligar()
        {
            Console.WriteLine($"{modelo} está desligado");
            
        }
        public void Freiar()
        {
            Console.WriteLine($"{modelo} está freiando");
            
        }
    }
}