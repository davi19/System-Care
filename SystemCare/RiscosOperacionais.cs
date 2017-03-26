using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class RiscosOperacionais : MetroForm
    {
        private static string IdRisco = "";
        private readonly QuerryMysql CadastrarRiscos = new QuerryMysql();

        public RiscosOperacionais()
        {
            InitializeComponent();
            var TabelaGrupo = CadastrarRiscos.RetornaGrupoRisco();
            ComboGrupoRisco.DataSource = TabelaGrupo;
            ComboGrupoRisco.DisplayMember = "descricao";
            ComboGrupoRisco.ValueMember = "id";

            var TabelaGrupoEditar = CadastrarRiscos.RetornaGrupoRisco();
            ComboGrupoEditar.DataSource = TabelaGrupoEditar;
            ComboGrupoEditar.DisplayMember = "descricao";
            ComboGrupoEditar.ValueMember = "id";

            var TabelaExames = CadastrarRiscos.RetornaTodaModalidadeExame();
            GridExames.DataSource = TabelaExames;

            var TabelaExamesEditar = CadastrarRiscos.RetornaTodaModalidadeExame();
            GridExamesEditar.DataSource = TabelaExames;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TextDescricao.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Favor preencher todos os campos do formulário!", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                var RelacaoExames = ";";

                for (var i = 0; i < GridExames.RowCount; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridExames.Rows[i].Cells[0].Value.ToString()))
                            RelacaoExames = RelacaoExames + GridExames.Rows[i].Cells[1].Value + ";";
                    }
                    catch
                    {
                    }
                CadastrarRiscos.CadastraRisco(TextDescricao.Text, ComboGrupoRisco.SelectedValue.ToString(),
                    RelacaoExames);
                TextDescricao.Text = "";
                GridExames.DataSource = null;
                var TabelaExames = CadastrarRiscos.RetornaTodaModalidadeExame();
                GridExames.DataSource = TabelaExames;
                MetroMessageBox.Show(this, "Risco cadastrado com sucesso!", "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var TabelaResultadoBusca = CadastrarRiscos.RetornaRisco(TextBuscar.Text);
            GridRiscos.DataSource = TabelaResultadoBusca;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (BtnEditar.Text.Equals("Editar"))
            {
                metroLabel3.Visible = true;
                metroLabel3.Visible = true;
                TextDescricaoEditar.Visible = true;
                ComboGrupoEditar.Visible = true;
                BtnExcluir.Visible = true;

                for (var i = 0; i < GridRiscos.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridRiscos.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdRisco = GridRiscos.Rows[i].Cells[1].Value.ToString();
                            TextDescricaoEditar.Text = GridRiscos.Rows[i].Cells[2].Value.ToString();
                            i = GridRiscos.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                var TabelaIdGrupo = CadastrarRiscos.RetornaGrupoRiscoEditar(IdRisco);
                var TabelaExames = CadastrarRiscos.RetornaRelacaoExamesEditar(IdRisco);
                var Exames = TabelaExames.Split(';');
                for (var j = 0; j < GridExamesEditar.RowCount; j++)
                for (var k = 0; k < Exames.Length; k++)
                    if (GridExamesEditar.Rows[j].Cells[1].Value.ToString().Equals(Exames[k]))
                    {
                        GridExamesEditar.Rows[j].Cells[0].Value = true;
                        k = Exames.Length;
                    }
                ComboGrupoEditar.SelectedValue = TabelaIdGrupo.Rows[0][0].ToString();
                BtnEditar.Text = "Salvar";
            }
            else
            {
                var RelacaoExames = ";";

                for (var i = 0; i < GridExames.RowCount; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridExamesEditar.Rows[i].Cells[0].Value.ToString()))
                            RelacaoExames = RelacaoExames + GridExamesEditar.Rows[i].Cells[1].Value + ";";
                    }
                    catch
                    {
                    }


                CadastrarRiscos.AtualizaRisco(TextDescricaoEditar.Text, ComboGrupoEditar.SelectedValue.ToString(),
                    IdRisco, RelacaoExames);
                MetroMessageBox.Show(this,
                    "Dados salvos com sucesso !", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextDescricaoEditar.Text = "";
                TextBuscar.Text = "";
                GridRiscos.DataSource = null;
                BtnEditar.Text = "Editar";
                metroLabel3.Visible = false;
                metroLabel4.Visible = false;
                TextDescricaoEditar.Visible = false;
                ComboGrupoEditar.Visible = false;
                BtnExcluir.Visible = false;
                GridExamesEditar.DataSource = null;
                var TabelaExames = CadastrarRiscos.RetornaTodaModalidadeExame();
                GridExamesEditar.DataSource = TabelaExames;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var Certeza = MetroMessageBox.Show(this,
                "Você tem certeza que deseja excluir o usuário selecionado ?", "Certeza ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Certeza == DialogResult.OK)
            {
                var IdRisco = "";
                for (var i = 0; i < GridRiscos.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridRiscos.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdRisco = GridRiscos.Rows[i].Cells[1].Value.ToString();
                            i = GridRiscos.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                CadastrarRiscos.ExcluirRisco(IdRisco);
                MetroMessageBox.Show(this,
                    "Usuário excluido com sucesso !", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextDescricaoEditar.Text = "";
                TextBuscar.Text = "";
                GridRiscos.DataSource = null;
                BtnEditar.Text = "Editar";
                metroLabel3.Visible = false;
                metroLabel4.Visible = false;
                TextDescricaoEditar.Visible = false;
                ComboGrupoEditar.Visible = false;
                BtnExcluir.Visible = false;
            }
        }
    }
}