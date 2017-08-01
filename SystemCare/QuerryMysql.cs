using System;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Text;
using System.IO;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Collections;

namespace SystemCare
{
    internal class QuerryMysql
    {
        private static string IdEmpresaEditar = "";
        private static string IdEmpresaRelatorio = "";
        private static string NomeSetor = "";
        private static string IdFuncionario = "";
        private static string IdFuncionarioNova = "";
        private static string IdUsuario = "";
        private static string IdConsulta = "";
        private static string IdFuncaoRelatorio = "";
        private static string ExameRelatorio = ""; 

        //192.168.1.200
        private readonly MySqlConnection Com =
            new MySqlConnection("Server =localhost; Database=medseg;Uid=root;Pwd=chinchila@acida12244819");

        
        public void SetIdConsulta(string Idconsulta)
        {
            IdConsulta = Idconsulta;
        }
        public string GetIdConsulta()
        {
            return IdConsulta;
        }

        public string Login(string Usuario, string Senha)
        {
            try
            {
                Com.Open();
            }
            catch
            {
                return "Banco";
            }
            var SelecionaUsuario =
                new MySqlCommand("SELECT * FROM usuarios WHERE login='" + Usuario + "' AND senha=MD5('" + Senha + "')",
                    Com);
            var LeitorUsuario = new MySqlDataAdapter(SelecionaUsuario);
            var TabelaUsuario = new DataTable();
            LeitorUsuario.Fill(TabelaUsuario);
            if (TabelaUsuario.Rows.Count > 0)
            {
                Com.Close();
                IdUsuario = TabelaUsuario.Rows[0]["id"].ToString();
                return "true";
            }
            Com.Close();
            return "false";
        }

        public DataTable BuscaCnae(string ValorDigitado)
        {
            Com.Open();
            var SelecionaCnae =
                new MySqlCommand(
                    "SELECT cnae as CNAE,descricao as DESCRIÇÃO FROM cnae WHERE cnae LIKE '%" + ValorDigitado +
                    "%' OR descricao LIKE'%" + ValorDigitado + "%';", Com);
            var LeitorCnae = new MySqlDataAdapter(SelecionaCnae);
            var TabelaCnae = new DataTable();
            LeitorCnae.Fill(TabelaCnae);
            Com.Close();
            return TabelaCnae;
        }
        public DataTable RetornaQuestionarioFuncionario(string IdFuncionario)
        {
            Com.Open();
            var SelecionaCnae =
                new MySqlCommand(
                    "SELECT a.id,b.nome,a.dataquestionario FROM atendimentosmedicos a,funcionarios b WHERE a.idfuncionario=b.id AND a.idfuncionario=" + IdFuncionario +
                    ";", Com);
            var LeitorCnae = new MySqlDataAdapter(SelecionaCnae);
            var TabelaCnae = new DataTable();
            LeitorCnae.Fill(TabelaCnae);
            Com.Close();
            return TabelaCnae;
        }
        public DataTable RetornaDadosQuestionarioFuncionario(string IdQuestionario)
        {
            Com.Open();
            var SelecionaCnae =
                new MySqlCommand(
                    "SELECT a.*,b.peso,b.altura,b.imc, b.nome,c.descricao FROM atendimentosmedicos a,funcionarios b, examesmedicos c WHERE c.id=a.tipoexame and a.idfuncionario=b.id AND a.id=" + IdQuestionario + ";", Com);
            var LeitorCnae = new MySqlDataAdapter(SelecionaCnae);
            var TabelaCnae = new DataTable();
            LeitorCnae.Fill(TabelaCnae);
            Com.Close();
            return TabelaCnae;
        }
        public DataTable BuscaCnaeEditar(string ValorDigitado)
        {
            Com.Open();
            var SelecionaCnae =
                new MySqlCommand(
                    "SELECT id as ID,cnae as CNAE,descricao as DESCRIÇÃO FROM cnae WHERE cnae LIKE '%" + ValorDigitado +
                    "%' OR descricao LIKE'%" + ValorDigitado + "%';", Com);
            var LeitorCnae = new MySqlDataAdapter(SelecionaCnae);
            var TabelaCnae = new DataTable();
            LeitorCnae.Fill(TabelaCnae);
            Com.Close();
            return TabelaCnae;
        }

        public void CadastraEmpresa(string Nome, string Endereco, string Cnpj, int QuantidadeFuncionario,
            string Telefone, string Email, string IdCnae, string Servicos,string Medico,string Crm)
        {
            Com.Open();
            var InserirEmpresa =
                new MySqlCommand(
                    "INSERT INTO empresas (nome,endereco,cnpj,quantidadefuncionario,telefone,email,idcnae,servicoprestado,medicoexaminador,crmmedico) VALUES('" +
                    Nome + "','" + Endereco + "','" + Cnpj + "'," + QuantidadeFuncionario + ",'" + Telefone + "','" +
                    Email + "','" + IdCnae + "','" + Servicos + "','"+Medico+"','"+Crm+"')", Com);
            InserirEmpresa.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro da empresa " + Nome + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();

        }

        public DataTable BuscaEmpresa(string ValorDigitado)
        {
            Com.Open();
            var SelecionaEmpresa =
                new MySqlCommand(
                    "SELECT id as ID, nome as NOME, cnpj as CNPJ,idcnae as CNAE FROM empresas WHERE excluido='N' AND nome LIKE '%" +
                    ValorDigitado + "%' OR cnpj LIKE'%" + ValorDigitado + "%';", Com);
            var LeitorEmpresa = new MySqlDataAdapter(SelecionaEmpresa);
            var TabelaEmpresa = new DataTable();
            LeitorEmpresa.Fill(TabelaEmpresa);
            Com.Close();
            return TabelaEmpresa;
        }

        public DataTable BuscaSetor(string ValorDigitado)
        {
            Com.Open();
            var SelecionaSetor =
                new MySqlCommand(
                    "SELECT a.id as ID, a.nome as 'NOME SETOR', b.nome as 'NOME EMPRESA' FROM setores a, empresas b  WHERE b.id = a.idempresa AND a.excluido='N' AND a.nome LIKE'%" +
                    ValorDigitado + "%' ;", Com);
            var LeitorSetor = new MySqlDataAdapter(SelecionaSetor);
            var TabelaSetor = new DataTable();
            LeitorSetor.Fill(TabelaSetor);
            Com.Close();
            return TabelaSetor;
        }

        public DataTable BuscaFuncao(string ValorDigitado)
        {
            Com.Open();
            var SelecionaSetor =
                new MySqlCommand(
                    "SELECT a.id as ID, a.nome as 'NOME FUNÇÃO', b.nome as 'NOME SETOR', c.nome as 'NOME EMPRESA' FROM funcoes a, setores b, empresas c  WHERE b.id = a.idsetor AND b.idempresa=c.id AND a.excluido='N' AND a.nome LIKE'%" +
                    ValorDigitado + "%' ;", Com);
            var LeitorSetor = new MySqlDataAdapter(SelecionaSetor);
            var TabelaSetor = new DataTable();
            LeitorSetor.Fill(TabelaSetor);
            Com.Close();
            return TabelaSetor;
        }

        public void SetEmpresa(string IdEmpresa)
        {
            IdEmpresaEditar = IdEmpresa;
        }

        public string GetEmpresa()
        {
            return IdEmpresaEditar;
        }

        public void SetEmpresaRelatorio(string IdEmpresa)
        {
            IdEmpresaRelatorio = IdEmpresa;
        }

        public string GetEmpresaRelatorio()
        {
            return IdEmpresaRelatorio;
        }

        public void SetSetor(string NomeSetorUsar)
        {
            NomeSetor = NomeSetorUsar;
        }

