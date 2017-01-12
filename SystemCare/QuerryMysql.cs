using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SystemCare
{
    internal class QuerryMysql
    {
        private static string IdEmpresaEditar = "";
        private static string NomeSetor = "";
        private static string IdFuncionario = "";
        private static string IdFuncionarioNova = "";
        //192.168.0.101
        private readonly MySqlConnection Com =
            new MySqlConnection("Server =localhost ; Database=medseg;Uid=root;Pwd=chinchila@acida12244819");

        public bool Login(string Usuario, string Senha)
        {
            Com.Open();
            var SelecionaUsuario =
                new MySqlCommand("SELECT * FROM usuarios WHERE login='" + Usuario + "' AND senha=MD5('" + Senha + "')",
                    Com);
            var LeitorUsuario = new MySqlDataAdapter(SelecionaUsuario);
            var TabelaUsuario = new DataTable();
            LeitorUsuario.Fill(TabelaUsuario);
            if (TabelaUsuario.Rows.Count > 0)
            {
                Com.Close();
                return true;
            }
            Com.Close();
            return false;
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

        public void CadastraEmpresa(string Nome, string Endereco, string Cnpj, int QuantidadeFuncionario,
            string Telefone, string Email, string IdCnae, int Risco)
        {
            Com.Open();
            var InserirEmpresa =
                new MySqlCommand(
                    "INSERT INTO empresas (nome,endereco,cnpj,quantidadefuncionario,telefone,email,idcnae,risco) VALUES('" +
                    Nome + "','" + Endereco + "','" + Cnpj + "'," + QuantidadeFuncionario + ",'" + Telefone + "','" +
                    Email + "','" + IdCnae + "'," + Risco + ")", Com);
            InserirEmpresa.ExecuteNonQuery();
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

        public DataTable RecuperaDadosEmpresa()
        {
            Com.Open();
            var SelecionaEmpresa =
                new MySqlCommand(
                    "SELECT nome,endereco, cnpj,quantidadefuncionario,telefone,email,idcnae,risco FROM empresas WHERE id=" +
                    IdEmpresaEditar + ";", Com);
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

        public void EditarEmpresa(string Nome, string Endereco, string Cnpj, int QuantidadeFuncionario, string Telefone,
            string Email, string IdCnae, int Risco)
        {
            Com.Open();
            var EditarEmpresa =
                new MySqlCommand(
                    "UPDATE empresas SET nome ='" + Nome + "' ,endereco='" + Endereco + "',cnpj='" + Cnpj +
                    "',quantidadefuncionario=" + QuantidadeFuncionario + ",telefone='" + Telefone + "',email='" + Email +
                    "',idcnae='" + IdCnae + "',risco=" + Risco + " WHERE id=" + IdEmpresaEditar + ";", Com);
            EditarEmpresa.ExecuteNonQuery();
            SetEmpresa("");
            Com.Close();
        }

        public void ExcluirEmpresa(string IdEmpresa)
        {
            Com.Open();
            var InserirEmpresa =
                new MySqlCommand("UPDATE empresas set excluido='S' WHERE id=" + IdEmpresa + ";", Com);
            InserirEmpresa.ExecuteNonQuery();
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

        public void CadastrarFuncao(string NomeFuncao, string IdCbo, string IdRiscos, string IdSetor)
        {
            Com.Open();
            var CadastrarFuncao =
                new MySqlCommand(
                    "INSERT INTO funcoes (idsetor,nome,idrisco,idcbo) VALUE(" + IdSetor + ",'" + NomeFuncao + "','" +
                    IdRiscos + "'," + IdCbo + ")", Com);
            CadastrarFuncao.ExecuteNonQuery();
            Com.Close();
        }

        public void CadastrarSetor(string IdEmpresa, string NomeSetor)
        {
            Com.Open();
            var CadastraSetor =
                new MySqlCommand("INSERT INTO setores (idempresa,nome) VALUES(" + IdEmpresa + ",'" + NomeSetor + "')",
                    Com);
            CadastraSetor.ExecuteNonQuery();
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
            Com.Close();
        }

        public void ExcluirFuncao(string IdFuncao)
        {
            Com.Open();
            var ExcluiFuncao =
                new MySqlCommand("UPDATE funcoes set excluido='S' WHERE id=" + IdFuncao + ";", Com);
            ExcluiFuncao.ExecuteNonQuery();
            Com.Close();
        }

        public void ExcluirFuncionario(string IdFuncionario)
        {
            Com.Open();
            var ExcluiFuncionario =
                new MySqlCommand("UPDATE funcionarios set excluido='S' WHERE id=" + IdFuncionario + ";", Com);
            ExcluiFuncionario.ExecuteNonQuery();
            Com.Close();
        }

        public void CadastraFuncionario(string Nome, string Idade, string Sexo, decimal Altura, decimal Peso, string Imc,
            string Cpf, string Identidade, string Telefone, DateTime DataNascimento, string Naturalidade,
            string IdFuncao)
        {
            Com.Open();
            var InserirFuncionario =
                new MySqlCommand(
                    "insert into funcionarios (nome,idade,sexo,altura,peso,imc,cpf,identidade,telefone,datanascimento,naturalidade,idfuncao) VALUES ('" +
                    Nome + "'," + Idade + ",'" + Sexo + "','" + Altura + "','" + Peso + "'," + Imc + ",'" +
                    Cpf.Replace(',', '.') + "','" +
                    Identidade + "','" + Telefone + "','" + DataNascimento.Date.ToString("yyyy-MM-dd") + "','" +
                    Naturalidade + "'," + IdFuncao + ")", Com);
            InserirFuncionario.ExecuteNonQuery();
            Com.Close();
        }

        public void AtualizaFuncionario(string IdFuncionario, string Nome, string Idade, string Sexo, decimal Altura,
            decimal Peso, string Imc, string Cpf, string Identidade, string Telefone, DateTime DataNascimento,
            string Naturalidade, string IdFuncao)
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
                    Naturalidade + "',idfuncao=" + IdFuncao + " WHERE id=" + IdFuncionario + ";", Com);
            InserirFuncionario.ExecuteNonQuery();
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

        public void CadastraHistorico(string Idfuncionario, string Apto, string ModalidadeExame, string TipoExame,
            string IdFuncao)
        {
            Com.Open();
            var InserirHistorico =
                new MySqlCommand(
                    "INSERT INTO historicos (idfuncionario,apto,modalidadeexame,tipoexame,idfuncao,datadoexame) VALUES(" +
                    Idfuncionario + ",'" + Apto + "','" + ModalidadeExame + "','" + TipoExame + "'," + IdFuncao +
                    ",NOW())", Com);
            InserirHistorico.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable SelecionaHistoricoFuncionario(string IdFuncionario)
        {
            Com.Open();
            MySqlCommand SelecionaHistorico = new MySqlCommand("select c.id,a.nome,b.descricao,c.datadoexame,c.apto from funcionarios a,examesmedicos b, historicos c where a.id=c.idfuncionario AND b.id=c.tipoexame AND c.idfuncionario="+IdFuncionario+";",Com);
            MySqlDataAdapter LeitorHistorico = new MySqlDataAdapter(SelecionaHistorico);
            DataTable TabelaHistorico = new DataTable();
            LeitorHistorico.Fill(TabelaHistorico);
            Com.Close();
            return TabelaHistorico;
        }
        public void AtualizaHistoricoFuncionario(string IdHistorico,string Apto)
        {
            Com.Open();
            MySqlCommand AtualizaHistorico = new MySqlCommand("UPDATE historicos SET apto='"+Apto+"' WHERE id="+IdHistorico+";", Com);
            AtualizaHistorico.ExecuteNonQuery();
            Com.Close();
            
        }
    }
}