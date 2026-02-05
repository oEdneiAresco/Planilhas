namespace Aldeia.Mercosul.Planilhas.UI
{
    partial class frmCarregarPlanilhas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarregarPlanilhas));
            this.cmbAbas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarPlanilha = new System.Windows.Forms.Button();
            this.dtgvListaDeGrupos = new System.Windows.Forms.DataGridView();
            this.btnGerarPlanilhas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaDeGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAbas
            // 
            this.cmbAbas.FormattingEnabled = true;
            this.cmbAbas.Location = new System.Drawing.Point(12, 43);
            this.cmbAbas.Name = "cmbAbas";
            this.cmbAbas.Size = new System.Drawing.Size(650, 24);
            this.cmbAbas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a categoria a ser carregada";
            // 
            // btnBuscarPlanilha
            // 
            this.btnBuscarPlanilha.Location = new System.Drawing.Point(668, 37);
            this.btnBuscarPlanilha.Name = "btnBuscarPlanilha";
            this.btnBuscarPlanilha.Size = new System.Drawing.Size(139, 35);
            this.btnBuscarPlanilha.TabIndex = 2;
            this.btnBuscarPlanilha.Text = "Buscar";
            this.btnBuscarPlanilha.UseVisualStyleBackColor = true;
            this.btnBuscarPlanilha.Click += new System.EventHandler(this.btnBuscarPlanilha_Click);
            // 
            // dtgvListaDeGrupos
            // 
            this.dtgvListaDeGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListaDeGrupos.Location = new System.Drawing.Point(12, 87);
            this.dtgvListaDeGrupos.Name = "dtgvListaDeGrupos";
            this.dtgvListaDeGrupos.RowHeadersWidth = 51;
            this.dtgvListaDeGrupos.RowTemplate.Height = 24;
            this.dtgvListaDeGrupos.Size = new System.Drawing.Size(1692, 521);
            this.dtgvListaDeGrupos.TabIndex = 3;
            this.dtgvListaDeGrupos.Visible = false;
            // 
            // btnGerarPlanilhas
            // 
            this.btnGerarPlanilhas.Enabled = false;
            this.btnGerarPlanilhas.Location = new System.Drawing.Point(813, 37);
            this.btnGerarPlanilhas.Name = "btnGerarPlanilhas";
            this.btnGerarPlanilhas.Size = new System.Drawing.Size(139, 35);
            this.btnGerarPlanilhas.TabIndex = 4;
            this.btnGerarPlanilhas.Text = "Gerar Planilhas";
            this.btnGerarPlanilhas.UseVisualStyleBackColor = true;
            this.btnGerarPlanilhas.Click += new System.EventHandler(this.btnGerarPlanilhas_Click);
            // 
            // frmCarregarPlanilhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 688);
            this.Controls.Add(this.btnGerarPlanilhas);
            this.Controls.Add(this.dtgvListaDeGrupos);
            this.Controls.Add(this.btnBuscarPlanilha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAbas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarregarPlanilhas";
            this.Text = "CTG Aldeia dos Anjos - Planilha";
            this.Load += new System.EventHandler(this.frmCarregarPlanilhas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaDeGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAbas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPlanilha;
        private System.Windows.Forms.DataGridView dtgvListaDeGrupos;
        private System.Windows.Forms.Button btnGerarPlanilhas;
    }
}