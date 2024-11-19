// Classe Base
namespace PilaresPOO.Classes.Apredizagem
{
    public abstract class Personagem
    {
        // virtual significa que o metodo pode ser SOBRESCRITO na classe filha/subclasse
        // public virtual void Atacar()
        // {
        //     Console.WriteLine("O Personagem esta atacando");
        // }
        public abstract void Atacar(); 
    }
}