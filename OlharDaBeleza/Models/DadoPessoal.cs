using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlharDaBeleza.Models
{
    public class DadoPessoal
    {
        
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Cpf { get; set; }
        private IObjetoEndereco _endereco;


        public DadoPessoal(IObjetoEndereco objeto)
        {
            _endereco = objeto;
        }

        public DadoPessoal (string nome, string sexo, int idade, DateTime dataDeNascimento, string telefone, string email, string instagram, string facebook, string cpf)

        {
            Nome = nome;
            Sexo = sexo;
            Idade = idade;
            DataDeNascimento = dataDeNascimento;
            Telefone = telefone;
            Email = email;
            Instagram = instagram;
            Facebook = facebook;
            Cpf = cpf;
        }



    }
}
