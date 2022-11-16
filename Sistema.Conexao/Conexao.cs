using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Windows.Forms;

namespace Sistema.Conexao
{
  public class ClasseConexao
    {

        public string statusConexao = "Conexão Inexistente";
        //CONEXAO COM O BANCO DE DADOS LOCAL
        public string conec = "SERVER=localhost; DATABASE=sistemaentregas; UID=root; PWD=; PORT=3306;";
        public MySqlConnection con = null;



        public void AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
                statusConexao = "Instância de Conexão Aberta";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Abrir Conexão com o Banco de Dados!\n O Seguinte Erro foi relatado: " + ex + "\n O Estatus da Conexão se encontra: " + statusConexao, "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        public void FecharCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
                statusConexao = "Instância de Conexão Fechada";
            }
            catch (Exception ex)
            {
              MessageBox.Show("Erro ao Fechar Conexão com o Banco de Dados!\n O Seguinte Erro foi relatado: " + ex + "\n O Estatus da Conexão se encontra: " + statusConexao, "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





    }


}