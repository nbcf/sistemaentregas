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
   public class GastosDAO
    {
        GastosModel modelGastos = new GastosModel();
        public int quantidadeBD = 0;
        public int quantidadePaginada = 0;
        public int resQuantSearch;
        public string acaoCrud = "";
        Sistema.Conexao.ClasseConexao classeConecta = new Sistema.Conexao.ClasseConexao();
        string sql;
        MySqlCommand cmd;
        MySqlCommand cmdVerificar;
        public bool conexao = false;
        public PapeisModel pmodelDAO;
        public PessoasModel pessmodelDAO;
        //acaoCrud

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

        // Metodo Salvar acaoCrud
        public void Salvar( int idsaida,
                            int idfornecedor,
                            int idtipogasto, 
                            string qtd,
                            string tipound,
                            string valorunitario,
                            string valortotal, 
                            string km, 
                            DateTime datagasto, 
                            string numeronota,
                            string imgnota)
        {
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM gastos where numeronota = @numeronota", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@usuario", modelGastos.Numeronota);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                if (dtp.Rows.Count > 0)
                {
                    var resultado = MessageBox.Show("O Registro " + Convert.ToString(modelGastos.Numeronota) + " Contagem dtp.Rows.Count : " + Convert.ToString(dtp.Rows.Count) + " já se encontra, no banco de dados do sistema. " + "\n" + "Para confirmar a inserção duplicada, clique no botão 'Sim'. E no botão 'Não' para cancelar.", "Aviso de Duplicidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {

                    sql = "INSERT INTO gastos (" +
                            "idsaida," +
                            "idfornecedor," +
                            "idtipogasto," +
                            "qtd," +
                            "tipound," +
                            "valorunitario," +
                            "valototal," +
                            "km," +
                            "datagasto," +
                            "numeronota," +
                            "imgnota" +
                            ") VALUES (" +
                            "@idsaida," +
                            "@idfornecedor," +
                            "@idtipogasto," +
                            "@qtd," +
                            "@tipound," +
                            "@valorunitario," +
                            "@valototal," +
                            "@km," +
                            "@datagasto," +
                            "@numeronota," +
                            "@imgnota)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@idsaida",         idsaida);
                        cmd.Parameters.AddWithValue("@idfornecedor",    idfornecedor);
                        cmd.Parameters.AddWithValue("@idtipogasto",     idtipogasto);
                        cmd.Parameters.AddWithValue("@qtd",             qtd);
                        cmd.Parameters.AddWithValue("@tipound",         tipound);
                        cmd.Parameters.AddWithValue("@valorunitario",   valorunitario);
                        cmd.Parameters.AddWithValue("@valortotal",      valortotal);
                        cmd.Parameters.AddWithValue("@km",              km);
                        cmd.Parameters.AddWithValue("@datagasto",       datagasto);
                        cmd.Parameters.AddWithValue("@numeronota",      numeronota);
                        cmd.Parameters.AddWithValue("@imgnota",         imgnota);
                        cmd.ExecuteNonQuery();
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

                    sql = "INSERT INTO gastos (" +
                            "idsaida," +
                            "idfornecedor," +
                            "idtipogasto," +
                            "qtd," +
                            "tipound," +
                            "valorunitario," +
                            "valototal," +
                            "km," +
                            "datagasto," +
                            "numeronota," +
                            "imgnota" +
                            ")VALUES(" +
                            "@idsaida, " +
                            "@idfornecedor," +
                            "@idtipogasto," +
                            "@qtd," +
                            "@tipound," +
                            "@valorunitario," +
                            "@valototal," +
                            "@km," +
                            "@datagasto," +
                            "@numeronota," +
                            "@imgnota)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idsaida",         idsaida);
                    cmd.Parameters.AddWithValue("@idfornecedor",    idfornecedor);
                    cmd.Parameters.AddWithValue("@idtipogasto",     idtipogasto);
                    cmd.Parameters.AddWithValue("@qtd",             qtd);
                    cmd.Parameters.AddWithValue("@tipound",         tipound);
                    cmd.Parameters.AddWithValue("@valorunitario",   valorunitario);
                    cmd.Parameters.AddWithValue("@valortotal",      valortotal);
                    cmd.Parameters.AddWithValue("@km",              km);
                    cmd.Parameters.AddWithValue("@datagasto",       datagasto);
                    cmd.Parameters.AddWithValue("@numeronota",      numeronota);
                    cmd.Parameters.AddWithValue("@imgnota",         imgnota);
                    cmd.ExecuteNonQuery();
                   
                    acaoCrud = "S!";
                    classeConecta.FecharCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex, "Erro na classe PessoaDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Editar( int idsaida, 
                            int idfornecedor, 
                            int idtipogasto,
                            string qtd, 
                            string tipound,
                            string valorunitario, 
                            string valortotal, 
                            string km,
                            DateTime datagasto,
                            string numeronota,
                            string imgnota,
                            int idgasto){
            try{

                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE gastos SET  " +
                    "   idsaida         =   @idsaida," +
                    "   idfornecedor    =   @idfornecedor," +
                    "   idtipogasto     =   @idtipogasto, " +
                    "   qtd             =   @qtd," +
                    "   tipound         =   @tipound," +
                    "   valorunitario   =   @valorunitario," +
                    "   valortotal      =   @valortotal," +
                    "   km              =   @km," +
                    "   datagasto       =   @datagasto," +
                    "   numeronota      =   @numeronota," +
                    "   imgnota         =   @imgnota" +
                    "   WHERE   idgasto =   @idgasto", classeConecta.con);

                cmd.Parameters.AddWithValue("@idsaida",         idsaida);
                cmd.Parameters.AddWithValue("@idfornecedor",    idfornecedor);
                cmd.Parameters.AddWithValue("@idtipogasto",     idtipogasto);
                cmd.Parameters.AddWithValue("@qtd",             qtd);
                cmd.Parameters.AddWithValue("@tipound",         tipound);
                cmd.Parameters.AddWithValue("@valorunitario",   valorunitario);
                cmd.Parameters.AddWithValue("@valortotal",      valortotal);
                cmd.Parameters.AddWithValue("@km",              km);
                cmd.Parameters.AddWithValue("@datagasto",       datagasto);
                cmd.Parameters.AddWithValue("@numeronota",      numeronota);
                cmd.Parameters.AddWithValue("@imgnota",         imgnota);
                cmd.Parameters.AddWithValue("@idgasto",         idgasto);

                cmd.ExecuteNonQuery();
                acaoCrud = "AT";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex);
            }

        }

        public void Excluir(int idgasto)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + Convert.ToString(modelGastos.Numeronota), "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM gastos where idgasto = @idgasto";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idgasto", idgasto);
                    cmd.ExecuteNonQuery();
                    classeConecta.FecharCon();
                    //MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //public DataTable Listar(string ordenarpor)
        //{
        //    try
        //    {
        //        classeConecta.AbrirCon();
        //        sql = "SELECT * FROM gastos where despesa LIKE @despesa";
        //        cmd = new MySqlCommand(sql, classeConecta.con);
        //        cmd.Parameters.AddWithValue("@despesa", modelGastos.Despesa + "%");
        //        MySqlDataAdapter da = new MySqlDataAdapter();
        //        da.SelectCommand = cmd;
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        quantidadeBD = dt.Rows.Count;
        //        return dt;
        //        classeConecta.FecharCon();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;

        //    }
        //}


        public int ListarTodosRegistrosBD()
        {
            int todosresgistros;
            classeConecta.AbrirCon();
            try
            {
                sql = "SELECT * FROM gastos";
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




        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                classeConecta.AbrirCon();
              sql = "SELECT * FROM gastos gast " +
                    "INNER JOIN tipogastos tpg " +
                    "INNER JOIN tipounds tpu " +
                    "INNER JOIN saidas said " +
                    "INNER JOIN fornecedores fornecedor " +
                    "ON gast.idsaida = said.idsaida " +
                    "AND gast.idfornecedor = fornecedor.idfornecedor " +
                    "AND gast.idtipogasto = tpg.idtipogasto " +
                    "AND tpg.idtipound= tpu.idtipound " +
                    "ORDER BY "+ parametro +" "+ indexar+ " Limit " + offsett + "," + limitt;            
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


        public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * from gastos ORDER BY " + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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
                sql = "SELECT * FROM gastos where despesa Like " + campo + "";
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
                sql = "SELECT * FROM gastos where despesa Like  " + campo + "";
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
                sql = "SELECT * FROM gastos where despesa Like  " + campo + "";

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