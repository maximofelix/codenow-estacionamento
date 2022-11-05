using EstacionamentoCode.Dominio.Models;
using EstacionamentoCode.Infra.Contexts;
using System.Linq;

var context = new Context();

Estacionamento est = new Estacionamento();
est.Nome = "Palace Hall";
est.PrecoInicial = 5;
est.PrecoHora = 1;
est.QtdeVagasTotais = 20;

Veiculo veic = new Veiculo();
veic.Placa = "AAA";
est.Estacionar(veic);
veic.Placa = "BBB";
est.Estacionar(veic);
veic.Placa = "CCC";
est.Estacionar(veic);
veic.Placa = "DDD";
est.Estacionar(veic);

Console.WriteLine("Nome..............: " + est.Nome);
Console.WriteLine("Tolerância........: " + est.Tolerancia);
Console.WriteLine("Vagas Totais......: " + est.QtdeVagasTotais);
Console.WriteLine("Vagas Ocupadas....: " + est.ObterVagasOcupadas());
Console.WriteLine("Vagas Disponiveis.: " + est.ObterVagasDisponiveis());
Console.ReadKey();