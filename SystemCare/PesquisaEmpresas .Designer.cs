namespace SystemCare
{
    partial class PesquisaEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaEmpresas));
            this.GridEmpresa = new MetroFramework.Controls.MetroGrid();
            this.BtnBuscarEmpresa = new MetroFramework.Controls.MetroButton();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.TextEmpresaBusca = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEmpresa
            // 
            this.GridEmpresa.AllowUserToAddRows = false;
            this.GridEmpresa.AllowUserToDeleteRows = false;
            this.GridEmpresa.AllowUserToResizeRows = false;
            this.GridEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridEmpresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridEmpresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridEmpresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridEmpresa.EnableHeadersVisualStyles = false;
            this.GridEmpresa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridEmpresa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridEmpresa.Location = new System.Drawing.Point(23, 112);
            this.GridEmpresa.Name = "GridEmpresa";
            this.GridEmpresa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridEmpresa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmpresa.Size = new System.Drawing.Size(579, 165);
            this.GridEmpresa.Style = MetroFramework.MetroColorStyle.Green;
            this.GridEmpresa.TabIndex = 103;
            this.GridEmpresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFuncionarioEditar_CellDoubleClick);
            // 
            // BtnBuscarEmpresa
            // 
            this.BtnBuscarEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarEmpresa.BackgroundImage = global::SystemCare.Properties.Resources.magnifier;
            this.BtnBuscarEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarEmpresa.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBuscarEmpresa.Location = new System.Drawing.Point(583, 82);
            this.BtnBuscarEmpresa.Name = "BtnBuscarEmpresa";
            this.BtnBuscarEmpresa.Size = new System.Drawing.Size(24, 24);
            this.BtnBuscarEmpresa.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnBuscarEmpresa.TabIndex = 1;
            this.BtnBuscarEmpresa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnBuscarEmpresa.UseSelectable = true;
            this.BtnBuscarEmpresa.Click += new System.EventHandler(this.BtnBuscarFuncionario_Click);
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel25.Location = new System.Drawing.Point(23, 60);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(104, 19);
            this.metroLabel25.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel25.TabIndex = 101;
            this.metroLabel25.Text = "BuscarEmpresa:";
            this.metroLabel25.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TextEmpresaBusca
            // 
            this.TextEmpresaBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TextEmpresaBusca.CustomButton.Image = null;
            this.TextEmpresaBusca.CustomButton.Location = new System.Drawing.Point(532, 2);
            this.TextEmpresaBusca.CustomButton.Name = "";
            this.TextEmpresaBusca.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.TextEmpresaBusca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextEmpresaBusca.CustomButton.TabIndex = 1;
            this.TextEmpresaBusca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextEmpresaBusca.CustomButton.UseSelectable = true;
            this.TextEmpresaBusca.CustomButton.Visible = false;
            this.TextEmpresaBusca.Icon = ((System.Drawing.Image)(resources.GetObject("TextEmpresaBusca.Icon")));
            this.TextEmpresaBusca.Lines = new string[0];
            this.TextEmpresaBusca.Location = new System.Drawing.Point(23, 82);
            this.TextEmpresaBusca.MaxLength = 32767;
            this.TextEmpresaBusca.Name = "TextEmpresaBusca";
            this.TextEmpresaBusca.PasswordChar = '\0';
            this.TextEmpresaBusca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextEmpresaBusca.SelectedText = "";
            this.TextEmpresaBusca.SelectionLength = 0;
            this.TextEmpresaBusca.SelectionStart = 0;
            this.TextEmpresaBusca.ShortcutsEnabled = true;
            this.TextEmpresaBusca.Size = new System.Drawing.Size(554, 24);
            this.TextEmpresaBusca.Style = MetroFramework.MetroColorStyle.Green;
            this.TextEmpresaBusca.TabIndex = 0;
            this.TextEmpresaBusca.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextEmpresaBusca.UseSelectable = true;
            this.TextEmpresaBusca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextEmpresaBusca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextEmpresaBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextFuncionarioBusca_KeyPress);
            // 
            // PesquisaEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 300);
            this.Controls.Add(this.GridEmpresa);
            this.Controls.Add(this.BtnBuscarEmpresa);
            this.Controls.Add(this.metroLabel25);
            this.Controls.Add(this.TextEmpresaBusca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PesquisaEmpresas";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Pesquisar Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GridEmpresa;
        private MetroFramework.Controls.MetroButton BtnBuscarEmpresa;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroTextBox TextEmpresaBusca;
    }
}