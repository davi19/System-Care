namespace SystemCare
{
    partial class BuscarEmpresa
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
            this.TextBusca = new MetroFramework.Controls.MetroTextBox();
            this.BtnBuscar = new MetroFramework.Controls.MetroButton();
            this.DataGridEmpresa = new MetroFramework.Controls.MetroGrid();
            this.SelecionaEmpres = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnExcluir = new MetroFramework.Controls.MetroButton();
            this.BtnEditar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBusca
            // 
            this.TextBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextBusca.CustomButton.Image = null;
            this.TextBusca.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.TextBusca.CustomButton.Name = "";
            this.TextBusca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBusca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBusca.CustomButton.TabIndex = 1;
            this.TextBusca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBusca.CustomButton.UseSelectable = true;
            this.TextBusca.CustomButton.Visible = false;
            this.TextBusca.Lines = new string[0];
            this.TextBusca.Location = new System.Drawing.Point(23, 63);
            this.TextBusca.MaxLength = 32767;
            this.TextBusca.Name = "TextBusca";
            this.TextBusca.PasswordChar = '\0';
            this.TextBusca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBusca.SelectedText = "";
            this.TextBusca.SelectionLength = 0;
            this.TextBusca.SelectionStart = 0;
            this.TextBusca.ShortcutsEnabled = true;
            this.TextBusca.Size = new System.Drawing.Size(448, 23);
            this.TextBusca.Style = MetroFramework.MetroColorStyle.Green;
            this.TextBusca.TabIndex = 0;
            this.TextBusca.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBusca.UseSelectable = true;
            this.TextBusca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBusca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBusca_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(477, 63);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnBuscar.UseSelectable = true;
            this.BtnBuscar.UseStyleColors = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DataGridEmpresa
            // 
            this.DataGridEmpresa.AllowUserToAddRows = false;
            this.DataGridEmpresa.AllowUserToDeleteRows = false;
            this.DataGridEmpresa.AllowUserToResizeColumns = false;
            this.DataGridEmpresa.AllowUserToResizeRows = false;
            this.DataGridEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridEmpresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridEmpresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelecionaEmpres});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridEmpresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridEmpresa.EnableHeadersVisualStyles = false;
            this.DataGridEmpresa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridEmpresa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridEmpresa.Location = new System.Drawing.Point(23, 92);
            this.DataGridEmpresa.MultiSelect = false;
            this.DataGridEmpresa.Name = "DataGridEmpresa";
            this.DataGridEmpresa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridEmpresa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridEmpresa.Size = new System.Drawing.Size(529, 185);
            this.DataGridEmpresa.Style = MetroFramework.MetroColorStyle.Green;
            this.DataGridEmpresa.TabIndex = 2;
            this.DataGridEmpresa.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // SelecionaEmpres
            // 
            this.SelecionaEmpres.HeaderText = "Selecionar";
            this.SelecionaEmpres.Name = "SelecionaEmpres";
            this.SelecionaEmpres.Width = 64;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(396, 283);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnExcluir.UseSelectable = true;
            this.BtnExcluir.UseStyleColors = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(477, 283);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnEditar.TabIndex = 4;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnEditar.UseSelectable = true;
            this.BtnEditar.UseStyleColors = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BuscarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 332);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.DataGridEmpresa);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextBusca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarEmpresa";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Buscar Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TextBusca;
        private MetroFramework.Controls.MetroButton BtnBuscar;
        private MetroFramework.Controls.MetroGrid DataGridEmpresa;
        private MetroFramework.Controls.MetroButton BtnExcluir;
        private MetroFramework.Controls.MetroButton BtnEditar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelecionaEmpres;
    }
}