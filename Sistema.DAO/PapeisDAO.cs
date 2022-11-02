using MySql.Data.MySqlClient;
using Sistema.Conexao;
using Sistema.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.DAO
{
  public  class PapeisDAO
    {
        PapeisModel papeisModel = new PapeisModel();

        public int pesquisaPapeisDAO = 0;
        public string acaoCrudPapeisDAO = "";
        public int qtBDPapeisDAO = 0;
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

        public void Salvar(
                        string papel,
                        bool cadastrar,
                        bool pesquisar, 
                        bool editar,
                        bool excluir,
                        bool menuope,
                        bool menuadmin,
                        bool menugen){
            
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM papeis where nomepapel = @nomepapel", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@nomepapel", papel);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                classeConecta.FecharCon();
                if (dtp.Rows.Count > 0)
                {
                    var resultado = MessageBox.Show("O Registro " + papel + " já se encontra, no banco de dados do sistema. " + "\n" + "Para confirmar a inserção duplicada, clique no botão 'Sim'. E no botão 'Não' para cancelar.",
                        "Aviso de Duplicidade",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        classeConecta.AbrirCon();
                        sql = "INSERT INTO papeis (" +
                            "nomepapel," +
                            "criar, " +
                            "recuperar, " +
                            "atualizar," +
                            "excluir," +
                            "menuope," +
                            "menuadmin," +
                            "menugen" +
                            ") VALUES (" +
                            "@nomepapel," +
                            "@criar," +
                            "@recuperar," +
                            "@atualizar," +
                            "@excluir," +
                            "@menuope," +
                            "@menuadmin," +
                            "@menugen)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@nomepapel", papel);
                        cmd.Parameters.AddWithValue("@criar", cadastrar);
                        cmd.Parameters.AddWithValue("@recuperar", pesquisar);
                        cmd.Parameters.AddWithValue("@atualizar", editar);
                        cmd.Parameters.AddWithValue("@excluir", excluir);
                        cmd.Parameters.AddWithValue("@menuope", menuope);
                        cmd.Parameters.AddWithValue("@menuadmin", menuadmin);
                        cmd.Parameters.AddWithValue("@menugen", menugen);
                        cmd.ExecuteNonQuery();
                        acaoCrudPapeisDAO = "S!!";
                        classeConecta.FecharCon();

                    }
                    else if (resultado == DialogResult.No)
                    {
                        acaoCrudPapeisDAO = "NS";
                    }
                }
                else if (dtp.Rows.Count == 0)
                {
                    classeConecta.AbrirCon();
                    sql = "INSERT INTO papeis (" +
                        "nomepapel," +
                        "criar, " +
                        "recuperar," +
                        "atualizar," +
                        "excluir, " +
                        "menuope, " +
                        "menuadmin, " +
                        "menugen" +
                        ") VALUES (" +
                        "@nomepapel," +
                        "@criar, " +
                        "@recuperar," +
                        "@atualizar," +
                        "@excluir," +
                        "@menuope, " +
                        "@menuadmin," +
                        "@menugen)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@nomepapel", papel);
                    cmd.Parameters.AddWithValue("@criar", cadastrar);
                    cmd.Parameters.AddWithValue("@recuperar", pesquisar);
                    cmd.Parameters.AddWithValue("@atualizar", editar);
                    cmd.Parameters.AddWithValue("@excluir", excluir);
                    cmd.Parameters.AddWithValue("@menuope", menuope);
                    cmd.Parameters.AddWithValue("@menuadmin", menuadmin);
                    cmd.Parameters.AddWithValue("@menugen", menugen);
                    cmd.ExecuteNonQuery();
                    acaoCrudPapeisDAO = "S!";
                    classeConecta.FecharCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex,
                    "Erro na classe UsuariosDAO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


        public void Editar(
                        string papel,
                        bool cadastrar, 
                        bool pesquisar,
                        bool editar, 
                        bool excluir,
                        bool menuope, 
                        bool menuadm, 
                        bool menugen, 
                        int idpapel){
            try{
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("UPDATE usuarios SET " +
                    " nomepapel     =   @nomepapel," +
                    " criar         =   @criar," +
                    " recuperar     =   @recuperar," +
                    " atualizar     =   @editar," +
                    " excluir       =   @excluir," +
                    " menuope       =   @menuope," +
                    " menuadm       =   @menuadm," +
                    " menugen       =   @menugen" +
                    " WHERE idpapel = @idpapel", classeConecta.con);
                    cmd.Parameters.AddWithValue("@nomepapel",   papel);
                    cmd.Parameters.AddWithValue("@criar",       cadastrar);
                    cmd.Parameters.AddWithValue("@recuperar",   pesquisar);
                    cmd.Parameters.AddWithValue("@atualizar",   editar);
                    cmd.Parameters.AddWithValue("@excluir",     excluir);
                    cmd.Parameters.AddWithValue("@menuope",     menuope);
                    cmd.Parameters.AddWithValue("@menuadmin",   menuadm);
                    cmd.Parameters.AddWithValue("@menugen",   menugen);
                    cmd.Parameters.AddWithValue("@idpapel",     idpapel);
                    cmd.ExecuteNonQuery();
                    acaoCrudPapeisDAO = "AT";

            } catch (Exception ex){
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Editar foi operado " + ex, "Erro na classe UsuariosDAO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


        public void Excluir(int idpapeis, string nomepapel)
        {
            var resultado = MessageBox.Show("Confirmar exclusão do registro: " + nomepapel, "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM papeis where idpapel = @idpapel";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idpapel", idpapeis);
                    cmd.ExecuteNonQuery();
                    classeConecta.FecharCon();
                    acaoCrudPapeisDAO = "DEL";
                    
                }catch (Exception ex){
                    MessageBox.Show("Erro ao Excluir " + ex);
          
                }
            }
            else if (resultado == DialogResult.No)
            {
                acaoCrudPapeisDAO = "NDEL";
            }
        }

        public DataTable Listar(string ordenarpor)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM papeis where nomepapel LIKE @nomepapel";
                cmd = new MySqlCommand(sql, classeConecta.con);
                cmd.Parameters.AddWithValue("@nomepapel", papeisModel.Nomepapel + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                qtBDPapeisDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int ListarBDPapeisDAO(){
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM papeis";
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


        public int ListarPesquisaPapeisDAO(){
            return pesquisaPapeisDAO;
        }

        public string AcaoCrudPapeisDAO(){
            return acaoCrudPapeisDAO;
        }

        public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * from papeis ORDER BY " + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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


        public DataTable ConfiListagemImportPU()
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * from papeis";
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
                sql = "SELECT * FROM papeis where nomepapel Like " + campo + "";
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
                pesquisaPapeisDAO = dt.Rows.Count;
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
                sql = "SELECT * FROM papeis where nomepapel Like  " + campo + "";
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
                pesquisaPapeisDAO = dt.Rows.Count;
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

                sql = "SELECT * FROM papeis where nomepapel Like  " + campo + "";

                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == "")
                {
                    cmd.Parameters.AddWithValue(campo, "");
                }
                else
                {
                    cmd.Parameters.AddWithValue(campo, "%" + pesquisar );
                }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                pesquisaPapeisDAO = dt.Rows.Count;
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