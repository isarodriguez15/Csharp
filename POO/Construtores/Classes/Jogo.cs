using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
         public string nome { get; set; }

        public string genero { get; set; }

        public int preco { get; set; }   

        public int lancamento { get; set; }   

        public Jogo(string nm, string gr, int pr, int lan)
        {
            nome = nm;
            genero = gr;
            preco = pr;
            lancamento = lan;
        }

         public void ExibirDados()
        {
            Console.WriteLine(@$"
            Nome: {nome}
            Genero: {genero};
            Preco: {preco};
            Lancamento: {lancamento};
           ");
        }


    }
}