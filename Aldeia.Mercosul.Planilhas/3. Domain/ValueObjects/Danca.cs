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

        public Danca(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome da dança inválido");

            Nome = nome.Trim();
        }

        public override string ToString() => Nome;
    }
}
