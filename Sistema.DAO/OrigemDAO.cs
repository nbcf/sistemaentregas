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

namespace Sistema.DAO
{
  public  class OrigemDAO
    {
        public int regEncontradosPesquisa = 0;
        public string acaoCrudDAO = "";
        Sistema.Conexao.ClasseConexao classeConecta = new Sistema.Conexao.ClasseConexao();
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
        public void Salvar(string nomeorigem, string codorigem){
            int registrosLinhas;
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM origem where nomeorigem = @nomeorigem", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@nomeorigem", nomeorigem);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                MessageBox.Show("Entrou Salvar");
                registrosLinhas = dtp.Rows.Count;
                classeConecta.FecharCon();

                if (registrosLinhas > 0){

                    var resultado = MessageBox.Show("O Registro: " +
                    Convert.ToString(nomeorigem) +
                    ", se encotra na base de dados. " + "\n" +
                    "Para confirmar a inserção duplicada, clique no botão 'Sim', e 'Não' para cancelar.",
                    "Aviso de Duplicidade",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes){
                        classeConecta.AbrirCon();
                        sql = "INSERT INTO origem (nomeorigem, codorigem) VALUES (@nomeorigem,@codorigem)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@nomeorigem", nomeorigem);
                        cmd.Parameters.AddWithValue("@codorigem", codorigem);
                        cmd.ExecuteNonQuery();
                        acaoCrudDAO = "S!!";
                        classeConecta.FecharCon();

                    }else if (resultado == DialogResult.No){
                        acaoCrudDAO = "NS";
                    

                    }

                }else if (registrosLinhas == 0){
                    classeConecta.AbrirCon();
                    sql = "INSERT INTO origem (nomeorigem, codorigem) VALUES (@nomeorigem,@codorigem)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@nomeorigem", nomeorigem);
                    cmd.Parameters.AddWithValue("@codorigem", codorigem);
                    cmd.ExecuteNonQuery();
                    acaoCrudDAO = "S!";
                    classeConecta.FecharCon();
                }
               
            }catch (Exception ex){
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex,
                    "Erro na classe OrigemDAO", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        public void Editar(string nomeorigem, string codorigem, int idorigem)
        {
            try
            {
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE origem SET nomeorigem = @nomeorigem, codorigem = @codorigem WHERE idorigem = @idorigem", classeConecta.con);
                cmd.Parameters.AddWithValue("@nomeorigem", nomeorigem);
                cmd.Parameters.AddWithValue("@codorigem", codorigem);
                cmd.Parameters.AddWithValue("@idorigem", idorigem);
                cmd.ExecuteNonQuery();
                acaoCrudDAO = "AT";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Editar foi operado " + ex, "Erro na classe OrigemDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Excluir(int idorigem)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + idorigem, "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM origem where idorigem = @idorigem";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idorigem", idorigem);
                    cmd.ExecuteNonQuery();
                    acaoCrudDAO = "DEL";
                    classeConecta.FecharCon();

                }catch (Exception ex){
                    MessageBox.Show("A Seguinte Excessão foi lançada quando o método Excluir foi operado " + ex, "Erro na classe OrigemDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else if (resultado == DialogResult.No){
                acaoCrudDAO = "NDEL";
            }
        }


        public int ListarTodosVeiculosBD(){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM origem";
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                classeConecta.FecharCon();
                return dt.Rows.Count;
                
            }catch (Exception ex){
                throw ex;
            }
        }


        public int ListarVeiculosPesquisados(){
            return regEncontradosPesquisa;
        }

        public string AcaoCrudDAO(){
            return acaoCrudDAO;
        }

        public DataTable ListaDataGrid(string parametro, string indexar, int offsett, int limitt){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * from origem  ORDER BY " + parametro + " " + indexar + " Limit " + offsett+ "," +limitt;
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


        public DataTable ConfiListagemImportOE(){
            try{

                classeConecta.AbrirCon();
                sql = "SELECT * from origem ";
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

        public DataTable PesquisarComeca(string coluna, string campo, string pesquisar)
        {
            try
            {
                classeConecta.AbrirCon();
                //  sql = "SELECT * FROM origem where nomeorigem Like " + campo + "";
                sql = "SELECT * FROM origem where "+coluna+" Like " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == ""){
                    cmd.Parameters.AddWithValue(campo, "");

                }else{
                    cmd.Parameters.AddWithValue(campo, pesquisar + "%");

                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                regEncontradosPesquisa = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable PesquisarContem(string coluna, string campo, string pesquisar){
            try{

                classeConecta.AbrirCon();
                // sql = "SELECT * FROM origem where nomeorigem Like  " + campo + "";
                sql = "SELECT * FROM origem where " + coluna + " Like " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == ""){
                    cmd.Parameters.AddWithValue(campo, "");
                }else{
                    cmd.Parameters.AddWithValue(campo, "%" + pesquisar + "%");
                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                regEncontradosPesquisa = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;

            }catch (Exception ex){
                throw ex;
            }
        }

        public DataTable PesquisarTermina(string coluna, string campo, string pesquisar)
        {
            try
            {
                classeConecta.AbrirCon();
                //    sql = "SELECT * FROM origem where nomeorigem Like  " + campo + "";
                sql = "SELECT * FROM origem where " + coluna + " Like " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == ""){

                    cmd.Parameters.AddWithValue(campo, "");
                }else{
                    cmd.Parameters.AddWithValue(campo, "%" + pesquisar);
                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                regEncontradosPesquisa = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
                
            }catch (Exception ex){
                throw ex;
            }
        }
    }
}
