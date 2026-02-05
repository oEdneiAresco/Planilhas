using Aldeia.Mercosul.Planilhas.App;
using Aldeia.Mercosul.Planilhas.Domain;
using Aldeia.Mercosul.Planilhas.Infra;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private string _caminhoArquivo = Properties.Settings.Default.CaminhoPlanilha;
        private ImportarGruposUseCase _useCase;
        private BindingList<GrupoGridViewModel> _binding;


        public frmCarregarPlanilhas()
        {
            InitializeComponent();
            ConfigurarGridGrupos();

            var leitor = new LeitorDeGruposExcel(_caminhoArquivo);
            _useCase = new ImportarGruposUseCase(leitor);
        }


        private void ConfigurarGridGrupos()
        {
            dtgvListaDeGrupos.AutoGenerateColumns = false;
            dtgvListaDeGrupos.Columns.Clear();

            dtgvListaDeGrupos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "CTG",
                DataPropertyName = "Nome",
                Width = 220
            });

            dtgvListaDeGrupos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "CIDADE",
                DataPropertyName = "Cidade",
                Width = 160
            });

            dtgvListaDeGrupos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "RT",
                DataPropertyName = "Regiao",
                Width = 30,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dtgvListaDeGrupos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "RESPONSÁVEL",
                DataPropertyName = "Responsavel",
                Width = 200
            });

            dtgvListaDeGrupos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "E-MAIL",
                DataPropertyName = "Email",
                Width = 220
            });

            dtgvListaDeGrupos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "CONTATO",
                DataPropertyName = "Contato",
                Width = 140
            });

            dtgvListaDeGrupos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "DANÇAS",
                DataPropertyName = "Dancas",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void btnBuscarPlanilha_Click(object sender, EventArgs e)
        {
            ConfigiurarTela();

            if (cmbAbas.SelectedValue == null)
                return;

            int indiceAba = (int)cmbAbas.SelectedValue;

            var gruposVm = _useCase
                .LerGruposPorAba(indiceAba)
                .ToList();

            _binding = new BindingList<GrupoGridViewModel>(gruposVm);
            dtgvListaDeGrupos.DataSource = _binding;
        }

        private void ConfigiurarTela()
        {
            // TODO: Verificar para uso de ENUM para especificar quando e o que deve ser mudado na tela

            dtgvListaDeGrupos.Visible = true;
            btnGerarPlanilhas.Enabled = true;
        }

        private void frmCarregarPlanilhas_Load(object sender, EventArgs e)
        {
            cmbAbas.DisplayMember = "Nome";
            cmbAbas.ValueMember = "Indice";
            cmbAbas.DataSource = _useCase.ListarAbas().ToList();
        }

        private void btnGerarPlanilhas_Click(object sender, EventArgs e)
        {
            if (_binding == null || !_binding.Any())
                return;

            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "PDF (*.pdf)|*.pdf";
                dialog.FileName = "Grupos.pdf";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                var gerador = new PdfGruposGenerator();
                var useCase = new GerarPdfGruposUseCase(gerador);

                useCase.Executar(_binding, dialog.FileName);
            }


            MessageBox.Show("PDF gerado com sucesso!");
        }

    }
}
