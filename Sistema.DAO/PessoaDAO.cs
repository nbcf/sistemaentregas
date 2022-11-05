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
    public class PessoaDAO
    {
        PessoasModel pessoaModel = new PessoasModel();
 
        public int listarQtPesquisa = 0;
        public string acaoCrudPessoaDAO = "";
        Sistema.Conexao.ClasseConexao classeConecta = new Sistema.Conexao.ClasseConexao();
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

        // Metodo Salvar registroInserido
        public void Salvar(PessoasModel modelPessoa)
        {
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM pessoas where nomepessoa = @nomepessoa", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@nomepessoa", modelPessoa.Nomepessoa);
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                classeConecta.FecharCon();
                if (dtp.Rows.Count > 0)
                {
                    var resultado = MessageBox.Show("O Registro: " +
                    Convert.ToString(modelPessoa.Nomepessoa) +
                    ", se encotra na base de dados. " + "\n" +
                    "Para confirmar a inserção duplicada, clique no botão 'Sim', e 'Não' para cancelar.",
                    "Aviso de Duplicidade",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes){
                        classeConecta.AbrirCon();
                        sql = "INSERT INTO pessoas (idendereco, nomepessoa, complemento) VALUES (@idendereco,@nomepessoa, @complemento)";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@idendereco", modelPessoa.Idendereco);
                        cmd.Parameters.AddWithValue("@nomepessoa", modelPessoa.Nomepessoa);
                        cmd.Parameters.AddWithValue("@complemento", modelPessoa.Complemento);
                        cmd.ExecuteNonQuery();
                        acaoCrudPessoaDAO = "S!!";
                        classeConecta.FecharCon();

                    }else if (resultado == DialogResult.No){
                        acaoCrudPessoaDAO = "NS";
                    }
                }
                else if (dtp.Rows.Count == 0)
                {
                    classeConecta.AbrirCon();
                    sql = "INSERT INTO pessoas (idendereco, nomepessoa, complemento) VALUES (@idendereco,@nomepessoa, @complemento)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idendereco", modelPessoa.Idendereco);
                    cmd.Parameters.AddWithValue("@nomepessoa", modelPessoa.Nomepessoa);
                    cmd.Parameters.AddWithValue("@complemento", modelPessoa.Complemento);
                    cmd.ExecuteNonQuery();
                    acaoCrudPessoaDAO = "S!";
                    classeConecta.FecharCon();
                }
            }catch (Exception ex) {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex, "Erro na classe PessoaDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        public void Editar(PessoasModel modelPessoa){
            try{
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE pessoas SET " +
                    "idendereco = @idendereco, " +
                    "nomepessoa = @nomepessoa, " +
                    "complemento = @complemento  " +
                    "WHERE idpessoa = @idpessoa", classeConecta.con);
                cmd.Parameters.AddWithValue("@idendereco", modelPessoa.Idendereco);
                cmd.Parameters.AddWithValue("@nomepessoa", modelPessoa.Nomepessoa);
                cmd.Parameters.AddWithValue("@complemento", modelPessoa.Complemento);
                cmd.Parameters.AddWithValue("@idpessoa", modelPessoa.Idpessoa);
                cmd.ExecuteNonQuery();
                acaoCrudPessoaDAO = "AT";
                classeConecta.FecharCon();
            }catch (Exception ex){
                MessageBox.Show("Erro ao Editar " + ex);
            }
           
        }

        public void Excluir(PessoasModel modelPessoa)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro "+Convert.ToString(modelPessoa.Nomepessoa), "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes){
                try{
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM pessoas where idpessoa = @idpessoa";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idpessoa", modelPessoa.Idpessoa);
                    cmd.ExecuteNonQuery();
                    acaoCrudPessoaDAO = "DEL";
                    classeConecta.FecharCon();
                }catch (Exception ex){
                    MessageBox.Show("Erro ao Excluir " + ex);
                }
            } else if (resultado == DialogResult.No){
                acaoCrudPessoaDAO = "NDEL";
            }
        }

        public int ListarQtBDPessoaDAO(){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM pessoas";
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                classeConecta.FecharCon();
                return dt.Rows.Count;
            } catch (Exception ex){
                throw ex;
            }
        }


        public int ListarPesquisados(){
            return listarQtPesquisa;
        }

        public string AcaoCrudPessoaDAO(){
            return acaoCrudPessoaDAO;
        }

        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * from pessoas ORDER BY " + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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


        public DataTable ListarDataGridInnerJoin(string parametro, string indexar, int offsett, int limitt){
            try {
                classeConecta.AbrirCon();
                sql = "SELECT * from pessoas pes INNER JOIN enderecos ende on pes.idendereco = ende.idendereco ORDER BY " + parametro + "   " + indexar + " Limit " + offsett + "," + limitt;
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

        public DataTable PesquisarComeca(string coluna , string campo, string pesquisar) {
            try{
                classeConecta.AbrirCon();
                sql = "SELECt * from pessoas pes " +
                    "inner join enderecos ende " +
                    "on pes.idendereco = ende.idendereco " +
                    "where pes.nomepessoa Like "+campo+"";
                cmd = new MySqlCommand(sql, classeConecta.con);
                    if (pesquisar == ""){
                        cmd.Parameters.AddWithValue(campo, "");
                    } else{
                        cmd.Parameters.AddWithValue(campo, pesquisar + "%"); 
                    }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                listarQtPesquisa = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
            } catch (Exception ex){
                throw ex;
            }
        }

        public DataTable PesquisarContem(string coluna, string campo, string pesquisar){
            try {
                classeConecta.AbrirCon();
                sql = "SELECt * from pessoas pes inner join enderecos ende on pes.idendereco = ende.idendereco where pes.nomepessoa Like " + campo + "";
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
                listarQtPesquisa = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
            }catch (Exception ex){
                throw ex;
            }
        }

        public DataTable PesquisarTermina(string coluna, string campo, string pesquisar){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * from pessoas pes inner join enderecos ende on pes.idendereco = ende.idendereco where pes.nomepessoa Like " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);
                    if (pesquisar == ""){
                        cmd.Parameters.AddWithValue(campo, "");
                    }else{
                        cmd.Parameters.AddWithValue(campo, "%"+ pesquisar);
                    }
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                listarQtPesquisa = dt.Rows.Count;
                classeConecta.FecharCon();
                return dt;
            }catch (Exception ex) {
                throw ex;
            }
        }
    }
}
