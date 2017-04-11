using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                Respiratoria =  Respiratoria + ";" + Rinite.Text;
            }
            if (Sinusite.Checked)
            {
                Respiratoria =  Respiratoria + ";" + Sinusite.Text;
            }
            Respiratoria = Respiratoria + ";" + TextRespiratoria.Text;
            if (Gastrite.Checked)
            {
                Gastro = Gastrite.Text;
            }
            if (Ulcera.Checked)
            {
                Gastro =  Gastro + ";" + Ulcera.Text;
            }
            if (Diarreia.Checked)
            {
                Gastro = Gastro + ";" + Diarreia.Text;
            }
            if (Constipacao.Checked)
            {
                Gastro = Gastro + ";" + Constipacao.Text;
            }
            Gastro =  Gastro + ";" + TextGastro.Text;
            if (Arritimia.Checked)
            {
                Cardiaca = Arritimia.Text;
            }
            if (Hipertensao.Checked)
            {
                Cardiaca =  Cardiaca + ";" + Hipertensao.Text;
            }
            if (Insuficiencia.Checked)
            {
                Cardiaca =  Cardiaca + ";" + Insuficiencia.Text;
            }
            Cardiaca =  Cardiaca + ";" + TextCardio.Text;
            if (Diabetes.Checked)
            {
                Endocrino = Diabetes.Text;
            }
            if (Hipotireodismo.Checked)
            {
                Endocrino =  Endocrino + ";" + Hipotireodismo.Text;
                }
            if (Hipertireodismo.Checked)
            {
                Endocrino =  Endocrino + ";" + Hipertireodismo.Text;
            }
            Endocrino =  Endocrino + ";" + TextEndocrino.Text;
            if (Coluna.Checked)
            {
                Osseo = Coluna.Text;
            }
            if (Ombro.Checked)
            {
                Osseo =  Osseo + ";" + Ombro.Text;
            }
            if (Bracos.Checked)
            {
                Osseo = Osseo + ";" + Bracos.Text;
            }
            if (Joelhos.Checked)
            {
                Osseo =  Osseo + ";" + Joelhos.Text;
            }
            if (Mao.Checked)
            {
                Osseo = Osseo + ";" + Mao.Text;
            }
            Osseo =  Osseo + ";" + TextOsteo.Text;
            CadastraQuestionario.CadastraQuestionario(IdFuncionarioQuestiona,TextQueixa.Text,Cirurgia,DataCirurgia.Value,TextCirurgia.Text,Fraturas,DataFratura.Value,Internacao,TextInternacao.Text,DataInternacao.Value,Alergias,TextAlergia.Text,Respiratoria,Gastro,Cardiaca,Endocrino,Osseo,TextHistorico.Text,AcidenteTrabalho,DataAcidente.Value,AfastamentoAcidente,AfastamentoPrevidencia,TextAfastamentoPrevidencia.Text);
        }
    }
}
