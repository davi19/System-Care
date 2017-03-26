using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class Historico : MetroForm
    {
        private readonly QuerryMysql VizualizaHistorico = new QuerryMysql();

        public Historico(string IdFuncionario)
        {
            InitializeComponent();
            var TabelaHiostorico = VizualizaHistorico.SelecionaHistoricoFuncionario(IdFuncionario);
            GridHistorico.DataSource = TabelaHiostorico;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < GridHistorico.RowCount; i++)
                VizualizaHistorico.AtualizaHistoricoFuncionario(GridHistorico.Rows[i].Cells[1].Value.ToString(),
                    GridHistorico.Rows[i].Cells[5].Value.ToString());
            MetroMessageBox.Show(this, "Dados atualizados com sucesso!", "Sucesso !",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void GridHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var Apto = "";
                var Resultado = "";
                var TabelaAso =
                    VizualizaHistorico.RetornaAsoHistorico(GridHistorico.Rows[e.RowIndex].Cells[1].Value.ToString());

                var TabelaDadosFuncionario =
                    VizualizaHistorico.RecuperaDadosFuncionario(TabelaAso.Rows[0]["idfuncionario"].ToString());

                var TabelaFuncao = VizualizaHistorico.RetornaDadosFuncao(TabelaAso.Rows[0]["idfuncao"].ToString());
                var Riscos = TabelaFuncao.Rows[0]["idrisco"].ToString().Split(';');
                var RiscosAso = "";
                var TabelaDadosRiscos = new DataTable();
                for (var i = 1; i < Riscos.Length; i++)
                {
                    TabelaDadosRiscos = VizualizaHistorico.SelecionaRiscosFuncao(Riscos[i]);
                    RiscosAso = RiscosAso + TabelaDadosRiscos.Rows[0][0] + ": " +
                                TabelaDadosRiscos.Rows[0][1] + "\n";
                }
                var TabelaSetor = VizualizaHistorico.RetornaDadosSetor(TabelaFuncao.Rows[0]["idsetor"].ToString());
                var Empresa = VizualizaHistorico.RetornaEmpresa(TabelaSetor.Rows[0]["idempresa"].ToString());
                if (GridHistorico.Rows[e.RowIndex].Cells[5].Value.ToString().Equals("S"))
                {
                    Apto = "S";
                    Resultado = "APTO";
                }
                else
                {
                    Apto = "N";
                    Resultado = "NÃO APTO";
                }

                var TipoExameAos = "";


                TipoExameAos = VizualizaHistorico.RetornaTipoExame(TabelaAso.Rows[0]["tipoexame"].ToString());

                var Sexo = "";
                if (TabelaDadosFuncionario.Rows[0]["sexo"].ToString().Equals("M"))
                    Sexo = "MASCULINO";
                else
                    Sexo = "FEMININO";

                var ModalidadeExameAos = "";
                var ModalidadeExames = TabelaAso.Rows[0]["modalidadeexame"].ToString().Split(';');

                for (var i = 1; i < ModalidadeExames.Length; i++)
                    try
                    {
                        ModalidadeExameAos = ModalidadeExameAos +
                                             VizualizaHistorico.RetornaModalidadeExame(ModalidadeExames[i]) + "\n";
                    }
                    catch
                    {
                    }

                var AOS = new Relatorios(TabelaDadosFuncionario.Rows[0]["nome"].ToString(),
                    TabelaDadosFuncionario.Rows[0]["idade"].ToString(), Resultado, ModalidadeExameAos, RiscosAso,
                    TipoExameAos, Sexo,
                    Convert.ToDateTime(TabelaDadosFuncionario.Rows[0]["datanascimento"].ToString())
                        .Date.ToShortDateString(),
                    TabelaDadosFuncionario.Rows[0]["telefone"].ToString(),
                    TabelaDadosFuncionario.Rows[0]["cpf"].ToString(),
                    TabelaDadosFuncionario.Rows[0]["naturalidade"].ToString(),
                    Empresa,
                    TabelaFuncao.Rows[0]["nome"].ToString(), TabelaDadosFuncionario.Rows[0]["identidade"].ToString());
                AOS.ShowDialog();
            }
        }
    }
}