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
using System.Collections;

namespace Sistema.DAO
{
   public class GastosDAO{

        public int listarPesquisadosGastosDAO = 0;
        public string acaoCrudGastosDAO = "";

        ClasseConexao classeConecta = new ClasseConexao();
        string sql;
        MySqlCommand cmd;
        MySqlCommand cmdVerificar;
        public bool conexao = false;

        public string estConexao(){

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
                            string imgnota){
            try{
              
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM gastos where numeronota = @numeronota and idfornecedor = @idfornecedor", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@numeronota", numeronota);
                cmdVerificar.Parameters.AddWithValue("@idfornecedor", idfornecedor);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                classeConecta.FecharCon();

                if (dtp.Rows.Count > 0){

                    var resultado = MessageBox.Show("O Registro " + numeronota + " Contagem dtp.Rows.Count : " +
                        Convert.ToString(dtp.Rows.Count) +
                        " já se encontra, no banco de dados do sistema." +
                        " " + "\n" + "Para confirmar a inserção duplicada," +
                        " clique no botão 'Sim'. E no botão 'Não' para cancelar.",
                        "Aviso de Duplicidade", 
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    
                   if (resultado == DialogResult.Yes){

                     classeConecta.AbrirCon();
                     sql = "INSERT INTO gastos (" +
                            "idsaida," +
                            "idfornecedor," +
                            "idtipogasto," +
                            "qtd," +
                            "tipound," +
                            "valorunitario," +
                            "valortotal," +
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
                            "@valortotal," +
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
                        acaoCrudGastosDAO = "S!!";
                        classeConecta.FecharCon();

                    }else if (resultado == DialogResult.No){
                        acaoCrudGastosDAO = "NS";
                    }

                }else if (dtp.Rows.Count == 0){
                    classeConecta.AbrirCon();
                    sql = "INSERT INTO gastos (" +
                            "idsaida," +
                            "idfornecedor," +
                            "idtipogasto," +
                            "qtd," +
                            "tipound," +
                            "valorunitario," +
                            "valortotal," +
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
                            "@valortotal," +
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
                    acaoCrudGastosDAO = "S!";
                    classeConecta.FecharCon();
                }

            }catch (Exception ex){
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex, "Erro na classe GastosDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                acaoCrudGastosDAO = "AT";
                classeConecta.FecharCon();

            }catch (Exception ex){
                MessageBox.Show("Erro ao Editar " + ex);
            }

        }

        public void Excluir(int idgasto){
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + idgasto, "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes){
                try{
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM gastos where idgasto = @idgasto";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idgasto", idgasto);
                    cmd.ExecuteNonQuery();
                    acaoCrudGastosDAO = "DEL";
                    classeConecta.FecharCon();

                }catch (Exception ex){
                    MessageBox.Show("Erro ao Excluir " + ex);
                }

            }else if (resultado == DialogResult.No){
                    acaoCrudGastosDAO = "NDEL";
            }
        }


        public int ListarGridBDGastosDAO(){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM gastos";
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


        public int ListarPesquisadosGastosDAO(){
            return listarPesquisadosGastosDAO;
        }

        public string AcaoCrudGastosDAO(){
            return acaoCrudGastosDAO;
        }

        public DataTable ListarDataGridAddSaida(int idsaida) {
            try{
                classeConecta.AbrirCon();
                sql = "SELECT  forn.fornecedor,  " +
                     "tpg.nomegasto,  " +
                     "tpu.nomeund, " +
                     "gts.qtd, " +
                     "gts.valorunitario, " +
                     "gts.valortotal, " +
                     "gts.numeronota,  " +
                     "gts.datagasto, " +
                     "gts.km, " +
                     "gts.idgasto, " +
                     "sai.idsaida, " +
                     "forn.idfornecedor, " +
                     "tpg.idtipogasto, " +
                     "tpu.idtipound " +

                     "FROM gastos gts " +
                     "INNER JOIN tipogastos tpg " +
                     "INNER JOIN tipounds tpu " +
                     "INNER JOIN saidas sai " +
                     "INNER JOIN fornecedores forn " +

                     "ON gts.idsaida = sai.idsaida " +
                     "AND gts.idfornecedor = forn.idfornecedor " +
                     "AND gts.idtipogasto = tpg.idtipogasto " +
                     "AND gts.tipound = tpu.idtipound " +

                     "WHERE gts.idsaida = "+ idsaida + "  order by idgasto asc";
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                classeConecta.FecharCon();
                return dt;
            } catch (Exception ex){
                throw ex;
            }
        }



        public DataTable ListarDataGridINNERJOIN(string parametro, string indexar, int offsett, int limitt){
            try{
                classeConecta.AbrirCon();
                 sql = " SELECT * FROM gastos gast " +
                       " INNER JOIN tipogastos tpg " +
                       " INNER JOIN saidas said " +
                       " INNER JOIN fornecedores forn " +
                       " ON gast.idsaida = said.idsaida " +
                       " AND gast.idfornecedor = forn.idfornecedor " +
                       " AND gast.idtipogasto = tpg.idtipogasto " +
                       " ORDER BY "+ parametro +" "+ indexar+ " Limit " + offsett + "," + limitt;            
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


        public DataTable ListarDataGridGastosDAO(string parametro, string indexar, int offsett, int limitt){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * from gastos ORDER BY " + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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
                //(string coluna, string campo, string pesquisar){
                sql = "SELECT * FROM gastos where despesa Like " + campo + "";
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
                listarPesquisadosGastosDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;

            }catch (Exception ex){
                throw ex;
            }
        }

        public DataTable PesquisarContem(string coluna, string campo, string pesquisar){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM gastos where despesa Like  " + campo + "";
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
                listarPesquisadosGastosDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
            }catch (Exception ex){
                throw ex;
            }
        }

        public DataTable PesquisarTermina(string coluna, string campo, string pesquisar){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM gastos where despesa Like  " + campo + "";
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
                listarPesquisadosGastosDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;

            }catch (Exception ex){

                throw ex;
            }
        }
    }
}