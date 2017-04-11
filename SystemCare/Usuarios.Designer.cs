namespace SystemCare
{
    partial class Usuarios
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabCriarUsuario = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TextSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextUsuario = new MetroFramework.Controls.MetroTextBox();
            this.BtnCriarUsuario = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TextSenhaEditar = new MetroFramework.Controls.MetroTextBox();
            this.TextUsuarioEditar = new MetroFramework.Controls.MetroTextBox();
            this.BtnEditar = new MetroFramework.Controls.MetroButton();
            this.BtnBuscar = new MetroFramework.Controls.MetroButton();
            this.BtnExcluir = new MetroFramework.Controls.MetroButton();
            this.GridUsuarios = new MetroFramework.Controls.MetroGrid();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TextBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.TabCriarUsuario.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.TabCriarUsuario);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(514, 254);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // TabCriarUsuario
            // 
            this.TabCriarUsuario.Controls.Add(this.metroLabel2);
            this.TabCriarUsuario.Controls.Add(this.TextSenha);
            this.TabCriarUsuario.Controls.Add(this.metroLabel1);
            this.TabCriarUsuario.Controls.Add(this.TextUsuario);
            this.TabCriarUsuario.Controls.Add(this.BtnCriarUsuario);
            this.TabCriarUsuario.HorizontalScrollbarBarColor = true;
            this.TabCriarUsuario.HorizontalScrollbarHighlightOnWheel = false;
            this.TabCriarUsuario.HorizontalScrollbarSize = 10;
            this.TabCriarUsuario.Location = new System.Drawing.Point(4, 38);
            this.TabCriarUsuario.Name = "TabCriarUsuario";
            this.TabCriarUsuario.Size = new System.Drawing.Size(506, 212);
            this.TabCriarUsuario.TabIndex = 0;
            this.TabCriarUsuario.Text = "Criar";
            this.TabCriarUsuario.VerticalScrollbarBarColor = true;
            this.TabCriarUsuario.VerticalScrollbarHighlightOnWheel = false;
            this.TabCriarUsuario.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Senha";
            // 
            // TextSenha
            // 
            // 
            // 
            // 
            this.TextSenha.CustomButton.Image = null;
            this.TextSenha.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TextSenha.CustomButton.Name = "";
            this.TextSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextSenha.CustomButton.TabIndex = 1;
            this.TextSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextSenha.CustomButton.UseSelectable = true;
            this.TextSenha.CustomButton.Visible = false;
            this.TextSenha.Lines = new string[0];
            this.TextSenha.Location = new System.Drawing.Point(3, 87);
            this.TextSenha.MaxLength = 32767;
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.PasswordChar = '*';
            this.TextSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextSenha.SelectedText = "";
            this.TextSenha.SelectionLength = 0;
            this.TextSenha.SelectionStart = 0;
            this.TextSenha.ShortcutsEnabled = true;
            this.TextSenha.Size = new System.Drawing.Size(219, 23);
            this.TextSenha.Style = MetroFramework.MetroColorStyle.Green;
            this.TextSenha.TabIndex = 5;
            this.TextSenha.UseSelectable = true;
            this.TextSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Usuário";
            // 
            // TextUsuario
            // 
            // 
            // 
            // 
            this.TextUsuario.CustomButton.Image = null;
            this.TextUsuario.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TextUsuario.CustomButton.Name = "";
            this.TextUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextUsuario.CustomButton.TabIndex = 1;
            this.TextUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextUsuario.CustomButton.UseSelectable = true;
            this.TextUsuario.CustomButton.Visible = false;
            this.TextUsuario.Lines = new string[0];
            this.TextUsuario.Location = new System.Drawing.Point(3, 34);
            this.TextUsuario.MaxLength = 32767;
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.PasswordChar = '\0';
            this.TextUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextUsuario.SelectedText = "";
            this.TextUsuario.SelectionLength = 0;
            this.TextUsuario.SelectionStart = 0;
            this.TextUsuario.ShortcutsEnabled = true;
            this.TextUsuario.Size = new System.Drawing.Size(219, 23);
            this.TextUsuario.Style = MetroFramework.MetroColorStyle.Green;
            this.TextUsuario.TabIndex = 3;
            this.TextUsuario.UseSelectable = true;
            this.TextUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnCriarUsuario
            // 
            this.BtnCriarUsuario.Location = new System.Drawing.Point(428, 186);
            this.BtnCriarUsuario.Name = "BtnCriarUsuario";
            this.BtnCriarUsuario.Size = new System.Drawing.Size(75, 23);
            this.BtnCriarUsuario.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnCriarUsuario.TabIndex = 2;
            this.BtnCriarUsuario.Text = "Criar";
            this.BtnCriarUsuario.UseSelectable = true;
            this.BtnCriarUsuario.Click += new System.EventHandler(this.BtnCriarUsuario_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.TextSenhaEditar);
            this.metroTabPage2.Controls.Add(this.TextUsuarioEditar);
            this.metroTabPage2.Controls.Add(this.BtnEditar);
            this.metroTabPage2.Controls.Add(this.BtnBuscar);
            this.metroTabPage2.Controls.Add(this.BtnExcluir);
            this.metroTabPage2.Controls.Add(this.GridUsuarios);
            this.metroTabPage2.Controls.Add(this.TextBuscar);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(506, 212);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Editar";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(0, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Buscar";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(269, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Senha";
            this.metroLabel4.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Usuário";
            this.metroLabel3.Visible = false;
            // 
            // TextSenhaEditar
            // 
            // 
            // 
            // 
            this.TextSenhaEditar.CustomButton.Image = null;
            this.TextSenhaEditar.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.TextSenhaEditar.CustomButton.Name = "";
            this.TextSenhaEditar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextSenhaEditar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextSenhaEditar.CustomButton.TabIndex = 1;
            this.TextSenhaEditar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextSenhaEditar.CustomButton.UseSelectable = true;
            this.TextSenhaEditar.CustomButton.Visible = false;
            this.TextSenhaEditar.Lines = new string[0];
            this.TextSenhaEditar.Location = new System.Drawing.Point(269, 146);
            this.TextSenhaEditar.MaxLength = 32767;
            this.TextSenhaEditar.Name = "TextSenhaEditar";
            this.TextSenhaEditar.PasswordChar = '*';
            this.TextSenhaEditar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextSenhaEditar.SelectedText = "";
            this.TextSenhaEditar.SelectionLength = 0;
            this.TextSenhaEditar.SelectionStart = 0;
            this.TextSenhaEditar.ShortcutsEnabled = true;
            this.TextSenhaEditar.Size = new System.Drawing.Size(232, 23);
            this.TextSenhaEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.TextSenhaEditar.TabIndex = 8;
            this.TextSenhaEditar.UseSelectable = true;
            this.TextSenhaEditar.Visible = false;
            this.TextSenhaEditar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextSenhaEditar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextUsuarioEditar
            // 
            // 
            // 
            // 
            this.TextUsuarioEditar.CustomButton.Image = null;
            this.TextUsuarioEditar.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.TextUsuarioEditar.CustomButton.Name = "";
            this.TextUsuarioEditar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextUsuarioEditar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextUsuarioEditar.CustomButton.TabIndex = 1;
            this.TextUsuarioEditar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextUsuarioEditar.CustomButton.UseSelectable = true;
            this.TextUsuarioEditar.CustomButton.Visible = false;
            this.TextUsuarioEditar.Lines = new string[0];
            this.TextUsuarioEditar.Location = new System.Drawing.Point(3, 146);
            this.TextUsuarioEditar.MaxLength = 32767;
            this.TextUsuarioEditar.Name = "TextUsuarioEditar";
            this.TextUsuarioEditar.PasswordChar = '\0';
            this.TextUsuarioEditar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextUsuarioEditar.SelectedText = "";
            this.TextUsuarioEditar.SelectionLength = 0;
            this.TextUsuarioEditar.SelectionStart = 0;
            this.TextUsuarioEditar.ShortcutsEnabled = true;
            this.TextUsuarioEditar.Size = new System.Drawing.Size(232, 23);
            this.TextUsuarioEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.TextUsuarioEditar.TabIndex = 7;
            this.TextUsuarioEditar.UseSelectable = true;
            this.TextUsuarioEditar.Visible = false;
            this.TextUsuarioEditar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextUsuarioEditar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(426, 186);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseSelectable = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(426, 22);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseSelectable = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(345, 186);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseSelectable = true;
            this.BtnExcluir.Visible = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // GridUsuarios
            // 
            this.GridUsuarios.AllowUserToAddRows = false;
            this.GridUsuarios.AllowUserToResizeRows = false;
            this.GridUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridUsuarios.EnableHeadersVisualStyles = false;
            this.GridUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridUsuarios.Location = new System.Drawing.Point(0, 51);
            this.GridUsuarios.Name = "GridUsuarios";
            this.GridUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUsuarios.Size = new System.Drawing.Size(501, 72);
            this.GridUsuarios.Style = MetroFramework.MetroColorStyle.Green;
            this.GridUsuarios.TabIndex = 3;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Seleciona";
            this.Selecionar.Name = "Selecionar";
            // 
            // TextBuscar
            // 
            // 
            // 
            // 
            this.TextBuscar.CustomButton.Image = null;
            this.TextBuscar.CustomButton.Location = new System.Drawing.Point(395, 1);
            this.TextBuscar.CustomButton.Name = "";
            this.TextBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBuscar.CustomButton.TabIndex = 1;
            this.TextBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBuscar.CustomButton.UseSelectable = true;
            this.TextBuscar.CustomButton.Visible = false;
            this.TextBuscar.Lines = new string[0];
            this.TextBuscar.Location = new System.Drawing.Point(0, 22);
            this.TextBuscar.MaxLength = 32767;
            this.TextBuscar.Name = "TextBuscar";
            this.TextBuscar.PasswordChar = '\0';
            this.TextBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBuscar.SelectedText = "";
            this.TextBuscar.SelectionLength = 0;
            this.TextBuscar.SelectionStart = 0;
            this.TextBuscar.ShortcutsEnabled = true;
            this.TextBuscar.Size = new System.Drawing.Size(417, 23);
            this.TextBuscar.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBuscar.TabIndex = 2;
            this.TextBuscar.UseSelectable = true;
            this.TextBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 340);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuarios";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Usuarios";
            this.metroTabControl1.ResumeLayout(false);
            this.TabCriarUsuario.ResumeLayout(false);
            this.TabCriarUsuario.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TabCriarUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TextSenha;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextUsuario;
        private MetroFramework.Controls.MetroButton BtnCriarUsuario;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TextSenhaEditar;
        private MetroFramework.Controls.MetroTextBox TextUsuarioEditar;
        private MetroFramework.Controls.MetroButton BtnEditar;
        private MetroFramework.Controls.MetroButton BtnBuscar;
        private MetroFramework.Controls.MetroButton BtnExcluir;
        private MetroFramework.Controls.MetroGrid GridUsuarios;
        private MetroFramework.Controls.MetroTextBox TextBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
    }
}