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
   public class FornecedoresDAO
    {
        public int regEncontradosPesquisa = 0;
        public string acaoCrudFornecedoresDAO = "";
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
        public void Salvar(string fornecedor){
            int registrosLinhas;
            try{

                classeConecta.AbrirCon();
                sql = "SELECT * FROM fornecedores where fornecedor = @fornecedor";
                cmdVerificar = new MySqlCommand(sql, classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@fornecedor", fornecedor);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                registrosLinhas = dtp.Rows.Count;
                classeConecta.FecharCon();

                if (registrosLinhas > 0){

                    var resultado = MessageBox.Show(
                    "O Registro: "+Convert.ToString(fornecedor) +
                    ", se encotra na base de dados. " + "\n" +
                    "Para confirmar a inserção duplicada," +
                    "clique no botão 'Sim', e 'Não' para cancelar.",
                    "Aviso de Duplicidade",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes){

                        classeConecta.AbrirCon();
                        sql = "INSERT INTO fornecedores (fornecedor) VALUES (@fornecedor)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
                        cmd.ExecuteNonQuery();
                        acaoCrudFornecedoresDAO = "S!!";
                        classeConecta.FecharCon();

                    }else if (resultado == DialogResult.No){
                        acaoCrudFornecedoresDAO = "NS";
                    }

                }else if (registrosLinhas == 0){

                    classeConecta.AbrirCon();
                    sql = "INSERT INTO fornecedores (fornecedor) VALUES (@fornecedor)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
                    cmd.ExecuteNonQuery();
                    acaoCrudFornecedoresDAO = "S!";
                    classeConecta.FecharCon();
                }

            }catch (Exception ex){
                    MessageBox.Show(
                   "A Seguinte Excessão foi lançada" +
                   " quando o método Salvar foi operado " + ex,
                    "Erro na classe FornecedoresDAO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        public void Editar(string fornecedor, int idfornecedor){
            
            try{

                classeConecta.AbrirCon();
                cmd = new MySqlCommand(
                    "   UPDATE fornecedores SET     " +
                    "   fornecedor = @fornecedor    " +
                    "   WHERE idfornecedor = @idfornecedor",
                classeConecta.con);
                cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
                cmd.Parameters.AddWithValue("@idfornecedor", idfornecedor);
                cmd.ExecuteNonQuery();
                acaoCrudFornecedoresDAO = "AT";
                classeConecta.FecharCon();

            }catch (Exception ex){
                MessageBox.Show(
                    "A Seguinte Excessão foi lançada" +
                    "quando o método Editar foi operado " + ex,
                    "Erro na classe FornecedoresDAO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        public void Excluir(int idfornecedor){

                var resultado = MessageBox.Show(
                "Confirmar excluisão do registro " 
                + idfornecedor,
                "Excluir Registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes){

                try{
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM fornecedores where idfornecedor = @idfornecedor";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idfornecedor", idfornecedor);
                    cmd.ExecuteNonQuery();
                    acaoCrudFornecedoresDAO = "DEL";
                    classeConecta.FecharCon();

                }catch (Exception ex){

                    MessageBox.Show(
                        "A Seguinte Excessão foi lançada" +
                        "quando o método Excluir foi operado " + ex,
                        "Erro na classe FornecedoresDAO",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }

            }else if (resultado == DialogResult.No){
                acaoCrudFornecedoresDAO = "NDEL";
            }
        }

        public DataTable ListarEmComboBox() {

            try{

                classeConecta.AbrirCon();
                sql = "SELECT * FROM fornecedores";
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

        public int ListarTodosVeiculosBD(){

            try{

                classeConecta.AbrirCon();
                sql = "SELECT * FROM fornecedores";
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

        public string AcaoCrudFornecedoresDAO(){
            return acaoCrudFornecedoresDAO;
        }

        public DataTable ListaDataGrid(string parametro, string indexar, int offsett, int limitt){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * from fornecedores  ORDER BY " +
                parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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
                sql = "SELECT * FROM fornecedores where " +
                coluna + " Like " + campo + "";
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

            }catch (Exception ex){
                throw ex;
            }
        }

        public DataTable PesquisarContem(string coluna, string campo, string pesquisar){
            try{

                classeConecta.AbrirCon();
                sql = "SELECT * FROM fornecedores where " + coluna + " Like " + campo + "";
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

        public DataTable PesquisarTermina(string coluna, string campo, string pesquisar){
            
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM fornecedores where " + coluna + " Like " + campo + "";
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
