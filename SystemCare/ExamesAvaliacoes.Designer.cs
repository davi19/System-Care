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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.BtnBuscarFuncionario = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.GridExameMedicoPrimeira = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GridTipoExamePrimeira = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LabelFuncionario = new MetroFramework.Controls.MetroLabel();
            this.LabelRiscos = new MetroFramework.Controls.MetroLabel();
            this.BtnGerarAos = new MetroFramework.Controls.MetroButton();
            this.CheckApto = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridExameMedicoPrimeira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoExamePrimeira)).BeginInit();
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
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.GridExameMedicoPrimeira);
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
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(983, 328);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Nova Avaliação";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
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
            this.BtnBuscarFuncionario.UseStyleColors = true;
            this.BtnBuscarFuncionario.Click += new System.EventHandler(this.BtnBuscarFuncionario_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(461, 181);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 109;
            this.metroLabel2.Text = "Exames Medicos";
            this.metroLabel2.UseStyleColors = true;
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
            this.metroLabel1.UseStyleColors = true;
            // 
            // GridExameMedicoPrimeira
            // 
            this.GridExameMedicoPrimeira.AllowUserToAddRows = false;
            this.GridExameMedicoPrimeira.AllowUserToDeleteRows = false;
            this.GridExameMedicoPrimeira.AllowUserToResizeRows = false;
            this.GridExameMedicoPrimeira.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridExameMedicoPrimeira.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridExameMedicoPrimeira.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridExameMedicoPrimeira.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridExameMedicoPrimeira.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridExameMedicoPrimeira.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridExameMedicoPrimeira.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridExameMedicoPrimeira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridExameMedicoPrimeira.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridExameMedicoPrimeira.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridExameMedicoPrimeira.EnableHeadersVisualStyles = false;
            this.GridExameMedicoPrimeira.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridExameMedicoPrimeira.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridExameMedicoPrimeira.Location = new System.Drawing.Point(461, 203);
            this.GridExameMedicoPrimeira.Name = "GridExameMedicoPrimeira";
            this.GridExameMedicoPrimeira.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridExameMedicoPrimeira.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridExameMedicoPrimeira.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridExameMedicoPrimeira.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridExameMedicoPrimeira.Size = new System.Drawing.Size(522, 234);
            this.GridExameMedicoPrimeira.Style = MetroFramework.MetroColorStyle.Green;
            this.GridExameMedicoPrimeira.TabIndex = 107;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleciona";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 79;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTipoExamePrimeira.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridTipoExamePrimeira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoExamePrimeira.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTipoExamePrimeira.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridTipoExamePrimeira.EnableHeadersVisualStyles = false;
            this.GridTipoExamePrimeira.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridTipoExamePrimeira.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridTipoExamePrimeira.Location = new System.Drawing.Point(9, 203);
            this.GridTipoExamePrimeira.Name = "GridTipoExamePrimeira";
            this.GridTipoExamePrimeira.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTipoExamePrimeira.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.LabelFuncionario.UseStyleColors = true;
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
            this.LabelRiscos.UseStyleColors = true;
            this.LabelRiscos.Visible = false;
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
            this.BtnGerarAos.UseStyleColors = true;
            this.BtnGerarAos.Click += new System.EventHandler(this.BtnGerarAos_Click);
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
            this.CheckApto.UseStyleColors = true;
            // 
            // ExamesAvaliacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 563);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "ExamesAvaliacoes";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Exames e Avaliacoes";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridExameMedicoPrimeira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoExamePrimeira)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton BtnBuscarFuncionario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid GridExameMedicoPrimeira;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private MetroFramework.Controls.MetroGrid GridTipoExamePrimeira;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private MetroFramework.Controls.MetroLabel LabelFuncionario;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel LabelRiscos;
        private MetroFramework.Controls.MetroCheckBox CheckApto;
        private MetroFramework.Controls.MetroButton BtnGerarAos;
    }
}