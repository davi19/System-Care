using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class Atestados : MetroForm
    {
        private readonly QuerryMysql CadastraAtestado = new QuerryMysql();
        private readonly string Funcionario = "";

        public Atestados(string IdFuncionario)
        {
            InitializeComponent();
            Funcionario = IdFuncionario;
            var TabelaFuncionario = CadastraAtestado.RecuperaDadosFuncionario(IdFuncionario);
            LabelFuncionario.Text = TabelaFuncionario.Rows[0]["nome"].ToString();
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            CadastraAtestado.CadastrarAtestado(Funcionario, DatePickerDataAtestado.Value.ToString("yyyy-MM-dd"),
                TextCid.Text, TextMotivo.Text, TextDiasAfastado.Text);
            TextCid.Text = "";
            TextDiasAfastado.Text = "";
            TextMotivo.Text = "";
            MetroMessageBox.Show(this, "Atestado cadastrado com sucesso!", "Atenção !", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}