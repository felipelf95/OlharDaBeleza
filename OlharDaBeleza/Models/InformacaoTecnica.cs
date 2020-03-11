using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlharDaBeleza.Models.Enums;

namespace OlharDaBeleza.Models
{
    public class InformacaoTecnica
    {
        public int id { get; set; }
        public TipoDeCabelo TipoDeCabelo { get; set; }
        public string Textura { get; set; }
        public string Densidade { get; set; }
        public string Porosidade { get; set; }
        public string Elasticidade { get; set; }
        public string CondicaoCouroCabeludo { get; set; }

        public InformacaoTecnica(TipoDeCabelo tipoDeCabelo, string textura, string densidade, string porosidade, string elasticidade, string condicaoCouroCabeludo)
        {
            TipoDeCabelo = tipoDeCabelo;
            Textura = textura;
            Densidade = densidade;
            Porosidade = porosidade;
            Elasticidade = elasticidade;
            CondicaoCouroCabeludo = condicaoCouroCabeludo;
        }
    }
}
