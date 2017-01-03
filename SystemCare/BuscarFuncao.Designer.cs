namespace SystemCare
{
    partial class BuscarFuncao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabBuscar = new MetroFramework.Controls.MetroTabPage();
            this.TextBuscaFuncao = new MetroFramework.Controls.MetroTextBox();
            this.BtnBuscar = new MetroFramework.Controls.MetroButton();
            this.GridFuncao = new MetroFramework.Controls.MetroGrid();
            this.TabEditar = new MetroFramework.Controls.MetroTabPage();
            this.GridRiscos = new MetroFramework.Controls.MetroGrid();
            this.Selecion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ComboSetor = new MetroFramework.Controls.MetroComboBox();
            this.LabelId = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TextNome = new MetroFramework.Controls.MetroTextBox();
            this.Label3 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.BtnSelecionar = new MetroFramework.Controls.MetroButton();
            this.BtnExcluir = new MetroFramework.Controls.MetroButton();
            this.BtnSalvar = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.TabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncao)).BeginInit();
            this.TabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.TabBuscar);
            this.metroTabControl1.Controls.Add(this.TabEditar);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(4, 53);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(663, 363);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 7;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TabBuscar
            // 
            this.TabBuscar.Controls.Add(this.TextBuscaFuncao);
            this.TabBuscar.Controls.Add(this.BtnBuscar);
            this.TabBuscar.Controls.Add(this.GridFuncao);
            this.TabBuscar.HorizontalScrollbarBarColor = true;
            this.TabBuscar.HorizontalScrollbarHighlightOnWheel = false;
            this.TabBuscar.HorizontalScrollbarSize = 10;
            this.TabBuscar.Location = new System.Drawing.Point(4, 38);
            this.TabBuscar.Name = "TabBuscar";
            this.TabBuscar.Size = new System.Drawing.Size(655, 321);
            this.TabBuscar.Style = MetroFramework.MetroColorStyle.Green;
            this.TabBuscar.TabIndex = 0;
            this.TabBuscar.Text = "Buscar";
            this.TabBuscar.VerticalScrollbarBarColor = true;
            this.TabBuscar.VerticalScrollbarHighlightOnWheel = false;
            this.TabBuscar.VerticalScrollbarSize = 10;
            // 
            // TextBuscaFuncao
            // 
            this.TextBuscaFuncao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextBuscaFuncao.CustomButton.Image = null;
            this.TextBuscaFuncao.CustomButton.Location = new System.Drawing.Point(425, 1);
            this.TextBuscaFuncao.CustomButton.Name = "";
            this.TextBuscaFuncao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBuscaFuncao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBuscaFuncao.CustomButton.TabIndex = 1;
            this.TextBuscaFuncao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBuscaFuncao.CustomButton.UseSelectable = true;
            this.TextBuscaFuncao.CustomButton.Visible = false;
            this.TextBuscaFuncao.Lines = new string[0];
            this.TextBuscaFuncao.Location = new System.Drawing.Point(3, 13);
            this.TextBuscaFuncao.MaxLength = 32767;
            this.TextBuscaFuncao.Name = "TextBuscaFuncao";
            this.TextBuscaFuncao.PasswordChar = '\0';
            this.TextBuscaFuncao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBuscaFuncao.SelectedText = "";
            this.TextBuscaFuncao.SelectionLength = 0;
            this.TextBuscaFuncao.SelectionStart = 0;
            this.TextBuscaFuncao.ShortcutsEnabled = true;
            this.TextBuscaFuncao.Size = new System.Drawing.Size(447, 23);
            this.TextBuscaFuncao.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBuscaFuncao.TabIndex = 0;
            this.TextBuscaFuncao.UseSelectable = true;
            this.TextBuscaFuncao.UseStyleColors = true;
            this.TextBuscaFuncao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBuscaFuncao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBuscaFuncao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBuscaSetor_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(456, 13);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseSelectable = true;
            this.BtnBuscar.UseStyleColors = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GridFuncao
            // 
            this.GridFuncao.AllowUserToAddRows = false;
            this.GridFuncao.AllowUserToDeleteRows = false;
            this.GridFuncao.AllowUserToResizeRows = false;
            this.GridFuncao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridFuncao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridFuncao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridFuncao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridFuncao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridFuncao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFuncao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridFuncao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFuncao.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridFuncao.EnableHeadersVisualStyles = false;
            this.GridFuncao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridFuncao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridFuncao.Location = new System.Drawing.Point(3, 42);
            this.GridFuncao.Name = "GridFuncao";
            this.GridFuncao.ReadOnly = true;
            this.GridFuncao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFuncao.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridFuncao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridFuncao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFuncao.Size = new System.Drawing.Size(538, 240);
            this.GridFuncao.Style = MetroFramework.MetroColorStyle.Green;
            this.GridFuncao.TabIndex = 2;
            this.GridFuncao.UseStyleColors = true;
            this.GridFuncao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSetor_CellContentClick);
            // 
            // TabEditar
            // 
            this.TabEditar.Controls.Add(this.GridRiscos);
            this.TabEditar.Controls.Add(this.metroLabel3);
            this.TabEditar.Controls.Add(this.ComboSetor);
            this.TabEditar.Controls.Add(this.LabelId);
            this.TabEditar.Controls.Add(this.metroLabel2);
            this.TabEditar.Controls.Add(this.TextNome);
            this.TabEditar.Controls.Add(this.Label3);
            this.TabEditar.HorizontalScrollbarBarColor = true;
            this.TabEditar.HorizontalScrollbarHighlightOnWheel = false;
            this.TabEditar.HorizontalScrollbarSize = 10;
            this.TabEditar.Location = new System.Drawing.Point(4, 38);
            this.TabEditar.Name = "TabEditar";
            this.TabEditar.Size = new System.Drawing.Size(655, 321);
            this.TabEditar.TabIndex = 1;
            this.TabEditar.Text = "Editar";
            this.TabEditar.VerticalScrollbarBarColor = true;
            this.TabEditar.VerticalScrollbarHighlightOnWheel = false;
            this.TabEditar.VerticalScrollbarSize = 10;
            // 
            // GridRiscos
            // 
            this.GridRiscos.AllowUserToAddRows = false;
            this.GridRiscos.AllowUserToDeleteRows = false;
            this.GridRiscos.AllowUserToResizeRows = false;
            this.GridRiscos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridRiscos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridRiscos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridRiscos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridRiscos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridRiscos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridRiscos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridRiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRiscos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecion});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridRiscos.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridRiscos.EnableHeadersVisualStyles = false;
            this.GridRiscos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridRiscos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridRiscos.Location = new System.Drawing.Point(9, 152);
            this.GridRiscos.Name = "GridRiscos";
            this.GridRiscos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridRiscos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridRiscos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridRiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridRiscos.Size = new System.Drawing.Size(643, 166);
            this.GridRiscos.Style = MetroFramework.MetroColorStyle.Green;
            this.GridRiscos.TabIndex = 14;
            this.GridRiscos.UseStyleColors = true;
            // 
            // Selecion
            // 
            this.Selecion.HeaderText = "Seleciona";
            this.Selecion.Name = "Selecion";
            this.Selecion.Width = 60;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(15, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Setor:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // ComboSetor
            // 
            this.ComboSetor.FormattingEnabled = true;
            this.ComboSetor.ItemHeight = 23;
            this.ComboSetor.Location = new System.Drawing.Point(15, 63);
            this.ComboSetor.Name = "ComboSetor";
            this.ComboSetor.Size = new System.Drawing.Size(637, 29);
            this.ComboSetor.Style = MetroFramework.MetroColorStyle.Green;
            this.ComboSetor.TabIndex = 12;
            this.ComboSetor.UseSelectable = true;
            this.ComboSetor.UseStyleColors = true;
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LabelId.Location = new System.Drawing.Point(45, 12);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(26, 19);
            this.LabelId.Style = MetroFramework.MetroColorStyle.Green;
            this.LabelId.TabIndex = 11;
            this.LabelId.Text = "Id:";
            this.LabelId.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Nome:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // TextNome
            // 
            this.TextNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextNome.CustomButton.Image = null;
            this.TextNome.CustomButton.Location = new System.Drawing.Point(611, 1);
            this.TextNome.CustomButton.Name = "";
            this.TextNome.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TextNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextNome.CustomButton.TabIndex = 1;
            this.TextNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextNome.CustomButton.UseSelectable = true;
            this.TextNome.CustomButton.Visible = false;
            this.TextNome.Lines = new string[0];
            this.TextNome.Location = new System.Drawing.Point(13, 117);
            this.TextNome.MaxLength = 32767;
            this.TextNome.Name = "TextNome";
            this.TextNome.PasswordChar = '\0';
            this.TextNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextNome.SelectedText = "";
            this.TextNome.SelectionLength = 0;
            this.TextNome.SelectionStart = 0;
            this.TextNome.ShortcutsEnabled = true;
            this.TextNome.Size = new System.Drawing.Size(639, 29);
            this.TextNome.Style = MetroFramework.MetroColorStyle.Green;
            this.TextNome.TabIndex = 8;
            this.TextNome.UseSelectable = true;
            this.TextNome.UseStyleColors = true;
            this.TextNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Label3.Location = new System.Drawing.Point(13, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(26, 19);
            this.Label3.Style = MetroFramework.MetroColorStyle.Green;
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Id:";
            this.Label3.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(655, 321);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Voltar";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Enter += new System.EventHandler(this.metroTabPage1_Enter);
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Location = new System.Drawing.Point(592, 433);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.BtnSelecionar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnSelecionar.TabIndex = 4;
            this.BtnSelecionar.Text = "Selecionar";
            this.BtnSelecionar.UseSelectable = true;
            this.BtnSelecionar.UseStyleColors = true;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(430, 433);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseSelectable = true;
            this.BtnExcluir.UseStyleColors = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(511, 433);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseSelectable = true;
            this.BtnSalvar.UseStyleColors = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BuscarFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 479);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.BtnSelecionar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnExcluir);
            this.Name = "BuscarFuncao";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Buscar Função";
            this.metroTabControl1.ResumeLayout(false);
            this.TabBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncao)).EndInit();
            this.TabEditar.ResumeLayout(false);
            this.TabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRiscos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TabBuscar;
        private MetroFramework.Controls.MetroTextBox TextBuscaFuncao;
        private MetroFramework.Controls.MetroButton BtnBuscar;
        private MetroFramework.Controls.MetroGrid GridFuncao;
        private MetroFramework.Controls.MetroTabPage TabEditar;
        private MetroFramework.Controls.MetroLabel LabelId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TextNome;
        private MetroFramework.Controls.MetroLabel Label3;
        private MetroFramework.Controls.MetroButton BtnSelecionar;
        private MetroFramework.Controls.MetroButton BtnExcluir;
        private MetroFramework.Controls.MetroButton BtnSalvar;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroGrid GridRiscos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox ComboSetor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecion;
    }
}