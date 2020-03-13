using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlharDaBeleza.Models
{
    public class HistoricoQuimico
    {
        public int Id { get; set; }
        public DateTime UltimoServico { get; set; }
        public string EspecificacaoDoUltimoServico { get; set; }
        public string RespectivosProfissionais { get; set; }
        public string QuimicaUtilizada { get; set; }

        public HistoricoQuimico( int id, DateTime ultimoServico, string especificacoesDoUltimoServico, string respectivosProfissionais, string quimicaUtilizada)
        {
            Id = id;
            UltimoServico = ultimoServico;
            EspecificacaoDoUltimoServico = especificacoesDoUltimoServico;
            RespectivosProfissionais = respectivosProfissionais;
            QuimicaUtilizada = quimicaUtilizada;
        }

    }
}
