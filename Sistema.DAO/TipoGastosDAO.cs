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
    public class TipoGastosDAO
    {
        TipoGastosModel tipoGastosModelModel = new TipoGastosModel();
        public int quantidadeBD = 0;
        public int resQuantSearch;
        public string registroInserido = "";
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
        public void Salvar(int idtipound, string nomegasto)
        {
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM tipogastos WHERE nomegasto = @nomegasto", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@nomegasto", nomegasto);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                classeConecta.FecharCon();

                if (dtp.Rows.Count > 0)
                {
                    var resultado = MessageBox.Show("O Registro: " +
                    Convert.ToString(nomegasto) +
                    ", se encotra na base de dados. " + "\n" +
                    "Para confirmar a inserção duplicada, clique no botão 'Sim', e 'Não' para cancelar.",
                    "Aviso de Duplicidade",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {//(idtipogasto, idtipound, nomegasto)  (@idtipogasto, @idtipound, @nomegasto)


                        /* classeConecta.AbrirCon();
                        sql = "INSERT INTO origem (nomeorigem, codorigem) VALUES (@nomeorigem,@codorigem)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@nomeorigem", nomeorigem);
                        cmd.Parameters.AddWithValue("@codorigem", codorigem);
                        cmd.ExecuteNonQuery();
                        acaoCrudDAO = "S!!";
                        classeConecta.FecharCon();*/



                        classeConecta.AbrirCon();
                        sql = "INSERT INTO tipogastos ( idtipound, nomegasto) VALUES ( @idtipound, @nomegasto)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@idtipound", idtipound);
                        cmd.Parameters.AddWithValue("@nomegasto", nomegasto);
                        cmd.ExecuteNonQuery();
                        registroInserido = "S!!";
                        classeConecta.FecharCon();

                    }
                    else if (resultado == DialogResult.No)
                    {
                        registroInserido = "NS";
                      

                    }
                }
                else if (dtp.Rows.Count == 0)
                {
                    classeConecta.AbrirCon();
                    sql = "INSERT INTO tipogastos ( idtipound, nomegasto) VALUES ( @idtipound, @nomegasto)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idtipound", idtipound);
                    cmd.Parameters.AddWithValue("@nomegasto", nomegasto);
                    cmd.ExecuteNonQuery();
                    registroInserido = "S!";
                    classeConecta.FecharCon();
                }
               
            }catch (Exception ex){
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex,
                    "Erro na classe PessoaDAO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        public void Editar(int idtipound, string nomegasto, int idtipogasto)
        {
            try
            {
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE tipogastos SET " +
                    " idtipound         =       @idtipound," +
                    " nomegasto         =       @nomegasto " +
                    " WHERE idtipogasto =       @idtipogasto", classeConecta.con);
                cmd.Parameters.AddWithValue("@idtipound", idtipound);
                cmd.Parameters.AddWithValue("@nomegasto", nomegasto);
                cmd.Parameters.AddWithValue("@idtipogasto", idtipogasto);
                cmd.ExecuteNonQuery();
                registroInserido = "AT";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex);
            }

        }

        public void Excluir(int idtipogasto)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + Convert.ToString(idtipogasto), "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM tipogastos where idtipogasto = @idtipogasto";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idtipogasto", idtipogasto);
                    cmd.ExecuteNonQuery();
                    classeConecta.FecharCon();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir " + ex);
                    classeConecta.FecharCon();
                }
            }
            else if (resultado == DialogResult.No)
            {

            }
        }
        public DataTable ListarEmComboBox()
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM tipogastos ";
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

        public DataTable Listar(string listar)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM tipogastos where nomegasto LIKE @nomegasto";
                cmd = new MySqlCommand(sql, classeConecta.con);
                cmd.Parameters.AddWithValue("@nomeund", listar + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                quantidadeBD = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
                
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }


        public int ListarTodosRegistrosBD()
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM tipogastos";
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
       
                classeConecta.FecharCon();
                return dt.Rows.Count;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int ListarPesquisados()
        {
            int retornoPesquisado;
            retornoPesquisado = resQuantSearch;
            return retornoPesquisado;
        }

        public string VerificarPersistencia()
        {
            string retornoExistente;
            retornoExistente = registroInserido;
            return retornoExistente;
        }

        public DataTable ListarEmDataGrid(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * from tipogastos ORDER BY " + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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
                sql = "SELECT * FROM tipogastos where " + coluna + " Like " + campo + "";
              //  sql = "SELECT * FROM tipogastos where nomegasto Like " + campo + "";
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
                resQuantSearch = dt.Rows.Count;
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
                sql = "SELECT * FROM tipogastos where " + coluna + " Like " + campo + "";
                //    sql = "SELECT * FROM tipogastos where nomegasto Like  " + campo + "";
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

                resQuantSearch = dt.Rows.Count;
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
                sql = "SELECT * FROM tipogastos where " + coluna + " Like " + campo + "";
                //sql = "SELECT * FROM tipogastos where nomegasto Like  " + campo + "";
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
                resQuantSearch = dt.Rows.Count;
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