using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoCode.Dominio.Models
{
    public class Vaga : EntityBase
    {
        public Estacionamento Estacionamento { get; set; }
        public Veiculo Veiculo { get; set; }
        public bool Ocupada { get; set; } = true;
        public int HoraEntrada { get; set; }
        public Nullable<int> HoraSaida { get; set; }
        public Nullable<int> TempoEstacionado { get; set; }

        public Vaga()
        {
            Ocupada = true;
        }

        public Vaga(Estacionamento estacionamento, Veiculo veiculo, int horaEntrada) : this()
        {
            Estacionamento = estacionamento;
            Veiculo = veiculo;
            HoraEntrada = horaEntrada;
        }
    }
}
