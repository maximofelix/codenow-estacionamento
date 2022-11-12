using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppAula.Models
{
    public class Estacionamento
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public int TotalVagas { get; set; }
        public bool Aberto { get; set; }

        public List<string> Veiculos;

        static int sequencial = 1;
        public Estacionamento()
        {
            Id = sequencial++;
            Veiculos = new List<string>();
        }

        public Estacionamento(string nome, int vagasTotais) : this()
        {
            Nome = nome;
            TotalVagas = vagasTotais;
            Aberto = true;
        }
    }   
}
