using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OlharDaBeleza.Models
{
    public class DadoPessoal
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        [Display(Name = "Data De Nascimento")]
        public DateTime DataDeNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        private IObjetoEndereco _endereco;


        public DadoPessoal(IObjetoEndereco objeto)
        {
            _endereco = objeto;
        }

        public DadoPessoal()
        {
        }

        public DadoPessoal(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public DadoPessoal (string nome, string sexo, DateTime dataDeNascimento, string telefone, string email, string password, string instagram, string facebook, string cpf)

        {
            Nome = nome;
            Sexo = sexo;
            DataDeNascimento = dataDeNascimento;
            Telefone = telefone;
            Email = email;
            Password = password;
            Instagram = instagram;
            Facebook = facebook;
            Cpf = cpf;
        }



    }
}
