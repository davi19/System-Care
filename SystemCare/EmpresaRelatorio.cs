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
using Microsoft.Reporting.WinForms;

namespace SystemCare
{
    public partial class EmpresaRelatorio : MetroForm
    {
        QuerryMysql Relatorio = new QuerryMysql();
        public EmpresaRelatorio()
        {
            InitializeComponent();
        }

        private void aBSENTEÍSMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var IdEmpresa = Relatorio.GetEmpresaRelatorio();
            if (!IdEmpresa.Equals(""))
            {
                DataTable TabelaAtestado = Relatorio.RetornaAtestados(IdEmpresa, DatePickerMesReferencia.Value.Month.ToString());
                var rds = new ReportDataSource("DataSet1",TabelaAtestado);

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
            var IdEmpresa = Relatorio.GetEmpresaRelatorio();
            if (!IdEmpresa.Equals(""))
            {
            }
            else
            {
                MetroMessageBox.Show(this, "Favor selecionar uma Empresa!", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
        }

        private void vacinaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var IdEmpresa = Relatorio.GetEmpresaRelatorio();
            if (!IdEmpresa.Equals(""))
            {
            }
            else
            {
                MetroMessageBox.Show(this, "Favor selecionar uma Empresa!", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
        }

        private void BtnSelecionaEmpresa_Click(object sender, EventArgs e)
        {
            PesquisaEmpresas BuscaEmpresa = new PesquisaEmpresas();
            BuscaEmpresa.ShowDialog();
            string IdEmnpresa = Relatorio.GetEmpresaRelatorio();
            LabelFuncionarioNova.Text=Relatorio.RetornaEmpresa(IdEmnpresa);
        }

        private void EmpresaRelatorio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
