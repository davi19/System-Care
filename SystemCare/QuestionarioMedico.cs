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

        public QuestionarioMedico(string IdFuncionario, string TipoExame,string Recupera)
        {

            InitializeComponent();
            if (Recupera.Equals("0"))
            {
                IdFuncionarioQuestiona = IdFuncionario;
                DataTable DadosFuncionarios = CadastraQuestionario.RecuperaDadosFuncionario(IdFuncionario);
                LabelFuncionario.Text = DadosFuncionarios.Rows[0]["nome"].ToString();
                LabelData.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
                LabelExame.Text = TipoExame.ToUpper();
            }
            else
            {
                BtnCadastrar.Visible = false;
                DataTable DadosQuestionario = CadastraQuestionario.RetornaDadosQuestionarioFuncionario(Recupera);
                TextQueixa.Text = DadosQuestionario.Rows[0]["queixa"].ToString();
                LabelFuncionario.Text = DadosQuestionario.Rows[0]["nome"].ToString();
                if (DadosQuestionario.Rows[0]["cirurgiaanterior"].ToString() == "S")
                {
                    RadioSimCirurgia.Checked = true;
                    TextCirurgia.Text = DadosQuestionario.Rows[0]["nomecirurgia"].ToString();
                    DataCirurgia.Text = DadosQuestionario.Rows[0]["datacirurgia"].ToString();

                }
                if (DadosQuestionario.Rows[0]["internacao"].ToString() == "S")
                {
                    RadioSimInternacao.Checked = true;
                    TextInternacao.Text = DadosQuestionario.Rows[0]["motivointernacao"].ToString();
                    DataInternacao.Text = DadosQuestionario.Rows[0]["datainternacao"].ToString();

                }
                if (DadosQuestionario.Rows[0]["fratura"].ToString() == "S")
                {
                    RadioFraturaSim.Checked = true;
                    DataFratura.Text = DadosQuestionario.Rows[0]["datatomografia"].ToString();
                }
                if (DadosQuestionario.Rows[0]["alergia"].ToString() == "S")
                {
                    RadioAlergiaSim.Checked = true;
                    TextAlergia.Text = DadosQuestionario.Rows[0]["descricaoalergia"].ToString();
                }

                TextHistorico.Text = DadosQuestionario.Rows[0]["historiaocupacional"].ToString();

                if (DadosQuestionario.Rows[0]["acidentedetrabalho"].ToString()=="S")
                {
                    RadioSimAcidente.Checked = true;
                    DataAcidente.Text = DadosQuestionario.Rows[0]["dataacidente"].ToString();

                }
                if (DadosQuestionario.Rows[0]["afastamentoinss"].ToString() == "S")
                {
                    RadioPrevidenciaSim.Checked = true;
                    TextAfastamentoPrevidencia.Text = DadosQuestionario.Rows[0]["periodoafastamentoinss"].ToString();
                }
                if (DadosQuestionario.Rows[0]["afastamentoacidente"].ToString() == "S")
                {
                    RadioSimAfastamento.Checked = true;
                    TextAfastamentoAcidente.Text = DadosQuestionario.Rows[0]["periodoafastamento"].ToString();
                }

                


                var Respiratoria = DadosQuestionario.Rows[0]["doencarespiratoria"].ToString().Split(';');
                var Gastro = DadosQuestionario.Rows[0]["doencagastrointestinal"].ToString().Split(';');
                var Cardio = DadosQuestionario.Rows[0]["doencacardiaca"].ToString().Split(';');
                var Endocrino = DadosQuestionario.Rows[0]["doencaendocrina"].ToString().Split(';');
                var Oesteo = DadosQuestionario.Rows[0]["doencaosteomusculares"].ToString().Split(';');
                var Neuro = DadosQuestionario.Rows[0]["doencaneurologica"].ToString().Split(';');
                var Renal = DadosQuestionario.Rows[0]["doencarenal"].ToString().Split(';');
                var Habitos = DadosQuestionario.Rows[0]["habitodevida"].ToString().Split(';');


                if (DadosQuestionario.Rows[0]["atividadefisica"].ToString() == "S")
                {
                    RadioAtividade.Checked = true;
                    FrequenciaAtividade.Value = Convert.ToInt32(DadosQuestionario.Rows[0]["frequenciaatividade"].ToString());
                }
                LabelData.Text = Convert.ToDateTime(DadosQuestionario.Rows[0]["dataquestionario"].ToString()).Date.ToString("dd/MM/yyyy");
                LabelExame.Text = DadosQuestionario.Rows[0]["descricao"].ToString();
                if (Respiratoria.Length > 0)
                {
                    RadioSimRespiratoria.Checked = true;
                }
                for (int i = 0; i < Respiratoria.Length; i++)
                {
                    if (Respiratoria[i].Length > 0)
                    {
                        foreach (var pb in this.Controls.OfType<CheckBox>())
                        {
                            if (pb.Name.Contains(Respiratoria[i]))
                            {
                                pb.Checked = true;
                            }
                        }
                    }
                }



                if (Gastro.Length > 0)
                {
                    RadioSimGastro.Checked = true;
                }
                for (int i = 0; i < Gastro.Length; i++)
                {
                    if (Gastro[i].Length > 0)
                    {
                        foreach (var pb in this.Controls.OfType<CheckBox>())
                        {
                            if (pb.Name.Contains(Gastro[i]))
                            {
                                pb.Checked = true;
                            }
                        }
                    }
                }





                if (Cardio.Length > 0)
                {
                    RadioSimCardio.Checked = true;
                }
                for (int i = 0; i < Cardio.Length; i++)
                {
                    if (Cardio[i].Length > 0)
                    {
                        foreach (var pb in this.Controls.OfType<CheckBox>())
                        {
                            if (pb.Name.Contains(Cardio[i]))
                            {
                                pb.Checked = true;
                            }
                        }
                    }
                }




                if (Endocrino.Length > 0)
                {
                    RadioSimEndocrino.Checked = true;
                }
                for (int i = 0; i < Endocrino.Length; i++)
                {
                    if (Endocrino[i].Length > 0)
                    {
                        foreach (var pb in this.Controls.OfType<CheckBox>())
                        {
                            if (pb.Name.Contains(Endocrino[i]))
                            {
                                pb.Checked = true;
                            }
                        }
                    }
                }



                if (Oesteo.Length > 0)
                {
                    RadioSimOsteo.Checked = true;
                }
                for (int i = 0; i < Oesteo.Length; i++)
                {
                    if (Oesteo[i].Length > 0)
                    {
                        foreach (var pb in this.Controls.OfType<CheckBox>())
                        {
                            if (pb.Name.Contains(Oesteo[i]))
                            {
                                pb.Checked = true;
                            }
                        }
                    }
                }



                if (Neuro.Length > 0)
                {
                    RadioSimNeuro.Checked = true;
                }
                for (int i = 0; i < Neuro.Length; i++)
                {
                    if (Neuro[i].Length > 0)
                    {
                        foreach (var pb in this.Controls.OfType<CheckBox>())
                        {
                            if (pb.Name.Contains(Neuro[i]))
                            {
                                pb.Checked = true;
                            }
                        }
                    }
                }


                if (Renal.Length > 0)
                {
                    RadioSimRenal.Checked = true;
                }
                for (int i = 0; i < Renal.Length; i++)
                {
                    if (Renal[i].Length > 0)
                    {
                        foreach (var pb in this.Controls.OfType<CheckBox>())
                        {
                            if (pb.Name.Contains(Renal[i]))
                            {
                                pb.Checked = true;
                            }
                        }
                    }
                }

                
                for (int i = 0; i < Habitos.Length; i++)
                {
                    if (Habitos[i].Length > 0)
                    {
                        foreach (var pb in this.Controls.OfType<CheckBox>())
                        {
                            if (pb.Name.Contains(Habitos[i]))
                            {
                                pb.Checked = true;
                            }
                        }
                    }
                }




            }
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
            DateTime Datacirurgia= DateTime.Now;
            DateTime Datainternacao=DateTime.Now;
            DateTime Datafratura= DateTime.Now;
            DateTime Dataacidente= DateTime.Now;
            bool erro = false;
            //Cirurgia
            if (RadioSimCirurgia.Checked)
            {
                Cirurgia = "S";
                try
                {
                    Datacirurgia = Convert.ToDateTime(DataCirurgia.Text);
                }
                catch
                {
                    erro = true;
                    MetroMessageBox.Show(this, "Favor preencher a data de cirurgia!", "Atenção !", MessageBoxButtons.OK,
               MessageBoxIcon.Hand);
                }

            }
            else
            {
                Cirurgia = "N";
                Datacirurgia = DateTime.Now;
            }
            //Internação
            if (RadioSimInternacao.Checked)
            {
                Internacao = "S";
                try
                {
                    Datainternacao = Convert.ToDateTime(DataInternacao.Text);
                }
                catch
                {
                    erro = true;
                    MetroMessageBox.Show(this, "Favor preencher a data de internação!", "Atenção !", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
                }
            }
            else
            {
                Internacao = "N";
                Datainternacao = DateTime.Now;
            }
            //Fratura
            if (RadioFraturaSim.Checked)
            {
                Fraturas = "S";
                try
                {
                    Datafratura = Convert.ToDateTime(DataFratura.Text);
                    
                }
                catch
                {
                    erro = true;
                    MetroMessageBox.Show(this, "Favor preencher a data da fratura!", "Atenção !", MessageBoxButtons.OK,
               MessageBoxIcon.Hand);
                }
            }
            else
            {
                Fraturas = "N";
                Datafratura = DateTime.Now;
            }

            //Alergia
            if (RadioAlergiaSim.Checked)
            {
                Alergias = "S";
                if (TextAlergia.Text.Length == 0)
                {
                    erro = true;
                    MetroMessageBox.Show(this, "Favor preencher a alergia!", "Atenção !", MessageBoxButtons.OK,
               MessageBoxIcon.Hand);
                }
            }
            else
            {
                Alergias = "N";
            }
            //Acidente
            if (RadioSimAcidente.Checked)
            {
                AcidenteTrabalho = "S";
                try
                {
                    Dataacidente = Convert.ToDateTime(DataAcidente.Text);

                }
                catch {
                    erro = true;
                    MetroMessageBox.Show(this, "Favor preencher a data do acidente!", "Atenção !", MessageBoxButtons.OK,
               MessageBoxIcon.Hand);
                }
            }
            else
            {
                AcidenteTrabalho = "N";
                Dataacidente = DateTime.Now;
            }

            //afastamento
            if (RadioSimAfastamento.Checked)
            {
                AfastamentoAcidente = "S";
                if (TextAfastamentoAcidente.Text.Length == 0)
                {
                    erro = true;
                    MetroMessageBox.Show(this, "Favor preencher a quantidade de dias afastado!", "Atenção !", MessageBoxButtons.OK,
               MessageBoxIcon.Hand);
                }
            }
            else
            {
                AfastamentoAcidente = "N";
            }
            //previdencia
            if (RadioPrevidenciaSim.Checked)
            {
                AfastamentoPrevidencia = "S";
                if (TextAfastamentoPrevidencia.Text.Length == 0)
                {
                    erro = true;
                    MetroMessageBox.Show(this, "Favor preencher a quantidade de dias de afastamento pela previdencia!", "Atenção !", MessageBoxButtons.OK,
               MessageBoxIcon.Hand);
                }
            }
            else
            {
                AfastamentoPrevidencia = "N";
            }

            //Respiratoria
            if (Bronquite.Checked)
            {
                Respiratoria = Respiratoria + Bronquite.Text + ";";
            }
            if (Asma.Checked)
            {
                Respiratoria = Respiratoria + Asma.Text + ";";
            }
            if (Rinite.Checked)
            {
                Respiratoria = Respiratoria + Rinite.Text + ";";
            }
            if (Sinusite.Checked)
            {
                Respiratoria = Respiratoria + Sinusite.Text + ";";
            }
            if (TextRespiratoria.Text.Length > 0)
            {
                Respiratoria = Respiratoria + TextRespiratoria.Text + ";";
            }

            //Gastro
            if (Gastrite.Checked)
            {
                Gastro = Gastro + Gastrite.Text + ";";
            }
            if (Ulcera.Checked)
            {
                Gastro = Gastro + Ulcera.Text + ";";
            }
            if (Diarreia.Checked)
            {
                Gastro = Gastro + Diarreia.Text + ";";
            }
            if (Constipacao.Checked)
            {
                Gastro = Gastro + Constipacao.Text + ";";
            }
            if (TextGastro.Text.Length > 0)
            {
                Gastro = Gastro + TextGastro.Text + ";";
            }


            //cardiaca
            if (Arritimia.Checked)
            {
                Cardiaca = Cardiaca + Arritimia.Text + ";";
            }
            if (Hipertensao.Checked)
            {
                Cardiaca = Cardiaca + Hipertensao.Text + ";";
            }
            if (Insuficiencia.Checked)
            {
                Cardiaca = Cardiaca + Insuficiencia.Text + ";";
            }
            if (TextCardio.Text.Length > 0)
            {
                Cardiaca = Cardiaca + TextCardio.Text + ";";
            }


            //Endocrino
            if (Diabetes.Checked)
            {
                Endocrino = Endocrino + Diabetes.Text + ";";
            }
            if (Hipotireodismo.Checked)
            {
                Endocrino = Endocrino + Hipotireodismo.Text + ";";
            }
            if (Hipertireodismo.Checked)
            {
                Endocrino = Endocrino + Hipertireodismo.Text + ";";
            }
            if (TextEndocrino.Text.Length > 0)
            {
                Endocrino = Endocrino + TextEndocrino.Text + ";";
            }


            //Osso
            if (Coluna.Checked)
            {
                Osseo = Osseo + Coluna.Text + ";";
            }
            if (Ombro.Checked)
            {
                Osseo = Osseo + Ombro.Text + ";";
            }
            if (Bracos.Checked)
            {
                Osseo = Osseo + Bracos.Text + ";";
            }
            if (Joelhos.Checked)
            {
                Osseo = Osseo + Joelhos.Text + ";";
            }
            if (Mao.Checked)
            {
                Osseo = Osseo + Mao.Text + ";";
            }
            if (TextOsteo.Text.Length > 0)
            {
                Osseo = Osseo + TextOsteo.Text + ";";
            }

            //Neuro
            var Neuro = "";
            if (Eplepsia.Checked)
            {
                Neuro = Neuro + Eplepsia.Text + ";";
            }
            if (Convulsao.Checked)
            {
                Neuro = Neuro + Convulsao.Text + ";";
            }
            if (Enxaqueca.Checked)
            {
                Neuro = Neuro + Enxaqueca.Text + ";";
            }
            if (Traumas.Checked)
            {
                Neuro = Neuro + Traumas.Text + ";";
            }
            if (Avc.Checked)
            {
                Neuro = Neuro + Avc.Text + ";";
            }
            if (TextOutraNeuro.Text.Length > 0)
            {
                Neuro = Neuro + TextOutraNeuro.Text + ";";
            }


            //Renal
            var Renal = "";
            if (Colica.Checked)
            {
                Renal = Renal + Colica.Text + ";";
            }
            if (Calculo.Checked)
            {
                Renal = Renal + Calculo.Text + ";";
            }
            if (Infeccao.Checked)
            {
                Renal = Renal + Infeccao.Text + ";";
            }
            if (TextOutraRenal.Text.Length > 0)
            {
                Renal = Renal + TextOutraRenal.Text + ";";
            }


            //Habitos de Vida
            var Habitos = "";
            if (Tabagismo.Checked)
            {
                Habitos = Habitos + Tabagismo.Text + ";";
            }
            if (Alcool.Checked)
            {
                Habitos = Habitos + Alcool + ";";
            }
            if (TextOutrasDrogas.Text.Length > 0)
            {
                Habitos = Habitos + TextOutrasDrogas.Text + ";";
            }


            //Atividade Fisica
            var Atividade = "";
            if (RadioAtividade.Checked)
            {
                Atividade = "S";
            }
            else
            {
                Atividade = "N";
            }
            if (!erro)
            {
                CadastraQuestionario.CadastraQuestionario(IdFuncionarioQuestiona, TextQueixa.Text, Cirurgia, Datacirurgia, TextCirurgia.Text, Fraturas, Datafratura, Internacao, TextInternacao.Text, Datainternacao, Alergias, TextAlergia.Text, Respiratoria, Gastro, Cardiaca, Endocrino, Osseo, TextHistorico.Text, AcidenteTrabalho, Dataacidente, AfastamentoAcidente, AfastamentoPrevidencia, TextAfastamentoAcidente.Text ,TextAfastamentoPrevidencia.Text, Neuro, Renal, Habitos, Atividade, FrequenciaAtividade.Value.ToString());
                MetroMessageBox.Show(this, "Questionário cadastrado com sucesso", "Sucesso !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
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
                Coluna.Visible = true;
                Ombro.Visible = true;
                Bracos.Visible = true;
                Joelhos.Visible = true;
                Mao.Visible = true;
                LabelOsteo.Visible = true;
                TextOsteo.Visible = true;
            }
            else
            {
                Coluna.Visible = false;
                Ombro.Visible = false;
                Bracos.Visible = false;
                Joelhos.Visible = false;
                Mao.Visible = false;
                LabelOsteo.Visible = false;
                TextOsteo.Visible = false;
            }
        }

        private void RadioNaoNeuro_CheckedChanged(object sender, EventArgs e)
        {
            if (!RadioNaoNeuro.Checked)
            {
                Eplepsia.Visible = true;
                Convulsao.Visible = true;
                Enxaqueca.Visible = true;
                Traumas.Visible = true;
                Avc.Visible = true;
                LabelOutraNeuro.Visible = true;
                TextOutraNeuro.Visible = true;
            }
            else
            {
                Eplepsia.Visible = false;
                Convulsao.Visible = false;
                Enxaqueca.Visible = false;
                Traumas.Visible = false;
                Avc.Visible = false;
                LabelOutraNeuro.Visible = false;
                TextOutraNeuro.Visible = false;
            }
        }

        private void RadioNaoRenal_CheckedChanged(object sender, EventArgs e)
        {
            if (!RadioNaoRenal.Checked)
            {
                Colica.Visible = true;
                Calculo.Visible = true;
                Infeccao.Visible = true;
                LabelOutraRenal.Visible = true;
                TextOutraRenal.Visible = true;
            }
            else
            {
                Colica.Visible = false;
                Calculo.Visible = false;
                Infeccao.Visible = false;
                LabelOutraRenal.Visible = false;
                TextOutraRenal.Visible = false;
            }
        }
    }
}
