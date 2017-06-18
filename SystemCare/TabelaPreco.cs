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
    public partial class TabelaPreco : MetroForm
    {
        QuerryMysql Cadastro = new QuerryMysql();
        public TabelaPreco()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TextBuscarExame.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Preencha o campo de busca.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                DataTable Resultado = Cadastro.BuscarExameModalidade(TextBuscarExame.Text);
                if (Resultado.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Sua busca não retornou nenhum resultado.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                
                GridResultado.DataSource = Resultado;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TextValor.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Preencha o campo de valor.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                string IdExame = "";
                for (int i = 0; i < GridResultado.RowCount; i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(GridResultado.Rows[i].Cells[0].Value))
                        {
                            IdExame = GridResultado.Rows[i].Cells[1].Value.ToString();
                        }
                    }
                    catch
                    {
                        
                    }
                }
                if (IdExame.Length == 0)
                {
                    MetroMessageBox.Show(this, "Selecione um exame.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
                else
                {
                    Cadastro.CadastrarPreco(TextValor.Text, IdExame);
                    GridResultado.DataSource = null;
                    TextValor.Text = "";
                    TextBuscarExame.Text = "";
                    MetroMessageBox.Show(this, "Preço Cadastrado com sucesso !", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void BtnBuscarEditar_Click(object sender, EventArgs e)
        {
            if (TextBuscaEditar.Text.Length == 0)
            {
                MetroMessageBox.Show(this, "Preencha o campo de busca.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                DataTable Resultado = Cadastro.BuscarExameModalidade(TextBuscaEditar.Text);
                if (Resultado.Rows.Count == 0)
                {
                    MetroMessageBox.Show(this, "Sua busca não retornou nenhum resultado.", "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                
                GridResultadoEditar.DataSource = Resultado;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            
            if (BtnEditar.Text.Equals("Editar"))
            {
                string IdExame = "";
                for (int i = 0; i < GridResultadoEditar.RowCount; i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(GridResultadoEditar.Rows[i].Cells[0].Value))
                        {
                            IdExame = GridResultadoEditar.Rows[i].Cells[1].Value.ToString();
                        }
                    }
                    catch
                    {

                    }
                }
                if (IdExame.Length == 0)
                {
                    MetroMessageBox.Show(this, "Selecione um exame.", "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
                else
                {

                    BtnEditar.Text = "Salvar";
                    string Valor = Cadastro.RecuperaDadosPreco(IdExame);
                    if (Valor.Length == 0)
                    {
                        MetroMessageBox.Show(this,
                            "Não existe um preço cadastrado para este exame, por favor cadastre um na aba 'Cadastrar'.",
                            "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        TextValorEditar.Text = Valor;
                    }


                }
            }
            else
            {
                string IdExame = "";
                for (int i = 0; i < GridResultadoEditar.RowCount; i++)
                {
                    try
                    {
                        if (Convert.ToBoolean(GridResultadoEditar.Rows[i].Cells[0].Value))
                        {
                            IdExame = GridResultadoEditar.Rows[i].Cells[1].Value.ToString();
                        }
                    }
                    catch
                    {

                    }
                }
                Cadastro.AtualizaPreco(IdExame, TextValorEditar.Text);
                GridResultadoEditar.DataSource = null;
                TextValorEditar.Text = "";
                TextBuscaEditar.Text = "";
                BtnEditar.Text = "Editar";
                MetroMessageBox.Show(this, "Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            GridResultadoEditar.DataSource = null;
            TextValorEditar.Text = "";
            TextBuscaEditar.Text = "";
            BtnEditar.Text = "Editar";
        }
    }
}
