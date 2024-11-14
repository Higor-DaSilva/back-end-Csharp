
namespace PilaresPOO.Classes.Apredizagem
{
    public class Professor : Pessoa
    {
        //Numero de identificacao do Fiscal - NIF
        public int NIF { get; set; }
        public float Salario {get; set;}

        public Professor(int _nif)
        {
            NIF = _nif;
        }
    }
}