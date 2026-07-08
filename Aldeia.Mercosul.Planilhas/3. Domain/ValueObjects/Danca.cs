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

        public QuesitoAvaliacao QuesitoCorrecao { get; }

        public Danca(
            string nome,
            QuesitoAvaliacao quesitoCorrecao)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome obrigatório");

            Nome = nome;
            QuesitoCorrecao = quesitoCorrecao
                ?? throw new ArgumentException("Quesito de correção obrigatório");
        }
    }
}
