namespace SystemCare
{
    partial class CadastrarDespesa
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
            this.TextNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.TextValor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TextData = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BtnEditar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TextNome
            // 
            // 
            // 
            // 
            this.TextNome.CustomButton.Image = null;
            this.TextNome.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.TextNome.CustomButton.Name = "";
            this.TextNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextNome.CustomButton.TabIndex = 1;
            this.TextNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextNome.CustomButton.UseSelectable = true;
            this.TextNome.CustomButton.Visible = false;
            this.TextNome.Lines = new string[0];
            this.TextNome.Location = new System.Drawing.Point(23, 98);
            this.TextNome.MaxLength = 32767;
            this.TextNome.Name = "TextNome";
            this.TextNome.PasswordChar = '\0';
            this.TextNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextNome.SelectedText = "";
            this.TextNome.SelectionLength = 0;
            this.TextNome.SelectionStart = 0;
            this.TextNome.ShortcutsEnabled = true;
            this.TextNome.Size = new System.Drawing.Size(426, 23);
            this.TextNome.TabIndex = 0;
            this.TextNome.UseSelectable = true;
            this.TextNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nome Despesa";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(366, 254);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Cadastrar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // TextValor
            // 
            // 
            // 
            // 
            this.TextValor.CustomButton.Image = null;
            this.TextValor.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.TextValor.CustomButton.Name = "";
            this.TextValor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextValor.CustomButton.TabIndex = 1;
            this.TextValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextValor.CustomButton.UseSelectable = true;
            this.TextValor.CustomButton.Visible = false;
            this.TextValor.Lines = new string[0];
            this.TextValor.Location = new System.Drawing.Point(23, 146);
            this.TextValor.MaxLength = 32767;
            this.TextValor.Name = "TextValor";
            this.TextValor.PasswordChar = '\0';
            this.TextValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextValor.SelectedText = "";
            this.TextValor.SelectionLength = 0;
            this.TextValor.SelectionStart = 0;
            this.TextValor.ShortcutsEnabled = true;
            this.TextValor.Size = new System.Drawing.Size(102, 23);
            this.TextValor.TabIndex = 3;
            this.TextValor.UseSelectable = true;
            this.TextValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Valor Despesa";
            // 
            // TextData
            // 
            this.TextData.Location = new System.Drawing.Point(148, 146);
            this.TextData.Mask = "00/00/0000";
            this.TextData.Name = "TextData";
            this.TextData.Size = new System.Drawing.Size(301, 20);
            this.TextData.TabIndex = 5;
            this.TextData.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(148, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Data Despesa";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(285, 254);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 7;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseSelectable = true;
            // 
            // CadastrarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 300);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TextData);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TextValor);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TextNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastrarDespesa";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Cadastrar Desespesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TextNome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox TextValor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.MaskedTextBox TextData;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton BtnEditar;
    }
}