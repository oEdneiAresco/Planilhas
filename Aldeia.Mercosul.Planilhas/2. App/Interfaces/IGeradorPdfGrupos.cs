using Aldeia.Mercosul.Planilhas.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.App
{
    public interface IGeradorPdfGrupos<T>
    {
        void Gerar(IEnumerable<T> grupos, string caminhoSaida);
    }

}
