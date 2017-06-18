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
    public partial class Cnae : MetroForm
    {
        QuerryMysql Cadastro = new QuerryMysql();
        string IdCnae;
        public Cnae()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TextCodigo.Text.Length == 0)
            {
                MetroMessageBox.Show(this,
               "Favor preencher o codigo do CNAE", "Atenção !",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TextDescricao.Text.Length == 0)
            {
                MetroMessageBox.Show(this,
               "Favor preencher a descrição do CNAE!", "Atenção !",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cadastro.CadastrarCnae(TextDescricao.Text, TextCodigo.Text);
                TextCodigo.Text = "";
                TextDescricao.Text = "";
                MetroMessageBox.Show(this,
              "CNAE cadastrada com sucesso!", "Sucesso !",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (BtnEditar.Text.Equals("Editar"))
            {
                IdCnae = "";
                for (var i = 0; i < GridSelecionaCbo.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridSelecionaCbo.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdCnae = GridSelecionaCbo.Rows[i].Cells[1].Value.ToString();
                            TextCodigoEditar.Text = GridSelecionaCbo.Rows[i].Cells[2].Value.ToString();
                            TextDescricaoEditar.Text = GridSelecionaCbo.Rows[i].Cells[3].Value.ToString();
                            BtnEditar.Text = "Salvar";
                            i = GridSelecionaCbo.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                if (IdCnae.Equals(""))
                {
                    MetroMessageBox.Show(this,
                        "Nenhuma CBO selecionada", "Certeza ?",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }

            else
            {


                Cadastro.AtualizaCnae(TextDescricaoEditar.Text,TextCodigoEditar.Text, IdCnae);
                TextDescricaoEditar.Text = "";
                TextCodigoEditar.Text = "";
                TextBusca.Text = "";
                GridSelecionaCbo.DataSource = null;
                MetroMessageBox.Show(this,
                       "Dados atualizados com sucesso!", "Sucesso !",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBuscarCbo_Click(object sender, EventArgs e)
        {
            DataTable TabelaResultado = Cadastro.BuscaCnaeEditar(TextBusca.Text);
            GridSelecionaCbo.DataSource = TabelaResultado;
        }
    }
}
