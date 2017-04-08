﻿namespace SystemCare
{
    partial class ExamesAvaliacoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamesAvaliacoes));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.CheckApto = new MetroFramework.Controls.MetroCheckBox();
            this.BtnGerarAos = new MetroFramework.Controls.MetroButton();
            this.LabelRiscos = new MetroFramework.Controls.MetroLabel();
            this.BtnBuscarFuncionario = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.GridTipoExamePrimeira = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LabelFuncionario = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.BtnCadastrarVacina = new MetroFramework.Controls.MetroButton();
            this.BtnCadastrarAtestado = new MetroFramework.Controls.MetroButton();
            this.BtnHistorico = new MetroFramework.Controls.MetroButton();
            this.CheckAptoNova = new MetroFramework.Controls.MetroCheckBox();
            this.BtnGerarAsoNova = new MetroFramework.Controls.MetroButton();
            this.LabelRiscoFuncionario = new MetroFramework.Controls.MetroLabel();
            this.BtnSelecionaFuncionarioNova = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.GridTipoExameNova = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LabelFuncionarioNova = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoExamePrimeira)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoExameNova)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(7, 58);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(991, 482);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 105;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.CheckApto);
            this.metroTabPage1.Controls.Add(this.BtnGerarAos);
            this.metroTabPage1.Controls.Add(this.LabelRiscos);
            this.metroTabPage1.Controls.Add(this.BtnBuscarFuncionario);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.GridTipoExamePrimeira);
            this.metroTabPage1.Controls.Add(this.LabelFuncionario);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(983, 440);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Primeira Avaliação";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // CheckApto
            // 
            this.CheckApto.AutoSize = true;
            this.CheckApto.Location = new System.Drawing.Point(810, 178);
            this.CheckApto.Name = "CheckApto";
            this.CheckApto.Size = new System.Drawing.Size(53, 15);
            this.CheckApto.Style = MetroFramework.MetroColorStyle.Green;
            this.CheckApto.TabIndex = 113;
            this.CheckApto.Text = "APTO";
            this.CheckApto.UseSelectable = true;
            // 
            // BtnGerarAos
            // 
            this.BtnGerarAos.Location = new System.Drawing.Point(869, 174);
            this.BtnGerarAos.Name = "BtnGerarAos";
            this.BtnGerarAos.Size = new System.Drawing.Size(84, 23);
            this.BtnGerarAos.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnGerarAos.TabIndex = 112;
            this.BtnGerarAos.Text = "Gerar ASO";
            this.BtnGerarAos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnGerarAos.UseSelectable = true;
            this.BtnGerarAos.Click += new System.EventHandler(this.BtnGerarAos_Click);
            // 
            // LabelRiscos
            // 
            this.LabelRiscos.AutoSize = true;
            this.LabelRiscos.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelRiscos.Location = new System.Drawing.Point(3, 28);
            this.LabelRiscos.Name = "LabelRiscos";
            this.LabelRiscos.Size = new System.Drawing.Size(180, 19);
            this.LabelRiscos.Style = MetroFramework.MetroColorStyle.Green;
            this.LabelRiscos.TabIndex = 111;
            this.LabelRiscos.Text = "Selecione um Funcionário";
            this.LabelRiscos.Visible = false;
            // 
            // BtnBuscarFuncionario
            // 
            this.BtnBuscarFuncionario.Location = new System.Drawing.Point(817, 9);
            this.BtnBuscarFuncionario.Name = "BtnBuscarFuncionario";
            this.BtnBuscarFuncionario.Size = new System.Drawing.Size(136, 23);
            this.BtnBuscarFuncionario.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnBuscarFuncionario.TabIndex = 110;
            this.BtnBuscarFuncionario.Text = "Selecionar Funcionário";
            this.BtnBuscarFuncionario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnBuscarFuncionario.UseSelectable = true;
            this.BtnBuscarFuncionario.Click += new System.EventHandler(this.BtnBuscarFuncionario_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 181);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 108;
            this.metroLabel1.Text = "Tipo de Exame";
            // 
            // GridTipoExamePrimeira
            // 
            this.GridTipoExamePrimeira.AllowUserToAddRows = false;
            this.GridTipoExamePrimeira.AllowUserToDeleteRows = false;
            this.GridTipoExamePrimeira.AllowUserToResizeRows = false;
            this.GridTipoExamePrimeira.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridTipoExamePrimeira.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridTipoExamePrimeira.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridTipoExamePrimeira.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridTipoExamePrimeira.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridTipoExamePrimeira.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTipoExamePrimeira.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridTipoExamePrimeira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoExamePrimeira.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTipoExamePrimeira.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridTipoExamePrimeira.EnableHeadersVisualStyles = false;
            this.GridTipoExamePrimeira.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridTipoExamePrimeira.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridTipoExamePrimeira.Location = new System.Drawing.Point(9, 203);
            this.GridTipoExamePrimeira.Name = "GridTipoExamePrimeira";
            this.GridTipoExamePrimeira.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTipoExamePrimeira.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridTipoExamePrimeira.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridTipoExamePrimeira.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTipoExamePrimeira.Size = new System.Drawing.Size(440, 234);
            this.GridTipoExamePrimeira.Style = MetroFramework.MetroColorStyle.Green;
            this.GridTipoExamePrimeira.TabIndex = 106;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "Seleciona";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.Width = 79;
            // 
            // LabelFuncionario
            // 
            this.LabelFuncionario.AutoSize = true;
            this.LabelFuncionario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelFuncionario.Location = new System.Drawing.Point(3, 9);
            this.LabelFuncionario.Name = "LabelFuncionario";
            this.LabelFuncionario.Size = new System.Drawing.Size(180, 19);
            this.LabelFuncionario.Style = MetroFramework.MetroColorStyle.Green;
            this.LabelFuncionario.TabIndex = 105;
            this.LabelFuncionario.Text = "Selecione um Funcionário";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.BtnCadastrarVacina);
            this.metroTabPage2.Controls.Add(this.BtnCadastrarAtestado);
            this.metroTabPage2.Controls.Add(this.BtnHistorico);
            this.metroTabPage2.Controls.Add(this.CheckAptoNova);
            this.metroTabPage2.Controls.Add(this.BtnGerarAsoNova);
            this.metroTabPage2.Controls.Add(this.LabelRiscoFuncionario);
            this.metroTabPage2.Controls.Add(this.BtnSelecionaFuncionarioNova);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.GridTipoExameNova);
            this.metroTabPage2.Controls.Add(this.LabelFuncionarioNova);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(983, 440);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Nova Avaliação";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // BtnCadastrarVacina
            // 
            this.BtnCadastrarVacina.Location = new System.Drawing.Point(815, 64);
            this.BtnCadastrarVacina.Name = "BtnCadastrarVacina";
            this.BtnCadastrarVacina.Size = new System.Drawing.Size(136, 23);
            this.BtnCadastrarVacina.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnCadastrarVacina.TabIndex = 125;
            this.BtnCadastrarVacina.Text = "Cadastrar Vacina";
            this.BtnCadastrarVacina.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnCadastrarVacina.UseSelectable = true;
            this.BtnCadastrarVacina.Click += new System.EventHandler(this.BtnCadastrarVacina_Click);
            // 
            // BtnCadastrarAtestado
            // 
            this.BtnCadastrarAtestado.Location = new System.Drawing.Point(815, 35);
            this.BtnCadastrarAtestado.Name = "BtnCadastrarAtestado";
            this.BtnCadastrarAtestado.Size = new System.Drawing.Size(136, 23);
            this.BtnCadastrarAtestado.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnCadastrarAtestado.TabIndex = 124;
            this.BtnCadastrarAtestado.Text = "Adcionar Atestado";
            this.BtnCadastrarAtestado.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnCadastrarAtestado.UseSelectable = true;
            this.BtnCadastrarAtestado.Click += new System.EventHandler(this.BtnCadastrarAtestado_Click);
            // 
            // BtnHistorico
            // 
            this.BtnHistorico.Location = new System.Drawing.Point(815, 93);
            this.BtnHistorico.Name = "BtnHistorico";
            this.BtnHistorico.Size = new System.Drawing.Size(136, 23);
            this.BtnHistorico.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnHistorico.TabIndex = 123;
            this.BtnHistorico.Text = "Histórico";
            this.BtnHistorico.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnHistorico.UseSelectable = true;
            this.BtnHistorico.Click += new System.EventHandler(this.BtnHistorico_Click);
            // 
            // CheckAptoNova
            // 
            this.CheckAptoNova.AutoSize = true;
            this.CheckAptoNova.Location = new System.Drawing.Point(808, 175);
            this.CheckAptoNova.Name = "CheckAptoNova";
            this.CheckAptoNova.Size = new System.Drawing.Size(53, 15);
            this.CheckAptoNova.Style = MetroFramework.MetroColorStyle.Green;
            this.CheckAptoNova.TabIndex = 122;
            this.CheckAptoNova.Text = "APTO";
            this.CheckAptoNova.UseSelectable = true;
            // 
            // BtnGerarAsoNova
            // 
            this.BtnGerarAsoNova.Location = new System.Drawing.Point(867, 171);
            this.BtnGerarAsoNova.Name = "BtnGerarAsoNova";
            this.BtnGerarAsoNova.Size = new System.Drawing.Size(84, 23);
            this.BtnGerarAsoNova.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnGerarAsoNova.TabIndex = 121;
            this.BtnGerarAsoNova.Text = "Gerar ASO";
            this.BtnGerarAsoNova.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnGerarAsoNova.UseSelectable = true;
            this.BtnGerarAsoNova.Click += new System.EventHandler(this.BtnGerarAsoNova_Click);
            // 
            // LabelRiscoFuncionario
            // 
            this.LabelRiscoFuncionario.AutoSize = true;
            this.LabelRiscoFuncionario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelRiscoFuncionario.Location = new System.Drawing.Point(1, 25);
            this.LabelRiscoFuncionario.Name = "LabelRiscoFuncionario";
            this.LabelRiscoFuncionario.Size = new System.Drawing.Size(180, 19);
            this.LabelRiscoFuncionario.Style = MetroFramework.MetroColorStyle.Green;
            this.LabelRiscoFuncionario.TabIndex = 120;
            this.LabelRiscoFuncionario.Text = "Selecione um Funcionário";
            this.LabelRiscoFuncionario.Visible = false;
            // 
            // BtnSelecionaFuncionarioNova
            // 
            this.BtnSelecionaFuncionarioNova.Location = new System.Drawing.Point(815, 6);
            this.BtnSelecionaFuncionarioNova.Name = "BtnSelecionaFuncionarioNova";
            this.BtnSelecionaFuncionarioNova.Size = new System.Drawing.Size(136, 23);
            this.BtnSelecionaFuncionarioNova.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnSelecionaFuncionarioNova.TabIndex = 119;
            this.BtnSelecionaFuncionarioNova.Text = "Selecionar Funcionário";
            this.BtnSelecionaFuncionarioNova.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSelecionaFuncionarioNova.UseSelectable = true;
            this.BtnSelecionaFuncionarioNova.Click += new System.EventHandler(this.BtnSelecionaFuncionarioNova_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 178);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(97, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 117;
            this.metroLabel5.Text = "Tipo de Exame";
            // 
            // GridTipoExameNova
            // 
            this.GridTipoExameNova.AllowUserToAddRows = false;
            this.GridTipoExameNova.AllowUserToDeleteRows = false;
            this.GridTipoExameNova.AllowUserToResizeRows = false;
            this.GridTipoExameNova.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridTipoExameNova.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridTipoExameNova.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridTipoExameNova.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridTipoExameNova.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridTipoExameNova.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTipoExameNova.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridTipoExameNova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoExameNova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTipoExameNova.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridTipoExameNova.EnableHeadersVisualStyles = false;
            this.GridTipoExameNova.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridTipoExameNova.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridTipoExameNova.Location = new System.Drawing.Point(7, 200);
            this.GridTipoExameNova.Name = "GridTipoExameNova";
            this.GridTipoExameNova.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTipoExameNova.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridTipoExameNova.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridTipoExameNova.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTipoExameNova.Size = new System.Drawing.Size(440, 234);
            this.GridTipoExameNova.Style = MetroFramework.MetroColorStyle.Green;
            this.GridTipoExameNova.TabIndex = 115;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.HeaderText = "Seleciona";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn4.Width = 79;
            // 
            // LabelFuncionarioNova
            // 
            this.LabelFuncionarioNova.AutoSize = true;
            this.LabelFuncionarioNova.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelFuncionarioNova.Location = new System.Drawing.Point(1, 6);
            this.LabelFuncionarioNova.Name = "LabelFuncionarioNova";
            this.LabelFuncionarioNova.Size = new System.Drawing.Size(180, 19);
            this.LabelFuncionarioNova.Style = MetroFramework.MetroColorStyle.Green;
            this.LabelFuncionarioNova.TabIndex = 114;
            this.LabelFuncionarioNova.Text = "Selecione um Funcionário";
            // 
            // ExamesAvaliacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 563);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExamesAvaliacoes";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Exames e Avaliacoes";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoExamePrimeira)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoExameNova)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton BtnBuscarFuncionario;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid GridTipoExamePrimeira;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private MetroFramework.Controls.MetroLabel LabelFuncionario;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel LabelRiscos;
        private MetroFramework.Controls.MetroButton BtnHistorico;
        private MetroFramework.Controls.MetroButton BtnGerarAsoNova;
        private MetroFramework.Controls.MetroLabel LabelRiscoFuncionario;
        private MetroFramework.Controls.MetroButton BtnSelecionaFuncionarioNova;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid GridTipoExameNova;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private MetroFramework.Controls.MetroLabel LabelFuncionarioNova;
        private MetroFramework.Controls.MetroCheckBox CheckApto;
        private MetroFramework.Controls.MetroButton BtnGerarAos;
        private MetroFramework.Controls.MetroCheckBox CheckAptoNova;
        private MetroFramework.Controls.MetroButton BtnCadastrarVacina;
        private MetroFramework.Controls.MetroButton BtnCadastrarAtestado;
    }
}