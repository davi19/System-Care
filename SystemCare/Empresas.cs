using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class Empresas : MetroForm
    {
        private readonly QuerryMysql Cadastro = new QuerryMysql();

        public Empresas()
        {
            InitializeComponent();
            DataTable TabelaServicos = Cadastro.RetornaServicosPrestados();
            GridServicosPrestados.DataSource = TabelaServicos;

            DataTable TabelaServicosEditar = Cadastro.RetornaServicosPrestados();
            GridServicosEditar.DataSource = TabelaServicos;


        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                e.Handled = true;
        }

        private void DataViewCnae_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LabelCnae.Text = "CNAE | " + DataViewCnae.Rows[e.RowIndex].Cells[0].Value + " | " +
                             DataViewCnae.Rows[e.RowIndex].Cells[1].Value;
            LabelCnae.UseStyleColors = true;
            LabelCnae.FontWeight = MetroLabelWeight.Bold;
            LabelCnae.AutoSize = true;
            TextBuscaCnae.Text = "";
            DataViewCnae.DataSource = null;
            DataViewCnae.Visible = false;
        }

        private void TextBuscaCnae_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnBuscaCnae_Click_1(sender, e);
        }


        private void TextQuantidadeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                e.Handled = true;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TextNome.Text.Length == 0 || TextCnpj.Text.Length == 0 || TextQuantidadeFuncionario.Text.Length == 0 ||
                TextEndereco.Text.Length == 0 || TextTelefone.Text.Length == 0 || TextRisco.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Favor preencher todos os campos!", "Atenção !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                string Servicos = "";
                for (int i = 0; i<GridServicosPrestados.RowCount; i++)
                {
                    if (Convert.ToBoolean(GridServicosPrestados.Rows[i].Cells[0].Value))
                    {
                        Servicos = Servicos + ";" + GridServicosPrestados.Rows[i].Cells[1].Value.ToString();
                    }
                   
                }
                var Cnae = LabelCnae.Text.Split('|');
                Cadastro.CadastraEmpresa(TextNome.Text, TextEndereco.Text, TextCnpj.Text,
                    Convert.ToInt32(TextQuantidadeFuncionario.Text), TextTelefone.Text, TextEmail.Text,
                    Cnae[1] + " | " + Cnae[2],
                    Convert.ToInt32(TextRisco.Text),Servicos);
                MetroMessageBox.Show(this, "Empresa cadastrada com sucesso!", "Sucesso !", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                TextNome.Text = "";
                TextCnpj.Text = "";
                TextQuantidadeFuncionario.Text = "";
                TextEndereco.Text = "";
                TextTelefone.Text = "";
                TextRisco.Text = "";
                TextEmail.Text = "";
                LabelCnae.Text = "CNAE:";
                GridServicosPrestados.DataSource = null;
                DataTable TabelaServicos = Cadastro.RetornaServicosPrestados();
                GridServicosPrestados.DataSource = TabelaServicos;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var TabelaResultadoEmpresa = Cadastro.BuscaEmpresa(TextBusca.Text);
            if (TabelaResultadoEmpresa.Rows.Count == 0)
                MetroMessageBox.Show(this,
                    "Sua busca não encontrou nenhum resultado", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                DataGridEmpresa.DataSource = TabelaResultadoEmpresa;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var Certeza = MetroMessageBox.Show(this,
                "Você tem certeza que deseja excluir as empresas selecionadas", "Certeza ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Certeza == DialogResult.OK)
            {
                for (var i = 0; i < DataGridEmpresa.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(DataGridEmpresa.Rows[i].Cells[0].Value.ToString()))
                        {
                            Cadastro.ExcluirEmpresa(DataGridEmpresa.Rows[i].Cells[1].Value.ToString());
                            Hide();
                        }
                    }
                    catch
                    {
                    }
                MetroMessageBox.Show(this,
                    "Empresas excluidas com sucesso", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cadastro.SetEmpresa("");
                BtnEditar.Text = "Editar";
                TextNomeEditar.Text = "";
                TextEnderecoEditar.Text = "";
                TextCnpjEditar.Text = "";
                TextQuantidadeFuncionarioEditar.Text = "";
                TextTelefoneEditar.Text = "";
                TextEmailEditar.Text = "";
                LabelCnaeEditar.Text = "CNAE:";
                TextRiscoEditar.Text = "";
                TextBusca.Text = "";
                DataGridEmpresa.DataSource = null;
                GridServicosEditar.DataSource = null;
                DataTable TabelaServicos = Cadastro.RetornaServicosPrestados();
                GridServicosEditar.DataSource = TabelaServicos;
            }
        }

        private void TextBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnBuscar_Click(sender, e);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (BtnEditar.Text.Equals("Editar"))
            {
                for (var i = 0; i < DataGridEmpresa.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(DataGridEmpresa.Rows[i].Cells[0].Value.ToString()))
                        {
                            Cadastro.SetEmpresa(DataGridEmpresa.Rows[i].Cells[1].Value.ToString());
                            i = DataGridEmpresa.RowCount;
                        }
                    }
                    catch
                    {
                    }
                var IdEmpresa = Cadastro.GetEmpresa();
                if (IdEmpresa.Equals(""))
                {
                }
                else
                {
                    var TabelaEditarEmpresa = Cadastro.RecuperaDadosEmpresa();
                    TextNomeEditar.Text = TabelaEditarEmpresa.Rows[0][0].ToString();
                    TextEnderecoEditar.Text = TabelaEditarEmpresa.Rows[0][1].ToString();
                    TextCnpjEditar.Text = TabelaEditarEmpresa.Rows[0][2].ToString();
                    TextQuantidadeFuncionarioEditar.Text = TabelaEditarEmpresa.Rows[0][3].ToString();
                    TextTelefoneEditar.Text = TabelaEditarEmpresa.Rows[0][4].ToString();
                    TextEmailEditar.Text = TabelaEditarEmpresa.Rows[0][5].ToString();
                    LabelCnaeEditar.Text = "CNAE |" + TabelaEditarEmpresa.Rows[0][6];
                    TextRiscoEditar.Text = TabelaEditarEmpresa.Rows[0][7].ToString();
                    string [] Servicos = TabelaEditarEmpresa.Rows[0]["servicoprestado"].ToString().Split(';');
                    for (int j = 1; j < Servicos.Length; j++)
                    {
                        for (int k=0;k<GridServicosEditar.RowCount;k++)
                            {
                                if (GridServicosEditar.Rows[k].Cells[1].Value.ToString().Equals(Servicos[j].ToString()))
                                {
                                    GridServicosEditar.Rows[k].Cells[0].Value = true;
                                }
                            }
                    }



                    BtnEditar.Text = "Salvar";
                }
            }
            else
            {
                string Servicos = "";
                for (int i = 0; i < GridServicosEditar.RowCount; i++)
                {
                    if (Convert.ToBoolean(GridServicosEditar.Rows[i].Cells[0].Value))
                    {
                        Servicos = Servicos + ";" + GridServicosEditar.Rows[i].Cells[1].Value.ToString();
                    }

                }
                var Cnae = LabelCnaeEditar.Text.Split('|');
                Cadastro.EditarEmpresa(TextNomeEditar.Text, TextEnderecoEditar.Text, TextCnpjEditar.Text,
                    Convert.ToInt32(TextQuantidadeFuncionarioEditar.Text), TextTelefoneEditar.Text, TextEmailEditar.Text,
                    Cnae[1] + " " +
                    "| " + Cnae[2],
                    Convert.ToInt32(TextRiscoEditar.Text),Servicos);
                MetroMessageBox.Show(this, "Dados da empresa atualizados com sucesso!", "Sucesso !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Cadastro.SetEmpresa("");
                BtnEditar.Text = "Editar";
                TextNomeEditar.Text = "";
                TextEnderecoEditar.Text = "";
                TextCnpjEditar.Text = "";
                TextQuantidadeFuncionarioEditar.Text = "";
                TextTelefoneEditar.Text = "";
                TextEmailEditar.Text = "";
                LabelCnaeEditar.Text = "CNAE:";
                TextRiscoEditar.Text = "";
                TextBusca.Text = "";
                DataGridEmpresa.DataSource = null;
                
            }
        }

        private void BtnCnaeEditar_Click(object sender, EventArgs e)
        {
            if (TextBuscaCnaeEditar.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Favor preencher o campo de busca !", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                var TabelaResultadoBuscaCnae = Cadastro.BuscaCnae(TextBuscaCnaeEditar.Text);
                if (TabelaResultadoBuscaCnae.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Sua busca não retornou nenhum dado!", "Atenção !", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    GridCnaeEditar.Visible = true;
                    GridCnaeEditar.DataSource = TabelaResultadoBuscaCnae;
                }
            }
        }

        private void TextBuscaCnaeEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnCnaeEditar_Click(sender, e);
        }

        private void GridCnaeEditar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LabelCnaeEditar.Text = "CNAE | " + DataViewCnae.Rows[e.RowIndex].Cells[0].Value + " | " +
                                   DataViewCnae.Rows[e.RowIndex].Cells[1].Value;
            LabelCnaeEditar.UseStyleColors = true;
            LabelCnaeEditar.FontWeight = MetroLabelWeight.Bold;
            LabelCnaeEditar.AutoSize = true;
            TextBuscaCnaeEditar.Text = "";
            GridCnaeEditar.DataSource = null;
            GridCnaeEditar.Visible = false;
        }

        private void BtnBuscaCnae_Click_1(object sender, EventArgs e)
        {
            if (TextBuscaCnae.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Favor preencher o campo de busca !", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                var TabelaResultadoBuscaCnae = Cadastro.BuscaCnae(TextBuscaCnae.Text);
                if (TabelaResultadoBuscaCnae.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Sua busca não retornou nenhum dado!", "Atenção !", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    DataViewCnae.Visible = true;
                    DataViewCnae.DataSource = TabelaResultadoBuscaCnae;
                }
            }
        }

        private void TextBuscaCnae_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnBuscaCnae_Click_1(sender, e);
        }
    }
}