using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class PesquisaFuncionario : MetroForm
    {
        private readonly QuerryMysql Cadastro = new QuerryMysql();
        private readonly string TipoFuncionario = "";

        public PesquisaFuncionario(string Tipo)
        {
            TipoFuncionario = Tipo;
            InitializeComponent();
        }

        private void BtnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            GridFuncionarioEditar.DataSource = null;
            var TabelFuncionarios = Cadastro.BuscaFuncionario(TextFuncionarioBusca.Text);
            GridFuncionarioEditar.DataSource = TabelFuncionarios;
        }

        private void GridFuncionarioEditar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TipoFuncionario.Equals("0"))
            {
                Cadastro.SetFuncionario(GridFuncionarioEditar.Rows[e.RowIndex].Cells[0].Value.ToString());
                Hide();
            }
            else
            {
                Cadastro.SetFuncionarioNova(GridFuncionarioEditar.Rows[e.RowIndex].Cells[0].Value.ToString());
                Hide();
            }
        }

        private void TextFuncionarioBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnBuscarFuncionario_Click(sender, e);
        }
    }
}