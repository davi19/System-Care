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
    public partial class BuscarSetor : MetroForm
    {
        QuerryMysql BuscaSetor = new QuerryMysql();
        public BuscarSetor()
        {

            InitializeComponent();
            DataTable TabelaEmpresas = BuscaSetor.SelecionaEmpresa();
            ComboEmpresa.DataSource = TabelaEmpresas;
            ComboEmpresa.DisplayMember = "nome";
            ComboEmpresa.ValueMember = "id";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable TabelaSetores = BuscaSetor.BuscaSetor(TextBuscaSetor.Text);
            if (TabelaSetores.Rows.Count == 0)
            {
                MetroMessageBox.Show(this,
                    "Sua busca não encontrou nenhum resultado", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GridSetor.DataSource = TabelaSetores;
            }
        }

        private void TextBuscaSetor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscar_Click(sender,e);
            }
        }

        private void GridSetor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable DadosSetor = BuscaSetor.RetornaDadosSetor(GridSetor.Rows[e.RowIndex].Cells[0].Value.ToString());
            LabelId.Text =  DadosSetor.Rows[0]["id"].ToString();
            ComboEmpresa.SelectedValue = DadosSetor.Rows[0]["idempresa"].ToString();
            TextNome.Text = DadosSetor.Rows[0]["nome"].ToString();
            metroTabControl1.SelectedTab = TabEditar;

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult Certeza = MetroMessageBox.Show(this,
                            "Você tem certeza que deseja excluir o setor selecionado ?", "Certeza ?",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Certeza == DialogResult.OK)
            {
                BuscaSetor.ExcluirSetor(LabelId.Text);
                MetroMessageBox.Show(this,
                   "Setor excluido com sucesso !", "Sucesso !",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabelId.Text = "";
                TextNome.Text = "";
                GridSetor.DataSource = null;

            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            BuscaSetor.EditarSetor(TextNome.Text,ComboEmpresa.SelectedValue.ToString(),LabelId.Text);
            MetroMessageBox.Show(this,
                  "Dados salvos com sucesso !", "Sucesso !",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            LabelId.Text = "";
            TextNome.Text = "";
            GridSetor.DataSource = null;
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            BuscaSetor.SetSetor(TextNome.Text);
            this.Hide();
        }
        private void metroTabPage1_Enter(object sender, EventArgs e)
        {
            BuscaSetor.SetSetor("Nenhum");
            this.Hide();
        }


    }
}
