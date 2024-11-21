
namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Conta
    {
        public float Limite;

        public override bool Depositar(float valor)
        {
            if (valor > 0){
            Saldo = Saldo + valor;
            return true;
            }else
            {
                return false;
            }
        }

        public override float Sacar(float valor)
        {
            if (valor <= Saldo){
            Saldo = Saldo - valor;
            return valor;

            }else
            {
                Console.WriteLine($"Valor de saque é maior que o saldo da conta");  
                return 0;
            }

        }

        public bool Transferir(float valor, Conta contaDestino)
        {
            return false;
        }

        
    }       
}