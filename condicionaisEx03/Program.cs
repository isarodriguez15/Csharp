
Console.WriteLine(@$"


_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
  
|    Bem vindo ao programa       |
|             dos                |
|          Triangulos            |
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

");



Console.WriteLine($"informe o lado 1:");
string lado1 = Console.ReadLine();

Console.WriteLine($"informe o lado 2:");
string lado2 = Console.ReadLine();

Console.WriteLine($"informe o lado 3:");
string lado3 = Console.ReadLine();

if (lado1 == lado2 && lado2 == lado3 )
{
    Console.WriteLine($"Triângulo Equilátero");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine($"Triângulo Isóscele");
}
else
{
    Console.WriteLine($" Triângulo Escaleno");
    
}


