using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SystemCare
{
    class QuerryMysql
    {
        MySqlConnection Com = new MySqlConnection("Server = localhost; Database=medseg;Uid=root;Pwd=chinchila@acida12244819");
        static  string IdEmpresaEditar = "";
        private static string NomeSetor = "";
        private static string NomeFuncao = "";

        public bool Login(string Usuario, string Senha)
        {
            Com.Open();
           MySqlCommand SelecionaUsuario = new MySqlCommand("SELECT * FROM usuarios WHERE login='"+Usuario+"' AND senha=MD5('"+Senha+"')",Com);
           MySqlDataAdapter LeitorUsuario = new MySqlDataAdapter(SelecionaUsuario);
           DataTable TabelaUsuario = new DataTable();
            LeitorUsuario.Fill(TabelaUsuario);
            if (TabelaUsuario.Rows.Count > 0)
            {
                Com.Close();
                return true;
            }
            else
            {
                Com.Close();
                return false;
            }
        }

        public DataTable BuscaCnae(string ValorDigitado)
        {
            Com.Open();
            MySqlCommand SelecionaCnae = new MySqlCommand("SELECT cnae as CNAE,descricao as DESCRIÇÃO FROM cnae WHERE cnae LIKE '%"+ValorDigitado+"%' OR descricao LIKE'%"+ValorDigitado+"%';",Com);
            MySqlDataAdapter LeitorCnae = new MySqlDataAdapter(SelecionaCnae);
            DataTable TabelaCnae = new DataTable();
            LeitorCnae.Fill(TabelaCnae);
            Com.Close();
            return TabelaCnae;
        }

        public void CadastraEmpresa(string Nome, string Endereco, string Cnpj, int QuantidadeFuncionario, string Telefone, string Email, string IdCnae, int Risco)
        {
            Com.Open();
            MySqlCommand InserirEmpresa =
                new MySqlCommand(
                    "INSERT INTO empresas (nome,endereco,cnpj,quantidadefuncionario,telefone,email,idcnae,risco) VALUES('" +
                    Nome + "','" + Endereco + "','" + Cnpj + "'," + QuantidadeFuncionario + ",'" + Telefone + "','" +
                    Email + "','" + IdCnae + "'," + Risco + ")",Com);
            InserirEmpresa.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable BuscaEmpresa(string ValorDigitado)
        {
            Com.Open();
            MySqlCommand SelecionaEmpresa = new MySqlCommand("SELECT id as ID, nome as NOME, cnpj as CNPJ,idcnae as CNAE FROM empresas WHERE excluido='N' AND nome LIKE '%" + ValorDigitado + "%' OR cnpj LIKE'%" + ValorDigitado + "%';", Com);
            MySqlDataAdapter LeitorEmpresa = new MySqlDataAdapter(SelecionaEmpresa);
            DataTable TabelaEmpresa = new DataTable();
            LeitorEmpresa.Fill(TabelaEmpresa);
            Com.Close();
            return TabelaEmpresa;
        }

        public DataTable BuscaSetor(string ValorDigitado)
        {
            Com.Open();
            MySqlCommand SelecionaSetor = new MySqlCommand("SELECT a.id as ID, a.nome as 'NOME SETOR', b.nome as 'NOME EMPRESA' FROM setores a, empresas b  WHERE b.id = a.idempresa AND a.excluido='N' AND a.nome LIKE'%" + ValorDigitado + "%' ;", Com);
            MySqlDataAdapter LeitorSetor = new MySqlDataAdapter(SelecionaSetor);
            DataTable TabelaSetor = new DataTable();
             LeitorSetor.Fill(TabelaSetor);
            Com.Close();
            return TabelaSetor;
        }

        public DataTable BuscaFuncao(string ValorDigitado)
        {
            Com.Open();
            MySqlCommand SelecionaSetor = new MySqlCommand("SELECT a.id as ID, a.nome as 'NOME FUNÇÃO', b.nome as 'NOME SETOR', c.nome as 'NOME EMPRESA' FROM funcoes a, setores b, empresas c  WHERE b.id = a.idsetor AND b.idempresa=c.id AND a.excluido='N' AND a.nome LIKE'%" + ValorDigitado + "%' ;", Com);
            MySqlDataAdapter LeitorSetor = new MySqlDataAdapter(SelecionaSetor);
            DataTable TabelaSetor = new DataTable();
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

        public void SetFuncao(string NomeFuncaoUsar)
        {
            NomeFuncao = NomeFuncaoUsar;
        }

        public string GetFuncao()
        {
            return NomeFuncao;
        }

        public DataTable RecuperaDadosEmpresa()
        {
            Com.Open();
            MySqlCommand SelecionaEmpresa = new MySqlCommand("SELECT nome,endereco, cnpj,quantidadefuncionario,telefone,email,idcnae,risco FROM empresas WHERE id=" + IdEmpresaEditar + ";", Com);
            MySqlDataAdapter LeitorEmpresa = new MySqlDataAdapter(SelecionaEmpresa);
            DataTable TabelaEmpresa = new DataTable();
            LeitorEmpresa.Fill(TabelaEmpresa);
            Com.Close();
            return TabelaEmpresa;
        }

        public void EditarEmpresa(string Nome, string Endereco, string Cnpj, int QuantidadeFuncionario, string Telefone, string Email, string IdCnae, int Risco)
        {
            Com.Open();
            MySqlCommand EditarEmpresa =
                new MySqlCommand(
                    "UPDATE empresas SET nome ='" + Nome + "' ,endereco='" + Endereco + "',cnpj='" + Cnpj + "',quantidadefuncionario=" + QuantidadeFuncionario + ",telefone='" + Telefone + "',email='" + Email + "',idcnae='" + IdCnae + "',risco=" + Risco + " WHERE id="+IdEmpresaEditar+";", Com);
            EditarEmpresa.ExecuteNonQuery();
            SetEmpresa("");
            Com.Close();
        }

        public void ExcluirEmpresa(string IdEmpresa)
        {
            Com.Open();
            MySqlCommand InserirEmpresa =
                new MySqlCommand("UPDATE empresas set excluido='S' WHERE id="+IdEmpresa+";", Com);
            InserirEmpresa.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable SelecionaRisco()
        {
            Com.Open();
            MySqlCommand SelecionaRiscos = new MySqlCommand("select a.id as ID, b.descricao as Grupo, a.descricao as Risco from riscos a, gruposriscos b where a.idgrupo=b.id",Com);
            MySqlDataAdapter LeitorRiscos = new MySqlDataAdapter(SelecionaRiscos);
            DataTable TabelaRiscos = new DataTable();
            LeitorRiscos.Fill(TabelaRiscos);
            Com.Close();
            return TabelaRiscos;
        }

        public DataTable SelecionaEmpresa()
        {
            Com.Open();
            MySqlCommand SelecionaEmpresas = new MySqlCommand("select id, nome from empresas where excluido='N'", Com);
            MySqlDataAdapter LeitorEmpresas = new MySqlDataAdapter(SelecionaEmpresas);
            DataTable TabelaEmpresas = new DataTable();
            LeitorEmpresas.Fill(TabelaEmpresas);
            Com.Close();
            return TabelaEmpresas;
        }

        public DataTable SelecionaFuncao()
        {
            Com.Open();
            MySqlCommand SelecionaFuncao = new MySqlCommand("select id, nome from funcoes where excluido='N'", Com);
            MySqlDataAdapter LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
            DataTable TabelaFuncao = new DataTable();
            LeitorFuncao.Fill(TabelaFuncao);
            Com.Close();
            return TabelaFuncao;
        }
        public DataTable SelecionaSetorEmpresa(string IdEmpresa)
        {
            try
            {
                Com.Open();
                MySqlCommand SelecionaFuncao =
                    new MySqlCommand("select id, nome from setores where idempresa=" + IdEmpresa + " AND excluido='N'",
                        Com);
                MySqlDataAdapter LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
                DataTable TabelaFuncao = new DataTable();
                LeitorFuncao.Fill(TabelaFuncao);
                Com.Close();
                return TabelaFuncao;
            }
            catch
            {
                Com.Close();
                DataTable TabelaNula = new DataTable();
                return TabelaNula;
            }
        }
        public DataTable SelecionaFuncaoEmpresa(string IdSetor)
        {
            try
            {
                Com.Open();
                MySqlCommand SelecionaFuncao =
                    new MySqlCommand("select id, nome from funcoes where idsetor=" + IdSetor + " AND excluido='N'",
                        Com);
                MySqlDataAdapter LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
                DataTable TabelaFuncao = new DataTable();
                LeitorFuncao.Fill(TabelaFuncao);
                Com.Close();
                return TabelaFuncao;
            }
            catch
            {
                Com.Close();
                DataTable TabelaNula = new DataTable();
                return TabelaNula;
            }
        }
        public DataTable SelecionaRiscosFuncao(string IdFuncao)
        {
            try
            {
                Com.Open();
                MySqlCommand SelecionaFuncao =
                    new MySqlCommand("select a.descricao, b.descricao from gruposriscos a , riscos b where b.idgrupo=a.id AND b.id=" + IdFuncao + ";",
                        Com);
                MySqlDataAdapter LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
                DataTable TabelaFuncao = new DataTable();
                LeitorFuncao.Fill(TabelaFuncao);
                Com.Close();
                return TabelaFuncao;
            }
            catch
            {
                Com.Close();
                DataTable TabelaNula = new DataTable();
                return TabelaNula;
            }
        }

        public DataTable SelecionaModalidadeExame()
        {
            Com.Open();
            MySqlCommand SelecionaFuncao = new MySqlCommand("select id, descricao from modalidadeexames", Com);
            MySqlDataAdapter LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
            DataTable TabelaFuncao = new DataTable();
            LeitorFuncao.Fill(TabelaFuncao);
            Com.Close();
            return TabelaFuncao;
        }
        public DataTable SelecionaExameMedico()
        {
            Com.Open();
            MySqlCommand SelecionaFuncao = new MySqlCommand("select id, descricao from examesmedicos", Com);
            MySqlDataAdapter LeitorFuncao = new MySqlDataAdapter(SelecionaFuncao);
            DataTable TabelaFuncao = new DataTable();
            LeitorFuncao.Fill(TabelaFuncao);
            Com.Close();
            return TabelaFuncao;
        }
        public DataTable SelecionaSetor()
        {
            Com.Open();
            MySqlCommand SelecionaEmpresas = new MySqlCommand("select id, nome from setores where excluido='N'", Com);
            MySqlDataAdapter LeitorEmpresas = new MySqlDataAdapter(SelecionaEmpresas);
            DataTable TabelaEmpresas = new DataTable();
            LeitorEmpresas.Fill(TabelaEmpresas);
            Com.Close();
            return TabelaEmpresas;
        }

        public void CadastrarFuncao(string NomeFuncao, string IdCbo, string IdRiscos, string IdSetor)
        {
            Com.Open();      
            MySqlCommand CadastrarFuncao = new MySqlCommand("INSERT INTO funcoes (idsetor,nome,idrisco,idcbo) VALUE("+IdSetor.ToString()+",'"+NomeFuncao+"','"+IdRiscos+"',"+IdCbo+")",Com);
            CadastrarFuncao.ExecuteNonQuery();
            Com.Close();
        }
        public void CadastrarSetor(string IdEmpresa, string NomeSetor)
        {
            Com.Open();
            MySqlCommand CadastraSetor = new MySqlCommand("INSERT INTO setores (idempresa,nome) VALUES(" + IdEmpresa + ",'" + NomeSetor + "')", Com);
            CadastraSetor.ExecuteNonQuery();
            Com.Close();
        }

        public DataTable BuscarCbo(string ValorDigitado)
        {
            Com.Open();
            MySqlCommand BuscaCbo = new MySqlCommand("SELECT id,codigo FROM cbo WHERE codigo LIKE'%"+ValorDigitado+"%'",Com);
            MySqlDataAdapter LeitorCbo = new MySqlDataAdapter(BuscaCbo);
            DataTable TabelaCbo = new DataTable();
            LeitorCbo.Fill(TabelaCbo);
            Com.Close();
            return TabelaCbo;
        }    

        public DataTable RetornaDadosSetor(string IdSetor)
        {
            Com.Open();
            MySqlCommand SelecionaSetor = new MySqlCommand("SELECT * FROM setores WHERE id="+IdSetor+"",Com);
            MySqlDataAdapter LeitorSetor = new MySqlDataAdapter(SelecionaSetor);
            DataTable TabelaSetor = new DataTable();
            LeitorSetor.Fill(TabelaSetor);
            Com.Close();
            return TabelaSetor;
           
        }

        public DataTable RetornaDadosFuncao(string IdFuncao)
        {
            Com.Open();
            MySqlCommand SelecionaSetor = new MySqlCommand("SELECT * FROM funcoes WHERE id=" + IdFuncao + "", Com);
            MySqlDataAdapter LeitorSetor = new MySqlDataAdapter(SelecionaSetor);
            DataTable TabelaSetor = new DataTable();
            LeitorSetor.Fill(TabelaSetor);
            Com.Close();
            return TabelaSetor;

        }

        public string RetornaEmpresa(string IdEmpresa)
        {
            Com.Open();
            MySqlCommand SelecionaEmpresa = new MySqlCommand("SELECT nome FROM empresas WHERE id=" + IdEmpresa + "", Com);
            MySqlDataAdapter LeitorEmpresa = new MySqlDataAdapter(SelecionaEmpresa);
            DataTable TabelaEmpresa = new DataTable();
            LeitorEmpresa.Fill(TabelaEmpresa);
            Com.Close();
            return TabelaEmpresa.Rows[0][0].ToString();

        }

        public string RetornaSetor(string IdSetor)
        {
            Com.Open();
            MySqlCommand SelecionaSetor = new MySqlCommand("SELECT nome FROM setores WHERE id=" + IdSetor + "", Com);
            MySqlDataAdapter LeitorSetor = new MySqlDataAdapter(SelecionaSetor);
            DataTable TabelaSetor = new DataTable();
            LeitorSetor.Fill(TabelaSetor);
            Com.Close();
            return TabelaSetor.Rows[0][0].ToString();

        }
        public string RetornaCbo(string IdCbo)
        {
            Com.Open();
            MySqlCommand SelecionaCbo = new MySqlCommand("SELECT id,codigo FROM cbo WHERE id=" + IdCbo + "", Com);
            MySqlDataAdapter LeitorCbo = new MySqlDataAdapter(SelecionaCbo);
            DataTable TabelaCbo = new DataTable();
            LeitorCbo.Fill(TabelaCbo);
            Com.Close();
            return TabelaCbo.Rows[0][0].ToString()+" | "+ TabelaCbo.Rows[0][1].ToString();

        }


        public void ExcluirSetor(string IdSetor)
        {
            Com.Open();
            MySqlCommand InserirEmpresa =
                new MySqlCommand("UPDATE setores set excluido='S' WHERE id=" + IdSetor + ";", Com);
            InserirEmpresa.ExecuteNonQuery();
            Com.Close();
        }

        public void EditarSetor(string Nome, string IdEmpresa, string IdSetor)
        {
            Com.Open();
            MySqlCommand EditarEmpresa =
                new MySqlCommand(
                    "UPDATE setores SET nome ='" + Nome + "' ,idempresa=" + IdEmpresa+ " WHERE id=" + IdSetor + ";", Com);
            EditarEmpresa.ExecuteNonQuery();
            SetEmpresa("");
            Com.Close();
        }

        public void EditarFuncao(string Nome, string IdSetor,string IdFuncao,string IdRiscos,string IdCbo)
        {
            Com.Open();
            MySqlCommand EditarEmpresa =
                new MySqlCommand(
                    "UPDATE funcoes SET nome ='" + Nome + "' ,idsetor=" + IdSetor + ", idrisco='"+IdRiscos+"', idcbo="+IdCbo+" WHERE id=" + IdFuncao + ";", Com);
            EditarEmpresa.ExecuteNonQuery();
            SetEmpresa("");
            Com.Close();
        }

        public void ExcluirFuncao(string IdFuncao)
        {
            Com.Open();
            MySqlCommand ExcluiFuncao =
                new MySqlCommand("UPDATE funcoes set excluido='S' WHERE id=" + IdFuncao + ";", Com);
            ExcluiFuncao.ExecuteNonQuery();
            Com.Close();
        }

    }
}
