using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoCode.Dominio.Models
{
    public class Veiculo : EntityBase
    {
        public Veiculo()
        {

        }
        public Veiculo(string placa, int tipoDeVeiculo) : this()
        {
            Placa = placa;
            this.TipoDeVeiculo = tipoDeVeiculo;
        }

        public string Placa { get; set; }
        public int TipoDeVeiculo { get; set; }

        public virtual List<Vaga> Vagas { get; set; }
    }
}
