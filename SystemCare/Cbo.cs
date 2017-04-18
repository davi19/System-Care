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
    public partial class Cbo : MetroForm
    {
        string IdCbo = "";
        QuerryMysql Cadastro = new QuerryMysql();
        public Cbo()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TextCodigo.Text.Length == 0)
            {
                MetroMessageBox.Show(this,
               "Favor preencher o codigo da CBO", "Atenção !",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TextDescricao.Text.Length == 0)
            {
                MetroMessageBox.Show(this,
               "Favor preencher a descrição da CBO!", "Atenção !",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cadastro.CadastrarCbo(TextCodigo.Text+" "+TextDescricao.Text);
                TextCodigo.Text = "";
                TextDescricao.Text = "";
                MetroMessageBox.Show(this,
              "CBO cadastrada com sucesso!", "Sucesso !",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBuscarCbo_Click(object sender, EventArgs e)
        {
            DataTable TabelaResultado = Cadastro.BuscaCbo(TextBusca.Text);
            GridSelecionaCbo.DataSource = TabelaResultado;

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            
            if (BtnEditar.Text.Equals("Editar"))
            {
                IdCbo = "";
                for (var i = 0; i < GridSelecionaCbo.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridSelecionaCbo.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdCbo = GridSelecionaCbo.Rows[i].Cells[1].Value.ToString();
                            TextEditarCbo.Text= GridSelecionaCbo.Rows[i].Cells[2].Value.ToString();
                            BtnEditar.Text = "Salvar";
                            i = GridSelecionaCbo.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                if (IdCbo.Equals(""))
                {
                    MetroMessageBox.Show(this,
                        "Nenhuma CBO selecionada", "Certeza ?",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
               
            }

            else
            {
                
               
                Cadastro.AtualizaCbo(TextEditarCbo.Text,IdCbo);
                TextEditarCbo.Text = "";
                GridSelecionaCbo.DataSource = null;
             MetroMessageBox.Show(this,
                    "Dados atualizados com sucesso!", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
