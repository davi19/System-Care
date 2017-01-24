using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class PesquisaEmpresas : MetroForm
    {
        private readonly QuerryMysql Cadastro = new QuerryMysql();


        public PesquisaEmpresas()
        {
            InitializeComponent();
        }

        private void BtnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            GridEmpresa.DataSource = null;
            var TabelFuncionarios = Cadastro.BuscaEmpresa(TextEmpresaBusca.Text);
            GridEmpresa.DataSource = TabelFuncionarios;
        }

        private void GridFuncionarioEditar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cadastro.SetEmpresaRelatorio(GridEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString());
            Hide();
        }

        private void TextFuncionarioBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnBuscarFuncionario_Click(sender, e);
        }
    }
}