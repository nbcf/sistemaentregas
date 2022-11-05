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
   
   public  class TipoUndsDAO
    {
    
        public int listarPesquisaTipoUndsDAO = 0;
        public string acaoCrudTipoUndsDAO = "";
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
        public void Salvar(string nomeund)
        {
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM tipounds where nomeund = @nomeund", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@nomeund", nomeund);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                if (dtp.Rows.Count > 0)
                {
                    var resultado = MessageBox.Show("O Registro: " +
                    Convert.ToString(nomeund) +
                    ", se encotra na base de dados. " + "\n" +
                    "Para confirmar a inserção duplicada, clique no botão 'Sim', e 'Não' para cancelar.",
                    "Aviso de Duplicidade",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        sql = "INSERT INTO tipounds (nomeund) VALUES (@nomeund)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@nomeund", nomeund);

                        cmd.ExecuteNonQuery();
                        acaoCrudTipoUndsDAO = "S!!";
                        classeConecta.FecharCon();

                    }
                    else if (resultado == DialogResult.No)
                    {
                        acaoCrudTipoUndsDAO = "NS";
                        classeConecta.FecharCon();

                    }
                }
                else if (dtp.Rows.Count == 0)
                {
                    sql = "INSERT INTO tipounds (nomeund) VALUES (@nomeund)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@nomeund", nomeund);
                    cmd.ExecuteNonQuery();

                    acaoCrudTipoUndsDAO = "S!";
                    classeConecta.FecharCon();
                }
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex, "Erro na classe PessoaDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void Editar(int idtipound, string nomeund)
        {
            try
            {
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE tipounds SET " +
                    "nomeund = @nomeund " +
                    "WHERE idtipound = @idtipound", classeConecta.con);
                cmd.Parameters.AddWithValue("@nomeund", nomeund);
                cmd.Parameters.AddWithValue("@idtipound", idtipound);
                cmd.ExecuteNonQuery();
                acaoCrudTipoUndsDAO = "AT";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex);
            }

        }

        public void Excluir(int idtipound)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + Convert.ToString(idtipound), "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM tipounds where idtipound = @idtipound";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idtipound", idtipound);
                    cmd.ExecuteNonQuery();
                    acaoCrudTipoUndsDAO = "DEL";
                    classeConecta.FecharCon();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir " + ex);
                    
                }
            }
            else if (resultado == DialogResult.No)
            {

            }
        }
        public DataTable ListComboBoxTipoUndDAO()
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM tipounds ";
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                classeConecta.FecharCon();
                return dt;
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int ListarTipoUndsBD(){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM tipounds";
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


        public int ListarPesquisadosTipoUndsDAO(){
            return listarPesquisaTipoUndsDAO;
        }

        public string AcaoCrudTipoUndsDAO(){
            return acaoCrudTipoUndsDAO;
        }

        public DataTable ListarTipoUndsDataGridDAO(string parametro, string indexar, int offsett, int limitt){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM tipounds ORDER BY " + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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


        public DataTable ConfiListagemImportOE()
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * from tipounds ";
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                classeConecta.FecharCon();
                return dt;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable PesquisarComeca(string coluna, string campo, string pesquisar)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM tipounds where nomeund Like " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == "")
                {
                    cmd.Parameters.AddWithValue(campo, "");
                }
                else
                {
                    cmd.Parameters.AddWithValue(campo, pesquisar + "%");

                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                listarPesquisaTipoUndsDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable PesquisarContem(string coluna, string campo, string pesquisar)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM tipounds where nomeund Like  " + campo + "";
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

                listarPesquisaTipoUndsDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable PesquisarTermina(string coluna, string campo, string pesquisar)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM tipounds where nomeund Like  " + campo + "";
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
                listarPesquisaTipoUndsDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
