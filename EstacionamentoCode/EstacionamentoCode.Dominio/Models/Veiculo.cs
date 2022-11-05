using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoCode.Dominio.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public int HoraEntrada { get; set; }
        public int HoraSaida { get; set; }
        public int TempoEstacionado { get; set; }
        public int TipoDeVeiculo { get; set; }

        //ValidarPlaca()
        //     - Deve verificar se a placa tem 3 caracteres
    }
}
