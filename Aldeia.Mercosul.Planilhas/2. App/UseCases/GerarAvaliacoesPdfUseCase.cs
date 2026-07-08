using Aldeia.Mercosul.Planilhas.Domain;
using Aldeia.Mercosul.Planilhas.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.App
{
    public class GerarAvaliacoesPdfUseCase
    {
        private readonly IPdfAvaliacaoGenerator _pdfGenerator;

        public GerarAvaliacoesPdfUseCase(IPdfAvaliacaoGenerator pdfGenerator)
        {
            _pdfGenerator = pdfGenerator;
        }

        public void Executar(IEnumerable<Grupo> grupos)
        {
            foreach (var grupo in grupos)
            {
                foreach (var danca in grupo.Dancas)
                {
                    GerarTresAvaliacoes(grupo, danca);
                }
            }
        }

        private void GerarTresAvaliacoes(Grupo grupo, Danca danca)
        {
            Gerar(grupo, danca, TipoAvaliacao.Correcao);
            Gerar(grupo, danca, TipoAvaliacao.Harmonia);
            Gerar(grupo, danca, TipoAvaliacao.Interpretacao);
        }

        private void Gerar(Grupo grupo, Danca danca, TipoAvaliacao tipo)
        {
            _pdfGenerator.Gerar(grupo, danca, tipo);
        }
    }
}
