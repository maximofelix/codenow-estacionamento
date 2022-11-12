using EstacionamentoCode.Dominio.Models;
using Microsoft.EntityFrameworkCore;

namespace EstacionamentoCode.Infra.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Estacionamento> Estacionamentos { get; set; }

        public Estacionamento CriarEstacionamentoTeste()
        {
            var est = new Estacionamento
            {
                Nome = "Estacionamento Code Now!",
                PrecoInicial = 3,
                PrecoHora = 1,
                QtdeVagasTotais = 5,
                Tolerancia = 0,
                DataCadastro = DateTime.Now
            };
            this.Estacionamentos.Add(est);

            Veiculo veic = new Veiculo("AAA", 1);
            est.Estacionar(veic, 1);

            veic = new Veiculo("BBB", 1);
            est.Estacionar(veic, 2);

            veic = new Veiculo("CCC", 1);
            est.Estacionar(veic, 3);

            veic = new Veiculo("DDD", 1);
            est.Estacionar(veic, 4);

            this.SaveChanges();
            return est;
        }
    }
}