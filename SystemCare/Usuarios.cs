using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class Usuarios : MetroForm
    {
        QuerryMysql CriarUsuario = new QuerryMysql();
        static string IdUsuario = "";
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BtnCriarUsuario_Click(object sender, EventArgs e)
        {
            if (TextUsuario.Text.Length == 0 || TextSenha.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Favor preencher todos os campos do formulário!", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                CriarUsuario.CadastraUsuario(TextUsuario.Text,TextSenha.Text);
                TextUsuario.Text = "";
                TextSenha.Text = "";
                MetroMessageBox.Show(this, "Usuário cadastrado com sucesso!", "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable TabelaResultadoBusca = CriarUsuario.RetornaUsuarios(TextBuscar.Text);
            GridUsuarios.DataSource = TabelaResultadoBusca;

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
           

           
            if (BtnEditar.Text.Equals("Editar"))
            {
                metroLabel3.Visible = true;
                metroLabel3.Visible = true;
                TextUsuarioEditar.Visible = true;
                TextSenhaEditar.Visible = true;
                BtnExcluir.Visible = true;

                for (var i = 0; i < GridUsuarios.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridUsuarios.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdUsuario = GridUsuarios.Rows[i].Cells[1].Value.ToString();
                            TextUsuarioEditar.Text = GridUsuarios.Rows[i].Cells[2].Value.ToString();
                            i = GridUsuarios.Rows.Count;
                           
                        }
                    }
                    catch
                    {
                    }
                BtnEditar.Text = "Salvar";
               
            }
            else
            {
               
                CriarUsuario.AtualizaUsuarios(TextUsuarioEditar.Text, TextSenhaEditar.Text, IdUsuario);
                MetroMessageBox.Show(this,
                    "Dados salvos com sucesso !", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextUsuarioEditar.Text = "";
                TextSenhaEditar.Text = "";
                TextBuscar.Text = "";
                GridUsuarios.DataSource = null;
                BtnEditar.Text = "Editar";
                metroLabel3.Visible = false;
                metroLabel4.Visible = false;
                TextUsuarioEditar.Visible = false;
                TextSenhaEditar.Visible = false;
                BtnExcluir.Visible = false;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var Certeza = MetroMessageBox.Show(this,
                "Você tem certeza que deseja excluir o usuário selecionado ?", "Certeza ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Certeza == DialogResult.OK)
            {
                var IdUsuario = "";
                for (var i = 0; i < GridUsuarios.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridUsuarios.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdUsuario = GridUsuarios.Rows[i].Cells[1].Value.ToString();
                            i = GridUsuarios.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                CriarUsuario.ExcluirUsuario(IdUsuario);
                MetroMessageBox.Show(this,
                    "Usuário excluido com sucesso !", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextUsuarioEditar.Text = "";
                TextSenhaEditar.Text = "";
                TextBuscar.Text = "";
                GridUsuarios.DataSource = null;
                BtnEditar.Text = "Editar";
                metroLabel3.Visible = false;
                metroLabel4.Visible = false;
                TextUsuarioEditar.Visible = false;
                TextSenhaEditar.Visible = false;
                BtnExcluir.Visible = false;
            }
        }
    }
}
