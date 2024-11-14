
namespace PilaresPOO.Classes.Apredizagem
{
    public class Pessoa 
    {
         // Atributos - caracteristicas
         // visibilidade tipoDeDado nomeDaProp
        // nome
        public string? Nome;
        // idade
        public int Idade;
        // cpf
        public string? CPF;
        // peso
        public float Peso { get; set; }
       // altura
       public float Altura { get; set; }

       // Metodos - acoes
       // visibilidade tipoDeDadoRetornado nome(parametros){corpo}
       // Envelhecer
       public void Envelhecer()
       {
            Idade++;
       }
       // Engordar
       public void Engordar(float _kg)
       {
           Peso = Peso + _kg;
       }
       // Emagrecer
       public void Emagrecer(float _kg) 
       {
           Peso = Peso - _kg;
       }

    }
}