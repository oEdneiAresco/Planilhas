using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public static class DancaFactory
    {
        public static Danca Criar(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Dança inválida");

            nome = nome.Trim().ToUpper();

            if (nome == "ANU")
                return CriarAnu();

            throw new NotImplementedException($"Dança não suportada: {nome}");
        }

        private static Danca CriarAnu()
        {
            var quesitos = new List<IQuesitoCorrecao>
        {
            new HarmoniaAnu(),
            new CorrecaoAnu(),
            new InterpretacaoAnu()
        };

            var quesitoCorrecao = new QuesitoCorrecao(quesitos);

            return new Danca("ANU", quesitoCorrecao);
        }
    }
}
