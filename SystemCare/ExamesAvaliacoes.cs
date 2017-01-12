﻿using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class ExamesAvaliacoes : MetroForm
    {
        private readonly QuerryMysql Cadastro = new QuerryMysql();

        public ExamesAvaliacoes()
        {
            InitializeComponent();

            var TabelaExamesMedicos = Cadastro.SelecionaModalidadeExame();
            GridExameMedicoPrimeira.DataSource = TabelaExamesMedicos;

            var TabelaTipoExame = Cadastro.SelecionaExameMedico();
            GridTipoExamePrimeira.DataSource = TabelaTipoExame;

            var TabelaExamesMedicosNova = Cadastro.SelecionaModalidadeExame();
            GridExamesMedicosNova.DataSource = TabelaExamesMedicosNova;

            var TabelaTipoExameNova = Cadastro.SelecionaExameMedico();
            GridTipoExameNova.DataSource = TabelaTipoExameNova;
        }

        private void BtnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            var BuscarFuncionario = new PesquisaFuncionario("0");
            BuscarFuncionario.ShowDialog();
            var IdFuncionario = Cadastro.GetFuncionario();
            if (!IdFuncionario.Equals(""))
            {
                var TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(IdFuncionario);
                var TabelaFuncao = Cadastro.RetornaDadosFuncao(TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
                var Riscos = TabelaFuncao.Rows[0]["idrisco"].ToString().Split(';');
                LabelRiscos.Text = "";
                LabelRiscos.Visible = true;
                var TabelaDadosRiscos = new DataTable();
                for (var i = 1; i < Riscos.Length; i++)
                {
                    TabelaDadosRiscos = Cadastro.SelecionaRiscosFuncao(Riscos[i]);
                    LabelRiscos.Text = LabelRiscos.Text + TabelaDadosRiscos.Rows[0][0] + ": " +
                                       TabelaDadosRiscos.Rows[0][1] + "\n";
                }
                LabelFuncionario.Text = "NOME: " + TabelaDadosFuncionario.Rows[0]["nome"] + "     CPF: " +
                                        TabelaDadosFuncionario.Rows[0]["cpf"] + "     FUNÇÃO: " +
                                        TabelaFuncao.Rows[0]["nome"];
            }
        }

        private void BtnGerarAos_Click(object sender, EventArgs e)
        {
            var Apto = "";
            var Resultado = "";
            var IdFuncionario = Cadastro.GetFuncionario();
            var TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(IdFuncionario);
            var TabelaFuncao = Cadastro.RetornaDadosFuncao(TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
            var TabelaSetor = Cadastro.RetornaDadosSetor(TabelaFuncao.Rows[0]["idsetor"].ToString());
            var Empresa = Cadastro.RetornaEmpresa(TabelaSetor.Rows[0]["idempresa"].ToString());
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
            var ModalidadeExames = "";
            for (var i = 0; i < GridExameMedicoPrimeira.Rows.Count; i++)
                try
                {
                    if (Convert.ToBoolean(GridExameMedicoPrimeira.Rows[i].Cells[0].Value.ToString()))
                        ModalidadeExames = ModalidadeExames + ";" + GridExameMedicoPrimeira.Rows[i].Cells[1].Value;
                }
                catch
                {
                }
            var TipoExame = "";
            for (var i = 0; i < GridTipoExamePrimeira.Rows.Count; i++)
                try
                {
                    if (Convert.ToBoolean(GridTipoExamePrimeira.Rows[i].Cells[0].Value.ToString()))
                        TipoExame =  GridTipoExamePrimeira.Rows[i].Cells[1].Value.ToString();
                    i = GridTipoExamePrimeira.Rows.Count;
                }
                catch
                {
                }
            var Sexo = "";
            if (TabelaDadosFuncionario.Rows[0]["sexo"].ToString().Equals("M"))
                Sexo = "MASCULINO";
            else
                Sexo = "FEMININO";
            var ModalidadeExameAos = "";
            for (var i = 0; i < GridExameMedicoPrimeira.Rows.Count; i++)
                try
                {
                    if (Convert.ToBoolean(GridExameMedicoPrimeira.Rows[i].Cells[0].Value.ToString()))
                        ModalidadeExameAos = ModalidadeExameAos + GridExameMedicoPrimeira.Rows[i].Cells[2].Value + "\n";
                }
                catch
                {
                }
            var TipoExameAos = "";
            for (var i = 0; i < GridTipoExamePrimeira.Rows.Count; i++)
                try
                {
                    if (Convert.ToBoolean(GridTipoExamePrimeira.Rows[i].Cells[0].Value.ToString()))
                        TipoExameAos = TipoExameAos + GridTipoExamePrimeira.Rows[i].Cells[2].Value + "\n";
                }
                catch
                {
                }


            Cadastro.CadastraHistorico(IdFuncionario, Apto, ModalidadeExames, TipoExame,
                TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
            var AOS = new Relatorios(TabelaDadosFuncionario.Rows[0]["nome"].ToString(),
                TabelaDadosFuncionario.Rows[0]["idade"].ToString(), Resultado, ModalidadeExameAos, LabelRiscos.Text,
                TipoExameAos, Sexo,
                TabelaDadosFuncionario.Rows[0]["datanascimento"].ToString(),
                TabelaDadosFuncionario.Rows[0]["telefone"].ToString(), TabelaDadosFuncionario.Rows[0]["cpf"].ToString(),
                TabelaDadosFuncionario.Rows[0]["naturalidade"].ToString(),
                Empresa,
                TabelaFuncao.Rows[0]["nome"].ToString(), TabelaDadosFuncionario.Rows[0]["identidade"].ToString());
            AOS.ShowDialog();
        }

        private void BtnSelecionaFuncionarioNova_Click(object sender, EventArgs e)
        {
            var BuscarFuncionario = new PesquisaFuncionario("1");
            BuscarFuncionario.ShowDialog();
            var IdFuncionario = Cadastro.GetFuncionarioNova();
            if (!IdFuncionario.Equals(""))
            {
                var TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(IdFuncionario);
                var TabelaFuncao = Cadastro.RetornaDadosFuncao(TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
                var Riscos = TabelaFuncao.Rows[0]["idrisco"].ToString().Split(';');
                LabelRiscoFuncionario.Text = "";
                LabelRiscoFuncionario.Visible = true;
                var TabelaDadosRiscos = new DataTable();
                for (var i = 1; i < Riscos.Length; i++)
                {
                    TabelaDadosRiscos = Cadastro.SelecionaRiscosFuncao(Riscos[i]);
                    LabelRiscoFuncionario.Text = LabelRiscoFuncionario.Text + TabelaDadosRiscos.Rows[0][0] + ": " +
                                                 TabelaDadosRiscos.Rows[0][1] + "\n";
                }
                LabelFuncionarioNova.Text = "NOME: " + TabelaDadosFuncionario.Rows[0]["nome"] + "     CPF: " +
                                            TabelaDadosFuncionario.Rows[0]["cpf"] + "     FUNÇÃO: " +

                                            TabelaFuncao.Rows[0]["nome"];
            }
        }

        private void BtnGerarAsoNova_Click(object sender, EventArgs e)
        {
            var Apto = "";
            var Resultado = "";
            var IdFuncionario = Cadastro.GetFuncionarioNova();
            var TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(IdFuncionario);
            var TabelaFuncao = Cadastro.RetornaDadosFuncao(TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
            var TabelaSetor = Cadastro.RetornaDadosSetor(TabelaFuncao.Rows[0]["idsetor"].ToString());
            var Empresa = Cadastro.RetornaEmpresa(TabelaSetor.Rows[0]["idempresa"].ToString());
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
            var ModalidadeExames = "";
            for (var i = 0; i < GridExamesMedicosNova.Rows.Count; i++)
                try
                {
                    if (Convert.ToBoolean(GridExamesMedicosNova.Rows[i].Cells[0].Value.ToString()))
                        ModalidadeExames = ModalidadeExames + ";" + GridExamesMedicosNova.Rows[i].Cells[1].Value;
                }
                catch
                {
                }
            var TipoExame = "";
            for (var i = 0; i < GridTipoExameNova.Rows.Count; i++)
                try
                {
                    if (Convert.ToBoolean(GridTipoExameNova.Rows[i].Cells[0].Value.ToString()))
                        TipoExame = GridTipoExamePrimeira.Rows[i].Cells[1].Value.ToString();
                    i = GridTipoExamePrimeira.Rows.Count;
                }
                catch
                {
                }
            var Sexo = "";
            if (TabelaDadosFuncionario.Rows[0]["sexo"].ToString().Equals("M"))
                Sexo = "MASCULINO";
            else
                Sexo = "FEMININO";
            var ModalidadeExameAos = "";
            for (var i = 0; i < GridExamesMedicosNova.Rows.Count; i++)
                try
                {
                    if (Convert.ToBoolean(GridExamesMedicosNova.Rows[i].Cells[0].Value.ToString()))
                        ModalidadeExameAos = ModalidadeExameAos + GridExamesMedicosNova.Rows[i].Cells[2].Value + "\n";
                }
                catch
                {
                }
            var TipoExameAos = "";
            for (var i = 0; i < GridTipoExameNova.Rows.Count; i++)
                try
                {
                    if (Convert.ToBoolean(GridTipoExameNova.Rows[i].Cells[0].Value.ToString()))
                        TipoExameAos = TipoExameAos + GridTipoExameNova.Rows[i].Cells[2].Value + "\n";
                }
                catch
                {
                }


            Cadastro.CadastraHistorico(IdFuncionario, Apto, ModalidadeExames, TipoExame,
                TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
            var AOS = new Relatorios(TabelaDadosFuncionario.Rows[0]["nome"].ToString(),
                TabelaDadosFuncionario.Rows[0]["idade"].ToString(), Resultado, ModalidadeExameAos,
                LabelRiscoFuncionario.Text, TipoExameAos, Sexo,
                TabelaDadosFuncionario.Rows[0]["datanascimento"].ToString(),
                TabelaDadosFuncionario.Rows[0]["telefone"].ToString(), TabelaDadosFuncionario.Rows[0]["cpf"].ToString(),
                TabelaDadosFuncionario.Rows[0]["naturalidade"].ToString(),
                Empresa,
                TabelaFuncao.Rows[0]["nome"].ToString(), TabelaDadosFuncionario.Rows[0]["identidade"].ToString());
            AOS.ShowDialog();
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            var IdFuncionario = Cadastro.GetFuncionarioNova();
            if (!IdFuncionario.Equals(""))
            {
                Historico MostraHistorico = new Historico(IdFuncionario);
                MostraHistorico.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Favor selecionar um funcionário!", "Atenção !", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
            }
        }
    }
}