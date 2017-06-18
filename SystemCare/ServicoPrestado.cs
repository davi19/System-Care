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
    public partial class ServicoPrestado : MetroForm
    {
        QuerryMysql Cadastro = new QuerryMysql(); 
        public ServicoPrestado()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TextDescricao.Text.Length == 0)
            {
                MetroMessageBox.Show(this,
                    "Favor preencher a descrição do serviço!", "Atenção !",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cadastro.CadastrarServicos(TextDescricao.Text);
                TextDescricao.Text = "";
                MetroMessageBox.Show(this,
                   "Serviçocadastrado com sucesso!", "Sucesso !",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TextBusca.Text.Length == 0)
            {
                MetroMessageBox.Show(this,
                    "Favor preencher o campo de busca!", "Atenção !",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable TabelaExame = Cadastro.BuscarServico(TextBusca.Text);
                if (TabelaExame.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this,
                        "Sua busca não retornou resultados!", "Sucesso !",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridResultado.DataSource = TabelaExame;
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var IdServico = "";
            if (BtnEditar.Text.Equals("Editar"))
            {
                for (var i = 0; i < GridResultado.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridResultado.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdServico = GridResultado.Rows[i].Cells[1].Value.ToString();
                            TextDescricaoEditar.Text = GridResultado.Rows[i].Cells[2].Value.ToString();
                            i = GridResultado.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                if (IdServico.Equals(""))
                {
                    MetroMessageBox.Show(this,
                        "Nenhum exame selecionado", "Certeza ?",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    BtnEditar.Text = "Salvar";

                }
            }

            else
            {


                for (var i = 0; i < GridResultado.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridResultado.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdServico = GridResultado.Rows[i].Cells[1].Value.ToString();
                            i = GridResultado.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                Cadastro.EditarServicos(TextDescricaoEditar.Text, IdServico);
                TextDescricaoEditar.Text = "";
                TextBusca.Text = "";
                GridResultado.DataSource = "";
                BtnEditar.Text = "Editar";
                MetroMessageBox.Show(this,
                    "Dados atualizados com sucesso!", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var Certeza = MetroMessageBox.Show(this,
               "Você tem certeza que deseja excluir o exame selecionado ?", "Certeza ?",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Certeza == DialogResult.OK)
            {
                var IdServico= "";
                for (var i = 0; i < GridResultado.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridResultado.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdServico = GridResultado.Rows[i].Cells[1].Value.ToString();
                            i = GridResultado.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                Cadastro.ExcluirServico(IdServico);
                MetroMessageBox.Show(this,
                    "Exame excluido com sucesso !", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextDescricaoEditar.Text = "";
                TextBusca.Text = "";
                GridResultado.DataSource = "";
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnEditar.Text = "Editar";
            TextDescricaoEditar.Text = "";
            TextBusca.Text = "";
            GridResultado.DataSource = "";
        }
    }
}
