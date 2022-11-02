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
  public  class UsuariosDAO
    {

        public int regEncontradosPesquisaUsuariosDAO = 0;
        public string acaoCrudUsuariosDAO = "";

        ClasseConexao classeConecta = new ClasseConexao();
        string sql;
        MySqlCommand cmd;
        MySqlCommand cmdVerificar;
        public bool conexao = false;
        public PapeisModel pmodelDAO;
        public PessoasModel pessmodelDAO;


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
        public void Salvar(int idpessoa, int idpapel, string usuario, string senha)
        {
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM usuarios where usuario = @usuario", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@usuario", usuario);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                classeConecta.FecharCon();
                if (dtp.Rows.Count > 0)
                {
                    var resultado = MessageBox.Show("O Registro " + Convert.ToString(usuario) + " Contagem dtp.Rows.Count : " + Convert.ToString(dtp.Rows.Count) + " já se encontra, no banco de dados do sistema. " + "\n" + "Para confirmar a inserção duplicada, clique no botão 'Sim'. E no botão 'Não' para cancelar.", "Aviso de Duplicidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        classeConecta.AbrirCon();
                        sql = "INSERT INTO usuarios (idpessoa, idpapel, usuario,senha) " +
                            "VALUES (@idpessoa,@idpapel,@usuario,@senha)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@idpessoa", idpessoa);
                        cmd.Parameters.AddWithValue("@idpapel", idpapel);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        cmd.ExecuteNonQuery();
                        acaoCrudUsuariosDAO = "S!!";
                        classeConecta.FecharCon();

                    }else if (resultado == DialogResult.No){
                        acaoCrudUsuariosDAO = "NS";
                    }
                }else if (dtp.Rows.Count == 0){
                    classeConecta.AbrirCon();
                    sql = "INSERT INTO usuarios (idpessoa, idpapel, usuario,senha) " +
                        "VALUES (@idpessoa,@idpapel,@usuario,@senha)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idpessoa", idpessoa);
                    cmd.Parameters.AddWithValue("@idpapel", idpapel);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.ExecuteNonQuery();
                    acaoCrudUsuariosDAO = "S!";
                    classeConecta.FecharCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex, "Erro na classe PessoaDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Editar(int idpessoa, int idpapel, string usuario, string senha, int idusuario)
        {
            try{
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE usuarios SET " +
                    "idpessoa = @idpessoa," +
                    " idpapel = @idpapel," +
                    " usuario = @usuario," +
                    " senha = @senha" +
                    " WHERE idusuario = @idusuario", classeConecta.con);
                cmd.Parameters.AddWithValue("@idpessoa", idpessoa);
                cmd.Parameters.AddWithValue("@idpapel", idpapel);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@idusario", idusuario);
                cmd.ExecuteNonQuery();
                acaoCrudUsuariosDAO = "AT";
                classeConecta.FecharCon();

            }catch (Exception ex){
                MessageBox.Show("Erro ao Editar " + ex);
            }

        }

        public void Excluir(int idusuario)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + idusuario, "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM usuarios where idusuario = @idusuario";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.ExecuteNonQuery();
                    acaoCrudUsuariosDAO = "DEL";
                    classeConecta.FecharCon();

                }catch (Exception ex){

                    MessageBox.Show("A Seguinte Excessão foi lançada quando o método Excluir foi operado " + ex, "Erro na classe OrigemDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else if (resultado == DialogResult.No){
                acaoCrudUsuariosDAO = "NDEL";
            }
        }

        public Object ExibirDadosPapeis(string idpapel) {
            PapeisModel pmodel = new PapeisModel();
            try
            {
                classeConecta.AbrirCon();
                MySqlCommand cmdVerificar;
                MySqlDataReader reader;
                cmdVerificar = new MySqlCommand("SELECT * FROM papeis where idpapel = @idpapel", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@idpapel", idpapel);
                reader = cmdVerificar.ExecuteReader();
                classeConecta.FecharCon();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pmodel.Nomepapel = Convert.ToString(reader["Nomepapel"]);
                        pmodel.Criar            =       "1".Equals(reader["Criar"])       ? true : false;
                        pmodel.Recuperar        =       "1".Equals(reader["Recuperar"])   ? true : false;
                        pmodel.Atualizar        =       "1".Equals(reader["Atualizar"])   ? true : false;
                        pmodel.Excluir          =       "1".Equals(reader["Excluir"])     ? true : false;
                        pmodel.Menuope          =       "1".Equals(reader["Menuope"])     ? true : false;
                        pmodel.Menuadmin        =       "1".Equals(reader["Menuadmin"])   ? true : false;
                        pmodel.Menugen          =       "1".Equals(reader["Menugen"])     ? true : false;
                    }
                }
                pmodelDAO = pmodel;
                return pmodelDAO;
            }
            catch (Exception ex){
                throw ex;
            }
        }


        public string ExibirDadosPessoa(string idpessoa)
        {
            string peganomepessoa= "";
            try
            {
                classeConecta.AbrirCon();
                MySqlCommand cmdVerificar;
                MySqlDataReader reader;
                cmdVerificar = new MySqlCommand("SELECT * FROM pessoas where idpessoa = @idpessoa", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@idpessoa", idpessoa);
                reader = cmdVerificar.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        peganomepessoa = Convert.ToString(reader["Nomepessoa"]);
                    }
                }
                classeConecta.FecharCon();
                return peganomepessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int ListarTodosVeiculoBD()
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM usuarios";
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


        public int ListarPesquisados(){
            return regEncontradosPesquisaUsuariosDAO;
        }

        public string VerificarPersistencia(){
            return acaoCrudUsuariosDAO;
        }



        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt){
              try{
               
                classeConecta.AbrirCon();
                sql =   "SELECT * FROM usuarios usu " +
                        "INNER JOIN papeis pap " +
                        "INNER JOIN pessoas pes " +
                        "ON usu.idpapel = pap.idpapel " +
                        "AND usu.idpessoa = pes.idpessoa " +
                        "ORDER BY usu."+parametro+ " " +indexar+ " Limit " + offsett + "," + limitt;
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
 
        public DataTable ListarImportEntregador(string funcao) {
            try{

                classeConecta.AbrirCon();
                sql = "SELECT * FROM usuarios usu " +
                    "INNER JOIN papeis pap " +
                    "INNER JOIN pessoas pes ON usu.idpapel = pap.idpapel and usu.idpessoa = pes.idpessoa " +
                    "WHERE pap.nomepapel = 'Entregador'";
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

        public DataTable PesquisarComeca(string coluna, string campo, string pesquisar) {
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM usuarios usu " +
                    "INNER JOIN papeis pap " +
                    "INNER JOIN pessoas pes ON usu.idpapel = pap.idpapel AND usu.idpessoa = pes.idpessoa " +
                    "WHERE usu.usuario LIKE " +campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);

                if (pesquisar == ""){
                    cmd.Parameters.AddWithValue(campo, "");

                } else{
                    cmd.Parameters.AddWithValue(campo, pesquisar +"%");
                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                regEncontradosPesquisaUsuariosDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
                
            } catch (Exception ex){

                throw ex;
            }
        }

        public DataTable PesquisarContem(string coluna, string campo, string pesquisar){
            try{
                classeConecta.AbrirCon();
               sql ="SELECT * FROM usuarios usu " +
                    "INNER JOIN papeis pap " +
                    "INNER JOIN pessoas pes " +
                    "ON usu.idpapel = pap.idpapel " +
                    "AND usu.idpessoa = pes.idpessoa " +
                    "WHERE usu.usuario LIKE " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == "")
                {
                    cmd.Parameters.AddWithValue("@" + campo, "");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@" + campo, "%" + pesquisar + "%");
                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                regEncontradosPesquisaUsuariosDAO = dt.Rows.Count;
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
              sql = "SELECT * FROM usuarios usu " +
                    "INNER JOIN papeis pap " +
                    "INNER JOIN pessoas pes " +
                    "ON usu.idpapel = pap.idpapel " +
                    "AND usu.idpessoa = pes.idpessoa " +
                    "WHERE usu.usuario LIKE " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == "")
                {
                    cmd.Parameters.AddWithValue("@" + campo, "");

                } else{
                    cmd.Parameters.AddWithValue("@" + campo, "%" + pesquisar);
                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                regEncontradosPesquisaUsuariosDAO = dt.Rows.Count;
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