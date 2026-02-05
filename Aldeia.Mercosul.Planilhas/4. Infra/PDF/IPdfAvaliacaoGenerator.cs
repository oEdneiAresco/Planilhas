using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Infra
{
    public interface IPdfAvaliacaoGenerator
    {
        void Gerar(Grupo grupo, Danca danca, TipoAvaliacao tipo);
    }
}
