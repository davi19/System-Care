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
    public partial class SelecionarExames : MetroForm
    {
        QuerryMysql Cadastro = new QuerryMysql();
        public SelecionarExames(string IdEmpresa)
        {
            
            InitializeComponent();


            DataTable ModalidadeExame = Cadastro.SelecionaExameMedico();
            DataTable Funcoes = Cadastro.RetornaRelacaoFuncaoEmpresa(IdEmpresa);

            GridFuncoes.DataSource = Funcoes;
            GridExame.DataSource = ModalidadeExame;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            for (int i =0; i< GridFuncoes.RowCount;i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridFuncoes.Rows[i].Cells[0].Value))
                    {
                        Cadastro.SetFuncaoRelatorio(GridFuncoes.Rows[i].Cells[1].Value.ToString());
                        i = GridFuncoes.RowCount;
                    }
                }
                catch
                {

                }
            }

            for (int i = 0; i < GridExame.RowCount; i++)
            {
                try
                {
                    if (Convert.ToBoolean(GridExame.Rows[i].Cells[0].Value))
                    {
                        Cadastro.SetExameRelatorio(GridExame.Rows[i].Cells[2].Value.ToString());
                        i = GridExame.RowCount;
                    }
                }
                catch
                {

                }
            }
            this.Hide();
        }
    }
}
