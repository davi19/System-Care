namespace SystemCare
{
    partial class Exames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exames));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.TextDescricao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnCadastrar = new MetroFramework.Controls.MetroButton();
            this.BtnEditar = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TextDescricaoEditar = new MetroFramework.Controls.MetroTextBox();
            this.BtnExcluir = new MetroFramework.Controls.MetroButton();
            this.GridResultado = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TextBusca = new MetroFramework.Controls.MetroTextBox();
            this.BtnBuscar = new MetroFramework.Controls.MetroButton();
            this.BtnCancelar = new MetroFramework.Controls.MetroButton();
            this.Seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(4, 81);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(477, 288);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.BtnCadastrar);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.TextDescricao);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(469, 246);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Cadastrar";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.BtnCancelar);
            this.metroTabPage2.Controls.Add(this.BtnBuscar);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.TextBusca);
            this.metroTabPage2.Controls.Add(this.GridResultado);
            this.metroTabPage2.Controls.Add(this.BtnExcluir);
            this.metroTabPage2.Controls.Add(this.BtnEditar);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.TextDescricaoEditar);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(469, 246);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Editar";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // TextDescricao
            // 
            this.TextDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextDescricao.CustomButton.Image = null;
            this.TextDescricao.CustomButton.Location = new System.Drawing.Point(432, 1);
            this.TextDescricao.CustomButton.Name = "";
            this.TextDescricao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextDescricao.CustomButton.TabIndex = 1;
            this.TextDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextDescricao.CustomButton.UseSelectable = true;
            this.TextDescricao.CustomButton.Visible = false;
            this.TextDescricao.Lines = new string[0];
            this.TextDescricao.Location = new System.Drawing.Point(15, 35);
            this.TextDescricao.MaxLength = 32767;
            this.TextDescricao.Name = "TextDescricao";
            this.TextDescricao.PasswordChar = '\0';
            this.TextDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextDescricao.SelectedText = "";
            this.TextDescricao.SelectionLength = 0;
            this.TextDescricao.SelectionStart = 0;
            this.TextDescricao.ShortcutsEnabled = true;
            this.TextDescricao.Size = new System.Drawing.Size(454, 23);
            this.TextDescricao.Style = MetroFramework.MetroColorStyle.Green;
            this.TextDescricao.TabIndex = 2;
            this.TextDescricao.UseSelectable = true;
            this.TextDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Descrição Exame";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(394, 220);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnCadastrar.TabIndex = 4;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseSelectable = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(394, 220);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnEditar.TabIndex = 7;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseSelectable = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 169);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Descrição Exame";
            // 
            // TextDescricaoEditar
            // 
            this.TextDescricaoEditar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextDescricaoEditar.CustomButton.Image = null;
            this.TextDescricaoEditar.CustomButton.Location = new System.Drawing.Point(432, 1);
            this.TextDescricaoEditar.CustomButton.Name = "";
            this.TextDescricaoEditar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextDescricaoEditar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextDescricaoEditar.CustomButton.TabIndex = 1;
            this.TextDescricaoEditar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextDescricaoEditar.CustomButton.UseSelectable = true;
            this.TextDescricaoEditar.CustomButton.Visible = false;
            this.TextDescricaoEditar.Lines = new string[0];
            this.TextDescricaoEditar.Location = new System.Drawing.Point(15, 191);
            this.TextDescricaoEditar.MaxLength = 32767;
            this.TextDescricaoEditar.Name = "TextDescricaoEditar";
            this.TextDescricaoEditar.PasswordChar = '\0';
            this.TextDescricaoEditar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextDescricaoEditar.SelectedText = "";
            this.TextDescricaoEditar.SelectionLength = 0;
            this.TextDescricaoEditar.SelectionStart = 0;
            this.TextDescricaoEditar.ShortcutsEnabled = true;
            this.TextDescricaoEditar.Size = new System.Drawing.Size(454, 23);
            this.TextDescricaoEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.TextDescricaoEditar.TabIndex = 5;
            this.TextDescricaoEditar.UseSelectable = true;
            this.TextDescricaoEditar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextDescricaoEditar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(313, 220);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseSelectable = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // GridResultado
            // 
            this.GridResultado.AllowUserToAddRows = false;
            this.GridResultado.AllowUserToDeleteRows = false;
            this.GridResultado.AllowUserToResizeRows = false;
            this.GridResultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridResultado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleciona});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridResultado.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridResultado.EnableHeadersVisualStyles = false;
            this.GridResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridResultado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridResultado.Location = new System.Drawing.Point(15, 63);
            this.GridResultado.Name = "GridResultado";
            this.GridResultado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridResultado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridResultado.Size = new System.Drawing.Size(451, 103);
            this.GridResultado.Style = MetroFramework.MetroColorStyle.Green;
            this.GridResultado.TabIndex = 9;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 12);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Buscar Exame";
            // 
            // TextBusca
            // 
            this.TextBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextBusca.CustomButton.Image = null;
            this.TextBusca.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.TextBusca.CustomButton.Name = "";
            this.TextBusca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBusca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBusca.CustomButton.TabIndex = 1;
            this.TextBusca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBusca.CustomButton.UseSelectable = true;
            this.TextBusca.CustomButton.Visible = false;
            this.TextBusca.Lines = new string[0];
            this.TextBusca.Location = new System.Drawing.Point(15, 34);
            this.TextBusca.MaxLength = 32767;
            this.TextBusca.Name = "TextBusca";
            this.TextBusca.PasswordChar = '\0';
            this.TextBusca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBusca.SelectedText = "";
            this.TextBusca.SelectionLength = 0;
            this.TextBusca.SelectionStart = 0;
            this.TextBusca.ShortcutsEnabled = true;
            this.TextBusca.Size = new System.Drawing.Size(373, 23);
            this.TextBusca.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBusca.TabIndex = 10;
            this.TextBusca.UseSelectable = true;
            this.TextBusca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBusca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(394, 34);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnBuscar.TabIndex = 12;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseSelectable = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(232, 220);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseSelectable = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Seleciona
            // 
            this.Seleciona.HeaderText = "Seleciona";
            this.Seleciona.Name = "Seleciona";
            // 
            // Exames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 376);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exames";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Exames";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton BtnCadastrar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextDescricao;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton BtnCancelar;
        private MetroFramework.Controls.MetroButton BtnBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TextBusca;
        private MetroFramework.Controls.MetroGrid GridResultado;
        private MetroFramework.Controls.MetroButton BtnExcluir;
        private MetroFramework.Controls.MetroButton BtnEditar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TextDescricaoEditar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleciona;
    }
}