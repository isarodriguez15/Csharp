Console.WriteLine(@$"


_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
  
|    Bem vindo ao programa       |
|         FutResult              |
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

");

int golsTimaA;
int golsTimaB;


Console.WriteLine($"Entre com a quantidade de gols do time A");
golsTimaA = int.Parse(Console.ReadLine());

Console.WriteLine($"Entre com a quantidade de gols do time B");
golsTimaB = int.Parse(Console.ReadLine());

if (golsTimaA > golsTimaB) 

{
    Console.WriteLine($"A vitoria e do time A");
}
else
{
    Console.WriteLine($"O resultado foi um empate.3");
}