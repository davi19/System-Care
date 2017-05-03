namespace SystemCare
{
    partial class TabelaPreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaPreco));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextBuscarExame = new MetroFramework.Controls.MetroTextBox();
            this.BtnBuscar = new MetroFramework.Controls.MetroButton();
            this.GridResultado = new MetroFramework.Controls.MetroGrid();
            this.Seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.TextValor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BtnCadastrar = new MetroFramework.Controls.MetroButton();
            this.BtnEditar = new MetroFramework.Controls.MetroButton();
            this.BtnCancelar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TextValorEditar = new MetroFramework.Controls.MetroTextBox();
            this.GridResultadoEditar = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TextBuscaEditar = new MetroFramework.Controls.MetroTextBox();
            this.BtnBuscarEditar = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultadoEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Buscar Exame";
            // 
            // TextBuscarExame
            // 
            this.TextBuscarExame.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextBuscarExame.CustomButton.Image = null;
            this.TextBuscarExame.CustomButton.Location = new System.Drawing.Point(566, 1);
            this.TextBuscarExame.CustomButton.Name = "";
            this.TextBuscarExame.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBuscarExame.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBuscarExame.CustomButton.TabIndex = 1;
            this.TextBuscarExame.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBuscarExame.CustomButton.UseSelectable = true;
            this.TextBuscarExame.CustomButton.Visible = false;
            this.TextBuscarExame.Lines = new string[0];
            this.TextBuscarExame.Location = new System.Drawing.Point(3, 35);
            this.TextBuscarExame.MaxLength = 32767;
            this.TextBuscarExame.Name = "TextBuscarExame";
            this.TextBuscarExame.PasswordChar = '\0';
            this.TextBuscarExame.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBuscarExame.SelectedText = "";
            this.TextBuscarExame.SelectionLength = 0;
            this.TextBuscarExame.SelectionStart = 0;
            this.TextBuscarExame.ShortcutsEnabled = true;
            this.TextBuscarExame.Size = new System.Drawing.Size(588, 23);
            this.TextBuscarExame.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBuscarExame.TabIndex = 1;
            this.TextBuscarExame.UseSelectable = true;
            this.TextBuscarExame.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBuscarExame.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(597, 35);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseSelectable = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridResultado.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridResultado.EnableHeadersVisualStyles = false;
            this.GridResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridResultado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridResultado.Location = new System.Drawing.Point(3, 64);
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
            this.GridResultado.Size = new System.Drawing.Size(669, 129);
            this.GridResultado.Style = MetroFramework.MetroColorStyle.Green;
            this.GridResultado.TabIndex = 3;
            // 
            // Seleciona
            // 
            this.Seleciona.HeaderText = "Seleciona";
            this.Seleciona.Name = "Seleciona";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 79);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(692, 314);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.BtnCadastrar);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.TextValor);
            this.metroTabPage1.Controls.Add(this.GridResultado);
            this.metroTabPage1.Controls.Add(this.TextBuscarExame);
            this.metroTabPage1.Controls.Add(this.BtnBuscar);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(684, 272);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Cadastrar";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.TextValorEditar);
            this.metroTabPage2.Controls.Add(this.GridResultadoEditar);
            this.metroTabPage2.Controls.Add(this.TextBuscaEditar);
            this.metroTabPage2.Controls.Add(this.BtnBuscarEditar);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.BtnCancelar);
            this.metroTabPage2.Controls.Add(this.BtnEditar);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(684, 272);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Editar";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // TextValor
            // 
            this.TextValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextValor.CustomButton.Image = null;
            this.TextValor.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.TextValor.CustomButton.Name = "";
            this.TextValor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextValor.CustomButton.TabIndex = 1;
            this.TextValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextValor.CustomButton.UseSelectable = true;
            this.TextValor.CustomButton.Visible = false;
            this.TextValor.Lines = new string[0];
            this.TextValor.Location = new System.Drawing.Point(3, 218);
            this.TextValor.MaxLength = 32767;
            this.TextValor.Name = "TextValor";
            this.TextValor.PasswordChar = '\0';
            this.TextValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextValor.SelectedText = "";
            this.TextValor.SelectionLength = 0;
            this.TextValor.SelectionStart = 0;
            this.TextValor.ShortcutsEnabled = true;
            this.TextValor.Size = new System.Drawing.Size(119, 23);
            this.TextValor.Style = MetroFramework.MetroColorStyle.Green;
            this.TextValor.TabIndex = 4;
            this.TextValor.UseSelectable = true;
            this.TextValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 196);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Valor";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(597, 246);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnCadastrar.TabIndex = 6;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseSelectable = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(597, 249);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnEditar.TabIndex = 13;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseSelectable = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(516, 249);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseSelectable = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 196);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Valor";
            // 
            // TextValorEditar
            // 
            this.TextValorEditar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextValorEditar.CustomButton.Image = null;
            this.TextValorEditar.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.TextValorEditar.CustomButton.Name = "";
            this.TextValorEditar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextValorEditar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextValorEditar.CustomButton.TabIndex = 1;
            this.TextValorEditar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextValorEditar.CustomButton.UseSelectable = true;
            this.TextValorEditar.CustomButton.Visible = false;
            this.TextValorEditar.Lines = new string[0];
            this.TextValorEditar.Location = new System.Drawing.Point(3, 218);
            this.TextValorEditar.MaxLength = 32767;
            this.TextValorEditar.Name = "TextValorEditar";
            this.TextValorEditar.PasswordChar = '\0';
            this.TextValorEditar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextValorEditar.SelectedText = "";
            this.TextValorEditar.SelectionLength = 0;
            this.TextValorEditar.SelectionStart = 0;
            this.TextValorEditar.ShortcutsEnabled = true;
            this.TextValorEditar.Size = new System.Drawing.Size(119, 23);
            this.TextValorEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.TextValorEditar.TabIndex = 20;
            this.TextValorEditar.UseSelectable = true;
            this.TextValorEditar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextValorEditar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GridResultadoEditar
            // 
            this.GridResultadoEditar.AllowUserToAddRows = false;
            this.GridResultadoEditar.AllowUserToDeleteRows = false;
            this.GridResultadoEditar.AllowUserToResizeRows = false;
            this.GridResultadoEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridResultadoEditar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridResultadoEditar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridResultadoEditar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridResultadoEditar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridResultadoEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResultadoEditar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridResultadoEditar.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridResultadoEditar.EnableHeadersVisualStyles = false;
            this.GridResultadoEditar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridResultadoEditar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridResultadoEditar.Location = new System.Drawing.Point(3, 66);
            this.GridResultadoEditar.Name = "GridResultadoEditar";
            this.GridResultadoEditar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridResultadoEditar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridResultadoEditar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridResultadoEditar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridResultadoEditar.Size = new System.Drawing.Size(669, 127);
            this.GridResultadoEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.GridResultadoEditar.TabIndex = 19;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleciona";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // TextBuscaEditar
            // 
            this.TextBuscaEditar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextBuscaEditar.CustomButton.Image = null;
            this.TextBuscaEditar.CustomButton.Location = new System.Drawing.Point(566, 1);
            this.TextBuscaEditar.CustomButton.Name = "";
            this.TextBuscaEditar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBuscaEditar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBuscaEditar.CustomButton.TabIndex = 1;
            this.TextBuscaEditar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBuscaEditar.CustomButton.UseSelectable = true;
            this.TextBuscaEditar.CustomButton.Visible = false;
            this.TextBuscaEditar.Lines = new string[0];
            this.TextBuscaEditar.Location = new System.Drawing.Point(3, 37);
            this.TextBuscaEditar.MaxLength = 32767;
            this.TextBuscaEditar.Name = "TextBuscaEditar";
            this.TextBuscaEditar.PasswordChar = '\0';
            this.TextBuscaEditar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBuscaEditar.SelectedText = "";
            this.TextBuscaEditar.SelectionLength = 0;
            this.TextBuscaEditar.SelectionStart = 0;
            this.TextBuscaEditar.ShortcutsEnabled = true;
            this.TextBuscaEditar.Size = new System.Drawing.Size(588, 23);
            this.TextBuscaEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBuscaEditar.TabIndex = 17;
            this.TextBuscaEditar.UseSelectable = true;
            this.TextBuscaEditar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBuscaEditar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnBuscarEditar
            // 
            this.BtnBuscarEditar.Location = new System.Drawing.Point(597, 37);
            this.BtnBuscarEditar.Name = "BtnBuscarEditar";
            this.BtnBuscarEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnBuscarEditar.TabIndex = 18;
            this.BtnBuscarEditar.Text = "Buscar";
            this.BtnBuscarEditar.UseSelectable = true;
            this.BtnBuscarEditar.Click += new System.EventHandler(this.BtnBuscarEditar_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 15);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Buscar Exame";
            // 
            // TabelaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 403);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TabelaPreco";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Tabela Preço";
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultadoEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBuscarExame;
        private MetroFramework.Controls.MetroButton BtnBuscar;
        private MetroFramework.Controls.MetroGrid GridResultado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleciona;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton BtnCadastrar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TextValor;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TextValorEditar;
        private MetroFramework.Controls.MetroGrid GridResultadoEditar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private MetroFramework.Controls.MetroTextBox TextBuscaEditar;
        private MetroFramework.Controls.MetroButton BtnBuscarEditar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton BtnCancelar;
        private MetroFramework.Controls.MetroButton BtnEditar;
    }
}