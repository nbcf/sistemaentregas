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
 public   class EnderecosDAO
    {
        EnderecosModel enderecosModel = new EnderecosModel();
        public int quantidadeBD = 0;
        public int quantidadePaginada = 0;
        public int resQuantSearch;
        public string acaoCrud = "";
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
        public void Salvar(EnderecosModel modelEnderecos)
        {
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM enderecos where logradouro = @logradouro", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@logradouro", modelEnderecos.Logradouro);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                if (dtp.Rows.Count > 0)
                {
                    var resultado = MessageBox.Show("O Registro " + Convert.ToString(modelEnderecos.Logradouro) + " Contagem dtp.Rows.Count : " + Convert.ToString(dtp.Rows.Count) + " já se encontra, no banco de dados do sistema. " + "\n" + "Para confirmar a inserção duplicada, clique no botão 'Sim'. E no botão 'Não' para cancelar.", "Aviso de Duplicidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        sql = "INSERT INTO enderecos (logradouro,  bairro, cidade, uf, cep) VALUES (@logradouro, @bairro, @cidade, @uf, @cep)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@logradouro", modelEnderecos.Logradouro);
                        cmd.Parameters.AddWithValue("@bairro", modelEnderecos.Bairro);
                        cmd.Parameters.AddWithValue("@cidade", modelEnderecos.Cidade);
                        cmd.Parameters.AddWithValue("@uf", modelEnderecos.Uf);
                        cmd.Parameters.AddWithValue("@cep", modelEnderecos.Cep);
                        cmd.ExecuteNonQuery();
                        //    MessageBox.Show("Registro Salvo com Sucesso!", "Registro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        acaoCrud = "S!!";
                        classeConecta.FecharCon();

                    }
                    else if (resultado == DialogResult.No)
                    {

                        acaoCrud = "NS";
                        classeConecta.FecharCon();

                    }
                }
                else if (dtp.Rows.Count == 0)
                {
                    sql = "INSERT INTO enderecos (logradouro,  bairro, cidade, uf, cep) VALUES (@logradouro,  @bairro, @cidade, @uf, @cep)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@logradouro", modelEnderecos.Logradouro);
                    cmd.Parameters.AddWithValue("@bairro", modelEnderecos.Bairro);
                    cmd.Parameters.AddWithValue("@cidade", modelEnderecos.Cidade);
                    cmd.Parameters.AddWithValue("@uf", modelEnderecos.Uf);
                    cmd.Parameters.AddWithValue("@cep", modelEnderecos.Cep);
                    cmd.ExecuteNonQuery();
                    //  MessageBox.Show("Registro Salvo com Sucesso!", "Registro Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    acaoCrud = "S!";
                    classeConecta.FecharCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex, "Erro na classe PessoaDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void Editar(EnderecosModel modelEnderecos)
        {

       
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM enderecos where logradouro = @logradouro", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@logradouro", modelEnderecos.Logradouro);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                if (dtp.Rows.Count == 0)
                {
                    cmd = new MySqlCommand("UPDATE enderecos SET logradouro = @logradouro, bairro = @bairro, cidade = @cidade, uf = @uf, cep = @cep  WHERE idendereco = @idendereco", classeConecta.con);
                    cmd.Parameters.AddWithValue("@logradouro", modelEnderecos.Logradouro);
                   
                    cmd.Parameters.AddWithValue("@bairro", modelEnderecos.Bairro);
                    cmd.Parameters.AddWithValue("@cidade", modelEnderecos.Cidade);
                    cmd.Parameters.AddWithValue("@uf", modelEnderecos.Uf);
                    cmd.Parameters.AddWithValue("@cep", modelEnderecos.Cep);
                    cmd.Parameters.AddWithValue("@idendereco", modelEnderecos.Idendereco);
                    cmd.ExecuteNonQuery();
                    acaoCrud = "AT";
                    classeConecta.FecharCon();
                }

                else if (dtp.Rows.Count > 0)
                {
                    var resultado = MessageBox.Show("O Registro que está tentando editar: " +
                    Convert.ToString(modelEnderecos.Logradouro) +
                    ", se encotra na base de dados. " +
                    "\n\nForam encontrados: " + Convert.ToInt32(dtp.Rows.Count) +
                    " Registros com o mesmo nome no campo 'Complemento'" +
                    "\n" + "Para confirmar a ação, clique no botão 'Sim', e 'Não' para cancelar.",
                    "Aviso de nome de Papel Repetido",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        cmd = new MySqlCommand("UPDATE enderecos SET logradouro = @logradouro, bairro = @bairro, cidade = @cidade, uf = @uf, cep = @cep  WHERE idendereco = @idendereco", classeConecta.con);
                        cmd.Parameters.AddWithValue("@logradouro", modelEnderecos.Logradouro);
                      
                        cmd.Parameters.AddWithValue("@bairro", modelEnderecos.Bairro);
                        cmd.Parameters.AddWithValue("@cidade", modelEnderecos.Cidade);
                        cmd.Parameters.AddWithValue("@uf", modelEnderecos.Uf);
                        cmd.Parameters.AddWithValue("@cep", modelEnderecos.Cep);
                        cmd.Parameters.AddWithValue("@idendereco", modelEnderecos.Idendereco);
                        cmd.ExecuteNonQuery();
                        acaoCrud  = "AT";
                        classeConecta.FecharCon();
                    }
                    else if (resultado == DialogResult.No)
                    {
                        acaoCrud = "NS";
                        classeConecta.FecharCon();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex);
            }
        }

        public void Excluir(EnderecosModel modelEnderecos)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + Convert.ToString(modelEnderecos.Cep), "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM enderecos where idendereco = @idendereco";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idendereco", modelEnderecos.Idendereco);
                    cmd.ExecuteNonQuery();
                    classeConecta.FecharCon();
                    acaoCrud = "DEL";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir " + ex);
                    classeConecta.FecharCon();
                }
            }
            else if (resultado == DialogResult.No)
            {
                acaoCrud = "NDEL";
            }
        }

        public DataTable Listar(string ordenarpor)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM enderecos where logradouro LIKE @logradouro";
                cmd = new MySqlCommand(sql, classeConecta.con);
                cmd.Parameters.AddWithValue("@logradouro", enderecosModel.Logradouro + "%");
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
                sql = "SELECT * FROM enderecos";
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
            retornoExistente = acaoCrud;
            return retornoExistente;
        }

        public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * from enderecos ORDER BY " + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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