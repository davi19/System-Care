using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Collections;
using iTextSharp.text.pdf;
using System.IO;

namespace SystemCare
{
    public partial class Historico : MetroForm
    {
        private readonly QuerryMysql Cadastro = new QuerryMysql();

        public Historico(string IdFuncionario)
        {
            InitializeComponent();
            var TabelaHiostorico = Cadastro.SelecionaHistoricoFuncionario(IdFuncionario);
            GridHistorico.DataSource = TabelaHiostorico;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < GridHistorico.RowCount; i++)
                Cadastro.AtualizaHistoricoFuncionario(GridHistorico.Rows[i].Cells[1].Value.ToString(),
                    GridHistorico.Rows[i].Cells[6].Value.ToString());
            MetroMessageBox.Show(this, "Dados atualizados com sucesso!", "Sucesso !",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void GridHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var Apto = "";
                var Resultado = "";
                var IdFuncionario = Cadastro.GetFuncionarioNova();
                var TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(IdFuncionario);
                var IdFuncao = Cadastro.SelecionaFuncaoHistorico(GridHistorico.Rows[e.RowIndex].Cells[1].Value.ToString());
                var TabelaFuncao = Cadastro.RetornaDadosFuncao(IdFuncao);
                var TabelaSetor = Cadastro.RetornaDadosSetor(TabelaFuncao.Rows[0]["idsetor"].ToString());

                string[] Riscos = TabelaFuncao.Rows[0]["idrisco"].ToString().Split(';');

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
                                ModalidadeExameAos.Add(Exame);
                            }
                        }
                    }
                }
               var Empresa = Cadastro.RetornaEmpresa(TabelaSetor.Rows[0]["idempresa"].ToString());
                if (GridHistorico.Rows[e.RowIndex].Cells[6].Value.Equals("S"))
                {
                    Apto = "S";
                    Resultado = "APTO";
                }
                else
                {
                    Apto = "N";
                    Resultado = "NÃO APTO";
                }

                var TipoExame = GridHistorico.Rows[e.RowIndex].Cells[3].Value.ToString();                
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
                    form.SetField("Observacao", GridHistorico.Rows[e.RowIndex].Cells[5].Value.ToString());
                    form.SetField("Data", DateTime.Now.ToString("dd/MM/yyyy"));
                    var Modalidade = Cadastro.SelecionaModalidadeHistorico(GridHistorico.Rows[e.RowIndex].Cells[1].Value.ToString());
                    string[] Modalidades = Modalidade.Split(';');
                    for (var i = 0; i < Modalidades.Length; i++)
                    {
                        if (Modalidades[i].ToString().Length > 0)
                        {
                            foreach (string fieldKey in fieldKeys)
                            {
                                //Replace Address Form field with my custom data
                                if (fieldKey.ToLower().Contains(Modalidades[i].ToString().ToLower()))
                                {
                                    form.SetField(fieldKey, "Sim");
                                }
                            }
                        }

                        
                    }


                    stamper.FormFlattening = true;
                }
                byte[] arquivo = Cadastro.AtualizaHistorico(GridHistorico.Rows[e.RowIndex].Cells[1].Value.ToString());
               Relatorios Aso = new Relatorios(arquivo);
               Aso.ShowDialog();

            }
        }
    }
}