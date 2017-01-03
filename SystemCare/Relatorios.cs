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

namespace SystemCare
{
    public partial class Relatorios : MetroForm
    {
        public Relatorios(string Nome, string Idade, string Resultado ,string ModalidadeExame, string RiscosOperacionais, string ExameMedico, string Sexo, string DataNascimento,string Telefone, string Cpf, string Naturalidade, string Empresa, string Funcao, string Rg)
        {
            InitializeComponent();
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();

            Microsoft.Reporting.WinForms.ReportParameter rp1 = new Microsoft.Reporting.WinForms.ReportParameter("Nome", Nome);
            Microsoft.Reporting.WinForms.ReportParameter rp2 = new Microsoft.Reporting.WinForms.ReportParameter("Idade",Idade );
            Microsoft.Reporting.WinForms.ReportParameter rp3 = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", Empresa);
            Microsoft.Reporting.WinForms.ReportParameter rp4 = new Microsoft.Reporting.WinForms.ReportParameter("Funcao", Funcao);
            Microsoft.Reporting.WinForms.ReportParameter rp5 = new Microsoft.Reporting.WinForms.ReportParameter("Rg", Rg);
            Microsoft.Reporting.WinForms.ReportParameter rp6 = new Microsoft.Reporting.WinForms.ReportParameter("Naturalidade", Naturalidade);
            Microsoft.Reporting.WinForms.ReportParameter rp7 = new Microsoft.Reporting.WinForms.ReportParameter("Cpf", Cpf);
            Microsoft.Reporting.WinForms.ReportParameter rp8 = new Microsoft.Reporting.WinForms.ReportParameter("Telefone", Telefone);
            Microsoft.Reporting.WinForms.ReportParameter rp9 = new Microsoft.Reporting.WinForms.ReportParameter("DataNascimento", DataNascimento);
            Microsoft.Reporting.WinForms.ReportParameter rp10 = new Microsoft.Reporting.WinForms.ReportParameter("Sexo", Sexo);
            Microsoft.Reporting.WinForms.ReportParameter rp11 = new Microsoft.Reporting.WinForms.ReportParameter("ExameMedico", ExameMedico);
            Microsoft.Reporting.WinForms.ReportParameter rp12 = new Microsoft.Reporting.WinForms.ReportParameter("RiscosOperacionais", RiscosOperacionais);
            Microsoft.Reporting.WinForms.ReportParameter rp13 = new Microsoft.Reporting.WinForms.ReportParameter("ModalidadeExames", ModalidadeExame);
            Microsoft.Reporting.WinForms.ReportParameter rp14 = new Microsoft.Reporting.WinForms.ReportParameter("Resultado", Resultado);
            Microsoft.Reporting.WinForms.ReportParameter rp15 = new Microsoft.Reporting.WinForms.ReportParameter("Data", DateTime.Now.Date.ToShortDateString().ToString());


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = "ASO.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { rp1, rp2, rp3, rp4, rp5, rp6, rp7, rp8, rp9, rp10, rp11, rp12, rp13, rp14, rp15 });
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
