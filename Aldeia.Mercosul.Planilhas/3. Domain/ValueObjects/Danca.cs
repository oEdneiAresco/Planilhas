using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public class Danca
    {
        public string Nome { get; }

        public IReadOnlyCollection<IQuesitoAvaliacao> Quesitos { get; }

        public Danca(
            string nome,
            IEnumerable<IQuesitoAvaliacao> quesitos)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome obrigatório");

            if (quesitos == null || !quesitos.Any())
                throw new ArgumentException("A dança deve possuir pelo menos um quesito.");

            Nome = nome;
            Quesitos = quesitos.ToList().AsReadOnly();
        }
    }
}
