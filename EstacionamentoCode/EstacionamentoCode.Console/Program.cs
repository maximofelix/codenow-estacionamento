using EstacionamentoCode.Dominio.Models;
using EstacionamentoCode.Infra.Contexts;
using System.Linq;


Estacionamento est = new Estacionamento();
est.Nome = "Palace Hall";
est.PrecoInicial = 5;
est.PrecoHora = 1;
est.QtdeVagasTotais = 20;

Veiculo veic = new Veiculo("AAA", 1);
est.Estacionar(veic, 1);

veic = new Veiculo("BBB", 1);
est.Estacionar(veic, 2);

veic = new Veiculo("CCC", 1);
est.Estacionar(veic, 3);

veic = new Veiculo("DDD", 1);
est.Estacionar(veic, 4);

Console.WriteLine("Nome..............: " + est.Nome);
Console.WriteLine("Tolerância........: " + est.Tolerancia);
Console.WriteLine("Vagas Totais......: " + est.QtdeVagasTotais);
Console.WriteLine("Vagas Ocupadas....: " + est.ObterVagasOcupadas());
Console.WriteLine("Vagas Disponiveis.: " + est.ObterVagasDisponiveis());
Console.ReadKey();