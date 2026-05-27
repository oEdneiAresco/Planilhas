using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public interface IQuesitoCorrecao
    {
        string Nome { get; }
        int Peso { get; }
    }
}
