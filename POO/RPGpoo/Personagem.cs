using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGpoo
{
    public class Personagem
    {
        public string nome = "nulo";

        public int idaderpg;

        public string NomedaArmadura = "nulo";

        public string InteligenciaArtificial = "nulo";

        public void Ataque ()
        {Console.WriteLine("O personagem atacou!:");}
        public void Defender ()
        {Console.WriteLine("O personagem restaurou a armadura!:");}
        public void RestaurarArmadura ()
        {Console.WriteLine("O personagem defendeu!:");}

    }
}