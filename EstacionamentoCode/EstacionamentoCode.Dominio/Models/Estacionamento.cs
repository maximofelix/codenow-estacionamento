using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoCode.Dominio.Models
{
    public class Estacionamento : EntityBase
    {
        public string Nome { get; set; }
        public decimal PrecoInicial { get; set; }
        public decimal PrecoHora { get; set; }
        public int Tolerancia { get; set; }
        public int QtdeVagasTotais { get; set; }
        public virtual List<Vaga> Vagas { get; set; }

        public Estacionamento()
        {
            Tolerancia = 1;
            Vagas = new List<Vaga>();
        }

        public bool Estacionar(Veiculo veiculo, int horaEntrada)
        {
            //Veiculos.Append(veiculo);
            var vaga = new Vaga(this, veiculo, horaEntrada);
            Vagas.Add(vaga);
            return true;
        }

        public int ObterVagasOcupadas()
        {
            return Vagas.Where(o => o.Ocupada).Count();
        }

        public int ObterVagasDisponiveis()
        {
            return QtdeVagasTotais - ObterVagasOcupadas();
        }

        //Obter(placa)
        //  -- Deve retornar o veículo a partir da Placa

        //CalcularValor(placa, tempo)
        //  -- Deve calcular o valor do estacionamento, com base no tempo do veículo estacionado

        //Pagar(placa)
        //  -- Deve identificar que o pagamento do estacionamento foi realizado

        //Retirar(placa)
        //  -- Deve remover o veículo do Estacionamento, desde que ele esteja pago
    }
}
