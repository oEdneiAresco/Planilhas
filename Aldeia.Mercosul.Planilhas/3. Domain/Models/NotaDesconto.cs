using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public class NotaDesconto
    {
        public decimal Valor { get; }
        public TipoDesconto Tipo { get; }

        public NotaDesconto(decimal valor, TipoDesconto tipo)
        {
            Valor = valor;
            Tipo = tipo;
        }
    }
}
