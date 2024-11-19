

namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Conta
    {
        public float Limite { get; set; }

        public bool Transferir (float valor, Conta contaDestino){
            return false; //simulando que deu erro
        }

        public override bool Depositar(float valor)
        {
            Saldo = Saldo + valor;

            return true;
        }

        public override float Sacar(float valor)
        {
            Saldo = Saldo - valor;
            
            return valor; // devolve o valor do saque
        }
    }
}