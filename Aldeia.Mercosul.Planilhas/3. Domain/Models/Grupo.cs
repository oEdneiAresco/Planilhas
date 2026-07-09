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
        private List<string> _dancasTexto = new List<string>();
        private List<Danca> _dancas = new List<Danca>();
        private string _email;
        private string _responsavel;
        private string _contato;

        public string Contato { get => _contato; set => _contato = value; }
        public string Responsavel { get => _responsavel; set => _responsavel = value; }
        public string Email { get => _email; set => _email = value; }
        public IReadOnlyCollection<string> DancasTexto => _dancasTexto.AsReadOnly();
        public string DancasStr => string.Join(" - ", _dancasTexto);
        public IReadOnlyCollection<Danca> Dancas => _dancas.AsReadOnly();


        public Grupo(string nomeEntidade, string cidade, string regiao, string responsavel,  
                    string email, string contato, string dancasStr) : base(nomeEntidade, cidade, regiao)
        {
            Contato = contato;
            Responsavel = responsavel;
            Email = email;
            SetDancas(dancasStr);
        }

        private void SetDancas(string dancasStr)
        {
            var dancas = dancasStr
                .Split('-', '–')
                .Select(d => d.Trim())
                .Where(d => !string.IsNullOrWhiteSpace(d))
                .ToList();

            _dancasTexto.AddRange(dancas);

            _dancas.AddRange(
                dancas.Select(DancaFactory.Criar));
        }
    }
}
