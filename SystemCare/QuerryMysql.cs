using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SystemCare
{
    internal class QuerryMysql
    {
        private static string IdEmpresaEditar = "";
        private static string IdEmpresaRelatorio = "";
        private static string NomeSetor = "";
        private static string IdFuncionario = "";
        private static string IdFuncionarioNova = "";
        //192.168.1.200
        private readonly MySqlConnection Com =
            new MySqlConnection("Server =localhost; Database=medseg;Uid=root;Pwd=chinchila@acida12244819");

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
            string Telefone, string Email, string IdCnae, string Servicos)
        {
            Com.Open();
            var InserirEmpresa =
                new MySqlCommand(
                    "INSERT INTO empresas (nome,endereco,cnpj,quantidadefuncionario,telefone,email,idcnae,servicoprestado) VALUES('" +
                    Nome + "','" + Endereco + "','" + Cnpj + "'," + QuantidadeFuncionario + ",'" + Telefone + "','" +
                    Email + "','" + IdCnae + "','" + Servicos + "')", Com);
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

        public DataTable RecuperaDadosEmpresa()
        {
            Com.Open();
            var SelecionaEmpresa =
                new MySqlCommand(
                    "SELECT nome,endereco, cnpj,quantidadefuncionario,telefone,email,idcnae,risco, servicoprestado FROM empresas WHERE id=" +
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
            string Email, string IdCnae, string Servicos)
        {
            Com.Open();
            var EditarEmpresa =
                new MySqlCommand(
                    "UPDATE empresas SET nome ='" + Nome + "' ,endereco='" + Endereco + "',cnpj='" + Cnpj +
                    "',quantidadefuncionario=" + QuantidadeFuncionario + ",telefone='" + Telefone + "',email='" + Email +
                    "',idcnae='" + IdCnae + "', servicoprestado='" + Servicos + "' WHERE id=" +
                    IdEmpresaEditar + ";", Com);
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

        public void CadastrarFuncaoExame(string NomeFuncao, string IdCbo, string IdRiscos, string IdSetor, string Exames)
        {
            Com.Open();
            var CadastrarFuncao =
                new MySqlCommand(
                    "INSERT INTO funcoes (idsetor,nome,idrisco,idcbo,modalidadeexame) VALUE(" + IdSetor + ",'" +
                    NomeFuncao + "','" +
                    IdRiscos + "'," + IdCbo + ",'" + Exames + "')", Com);
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
        public void EditarFuncaoExames(string Nome, string IdSetor, string IdFuncao, string IdRiscos, string IdCbo,string Exames)
        {
            Com.Open();
            var EditarEmpresa =
                new MySqlCommand(
                    "UPDATE funcoes SET nome ='" + Nome + "' ,idsetor=" + IdSetor + ", idrisco='" + IdRiscos +
                    "', idcbo=" + IdCbo + ",modalidadeexame='"+Exames+"' WHERE id=" + IdFuncao + ";", Com);
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
            var SelecionaHistorico =
                new MySqlCommand(
                    "select c.id,a.nome,b.descricao,c.datadoexame,c.apto from funcionarios a,examesmedicos b, historicos c where a.id=c.idfuncionario AND b.id=c.tipoexame AND c.idfuncionario=" +
                    IdFuncionario + ";", Com);
            var LeitorHistorico = new MySqlDataAdapter(SelecionaHistorico);
            var TabelaHistorico = new DataTable();
            LeitorHistorico.Fill(TabelaHistorico);
            Com.Close();
            return TabelaHistorico;
        }

        public void AtualizaHistoricoFuncionario(string IdHistorico, string Apto)
        {
            Com.Open();
            var AtualizaHistorico =
                new MySqlCommand("UPDATE historicos SET apto='" + Apto + "' WHERE id=" + IdHistorico + ";", Com);
            AtualizaHistorico.ExecuteNonQuery();
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
            Com.Close();
        }

        public DataTable RetornaAtestados(string IdEmpresa, string MesReferencia)
        {
            Com.Open();
            var SelecionaAtestados =
                new MySqlCommand(
                    "select a.nome as nome,b.nome as setor,c.nome as funcao,Date_format(d.dataatestado, '%d-%m-%Y') as dataatestado,d.cid,d.motivo,d.diaafastado from funcionarios a, setores b, funcoes c, atestados d WHERE d.idfuncionario=a.id AND a.idfuncao=c.id AND c.idsetor=b.id and b.idempresa=" +
                    IdEmpresa + " AND MONTH(d.dataatestado)=" + MesReferencia + ";", Com);
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

        public void CadastraQuestionario(string idfuncionario, string queixa ,string cirurgiaanterior, DateTime datacirurgia, string nomecirurgia, string fratura, DateTime datatomografia, string internacao ,string motivointernacao ,DateTime datainternacao, string alergia,string descricaoalergia, string doencarespiratoria, string doencagastrointestinal, string doencacardiaca,string doencaendocrina,string  doencaosteomusculares, string historiaocupacional, string acidentedetrabalho, DateTime dataacidente, string afastamentoacidente, string afastamentoinss, string periodoafastamento)
        {
            Com.Open();
            MySqlCommand InserirQuesrtionario = new MySqlCommand("INSERT INTO atendimentosmedicos (idfuncionario,queixa ,cirurgiaanterior,datacirurgia,nomecirurgia,fratura,datatomografia,internacao ,motivointernacao ,datainternacao,alergia,descricaoalergia,doencarespiratoria,doencagastrointestinal,doencacardiaca,doencaendocrina,doencaosteomusculares,historiaocupacional,acidentedetrabalho,dataacidente,afastamentoacidente,afastamentoinss,periodoafastamento) VALUES ("+idfuncionario+",'"+queixa+"','"+cirurgiaanterior+"','"+datacirurgia.Date.ToString("yyyy/MM/dd")+"','"+nomecirurgia+"','"+fratura+"','"+datatomografia.Date.ToString("yyyy/MM/dd") + "','"+internacao +"','"+motivointernacao+"','"+datainternacao.Date.ToString("yyyy/MM/dd") + "','"+alergia+"','"+descricaoalergia+"','"+doencarespiratoria+"','"+doencagastrointestinal+"','"+doencacardiaca+"','"+doencaendocrina+"','"+doencaosteomusculares+"','"+historiaocupacional+"','"+acidentedetrabalho+"','"+dataacidente.Date.ToString("yyyy/MM/dd") + "','"+afastamentoacidente+"','"+afastamentoinss+"','"+periodoafastamento+"')", Com);
            InserirQuesrtionario.ExecuteNonQuery();
            Com.Close();
        }

        public void CadastrarCbo(string Descricao)
        {
            Com.Open();
            MySqlCommand InserirCbo = new MySqlCommand("INSERT INTO cbo (codigo) VALUES('"+Descricao+"')",Com);
            InserirCbo.ExecuteNonQuery();
            Com.Close();
        }
        public void AtualizaCbo(string Descricao,string IdCbo)
        {
            Com.Open();
            MySqlCommand InserirCbo = new MySqlCommand("UPDATE cbo SET codigo='" + Descricao + "' where id="+IdCbo+";", Com);
            InserirCbo.ExecuteNonQuery();
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
            MySqlCommand InserirExame = new MySqlCommand("INSERT INTO examesmedicos (descricao) VALUES('"+Descricao+"')",Com);
            InserirExame.ExecuteNonQuery();
            Com.Close();

        }
        public void CadastrarModalidadeExame(string Descricao)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("INSERT INTO modalidadeexames (descricao) VALUES('" + Descricao + "')", Com);
            InserirExame.ExecuteNonQuery();
            Com.Close();

        }
        public void EditarExame(string Descricao,string Id)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("UPDATE examesmedicos SET descricao='" + Descricao + "' WHERE id=" + Id + ";", Com);
            InserirExame.ExecuteNonQuery();
            Com.Close();

        }
        public void EditarModalidadeExame(string Descricao,string Id)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("UPDATE modalidadeexames SET descricao='" + Descricao + "' WHERE id=" + Id + ";", Com);
            InserirExame.ExecuteNonQuery();
            Com.Close();

        }
        public void ExcluirExame(string Id)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("UPDATE examesmedicos SET excluido='S' WHERE id=" + Id + ";", Com);
            InserirExame.ExecuteNonQuery();
            Com.Close();

        }
        public void ExcluirModalidadeExame(string Id)
        {
            Com.Open();
            MySqlCommand InserirExame = new MySqlCommand("UPDATE modalidadeexames SET excluido='S' WHERE id="+Id+";", Com);
            InserirExame.ExecuteNonQuery();
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

    }
}