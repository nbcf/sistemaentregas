using MySql.Data.MySqlClient;
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

        public void Salvar(PapeisModel modelPapeis)
        {
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM papeis where nomepapel = @nomepapel", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@nomepapel", modelPapeis.Nomepapel);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                if (dtp.Rows.Count == 0)
                {
                    sql = "INSERT INTO papeis (nomepapel, criar, recuperar, atualizar, excluir, menuope, menuadmin, menugen) VALUES (@nomepapel, @criar, @recuperar, @atualizar, @excluir, @menuope, @menuadmin, @menugen)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@nomepapel", modelPapeis.Nomepapel);
                    cmd.Parameters.AddWithValue("@criar", modelPapeis.Criar);
                    cmd.Parameters.AddWithValue("@recuperar", modelPapeis.Recuperar);
                    cmd.Parameters.AddWithValue("@atualizar", modelPapeis.Atualizar);
                    cmd.Parameters.AddWithValue("@excluir", modelPapeis.Excluir);
                    cmd.Parameters.AddWithValue("@menuope", modelPapeis.Menuope);
                    cmd.Parameters.AddWithValue("@menuadmin", modelPapeis.Menuadmin);
                    cmd.Parameters.AddWithValue("@menugen", modelPapeis.Menugen);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Salvo com Sucesso!", "Registro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    registroInserido = "S!";
                    classeConecta.FecharCon();
                }

                else  if (dtp.Rows.Count > 0)
                {
                    
                    MessageBox.Show("Registro Já Existente no Banco de Dados", "Não Foi Possivel Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex, "Erro na classe PessoaDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Editar(PapeisModel modelPapeis)
        {
            string edicaoRepetida = modelPapeis.Nomepapel;
            int dadoEncontrado = modelPapeis.Idpapel;
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM papeis where nomepapel = @nomepapel ", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@nomepapel", modelPapeis.Nomepapel);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                if (dtp.Rows.Count == 0)
                {
                    sql = "INSERT INTO papeis (nomepapel, criar, recuperar, atualizar, excluir, menuope, menuadmin, menugen) VALUES (@nomepapel, @criar, @recuperar, @atualizar, @excluir, @menuope, @menuadmin, @menugen)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@nomepapel",   modelPapeis.Nomepapel);
                    cmd.Parameters.AddWithValue("@criar",       modelPapeis.Criar);
                    cmd.Parameters.AddWithValue("@recuperar",   modelPapeis.Recuperar);
                    cmd.Parameters.AddWithValue("@atualizar",   modelPapeis.Atualizar);
                    cmd.Parameters.AddWithValue("@excluir",     modelPapeis.Excluir);
                    cmd.Parameters.AddWithValue("@menuope",     modelPapeis.Menuope);
                    cmd.Parameters.AddWithValue("@menuadmin",   modelPapeis.Menuadmin);
                    cmd.Parameters.AddWithValue("@menugen",     modelPapeis.Menugen);
                    cmd.ExecuteNonQuery();
                    registroInserido = "AT";
                    classeConecta.FecharCon();
                }

                else if (dtp.Rows.Count > 0)
                {
                    MessageBox.Show("Não é possível renomear para outro registro existente\n Da mesma forma a atualização do mesmo a ação é nula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //var resultado = MessageBox.Show("O Registro que está tentando editar: " +
                    //Convert.ToString(modelPapeis.Nomepapel) +
                    //", se encotra na base de dados. " +
                    //"\n\nForam encontrados: " + Convert.ToInt32(dtp.Rows.Count) +
                    //" Registros com o mesmo nome no campo 'Complemento'" +
                    //"\n" + "Para confirmar a ação, clique no botão 'Sim', e 'Não' para cancelar.",
                    //"Aviso de nome de Papel Repetido",
                    //MessageBoxButtons.OK,
                    //MessageBoxIcon.Question);
                    //if (resultado == DialogResult.Yes)
                    //{
                    //    sql = "INSERT INTO papeis (nomepapel, criar, recuperar, atualizar, excluir, menuope, menuadmin, menugen) VALUES (@nomepapel, @criar, @recuperar, @atualizar, @excluir, @menuope, @menuadmin, @menugen)";
                    //    cmd = new MySqlCommand(sql, classeConecta.con);
                    //    cmd.Parameters.AddWithValue("@nomepapel", modelPapeis.Nomepapel);
                    //    cmd.Parameters.AddWithValue("@criar", modelPapeis.Criar);
                    //    cmd.Parameters.AddWithValue("@recuperar", modelPapeis.Recuperar);
                    //    cmd.Parameters.AddWithValue("@atualizar", modelPapeis.Atualizar);
                    //    cmd.Parameters.AddWithValue("@excluir", modelPapeis.Excluir);
                    //    cmd.Parameters.AddWithValue("@menuope", modelPapeis.Menuope);
                    //    cmd.Parameters.AddWithValue("@menuadmin", modelPapeis.Menuadmin);
                    //    cmd.Parameters.AddWithValue("@menugen", modelPapeis.Menugen);
                    //    cmd.ExecuteNonQuery();
                    //    registroInserido = "AT";
                    //    classeConecta.FecharCon();
                    //}
                    //else if (resultado == DialogResult.No)
                    //{
                        registroInserido = "NS";
                    //    classeConecta.FecharCon();
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex);
            }
        }



        public void Excluir(PapeisModel modelPapeis)
        {
            var resultado = MessageBox.Show("Confirmar exclusão do registro: " + Convert.ToString(modelPapeis.Nomepapel), "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM papeis where idpapel = @idpapel";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idpapel", modelPapeis.Idpapel);
                    cmd.ExecuteNonQuery();
                    classeConecta.FecharCon();
                    registroInserido = "DEL";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir " + ex);
                    classeConecta.FecharCon();
                }
            }
            else if (resultado == DialogResult.No)
            {
                registroInserido = "NDEL";
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
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM papeis";
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
                sql = "SELECT * from papeis ORDER BY " + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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