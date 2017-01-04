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
using Microsoft.Reporting.WebForms;
using ReportParameter = Microsoft.Reporting.WebForms.Internal.Soap.ReportingServices2005.Execution.ReportParameter;

namespace SystemCare
{
    public partial class Principal : MetroForm
    {
        QuerryMysql Cadastro = new QuerryMysql();
        public Principal()
        {
            InitializeComponent();
          
            Text = "System Care V."+Application.ProductVersion;
            

            DataTable TabelaRiscos = Cadastro.SelecionaRisco();
            DataGridRiscos.DataSource = TabelaRiscos;






            DataTable TabelaEmpresa = Cadastro.SelecionaEmpresa();
            ComboEmpresaFuncionario.DataSource = TabelaEmpresa;
            ComboEmpresaFuncionario.DisplayMember = "nome";
            ComboEmpresaFuncionario.ValueMember = "id";
            

            DataTable TabelaModalidadesExame = Cadastro.SelecionaModalidadeExame();
            GridModalidadeExame.DataSource = TabelaModalidadesExame;

            DataTable TabelaExame = Cadastro.SelecionaExameMedico();
            GridTipoExame.DataSource = TabelaExame;
        }


        private void TabSair_Enter(object sender, EventArgs e)
        {
            Application.Exit();
        }  

      


   

        private void BtnCadastrarSetorFuncao_Click(object sender, EventArgs e)
        {
            if (CheckCadastroFuncao.Checked)
            {
                string[] IdCbo = LabelCbo.Text.Split('|');
                if ( TextNomeFuncao.Text.Length == 0 || IdCbo[0].Equals(""))
                {
                    MetroMessageBox.Show(this, "Favor preencher todos os campos em destaque!", "Atenção !", MessageBoxButtons.OK,
                   MessageBoxIcon.Hand);
                }
                else
                { 
               
                string IdRiscos = "";

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


                        MetroMessageBox.Show(this, "Setor e Função cadastrado com sucesso!", "Sucesso !",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }


                
            }
            else
            {

                
                    
                    MetroMessageBox.Show(this, "Setor cadastrado com sucesso!", "Sucesso !", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                
            }
        }

        private void BtnBuscarCbo_Click(object sender, EventArgs e)
        {
            DataTable TabelaCbo = Cadastro.BuscarCbo(TextCbo.Text);
            GridCbo.DataSource=TabelaCbo;
            GridCbo.Visible = true;
        }

        private void GridCbo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LabelCbo.Text = " CBO | " + GridCbo.Rows[e.RowIndex].Cells[0].Value + " | " +GridCbo.Rows[e.RowIndex].Cells[1].Value;
            LabelCbo.UseStyleColors = true;
            LabelCbo.FontWeight = MetroLabelWeight.Bold;
            LabelCbo.AutoSize = true;
            TextCbo.Text = "";
            GridCbo.DataSource = null;
            GridCbo.Visible = false;
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCadastroFuncao.Checked)
            {
                TextCbo.Enabled = true;
                TextNomeFuncao.Enabled = true;
                DataGridRiscos.Visible = true;
                BtnBuscarCbo.Enabled = true;
                TextNomeFuncao.Text = "";

            }
            else
            {
                TextCbo.Enabled = false;
                TextNomeFuncao.Enabled = false;
                DataGridRiscos.Visible = false;
                BtnBuscarCbo.Enabled = false;
            }
        }

        private void BtnEditarFuncao_Click(object sender, EventArgs e)
        {
            BuscarFuncao buscafuncao = new BuscarFuncao();
            buscafuncao.ShowDialog();
            string NomeFuncao = Cadastro.GetFuncao();
            if (NomeFuncao.Equals("Nenhum"))
            {
                
            }
            else
            {
                TextNomeFuncao.Text = NomeFuncao;
                CheckCadastroFuncao.Checked = false;
                TextNomeFuncao.Enabled = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.ShowDialog();
        }
    
        private void BtnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            string Resultado = "";
            string Sexo = "";
            if (CheckAptoFuncionario.Checked)
            {
                Resultado = "APTO";
            }
            else
            {
                MetroMessageBox.Show(this, "Favor informar se o funcionário está apto!", "Atenção !", MessageBoxButtons.OK,
                       MessageBoxIcon.Hand);
            }
            if (RadioMasculino.Checked)
            {
                Sexo = "MASCULINO";
            }
            else if (RadioFeminino.Checked)
            {
                Sexo = "FEMININO";
            }
            else
            {
                MetroMessageBox.Show(this, "Favor preencher o sexo do funcionário!", "Atenção !", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
            }
            string TipoExame="";

            for (int i=0; i<GridTipoExame.Rows.Count;i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(GridTipoExame.Rows[i].Cells[0].Value))
                        {
                            TipoExame = GridTipoExame.Rows[i].Cells[2].Value.ToString();
                        }
                    }
                    catch
                    {
                        
                    }
                }
            string ModalidadeExame = "";
            for (int i = 0; i < GridModalidadeExame.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridModalidadeExame.Rows[i].Cells[0].Value))
                    {
                        ModalidadeExame = ModalidadeExame +GridModalidadeExame.Rows[i].Cells[3].Value.ToString() + " - " + GridModalidadeExame.Rows[i].Cells[1].Value.ToString() + "\n";

                    }
                }
                catch
                {

                }
            }
            DataTable TabelaDadosFuncao = Cadastro.RetornaDadosFuncao(ComboFuncaoFuncionario.SelectedValue.ToString());
            string [] IdRiscos = TabelaDadosFuncao.Rows[0]["idrisco"].ToString().Split(';');
            string RiscosOperacionais = "";
            for (int j = 1; j < IdRiscos.Length; j++)
            {
               DataTable TabelaDadosRiscos = Cadastro.SelecionaRiscosFuncao(IdRiscos[j]);
                RiscosOperacionais = RiscosOperacionais + TabelaDadosRiscos.Rows[0][0].ToString() + " - " +
                                     TabelaDadosRiscos.Rows[0][1].ToString() + "\n";
            }

            Relatorios AOS = new Relatorios(TextNomeFuncionario.Text, TextIdade.Text, Resultado, ModalidadeExame, RiscosOperacionais, TipoExame, Sexo,
                    TextDataNascimento.Text, TextTelefoneFuncionario.Text, TextCpf.Text, TextNaturalidade.Text,
                    "",
                    ComboFuncaoFuncionario.Text, TextIdentidade.Text);
                AOS.ShowDialog();
            
        }

        private void ComboEmpresaFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
           try
            {
                DataTable TabelaFuncoes =
                    Cadastro.SelecionaSetorEmpresa(ComboEmpresaFuncionario.SelectedValue.ToString());
                ComboSetorFuncionario.DataSource = TabelaFuncoes;
                ComboSetorFuncionario.DisplayMember = "nome";
                ComboSetorFuncionario.ValueMember = "id";
            }
            catch
            {
                
            }
        }

        private void ComboSetorFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable TabelaFuncoes =
                    Cadastro.SelecionaFuncaoEmpresa(ComboSetorFuncionario.SelectedValue.ToString());
                ComboFuncaoFuncionario.DataSource = TabelaFuncoes;
                ComboFuncaoFuncionario.DisplayMember = "nome";
                ComboFuncaoFuncionario.ValueMember = "id";
            }
            catch
            {

            }
        }

        private void BtnQuestionarioFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresas CadastroEmpresa = new Empresas();
            CadastroEmpresa.ShowDialog();
        }

        private void setoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setores CadastroSetores = new Setores();
            CadastroSetores.ShowDialog();
        }
    }
}
