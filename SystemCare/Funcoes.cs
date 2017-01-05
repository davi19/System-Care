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
    public partial class Funcoes : MetroForm
    {
        QuerryMysql Cadastro = new QuerryMysql();
        public Funcoes()
        {
            InitializeComponent();
            DataTable TabelaRiscos = Cadastro.SelecionaRisco();
            DataGridRiscos.DataSource = TabelaRiscos;

            DataTable TabelaRiscosEditar = Cadastro.SelecionaRisco();
            GridRiscosEditar.DataSource = TabelaRiscosEditar;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {


            if (TextNomeFuncao.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Favor inserir um nome para a função!", "Atenção !", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
            }
            else
            {
                string[] IdCbo = LabelCbo.Text.Split('|');
                if (LabelCbo.Text.Equals("CBO"))
                {
                    MetroMessageBox.Show(this, "Favor selecionar uma CBO!", "Atenção !", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }
                else
                {
                    string IdRiscos = "";
                    string IdSetor = "";

                    for (int i = 0; i < GridSetores.Rows.Count; i++)
                    {
                        try
                        {
                            if (Convert.ToBoolean(GridSetores.Rows[i].Cells[0].Value.ToString()))
                            {

                                IdSetor = GridSetores.Rows[i].Cells[1].Value.ToString();
                                i = GridSetores.Rows.Count;
                            }
                        }
                        catch
                        {

                        }
                    }
                    if (IdSetor.Equals(""))
                    {
                        MetroMessageBox.Show(this, "Favor selecionar um setor!", "Atenção !", MessageBoxButtons.OK,
                            MessageBoxIcon.Hand);
                    }
                    else
                    {
                        for (int i = 0; i < DataGridRiscos.Rows.Count; i++)
                        {
                            try
                            {
                                if (Convert.ToBoolean(DataGridRiscos.Rows[i].Cells[0].Value.ToString()))
                                {

                                    IdRiscos = IdRiscos + ";" + DataGridRiscos.Rows[i].Cells[1].Value.ToString();

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
                            Cadastro.CadastrarFuncao(TextNomeFuncao.Text, IdCbo[1], IdRiscos, IdSetor);
                            MetroMessageBox.Show(this, "Função cadastrada com sucesso!", "Sucesso !", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                            TextNomeFuncao.Text = "";
                            GridSetores.DataSource = null;
                            GridCbo.DataSource = null;
                            TextNomeSetor.Text = "";
                            TextCbo.Text = "";
                            LabelCbo.Text = "CBO";

                        }
                    }
                }
            }
        }

        private void BtnBuscarCbo_Click(object sender, EventArgs e)
        {
            DataTable TabelaCbo = Cadastro.BuscarCbo(TextCbo.Text);
            GridCbo.DataSource = TabelaCbo;
            GridCbo.Visible = true;
        }
        private void GridCbo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LabelCbo.Text = " CBO | " + GridCbo.Rows[e.RowIndex].Cells[0].Value + " | " + GridCbo.Rows[e.RowIndex].Cells[1].Value;
            LabelCbo.UseStyleColors = true;
            LabelCbo.FontWeight = MetroLabelWeight.Bold;
            LabelCbo.AutoSize = true;
            TextCbo.Text = "";
            GridCbo.DataSource = null;
            GridCbo.Visible = false;
        }

        private void BtnBuscaSetor_Click(object sender, EventArgs e)
        {
            GridSetores.DataSource = null;
            DataTable TabelaSetores =  Cadastro.BuscaSetor(TextNomeSetor.Text);
            GridSetores.DataSource = TabelaSetores;

        }

        private void TextNomeSetor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscaSetor_Click(sender, e);
            }
        }

        private void TextNomeFuncao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscarCbo_Click(sender, e);
            }
        }
      
        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {
            DialogResult Certeza = MetroMessageBox.Show(this,
                            "Você tem certeza que deseja excluir a função selecionado ?", "Certeza ?",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Certeza == DialogResult.OK)
            {
                string IdFuncao = "";
                for (int i = 0; i < GridFuncaoEditar.Rows.Count; i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(GridFuncaoEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdFuncao = GridFuncaoEditar.Rows[i].Cells[1].Value.ToString();
                            i = GridFuncaoEditar.Rows.Count;

                        }
                    }
                    catch
                    {

                    }
                }
                Cadastro.ExcluirFuncao(IdFuncao);
                MetroMessageBox.Show(this,
                   "Função excluido com sucesso !", "Sucesso !",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextBuscaFuncao.Text = "";
                GridFuncaoEditar.DataSource = null;
                metroLabel2.Visible = false;
                metroLabel4.Visible = false;
                LabelCboEditar.Visible = false;
                GridSetorEditar.Visible = false;
                GridRiscosEditar.Visible = false;
                GridCboEditar.Visible = false;
                TextNomeFuncaoEditar.Visible = false;
                TextNomeSetorEditar.Visible = false;
                BtnBuscaSetorEditar.Visible = false;
                BtnBuscarCboEditar.Visible = false;
                TextCboEditar.Visible = false;

            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            string IdFuncao = "";
            if (BtnEditar.Text.Equals("Editar"))
            {
                metroLabel2.Visible = true;
                metroLabel4.Visible = true;
                LabelCboEditar.Visible = true;
                GridSetorEditar.Visible = true;
                GridRiscosEditar.Visible = true;
                GridCboEditar.Visible = true;
                TextNomeFuncaoEditar.Visible = true;
                TextNomeSetorEditar.Visible = true;
                TextCboEditar.Visible = true;
                BtnBuscaSetorEditar.Visible = true;
                BtnBuscarCboEditar.Visible = true;

                for (int i = 0; i < GridFuncaoEditar.Rows.Count; i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(GridFuncaoEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdFuncao = GridFuncaoEditar.Rows[i].Cells[1].Value.ToString();
                            i = GridFuncaoEditar.Rows.Count;

                        }
                    }
                    catch
                    {

                    }
                }
                DataTable DadosFuncao = Cadastro.RetornaDadosFuncao(IdFuncao);
                LabelCboEditar.Text= " CBO | " + Cadastro.RetornaCbo(DadosFuncao.Rows[0]["idcbo"].ToString());
                string NomeSetor= Cadastro.RetornaSetor(DadosFuncao.Rows[0]["idsetor"].ToString());
                TextNomeSetorEditar.Text = NomeSetor;
                TextNomeFuncaoEditar.Text = DadosFuncao.Rows[0]["nome"].ToString();
                BtnEditar.Text = "Salvar";
                string[] IdRiscos = DadosFuncao.Rows[0]["idrisco"].ToString().Split(';');

                BtnBuscaSetorEditar_Click(sender, e);
                for (int i = 0; i < GridSetorEditar.Rows.Count; i++)
                {

                    try
                    {
                        if (GridSetorEditar.Rows[i].Cells[2].Value.ToString().Equals(NomeSetor))
                        {
                            GridSetorEditar.Rows[i].Cells[0].Value = true;
                            i = GridSetorEditar.Rows.Count;

                        }
                    }
                    catch
                    {

                    }
                }
                for (int i = 0; i < GridRiscosEditar.Rows.Count; i++)
                {

                    try
                    {
                        for (int j = 0; j < IdRiscos.Length; j++)
                        {
                            if (GridRiscosEditar.Rows[i].Cells[1].Value.ToString().Equals(IdRiscos[j]))
                            {
                                GridRiscosEditar.Rows[i].Cells[0].Value = true;
                                j = IdRiscos.Length;

                            }
                        }
                    }
                    catch
                    {

                    }
                }

            }
            else
            {
                
                for (int i = 0; i < GridFuncaoEditar.Rows.Count; i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(GridFuncaoEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdFuncao = GridFuncaoEditar.Rows[i].Cells[1].Value.ToString();
                            i = GridFuncaoEditar.Rows.Count;

                        }
                    }
                    catch
                    {

                    }
                }
                string IdSetor = "";
                for (int i = 0; i < GridSetorEditar.Rows.Count; i++)
                {

                    try
                    {
                        if (Convert.ToBoolean(GridSetorEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdSetor = GridSetorEditar.Rows[i].Cells[1].Value.ToString();
                            i = GridSetorEditar.Rows.Count;

                        }
                    }
                    catch
                    {

                    }
                }
                string IdRiscos = "";
                for (int i = 0; i < GridRiscosEditar.Rows.Count; i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(GridRiscosEditar.Rows[i].Cells[0].Value.ToString()))
                        {

                            IdRiscos = IdRiscos + ";" + GridRiscosEditar.Rows[i].Cells[1].Value.ToString();

                        }
                    }
                    catch
                    {

                    }
                }
                string[] IdCbo = LabelCboEditar.Text.Split('|');
                Cadastro.EditarFuncao(TextNomeFuncaoEditar.Text, IdSetor, IdFuncao,IdRiscos,IdCbo[1]);
                MetroMessageBox.Show(this,
                      "Dados salvos com sucesso !", "Sucesso !",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroLabel2.Visible = false;
                metroLabel4.Visible = false;
                LabelCboEditar.Visible = false;
                GridSetorEditar.Visible = false;
                GridRiscosEditar.Visible = false;
                GridCboEditar.Visible = false;
                TextNomeFuncaoEditar.Visible = false;
                TextNomeSetorEditar.Visible = false;
                BtnBuscaSetorEditar.Visible = false;
                BtnBuscarCboEditar.Visible = false;
                TextCboEditar.Visible = false;
                TextBuscaFuncao.Text = "";
                GridFuncaoEditar.DataSource = null;
            }
        
    }

        private void BtnBuscarCboEditar_Click(object sender, EventArgs e)
        {
            GridCboEditar.DataSource = null;
            DataTable TabelaCbo = Cadastro.BuscarCbo(TextCboEditar.Text);
            GridCboEditar.DataSource = TabelaCbo;
            GridCboEditar.Visible = true;
        }

        private void TextCbo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                BtnBuscarCbo_Click(sender, e);
            }
        }

        private void TextCboEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscarCboEditar_Click(sender, e);
            }
        }

        private void BtnBuscaSetorEditar_Click(object sender, EventArgs e)
        {
            GridSetores.DataSource = null;
            DataTable TabelaSetores = Cadastro.BuscaSetor(TextNomeSetorEditar.Text);
             GridSetorEditar.DataSource = TabelaSetores;
        }

        private void TextNomeSetorEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscaSetorEditar_Click(sender, e);
            }
        }

        private void BtnBuscaFuncao_Click(object sender, EventArgs e)
        {
            GridFuncaoEditar.DataSource = null;
            DataTable TabelaFuncao = Cadastro.BuscaFuncao(TextBuscaFuncao.Text);
            GridFuncaoEditar.DataSource = TabelaFuncao;
        }

        private void TextBuscaFuncao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscaFuncao_Click(sender, e);
            }
        }

        private void GridCboEditar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LabelCboEditar.Text = " CBO | " + GridCboEditar.Rows[e.RowIndex].Cells[0].Value + " | " + GridCboEditar.Rows[e.RowIndex].Cells[1].Value;
            LabelCboEditar.UseStyleColors = true;
            LabelCboEditar.FontWeight = MetroLabelWeight.Bold;
            LabelCboEditar.AutoSize = true;
            TextCboEditar.Text = "";
            GridCboEditar.DataSource = null;
            GridCboEditar.Visible = false;
        }
    }
}
