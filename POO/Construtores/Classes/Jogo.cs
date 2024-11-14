using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string Nome { get; set; }
        public string  Lancamento { get; set; }
        public string Genero { get; set; }
        public float Preco { get; set; }



        public Jogo(string nome, string lancamento, string genero, float preco)
        {
            Nome = nome;
            Lancamento = lancamento;
            Genero = genero;
            Preco = preco;

        }
        public void ImprimirJogo()
        {
            Console.WriteLine($@"
            Nome: {Nome}
            Lançamento: {Lancamento}
            Gênero: {Genero}
            Preço: R${Preco} ");

        }
    }
}