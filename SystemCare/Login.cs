using System;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (TextUsuario.Text.Length == 0 && TextSenha.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Usuário e senha em brancos !", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (TextUsuario.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Usuário em branco !", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (TextSenha.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Senha em branco !", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                var Logar = new QuerryMysql();
                var PermissaoLogar = Logar.Login(TextUsuario.Text, TextSenha.Text);
                if (PermissaoLogar)
                {
                    var principal = new Principal();
                    principal.Show();
                    Hide();
                }
                else
                {
                    MetroMessageBox.Show(this, "Usuário ou senha incorreto !", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void TextSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                metroButton1_Click(sender, e);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.cactusdevs.com.br");
        }
    }
}