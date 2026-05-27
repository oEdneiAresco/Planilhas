using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public abstract class QuesitoCorrecaoBase : IQuesitoCorrecao
    {
        public string Nome { get; protected set; }
        public int Peso { get; protected set; }

        protected QuesitoCorrecaoBase(string nome, int peso)
        {
            Nome = nome;
            Peso = peso;
        }
    }
}
