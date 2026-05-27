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
        public IReadOnlyCollection<IQuesitoCorrecao> Quesitos { get; }

        public QuesitoCorrecao(IEnumerable<IQuesitoCorrecao> quesitos)
        {
            if (quesitos == null || !quesitos.Any())
                throw new ArgumentException("Quesitos obrigatórios");

            Quesitos = quesitos.ToList();
        }
    }
}
