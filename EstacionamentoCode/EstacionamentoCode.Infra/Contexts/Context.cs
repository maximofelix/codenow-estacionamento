using EstacionamentoCode.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoCode.Infra.Contexts
{
    public class Context
    {
        public Context()
        {
            Veiculos = new List<Veiculo>();
            Estacionamentos = new List<Estacionamento>();
        }

        public List<Veiculo> Veiculos { get; set; }
        public List<Estacionamento> Estacionamentos { get; set; }
    }
}
