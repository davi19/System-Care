﻿using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SystemCare
{
    public partial class Principal : MetroForm
    {
        private QuerryMysql Cadastro = new QuerryMysql();

        public Principal()
        {
            InitializeComponent();

            Text = "System Care V. " + Application.ProductVersion;
        }


        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CadastroEmpresa = new Empresas();
            CadastroEmpresa.ShowDialog();
        }

        private void setoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CadastroSetores = new Setores();
            CadastroSetores.ShowDialog();
        }

        private void funçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CadastraFuncao = new Funcoes();
            CadastraFuncao.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CadastroFuncionario = new Funcionarios();
            CadastroFuncionario.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ajuda = new Ajuda();
            ajuda.ShowDialog();
        }

        private void examesEAvaliaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CadastroAvaliação = new ExamesAvaliacoes();
            CadastroAvaliação.ShowDialog();
        }

        private void empresasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var RelatoriosEmpresa = new EmpresaRelatorio();
            RelatoriosEmpresa.ShowDialog();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var CriarUsuario = new Usuarios();
            CriarUsuario.ShowDialog();
        }

        private void riscosOperacionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var riscos = new RiscosOperacionais();
            riscos.ShowDialog();
        }

        private void cBOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cbo CadastroCbo = new Cbo();
            CadastroCbo.ShowDialog();
        }

        private void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exames exame = new Exames();
            exame.ShowDialog();
        }

        private void modalidadesDeExamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalidadeExame Modalidade = new ModalidadeExame();
            Modalidade.ShowDialog();
        }

        private void cnaeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cnae cnae = new Cnae();
            cnae.ShowDialog();
        }

        private void serviçosPrestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicoPrestado Servico = new ServicoPrestado();
            Servico.ShowDialog();
        }

        private void tabelaDePreçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaPreco Tabela = new TabelaPreco();
            Tabela.ShowDialog();

        }

        private void atestadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void despesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarDespesa Despesa = new CadastrarDespesa();
            Despesa.ShowDialog();
        }
    }
}