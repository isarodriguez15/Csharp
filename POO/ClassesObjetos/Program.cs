// Importando as classes de dentro da pasta Classes
using System.Net.Http.Headers;
using ClassesObjetos.Classes;

// Cria o objeto/variavel animal
Animal cachorro =new Animal();

cachorro.nome = "Spaik";
cachorro.raca = "Shihtzu";
cachorro.cor = "Preto e Branco";
cachorro.idade = 5;

Console.WriteLine($"Nome do cachorrinho: {cachorro.nome}");
Console.WriteLine($"Idade do cachorrinho: {cachorro.idade}");
Console.WriteLine($"Cor do cachorrinho: {cachorro.cor}");
Console.WriteLine($"Raca do cachorrinho: {cachorro.raca}");



Animal hamster =new Animal();

hamster.nome = "Pocoyo";
hamster.raca = "Hamster";
hamster.cor = "Caramelo";
hamster.idade = 2;

Console.WriteLine($"Nome do hamster: {hamster.nome}");
Console.WriteLine($"Idade do hamster: {hamster.idade}");
Console.WriteLine($"Cor do hamster: {hamster.cor}");
Console.WriteLine($"Raca do hamster: {hamster.raca}");




