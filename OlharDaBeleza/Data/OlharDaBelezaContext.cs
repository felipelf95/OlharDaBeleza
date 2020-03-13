using Microsoft.EntityFrameworkCore;
using OlharDaBeleza.Models;

namespace OlharDaBeleza.Controllers
{
    public class OlharDaBelezaContext :DbContext
    {

        public OlharDaBelezaContext(DbContextOptions<OlharDaBelezaContext> options)
            : base(options)
        {
        }

        public DbSet<DadoPessoal> DadoPessoal { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<HistoricoQuimico> HistoricoQuimico { get; set; }
        public DbSet<InformacaoTecnica> InformacaoTecnica { get; set; }


        
    }
}