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
    public partial class Consultas : MetroForm
    {
        QuerryMysql Consulta = new QuerryMysql();
        public Consultas()
        {
            InitializeComponent();
            
           DataTable Consultas= Consulta.RetornaConsulta();
            GridConsultas.DataSource = Consultas;
        }

        private void GridConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var Certeza = MetroMessageBox.Show(this,
               "Você tem certeza que deseja encerrar esta consulta", "Certeza ?",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Certeza == DialogResult.OK)
                {
                    Consulta.EncerrarConsulta(GridConsultas.Rows[e.RowIndex].Cells[2].Value.ToString());
                    MetroMessageBox.Show(this, "Consulta encerrada com sucesso!", "Sucesso !", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                    GridConsultas.DataSource = null;
                    DataTable Consultas = Consulta.RetornaConsulta();
                    GridConsultas.DataSource = Consultas;
                }

            }
            else if (e.ColumnIndex == 1)
            {
                Consulta.SetIdConsulta(GridConsultas.Rows[e.RowIndex].Cells[2].Value.ToString());
                this.Hide();
            }
        }
    }
}
