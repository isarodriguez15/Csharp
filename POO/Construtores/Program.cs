 using Construtores.Classes;


// Constutores
Aluno2 spadaMen = new Aluno2("Herik Spada", 55987);
Console.WriteLine (spadaMen.Nome); 
Console.WriteLine (spadaMen.CPF);



Aluno2 bellyBarbosa = new Aluno2("Isabelly Barbosa");
bellyBarbosa.CPF = 1234;

Aluno2 giAlves = new Aluno2("Giovanna Alves");
giAlves.CPF = 5555;

Aluno2 eduCosta = new Aluno2();
eduCosta.CPF = 6789;

Console.WriteLine(bellyBarbosa.Nome);
Console.WriteLine(bellyBarbosa.CPF);

Console.WriteLine(giAlves.Nome);
Console.WriteLine(giAlves.CPF);

Console.WriteLine(eduCosta.Nome);
Console.WriteLine(eduCosta.CPF);









// Veiculo carro1 = new Veiculo("Ford","Ka",2000,"Vermelho");
// Veiculo carro2 = new Veiculo("Ford","Mustang",1995,"Preto");


// Jogo game = new Jogo("Para todos os Garotos que ja amei","Romance",190,2018);

// game.ExibirDados();

// Aluno matriculaaluno = new Aluno("Ana Livia Junqueira",6,0001104087789);

// matriculaaluno.ExibirDados();

// List<Jogo> estoqueJogos = new List<Jogo>();

// Jogo c0Duty= new Jogo ("Call of Duty","Ação", 23, 2003);
// Jogo c0DutyColossus = new Jogo (@"Call of Duty - Shadow of the 
// Colossus", "Ação", 90, 2005);


// Jogo Multiversus = new Jogo ("Multiversus","Ação", 00 , 2022);
// Jogo valorant = new Jogo ("Valorant","Battle Shooter",00, 2022);


// estoqueJogos.Add(c0Duty);
// estoqueJogos.Add(c0DutyColossus);

// estoqueJogos.Add(Multiversus);
// estoqueJogos.Add(valorant);

// foreach (var Jogo  in estoqueJogos){
// Console.WriteLine($"Jogo: {Jogo.nome2}");
// } 