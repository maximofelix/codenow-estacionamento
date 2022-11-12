using ConsoleAppAula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula.Servicos
{
    public class EstacionamentoSvc
    {
        readonly Estacionamento _estacionamento;

        public EstacionamentoSvc(Estacionamento estacionamento)
        {
            _estacionamento = estacionamento;
        }

        public void Estacionar(string placa)
        {
            if (_estacionamento.Veiculos.Contains(placa))
                return; // Se já está estacionado, não provoca duplicidade

            _estacionamento.Veiculos.Add(placa);
        }
        public void Retirar(string placa)
        {
            _estacionamento.Veiculos.Remove(placa);
        }
        public int ContarVagasOcupadas()
        {
            return _estacionamento.Veiculos.Count();
        }
        public int ContarVagasDisponiveis()
        {
            return _estacionamento.TotalVagas + _estacionamento.Veiculos.Count();
        }
    }
}
