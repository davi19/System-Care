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

        private void funçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcoes CadastraFuncao = new Funcoes();
            CadastraFuncao.ShowDialog();
        }
    }
}
