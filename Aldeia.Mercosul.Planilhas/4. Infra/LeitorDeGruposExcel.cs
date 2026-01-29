using Aldeia.Mercosul.Planilhas.App;
using Aldeia.Mercosul.Planilhas.Domain;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldeia.Mercosul.Planilhas.Infra
{
    public class LeitorDeGruposExcel : ILeitorPlanilhaGrupo
    {
        private readonly string _caminhoArquivo;

        public LeitorDeGruposExcel(string caminhoArquivo)
        {
            _caminhoArquivo = caminhoArquivo;
        }

        public IEnumerable<Grupo> LerAba(int indiceAba)
        {
            var clientes = new List<Grupo>();
            
            // Workbook -> Cada Aba da planilha
            using (var workbook = new XLWorkbook(_caminhoArquivo))
            {
                var planilha = workbook.Worksheet(indiceAba);
                var linhas = planilha.RangeUsed().RowsUsed().Skip(2); // pula cabeçalho

                foreach (var linha in linhas)
                {
                    var nome = linha.Cell(2).GetString();
                    var cidade = linha.Cell(3).GetString();
                    var regiao = linha.Cell(4).GetString();
                    var responsavel = linha.Cell(5).GetString();
                    var email = linha.Cell(6).GetString();
                    var contato = linha.Cell(7).GetString();
                    var dancas = linha.Cell(8).GetString();

                    clientes.Add(new Grupo(nome, cidade, regiao, responsavel, email, contato, dancas));
                }
            }

            return clientes;
        }

        public IEnumerable<PlanilhaInfo> ListarAbas()
        {
            using (var workbook = new XLWorkbook(_caminhoArquivo))
            {
                return workbook.Worksheets
                    .Select((ws, index) =>
                        new PlanilhaInfo(index + 1, ws.Name))
                    .ToList();
            }
        }
    }
}
