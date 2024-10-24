
Console.WriteLine(@$"


_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
  
|    Bem vindo ao programa       |
|            Senha               |
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

");


int Senha = 1234;

Console.WriteLine($"Digite sua senha:");
int confirmarSenha = int.Parse(Console.ReadLine());

if(Senha == confirmarSenha){
    Console.WriteLine("ACESSO PERMITIDO");
} else {
    Console.WriteLine($"ACESSO NEGADO");
}
