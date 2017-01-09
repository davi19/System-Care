using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class ExamesAvaliacoes : MetroForm
    {
        QuerryMysql Cadastro = new QuerryMysql();
        public ExamesAvaliacoes()
        {
            InitializeComponent();

            DataTable TabelaExamesMedicos = Cadastro.SelecionaModalidadeExame();
            GridExameMedicoPrimeira.DataSource = TabelaExamesMedicos;

            DataTable TabelaTipoExame = Cadastro.SelecionaExameMedico();
            GridTipoExamePrimeira.DataSource = TabelaTipoExame;

            DataTable TabelaExamesMedicosNova = Cadastro.SelecionaModalidadeExame();
            GridExamesMedicosNova.DataSource = TabelaExamesMedicosNova;

            DataTable TabelaTipoExameNova = Cadastro.SelecionaExameMedico();
            GridTipoExameNova.DataSource = TabelaTipoExameNova;
        }

        private void BtnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            PesquisaFuncionario BuscarFuncionario = new PesquisaFuncionario("0");
            BuscarFuncionario.ShowDialog();
            string IdFuncionario = Cadastro.GetFuncionario();
            DataTable TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(IdFuncionario);
            DataTable TabelaFuncao = Cadastro.RetornaDadosFuncao(TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
            string[] Riscos = TabelaFuncao.Rows[0]["idrisco"].ToString().Split(';');
            LabelRiscos.Text = "";
            LabelRiscos.Visible = true;
            DataTable TabelaDadosRiscos = new DataTable();
            for (int i = 1; i < Riscos.Length; i++)
            {
                TabelaDadosRiscos = Cadastro.SelecionaRiscosFuncao(Riscos[i]);
                LabelRiscos.Text = LabelRiscos.Text +TabelaDadosRiscos.Rows[0][0].ToString() + ": " +
                                   TabelaDadosRiscos.Rows[0][1].ToString() +"\n" ;
            }
            LabelFuncionario.Text = "NOME: "+TabelaDadosFuncionario.Rows[0]["nome"].ToString() + "     CPF: " +
                                    TabelaDadosFuncionario.Rows[0]["cpf"].ToString() + "     FUNÇÃO: " +
                                    TabelaFuncao.Rows[0]["nome"].ToString();

        }

        private void BtnGerarAos_Click(object sender, EventArgs e)
        {
            string Apto = "";
            string Resultado = "";
            string IdFuncionario = Cadastro.GetFuncionario();
            DataTable TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(IdFuncionario);
            DataTable TabelaFuncao = Cadastro.RetornaDadosFuncao(TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
            DataTable TabelaSetor = Cadastro.RetornaDadosSetor(TabelaFuncao.Rows[0]["idsetor"].ToString());
            string Empresa = Cadastro.RetornaEmpresa(TabelaSetor.Rows[0]["idempresa"].ToString());
            if (CheckApto.Checked)
            {
                Apto = "S";
                Resultado = "APTO";
            }
            else
            {
                Apto = "N";
                Resultado = "NÃO APTO";
            }
            string ModalidadeExames = "";
            for (int i = 0; i < GridExameMedicoPrimeira.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridExameMedicoPrimeira.Rows[i].Cells[0].Value.ToString()))
                    {

                        ModalidadeExames = ModalidadeExames + ";" + GridExameMedicoPrimeira.Rows[i].Cells[1].Value.ToString();

                    }
                }
                catch
                {

                }
            }
            string TipoExame = "";
            for (int i = 0; i < GridTipoExamePrimeira.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridTipoExamePrimeira.Rows[i].Cells[0].Value.ToString()))
                    {

                        TipoExame = TipoExame + ";" + GridTipoExamePrimeira.Rows[i].Cells[1].Value.ToString();

                    }
                }
                catch
                {

                }
            }
            string Sexo = "";
            if (TabelaDadosFuncionario.Rows[0]["sexo"].ToString().Equals("M"))
            {
                Sexo = "MASCULINO";
            }
            else
            {
                Sexo = "FEMININO";
            }
            string ModalidadeExameAos = "";
            for (int i = 0; i < GridExameMedicoPrimeira.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridExameMedicoPrimeira.Rows[i].Cells[0].Value.ToString()))
                    {

                        ModalidadeExameAos = ModalidadeExameAos+ GridExameMedicoPrimeira.Rows[i].Cells[2].Value.ToString() +"\n";

                    }
                }
                catch
                {

                }
            }
            string TipoExameAos = "";
            for (int i = 0; i < GridTipoExamePrimeira.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridTipoExamePrimeira.Rows[i].Cells[0].Value.ToString()))
                    {

                        TipoExameAos = TipoExameAos  + GridTipoExamePrimeira.Rows[i].Cells[2].Value.ToString() +"\n";

                    }
                }
                catch
                {

                }
            }






            Cadastro.CadastraHistorico(IdFuncionario, Apto, ModalidadeExames, TipoExame,
                TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
            Relatorios AOS = new Relatorios(TabelaDadosFuncionario.Rows[0]["nome"].ToString(), TabelaDadosFuncionario.Rows[0]["idade"].ToString(), Resultado, ModalidadeExameAos, LabelRiscos.Text, TipoExameAos, Sexo,
                   TabelaDadosFuncionario.Rows[0]["datanascimento"].ToString(), TabelaDadosFuncionario.Rows[0]["telefone"].ToString(), TabelaDadosFuncionario.Rows[0]["cpf"].ToString(), TabelaDadosFuncionario.Rows[0]["naturalidade"].ToString(),
                   Empresa,
                   TabelaFuncao.Rows[0]["nome"].ToString(), TabelaDadosFuncionario.Rows[0]["identidade"].ToString());
            AOS.ShowDialog();
        }

        private void BtnSelecionaFuncionarioNova_Click(object sender, EventArgs e)
        {
            PesquisaFuncionario BuscarFuncionario = new PesquisaFuncionario("1");
            BuscarFuncionario.ShowDialog();
            string IdFuncionario = Cadastro.GetFuncionarioNova();
            DataTable TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(IdFuncionario);
            DataTable TabelaFuncao = Cadastro.RetornaDadosFuncao(TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
            string[] Riscos = TabelaFuncao.Rows[0]["idrisco"].ToString().Split(';');
            LabelRiscoFuncionario.Text = "";
            LabelRiscoFuncionario.Visible = true;
            DataTable TabelaDadosRiscos = new DataTable();
            for (int i = 1; i < Riscos.Length; i++)
            {
                TabelaDadosRiscos = Cadastro.SelecionaRiscosFuncao(Riscos[i]);
                LabelRiscoFuncionario.Text = LabelRiscoFuncionario.Text + TabelaDadosRiscos.Rows[0][0].ToString() + ": " +
                                   TabelaDadosRiscos.Rows[0][1].ToString() + "\n";
            }
            LabelFuncionarioNova.Text = "NOME: " + TabelaDadosFuncionario.Rows[0]["nome"].ToString() + "     CPF: " +
                                    TabelaDadosFuncionario.Rows[0]["cpf"].ToString() + "     FUNÇÃO: " +
                                    TabelaFuncao.Rows[0]["nome"].ToString();

        }

        private void BtnGerarAsoNova_Click(object sender, EventArgs e)
        {
            string Apto = "";
            string Resultado = "";
            string IdFuncionario = Cadastro.GetFuncionarioNova();
            DataTable TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(IdFuncionario);
            DataTable TabelaFuncao = Cadastro.RetornaDadosFuncao(TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
            DataTable TabelaSetor = Cadastro.RetornaDadosSetor(TabelaFuncao.Rows[0]["idsetor"].ToString());
            string Empresa = Cadastro.RetornaEmpresa(TabelaSetor.Rows[0]["idempresa"].ToString());
            if (CheckAptoNova.Checked)
            {
                Apto = "S";
                Resultado = "APTO";
            }
            else
            {
                Apto = "N";
                Resultado = "NÃO APTO";
            }
            string ModalidadeExames = "";
            for (int i = 0; i < GridExamesMedicosNova.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridExamesMedicosNova.Rows[i].Cells[0].Value.ToString()))
                    {

                        ModalidadeExames = ModalidadeExames + ";" + GridExamesMedicosNova.Rows[i].Cells[1].Value.ToString();

                    }
                }
                catch
                {

                }
            }
            string TipoExame = "";
            for (int i = 0; i < GridTipoExameNova.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridTipoExameNova.Rows[i].Cells[0].Value.ToString()))
                    {

                        TipoExame = TipoExame + ";" + GridTipoExameNova.Rows[i].Cells[1].Value.ToString();

                    }
                }
                catch
                {

                }
            }
            string Sexo = "";
            if (TabelaDadosFuncionario.Rows[0]["sexo"].ToString().Equals("M"))
            {
                Sexo = "MASCULINO";
            }
            else
            {
                Sexo = "FEMININO";
            }
            string ModalidadeExameAos = "";
            for (int i = 0; i < GridExamesMedicosNova.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridExamesMedicosNova.Rows[i].Cells[0].Value.ToString()))
                    {

                        ModalidadeExameAos = ModalidadeExameAos + GridExamesMedicosNova.Rows[i].Cells[2].Value.ToString() + "\n";

                    }
                }
                catch
                {

                }
            }
            string TipoExameAos = "";
            for (int i = 0; i < GridTipoExameNova.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridTipoExameNova.Rows[i].Cells[0].Value.ToString()))
                    {

                        TipoExameAos = TipoExameAos + GridTipoExameNova.Rows[i].Cells[2].Value.ToString() + "\n";

                    }
                }
                catch
                {

                }
            }






            Cadastro.CadastraHistorico(IdFuncionario, Apto, ModalidadeExames, TipoExame,
                TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
            Relatorios AOS = new Relatorios(TabelaDadosFuncionario.Rows[0]["nome"].ToString(), TabelaDadosFuncionario.Rows[0]["idade"].ToString(), Resultado, ModalidadeExameAos, LabelRiscoFuncionario.Text, TipoExameAos, Sexo,
                   TabelaDadosFuncionario.Rows[0]["datanascimento"].ToString(), TabelaDadosFuncionario.Rows[0]["telefone"].ToString(), TabelaDadosFuncionario.Rows[0]["cpf"].ToString(), TabelaDadosFuncionario.Rows[0]["naturalidade"].ToString(),
                   Empresa,
                   TabelaFuncao.Rows[0]["nome"].ToString(), TabelaDadosFuncionario.Rows[0]["identidade"].ToString());
            AOS.ShowDialog();
        }
    }
}
