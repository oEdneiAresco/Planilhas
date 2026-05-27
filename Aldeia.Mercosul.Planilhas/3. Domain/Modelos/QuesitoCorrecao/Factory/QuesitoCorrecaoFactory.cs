using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public static class QuesitoCorrecaoFactory
    {
        public static List<IQuesitoCorrecao> Criar(TipoDanca tipo)
        {
            switch (tipo)
            {
                case TipoDanca.ANU:
                    return CriarAnu();

                default:
                    throw new NotImplementedException($"Tipo de dança não suportado: {tipo}");
            }
        }

        private static List<IQuesitoCorrecao> CriarAnu()
        {
            return new List<IQuesitoCorrecao>
            {
                new HarmoniaAnu(),
                new CorrecaoAnu(),
                new InterpretacaoAnu()
            };
        }
    }
}
