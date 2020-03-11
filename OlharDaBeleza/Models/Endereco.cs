using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlharDaBeleza.Models
{
    public class Endereco : IObjetoEndereco
    {
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string NumeroCasa { get; set; }
        public string Complemento { get; set; }

        public Endereco(string cep, string estado, string cidade, string logradouro, string numeroCasa,string complemento)
        {
            Cep = cep;
            Estado = estado;
            Cidade = cidade;
            Logradouro = logradouro;
            NumeroCasa = numeroCasa;
            Complemento = complemento;
        }



    }
}
