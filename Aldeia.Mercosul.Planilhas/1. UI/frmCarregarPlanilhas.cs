using Aldeia.Mercosul.Planilhas.App;
using Aldeia.Mercosul.Planilhas.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aldeia.Mercosul.Planilhas.UI
{
    public partial class frmCarregarPlanilhas : Form
    {
        public frmCarregarPlanilhas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (cmbAbas.SelectedValue == null)
            //    return;

            //int indiceAba = (int)cmbAbas.SelectedValue;

            //var grupos = _planilhaReader
            //    .LerAba(indiceAba)
            //    .ToList();

            //dataGridView1.DataSource = grupos;
        }

        private void frmCarregarPlanilhas_Load(object sender, EventArgs e)
        {
            var leitor = new LeitorDeGruposExcel(@"C:\INVERNADAS.xlsx");
            var useCase = new ImportarGruposUseCase(leitor);

            IEnumerable<PlanilhaInfo> categoriasGrupos = useCase.ListarAbas();

            foreach (PlanilhaInfo aba in categoriasGrupos)
            {
                cmbAbas.Items.Add(aba);
            }
        }
    }
}
