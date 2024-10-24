
Console.WriteLine(@$"


_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
  
|    Bem vindo ao programa       |
|             Nota               |
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

");


Console.WriteLine("Informe a porcentagem da sua frequencia:");
float frequencia = float.Parse (Console.ReadLine());

Console.WriteLine("Informe a sua media:");
float media = float.Parse (Console.ReadLine());


if ( frequencia >=75 && media >=7) {
    Console.WriteLine($"Aprovado");
    
} else if ( media <3 && media >7 ) {
    Console.WriteLine($"Recuperação");
    
}else {
    Console.WriteLine($"Reprovado");
}
