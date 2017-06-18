namespace SystemCare
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamesAvaliacoes));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.BtnCadastrarVacina = new MetroFramework.Controls.MetroButton();
            this.BtnCadastrarAtestado = new MetroFramework.Controls.MetroButton();
            this.BtnHistorico = new MetroFramework.Controls.MetroButton();
            this.CheckAptoNova = new MetroFramework.Controls.MetroCheckBox();
            this.BtnGerarAsoNova = new MetroFramework.Controls.MetroButton();
            this.LabelRiscoFuncionario = new MetroFramework.Controls.MetroLabel();
            this.BtnSelecionaFuncionarioNova = new MetroFramework.Controls.MetroButton();
            this.LabelFuncionarioNova = new MetroFramework.Controls.MetroLabel();
            this.GridTipoExame = new MetroFramework.Controls.MetroGrid();
            this.GridExame = new MetroFramework.Controls.MetroGrid();
            this.Seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SelecionaExame = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextObservacao = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoExame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridExame)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(7, 58);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(991, 482);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 105;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.TextObservacao);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.GridExame);
            this.metroTabPage2.Controls.Add(this.GridTipoExame);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.BtnCadastrarVacina);
            this.metroTabPage2.Controls.Add(this.BtnCadastrarAtestado);
            this.metroTabPage2.Controls.Add(this.BtnHistorico);
            this.metroTabPage2.Controls.Add(this.CheckAptoNova);
            this.metroTabPage2.Controls.Add(this.BtnGerarAsoNova);
            this.metroTabPage2.Controls.Add(this.LabelRiscoFuncionario);
            this.metroTabPage2.Controls.Add(this.BtnSelecionaFuncionarioNova);
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
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(815, 122);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(136, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 126;
            this.metroButton1.Text = "Realizar Questionario";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
            this.CheckAptoNova.Location = new System.Drawing.Point(808, 166);
            this.CheckAptoNova.Name = "CheckAptoNova";
            this.CheckAptoNova.Size = new System.Drawing.Size(53, 15);
            this.CheckAptoNova.Style = MetroFramework.MetroColorStyle.Green;
            this.CheckAptoNova.TabIndex = 122;
            this.CheckAptoNova.Text = "APTO";
            this.CheckAptoNova.UseSelectable = true;
            // 
            // BtnGerarAsoNova
            // 
            this.BtnGerarAsoNova.Location = new System.Drawing.Point(867, 161);
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
            // GridTipoExame
            // 
            this.GridTipoExame.AllowUserToAddRows = false;
            this.GridTipoExame.AllowUserToDeleteRows = false;
            this.GridTipoExame.AllowUserToResizeRows = false;
            this.GridTipoExame.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridTipoExame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridTipoExame.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridTipoExame.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTipoExame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridTipoExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoExame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleciona});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTipoExame.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridTipoExame.EnableHeadersVisualStyles = false;
            this.GridTipoExame.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridTipoExame.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridTipoExame.Location = new System.Drawing.Point(3, 191);
            this.GridTipoExame.Name = "GridTipoExame";
            this.GridTipoExame.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTipoExame.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridTipoExame.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridTipoExame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTipoExame.Size = new System.Drawing.Size(409, 246);
            this.GridTipoExame.Style = MetroFramework.MetroColorStyle.Green;
            this.GridTipoExame.TabIndex = 127;
            // 
            // GridExame
            // 
            this.GridExame.AllowUserToAddRows = false;
            this.GridExame.AllowUserToDeleteRows = false;
            this.GridExame.AllowUserToResizeRows = false;
            this.GridExame.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridExame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridExame.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridExame.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridExame.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridExame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelecionaExame});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridExame.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridExame.EnableHeadersVisualStyles = false;
            this.GridExame.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridExame.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridExame.Location = new System.Drawing.Point(418, 191);
            this.GridExame.Name = "GridExame";
            this.GridExame.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridExame.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridExame.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridExame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridExame.Size = new System.Drawing.Size(387, 246);
            this.GridExame.Style = MetroFramework.MetroColorStyle.Green;
            this.GridExame.TabIndex = 128;
            // 
            // Seleciona
            // 
            this.Seleciona.HeaderText = "Seleciona";
            this.Seleciona.Name = "Seleciona";
            // 
            // SelecionaExame
            // 
            this.SelecionaExame.HeaderText = "Seleciona";
            this.SelecionaExame.Name = "SelecionaExame";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 162);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 129;
            this.metroLabel1.Text = "Observações:";
            // 
            // TextObservacao
            // 
            // 
            // 
            // 
            this.TextObservacao.CustomButton.Image = null;
            this.TextObservacao.CustomButton.Location = new System.Drawing.Point(686, 1);
            this.TextObservacao.CustomButton.Name = "";
            this.TextObservacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextObservacao.CustomButton.TabIndex = 1;
            this.TextObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextObservacao.CustomButton.UseSelectable = true;
            this.TextObservacao.CustomButton.Visible = false;
            this.TextObservacao.Lines = new string[0];
            this.TextObservacao.Location = new System.Drawing.Point(94, 161);
            this.TextObservacao.MaxLength = 32767;
            this.TextObservacao.Name = "TextObservacao";
            this.TextObservacao.PasswordChar = '\0';
            this.TextObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextObservacao.SelectedText = "";
            this.TextObservacao.SelectionLength = 0;
            this.TextObservacao.SelectionStart = 0;
            this.TextObservacao.ShortcutsEnabled = true;
            this.TextObservacao.Size = new System.Drawing.Size(708, 23);
            this.TextObservacao.TabIndex = 130;
            this.TextObservacao.UseSelectable = true;
            this.TextObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextObservacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoExame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridExame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton BtnHistorico;
        private MetroFramework.Controls.MetroButton BtnGerarAsoNova;
        private MetroFramework.Controls.MetroLabel LabelRiscoFuncionario;
        private MetroFramework.Controls.MetroButton BtnSelecionaFuncionarioNova;
        private MetroFramework.Controls.MetroLabel LabelFuncionarioNova;
        private MetroFramework.Controls.MetroCheckBox CheckAptoNova;
        private MetroFramework.Controls.MetroButton BtnCadastrarVacina;
        private MetroFramework.Controls.MetroButton BtnCadastrarAtestado;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid GridExame;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelecionaExame;
        private MetroFramework.Controls.MetroGrid GridTipoExame;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleciona;
        private MetroFramework.Controls.MetroTextBox TextObservacao;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}