using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public class Entidade
    {
        private string _entidade;
        private string _cidade;
        private int _regiao;

        public string Nome { get { return _entidade; } }
        public string Cidade { get { return _cidade; } }
        public int Regiao { get { return _regiao; } }
    }
}
