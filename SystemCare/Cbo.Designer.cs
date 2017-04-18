namespace SystemCare
{
    partial class Cbo
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnCadastrar = new MetroFramework.Controls.MetroButton();
            this.TextCodigo = new MetroFramework.Controls.MetroTextBox();
            this.TextDescricao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TextEditarCbo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BtnEditar = new MetroFramework.Controls.MetroButton();
            this.GridSelecionaCbo = new MetroFramework.Controls.MetroGrid();
            this.Seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TextBusca = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.BtnBuscarCbo = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSelecionaCbo)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(448, 248);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.TextDescricao);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.TextCodigo);
            this.metroTabPage1.Controls.Add(this.BtnCadastrar);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(440, 206);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Cadastrar";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.BtnBuscarCbo);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.TextBusca);
            this.metroTabPage2.Controls.Add(this.GridSelecionaCbo);
            this.metroTabPage2.Controls.Add(this.BtnEditar);
            this.metroTabPage2.Controls.Add(this.TextEditarCbo);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(440, 206);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Editar";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Codigo";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(360, 180);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 3;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseSelectable = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TextCodigo
            // 
            this.TextCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextCodigo.CustomButton.Image = null;
            this.TextCodigo.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.TextCodigo.CustomButton.Name = "";
            this.TextCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextCodigo.CustomButton.TabIndex = 1;
            this.TextCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextCodigo.CustomButton.UseSelectable = true;
            this.TextCodigo.CustomButton.Visible = false;
            this.TextCodigo.Lines = new string[0];
            this.TextCodigo.Location = new System.Drawing.Point(3, 33);
            this.TextCodigo.MaxLength = 32767;
            this.TextCodigo.Name = "TextCodigo";
            this.TextCodigo.PasswordChar = '\0';
            this.TextCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextCodigo.SelectedText = "";
            this.TextCodigo.SelectionLength = 0;
            this.TextCodigo.SelectionStart = 0;
            this.TextCodigo.ShortcutsEnabled = true;
            this.TextCodigo.Size = new System.Drawing.Size(81, 23);
            this.TextCodigo.TabIndex = 4;
            this.TextCodigo.UseSelectable = true;
            this.TextCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextDescricao
            // 
            this.TextDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextDescricao.CustomButton.Image = null;
            this.TextDescricao.CustomButton.Location = new System.Drawing.Point(323, 1);
            this.TextDescricao.CustomButton.Name = "";
            this.TextDescricao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextDescricao.CustomButton.TabIndex = 1;
            this.TextDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextDescricao.CustomButton.UseSelectable = true;
            this.TextDescricao.CustomButton.Visible = false;
            this.TextDescricao.Lines = new string[0];
            this.TextDescricao.Location = new System.Drawing.Point(90, 33);
            this.TextDescricao.MaxLength = 32767;
            this.TextDescricao.Name = "TextDescricao";
            this.TextDescricao.PasswordChar = '\0';
            this.TextDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextDescricao.SelectedText = "";
            this.TextDescricao.SelectionLength = 0;
            this.TextDescricao.SelectionStart = 0;
            this.TextDescricao.ShortcutsEnabled = true;
            this.TextDescricao.Size = new System.Drawing.Size(345, 23);
            this.TextDescricao.TabIndex = 6;
            this.TextDescricao.UseSelectable = true;
            this.TextDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(90, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Desrição";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 129);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Codigo";
            // 
            // TextEditarCbo
            // 
            this.TextEditarCbo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextEditarCbo.CustomButton.Image = null;
            this.TextEditarCbo.CustomButton.Location = new System.Drawing.Point(410, 1);
            this.TextEditarCbo.CustomButton.Name = "";
            this.TextEditarCbo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextEditarCbo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextEditarCbo.CustomButton.TabIndex = 1;
            this.TextEditarCbo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextEditarCbo.CustomButton.UseSelectable = true;
            this.TextEditarCbo.CustomButton.Visible = false;
            this.TextEditarCbo.Lines = new string[0];
            this.TextEditarCbo.Location = new System.Drawing.Point(3, 151);
            this.TextEditarCbo.MaxLength = 32767;
            this.TextEditarCbo.Name = "TextEditarCbo";
            this.TextEditarCbo.PasswordChar = '\0';
            this.TextEditarCbo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextEditarCbo.SelectedText = "";
            this.TextEditarCbo.SelectionLength = 0;
            this.TextEditarCbo.SelectionStart = 0;
            this.TextEditarCbo.ShortcutsEnabled = true;
            this.TextEditarCbo.Size = new System.Drawing.Size(432, 23);
            this.TextEditarCbo.Style = MetroFramework.MetroColorStyle.Green;
            this.TextEditarCbo.TabIndex = 8;
            this.TextEditarCbo.UseSelectable = true;
            this.TextEditarCbo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextEditarCbo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(90, 129);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Desrição";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(360, 183);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnEditar.TabIndex = 9;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseSelectable = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // GridSelecionaCbo
            // 
            this.GridSelecionaCbo.AllowUserToAddRows = false;
            this.GridSelecionaCbo.AllowUserToDeleteRows = false;
            this.GridSelecionaCbo.AllowUserToResizeRows = false;
            this.GridSelecionaCbo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridSelecionaCbo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridSelecionaCbo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridSelecionaCbo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSelecionaCbo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridSelecionaCbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSelecionaCbo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleciona});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridSelecionaCbo.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridSelecionaCbo.EnableHeadersVisualStyles = false;
            this.GridSelecionaCbo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridSelecionaCbo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridSelecionaCbo.Location = new System.Drawing.Point(-4, 55);
            this.GridSelecionaCbo.Name = "GridSelecionaCbo";
            this.GridSelecionaCbo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSelecionaCbo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridSelecionaCbo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridSelecionaCbo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSelecionaCbo.Size = new System.Drawing.Size(432, 71);
            this.GridSelecionaCbo.Style = MetroFramework.MetroColorStyle.Green;
            this.GridSelecionaCbo.TabIndex = 11;
            // 
            // Seleciona
            // 
            this.Seleciona.HeaderText = "Seleciona";
            this.Seleciona.Name = "Seleciona";
            // 
            // TextBusca
            // 
            this.TextBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextBusca.CustomButton.Image = null;
            this.TextBusca.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.TextBusca.CustomButton.Name = "";
            this.TextBusca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBusca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBusca.CustomButton.TabIndex = 1;
            this.TextBusca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBusca.CustomButton.UseSelectable = true;
            this.TextBusca.CustomButton.Visible = false;
            this.TextBusca.Lines = new string[0];
            this.TextBusca.Location = new System.Drawing.Point(0, 26);
            this.TextBusca.MaxLength = 32767;
            this.TextBusca.Name = "TextBusca";
            this.TextBusca.PasswordChar = '\0';
            this.TextBusca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBusca.SelectedText = "";
            this.TextBusca.SelectionLength = 0;
            this.TextBusca.SelectionStart = 0;
            this.TextBusca.ShortcutsEnabled = true;
            this.TextBusca.Size = new System.Drawing.Size(406, 23);
            this.TextBusca.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBusca.TabIndex = 12;
            this.TextBusca.UseSelectable = true;
            this.TextBusca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBusca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 4);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Buscar";
            // 
            // BtnBuscarCbo
            // 
            this.BtnBuscarCbo.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarCbo.BackgroundImage = global::SystemCare.Properties.Resources.magnifier;
            this.BtnBuscarCbo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarCbo.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBuscarCbo.Location = new System.Drawing.Point(411, 26);
            this.BtnBuscarCbo.Name = "BtnBuscarCbo";
            this.BtnBuscarCbo.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarCbo.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnBuscarCbo.TabIndex = 99;
            this.BtnBuscarCbo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnBuscarCbo.UseSelectable = true;
            this.BtnBuscarCbo.Click += new System.EventHandler(this.BtnBuscarCbo_Click);
            // 
            // Cbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 334);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cbo";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "CBO";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSelecionaCbo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox TextDescricao;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TextCodigo;
        private MetroFramework.Controls.MetroButton BtnCadastrar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TextBusca;
        private MetroFramework.Controls.MetroGrid GridSelecionaCbo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleciona;
        private MetroFramework.Controls.MetroButton BtnEditar;
        private MetroFramework.Controls.MetroTextBox TextEditarCbo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton BtnBuscarCbo;
    }
}