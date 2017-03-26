using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;

namespace SystemCare
{
    public partial class EmpresaRelatorio : MetroForm
    {
        private readonly QuerryMysql Relatorio = new QuerryMysql();

        public EmpresaRelatorio()
        {
            InitializeComponent();
        }

        private void aBSENTEÍSMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var IdEmpresa = Relatorio.GetEmpresaRelatorio();
            if (!IdEmpresa.Equals(""))
            {
                var TabelaAtestado = Relatorio.RetornaAtestados(IdEmpresa,
                    DatePickerMesReferencia.Value.Month.ToString());
                var rds = new ReportDataSource("DataSet1", TabelaAtestado);

                var rp1 = new ReportParameter("Empresa", LabelFuncionarioNova.Text);
                var rp2 = new ReportParameter("MesReferencia", DatePickerMesReferencia.Value.ToString("MMMM").ToUpper());


                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportPath = "Atestados.rdlc";
                reportViewer1.LocalReport.SetParameters(new[] {rp1, rp2});
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            else
            {
                MetroMessageBox.Show(this, "Favor selecionar uma Empresa!", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
        }

        private void prestaçãoDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var IdEmpresa = Relatorio.GetEmpresaRelatorio();
                        if (!IdEmpresa.Equals(""))
                        {
                            var TabelaFuncionarios = Relatorio.RetornaFuncionariosEmpresa(IdEmpresa);
                            var TabelaHistorico = new DataTable();
                            var TabelaVacinaFinal = new DataTable("TabelaVacina");
            
                            TabelaVacinaFinal.Columns.Add("nomeexame");
                            TabelaVacinaFinal.Columns.Add("valor");
                            TabelaVacinaFinal.Columns.Add("dataexame");
                           TabelaVacinaFinal.Columns.Add("nomefuncionario");
                            TabelaVacinaFinal.Columns.Add("funcao");
            
                            for (int i = 0; i < TabelaFuncionarios.Rows.Count; i++)
                            {
            
                                var IdFuncionario = Relatorio.RetornaIdFuncionario(TabelaFuncionarios.Rows[i][0].ToString());
                                TabelaHistorico = Relatorio.RetornaVacinasFuncionarios(IdFuncionario.Rows[0][0].ToString());
            
                                for (int j = 0; j <= TabelaHistorico.Rows.Count; j++)
                                {
                                    if (j == TabelaHistorico.Rows.Count)
                                    {
                                        DataRow dr4 = TabelaVacinaFinal.NewRow();
                                        dr4["nome"] = "";
                                        dr4["dose"] = "";
                                        dr4["dataaplicacao"] = "";
                                        dr4["reforco"] = "";
                                        dr4["nomefuncionario"] = "";
                                        dr4["funcao"] = "";
                                        TabelaVacinaFinal.Rows.Add(dr4);
                                        j = TabelaHistorico.Rows.Count + 5;
                                    }
                                    else
                                    {
                                        DataRow dr3 = TabelaVacinaFinal.NewRow();
                                        if (j == 0)
                                        {
                                            dr3["nomefuncionario"] = TabelaFuncionarios.Rows[i][0].ToString();
                                            dr3["funcao"] = TabelaFuncionarios.Rows[i][1].ToString();
            
                                        }
                                        else
                                        {
                                            dr3["nomefuncionario"] = "";
                                            dr3["funcao"] = "";
                                        }
                                        dr3["nome"] = TabelaVacina.Rows[j][0].ToString();
                                        dr3["dose"] = TabelaVacina.Rows[j][1].ToString();
                                        dr3["dataaplicacao"] = TabelaVacina.Rows[j][3].ToString();
                                        dr3["reforco"] = TabelaVacina.Rows[j][2].ToString();
                                        TabelaVacinaFinal.Rows.Add(dr3);
                                    }
                                }
            
            
                            }
            
            
                            var rds2 = new ReportDataSource("DataSet1", TabelaVacinaFinal);
            
                            var rp1 = new ReportParameter("Empresa", LabelFuncionarioNova.Text);
                            var rp2 = new ReportParameter("MesReferencia", DatePickerMesReferencia.Value.ToString("MMMM").ToUpper());
            
            
                            reportViewer1.LocalReport.DataSources.Clear();
                            reportViewer1.LocalReport.ReportPath = "Vacinas.rdlc";
                            reportViewer1.LocalReport.SetParameters(new[] { rp1, rp2 });
                            reportViewer1.LocalReport.DataSources.Add(rds2);
                            reportViewer1.LocalReport.Refresh();
                            reportViewer1.RefreshReport();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Favor selecionar uma Empresa!", "Atenção !", MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
                        }*/
        }

        private void vacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var IdEmpresa = Relatorio.GetEmpresaRelatorio();
            if (!IdEmpresa.Equals(""))
            {
                var TabelaFuncionarios = Relatorio.RetornaFuncionariosEmpresa(IdEmpresa);
                var TabelaVacina = new DataTable();
                var TabelaVacinaFinal = new DataTable("TabelaVacina");
                TabelaVacinaFinal.Columns.Add("nome");
                TabelaVacinaFinal.Columns.Add("dose");
                TabelaVacinaFinal.Columns.Add("dataaplicacao");
                TabelaVacinaFinal.Columns.Add("reforco");
                TabelaVacinaFinal.Columns.Add("nomefuncionario");
                TabelaVacinaFinal.Columns.Add("funcao");

                for (var i = 0; i < TabelaFuncionarios.Rows.Count; i++)
                {
                    var IdFuncionario = Relatorio.RetornaIdFuncionario(TabelaFuncionarios.Rows[i][0].ToString());
                    TabelaVacina = Relatorio.RetornaVacinasFuncionarios(IdFuncionario.Rows[0][0].ToString());

                    for (var j = 0; j <= TabelaVacina.Rows.Count; j++)
                        if (j == TabelaVacina.Rows.Count)
                        {
                            var dr4 = TabelaVacinaFinal.NewRow();
                            dr4["nome"] = "";
                            dr4["dose"] = "";
                            dr4["dataaplicacao"] = "";
                            dr4["reforco"] = "";
                            dr4["nomefuncionario"] = "";
                            dr4["funcao"] = "";
                            TabelaVacinaFinal.Rows.Add(dr4);
                            j = TabelaVacina.Rows.Count + 5;
                        }
                        else
                        {
                            var dr3 = TabelaVacinaFinal.NewRow();
                            if (j == 0)
                            {
                                dr3["nomefuncionario"] = TabelaFuncionarios.Rows[i][0].ToString();
                                dr3["funcao"] = TabelaFuncionarios.Rows[i][1].ToString();
                            }
                            else
                            {
                                dr3["nomefuncionario"] = "";
                                dr3["funcao"] = "";
                            }
                            dr3["nome"] = TabelaVacina.Rows[j][0].ToString();
                            dr3["dose"] = TabelaVacina.Rows[j][1].ToString();
                            dr3["dataaplicacao"] = TabelaVacina.Rows[j][3].ToString();
                            dr3["reforco"] = TabelaVacina.Rows[j][2].ToString();
                            TabelaVacinaFinal.Rows.Add(dr3);
                        }
                }


                var rds2 = new ReportDataSource("DataSet1", TabelaVacinaFinal);

                var rp1 = new ReportParameter("Empresa", LabelFuncionarioNova.Text);
                var rp2 = new ReportParameter("MesReferencia", DatePickerMesReferencia.Value.ToString("MMMM").ToUpper());


                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportPath = "Vacinas.rdlc";
                reportViewer1.LocalReport.SetParameters(new[] {rp1, rp2});
                reportViewer1.LocalReport.DataSources.Add(rds2);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            else
            {
                MetroMessageBox.Show(this, "Favor selecionar uma Empresa!", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
        }

        private void BtnSelecionaEmpresa_Click(object sender, EventArgs e)
        {
            var BuscaEmpresa = new PesquisaEmpresas();
            BuscaEmpresa.ShowDialog();
            var IdEmnpresa = Relatorio.GetEmpresaRelatorio();
            LabelFuncionarioNova.Text = Relatorio.RetornaEmpresa(IdEmnpresa);
        }

        private void EmpresaRelatorio_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }
    }
}