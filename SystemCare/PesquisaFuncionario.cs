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
    public partial class PesquisaFuncionario : MetroForm
    {
        QuerryMysql Cadastro = new QuerryMysql();
        private string TipoFuncionario = "";
        public PesquisaFuncionario(string Tipo)
        {
            TipoFuncionario = Tipo;
            InitializeComponent();
        }

        private void BtnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            GridFuncionarioEditar.DataSource = null;
            DataTable TabelFuncionarios = Cadastro.BuscaFuncionario(TextFuncionarioBusca.Text);
            GridFuncionarioEditar.DataSource = TabelFuncionarios;
        }

        private void GridFuncionarioEditar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TipoFuncionario.Equals("0"))
            {
                Cadastro.SetFuncionario(GridFuncionarioEditar.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Hide();
            }
            else
            {
                Cadastro.SetFuncionarioNova(GridFuncionarioEditar.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Hide();
            }

        }

        private void TextFuncionarioBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscarFuncionario_Click(sender,e);
            }
        }
    }
}
