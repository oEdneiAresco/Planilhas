using DocumentFormat.OpenXml.InkML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Domain
{
    public class Grupo : Entidade
    {
        private List<string> _dancas;
        private string _email;
        private string _responsavel;
        private string _contato;

        public string Contato { get => _contato; set => _contato = value; }
        public string Responsavel { get => _responsavel; set => _responsavel = value; }
        public string Email { get => _email; set => _email = value; }
        public List<string> Dancas { get => _dancas; set => _dancas = value; }

        public Grupo(string nomeEntidade, string cidade, string regiao, string responsavel,  
                    string email, string contato, string dancas) : base(nomeEntidade, cidade, regiao)
        {
            Contato = contato;
            Responsavel = responsavel;
            Dancas = CriaListaDancas(dancas);
            Email = email;
        }

        private List<string> CriaListaDancas(string dancas)
        {
            return new List<string>();
        }
    }
}
