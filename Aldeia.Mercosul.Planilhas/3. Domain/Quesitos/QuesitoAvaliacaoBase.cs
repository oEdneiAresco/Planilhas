using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public abstract class QuesitoAvaliacaoBase : IQuesitoAvaliacao
    {
        public string Nome { get; protected set; }
        public int Peso { get; protected set; }

        protected QuesitoAvaliacaoBase(string nome, int peso)
        {
            Nome = nome;
            Peso = peso;
        }
    }
}
