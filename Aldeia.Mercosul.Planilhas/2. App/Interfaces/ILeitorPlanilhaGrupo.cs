using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.App
{
    public interface ILeitorPlanilhaGrupo
    {
        IEnumerable<PlanilhaInfo> ListarAbas();
        IEnumerable<Grupo> LerAba(int indiceAba);
    }
}
