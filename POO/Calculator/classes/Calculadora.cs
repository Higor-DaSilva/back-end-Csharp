
namespace Calculator.classes
{
    public class Calculadora
    {
        public float num1 = 0f;
        public float num2 = 0f;

        public void Somar()
        {
            Console.WriteLine($"A soma fica {num1 + num2}");
            
        }
        public void Subtrair()
        {
            Console.WriteLine($"A subtração fica  {num1 - num2}");

            
        }
        public void Multiplicar()
        {
            System.Console.WriteLine($"A multiplicação  fica {num1 * num2}");


        }
        public void Dividir()
        {
            Console.WriteLine($"A divisão fica  {num1 / num2}");

            
        }

    }
}