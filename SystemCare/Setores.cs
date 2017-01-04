using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace SystemCare
{
    public partial class Setores : MetroForm
    {
        QuerryMysql CadastroSetor = new QuerryMysql();
        public Setores()
        {
            InitializeComponent();
        }

        private void BtnCadastrarSetor_Click(object sender, EventArgs e)
        {
            string IdEmpresa = "";
            for (int i = 0; i < DataGridEmpresas.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(DataGridEmpresas.Rows[i].Cells[0].Value.ToString()))
                    {

                        IdEmpresa =DataGridEmpresas.Rows[i].Cells[1].Value.ToString();
                        i = DataGridEmpresas.Rows.Count;

                    }
                }
                catch
                {

                }
            }
            CadastroSetor.CadastrarSetor(IdEmpresa, TextNomeSetor.Text);
            MetroMessageBox.Show(this, "Setor Cadastrado com sucesso!", "Atenção !", MessageBoxButtons.OK,MessageBoxIcon.Information);
            DataGridEmpresas.DataSource = null;
            TextNomeSetor.Text = "";
            TextPesdquisaEmpresa.Text = "";

        }

        private void BtnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            DataGridEmpresas.DataSource = null;
            DataTable TabelaEmpresa = CadastroSetor.BuscaEmpresa(TextPesdquisaEmpresa.Text);
            DataGridEmpresas.DataSource = TabelaEmpresa;


        }

        private void TextPesdquisaEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscarEmpresa_Click(sender, e);
            }
        }

        private void BtnBuscaSetorEditar_Click(object sender, EventArgs e)
        {
            DataTable TabelaSetores = CadastroSetor.BuscaSetor(TextPesquisaSetorEditar.Text);
            if (TabelaSetores.Rows.Count == 0)
            {
                MetroMessageBox.Show(this,
                    "Sua busca não encontrou nenhum resultado", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataGridSetorEditar.DataSource = TabelaSetores;
            }
        }
        private void TextPesquisaSetorEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscaSetorEditar_Click(sender, e);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            metroLabel2.Visible = true;

            string IdSetor = "";
            if (BtnEditar.Text.Equals("Editar"))
            {
                metroLabel2.Visible = true;
                metroLabel3.Visible = true;
                DataGridEmpresaEditar.Visible = true;
                TextPesquisaEmpresaEditar.Visible = true;
                TextNomeSetorEditar.Visible = true;
                BtnBuscaEmpresaEditar.Visible = true;

                for (int i = 0; i < DataGridSetorEditar.Rows.Count; i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(DataGridSetorEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdSetor = DataGridSetorEditar.Rows[i].Cells[1].Value.ToString();
                            i = DataGridSetorEditar.Rows.Count;

                        }
                    }
                    catch
                    {

                    }
                }
                DataTable DadosSetor = CadastroSetor.RetornaDadosSetor(IdSetor);
                string NomeEmpresa = CadastroSetor.RetornaEmpresa(DadosSetor.Rows[0]["idempresa"].ToString());
                TextNomeSetorEditar.Text = DadosSetor.Rows[0]["nome"].ToString();
                BtnEditar.Text = "Salvar";
                BtnBuscaEmpresaEditar_Click(sender, e);
                for (int i = 0; i < DataGridEmpresaEditar.Rows.Count; i++)
                {

                    try
                    {
                        if (DataGridEmpresaEditar.Rows[i].Cells[2].Value.ToString().Equals(NomeEmpresa))
                        {
                            DataGridEmpresaEditar.Rows[i].Cells[0].Value = true;
                            i = DataGridEmpresaEditar.Rows.Count;

                        }
                    }
                    catch
                    {

                    }
                }


            }
            else
            {

                for (int i = 0; i < DataGridSetorEditar.Rows.Count; i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(DataGridSetorEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdSetor = DataGridSetorEditar.Rows[i].Cells[1].Value.ToString();
                            i = DataGridSetorEditar.Rows.Count;

                        }
                    }
                    catch
                    {

                    }
                }
                    string IdEmpresa = "";
                for (int i = 0; i < DataGridEmpresaEditar.Rows.Count; i++)
                {
                
                    try
                    {
                        if (Convert.ToBoolean(DataGridEmpresaEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdEmpresa = DataGridEmpresaEditar.Rows[i].Cells[1].Value.ToString();
                            i = DataGridEmpresaEditar.Rows.Count;

                        }
                    }
                    catch
                    {

                    }
                }
                CadastroSetor.EditarSetor(TextNomeSetorEditar.Text,IdEmpresa, IdSetor);
                MetroMessageBox.Show(this,
                      "Dados salvos com sucesso !", "Sucesso !",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextPesquisaSetorEditar.Text = "";
                TextPesquisaEmpresaEditar.Text = "";
                TextNomeSetorEditar.Text = "";
                DataGridSetorEditar.DataSource = null;
                DataGridEmpresaEditar.DataSource = null;
                BtnEditar.Text = "Editar";
                metroLabel2.Visible = false;
                metroLabel3.Visible = false;
                DataGridEmpresaEditar.Visible = false;
                TextPesquisaEmpresaEditar.Visible = false;
                TextNomeSetorEditar.Visible = false;
                BtnBuscaEmpresaEditar.Visible = false;
            }
        }

        private void BtnBuscaEmpresaEditar_Click(object sender, EventArgs e)
        {
            DataGridEmpresaEditar.DataSource = null;
            DataTable TabelaEmpresa = CadastroSetor.BuscaEmpresa(TextPesdquisaEmpresa.Text);
            DataGridEmpresaEditar.DataSource = TabelaEmpresa;
        }
    }
}