        public string GetSetor()
        {
            return NomeSetor;
        }

        public void SetFuncionario(string IdFuncionarioUsar)
        {
            IdFuncionario = IdFuncionarioUsar;
        }

        public string GetFuncionario()
        {
            return IdFuncionario;
        }

        public void SetFuncionarioNova(string IdFuncionarioUsar)
        {
            IdFuncionarioNova = IdFuncionarioUsar;
        }

        public string GetFuncionarioNova()
        {
            return IdFuncionarioNova;
        }
        public void SetFuncaoRelatorio(string IdFuncao)
        {
            IdFuncaoRelatorio = IdFuncao;
        }
        public string GetFuncaoRelatorio()
        {
            return IdFuncaoRelatorio;
        }

        public void SetExameRelatorio(string Exame)
        {
            ExameRelatorio = Exame;
        }
        public string GetExameRelatorio()
        {
            return ExameRelatorio;
        }

        public DataTable RecuperaDadosEmpresa()
        {
            Com.Open();
            var SelecionaEmpresa =
                new MySqlCommand(
                    "SELECT nome,endereco, cnpj,quantidadefuncionario,telefone,email,idcnae,risco, servicoprestado,medicoexaminador,crmmedico FROM empresas WHERE id=" +
                    IdEmpresaEditar + ";", Com);
            var LeitorEmpresa = new MySqlDataAdapter(SelecionaEmpresa);
            var TabelaEmpresa = new DataTable();
            LeitorEmpresa.Fill(TabelaEmpresa);
            Com.Close();
            return TabelaEmpresa;
        }
        public DataTable RecuperaDadosEmpresaAso(string Idempresa)
        {
            Com.Open();
            var SelecionaEmpresa =
                new MySqlCommand(
                    "SELECT nome,endereco, cnpj,quantidadefuncionario,telefone,email,idcnae,risco, servicoprestado,medicoexaminador,crmmedico FROM empresas WHERE id=" +
                    Idempresa + ";", Com);
            var LeitorEmpresa = new MySqlDataAdapter(SelecionaEmpresa);
            var TabelaEmpresa = new DataTable();
            LeitorEmpresa.Fill(TabelaEmpresa);
            Com.Close();
            return TabelaEmpresa;
        }
        public DataTable RecuperaPermissaoUsuario()
        {
            Com.Open();
            var SelecionaEmpresa =
                new MySqlCommand(
                    "SELECT permissao FROM usuarios WHERE id=" +
                    IdUsuario + ";", Com);
            var LeitorEmpresa = new MySqlDataAdapter(SelecionaEmpresa);
            var TabelaEmpresa = new DataTable();
            LeitorEmpresa.Fill(TabelaEmpresa);
            Com.Close();
            return TabelaEmpresa;
        }
        public DataTable RecuperaDadosFuncionario(string IdFuncionario)
        {
            Com.Open();
            var SelecionaFuncionario = new MySqlCommand("SELECT * FROM funcionarios WHERE id=" + IdFuncionario + ";",
                Com);
            var LeitorFuncionario = new MySqlDataAdapter(SelecionaFuncionario);
            var TabelaFuncionario = new DataTable();
            LeitorFuncionario.Fill(TabelaFuncionario);
            Com.Close();
            return TabelaFuncionario;
        }
        public bool ValidaCpf(string Cpf)
        {
            Com.Open();
            var SelecionaFuncionario = new MySqlCommand("SELECT count(id) FROM funcionarios WHERE cpf='" + Cpf.Replace(",",".") + "';",
                Com);
            var LeitorFuncionario = new MySqlDataAdapter(SelecionaFuncionario);
            var TabelaFuncionario = new DataTable();
            LeitorFuncionario.Fill(TabelaFuncionario);
            Com.Close();
            if (TabelaFuncionario.Rows[0][0].ToString().Equals("0"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable RecuperaDadosRiscos(string IdRisco)
        {
            Com.Open();
            var SelecionaFuncionario = new MySqlCommand("SELECT * FROM riscos WHERE id=" + IdRisco + ";",
                Com);
            var LeitorFuncionario = new MySqlDataAdapter(SelecionaFuncionario);
            var TabelaFuncionario = new DataTable();
            LeitorFuncionario.Fill(TabelaFuncionario);
            Com.Close();
            return TabelaFuncionario;
        }

        public void EditarEmpresa(string Nome, string Endereco, string Cnpj, int QuantidadeFuncionario, string Telefone,
            string Email, string IdCnae, string Servicos,string Medico,string Crm)
        {
            Com.Open();
            var EditarEmpresa =
                new MySqlCommand(
                    "UPDATE empresas SET nome ='" + Nome + "' ,endereco='" + Endereco + "',cnpj='" + Cnpj +
                    "',quantidadefuncionario=" + QuantidadeFuncionario + ",telefone='" + Telefone + "',email='" + Email +
                    "',idcnae='" + IdCnae + "', servicoprestado='" + Servicos + "',medicoexaminador='"+Medico+"', crmmedico='"+Crm+"' WHERE id=" +
                    IdEmpresaEditar + ";", Com);
            EditarEmpresa.ExecuteNonQuery();
            SetEmpresa("");
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Alterado dados da empresa " + Nome + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }
        public DataTable RetornaDadosRelacaoExame(string IdEmpresa,string IdFuncao)
        {
            Com.Open();
            MySqlCommand SelecionaDados = new MySqlCommand("select a.nome as Empresa, b.nome as Funcao from empresas a , funcoes b,setores c  WHERE a.id="+IdEmpresa+" AND b.id="+IdFuncao+" and c.idempresa=a.id AND c.id=b.idsetor",Com);
            MySqlDataAdapter LeitorDados = new MySqlDataAdapter(SelecionaDados);
            DataTable TabelaDados = new DataTable();
            LeitorDados.Fill(TabelaDados);
            Com.Close();
            return TabelaDados;
        }
        public DataTable RetornaRelacaoFuncaoEmpresa(string IdEmpresa)
        {
            Com.Open();
            MySqlCommand SelecionaFuncoes = new MySqlCommand("SELECT a.id as ID,a.nome as Função from funcoes a, empresas b, setores c where a.idsetor = c.id and c.idempresa=b.id and b.id="+IdEmpresa+";",Com);
            MySqlDataAdapter LeitorFuncoes = new MySqlDataAdapter(SelecionaFuncoes);
            DataTable TabelaFuncoes = new DataTable();
            LeitorFuncoes.Fill(TabelaFuncoes);
            Com.Close();
            return TabelaFuncoes;
        }

        public DataTable RetornaRelacaoExames(string IdFuncao)
        {
            Com.Open();
            MySqlCommand SelecionaFuncoes = new MySqlCommand("SELECT idrisco,modalidadeexame FROM funcoes WHERE id=" + IdFuncao + ";", Com);
            MySqlDataAdapter LeitorFuncoes = new MySqlDataAdapter(SelecionaFuncoes);
            DataTable TabelaFuncoes = new DataTable();
            LeitorFuncoes.Fill(TabelaFuncoes);


            var ExamesFuncao = TabelaFuncoes.Rows[0][1].ToString().Split(';');
            var Riscos = TabelaFuncoes.Rows[0][0].ToString().Split(';');


            DataTable TabelaExame = new DataTable();
            TabelaExame.Columns.Add("NomeExame",typeof(string));
            if (Riscos.Length >= 1)
            {
                for (int i = 1; i < Riscos.Length; i++)
                {
                    MySqlCommand SelecionaRisco = new MySqlCommand("SELECT relacaoexames FROM riscos WHERE id=" + Riscos[i] + ";", Com);
                    MySqlDataAdapter LeitorRisco = new MySqlDataAdapter(SelecionaRisco);
                    DataTable TabelaRisco = new DataTable();
                    LeitorRisco.Fill(TabelaRisco);

                    var ExameRisco = TabelaRisco.Rows[0][0].ToString().Split(';');

                    for(int j =1; j < ExameRisco.Length; j++)
                    {
                        try
                        {
                            MySqlCommand SelecionaExame = new MySqlCommand("SELECT descricao FROM modalidadeexames WHERE id=" + ExameRisco[j] + ";", Com);
                            MySqlDataAdapter LeitorExame = new MySqlDataAdapter(SelecionaExame);
                            DataTable TabelaExameBanco = new DataTable();
                            LeitorExame.Fill(TabelaExameBanco);
                            TabelaExame.Rows.Add(TabelaExameBanco.Rows[0][0].ToString());
                        }
                        catch
                        { }
                    }
                }
            }
            if (ExamesFuncao.Length > 0)
            {
                for (int j = 1; j < ExamesFuncao.Length; j++)
                {
                    try
                    {
                        MySqlCommand SelecionaExame2 = new MySqlCommand("SELECT descricao FROM modalidadeexames WHERE id=" + ExamesFuncao[j] + ";", Com);
                        MySqlDataAdapter LeitorExame2 = new MySqlDataAdapter(SelecionaExame2);
                        DataTable TabelaExameBanco2 = new DataTable();
                        LeitorExame2.Fill(TabelaExameBanco2);
                        TabelaExame.Rows.Add(TabelaExameBanco2.Rows[0][0].ToString());

                    }
                    catch
                    { }
                }
            }
            
            Com.Close();
            return TabelaExame;

                    }

        public void ExcluirEmpresa(string IdEmpresa)
        {
            Com.Open();
            var InserirEmpresa =
                new MySqlCommand("UPDATE empresas set excluido='S' WHERE id=" + IdEmpresa + ";", Com);
            InserirEmpresa.ExecuteNonQuery();

            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Excluido a empresa de ID:" + IdEmpresa + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable SelecionaRisco()
        {
            Com.Open();
            var SelecionaRiscos =
                new MySqlCommand(
                    "select a.id as ID, b.descricao as Grupo, a.descricao as Risco from riscos a, gruposriscos b where a.idgrupo=b.id",
                    Com);
            var LeitorRiscos = new MySqlDataAdapter(SelecionaRiscos);
            var TabelaRiscos = new DataTable();
            LeitorRiscos.Fill(TabelaRiscos);
            Com.Close();
            return TabelaRiscos;
        }

        public DataTable SelecionaEmpresa()
        {
            Com.Open();
            var SelecionaEmpresas = new MySqlCommand("select id, nome from empresas where excluido='N'", Com);
            var LeitorEmpresas = new MySqlDataAdapter(SelecionaEmpresas);
            var TabelaEmpresas = new DataTable();
            LeitorEmpresas.Fill(TabelaEmpresas);
            Com.Close();
            return TabelaEmpresas;
        }

        public DataTable SelecionaFuncao()
        {
            Com.Open();
            var SelecionaFuncao = new MySqlCommand("select id, nome from funcoes where excluido='N'", Com);
            var LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
            var TabelaFuncao = new DataTable();
            LeitorFuncao.Fill(TabelaFuncao);
            Com.Close();
            return TabelaFuncao;
        }

        public DataTable SelecionaSetorEmpresa(string IdEmpresa)
        {
            try
            {
                Com.Open();
                var SelecionaFuncao =
                    new MySqlCommand("select id, nome from setores where idempresa=" + IdEmpresa + " AND excluido='N'",
                        Com);
                var LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
                var TabelaFuncao = new DataTable();
                LeitorFuncao.Fill(TabelaFuncao);
                Com.Close();
                return TabelaFuncao;
            }
            catch
            {
                Com.Close();
                var TabelaNula = new DataTable();
                return TabelaNula;
            }
        }

        public DataTable SelecionaFuncaoEmpresa(string IdSetor)
        {
            try
            {
                Com.Open();
                var SelecionaFuncao =
                    new MySqlCommand("select id, nome from funcoes where idsetor=" + IdSetor + " AND excluido='N'",
                        Com);
                var LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
                var TabelaFuncao = new DataTable();
                LeitorFuncao.Fill(TabelaFuncao);
                Com.Close();
                return TabelaFuncao;
            }
            catch
            {
                Com.Close();
                var TabelaNula = new DataTable();
                return TabelaNula;
            }
        }

        public DataTable SelecionaRiscosFuncao(string IdFuncao)
        {
            try
            {
                Com.Open();
                var SelecionaFuncao =
                    new MySqlCommand(
                        "select a.descricao as 'GRUPO DO RISCO', b.descricao AS 'RISCO' from gruposriscos a , riscos b where b.idgrupo=a.id AND b.id=" +
                        IdFuncao + ";",
                        Com);
                var LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
                var TabelaFuncao = new DataTable();
                LeitorFuncao.Fill(TabelaFuncao);
                Com.Close();
                return TabelaFuncao;
            }
            catch
            {
                Com.Close();
                var TabelaNula = new DataTable();
                return TabelaNula;
            }
        }

        public DataTable SelecionaModalidadeExame()
        {
            Com.Open();
            var SelecionaFuncao = new MySqlCommand("select id, descricao from modalidadeexames", Com);
            var LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
            var TabelaFuncao = new DataTable();
            LeitorFuncao.Fill(TabelaFuncao);
            Com.Close();
            return TabelaFuncao;
        }

        public DataTable SelecionaExameMedico()
        {
            Com.Open();
            var SelecionaFuncao = new MySqlCommand("select id, descricao from examesmedicos", Com);
            var LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
            var TabelaFuncao = new DataTable();
            LeitorFuncao.Fill(TabelaFuncao);
            Com.Close();
            return TabelaFuncao;
        }

        public DataTable SelecionaSetor()
        {
            Com.Open();
            var SelecionaEmpresas = new MySqlCommand("select id, nome from setores where excluido='N'", Com);
            var LeitorEmpresas = new MySqlDataAdapter(SelecionaEmpresas);
            var TabelaEmpresas = new DataTable();
            LeitorEmpresas.Fill(TabelaEmpresas);
            Com.Close();
            return TabelaEmpresas;
        }

        public DataTable RetornaConsulta()
        {
            Com.Open();
            var SelecionaEmpresas = new MySqlCommand("select a.id, b.nome as FUNCIONÁRIO,a.dataconsulta as DATA from consultas a, funcionarios b where a.idfuncionario=b.id AND ativa='S'", Com);
            var LeitorEmpresas = new MySqlDataAdapter(SelecionaEmpresas);
            var TabelaEmpresas = new DataTable();
            LeitorEmpresas.Fill(TabelaEmpresas);
            Com.Close();
            return TabelaEmpresas;
        }
        public DataTable RetornaDadosConsulta(string Idconsulta)
        {
            Com.Open();
            var SelecionaEmpresas = new MySqlCommand("select * from consultas where id="+Idconsulta+";", Com);
            var LeitorEmpresas = new MySqlDataAdapter(SelecionaEmpresas);
            var TabelaEmpresas = new DataTable();
            LeitorEmpresas.Fill(TabelaEmpresas);
            Com.Close();
            return TabelaEmpresas;
        }
        public void CadastrarConsulta(string IdFuncionario,string TipoExame,string ModalidadeExame,string DataExame)
        {
            Com.Open();
            var CadastrarFuncao =
                new MySqlCommand(
                    "INSERT INTO consultas (idfuncionario,tipoexame,modalidadeexame,dataexame,dataconsulta) VALUE(" +IdFuncionario + ",'" + TipoExame + "','" +
                    ModalidadeExame + "','" + DataExame + "',now())", Com);
            CadastrarFuncao.ExecuteNonQuery();
            Com.Close();
        }
        public void EncerrarConsulta(string IdConsulta)
        {
            Com.Open();
            var CadastrarFuncao =
                new MySqlCommand(
                    "UPDATE consultas SET ativa='N' WHERE id="+IdConsulta+";", Com);
            CadastrarFuncao.ExecuteNonQuery();
            Com.Close();
        }
        public void CadastrarFuncao(string NomeFuncao, string IdCbo, string IdRiscos, string IdSetor)
        {
            Com.Open();
            var CadastrarFuncao =
                new MySqlCommand(
                    "INSERT INTO funcoes (idsetor,nome,idrisco,idcbo) VALUE(" + IdSetor + ",'" + NomeFuncao + "','" +
                    IdRiscos + "'," + IdCbo + ")", Com);
            CadastrarFuncao.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro da função " + NomeFuncao + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public void CadastrarFuncaoExame(string NomeFuncao, string IdCbo, string IdRiscos, string IdSetor, string Exames)
        {
            Com.Open();
            var CadastrarFuncao =
                new MySqlCommand(
                    "INSERT INTO funcoes (idsetor,nome,idrisco,idcbo,modalidadeexame) VALUE(" + IdSetor + ",'" +
                    NomeFuncao + "','" +
                    IdRiscos + "'," + IdCbo + ",'" + Exames + "')", Com);
            CadastrarFuncao.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro da função " + NomeFuncao + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public void CadastrarSetor(string IdEmpresa, string NomeSetor)
        {
            Com.Open();
            var CadastraSetor =
                new MySqlCommand("INSERT INTO setores (idempresa,nome) VALUES(" + IdEmpresa + ",'" + NomeSetor + "')",
                    Com);
            CadastraSetor.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro do setor " + NomeSetor + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable BuscarCbo(string ValorDigitado)
        {
            Com.Open();
            var BuscaCbo = new MySqlCommand("SELECT id,codigo FROM cbo WHERE codigo LIKE'%" + ValorDigitado + "%'", Com);
            var LeitorCbo = new MySqlDataAdapter(BuscaCbo);
            var TabelaCbo = new DataTable();
            LeitorCbo.Fill(TabelaCbo);
            Com.Close();
            return TabelaCbo;
        }

        public DataTable RetornaDadosSetor(string IdSetor)
        {
            Com.Open();
            var SelecionaSetor = new MySqlCommand("SELECT * FROM setores WHERE id=" + IdSetor + "", Com);
            var LeitorSetor = new MySqlDataAdapter(SelecionaSetor);
            var TabelaSetor = new DataTable();
            LeitorSetor.Fill(TabelaSetor);
            Com.Close();
            return TabelaSetor;
        }

        public DataTable RetornaDadosFuncao(string IdFuncao)
        {
            Com.Open();
            var SelecionaSetor = new MySqlCommand("SELECT * FROM funcoes WHERE id=" + IdFuncao + "", Com);
            var LeitorSetor = new MySqlDataAdapter(SelecionaSetor);
            var TabelaSetor = new DataTable();
            LeitorSetor.Fill(TabelaSetor);
            Com.Close();
            return TabelaSetor;
        }

        public string RetornaEmpresa(string IdEmpresa)
        {
            Com.Open();
            var SelecionaEmpresa = new MySqlCommand("SELECT nome FROM empresas WHERE id=" + IdEmpresa + "", Com);
            var LeitorEmpresa = new MySqlDataAdapter(SelecionaEmpresa);
            var TabelaEmpresa = new DataTable();
            LeitorEmpresa.Fill(TabelaEmpresa);
            Com.Close();
            return TabelaEmpresa.Rows[0][0].ToString();
        }

        public string RetornaFuncao(string IdFuncao)
        {
            Com.Open();
            var SelecionaFuncao = new MySqlCommand("SELECT nome FROM funcoes WHERE id=" + IdFuncao + "", Com);
            var LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
            var TabelaFuncao = new DataTable();
            LeitorFuncao.Fill(TabelaFuncao);
            Com.Close();
            return TabelaFuncao.Rows[0][0].ToString();
        }

        public string RetornaSetor(string IdSetor)
        {
            Com.Open();
            var SelecionaSetor = new MySqlCommand("SELECT nome FROM setores WHERE id=" + IdSetor + "", Com);
            var LeitorSetor = new MySqlDataAdapter(SelecionaSetor);
            var TabelaSetor = new DataTable();
            LeitorSetor.Fill(TabelaSetor);
            Com.Close();
            return TabelaSetor.Rows[0][0].ToString();
        }

        public string RetornaCbo(string IdCbo)
        {
            Com.Open();
            var SelecionaCbo = new MySqlCommand("SELECT id,codigo FROM cbo WHERE id=" + IdCbo + "", Com);
            var LeitorCbo = new MySqlDataAdapter(SelecionaCbo);
            var TabelaCbo = new DataTable();
            LeitorCbo.Fill(TabelaCbo);
            Com.Close();
            return TabelaCbo.Rows[0][0] + " | " + TabelaCbo.Rows[0][1];
        }


        public void ExcluirSetor(string IdSetor)
        {
            Com.Open();
            var InserirEmpresa =
                new MySqlCommand("UPDATE setores set excluido='S' WHERE id=" + IdSetor + ";", Com);
            InserirEmpresa.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Excluido setor de ID:" + IdSetor + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public void EditarSetor(string Nome, string IdEmpresa, string IdSetor)
        {
            Com.Open();
            var EditarEmpresa =
                new MySqlCommand(
                    "UPDATE setores SET nome ='" + Nome + "' ,idempresa=" + IdEmpresa + " WHERE id=" + IdSetor + ";",
                    Com);
            EditarEmpresa.ExecuteNonQuery();
            SetEmpresa("");
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Atualizado dados do setor " + NomeSetor + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public void EditarFuncao(string Nome, string IdSetor, string IdFuncao, string IdRiscos, string IdCbo)
        {
            Com.Open();
            var EditarEmpresa =
                new MySqlCommand(
                    "UPDATE funcoes SET nome ='" + Nome + "' ,idsetor=" + IdSetor + ", idrisco='" + IdRiscos +
                    "', idcbo=" + IdCbo + " WHERE id=" + IdFuncao + ";", Com);
            EditarEmpresa.ExecuteNonQuery();
            SetEmpresa("");
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Atualizado dados da função " + Nome + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }
        public void EditarFuncaoExames(string Nome, string IdSetor, string IdFuncao, string IdRiscos, string IdCbo, string Exames)
        {
            Com.Open();
            var EditarEmpresa =
                new MySqlCommand(
                    "UPDATE funcoes SET nome ='" + Nome + "' ,idsetor=" + IdSetor + ", idrisco='" + IdRiscos +
                    "', idcbo=" + IdCbo + ",modalidadeexame='" + Exames + "' WHERE id=" + IdFuncao + ";", Com);
            EditarEmpresa.ExecuteNonQuery();
            SetEmpresa("");
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Alterado dados da função " + Nome + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }
        public void ExcluirFuncao(string IdFuncao)
        {
            Com.Open();
            var ExcluiFuncao =
                new MySqlCommand("UPDATE funcoes set excluido='S' WHERE id=" + IdFuncao + ";", Com);
            ExcluiFuncao.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Excluido função de ID: " + IdFuncao + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public void ExcluirFuncionario(string IdFuncionario)
        {
            Com.Open();
            var ExcluiFuncionario =
                new MySqlCommand("UPDATE funcionarios set excluido='S' WHERE id=" + IdFuncionario + ";", Com);
            ExcluiFuncionario.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Excluido funcionário de ID:" + IdFuncionario + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public void CadastraFuncionario(string Nome, string Idade, string Sexo, string Altura, string Peso, string Imc,
            string Cpf, string Identidade, string Telefone, DateTime DataNascimento, string Naturalidade,
            string IdFuncao,string EstadoCivil,string Escolaridade)
        {
            Com.Open();
            var InserirFuncionario =
                new MySqlCommand(
                    "insert into funcionarios (nome,idade,sexo,altura,peso,imc,cpf,identidade,telefone,datanascimento,naturalidade,idfuncao,escolaridade,estadocivil) VALUES ('" +
                    Nome + "'," + Idade + ",'" + Sexo + "','" + Altura + "','" + Peso + "','" + Imc.Replace(',', '.') + "','" +
                    Cpf.Replace(',', '.') + "','" +
                    Identidade + "','" + Telefone + "','" + DataNascimento.Date.ToString("yyyy-MM-dd") + "','" +
                    Naturalidade + "'," + IdFuncao + ",'"+Escolaridade+"','"+EstadoCivil+"')", Com);
            InserirFuncionario.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro do funcionário " + Nome + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public void AtualizaFuncionario(string IdFuncionario, string Nome, string Idade, string Sexo, decimal Altura,
            decimal Peso, string Imc, string Cpf, string Identidade, string Telefone, DateTime DataNascimento,
            string Naturalidade, string IdFuncao,string EstadoCivil,string Escolaridade)
        {
            Com.Open();
            var InserirFuncionario =
                new MySqlCommand(
                    "UPDATE funcionarios SET nome='" +
                    Nome + "',idade=" + Idade + ",sexo='" + Sexo + "',altura='" + Altura.ToString().Replace(',', '.') +
                    "',peso='" + Peso.ToString().Replace(',', '.') + "',imc=" +
                    Imc + ",cpf='" + Cpf.Replace(',', '.') + "',identidade='" +
                    Identidade + "',telefone='" + Telefone + "',datanascimento='" +
                    DataNascimento.Date.ToString("yyyy-MM-dd") + "',naturalidade='" +
                    Naturalidade + "',idfuncao=" + IdFuncao + ",escolaridade='"+Escolaridade+"',estadocivil='"+EstadoCivil+"' WHERE id=" + IdFuncionario + ";", Com);
            InserirFuncionario.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Atualizado dados do funcionário " + Nome + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable BuscaFuncionario(string ValorDigitado)
        {
            Com.Open();
            var SelecionaFuncionario =
                new MySqlCommand(
                    "select a.id as ID,a.nome as 'NOME FUNCIONÁRIO',a.cpf as CPF,b.nome as 'NOME FUNÇÃO',d.nome as 'NOME EMPRESA' from funcionarios a , funcoes b, setores c , empresas d where c.idempresa=d.id AND a.idfuncao=b.id AND b.idsetor=c.id AND (a.nome like'%" +
                    ValorDigitado + "%'  or a.cpf like'%" + ValorDigitado + "%')", Com);
            var LeitorFuncionario = new MySqlDataAdapter(SelecionaFuncionario);
            var TabelaFuncionario = new DataTable();
            LeitorFuncionario.Fill(TabelaFuncionario);
            Com.Close();
            return TabelaFuncionario;
        }

        public byte[] CadastraHistorico(string Idfuncionario, string Apto, string ModalidadeExame, string TipoExame,
            string IdFuncao)
        {
            Com.Open();

            FileStream fs = new FileStream(@"C:\Aso\Teste.pdf", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);

            var InserirHistorico =
                new MySqlCommand(
                    "INSERT INTO historicos (idfuncionario,apto,modalidadeexame,tipoexame,idfuncao,datadoexame,aso) VALUES(" +
                    Idfuncionario + ",'" + Apto + "','" + ModalidadeExame + "','" + TipoExame + "'," + IdFuncao +
                    ",NOW(),@Data)", Com);
            InserirHistorico.Parameters.AddWithValue("@Data", bytes).DbType = DbType.Binary;
            InserirHistorico.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro do histórico do funcionário de ID:" + Idfuncionario + "',now())", Com);
            InserirLog.ExecuteNonQuery();

            long UltimaId = InserirHistorico.LastInsertedId;
            var SelecionaHistorico = new MySqlCommand("select aso from historicos where id=" + UltimaId + "", Com);
            var LeitorHistorico = new MySqlDataAdapter(SelecionaHistorico);
            var TabelaHistorico = new DataTable();
            LeitorHistorico.Fill(TabelaHistorico);

            byte[] AsoHistorico = (byte[])TabelaHistorico.Rows[0][0];
            Com.Close();
            return AsoHistorico;
           
        }

        public byte[] AtualizaHistorico(string IdHistorico)
        {
            Com.Open();

            FileStream fs = new FileStream(@"C:\Aso\Teste.pdf", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Byte[] bytes = br.ReadBytes((Int32)fs.Length);

            var InserirHistorico =
                new MySqlCommand(
                    "UPDATE historicos set aso=@Data WHERE id="+IdHistorico+"", Com);
            InserirHistorico.Parameters.AddWithValue("@Data", bytes).DbType = DbType.Binary;
            InserirHistorico.ExecuteNonQuery();
            


            var SelecionaHistorico = new MySqlCommand("select aso from historicos where id=" + IdHistorico + "", Com);
            var LeitorHistorico = new MySqlDataAdapter(SelecionaHistorico);
            var TabelaHistorico = new DataTable();
            LeitorHistorico.Fill(TabelaHistorico);

            byte[] AsoHistorico = (byte[])TabelaHistorico.Rows[0][0];
            Com.Close();
            return AsoHistorico;

        }



        public DataTable SelecionaHistoricoFuncionario(string IdFuncionario)
        {
            Com.Open();
            var SelecionaHistorico =
                new MySqlCommand(
                    "select c.id,a.nome,c.tipoexame as Exame,c.datadoexame,c.observacao,c.apto from funcionarios a, historicos c where a.id=c.idfuncionario  AND a.id=" +
                    IdFuncionario + ";", Com);
            var LeitorHistorico = new MySqlDataAdapter(SelecionaHistorico);
            var TabelaHistorico = new DataTable();
            LeitorHistorico.Fill(TabelaHistorico);
            Com.Close();
            return TabelaHistorico;
        }

        public string SelecionaModalidadeHistorico(string IdHistorico)
        {
            Com.Open();
            var SelecionaHistorico =
                new MySqlCommand(
                    "select modalidadeexame from historicos where id="+
                    IdHistorico + ";", Com);
            var LeitorHistorico = new MySqlDataAdapter(SelecionaHistorico);
            var TabelaHistorico = new DataTable();
            LeitorHistorico.Fill(TabelaHistorico);
            Com.Close();
            return TabelaHistorico.Rows[0][0].ToString();
        }

        public string SelecionaFuncaoHistorico(string IdHistorico)
        {
            Com.Open();
            var SelecionaHistorico =
                new MySqlCommand(
                    "select idfuncao from historicos where id=" +
                    IdHistorico + ";", Com);
            var LeitorHistorico = new MySqlDataAdapter(SelecionaHistorico);
            var TabelaHistorico = new DataTable();
            LeitorHistorico.Fill(TabelaHistorico);
            Com.Close();
            return TabelaHistorico.Rows[0][0].ToString();
        }

        public void AtualizaHistoricoFuncionario(string IdHistorico, string Apto)
        {
            Com.Open();
            var AtualizaHistorico =
                new MySqlCommand("UPDATE historicos SET apto='" + Apto + "' WHERE id=" + IdHistorico + ";", Com);
            AtualizaHistorico.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Atualizado histórico do funcionário " + IdHistorico + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable RetornaAsoHistorico(string IdHistorico)
        {
            Com.Open();
            var SelecionaDadosAso = new MySqlCommand("SELECT * FROM historicos WHERE id=" + IdHistorico + ";",
                Com);
            var LeitorAso = new MySqlDataAdapter(SelecionaDadosAso);
            var TabelaAso = new DataTable();
            LeitorAso.Fill(TabelaAso);
            Com.Close();
            return TabelaAso;
        }

        public string RetornaTipoExame(string IdTipoExame)
        {
            Com.Open();
            var SelecionaTipoExame =
                new MySqlCommand("SELECT descricao FROM examesmedicos WHERE id=" + IdTipoExame + ";", Com);
            var LeitorTipoExame = new MySqlDataAdapter(SelecionaTipoExame);
            var TabelaTipoExame = new DataTable();
            LeitorTipoExame.Fill(TabelaTipoExame);
            Com.Close();
            return TabelaTipoExame.Rows[0][0].ToString();
        }

        public string RetornaModalidadeExame(string IdTipoExame)
        {
            Com.Open();
            var SelecionaTipoExame =
                new MySqlCommand("SELECT descricao FROM modalidadeexames WHERE id=" + IdTipoExame + ";", Com);
            var LeitorTipoExame = new MySqlDataAdapter(SelecionaTipoExame);
            var TabelaTipoExame = new DataTable();
            LeitorTipoExame.Fill(TabelaTipoExame);
            Com.Close();
            return TabelaTipoExame.Rows[0][0].ToString();
        }

        public DataTable RetornaTodaModalidadeExame()
        {
            Com.Open();
            var SelecionaTipoExame =
                new MySqlCommand("SELECT id,descricao FROM modalidadeexames;", Com);
            var LeitorTipoExame = new MySqlDataAdapter(SelecionaTipoExame);
            var TabelaTipoExame = new DataTable();
            LeitorTipoExame.Fill(TabelaTipoExame);
            Com.Close();
            return TabelaTipoExame;
        }

        public void CadastrarAtestado(string Idfuncionario, string DataAtestado, string Cid, string Motivo,
            string DiasAfastafdo)
        {
            Com.Open();
            var CadastrarAtestado =
                new MySqlCommand(
                    "INSERT INTO atestados (idfuncionario,dataatestado,cid,motivo,diaafastado) VALUES(" + Idfuncionario +
                    ",'" + DataAtestado + "','" + Cid + "','" + Motivo + "'," + DiasAfastafdo + ")", Com);
            CadastrarAtestado.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro do atestado para o funcionário de ID: " + Idfuncionario + "',now)", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public void CadastrarVacina(string IdFuncionario, string DataAplicacao, string NomeVacina, string Reforco,
            string Dose)
        {
            Com.Open();
            var CadastrarVacina =
                new MySqlCommand(
                    "INSERT INTO vacinas(idfuncionario,nome,dataaplicacao,reforco,dose) VALUES(" + IdFuncionario + ",'" +
                    NomeVacina + "','" + DataAplicacao + "','" + Reforco + "'," + Dose + ")", Com);
            CadastrarVacina.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro da vacina do funcionário de ID: " + IdFuncionario + "',now())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable RetornaAtestados(string IdEmpresa, string MesReferencia,string AnoReferencia)
        {
            Com.Open();
            var SelecionaAtestados =
                new MySqlCommand(
                    "select a.nome as nome,b.nome as setor,c.nome as funcao,Date_format(d.dataatestado, '%d-%m-%Y') as dataatestado,d.cid,d.motivo,d.diaafastado from funcionarios a, setores b, funcoes c, atestados d WHERE d.idfuncionario=a.id AND a.idfuncao=c.id AND c.idsetor=b.id and b.idempresa=" +
                    IdEmpresa + " AND MONTH(d.dataatestado)=" + MesReferencia + " AND YEAR(d.dataatestado)="+AnoReferencia+";", Com);
            var LeitorAtestado = new MySqlDataAdapter(SelecionaAtestados);
            var TabelaAtestados = new DataTable();
            LeitorAtestado.Fill(TabelaAtestados);
            Com.Close();
            return TabelaAtestados;
        }

        public DataTable RetornaFuncionariosEmpresa(string IdEmpresa)
        {
            Com.Open();
            var SelecionaFuncionarios =
                new MySqlCommand(
                    "select a.nome as nome,b.nome as funcao from funcionarios a, funcoes b, setores c, empresas d where a.idfuncao=b.id and b.idsetor=c.id and c.idempresa=d.id and d.id=" +
                    IdEmpresa + " order by a.nome   asc;", Com);
            var LeitorFuncionario = new MySqlDataAdapter(SelecionaFuncionarios);
            var TabelaFuncionario = new DataTable();
            LeitorFuncionario.Fill(TabelaFuncionario);
            Com.Close();
            return TabelaFuncionario;
        }

        public DataTable RetornaVacinasFuncionarios(string IdFuncionario)
        {
            Com.Open();
            var SelecionaVacina =
                new MySqlCommand(
                    "select a.nome as nome,a.dose as dose, a.reforco as reforco, a.dataaplicacao as dataaplicacao from vacinas a, funcionarios b WHERE a.idfuncionario=b.id and a.idfuncionario=" +
                    IdFuncionario + " order by a.nome   asc;", Com);
            var LeitorVacina = new MySqlDataAdapter(SelecionaVacina);
            var TabelaVacina = new DataTable();
            LeitorVacina.Fill(TabelaVacina);
            Com.Close();
            return TabelaVacina;
        }

        public DataTable RetornaIdFuncionario(string NomeFuncionario)
        {
            Com.Open();
            var SelecionaVacina = new MySqlCommand("select id from funcionarios WHERE nome='" + NomeFuncionario + "';",
                Com);
            var LeitorVacina = new MySqlDataAdapter(SelecionaVacina);
            var TabelaVacina = new DataTable();
            LeitorVacina.Fill(TabelaVacina);
            Com.Close();
            return TabelaVacina;
        }

        public DataTable RetornaServicosPrestados()
        {
            Com.Open();
            var SelecionaServicos = new MySqlCommand("SELECT id,descricao FROM servicosprestados WHERE excluido='N'",
                Com);
            var LeitorServicos = new MySqlDataAdapter(SelecionaServicos);
            var TabelaServicos = new DataTable();
            LeitorServicos.Fill(TabelaServicos);
            Com.Close();
            return TabelaServicos;
        }

        public void CadastraUsuario(string Usuario, string Senha)
        {
            Com.Open();
            var InserirUsuario =
                new MySqlCommand("INSERT INTO usuarios (login,senha) VALUES('" + Usuario + "',MD5('" + Senha + "'))",
                    Com);
            InserirUsuario.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable RetornaUsuarios(string TextoPesquisa)
        {
            Com.Open();
            var SelecionaUsuarios =
                new MySqlCommand(
                    "SELECT id,login FROM usuarios WHERE login like'%" + TextoPesquisa + "%' AND excluido='N'", Com);
            var LeitorUsuarios = new MySqlDataAdapter(SelecionaUsuarios);
            var TabelaUsuarios = new DataTable();
            LeitorUsuarios.Fill(TabelaUsuarios);
            Com.Close();
            return TabelaUsuarios;
        }

        public void AtualizaUsuarios(string Usuario, string Senha, string Id)
        {
            Com.Open();
            var AtualizaUsuario =
                new MySqlCommand(
                    "UPDATE usuarios SET login='" + Usuario + "', senha=MD5('" + Senha + "') WHERE id=" + Id + "", Com);
            AtualizaUsuario.ExecuteNonQuery();
            Com.Close();
        }

        public void ExcluirUsuario(string Id)
        {
            Com.Open();
            var ExcluiFuncionario = new MySqlCommand("UPDATE usuarios SET excluido='S' WHERE id=" + Id + "", Com);
            ExcluiFuncionario.ExecuteNonQuery();
            Com.Close();
        }

        public void CadastraRisco(string Descricao, string IdGrupo, string Relacao)
        {
            Com.Open();
            var InserirRisco =
                new MySqlCommand(
                    "INSERT INTO riscos (descricao,idgrupo,relacaoexames) VALUES('" + Descricao + "'," + IdGrupo + " ,'" +
                    Relacao + "')", Com);
            InserirRisco.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable RetornaRisco(string TextoPesquisa)
        {
            Com.Open();
            var SelecionaRiscos =
                new MySqlCommand(
                    "SELECT id,descricao FROM riscos WHERE descricao like'%" + TextoPesquisa + "%' AND excluido='N'",
                    Com);
            var LeitorRiscos = new MySqlDataAdapter(SelecionaRiscos);
            var TabelaRiscos = new DataTable();
            LeitorRiscos.Fill(TabelaRiscos);
            Com.Close();
            return TabelaRiscos;
        }

        public void AtualizaRisco(string Descricao, string IdGrupo, string Id, string Relacao)
        {
            Com.Open();
            var AtualizaRiscos =
                new MySqlCommand(
                    "UPDATE riscos SET descricao='" + Descricao + "', idgrupo=" + IdGrupo + ",relacaoexames='" + Relacao +
                    "' WHERE id=" + Id + "", Com);
            AtualizaRiscos.ExecuteNonQuery();
            Com.Close();
        }

        public void ExcluirRisco(string Id)
        {
            Com.Open();
            var ExcluiRiscos = new MySqlCommand("UPDATE riscos SET excluido='S' WHERE id=" + Id + "", Com);
            ExcluiRiscos.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable RetornaGrupoRisco()
        {
            Com.Open();
            var SelecionaRiscos = new MySqlCommand("SELECT id,descricao FROM gruposriscos", Com);
            var LeitorRiscos = new MySqlDataAdapter(SelecionaRiscos);
            var TabelaRiscos = new DataTable();
            LeitorRiscos.Fill(TabelaRiscos);
            Com.Close();
            return TabelaRiscos;
        }

        public DataTable RetornaGrupoRiscoEditar(string Id)
        {
            Com.Open();
            var SelecionaRiscos = new MySqlCommand("SELECT idgrupo FROM riscos where id=" + Id + "", Com);
            var LeitorRiscos = new MySqlDataAdapter(SelecionaRiscos);
            var TabelaRiscos = new DataTable();
            LeitorRiscos.Fill(TabelaRiscos);
            Com.Close();
            return TabelaRiscos;
        }

        public string RetornaRelacaoExamesEditar(string Id)
        {
            Com.Open();
            var SelecionaRiscos = new MySqlCommand("SELECT relacaoexames FROM riscos where id=" + Id + "", Com);
            var LeitorRiscos = new MySqlDataAdapter(SelecionaRiscos);
            var TabelaRiscos = new DataTable();
            LeitorRiscos.Fill(TabelaRiscos);
            Com.Close();
            return TabelaRiscos.Rows[0][0].ToString();
        }

        public void CadastraQuestionario(string idfuncionario, string queixa, string cirurgiaanterior, DateTime datacirurgia, string nomecirurgia, string fratura, DateTime datatomografia, string internacao, string motivointernacao, DateTime datainternacao, string alergia, string descricaoalergia, string doencarespiratoria, string doencagastrointestinal, string doencacardiaca, string doencaendocrina, string doencaosteomusculares, string historiaocupacional, string acidentedetrabalho, DateTime dataacidente, string afastamentoacidente, string afastamentoinss, string periodoafastamento,string periodoafastamentoinss,string Neuro,string Renal,string Habitos,string Atividade,string Frequencia,string deficiencia, string qualdeficiencia,string qualatividade,string fisico,DateTime Data,string Exame )
        {
            Com.Open();
            MySqlCommand InserirQuesrtionario = new MySqlCommand("INSERT INTO atendimentosmedicos (idfuncionario,queixa ,cirurgiaanterior,datacirurgia,nomecirurgia,fratura,datatomografia,internacao ,motivointernacao ,datainternacao,alergia,descricaoalergia,doencarespiratoria,doencagastrointestinal,doencacardiaca,doencaendocrina,doencaosteomusculares,historiaocupacional,acidentedetrabalho,dataacidente,afastamentoacidente,afastamentoinss,periodoafastamento,periodoafastamentoinss,doencaneurologica,doencarenal,habitodevida,atividadefisica,frequenciaatividade,deficiencia,descricaodeficiencia,descricaoatividade,examefisico,dataquestionario,tipoexame) VALUES (" + idfuncionario + ",'" + queixa + "','" + cirurgiaanterior + "','" + datacirurgia.Date.ToString("yyyy/MM/dd") + "','" + nomecirurgia + "','" + fratura + "','" + datatomografia.Date.ToString("yyyy/MM/dd") + "','" + internacao + "','" + motivointernacao + "','" + datainternacao.Date.ToString("yyyy/MM/dd") + "','" + alergia + "','" + descricaoalergia + "','" + doencarespiratoria + "','" + doencagastrointestinal + "','" + doencacardiaca + "','" + doencaendocrina + "','" + doencaosteomusculares + "','" + historiaocupacional + "','" + acidentedetrabalho + "','" + dataacidente.Date.ToString("yyyy/MM/dd") + "','" + afastamentoacidente + "','" + afastamentoinss + "','" + periodoafastamento + "','"+periodoafastamentoinss+"','"+Neuro+"','"+Renal+"','"+Habitos+"','"+Atividade+"','"+Frequencia+"','"+deficiencia+"','"+qualdeficiencia+"','"+qualatividade+"','"+fisico+"','"+Data.Date.ToString("yyyy/MM/dd")+"',"+Exame+")", Com);
            InserirQuesrtionario.ExecuteNonQuery();
            Com.Close();
        }
        public string RetornaExameQuestionario(string Exame)
        {
            Com.Open();
            MySqlCommand SelecionaExame = new MySqlCommand("SELECT id FROM examesmedicos WHERE descricao='"+Exame+"'",Com);
            MySqlDataAdapter LeitorExame = new MySqlDataAdapter(SelecionaExame);
            DataTable TabelaExame = new DataTable();
            LeitorExame.Fill(TabelaExame);
            Com.Close();
            return TabelaExame.Rows[0]["id"].ToString();
        }

        public void CadastrarCbo(string Descricao)
        {
            Com.Open();
            MySqlCommand InserirCbo = new MySqlCommand("INSERT INTO cbo (codigo) VALUES('" + Descricao + "')", Com);
            InserirCbo.ExecuteNonQuery();
            Com.Close();
        }
        public void AtualizaCbo(string Descricao, string IdCbo)
        {
            Com.Open();
            MySqlCommand InserirCbo = new MySqlCommand("UPDATE cbo SET codigo='" + Descricao + "' where id=" + IdCbo + ";", Com);
            InserirCbo.ExecuteNonQuery();
            Com.Close();
        }
        public void CadastrarCnae(string Descricao, string Codigo)
        {
            Com.Open();
            MySqlCommand InserirCnae = new MySqlCommand("INSERT INTO cnae (cnae,descricao) VALUES('" + Codigo + "','" + Descricao + "')", Com);
            InserirCnae.ExecuteNonQuery();
            Com.Close();
        }
        public void AtualizaCnae(string Descricao, string Codigo, string IdCnae)
        {
            Com.Open();
            MySqlCommand InserirCnae = new MySqlCommand("UPDATE cnae SET cnae='" + Codigo + "',descricao='" + Descricao + "' where id=" + IdCnae + ";", Com);
            InserirCnae.ExecuteNonQuery();
            Com.Close();
        }
        public DataTable BuscaCbo(string Descricao)
        {
            Com.Open();
            MySqlCommand InserirCbo = new MySqlCommand("Select * FROM cbo where codigo LIKE'%" + Descricao + "%';", Com);
            MySqlDataAdapter SelecionaCbo = new MySqlDataAdapter(InserirCbo);
            DataTable TabelaCbo = new DataTable();
            SelecionaCbo.Fill(TabelaCbo);
            Com.Close();
            return TabelaCbo;

        }

        public void CadastrarExame(string Descricao)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("INSERT INTO examesmedicos (descricao) VALUES('" + Descricao + "')", Com);
            InserirExame.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro do exame medico " + Descricao + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();

        }
        public void CadastrarModalidadeExame(string Descricao)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("INSERT INTO modalidadeexames (descricao) VALUES('" + Descricao + "')", Com);
            InserirExame.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro da modalidade de exame " + Descricao + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();

        }
        public void EditarExame(string Descricao, string Id)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("UPDATE examesmedicos SET descricao='" + Descricao + "' WHERE id=" + Id + ";", Com);
            InserirExame.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Alterado dados de exames de descrição " + Descricao + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();

        }
        public void EditarModalidadeExame(string Descricao, string Id)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("UPDATE modalidadeexames SET descricao='" + Descricao + "' WHERE id=" + Id + ";", Com);
            InserirExame.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Alterado dados de modalidade de exame de ID: " + Id + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();

        }
        public void ExcluirExame(string Id)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("UPDATE examesmedicos SET excluido='S' WHERE id=" + Id + ";", Com);
            InserirExame.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Excluido exame de ID " + Id + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();

        }
        public void ExcluirModalidadeExame(string Id)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("UPDATE modalidadeexames SET excluido='S' WHERE id=" + Id + ";", Com);
            InserirExame.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Excluido modalidade de exame de ID " + Id + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();

        }
        public DataTable BuscarExame(string Descricao)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("SELECT id,descricao FROM examesmedicos WHERE descricao like'%" + Descricao + "%' AND excluido='N';", Com);
            MySqlDataAdapter SelecionaExame = new MySqlDataAdapter(InserirExame);
            DataTable ResultadoExames = new DataTable();
            SelecionaExame.Fill(ResultadoExames);
            Com.Close();
            return ResultadoExames;

        }
        public DataTable BuscarModalidadeExame(string Descricao)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("SELECT id,descricao FROM modalidadeexames WHERE descricao like'%" + Descricao + "%' AND excluido='N';", Com);
            MySqlDataAdapter SelecionaExame = new MySqlDataAdapter(InserirExame);
            DataTable ResultadoExames = new DataTable();
            SelecionaExame.Fill(ResultadoExames);
            Com.Close();
            return ResultadoExames;

        }

        public void CadastrarServicos(string Descricao)
        {
            Com.Open();
            MySqlCommand InserirServico = new MySqlCommand("INSERT INTO servicosprestados (descricao) VALUES('" + Descricao + "');", Com);
            InserirServico.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro de serviço " + Descricao + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public void EditarServicos(string Descricao, string IdServico)
        {
            Com.Open();
            MySqlCommand AtualizarServico = new MySqlCommand("UPDATE servicosprestados SET descricao ='" + Descricao + "' WHERE id=" + IdServico + ";", Com);
            AtualizarServico.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Alterado dados do serviço de descrição " + Descricao + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable BuscarServico(string Busca)
        {
            Com.Open();
            MySqlCommand BuscaServico = new MySqlCommand("select id as ID,descricao as DESCRIÇÃO from servicosprestados WHERE descricao like'%" + Busca + "%' AND excluido='S';", Com);
            MySqlDataAdapter LeitorServico = new MySqlDataAdapter(BuscaServico);
            DataTable TabelaServico = new DataTable();
            LeitorServico.Fill(TabelaServico);
            Com.Close();
            return TabelaServico;
        }

        public void ExcluirServico(string IdServico)
        {
            Com.Open();
            MySqlCommand ExcluirServico = new MySqlCommand("UPDATE servicosprestados SET excluido ='S' WHERE id=" + IdServico + ";", Com);
            ExcluirServico.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Excluido serviço de ID: " + IdServico + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable BuscarExameModalidade(string Busca)
        {
            Com.Open();
            MySqlCommand SelecionaExame = new MySqlCommand("SELECT id,descricao FROM examesmedicos where descricao like'%" + Busca + "%'", Com);
            MySqlCommand SelecionaExame2 = new MySqlCommand("SELECT id, descricao FROM modalidadeexames where descricao like'%" + Busca + "%'", Com);
            MySqlDataAdapter LeitorExame = new MySqlDataAdapter(SelecionaExame);
            MySqlDataAdapter LeitorExame2 = new MySqlDataAdapter(SelecionaExame2);
            DataTable TabelaExame = new DataTable();
            LeitorExame.Fill(TabelaExame);
            LeitorExame2.Fill(TabelaExame);
            Com.Close();
            return TabelaExame;

        }
        public string RecuperaDadosPreco(string IdExame)
        {
            Com.Open();
            MySqlCommand SelecionaExame = new MySqlCommand("SELECT valor FROM precosexames where idexame=" + IdExame + "", Com);
            MySqlDataAdapter LeitorExame = new MySqlDataAdapter(SelecionaExame);
            DataTable TabelaExame = new DataTable();
            LeitorExame.Fill(TabelaExame);
            Com.Close();
            try
            {
                return TabelaExame.Rows[0][0].ToString();
            }
            catch
            {
                return "";
            }

        }

        public void CadastrarPreco(string Valor, string IdExame)
        {
            Com.Open();
            MySqlCommand InserirPreco = new MySqlCommand("INSERT INTO precosexames (idexame,valor) VALUES(" + IdExame + ",'" + Valor.Replace(",", ".") + "')", Com);
            InserirPreco.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Cadastro do preço do exame de ID:" + IdExame + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }
        public void AtualizaPreco(string IdExame, string Valor)
        {
            Com.Open();
            MySqlCommand InserirPreco = new MySqlCommand("UPDATE precosexames  SET valor='" + Valor.Replace(",", ".") + "' WHERE idexame=" + IdExame + "", Com);
            InserirPreco.ExecuteNonQuery();
            var InserirLog = new MySqlCommand("INSERT INTO logs (idusuario,acao,data) VALUES(" + IdUsuario + ",'Alterado preço do exame de ID:" + IdExame + "',NOW())", Com);
            InserirLog.ExecuteNonQuery();
            Com.Close();
        }
        public string RemoveAccents(string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(letter) != System.Globalization.UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }
        public void CadastraDespesa(string Nome,string Valor, string Data)
        {
            Com.Open();
            MySqlCommand InserirDespesa = new MySqlCommand("INSERT INTO despesas (nome,valor,data) VALUES('" + Nome + "','" + Valor.Replace(',','.') + "','" + Convert.ToDateTime(Data).Date.ToString("yyyy/MM/dd") + "')", Com);
            InserirDespesa.ExecuteNonQuery();
            Com.Close();
        }
       


    }
}