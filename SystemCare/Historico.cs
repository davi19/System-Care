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
    public partial class Historico : MetroForm
    {
        QuerryMysql VizualisaHistorico = new QuerryMysql();
        public Historico(string IdFuncionario)
        {
            InitializeComponent();
            DataTable TabelaHiostorico = VizualisaHistorico.SelecionaHistoricoFuncionario(IdFuncionario);
            GridHistorico.DataSource = TabelaHiostorico;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridHistorico.RowCount; i++)
            {
                VizualisaHistorico.AtualizaHistoricoFuncionario(GridHistorico.Rows[i].Cells[1].Value.ToString(),
                    GridHistorico.Rows[i].Cells[5].Value.ToString());
            }
            MetroMessageBox.Show(this, "Dados atualizados com sucesso!", "Sucesso !",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }
    }
}
