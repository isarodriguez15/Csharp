using PilaresPOO.Classes.Pilares;

ContaCorrente ctIsa = new ContaCorrente();
ctIsa.Titular = "Isabelle Rodrigues dos Reis";
ctIsa.Depositar(1000000f);// usuario colocou grana direto no saldo


Console.WriteLine($"Titular da Conta: {ctIsa.Titular}");
Console.WriteLine($"Saldo da Conta: {ctIsa.getSaldo()}");

float valorSacado = ctIsa.Sacar(1200f);

ctIsa.Sacar(1200f);
Console.WriteLine($"Valor do Saque:{valorSacado}");
Console.WriteLine($"Novo Saldo: {ctIsa.getSaldo()}");

