﻿// Heranca
// Abstracao
// Encapsulamento
// Polimorfismo

using PilaresPOO.Classes.Apredizagem;

Pessoa joao = new Pessoa();
joao.Nome = "Joao";

Console.WriteLine($"{joao.Nome}Nasceu com {joao.Idade}anos");

Professor sam = new Professor(123321);
sam.Nome = "Samanta";
sam.Idade = 22;

Aluno isaacBorges = new Aluno();
isaacBorges.Nome = "Isaac Borges";
isaacBorges.Idade = 17;
isaacBorges.CPF = "123456";
isaacBorges.Peso = 50.00f;
isaacBorges.Altura = 1.82f;
isaacBorges.Matricula = 1234567;
isaacBorges.Curso = "Dev";
isaacBorges.Media = 7.9f;

// Exibir dados
Console.WriteLine($"Aluno: {isaacBorges.Nome}");
Console.WriteLine($"Professor: {sam.Nome}");
Console.WriteLine($"Identificacao do Professor: {sam.NIF}");


Console.WriteLine($"Aluno: {isaacBorges.Nome}");
Console.WriteLine($"Idade: {isaacBorges.Idade}");
Console.WriteLine($"CPF: {isaacBorges.CPF}");
Console.WriteLine($"Peso: {isaacBorges.Peso}");
Console.WriteLine($"Altura: {isaacBorges.Altura}");
Console.WriteLine($"Matricula: {isaacBorges.Matricula}");
Console.WriteLine($"Curso: {isaacBorges.Curso}");
Console.WriteLine($"Media: {isaacBorges.Media}");
Console.WriteLine($"{isaacBorges.Nome}Nasceu com {isaacBorges.Idade}anos");

Carro skiline  = new Carro();
skiline.marca = "nissan";
skiline.modelo = "skiline";
skiline.cor = "preto";
skiline.potencia = 222;
skiline.qtdPortas = 4;



Aviao asas = new Aviao();

asas.marca = "bong";
asas.modelo = "747";
asas.cor = "branco";
asas.potencia = 2222;
asas.qtdPortas = 8;


Moto ran = new Moto();
ran.marca = "TRIUMPH";
ran.modelo = "Tiger";
ran.cor = "vermelho";
ran.potencia = 2222;
ran.rodas = 2;



Console.WriteLine($@"seu carro: 
Marca:{skiline.marca}
Modelo:{skiline.modelo}
Cor:{skiline.cor}
Potencia:{skiline.potencia}
POrta:{skiline.qtdPortas}
");

Console.WriteLine($@"seu aviao: 
Maraca:{asas.marca}
MOdelo:{asas.modelo}
Cor:{asas.cor}
Potencia:{asas.potencia}
Portas:{asas.qtdPortas}
");

Console.WriteLine($@"sua moto: 
Marca:{ran.marca}
Modelo:{ran.modelo}
Cor:{ran.cor}
Potencia:{ran.potencia}
Rodas:{ran.rodas}
");



