
using System.Diagnostics.Contracts;

namespace PilaresPOO.Classes.Apredizagem
{
    public abstract class Pessoa
    {
        public string Nome;
        public int Idade ;
        public string CPF;
        public float Peso {get; set;} 
        public float Altura {get; set;}
 
        public void Envelhecer()
        {
            Idade++;
        }
        public void Engondar(float _kg)
        {
            Peso = Peso + _kg;
        }
        public void Emagrecer(float _kg)
        {
            Peso = Peso - _kg;
        }

    }
}