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
    public partial class BuscarFuncao : MetroForm
    {
        QuerryMysql BuscaFuncao = new QuerryMysql();
        public BuscarFuncao()
        {
            InitializeComponent();
          
            DataTable TabelaSetores = BuscaFuncao.SelecionaSetor();
            ComboSetor.DataSource = TabelaSetores;
            ComboSetor.DisplayMember = "nome";
            ComboSetor.ValueMember = "id";
            DataTable TabelaRiscos = BuscaFuncao.SelecionaRisco();
            GridRiscos.DataSource = TabelaRiscos;
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable TabelaSetores = BuscaFuncao.BuscaFuncao(TextBuscaFuncao.Text);
            if (TabelaSetores.Rows.Count == 0)
            {
                MetroMessageBox.Show(this,
                    "Sua busca não encontrou nenhum resultado", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GridFuncao.DataSource = TabelaSetores;
            }
        }

        private void TextBuscaSetor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscar_Click(sender, e);
            }
        }

        private void GridSetor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable DadosSetor = BuscaFuncao.RetornaDadosFuncao(GridFuncao.Rows[e.RowIndex].Cells[0].Value.ToString());
            LabelId.Text = DadosSetor.Rows[0]["id"].ToString();
            ComboSetor.SelectedValue = DadosSetor.Rows[0]["idsetor"].ToString();
            TextNome.Text = DadosSetor.Rows[0]["nome"].ToString();
            string[] Riscos = DadosSetor.Rows[0]["idrisco"].ToString().Split(';');
            for (int i = 1; i < Riscos.Length; i++)
            {
                for (int j = 0; j < GridRiscos.Rows.Count; j++)
                {
                   
                    if (GridRiscos.Rows[j].Cells[1].Value.ToString().Equals(Riscos.GetValue(i).ToString()))
                    {
                        GridRiscos.Rows[j].Cells[0].Value=true;
                       
                            j = GridRiscos.Rows.Count;
                            
                        
                    }
                }
            }
            metroTabControl1.SelectedTab = TabEditar;

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult Certeza = MetroMessageBox.Show(this,
                            "Você tem certeza que deseja excluir a função selecionado ?", "Certeza ?",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Certeza == DialogResult.OK)
            {
                BuscaFuncao.ExcluirFuncao(LabelId.Text);
                MetroMessageBox.Show(this,
                   "Função excluido com sucesso !", "Sucesso !",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabelId.Text = "";
                TextNome.Text = "";
                GridFuncao.DataSource = null;

            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            string IdRiscos = "";

            for (int i = 0; i < GridRiscos.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridRiscos.Rows[i].Cells[0].Value.ToString()))
                    {

                        IdRiscos = IdRiscos + ";" + GridRiscos.Rows[i].Cells[1].Value.ToString();

                    }
                }
                catch
                {

                }
            }
            if (IdRiscos.Equals(""))
            {
                MetroMessageBox.Show(this, "Favor selecionar um risco!", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {

                BuscaFuncao.EditarFuncao(TextNome.Text, ComboSetor.SelectedValue.ToString(), LabelId.Text, IdRiscos);
                MetroMessageBox.Show(this,
                    "Dados salvos com sucesso !", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabelId.Text = "";
                TextNome.Text = "";
                GridFuncao.DataSource = null;
            }
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            BuscaFuncao.SetFuncao(TextNome.Text);
            this.Hide();
        }
        private void metroTabPage1_Enter(object sender, EventArgs e)
        {
            BuscaFuncao.SetSetor("Nenhum");
            this.Hide();
        }


    }
}
