using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OlharDaBeleza.Models;

namespace OlharDaBeleza.Data
{
    public class OlharDaBelezaContext : DbContext
    {
        public OlharDaBelezaContext (DbContextOptions<OlharDaBelezaContext> options)
            : base(options)
        {
        }

        public DbSet<OlharDaBeleza.Models.DadoPessoal> DadoPessoal { get; set; }
    }
}
