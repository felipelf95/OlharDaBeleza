using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlharDaBeleza.Models
{
    public class Produto
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Validade { get; set; }
        public double Preco { get; set; }

        public Produto(int cod, string nome, string descricao, DateTime validade, double preco)
        {
            Cod = cod;
            Nome = nome;
            Descricao = descricao;
            Validade = validade;
            Preco = preco;
        }


    }
}
