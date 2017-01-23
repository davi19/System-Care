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
    }
}
