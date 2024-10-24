
Console.WriteLine(@$"


_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
  
|    Bem vindo ao programa       |
|            Venda               |
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

");


Console.WriteLine($"Quantas macas deseja comprar?:");
int quantoMacas = int.Parse(Console.ReadLine());
float valorVenda;

if (quantMacas < 12)
{
    valorVenda = quantoMacas * 0.30f;
}
else 
{
    valorVenda = quantoMacas  * 0.25f;
}

Console.WriteLine($" Valor da venda:  {valorVenda}");