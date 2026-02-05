using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.App
{
    public class AvaliacaoContextoDto
    {
        public string NomeGrupo { get; }
        public string Cidade { get; }
        public Danca Danca { get; }
        public TipoAvaliacao Tipo { get; }

        public AvaliacaoContextoDto(
            string nomeGrupo,
            string cidade,
            Danca danca,
            TipoAvaliacao tipo)
        {
            NomeGrupo = nomeGrupo;
            Cidade = cidade;
            Danca = danca;
            Tipo = tipo;
        }
    }
}
