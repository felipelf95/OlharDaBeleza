using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlharDaBeleza.Models
{
    public class Endereco : IObjetoEndereco
    {
        public  int Id { get; set; }

        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string NumeroCasa { get; set; }
        public string Complemento { get; set; }

        public Endereco(int id, string cep, string estado, string cidade, string logradouro, string numeroCasa,string complemento)
        {
            Id = id;
            Cep = cep;
            Estado = estado;
            Cidade = cidade;
            Logradouro = logradouro;
            NumeroCasa = numeroCasa;
            Complemento = complemento;
        }



    }
}
