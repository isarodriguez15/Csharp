using RPGpoo;
Personagem programrpg = new Personagem();

Console.Clear();
Console.WriteLine("$*********Program Personagem**********");
Console.WriteLine();


Console.WriteLine("Digite o nome do seu personagem:");
programrpg.nome = Console.ReadLine();

Console.WriteLine("Digite a idade do seu personagem: ");
programrpg.idaderpg = int.Parse(Console.ReadLine()); 

Console.WriteLine("Informe o nome da armadura do personagem:");
programrpg.NomedaArmadura = Console.ReadLine();

Console.WriteLine("Informe a I.A que o personagem utiliza:");
programrpg.InteligenciaArtificial = Console.ReadLine();


programrpg.Ataque();
programrpg.Defender();
programrpg.RestaurarArmadura();