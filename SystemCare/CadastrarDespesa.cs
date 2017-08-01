using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemCare
{
    public partial class CadastrarDespesa : MetroForm
    {
        public CadastrarDespesa()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (TextNome.Text.Length > 0 && TextValor.Text.Length > 0 && TextData.MaskCompleted)
            {
                QuerryMysql CadastrarDespesa = new QuerryMysql();
                CadastrarDespesa.CadastraDespesa(TextNome.Text, TextValor.Text, TextData.Text);
                TextNome.Text = "";
                TextValor.Text = "";
                TextData.Text = "";
                MetroMessageBox.Show(this, "Despesa cadastrada com sucesso!", "Sucesso !", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, "Favor preencher todos os campos", "Atenção !", MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
            }

        }
    }
}
