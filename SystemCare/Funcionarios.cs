using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class Funcionarios : MetroForm
    {
        private readonly QuerryMysql Cadastro = new QuerryMysql();

        public Funcionarios()
        {
            InitializeComponent();
        }

        private void BtnBuscaFuncao_Click(object sender, EventArgs e)
        {
            GridFuncaoEditar.DataSource = null;
            var TabelaFuncao = Cadastro.BuscaFuncao(TextBuscaFuncao.Text);
            GridFuncaoEditar.DataSource = TabelaFuncao;
        }

        private void TextBuscaFuncao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnBuscaFuncao_Click(sender, e);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            bool Validado=Cadastro.ValidaCpf(TextCpf.Text);
            if (Validado)
            {
                var IdFuncao = "";
                var Sexo = "";
                for (var i = 0; i < GridFuncaoEditar.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridFuncaoEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdFuncao = GridFuncaoEditar.Rows[i].Cells[1].Value.ToString();
                            i = GridFuncaoEditar.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                if (IdFuncao.Length == 0)
                {
                    MetroMessageBox.Show(this,
                        "Nenhuma função selecionada", "Atenção",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (RadioMasculino.Checked)
                        Sexo = "M";
                    else
                        Sexo = "F";

                    if (Sexo.Length == 0)
                    {
                        MetroMessageBox.Show(this,
                            "Selecione o sexo do funcionário", "Atenção",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else if (TextNomeFuncionario.Text.Length == 00)
                    {
                        MetroMessageBox.Show(this,
                            "Preencha o nome do funcionário", "Atenção",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else if (!TextCpf.MaskCompleted)
                    {
                        MetroMessageBox.Show(this,
                            "Preencha o CPF do funcionário", "Atenção",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else if (!TextIdentidade.MaskCompleted)
                    {
                        MetroMessageBox.Show(this,
                            "Preencha a identidade do funcionário", "Atenção",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else if (!TextDataNascimento.MaskCompleted)
                    {
                        MetroMessageBox.Show(this,
                            "Preencha a data de nascimento do funcionário", "Atenção",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Cadastro.CadastraFuncionario(TextNomeFuncionario.Text, TextIdade.Text, Sexo,
                            TextAltura.Text.Replace(',', '.'),
                            TextPeso.Text.Replace(',', '.'),
                            TextImc.Text, TextCpf.Text, TextIdentidade.Text, TextTelefoneFuncionario.Text,
                            Convert.ToDateTime(TextDataNascimento.Text), TextNaturalidade.Text, IdFuncao);
                        TextNomeFuncionario.Text = "";
                        TextIdade.Text = "";
                        TextAltura.Text = "";
                        TextPeso.Text = "";
                        TextImc.Text = "";
                        TextCpf.Text = "";
                        TextIdentidade.Text = "";
                        TextTelefoneFuncionario.Text = "";
                        TextDataNascimento.Text = "";
                        TextNaturalidade.Text = "";
                        TextBuscaFuncao.Text = "";
                        GridFuncaoEditar.DataSource = null;
                        MetroMessageBox.Show(this,
                            "Funcionário cadastrado com sucesso!", "Sucesso !",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this,
                           "Este CPF já está cadastrado!", "Sucesso !",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            GridFuncionarioEditar.DataSource = null;
            var TabelFuncionarios = Cadastro.BuscaFuncionario(TextFuncionarioBusca.Text);
            GridFuncionarioEditar.DataSource = TabelFuncionarios;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var IdFuncionario = "";
            var IdFuncao = "";
            if (BtnEditar.Text.Equals("Editar"))
            {
                for (var i = 0; i < GridFuncionarioEditar.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridFuncionarioEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdFuncionario = GridFuncionarioEditar.Rows[i].Cells[1].Value.ToString();
                            i = GridFuncionarioEditar.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                if (IdFuncionario.Equals(""))
                {
                    MetroMessageBox.Show(this,
                        "Nenhum funcionário selecionado", "Certeza ?",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    var TabelaDadosFuncionario = Cadastro.RecuperaDadosFuncionario(IdFuncionario);
                    TextNomeFuncionarioEditar.Text = TabelaDadosFuncionario.Rows[0]["nome"].ToString();
                    TextIdadeEditar.Text = TabelaDadosFuncionario.Rows[0]["idade"].ToString();
                    TextAlturaEditar.Text = TabelaDadosFuncionario.Rows[0]["altura"].ToString();
                    TextPesoEditar.Text = TabelaDadosFuncionario.Rows[0]["peso"].ToString();
                    TextImcEditar.Text = TabelaDadosFuncionario.Rows[0]["imc"].ToString();
                    TextCpfEditar.Text = TabelaDadosFuncionario.Rows[0]["cpf"].ToString();
                    TextIdentidadeEditar.Text = TabelaDadosFuncionario.Rows[0]["identidade"].ToString();
                    TextTelefoneEditar.Text = TabelaDadosFuncionario.Rows[0]["telefone"].ToString();
                    TextDataNascimentoEditar.Text = TabelaDadosFuncionario.Rows[0]["datanascimento"].ToString();
                    TextNaturalidadeEditar.Text = TabelaDadosFuncionario.Rows[0]["naturalidade"].ToString();
                    BtnEditar.Text = "Salvar";
                    if (TabelaDadosFuncionario.Rows[0]["sexo"].ToString().Equals("M"))
                        RadioMasculinoEditar.Checked = true;
                    else
                        RadioFemininoEditar.Checked = true;
                    TextBuscaFuncaoEditar.Text =
                        Cadastro.RetornaFuncao(TabelaDadosFuncionario.Rows[0]["idfuncao"].ToString());
                    BtnBuscaFuncaoEditar_Click(sender, e);
                    for (var i = 0; i < GridFuncaoFuncionarioEditar.Rows.Count; i++)
                        try
                        {
                            if (
                                GridFuncaoFuncionarioEditar.Rows[i].Cells[2].Value.ToString()
                                    .Equals(TextBuscaFuncaoEditar.Text))
                            {
                                GridFuncaoFuncionarioEditar.Rows[i].Cells[0].Value = true;
                                i = GridFuncaoFuncionarioEditar.Rows.Count;
                            }
                        }
                        catch
                        {
                        }
                }
            }

            else
            {
                var Sexo = "";
                if (RadioMasculinoEditar.Checked)
                    Sexo = "M";
                else
                    Sexo = "F";
                for (var i = 0; i < GridFuncaoFuncionarioEditar.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridFuncaoFuncionarioEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdFuncao = GridFuncaoFuncionarioEditar.Rows[i].Cells[1].Value.ToString();
                            i = GridFuncaoFuncionarioEditar.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                for (var i = 0; i < GridFuncionarioEditar.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridFuncionarioEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdFuncionario = GridFuncionarioEditar.Rows[i].Cells[1].Value.ToString();
                            i = GridFuncionarioEditar.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                Cadastro.AtualizaFuncionario(IdFuncionario, TextNomeFuncionarioEditar.Text, TextIdadeEditar.Text, Sexo,
                    Convert.ToDecimal(TextAlturaEditar.Text), Convert.ToDecimal(TextPesoEditar.Text),
                    TextImcEditar.Text, TextCpfEditar.Text, TextIdentidadeEditar.Text, TextTelefoneEditar.Text,
                    Convert.ToDateTime(TextDataNascimentoEditar.Text), TextNaturalidadeEditar.Text, IdFuncao);
                TextFuncionarioBusca.Text = "";
                GridFuncionarioEditar.DataSource = null;
                TextNomeFuncionarioEditar.Text = "";
                TextIdadeEditar.Text = "";
                TextAlturaEditar.Text = "";
                TextPesoEditar.Text = "";
                TextImcEditar.Text = "";
                TextCpfEditar.Text = "";
                TextIdentidadeEditar.Text = "";
                TextTelefoneEditar.Text = "";
                TextDataNascimentoEditar.Text = "";
                TextNaturalidadeEditar.Text = "";
                TextBuscaFuncaoEditar.Text = "";
                GridFuncaoFuncionarioEditar.DataSource = "";
                MetroMessageBox.Show(this,
                    "Dados atualizados com sucesso!", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var Certeza = MetroMessageBox.Show(this,
                "Você tem certeza que deseja excluir a função selecionado ?", "Certeza ?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (Certeza == DialogResult.OK)
            {
                var IdFuncionario = "";
                for (var i = 0; i < GridFuncionarioEditar.Rows.Count; i++)
                    try
                    {
                        if (Convert.ToBoolean(GridFuncionarioEditar.Rows[i].Cells[0].Value.ToString()))
                        {
                            IdFuncionario = GridFuncionarioEditar.Rows[i].Cells[1].Value.ToString();
                            i = GridFuncionarioEditar.Rows.Count;
                        }
                    }
                    catch
                    {
                    }
                Cadastro.ExcluirFuncionario(IdFuncionario);
                MetroMessageBox.Show(this,
                    "Funcionário excluido com sucesso !", "Sucesso !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextFuncionarioBusca.Text = "";
                GridFuncionarioEditar.DataSource = null;
                TextNomeFuncionarioEditar.Text = "";
                TextIdadeEditar.Text = "";
                TextAlturaEditar.Text = "";
                TextPesoEditar.Text = "";
                TextImcEditar.Text = "";
                TextCpfEditar.Text = "";
                TextIdentidadeEditar.Text = "";
                TextTelefoneEditar.Text = "";
                TextDataNascimentoEditar.Text = "";
                TextNaturalidadeEditar.Text = "";
                TextBuscaFuncaoEditar.Text = "";
                GridFuncaoFuncionarioEditar.DataSource = "";
            }
        }

        private void BtnBuscaFuncaoEditar_Click(object sender, EventArgs e)
        {
            GridFuncaoFuncionarioEditar.DataSource = null;
            var TabelaFuncao = Cadastro.BuscaFuncao(TextBuscaFuncaoEditar.Text);
            GridFuncaoFuncionarioEditar.DataSource = TabelaFuncao;
        }

        private void TextFuncionarioBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnBuscarFuncionario_Click(sender, e);
        }

        private void TextBuscaFuncaoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                BtnBuscaFuncaoEditar_Click(sender, e);
        }

        private void TextImc_Enter(object sender, EventArgs e)
        {
            if (TextAltura.Text.Length == 0 || TextPeso.Text.Length==0)
            {
                MetroMessageBox.Show(this,
                        "Preencha o campo de Altura e Peso", "Atenção",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                var altura = Convert.ToDouble(TextAltura.Text.Replace(',', '.'));
                var peso = Convert.ToDouble(TextPeso.Text.Replace(',', '.'));
                TextImc.Text = (peso / Math.Pow(altura, 2) * 100).ToString("##.##");
            }
        }
    }
}