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
    public partial class Vacinas : MetroForm
    {
        QuerryMysql CadastraVacina = new QuerryMysql();
        string Funcionario = "";
        public Vacinas(string IdFuncionario)
        {
            InitializeComponent();
            Funcionario = IdFuncionario;
            DataTable TabelaFuncionario = CadastraVacina.RecuperaDadosFuncionario(IdFuncionario);
            LabelFuncionario.Text = TabelaFuncionario.Rows[0]["nome"].ToString();
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            string Reforco = "";
            if (CheckReforco.Checked)
            {
                Reforco = "S";
            }
            else
            {
                Reforco = "N";
            }
            CadastraVacina.CadastrarVacina(Funcionario,DatePickerDataAplicacao.Value.ToString("yyyy-MM-dd"),TextNomeVacina.Text,Reforco,TextDose.Text);
            TextDose.ResetText();
            TextNomeVacina.ResetText();
            DatePickerDataAplicacao.ResetText();
            MetroMessageBox.Show(this, "Vacina cadastrada com sucesso!", "Atenção !", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }
    }
}
