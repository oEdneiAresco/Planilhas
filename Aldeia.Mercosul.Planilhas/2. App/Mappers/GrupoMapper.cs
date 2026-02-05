using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.App
{
    public static class GrupoMapper
    {
        public static GrupoGridViewModel ToViewModel(Grupo grupo)
        {
            return new GrupoGridViewModel
            {
                Nome = grupo.Nome,
                Cidade = grupo.Cidade,
                RT = grupo.Regiao,
                Responsavel = grupo.Responsavel,
                Email = grupo.Email,
                Contato = grupo.Contato,
                Dancas = grupo.DancasStr
            };
        }

        public static Grupo ToDomain(GrupoGridViewModel vm)
        {
            return new Grupo(
                vm.Nome,
                vm.Cidade,
                vm.RT,
                vm.Responsavel,
                vm.Email,
                vm.Contato,
                vm.Dancas
            );
        }
    }

}
