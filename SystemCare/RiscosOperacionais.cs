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
    public partial class RiscosOperacionais : MetroForm
    {
        QuerryMysql CadastrarRiscos = new QuerryMysql();
        static string IdRisco = "";
        public RiscosOperacionais()
        {
            InitializeComponent();
            DataTable TabelaGrupo =CadastrarRiscos.RetornaGrupoRisco();
            ComboGrupoRisco.DataSource = TabelaGrupo;
            ComboGrupoRisco.DisplayMember = "descricao";
            ComboGrupoRisco.ValueMember = "id";

            DataTable TabelaGrupoEditar = CadastrarRiscos.RetornaGrupoRisco();
            ComboGrupoEditar.DataSource = TabelaGrupoEditar;
            ComboGrupoEditar.DisplayMember = "descricao";
            ComboGrupoEditar.ValueMember = "id";
          
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
                CadastrarRiscos.CadastraRisco(TextDescricao.Text, ComboGrupoRisco.SelectedValue.ToString());
                TextDescricao.Text = "";
                MetroMessageBox.Show(this, "Risco cadastrado com sucesso!", "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable TabelaResultadoBusca = CadastrarRiscos.RetornaRisco(TextBuscar.Text);
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
                DataTable TabelaIdGrupo = CadastrarRiscos.RetornaGrupoRiscoEditar(IdRisco);
                ComboGrupoEditar.SelectedValue = TabelaIdGrupo.Rows[0][0].ToString();
                BtnEditar.Text = "Salvar";

            }
            else
            {

                CadastrarRiscos.AtualizaRisco(TextDescricaoEditar.Text, ComboGrupoEditar.SelectedValue.ToString(), IdRisco);
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
