namespace SystemCare
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TextUsuario = new MetroFramework.Controls.MetroTextBox();
            this.TextSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.BtnSair = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextUsuario
            // 
            // 
            // 
            // 
            this.TextUsuario.CustomButton.Image = null;
            this.TextUsuario.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.TextUsuario.CustomButton.Name = "";
            this.TextUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextUsuario.CustomButton.TabIndex = 1;
            this.TextUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextUsuario.CustomButton.UseSelectable = true;
            this.TextUsuario.CustomButton.Visible = false;
            this.TextUsuario.Lines = new string[0];
            this.TextUsuario.Location = new System.Drawing.Point(23, 192);
            this.TextUsuario.MaxLength = 32767;
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.PasswordChar = '\0';
            this.TextUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextUsuario.SelectedText = "";
            this.TextUsuario.SelectionLength = 0;
            this.TextUsuario.SelectionStart = 0;
            this.TextUsuario.ShortcutsEnabled = true;
            this.TextUsuario.Size = new System.Drawing.Size(254, 23);
            this.TextUsuario.Style = MetroFramework.MetroColorStyle.Green;
            this.TextUsuario.TabIndex = 0;
            this.TextUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextUsuario.UseSelectable = true;
            this.TextUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextSenha
            // 
            // 
            // 
            // 
            this.TextSenha.CustomButton.Image = null;
            this.TextSenha.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.TextSenha.CustomButton.Name = "";
            this.TextSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextSenha.CustomButton.TabIndex = 1;
            this.TextSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextSenha.CustomButton.UseSelectable = true;
            this.TextSenha.CustomButton.Visible = false;
            this.TextSenha.Lines = new string[0];
            this.TextSenha.Location = new System.Drawing.Point(23, 240);
            this.TextSenha.MaxLength = 32767;
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.PasswordChar = '*';
            this.TextSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextSenha.SelectedText = "";
            this.TextSenha.SelectionLength = 0;
            this.TextSenha.SelectionStart = 0;
            this.TextSenha.ShortcutsEnabled = true;
            this.TextSenha.Size = new System.Drawing.Size(254, 23);
            this.TextSenha.Style = MetroFramework.MetroColorStyle.Green;
            this.TextSenha.TabIndex = 1;
            this.TextSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextSenha.UseSelectable = true;
            this.TextSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSenha_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 170);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Usuário";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 218);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Senha";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(151, 315);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Logar";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(55, 315);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "Sair";
            this.BtnSair.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSair.UseSelectable = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemCare.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(62, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(68, 269);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(165, 23);
            this.metroLink1.TabIndex = 7;
            this.metroLink1.Text = "www.cactusdevs.com.br";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 361);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TextSenha);
            this.Controls.Add(this.TextUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TextUsuario;
        private MetroFramework.Controls.MetroTextBox TextSenha;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton BtnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}