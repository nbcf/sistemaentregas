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
   public class VeiculosDAO
    {  
        public int registrosEncontradosPesquisaVeiculosDAO = 0;
        public string acaoCrudVeiculosDAO = "";
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

        public void Salvar(string nomeveiculo, string placa, string estatusveiculo)
        {
            int registrosLinhas;
            try{
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM veiculos where placa = @placa", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@placa", placa);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                registrosLinhas = dtp.Rows.Count;
                classeConecta.FecharCon();

                if (registrosLinhas > 0){

                    var resultado = MessageBox.Show("O Registro Veículo: " + nomeveiculo+" Placa: "+placa + " Contagem dtp.Rows.Count : " + Convert.ToString(dtp.Rows.Count) + " já se encontra, no banco de dados do sistema. " + "\n" + "Para confirmar a inserção duplicada, clique no botão 'Sim'. E no botão 'Não' para cancelar.", "Aviso de Duplicidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes){

                        classeConecta.AbrirCon();
                        sql = "INSERT INTO veiculos (nomeveiculo, placa, estatusveiculo) VALUES (@nomeveiculo, @placa, @estatusveiculo)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@nomeveiculo", nomeveiculo);
                        cmd.Parameters.AddWithValue("@placa", placa);
                        cmd.Parameters.AddWithValue("@estatusveiculo", estatusveiculo);
                        cmd.ExecuteNonQuery();
                        acaoCrudVeiculosDAO = "S!!";
                        classeConecta.FecharCon();

                    }else if (resultado == DialogResult.No) {
                        acaoCrudVeiculosDAO = "NS";
                     
                    }

                }else if (registrosLinhas == 0){
                    classeConecta.AbrirCon();
                    sql = "INSERT INTO veiculos (nomeveiculo, placa, estatusveiculo) VALUES (@nomeveiculo, @placa, @estatusveiculo)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@nomeveiculo", nomeveiculo);
                    cmd.Parameters.AddWithValue("@placa", placa);
                    cmd.Parameters.AddWithValue("@estatusveiculo", estatusveiculo);
                    cmd.ExecuteNonQuery();
                    acaoCrudVeiculosDAO = "S!";
                    classeConecta.FecharCon();
                }
            }catch (Exception ex){
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado em VeiculosDAO " + ex, "Erro na classe VeiculosDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Editar(string nomeveiculo, string placa, string estatusveiculo, int idveiculo){
            try{
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE veiculos SET " +
                    "nomeveiculo        =       @nomeveiculo, " +
                    "placa              =       @placa, " +
                    "estatusveiculo     =       @estatusveiculo " +
                    "WHERE idveiculo    =       @idveiculo", classeConecta.con);

                cmd.Parameters.AddWithValue("@nomeveiculo",         nomeveiculo);
                cmd.Parameters.AddWithValue("@placa",               placa);
                cmd.Parameters.AddWithValue("@estatusveiculo",      estatusveiculo);
                cmd.Parameters.AddWithValue("@idveiculo",           idveiculo);
                cmd.ExecuteNonQuery();
                acaoCrudVeiculosDAO = "AT";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex);
            }

        }

        public void EditarEstatusVeiculo(string nomeveiculo, string placa, string estatusveiculo, int idveiculo){
            try{
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE veiculos SET " +
                    " nomeveiculo       =   @nomeveiculo," +
                    " placa             =   @placa," +
                    " estatusveiculo    =   @estatusveiculo" +
                    " WHERE idveiculo   =   @idveiculo", classeConecta.con);

                cmd.Parameters.AddWithValue("@nomeveiculo",     nomeveiculo);
                cmd.Parameters.AddWithValue("@placa",           placa);
                cmd.Parameters.AddWithValue("@estatusveiculo",  estatusveiculo);
                cmd.Parameters.AddWithValue("@idveiculo",       idveiculo);
                cmd.ExecuteNonQuery();
                acaoCrudVeiculosDAO = "ATESTATUS";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex);
            }

        }

        public void Excluir(int idveiculo)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + idveiculo, "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes){
                try{
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM veiculos where idveiculo = @idveiculo";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idveiculo", idveiculo);
                    cmd.ExecuteNonQuery();
                    acaoCrudVeiculosDAO = "DEL";
                    classeConecta.FecharCon();

                }catch (Exception ex){ 
                    MessageBox.Show("A Seguinte Excessão foi lançada quando o método Excluir foi operado " + ex, "Erro na classe VeiculosDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (resultado == DialogResult.No){
                acaoCrudVeiculosDAO = "NDEL";
            }
        }


        public int ListarTodosRegistrosBD()
        {
            
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM veiculos";
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


        public int ListarVeiculosEncontradosDAO() {
            return registrosEncontradosPesquisaVeiculosDAO;
        }

        public string AcaoCrudVeiculosDAO() {
            return acaoCrudVeiculosDAO;
        }


        public DataTable ListarVeiculosEmComboBoxDAO(){

            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM veiculos";
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

        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * from veiculos ORDER BY " + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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


        public DataTable ConfiListagemImportVS(){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * from veiculos WHERE estatusveiculo = 'Disponivel' or estatusveiculo = ''";
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
                sql = "SELECT * FROM veiculos where "+coluna+" Like " + campo + "";
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
                registrosEncontradosPesquisaVeiculosDAO = dt.Rows.Count;
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
                sql = "SELECT * FROM veiculos where " +coluna+ " Like " + campo + "";
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
                registrosEncontradosPesquisaVeiculosDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
               

            }catch (Exception ex){
                throw ex;
            }
        }

        public DataTable PesquisarTermina(string coluna, string campo, string pesquisar) {
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM veiculos where " +coluna+ " Like " + campo + "";
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
                registrosEncontradosPesquisaVeiculosDAO = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;

            }catch (Exception ex){

                throw ex;
            }
        }
    }
}