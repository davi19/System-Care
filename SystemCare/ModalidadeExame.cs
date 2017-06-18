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
    public partial class ModalidadeExame : MetroForm
    {
        QuerryMysql Cadastro = new QuerryMysql();
        public ModalidadeExame()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            if (TextDescricao.Text.Length == 0)
            {
                MetroMessageBox.Show(this,
                    "Favor preencher a descrição da modalidade de exame!", "Atenção !",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cadastro.CadastrarModalidadeExame(TextDescricao.Text);
                TextDescricao.Text = "";
                MetroMessageBox.Show(this,
                   "Modalidade de exame cadastrado com sucesso!", "Sucesso !",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var IdExame = "";
            if (BtnEditar.Text.Equals("Editar"))
            {
                for (var i = 0; i < GridResultado.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridResultado.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdExame = GridResultado.Rows[i].Cells[1].Value.ToString();
                            TextDescricaoEditar.Text = GridResultado.Rows[i].Cells[2].Value.ToString();
                            i = GridResultado.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                if (IdExame.Equals(""))
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
                            IdExame = GridResultado.Rows[i].Cells[1].Value.ToString();
                            i = GridResultado.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                Cadastro.EditarModalidadeExame(TextDescricaoEditar.Text, IdExame);
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
                "Você tem certeza que deseja excluir a modalidade de exame selecionada ?", "Certeza ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Certeza == DialogResult.OK)
            {
                var IdExame = "";
                for (var i = 0; i < GridResultado.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridResultado.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdExame = GridResultado.Rows[i].Cells[1].Value.ToString();
                            i = GridResultado.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                Cadastro.ExcluirModalidadeExame(IdExame);
                MetroMessageBox.Show(this,
                    "Modalidade de exame excluido com sucesso !", "Sucesso !",
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
                DataTable TabelaExame = Cadastro.BuscarModalidadeExame(TextBusca.Text);
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
    }
}
