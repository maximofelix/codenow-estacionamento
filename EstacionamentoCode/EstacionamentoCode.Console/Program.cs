using EstacionamentoCode.Dominio.Models;

Estacionamento est = new Estacionamento();
est.Nome = "Palace Hall";
est.PrecoInicial = 5;
est.PrecoHora = 1;
est.QtdeVagasTotais = 20;

Veiculo veiculo1 = new Veiculo();
veiculo1.Placa = "AAA";
est.Estacionar(veiculo1);
veiculo1.Placa = "BBB";
est.Estacionar(veiculo1);

Console.WriteLine("Nome..............: " + est.Nome);
Console.WriteLine("Tolerância........: " + est.Tolerancia);
Console.WriteLine("Vagas Totais......: " + est.QtdeVagasTotais);
Console.WriteLine("Vagas Ocupadas....: " + est.ObterVagasOcupadas());
Console.WriteLine("Vagas Disponiveis.: " + est.ObterVagasDisponiveis());
Console.ReadKey();