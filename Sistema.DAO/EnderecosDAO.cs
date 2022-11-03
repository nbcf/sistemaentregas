using Sistema.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sistema.Conexao;
using System.Windows.Forms;
// 
namespace Sistema.DAO
{
    public class EnderecosDAO{
        //public int quantidadeBD = 0;
        //public int quantidadePaginada = 0;
        //public int resQuantSearch;
        //public string acaoCrud = "";

        public int pesquisaEnderecosDAO = 0;
        public string acaoCrudEnderecosDAO = "";

        ClasseConexao classeConecta = new ClasseConexao();
        string sql;
        MySqlCommand cmd;
        MySqlCommand cmdVerificar;
        public bool conexao = false;

        public string estConexao()
        {

            string retorno = classeConecta.statusConexao;
            if (retorno.Equals("Instância de Conexão Aberta"))
            {
                retorno = "Conexao Aberta";
            }
            else if (retorno.Equals("Instância de Conexão Fechada"))
            {
                retorno = "Conexao Fechada";
            }
            else if (retorno.Equals("Conexão Inexistente"))
            {
                retorno = "Sem Conexao";
            }
            return retorno;

        }

        // Metodo Salvar registroInserido
        public void Salvar(
            string logradouro,
            string bairro,
            string cidade,
            string uf,
            string cep)
        {
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM enderecos where logradouro = @logradouro", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@logradouro", logradouro);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                classeConecta.FecharCon();

                if (dtp.Rows.Count > 0)
                {
                    var resultado = MessageBox.Show("O Registro " + logradouro + " já se encontra, no banco de dados do sistema. " + "\n" + "Para confirmar a inserção duplicada, clique no botão 'Sim'. E no botão 'Não' para cancelar.", "Aviso de Duplicidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        classeConecta.AbrirCon();
                        sql = "INSERT INTO enderecos (" +
                            "logradouro," +
                            "  bairro, " +
                            "cidade, " +
                            "uf," +
                            " cep" +
                            ") VALUES (" +
                            "@logradouro," +
                            " @bairro," +
                            " @cidade," +
                            " @uf," +
                            " @cep" +
                            ")";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@logradouro", logradouro);
                        cmd.Parameters.AddWithValue("@bairro", bairro);
                        cmd.Parameters.AddWithValue("@cidade", cidade);
                        cmd.Parameters.AddWithValue("@uf", uf);
                        cmd.Parameters.AddWithValue("@cep", cep);
                        cmd.ExecuteNonQuery();
                        //    MessageBox.Show("Registro Salvo com Sucesso!", "Registro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        acaoCrudEnderecosDAO = "S!!";
                        classeConecta.FecharCon();

                    }
                    else if (resultado == DialogResult.No)
                    {

                        acaoCrudEnderecosDAO = "NS";
             

                    }
                }
                else if (dtp.Rows.Count == 0)
                {
                    classeConecta.AbrirCon();
                    sql = "INSERT INTO enderecos (" +
                        "logradouro, " +
                        " bairro," +
                        " cidade," +
                        " uf," +
                        " cep" +
                        ") VALUES (" +
                        "@logradouro, " +
                        " @bairro," +
                        " @cidade," +
                        " @uf," +
                        " @cep" +
                        ")";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@logradouro", logradouro);
                    cmd.Parameters.AddWithValue("@bairro", bairro);
                    cmd.Parameters.AddWithValue("@cidade", cidade);
                    cmd.Parameters.AddWithValue("@uf", uf);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.ExecuteNonQuery();
                    //  MessageBox.Show("Registro Salvo com Sucesso!", "Registro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    acaoCrudEnderecosDAO = "S!";
                    classeConecta.FecharCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex, "Erro na classe PessoaDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void Editar(
            int idendereco,
            string logradouro,
            string bairro,
            string cidade,
            string uf,
            string cep){

            try{
                classeConecta.AbrirCon();
                    cmd = new MySqlCommand("UPDATE enderecos SET " +
                        "logradouro =   @logradouro, " +
                        "bairro     =   @bairro," +
                        "cidade     =   @cidade," +
                        "uf         =   @uf, " +
                        "cep        =   @cep " +
                        " WHERE idendereco = @idendereco", classeConecta.con);
                    cmd.Parameters.AddWithValue("@logradouro", logradouro);
                    cmd.Parameters.AddWithValue("@bairro", bairro);
                    cmd.Parameters.AddWithValue("@cidade", cidade);
                    cmd.Parameters.AddWithValue("@uf", uf);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.Parameters.AddWithValue("@idendereco", idendereco);
                    cmd.ExecuteNonQuery();
                    acaoCrudEnderecosDAO = "AT";
                    classeConecta.FecharCon();

            }catch (Exception ex) {
                MessageBox.Show("Erro ao Editar " + ex);
            }
        }

        public void Excluir(int idendereco)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + idendereco, "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM enderecos where idendereco = @idendereco";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idendereco", idendereco);
                    cmd.ExecuteNonQuery();
                    acaoCrudEnderecosDAO = "DEL";
                    classeConecta.AbrirCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir " + ex);
                  
                }
            }
            else if (resultado == DialogResult.No)
            {
                acaoCrudEnderecosDAO = "NDEL";
            }
        }


        public int ListarBDEnderecosDAO() {
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM enderecos";
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                classeConecta.AbrirCon();
                return dt.Rows.Count;

            }catch (Exception ex){
                throw ex;
            }
        }


        public int PesquisaEnderecosDAO()
        {
            
            return pesquisaEnderecosDAO;
        }

        public string AcaoCrudEnderecosDAO()
        {
            
            return acaoCrudEnderecosDAO;
        }

        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * from enderecos ORDER BY " + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                classeConecta.FecharCon();
                return dt;
                
            }catch (Exception ex){

                throw ex;
            }
        }



        public DataTable PesquisarComeca(string coluna, string campo, string pesquisar){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM enderecos where logradouro Like " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == "")
                {
                    cmd.Parameters.AddWithValue(campo, "");
                }
                else
                {
                    cmd.Parameters.AddWithValue(campo, pesquisar + "%"  );
                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                pesquisaEnderecosDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;

            }catch (Exception ex){
                throw ex;
            }
        }

        public DataTable PesquisarContem(string coluna, string campo, string pesquisar){
            try{

                classeConecta.AbrirCon();
                sql = "SELECT * FROM enderecos where logradouro Like  " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == "")
                {
                    cmd.Parameters.AddWithValue(campo, "");
                }
                else
                {
                    cmd.Parameters.AddWithValue(campo, "%" + pesquisar + "%");
                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                pesquisaEnderecosDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;

            }catch (Exception ex){
                throw ex;
            }
        }

        public DataTable PesquisarTermina(string coluna, string campo, string pesquisar){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM enderecos where logradouro Like  " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == "")
                {
                    cmd.Parameters.AddWithValue(campo, "");
                }
                else
                {
                    cmd.Parameters.AddWithValue(campo, "%" + pesquisar);
                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                pesquisaEnderecosDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;

            }catch (Exception ex){

                throw ex;
            }
        }
    }
}