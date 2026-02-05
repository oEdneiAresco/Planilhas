using Aldeia.Mercosul.Planilhas.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.App
{
    public class GerarPdfGruposUseCase
    {
        private readonly IGeradorPdfGrupos<GrupoGridViewModel> _geradorPdf;

        public GerarPdfGruposUseCase(IGeradorPdfGrupos<GrupoGridViewModel> geradorPdf)
        {
            _geradorPdf = geradorPdf;
        }

        public void Executar(
            IEnumerable<GrupoGridViewModel> grupos,
            string caminhoPdf)
        {
            _geradorPdf.Gerar(grupos, caminhoPdf);
        }
    }

}
