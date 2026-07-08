using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public class Entidade
    {
        public string Nome { get; }
        public string Cidade { get; }
        public string Regiao { get; }

        protected Entidade(string nome, string cidade, string regiao)
        {
            //if (string.IsNullOrWhiteSpace(nome))
            //    throw new ArgumentException("Nome é obrigatório");

            Nome = nome;
            Cidade = cidade;
            Regiao = regiao;
        }
    }
}
