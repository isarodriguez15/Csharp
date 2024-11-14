using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Apredizagem
{
    public abstract class Veiculo
    {
        public string? marca;

        public string? modelo;

        public string? cor;

        public int potencia;

        public int qtdPassageiros;

        public void Ligar()
        {
            Console.WriteLine("Seu veiculo ligou");
             
        }
        public void Desligar()
        {
            Console.WriteLine("Seu veiculo desligou");
        }
        public void Buzinar(){
            Console.WriteLine("Seu veiculo buzinou");
        }
    }
}