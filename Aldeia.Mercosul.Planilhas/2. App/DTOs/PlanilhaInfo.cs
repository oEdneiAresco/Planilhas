using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.App
{
    public class PlanilhaInfo
    {
        public int Indice { get; }
        public string Nome { get; }

        public PlanilhaInfo(int indice, string nome)
        {
            Indice = indice;
            Nome = nome;
        }

        public override string ToString() => Nome;
    }

}
