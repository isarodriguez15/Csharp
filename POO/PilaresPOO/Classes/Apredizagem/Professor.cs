using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Apredizagem
{
    public class Professor : Pessoa
    {
        // Numero de Indentificacao Fiscal - Nif
        // Salario

        public int NIF { get; set; }

        public float Salario { get; set; }


        public Professor(int _nif)
        {
            NIF = _nif;
        }
    }
}