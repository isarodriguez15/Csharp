// Subclasse - Herda de Personagem
namespace PilaresPOO.Classes.Apredizagem
{
    public class Mago : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"O mago lanca o seu feitico! 🪄");
        }
    }
}