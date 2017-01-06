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
          
            Text = "System Care V. "+Application.ProductVersion;

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

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios CadastroFuncionario = new Funcionarios();
            CadastroFuncionario.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.ShowDialog();
        }
    }
}
