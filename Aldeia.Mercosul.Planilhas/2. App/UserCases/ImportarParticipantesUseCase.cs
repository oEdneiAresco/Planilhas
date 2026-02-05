using Aldeia.Mercosul.Planilhas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.App
{
    public class ImportarParticipantesUseCase
    {
        private readonly ILeitorPlanilhaParticipante _leitor;

        public ImportarParticipantesUseCase(ILeitorPlanilhaParticipante leitor)
        {
            _leitor = leitor;
        }

        public IEnumerable<PlanilhaInfo> ListarCategorias()
        {
            return _leitor.ListarAbas();
        }
    }
}
