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
    public partial class Atestados : MetroForm
    {
        QuerryMysql CadastraAtestado = new QuerryMysql();
        string Funcionario = "";
        public Atestados(string IdFuncionario)
        {

            InitializeComponent();
            Funcionario = IdFuncionario;
           DataTable TabelaFuncionario= CadastraAtestado.RecuperaDadosFuncionario(IdFuncionario);
            LabelFuncionario.Text = TabelaFuncionario.Rows[0]["nome"].ToString();
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            CadastraAtestado.CadastrarAtestado(Funcionario,DatePickerDataAtestado.Value.ToString("yyyy-MM-dd"),TextCid.Text,TextMotivo.Text,TextDiasAfastado.Text);
            TextCid.Text = "";
            TextDiasAfastado.Text = "";
            TextMotivo.Text = "";
            MetroMessageBox.Show(this, "Atestado cadastrado com sucesso!", "Atenção !", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }
    }
}
