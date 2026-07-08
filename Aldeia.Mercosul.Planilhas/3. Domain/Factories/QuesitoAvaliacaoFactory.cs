using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public static class QuesitoAvaliacaoFactory
    {
        public static List<IQuesitoAvaliacao> Criar(string nomeDanca)
        {
            if (string.IsNullOrWhiteSpace(nomeDanca))
                throw new ArgumentException("Dança inválida");

            nomeDanca = nomeDanca.Trim().ToUpper();

            switch (nomeDanca)
            {
                case "ANU":
                    return CriarAnu();

                default:
                    throw new NotImplementedException(
                        $"Tipo de dança não suportado: {nomeDanca}"
                    );
            }
        }

        private static List<IQuesitoAvaliacao> CriarAnu()
        {
            return new List<IQuesitoAvaliacao>
        {
            new HarmoniaAnu(),
            new CorrecaoAnu(),
            new InterpretacaoAnu()
        };
        }
    }
}
