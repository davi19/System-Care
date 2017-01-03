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
    public partial class BuscarEmpresa : MetroForm
    {
        QuerryMysql Busca = new QuerryMysql();
        public BuscarEmpresa()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            DataTable TabelaResultadoEmpresa = Busca.BuscaEmpresa(TextBusca.Text);
            if (TabelaResultadoEmpresa.Rows.Count == 0)
            {
                MetroMessageBox.Show(this,
                    "Sua busca não encontrou nenhum resultado", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataGridEmpresa.DataSource = TabelaResultadoEmpresa;
            }
        }

        private void TextBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscar_Click(sender,e);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridEmpresa.Rows.Count; i++)
            {
                try
                {
                    if (Convert.ToBoolean(DataGridEmpresa.Rows[i].Cells[0].Value.ToString()))
                    {
                       
                        Busca.SetEmpresa(DataGridEmpresa.Rows[i].Cells[1].Value.ToString());
                        i = DataGridEmpresa.RowCount;
                        this.Hide();
                    }
                }
                catch 
                {

                }
                
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult Certeza = MetroMessageBox.Show(this,
                            "Você tem certeza que deseja excluir as empresas selecionadas", "Certeza ?",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Certeza== DialogResult.OK)
            {
                for (int i = 0; i < DataGridEmpresa.Rows.Count; i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(DataGridEmpresa.Rows[i].Cells[0].Value.ToString()))
                        {


                            Busca.ExcluirEmpresa(DataGridEmpresa.Rows[i].Cells[1].Value.ToString());
                            this.Hide();
                        }
                    }
                    catch
                    {

                    }

                }
                MetroMessageBox.Show(this,
                            "Empresas excluidas com sucesso", "Sucesso !",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
