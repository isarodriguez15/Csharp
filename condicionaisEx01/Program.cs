
Console.WriteLine(@$"


_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
  
|    Bem vindo ao programa       |
|       Banco XPTO               |
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

");

Console.WriteLine($"Entre com o valor do salario recebido");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Entre com o valor do salario recebido");
float gasto = float.Parse(Console.ReadLine()!);

if (salario >= gasto)
{
    Console.WriteLine($"Gastos dentro do orcamento");
}
else
{
    Console.WriteLine($"Orcamento estourado");
}