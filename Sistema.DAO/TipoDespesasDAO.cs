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
using Sistema.Model;

namespace Sistema.DAO
{
  public class TipoDespesasDAO
    {
        TipoDespesasModel modelTipoDespesas = new TipoDespesasModel();
        public int quantidadeBD = 0;
        public int quantidadePaginada = 0;
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

        // Metodo Salvar registroInserido
        public void Salvar(TipoDespesasModel modelTipoDespesas)
        {
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM tipodespesas where nomedespesa = @nomedespesa", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@nomedespesa", "56fds4g6a5sdf46g5afdsg");
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                if (dtp.Rows.Count > 0)
                {
                    var resultado = MessageBox.Show("O Registro " + Convert.ToString(modelTipoDespesas.Nomedespesa) + " Contagem dtp.Rows.Count : " + Convert.ToString(dtp.Rows.Count) + " já se encontra, no banco de dados do sistema. " + "\n" + "Para confirmar a inserção duplicada, clique no botão 'Sim'. E no botão 'Não' para cancelar.", "Aviso de Duplicidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        sql = "INSERT INTO tipodespesas (nomedespesa) VALUES (@nomedespesa)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@nomedespesa", modelTipoDespesas.Nomedespesa);
                        cmd.ExecuteNonQuery();
                        //    MessageBox.Show("Registro Salvo com Sucesso!", "Registro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        registroInserido = "S!!";
                        classeConecta.FecharCon();

                    }
                    else if (resultado == DialogResult.No)
                    {

                        registroInserido = "NS";
                        classeConecta.FecharCon();

                    }
                }
                else if (dtp.Rows.Count == 0)
                {
                    sql = "INSERT INTO tipodespesas (nomedespesa) VALUES (@nomedespesa)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@nomedespesa", modelTipoDespesas.Nomedespesa);
                    cmd.ExecuteNonQuery();
                    //  MessageBox.Show("Registro Salvo com Sucesso!", "Registro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    registroInserido = "S!";
                    classeConecta.FecharCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex, "Erro na classe PessoaDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Editar(TipoDespesasModel modelTipoDespesas)
        {
            try
            {
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE tipodespesas SET nomedespesa = @nomedespesa WHERE idtipodespesa = @idtipodespesa", classeConecta.con);
                cmd.Parameters.AddWithValue("@nomedespesa", modelTipoDespesas.Nomedespesa);
                cmd.Parameters.AddWithValue("@idtipodespesa", modelTipoDespesas.Idtipodespesa);
                cmd.ExecuteNonQuery();
                registroInserido = "ATP";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex);
            }

        }

        public void Excluir(TipoDespesasModel modelTipoDespesas)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + Convert.ToString(modelTipoDespesas.Nomedespesa), "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM tipodespesas where idtipodespesa = @idtipodespesa";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idtipodespesa", modelTipoDespesas.Idtipodespesa);
                    cmd.ExecuteNonQuery();
                    classeConecta.FecharCon();
                    MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public DataTable Listar(string ordenarpor)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM tipodespesas where nomedespesa LIKE @nomedespesa";
                cmd = new MySqlCommand(sql, classeConecta.con);
                cmd.Parameters.AddWithValue("@nomedespesa", modelTipoDespesas.Nomedespesa + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                quantidadeBD = dt.Rows.Count;
                return dt;
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }


        public int ListarTodosRegistrosBD()
        {
            int todosresgistros;
            classeConecta.AbrirCon();
            try
            {
                sql = "SELECT * FROM tipodespesas";
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt = new DataTable();
                da.Fill(dt);
                todosresgistros = dt.Rows.Count;
                return todosresgistros;
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

        public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * from tipodespesas ORDER BY " + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
                classeConecta.FecharCon();
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
                sql = "SELECT * FROM tipodespesas where nomedespesa Like " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);

                if (pesquisar == "")
                {
                    cmd.Parameters.AddWithValue(campo, "");
                }
                else
                {
                    //   cmd.Parameters.AddWithValue(campo, pesquisar + "%");
                    //   cmd.Parameters.AddWithValue(campo, "%" + pesquisar + "%");
                    cmd.Parameters.AddWithValue(campo, "%" + pesquisar);
                }



                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                resQuantSearch = dt.Rows.Count;
                return dt;
                classeConecta.FecharCon();
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
                sql = "SELECT * FROM tipodespesas where nomedespesa Like  " + campo + "";
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
                return dt;
                classeConecta.FecharCon();

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
                sql = "SELECT * FROM tipodespesas where nomedespesa Like  " + campo + "";

                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == "")
                {
                    cmd.Parameters.AddWithValue(campo, "");
                }
                else
                {
                    cmd.Parameters.AddWithValue(campo, pesquisar + "%");
                    //   cmd.Parameters.AddWithValue(campo, "%" + pesquisar + "%");
                }


                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                resQuantSearch = dt.Rows.Count;
                return dt;
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}