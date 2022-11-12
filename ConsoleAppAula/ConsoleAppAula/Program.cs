using ConsoleAppAula.Models;
using ConsoleAppAula.Servicos;

Estacionamento est = new Estacionamento("Park Code", 10);

EstacionamentoSvc svc = new EstacionamentoSvc(est);

Console.WriteLine(": APP: Estacionamento   ");
Console.WriteLine(": Id................. : " + est.Id);
Console.WriteLine(": Nome............... : " + est.Nome);
Console.WriteLine(": Vagas.............. : " + est.TotalVagas);

svc.Estacionar("AAA");  // veiculos = 1
svc.Estacionar("BBB");  // veiculos = 2
svc.Estacionar("CCC");  // veiculos = 3
svc.Estacionar("CCC");  // veiculos = 3 (repetido)
svc.Retirar("BBB");     // veiculos = 2
svc.Retirar("EEE");     // veiculos = 2 (nao localizado)
svc.Estacionar("DDD");  // veiculos = 3
svc.Estacionar("EEE");  // veiculos = 4

Console.WriteLine(": Vagas Ocupadas..... : " + svc.ContarVagasOcupadas());
Console.WriteLine(": Vagas Disponíveis.. : " + svc.ContarVagasDisponiveis());
