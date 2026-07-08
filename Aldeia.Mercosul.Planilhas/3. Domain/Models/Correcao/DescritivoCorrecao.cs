using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public class DescritivoCorrecao
    {
        public string Texto { get; }

        private readonly List<NotaDesconto> _notas;
        public IReadOnlyCollection<NotaDesconto> Notas
            => _notas.AsReadOnly();

        public DescritivoCorrecao(
            string texto,
            IEnumerable<NotaDesconto> notas)
        {
            Texto = texto ?? throw new ArgumentException("Texto obrigatório");
            _notas = notas?.ToList()
                ?? throw new ArgumentException("Notas obrigatórias");
        }
    }
}
