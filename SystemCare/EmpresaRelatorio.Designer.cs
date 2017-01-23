namespace SystemCare
{
    partial class EmpresaRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpresaRelatorio));
            this.BtnSelecionaEmpresa = new MetroFramework.Controls.MetroButton();
            this.LabelFuncionarioNova = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestaçãoDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacinaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBSENTEÍSMOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatePickerMesReferencia = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSelecionaEmpresa
            // 
            this.BtnSelecionaEmpresa.Location = new System.Drawing.Point(442, 87);
            this.BtnSelecionaEmpresa.Name = "BtnSelecionaEmpresa";
            this.BtnSelecionaEmpresa.Size = new System.Drawing.Size(136, 23);
            this.BtnSelecionaEmpresa.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnSelecionaEmpresa.TabIndex = 120;
            this.BtnSelecionaEmpresa.Text = "Selecionar Empresa";
            this.BtnSelecionaEmpresa.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSelecionaEmpresa.UseSelectable = true;
            this.BtnSelecionaEmpresa.UseStyleColors = true;
            this.BtnSelecionaEmpresa.Click += new System.EventHandler(this.BtnSelecionaEmpresa_Click);
            // 
            // LabelFuncionarioNova
            // 
            this.LabelFuncionarioNova.AutoSize = true;
            this.LabelFuncionarioNova.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelFuncionarioNova.Location = new System.Drawing.Point(23, 91);
            this.LabelFuncionarioNova.Name = "LabelFuncionarioNova";
            this.LabelFuncionarioNova.Size = new System.Drawing.Size(168, 19);
            this.LabelFuncionarioNova.Style = MetroFramework.MetroColorStyle.Green;
            this.LabelFuncionarioNova.TabIndex = 121;
            this.LabelFuncionarioNova.Text = "Selecione uma empresa";
            this.LabelFuncionarioNova.UseStyleColors = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 122;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestaçãoDeServiçoToolStripMenuItem,
            this.vacinaçãoToolStripMenuItem,
            this.aBSENTEÍSMOToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // prestaçãoDeServiçoToolStripMenuItem
            // 
            this.prestaçãoDeServiçoToolStripMenuItem.Name = "prestaçãoDeServiçoToolStripMenuItem";
            this.prestaçãoDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.prestaçãoDeServiçoToolStripMenuItem.Text = "Prestação de Serviço";
            this.prestaçãoDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.prestaçãoDeServiçoToolStripMenuItem_Click);
            // 
            // vacinaçãoToolStripMenuItem
            // 
            this.vacinaçãoToolStripMenuItem.Name = "vacinaçãoToolStripMenuItem";
            this.vacinaçãoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.vacinaçãoToolStripMenuItem.Text = "Vacinação";
            this.vacinaçãoToolStripMenuItem.Click += new System.EventHandler(this.vacinaçãoToolStripMenuItem_Click);
            // 
            // aBSENTEÍSMOToolStripMenuItem
            // 
            this.aBSENTEÍSMOToolStripMenuItem.Name = "aBSENTEÍSMOToolStripMenuItem";
            this.aBSENTEÍSMOToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aBSENTEÍSMOToolStripMenuItem.Text = "Absenteísmo";
            this.aBSENTEÍSMOToolStripMenuItem.Click += new System.EventHandler(this.aBSENTEÍSMOToolStripMenuItem_Click);
            // 
            // DatePickerMesReferencia
            // 
            this.DatePickerMesReferencia.Location = new System.Drawing.Point(23, 154);
            this.DatePickerMesReferencia.MinimumSize = new System.Drawing.Size(0, 29);
            this.DatePickerMesReferencia.Name = "DatePickerMesReferencia";
            this.DatePickerMesReferencia.Size = new System.Drawing.Size(258, 29);
            this.DatePickerMesReferencia.TabIndex = 123;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 132);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 124;
            this.metroLabel1.Text = "Mês de Referência";
            this.metroLabel1.UseStyleColors = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(20, 204);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(597, 400);
            this.reportViewer1.TabIndex = 125;
            // 
            // EmpresaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 627);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DatePickerMesReferencia);
            this.Controls.Add(this.LabelFuncionarioNova);
            this.Controls.Add(this.BtnSelecionaEmpresa);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmpresaRelatorio";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Relatórios Empresa";
            this.Load += new System.EventHandler(this.EmpresaRelatorio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnSelecionaEmpresa;
        private MetroFramework.Controls.MetroLabel LabelFuncionarioNova;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestaçãoDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacinaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBSENTEÍSMOToolStripMenuItem;
        private MetroFramework.Controls.MetroDateTime DatePickerMesReferencia;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}