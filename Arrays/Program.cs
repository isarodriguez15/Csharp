﻿//cria um array tamanho 3 (de 0 a 2)
string[] carros = new string[3];

for (int i = 0; i < carros.Length; i ++)

{
    Console.WriteLine($"Digite o nome do carro a ser cadastrado");
    carros[i] = Console.ReadLine();
}
Console.WriteLine($"O carro cadastrado e{carros{0}}, {carros{1}}, {carros{2}}");