using System;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;

namespace SystemCare
{
    public partial class Relatorios : MetroForm
    {
        public Relatorios(string Nome, string Idade, string Resultado, string ModalidadeExame, string RiscosOperacionais,
            string ExameMedico, string Sexo, string DataNascimento, string Telefone, string Cpf, string Naturalidade,
            string Empresa, string Funcao, string Rg)
        {
            InitializeComponent();
            var rds = new ReportDataSource();

            var rp1 = new ReportParameter("Nome", Nome);
            var rp2 = new ReportParameter("Idade", Idade);
            var rp3 = new ReportParameter("Empresa", Empresa);
            var rp4 = new ReportParameter("Funcao", Funcao);
            var rp5 = new ReportParameter("Rg", Rg);
            var rp6 = new ReportParameter("Naturalidade", Naturalidade);
            var rp7 = new ReportParameter("Cpf", Cpf);
            var rp8 = new ReportParameter("Telefone", Telefone);
            var rp9 = new ReportParameter("DataNascimento", DataNascimento);
            var rp10 = new ReportParameter("Sexo", Sexo);
            var rp11 = new ReportParameter("ExameMedico", ExameMedico);
            var rp12 = new ReportParameter("RiscosOperacionais", RiscosOperacionais);
            var rp13 = new ReportParameter("ModalidadeExames", ModalidadeExame);
            var rp14 = new ReportParameter("Resultado", Resultado);
            var rp15 = new ReportParameter("Data", DateTime.Now.Date.ToShortDateString());


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = "ASO.rdlc";
            reportViewer1.LocalReport.SetParameters(new[]
                {rp1, rp2, rp3, rp4, rp5, rp6, rp7, rp8, rp9, rp10, rp11, rp12, rp13, rp14, rp15});
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }
    }
}