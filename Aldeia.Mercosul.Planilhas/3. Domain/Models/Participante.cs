using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public class Participante : Entidade
    {
        private string _nome;
        private string _categoria;

        public Participante(string nomeEntidade, string cidade, string regiao, string nomeParticipante, string categoria) : base(nomeEntidade, cidade, regiao)
        {
            
        }
    }
}
