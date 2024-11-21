
namespace PilaresPOO.Classes.Pilares
{
    public class ContaPoupanca : Conta
    {
        public int LimiteSaque;
        public float Rendimentos;

        public override bool Depositar(float valor)
        {
            throw new NotImplementedException();
        }

        public override float Sacar(float valor)
        {
            throw new NotImplementedException();
        }
    }
}