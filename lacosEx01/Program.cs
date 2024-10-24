Console.WriteLine(@$"


_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
  
|    Bem vindo ao programa       |
|          Contador              |
|             de                 |   
|           Pessoas              |
_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

");

int qtHomem = 0;
int qtMulher = 0;
int qtEsportes = 0;
int qtnEsportes = 0;


Console.WriteLine($"Quantas pessoas tem na sua mesa");

int qtdDeEntrevistados = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual e o seu sexo? m/f");
    string sexo = Console.ReadLine();

    if (sexo == "f") 

    {
        qtMulher++;
    }
else
{
    qtHomem ++;
}

Console.WriteLine($"Voce gosta de esportes ? s/n");
string esportes = Console.ReadLine();

if (esportes == "s") 
{
    qtEsportes ++;
}
else 
{
    qtnEsportes ++;
}


}
float percentual = (100 / qtdDeEntrevistados) * qtEsportes;

Console.WriteLine($"Quantidade de Mulheres: {qtMulher}");
Console.WriteLine($"Quantidade de Homens: {qtHomem}");
Console.WriteLine($"Total de Entrevistados: {qtMulher + qtHomem}");
Console.WriteLine($"Total de pessoas que gostam de esportes: {qtEsportes}");
Console.WriteLine($"Total de pessoas que nao gostam de esportes: {qtnEsportes}");
Console.WriteLine($"Percentual de pessoas que  gostam de esportes: {percentual}");
