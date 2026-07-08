using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public class QuesitoCorrecao
    {
        public string Nome { get; } // "Correção"

        private readonly List<DescritivoCorrecao> _descritivos;

        public IReadOnlyCollection<DescritivoCorrecao> Descritivos
            => _descritivos.AsReadOnly();

        public QuesitoCorrecao(
            string nome,
            IEnumerable<DescritivoCorrecao> descritivos)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome obrigatório");

            Nome = nome;
            _descritivos = descritivos?.ToList()
                ?? throw new ArgumentException("Descritivos obrigatórios");
        }
    }
}
