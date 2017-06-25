using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Text;

namespace SystemCare
{
    public partial class ExamesAvaliacoes : MetroForm
    {
        private string IdfuncionarioQuestionario;
        private readonly QuerryMysql Cadastro = new QuerryMysql();

        public ExamesAvaliacoes()
        {
            InitializeComponent();

            DataTable ModalidadeExame = Cadastro.SelecionaModalidadeExame();
            DataTable TipoExame = Cadastro.SelecionaExameMedico();

            GridTipoExame.DataSource = TipoExame;
            GridExame.DataSource = ModalidadeExame;



        }
        private void BtnSelecionaFuncionarioNova_Click(object sender, EventArgs e)
        {
            var BuscarFuncionario = new PesquisaFuncionario("1");
            BuscarFuncionario.ShowDialog();

            var IdFuncionario = Cadastro.GetFuncionarioNova();
            IdfuncionarioQuestionario = IdFuncionario;
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
            if (IdFuncionario.Length == 0)
            {
                MetroMessageBox.Show(this, "Favor selecionar um funcionário!", "Atenção !", MessageBoxButtons.OK,
               MessageBoxIcon.Hand);
            }
            else
            {
                var TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(IdFuncionario);
                var TabelaFuncao = Cadastro.RetornaDadosFuncao(TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
                var TabelaSetor = Cadastro.RetornaDadosSetor(TabelaFuncao.Rows[0]["idsetor"].ToString());
                string[] Riscos = TabelaFuncao.Rows[0]["idrisco"].ToString().Split(';');
                string Modalidades = "";
                ArrayList ModalidadeExameAos = new ArrayList();
                ArrayList RiscosAso = new ArrayList();
                for (int i = 1; i < Riscos.Length; i++)
                {
                    if (Riscos[i].Length > 0)
                    {
                        var TabelaRisco = Cadastro.RecuperaDadosRiscos(Riscos[i]);
                        RiscosAso.Add(TabelaRisco.Rows[0]["descricao"].ToString());
                        string[] Modalidade = TabelaRisco.Rows[0]["relacaoexames"].ToString().Split(';');
                        for (int j = 1; j < Modalidade.Length; j++)
                        {
                            if (Modalidade[j].Length > 0)
                            {
                                string Exame = Cadastro.RetornaModalidadeExame(Modalidade[j]);
                                Modalidades = Exame + ";" + Modalidades;
                                ModalidadeExameAos.Add(Exame);
                            }
                        }
                    }
                }
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

                var TipoExame = "";
                for (var i = 0; i < GridTipoExame.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridTipoExame.Rows[i].Cells[0].Value.ToString()))
                            TipoExame = GridTipoExame.Rows[i].Cells[2].Value.ToString();
                        i = GridTipoExame.Rows.Count;
                    }
                    catch
                    {
                    }
                if (TipoExame.Length == 0)
                {
                    MetroMessageBox.Show(this, "Favor selecionar um tipo de exame!", "Atenção !", MessageBoxButtons.OK,
               MessageBoxIcon.Hand);
                }
                else
                {
                    var Sexo = "";
                    if (TabelaDadosFuncionario.Rows[0]["sexo"].ToString().Equals("M"))
                        Sexo = "MASCULINO";
                    else
                        Sexo = "FEMININO";







                    PdfReader reader = new PdfReader("ASO.pdf");
                    reader.SelectPages("1-2"); //Work with only page# 1 & 2
                    using (PdfStamper stamper = new PdfStamper(reader, new FileStream(@"C:\Aso\Teste.pdf", FileMode.Create)))
                    {
                        AcroFields form = stamper.AcroFields;
                        var fieldKeys = form.Fields.Keys;
                        form.SetField("Nome", TabelaDadosFuncionario.Rows[0]["nome"].ToString());
                        form.SetField("Nome2", TabelaDadosFuncionario.Rows[0]["nome"].ToString());
                        form.SetField("Empresa", Empresa);
                        form.SetField("Funcao", TabelaFuncao.Rows[0]["nome"].ToString());
                        form.SetField("Rg", TabelaDadosFuncionario.Rows[0]["identidade"].ToString());
                        form.SetField("Cpf", TabelaDadosFuncionario.Rows[0]["cpf"].ToString());
                        form.SetField("Naturalidade", TabelaDadosFuncionario.Rows[0]["naturalidade"].ToString());
                        form.SetField("Sexo", Sexo);
                        form.SetField("DataNascimento", Convert.ToDateTime(TabelaDadosFuncionario.Rows[0]["datanascimento"].ToString()).ToString("dd/MM/yyyy"));
                        form.SetField("Telefone", TabelaDadosFuncionario.Rows[0]["telefone"].ToString());
                        form.SetField("Idade", TabelaDadosFuncionario.Rows[0]["idade"].ToString());
                        foreach (string fieldKey in fieldKeys)
                        {
                            //Replace Address Form field with my custom data
                            if (fieldKey.ToLower().Contains(TipoExame.ToLower()))
                            {
                                form.SetField(fieldKey, "Sim");
                            }
                        }
                        for (int i = 0; i < ModalidadeExameAos.Count; i++)
                        {
                            string Auxiliar = Cadastro.RemoveAccents(ModalidadeExameAos[i].ToString());
                            foreach (string fieldKey in fieldKeys)
                            {
                                //Replace Address Form field with my custom data
                                if (fieldKey.ToLower().Contains(Auxiliar.ToLower()))
                                {
                                    form.SetField(fieldKey, "Sim");
                                }
                            }
                        }
                        for (int i = 0; i < RiscosAso.Count; i++)
                        {
                            string Auxiliar = Cadastro.RemoveAccents(RiscosAso[i].ToString());
                            foreach (string fieldKey in fieldKeys)
                            {
                                //Replace Address Form field with my custom data
                                if (fieldKey.ToLower().Contains(Auxiliar.ToLower()))
                                {
                                    form.SetField(fieldKey, "Sim");
                                }
                            }
                        }
                        if (RiscosAso.Count > 0)
                        {
                            form.SetField("Sim", "Sim");
                        }
                        else
                        {
                            form.SetField("Não", "Sim");
                        }
                        form.SetField("Resultado", Resultado);
                        form.SetField("Observacao", TextObservacao.Text);
                        form.SetField("Data", DateTime.Now.ToString("dd/MM/yyyy"));

                        for (var i = 0; i < GridExame.Rows.Count; i++)
                        {
                            try
                            {
                                if (Convert.ToBoolean(GridExame.Rows[i].Cells[0].Value.ToString()))
                                {

                                    string Auxiliar = Cadastro.RemoveAccents(GridExame.Rows[i].Cells[2].Value.ToString());
                                    Modalidades = Auxiliar + ";" + Modalidades;
                                    foreach (string fieldKey in fieldKeys)
                                    {
                                        //Replace Address Form field with my custom data
                                        if (fieldKey.ToLower().Contains(Auxiliar.ToLower()))
                                        {
                                            form.SetField(fieldKey, "Sim");
                                        }
                                    }
                                }

                            }
                            catch { }
                        }


                        stamper.FormFlattening = true;
                    }
                    byte[] arquivo = Cadastro.CadastraHistorico(TabelaDadosFuncionario.Rows[0]["id"].ToString(), Apto, Modalidades, TipoExame, TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
                    Relatorios Aso = new Relatorios(arquivo);
                    Aso.ShowDialog();
                }
            }
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            var IdFuncionario = Cadastro.GetFuncionarioNova();
            if (!IdFuncionario.Equals(""))
            {
                var MostraHistorico = new Historico(IdFuncionario);
                MostraHistorico.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Favor selecionar um funcionário!", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
        }

        private void BtnCadastrarAtestado_Click(object sender, EventArgs e)
        {
            var IdFuncionario = Cadastro.GetFuncionarioNova();
            if (!IdFuncionario.Equals(""))
            {
                var CadastrarAtestado = new Atestados(IdFuncionario);
                CadastrarAtestado.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Favor selecionar um funcionário!", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
        }

        private void BtnCadastrarVacina_Click(object sender, EventArgs e)
        {
            var IdFuncionario = Cadastro.GetFuncionarioNova();
            if (!IdFuncionario.Equals(""))
            {
                var CadastrarVacinas = new Vacinas(IdFuncionario);
                CadastrarVacinas.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Favor selecionar um funcionário!", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            string TipoExame = "";
            for (var i = 0; i < GridTipoExame.Rows.Count; i++)
                try
                {
                    if (Convert.ToBoolean(GridTipoExame.Rows[i].Cells[0].Value.ToString()))
                        TipoExame = GridTipoExame.Rows[i].Cells[2].Value.ToString();
                    i = GridTipoExame.Rows.Count;
                }
                catch
                {
                }
            if (TipoExame.Length == 0)
            {
                MetroMessageBox.Show(this, "Favor selecionar um tipo de exame!", "Atenção !", MessageBoxButtons.OK,
           MessageBoxIcon.Hand);
            }
            else if (IdfuncionarioQuestionario.Equals(""))
            {
                MetroMessageBox.Show(this, "Favor selecionar um funcionário!", "Atenção !", MessageBoxButtons.OK,
                   MessageBoxIcon.Hand);
            }

            else
            {
                CheckCalculo Questionario = new CheckCalculo(IdfuncionarioQuestionario, TipoExame);
                Questionario.ShowDialog();
                IdfuncionarioQuestionario = "";
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (IdfuncionarioQuestionario.Equals(""))
            {
                MetroMessageBox.Show(this, "Favor selecionar um funcionário!", "Atenção !", MessageBoxButtons.OK,
                   MessageBoxIcon.Hand);
            }
            else
            {


                string TipoExame = "";
                for (var i = 0; i < GridTipoExame.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridTipoExame.Rows[i].Cells[0].Value.ToString()))
                            TipoExame = GridTipoExame.Rows[i].Cells[1].Value.ToString();
                        i = GridTipoExame.Rows.Count;
                    }
                    catch
                    {
                    }


                var ModalidadeExame = "";
                var DataExame = "";

                for (var i = 0; i < GridExame.Rows.Count; i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(GridExame.Rows[i].Cells[0].Value.ToString()))
                        {
                            ModalidadeExame = ModalidadeExame + GridExame.Rows[i].Cells[2].Value.ToString() + ";";
                            DataExame = DataExame + GridExame.Rows[i].Cells[1].Value.ToString() + ";";


                        }

                    }
                    catch { }
                }
                if (TipoExame.Length == 0)
                {
                    MetroMessageBox.Show(this, "Favor selecionar qual o tipo de exame que será ralizado!", "Atenção !", MessageBoxButtons.OK,
                  MessageBoxIcon.Hand);
                }
                else
                {
                    Cadastro.CadastrarConsulta(IdfuncionarioQuestionario, TipoExame, ModalidadeExame, DataExame);
                    MetroMessageBox.Show(this, "Consulta iniciada com sucesso!", "Sucesso !", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    LabelFuncionarioNova.Text = "Selecione um Funcionário";
                    GridExame.DataSource = null;
                    GridTipoExame = null;
                    DataTable ModalidadesExame = Cadastro.SelecionaModalidadeExame();
                    DataTable TiposExame = Cadastro.SelecionaExameMedico();

                    GridTipoExame.DataSource = TiposExame;
                    GridExame.DataSource = ModalidadesExame;

                }
            }
        }

        private void BtnConsultasAbertas_Click(object sender, EventArgs e)
        {
            Consultas consulta = new Consultas();
            consulta.ShowDialog();
            string IdConsulta = Cadastro.GetIdConsulta();
            DataTable DadosConsulta = Cadastro.RetornaDadosConsulta(IdConsulta);
            var Modalidades = DadosConsulta.Rows[0]["modalidadeexame"].ToString().Split(';');
            var Datas = DadosConsulta.Rows[0]["dataexame"].ToString().Split(';');
           var teste = GridTipoExame.Rows.Count;
            if (Modalidades.Length > 0)
            {

                for (var j = 0; j < Modalidades.Length; j++)
                {
                    for (var i = 0; i < GridExame.Rows.Count; i++)
                    {
                        try
                        {
                            if (GridExame.Rows[i].Cells[2].Value.ToString().Equals(Modalidades[j].ToString()))
                            {
                                GridExame.Rows[i].Cells[0].Value = true;
                                GridExame.Rows[i].Cells[1].Value = Datas[j];


                            }

                        }
                        catch { }
                    }
                }
            }
            var TipoExame = DadosConsulta.Rows[0]["tipoexame"].ToString();
            
            for (var i = 0; i < GridTipoExame.Rows.Count; i++)
            {
              
                if (GridTipoExame.Rows[i].Cells[1].Value.ToString().Equals(TipoExame))
                    GridTipoExame.Rows[i].Cells[0].Value = true;
            }
               
            IdfuncionarioQuestionario = DadosConsulta.Rows[0]["IdFuncionario"].ToString();
            var TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(DadosConsulta.Rows[0]["IdFuncionario"].ToString());
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
}