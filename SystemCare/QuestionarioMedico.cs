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
    public partial class QuestionarioMedico : MetroForm
    {
        QuerryMysql CadastraQuestionario = new QuerryMysql();
        static string IdFuncionarioQuestiona;
        public QuestionarioMedico(string IdFuncionario)
        {

            InitializeComponent();
            IdFuncionarioQuestiona = IdFuncionario;
            DataTable DadosFuncionarios = CadastraQuestionario.RecuperaDadosFuncionario(IdFuncionario);
            LabelFuncionario.Text = DadosFuncionarios.Rows[0]["nome"].ToString();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string Cirurgia = "";
            string Internacao = "";
            string Fraturas = "";
            string Alergias = "";
            string AcidenteTrabalho = "";
            string AfastamentoAcidente = "";
            string AfastamentoPrevidencia = "";
            string Respiratoria = "";
            string Gastro = "";
            string Cardiaca = "";
            string Endocrino = "";
            string Osseo = "";

            if (RadioSimCirurgia.Checked)
            {
                Cirurgia = "S";
            }
            else
            {
                Cirurgia = "N";
            }
            if (RadioSimInternacao.Checked)
            {
                Internacao = "S";
            }
            else
            {
                Internacao = "N";
            }
            if (RadioFraturaSim.Checked)
            {
                Fraturas = "S";
            }
            else
            {
                Fraturas = "N";
            }
            if (RadioAlergiaSim.Checked)
            {
                Alergias = "S";
            }
            else
            {
                Alergias = "N";
            }
            if (RadioSimAcidente.Checked)
            {
                AcidenteTrabalho = "S";
            }
            else
            {
                AcidenteTrabalho = "N";
            }
            if (RadioSimAfastamento.Checked)
            {
                AfastamentoAcidente = "S";
            }
            else
            {
                AfastamentoAcidente = "N";
            }
            if (RadioPrevidenciaSim.Checked)
            {
                AfastamentoPrevidencia = "S";
            }
            else
            {
                AfastamentoPrevidencia = "N";
            }
            if (Bronquite.Checked)
            {
                Respiratoria = Bronquite.Text;
            }
            if (Asma.Checked)
            {
                Respiratoria = Respiratoria + ";" + Asma.Text;
            }
            if (Rinite.Checked)
            {
                Respiratoria = Respiratoria + ";" + Rinite.Text;
            }
            if (Sinusite.Checked)
            {
                Respiratoria = Respiratoria + ";" + Sinusite.Text;
            }
            Respiratoria = Respiratoria + ";" + TextRespiratoria.Text;
            if (Gastrite.Checked)
            {
                Gastro = Gastrite.Text;
            }
            if (Ulcera.Checked)
            {
                Gastro = Gastro + ";" + Ulcera.Text;
            }
            if (Diarreia.Checked)
            {
                Gastro = Gastro + ";" + Diarreia.Text;
            }
            if (Constipacao.Checked)
            {
                Gastro = Gastro + ";" + Constipacao.Text;
            }
            Gastro = Gastro + ";" + TextGastro.Text;
            if (Arritimia.Checked)
            {
                Cardiaca = Arritimia.Text;
            }
            if (Hipertensao.Checked)
            {
                Cardiaca = Cardiaca + ";" + Hipertensao.Text;
            }
            if (Insuficiencia.Checked)
            {
                Cardiaca = Cardiaca + ";" + Insuficiencia.Text;
            }
            Cardiaca = Cardiaca + ";" + TextCardio.Text;
            if (Diabetes.Checked)
            {
                Endocrino = Diabetes.Text;
            }
            if (Hipotireodismo.Checked)
            {
                Endocrino = Endocrino + ";" + Hipotireodismo.Text;
            }
            if (Hipertireodismo.Checked)
            {
                Endocrino = Endocrino + ";" + Hipertireodismo.Text;
            }
            Endocrino = Endocrino + ";" + TextEndocrino.Text;
            if (Coluna.Checked)
            {
                Osseo = Coluna.Text;
            }
            if (Ombro.Checked)
            {
                Osseo = Osseo + ";" + Ombro.Text;
            }
            if (Bracos.Checked)
            {
                Osseo = Osseo + ";" + Bracos.Text;
            }
            if (Joelhos.Checked)
            {
                Osseo = Osseo + ";" + Joelhos.Text;
            }
            if (Mao.Checked)
            {
                Osseo = Osseo + ";" + Mao.Text;
            }
            Osseo = Osseo + ";" + TextOsteo.Text;
            CadastraQuestionario.CadastraQuestionario(IdFuncionarioQuestiona, TextQueixa.Text, Cirurgia, DataCirurgia.Value, TextCirurgia.Text, Fraturas, DataFratura.Value, Internacao, TextInternacao.Text, DataInternacao.Value, Alergias, TextAlergia.Text, Respiratoria, Gastro, Cardiaca, Endocrino, Osseo, TextHistorico.Text, AcidenteTrabalho, DataAcidente.Value, AfastamentoAcidente, AfastamentoPrevidencia, TextAfastamentoPrevidencia.Text);
            MetroMessageBox.Show(this, "Questionário cadastrado com sucesso", "Sucesso !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!RadioRespiratoria.Checked)
            {
                Bronquite.Visible = true;
                Asma.Visible = true;
                Rinite.Visible = true; ;
                Sinusite.Visible = true;
                LabelRepiratoria.Visible = true;
                TextRespiratoria.Visible = true;
            }
            else
            {

                Bronquite.Visible = false;
                Asma.Visible = false;
                Rinite.Visible = false;
                Sinusite.Visible = false;
                LabelRepiratoria.Visible = false;
                TextRespiratoria.Visible = false;
            }
        }

        private void RadioGastro_CheckedChanged(object sender, EventArgs e)
        {
            if (!RadioGastro.Checked)
            {
                Gastrite.Visible = true;
                Ulcera.Visible = true;
                Diarreia.Visible = true;
                Constipacao.Visible = true;
                LabelGastro.Visible = true;
                TextGastro.Visible = true;


            }
            else
            {
                Gastrite.Visible = false;
                Ulcera.Visible = false;
                Diarreia.Visible = false;
                Constipacao.Visible = false;
                LabelGastro.Visible = false;
                TextGastro.Visible = false;

            }
        }

        private void RadioCardio_CheckedChanged(object sender, EventArgs e)
        {
            if (!RadioCardio.Checked)
            {
                Arritimia.Visible = true;
                Hipertensao.Visible = true;
                Insuficiencia.Visible = true;
                LabelCardio.Visible = true;
                TextCardio.Visible = true;
            }
            else
            {
                Arritimia.Visible = false;
                Hipertensao.Visible = false;
                Insuficiencia.Visible = false;
                LabelCardio.Visible = false;
                TextCardio.Visible = false;
            }
        }

        private void RadioEndocrino_CheckedChanged(object sender, EventArgs e)
        {
            if (!RadioEndocrino.Checked)
            {
                Diabetes.Visible = true;
                Hipertireodismo.Visible = true;
                Hipotireodismo.Visible = true;
                LabelEndocrino.Visible = true;
                TextEndocrino.Visible = true;
            }
            else
            {
                Diabetes.Visible = false;
                Hipertireodismo.Visible = false;
                Hipotireodismo.Visible = false;
                LabelEndocrino.Visible = false;
                TextEndocrino.Visible = false;
            }
        }

        private void RadioOsteo_CheckedChanged(object sender, EventArgs e)
        {
            if (!RadioOsteo.Checked)
            {
                Coluna.Visible=true;
                Ombro.Visible=true;
                Bracos.Visible=true;
                Joelhos.Visible=true;
                Mao.Visible = true;
                LabelOsteo.Visible = true;
                TextOsteo.Visible=true;
            }
            else
            {
                Coluna.Visible = false;
                Ombro.Visible = false;
                Bracos.Visible = false;
                Joelhos.Visible = false;
                Mao.Visible =false;
                LabelOsteo.Visible = false;
                TextOsteo.Visible = false;
            }
        }
    }
}
