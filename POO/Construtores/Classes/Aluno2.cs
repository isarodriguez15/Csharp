
namespace Construtores.Classes
{
    public class Aluno2
    {
        public string Nome;

        public int CPF;
        public Aluno2(){}    

        public Aluno2 (string _chuchu){
            Nome = _chuchu;
        }

        public Aluno2 (string nome, int cpf){

            Nome = nome;
            CPF = cpf;
        }
        
      }
    }
