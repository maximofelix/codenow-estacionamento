using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoCode.Dominio.Models
{
    public class Estacionamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoInicial { get; set; }
        public decimal PrecoHora { get; set; }
        public int Tolerancia { get; set; }
        public int QtdeVagasTotais { get; set; }
        public List<Veiculo> Veiculos { get; set; }

        public Estacionamento()
        {
            Tolerancia = 1;
            Veiculos = new List<Veiculo>();
        }

        public bool Estacionar(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
            return true;
        }

        public int ObterVagasOcupadas()
        {
            return Veiculos.Count();
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
