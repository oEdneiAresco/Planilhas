using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.App
{
    public class ImportarGruposUseCase
    {
        private readonly ILeitorPlanilhaGrupo _leitor;

        public ImportarGruposUseCase(ILeitorPlanilhaGrupo leitor)
        {
            _leitor = leitor;
        }

        public IEnumerable<PlanilhaInfo> ListarAbas()
        {
            return _leitor.ListarAbas();
        }
    }
}
