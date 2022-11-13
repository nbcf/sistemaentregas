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
    public class EncomendasDAO
    {
        EncomendasModel encomendasModel = new EncomendasModel();
        public int quantidadeBD = 0;
        public int quantidadeBDEstatus = 0;
        public int quantidadePaginada = 0;
        public int resQuantSearch;
        public string acaoCrud = "";
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

        public void Salvar(EncomendasModel encomendasModel)
        {
            try
            {
                classeConecta.AbrirCon();
                cmdVerificar = new MySqlCommand("SELECT * FROM encomendas where numpacote = @numpacote and estentrega = @estentrega", classeConecta.con);
                cmdVerificar.Parameters.AddWithValue("@numpacote", encomendasModel.Numpacote);
                cmdVerificar.Parameters.AddWithValue("@estentrega", "Saiu para entrega");
                MySqlDataAdapter dap = new MySqlDataAdapter();
                dap.SelectCommand = cmdVerificar;
                DataTable dtp = new DataTable();
                dap.Fill(dtp);
                if (dtp.Rows.Count > 0)
                {
                    var resultado = MessageBox.Show("O Registro " + Convert.ToString(encomendasModel.Estentrega) + " Contagem dtp.Rows.Count : " + Convert.ToString(dtp.Rows.Count) + " já se encontra, no banco de dados do sistema. " +
                                    "\n" + "Para confirmar a inserção duplicada, clique no botão 'Sim'. E no botão 'Não' para cancelar.",
                                    "Aviso de Duplicidade",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        sql = "INSERT INTO encomendas (  idorigem," +
                                                     "  idveiculo," +
                                                     "  identregador," +
                                                     "  nomeveiculo," +
                                                     "  placa," +
                                                     "  entregador," +
                                                     "  peso," +
                                                     "  numpacote," +
                                                     "  estentrega," +
                                                     "  cpf," +
                                                     "  destinatario," +
                                                     "  logradouro," +
                                                     "  complemento," +
                                                     "  bairro," +
                                                     "  cidade," +
                                                     "  uf," +
                                                     "  cep," +
                                                     "  dataentrega," +
                                                     "  datarota," +
                                                     "  dataentrada," +
                                                     "  idsaida)" +
                                                 "VALUES(@idorigem," +
                                                     "  @idveiculo," +
                                                     "  @identregador," +
                                                     "  @nomeveiculo," +
                                                     "  @placa," +
                                                     "  @entregador," +
                                                     "  @peso," +
                                                     "  @numpacote," +
                                                     "  @estentrega," +
                                                     "  @cpf," +
                                                     "  @destinatario," +
                                                     "  @logradouro," +
                                                     "  @complemento," +
                                                     "  @bairro," +
                                                     "  @cidade," +
                                                     "  @uf," +
                                                     "  @cep," +
                                                     "  @dataentrega," +
                                                     "  @datarota," +
                                                     "  @dataentrada," +
                                                     "  @idsaida )";
                        cmd = new MySqlCommand(sql, classeConecta.con);
                        cmd.Parameters.AddWithValue("@idorigem",        encomendasModel.Idorigem);
                        cmd.Parameters.AddWithValue("@idveiculo",       encomendasModel.Idveiculo);
                        cmd.Parameters.AddWithValue("@identregador",    encomendasModel.Identregador);
                        cmd.Parameters.AddWithValue("@nomeveiculo",     encomendasModel.Nomeveiculo);
                        cmd.Parameters.AddWithValue("@placa",           encomendasModel.Placa);
                        cmd.Parameters.AddWithValue("@entregador",      encomendasModel.Entregador);
                        cmd.Parameters.AddWithValue("@peso",            encomendasModel.Peso);
                        cmd.Parameters.AddWithValue("@numpacote",       encomendasModel.Numpacote);
                        cmd.Parameters.AddWithValue("@estentrega",      encomendasModel.Estentrega);
                        cmd.Parameters.AddWithValue("@cpf",             encomendasModel.Cpf);
                        cmd.Parameters.AddWithValue("@destinatario",    encomendasModel.Destinatario);
                        cmd.Parameters.AddWithValue("@logradouro",      encomendasModel.Logradouro);
                        cmd.Parameters.AddWithValue("@complemento",     encomendasModel.Complemento);
                        cmd.Parameters.AddWithValue("@bairro",          encomendasModel.Bairro);
                        cmd.Parameters.AddWithValue("@cidade",          encomendasModel.Cidade);
                        cmd.Parameters.AddWithValue("@uf",              encomendasModel.Uf);
                        cmd.Parameters.AddWithValue("@cep",             encomendasModel.Cep);
                        cmd.Parameters.AddWithValue("@dataentrega",     encomendasModel.Dataentrega);
                        cmd.Parameters.AddWithValue("@datarota",        encomendasModel.Datarota);
                        cmd.Parameters.AddWithValue("@dataentrada",     encomendasModel.Dataentrada);
                        cmd.Parameters.AddWithValue("@idsaida",         encomendasModel.Idsaida);
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
                    sql = "INSERT INTO encomendas     (  idorigem," +
                                                      "  idveiculo," +
                                                      "  identregador," +
                                                      "  nomeveiculo," +
                                                      "  placa," +
                                                      "  entregador," +
                                                      "  peso," +
                                                      "  numpacote," +
                                                      "  estentrega," +
                                                      "  cpf," +
                                                      "  destinatario," +
                                                      "  logradouro," +
                                                      "  complemento," +
                                                      "  bairro," +
                                                      "  cidade," +
                                                      "  uf," +
                                                      "  cep," +
                                                      "  dataentrega," +
                                                      "  datarota," +
                                                      "  dataentrada," +
                                                      "  idsaida)" +
                                                  "VALUES(@idorigem," +
                                                      "  @idveiculo," +
                                                      "  @identregador," +
                                                      "  @nomeveiculo," +
                                                      "  @placa," +
                                                      "  @entregador," +
                                                      "  @peso," +
                                                      "  @numpacote," +
                                                      "  @estentrega," +
                                                      "  @cpf," +
                                                      "  @destinatario," +
                                                      "  @logradouro," +
                                                      "  @complemento," +
                                                      "  @bairro," +
                                                      "  @cidade," +
                                                      "  @uf," +
                                                      "  @cep," +
                                                      "  @dataentrega," +
                                                      "  @datarota," +
                                                      "  @dataentrada," +
                                                      "  @idsaida )";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idorigem",        encomendasModel.Idorigem);
                    cmd.Parameters.AddWithValue("@idveiculo",       encomendasModel.Idveiculo);
                    cmd.Parameters.AddWithValue("@identregador",    encomendasModel.Identregador);
                    cmd.Parameters.AddWithValue("@nomeveiculo",     encomendasModel.Nomeveiculo);
                    cmd.Parameters.AddWithValue("@placa",           encomendasModel.Placa);
                    cmd.Parameters.AddWithValue("@entregador",      encomendasModel.Entregador);
                    cmd.Parameters.AddWithValue("@peso",            encomendasModel.Peso);
                    cmd.Parameters.AddWithValue("@numpacote",       encomendasModel.Numpacote);
                    cmd.Parameters.AddWithValue("@estentrega",      encomendasModel.Estentrega);
                    cmd.Parameters.AddWithValue("@cpf",             encomendasModel.Cpf);
                    cmd.Parameters.AddWithValue("@destinatario",    encomendasModel.Destinatario);
                    cmd.Parameters.AddWithValue("@logradouro",      encomendasModel.Logradouro);
                    cmd.Parameters.AddWithValue("@complemento",     encomendasModel.Complemento);
                    cmd.Parameters.AddWithValue("@bairro",          encomendasModel.Bairro);
                    cmd.Parameters.AddWithValue("@cidade",          encomendasModel.Cidade);
                    cmd.Parameters.AddWithValue("@uf",              encomendasModel.Uf);
                    cmd.Parameters.AddWithValue("@cep",             encomendasModel.Cep);
                    cmd.Parameters.AddWithValue("@dataentrega",     encomendasModel.Dataentrega);
                    cmd.Parameters.AddWithValue("@datarota",        encomendasModel.Datarota);
                    cmd.Parameters.AddWithValue("@dataentrada",     encomendasModel.Dataentrada);
                    cmd.Parameters.AddWithValue("@idsaida",         encomendasModel.Idsaida);
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

        public void Editar(EncomendasModel encomendasModel)
        {

            try
            {
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE encomendas SET " +
                        "  idorigem  	=  @idorigem," +
                        "  idveiculo	=  @idveiculo," +
                        "  identregador =  @identregador," +
                        "  nomeveiculo 	=  @nomeveiculo," +
                        "  placa 		=  @placa," +
                        "  entregador 	=  @entregador," +
                        "  peso			=  @peso," +
                        "  numpacote 	=  @numpacote," +
                        "  estentrega 	=  @estentrega," +
                        "  cpf	        =  @cpf," +
                        "  destinatario =  @destinatario," +
                        "  logradouro	=  @logradouro," +
                        "  complemento	=  @complemento," +
                        "  bairro		=  @bairro," +
                        "  cidade		=  @cidade," +
                        "  uf 			=  @uf," +
                        "  cep			=  @cep," +
                        "  dataentrega	=  @dataentrega," +
                        "  datarota	    =  @datarota," +
                        "  dataentrada	=  @dataentrada," +
                        "  idsaida		=  @idsaida" +
                        "  WHERE idencomenda	=  @idencomenda", classeConecta.con);
                cmd.Parameters.AddWithValue("@idorigem",        encomendasModel.Idorigem);
                cmd.Parameters.AddWithValue("@idveiculo",       encomendasModel.Idveiculo);
                cmd.Parameters.AddWithValue("@identregador",    encomendasModel.Identregador);
                cmd.Parameters.AddWithValue("@nomeveiculo",     encomendasModel.Nomeveiculo);
                cmd.Parameters.AddWithValue("@placa",           encomendasModel.Placa);
                cmd.Parameters.AddWithValue("@entregador",      encomendasModel.Entregador);
                cmd.Parameters.AddWithValue("@peso",            encomendasModel.Peso);
                cmd.Parameters.AddWithValue("@numpacote",       encomendasModel.Numpacote);
                cmd.Parameters.AddWithValue("@estentrega",      encomendasModel.Estentrega);
                cmd.Parameters.AddWithValue("@cpf",             encomendasModel.Cpf);
                cmd.Parameters.AddWithValue("@destinatario",    encomendasModel.Destinatario);
                cmd.Parameters.AddWithValue("@logradouro",      encomendasModel.Logradouro);
                cmd.Parameters.AddWithValue("@complemento",     encomendasModel.Complemento);
                cmd.Parameters.AddWithValue("@bairro",          encomendasModel.Bairro);
                cmd.Parameters.AddWithValue("@cidade",          encomendasModel.Cidade);
                cmd.Parameters.AddWithValue("@uf",              encomendasModel.Uf);
                cmd.Parameters.AddWithValue("@cep",             encomendasModel.Cep);
                cmd.Parameters.AddWithValue("@dataentrega",     encomendasModel.Dataentrega);
                cmd.Parameters.AddWithValue("@datarota",        encomendasModel.Datarota);
                cmd.Parameters.AddWithValue("@dataentrada",     encomendasModel.Dataentrada);
                cmd.Parameters.AddWithValue("@idsaida",         encomendasModel.Idsaida);
                cmd.Parameters.AddWithValue("@idencomenda",     encomendasModel.Idencomenda);
                cmd.ExecuteNonQuery();
                acaoCrud = "AT";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Editar na classe EncomendasVO foi operado" + ex);
            }
        }

        public void EditarSaidaEncomendaRota(EncomendasModel encomendasModel)
        {
            try
            {
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE encomendas SET " +
                        "  idorigem  	=  @idorigem," +
                        "  idveiculo	=  @idveiculo," +
                        "  identregador =  @identregador," +
                        "  estentrega 	=  @estentrega," +
                        "  idsaida		=  @idsaida," +
                        "  datarota	    =  @datarota" +
                        "  WHERE idencomenda	=  @idencomenda",
                classeConecta.con);
                cmd.Parameters.AddWithValue("@idorigem", encomendasModel.Idorigem);
                cmd.Parameters.AddWithValue("@idveiculo", encomendasModel.Idveiculo);
                cmd.Parameters.AddWithValue("@identregador", encomendasModel.Identregador);
                cmd.Parameters.AddWithValue("@estentrega", encomendasModel.Estentrega);
                cmd.Parameters.AddWithValue("@idsaida", encomendasModel.Idsaida);
                cmd.Parameters.AddWithValue("@datarota", encomendasModel.Datarota);
                cmd.Parameters.AddWithValue("@idencomenda", encomendasModel.Idencomenda);
                cmd.ExecuteNonQuery();
                acaoCrud = "AT";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método EditarSaidaEncomendaRota na classe EncomendasVO foi operado" + ex);
            }

        }

        public void EditarSaidaEncomendaRotaDel(EncomendasModel encomendasModel)
        {
            try
            {
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE encomendas SET " +
                        "  idorigem  	=  @idorigem," +
                        "  idveiculo	    =       @idveiculo," +
                        "  identregador     =       @identregador," +
                        "  nomeveiculo      =       @nomeveiculo,"+
                        "  placa            =       @placa," +
                        "  entregador       =       @entregador," +
                        "  estentrega 	    =       @estentrega," +
                        "  idsaida		    =       @idsaida," +
                        "  WHERE idencomenda	=   @idencomenda", classeConecta.con);
                cmd.Parameters.AddWithValue("@idorigem",        encomendasModel.Idorigem);
                cmd.Parameters.AddWithValue("@idveiculo",       encomendasModel.Idveiculo);
                cmd.Parameters.AddWithValue("@identregador",    encomendasModel.Identregador);
                cmd.Parameters.AddWithValue("@nomeveiculo",     encomendasModel.Nomeveiculo);
                cmd.Parameters.AddWithValue("@placa",           encomendasModel.Placa);
                cmd.Parameters.AddWithValue("@entregador",      encomendasModel.Entregador);
                cmd.Parameters.AddWithValue("@estentrega",      encomendasModel.Estentrega);
                cmd.Parameters.AddWithValue("@idsaida",         encomendasModel.Idsaida);
                cmd.Parameters.AddWithValue("@idencomenda",     encomendasModel.Idencomenda);


                cmd.ExecuteNonQuery();
                acaoCrud = "AT";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método EditarSaidaEncomendaRotaDel na classe EncomendasVO foi operado" + ex);
            }

        }
            public void EditarSaidaEncomendaEntregue(EncomendasModel encomendasModel)
            {

                try
                {
                    classeConecta.AbrirCon();
                    cmd = new MySqlCommand(
                  "     UPDATE encomendas SET " +
                  "     idorigem  	    =   @idorigem," +
                  "     idveiculo	    =   @idveiculo," +
                  "     identregador    =   @identregador," +
                  "     nomeveiculo 	=   @nomeveiculo," +
                  "     placa 		    =   @placa," +
                  "     entregador 	    =   @entregador," +
                  "     peso			=   @peso," +
                  "     numpacote 	    =   @numpacote," +
                  "     estentrega 	    =   @estentrega," +
                  "     idsaida		    =   @idsaida," +
                  "     destinatario    =   @destinatario," +
                  "     logradouro	    =   @logradouro," +
                  "     complemento	    =   @complemento," +
                  "     bairro		    =   @bairro," +
                  "     cidade		    =   @cidade," +
                  "     uf 			    =   @uf," +
                  "     cep			    =   @cep," +
                  "     dataentrega	    =   @dataentrega," +
                  "     cpf	            =   @cpf" +
                  "     WHERE idencomenda	=  @idencomenda",classeConecta.con);
                cmd.Parameters.AddWithValue("@idorigem",        encomendasModel.Idorigem);
                cmd.Parameters.AddWithValue("@idveiculo",       encomendasModel.Idveiculo);
                cmd.Parameters.AddWithValue("@identregador",    encomendasModel.Identregador);
                cmd.Parameters.AddWithValue("@nomeveiculo",     encomendasModel.Nomeveiculo);
                cmd.Parameters.AddWithValue("@placa",           encomendasModel.Placa);
                cmd.Parameters.AddWithValue("@entregador",      encomendasModel.Entregador);
                cmd.Parameters.AddWithValue("@peso",            encomendasModel.Peso);
                cmd.Parameters.AddWithValue("@numpacote",       encomendasModel.Numpacote);
                cmd.Parameters.AddWithValue("@estentrega",      encomendasModel.Estentrega);
                cmd.Parameters.AddWithValue("@idsaida",         encomendasModel.Idsaida);
                cmd.Parameters.AddWithValue("@destinatario",    encomendasModel.Destinatario);
                cmd.Parameters.AddWithValue("@logradouro",      encomendasModel.Logradouro);
                cmd.Parameters.AddWithValue("@complemento",     encomendasModel.Complemento);
                cmd.Parameters.AddWithValue("@bairro",          encomendasModel.Bairro);
                cmd.Parameters.AddWithValue("@cidade",          encomendasModel.Cidade);
                cmd.Parameters.AddWithValue("@uf",              encomendasModel.Uf);
                cmd.Parameters.AddWithValue("@cep",             encomendasModel.Cep);
                cmd.Parameters.AddWithValue("@dataentrega",     encomendasModel.Dataentrega);
                cmd.Parameters.AddWithValue("@cpf",             encomendasModel.Cpf);
                cmd.Parameters.AddWithValue("@idencomenda",     encomendasModel.Idencomenda);
                cmd.ExecuteNonQuery();
                    acaoCrud = "AT";
                    classeConecta.FecharCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A Seguinte Excessão foi lançada quando o método EditarSaidaEncomendaEntregue na classe EncomendasVO foi operado" + ex);
                }
            }



        public void Excluir(int idencomenda)
        {
            var resultado = MessageBox.Show("Confirmar excluisão do registro " + Convert.ToString(encomendasModel.Numpacote), "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM encomendas where idencomenda = @idencomenda";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idencomenda", idencomenda);
                    cmd.ExecuteNonQuery();
                    acaoCrud = "DEL";
                    classeConecta.FecharCon();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A Seguinte Excessão foi lançada quando o método Excluir na classe EncomendasVO foi operado" + ex);
                }
            }
            else if (resultado == DialogResult.No) {
                acaoCrud = "NDEL";

            }
            
        }

        public DataTable Listar(string ordenarpor)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas where numpacote LIKE @numpacote";
                cmd = new MySqlCommand(sql, classeConecta.con);
                cmd.Parameters.AddWithValue("@numpacote", encomendasModel.Numpacote + "%");
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

        public int ListarTodosRegistrosBD(){
           
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas";
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                classeConecta.FecharCon();
                return dt.Rows.Count;

            }catch (Exception ex) {

                throw ex;
            }
        }

        public int ListarTodosRegistrosBDEstatus(string estatusencomenda){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                    "INNER JOIN origem ori " +
                    "ON  enco.idorigem = ori.idorigem " +
                    "WHERE enco.estentrega = '"+estatusencomenda+"'";
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt); 
                classeConecta.FecharCon();
                return dt.Rows.Count;
            }catch (Exception ex) {
                throw ex;
            }
        }
    
        public int ListarPesquisados()
        {
            return resQuantSearch;
        }

        public string AcaoCrud()
        {
            return acaoCrud;
        }

        public int ContarEncomendas(
            string stridsaida,
            int idveiculo,
            int identregador,
            string estentrega, 
            DateTime datarota){

            try
            {
            classeConecta.AbrirCon();
                sql = "  SELECT  COUNT(*) " +
                       " FROM encomendas enco " +
                       " WHERE enco.idsaida = '" + stridsaida + "'" +
                       " AND  enco.idveiculo = '" + idveiculo + "'" +
                       " AND  enco.identregador = '" + identregador + "'" +
                       " AND enco.estentrega = '" + estentrega + "'";
                cmd = new MySqlCommand(sql, classeConecta.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                classeConecta.FecharCon();
                return id;
                
            }catch (Exception ex){
                throw ex;
            }
        }

        public DataTable ListarEstatusDeEntrega(string estencomendas)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                    "" +
                    "INNER JOIN origem ori " +
                    "INNER JOIN saidas saida " +
                    "ON saida.idsaida = enco.idsaida " +
                    "WHERE enco.estentrega = '"+ estencomendas + "'";
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

        public DataTable ListarTodasEntregaSaida(
            string idsaida,
            string estencomendas,
            string parametro,
            string indexar, 
            int offsett,
            int limitt) {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                      "INNER JOIN origem ori " +
                      "ON  enco.idorigem = ori.idorigem " +
                      "WHERE enco.idsaida = '" + idsaida + "' " +
                      "AND enco.estentrega = '" + estencomendas + "' " +
                      "ORDER BY enco." + parametro+" "+ indexar + " Limit " + offsett + "," + limitt;
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

        public DataTable ListarEntregaSaida(string estencomendas, string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                      "INNER JOIN origem ori " +
                      "ON  enco.idorigem = ori.idorigem WHERE enco.estentrega = '"+ estencomendas +"' " +
                      "ORDER BY enco." + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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

        public DataTable ConfiListagemEstatusDeEntregaESaida(int idsaida, string estencomendas)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                      "INNER JOIN enderecos ende " +
                      "INNER JOIN origem ori " +
                      "ON enco.idendereco = ende.idendereco " +
                      "AND enco.idorigem = ori.idorigem " +
                      "WHERE enco.estencomendas = " + estencomendas + " " +
                      "AND enco.idsaida = " + idsaida + "";
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



        public DataTable ConfiListagemDataGrid(string idsaida, string estentrega, string parametro, string indexar, int offsett, int limitt)
        {
            try
            {//Em Transito
                classeConecta.AbrirCon();
               sql ="SELECT * FROM encomendas enco "+
                    "INNER JOIN origem ori "+
                    "ON enco.idorigem = ori.idorigem "+
                    "AND enco.idsaida = "+idsaida+" "+
                    "AND enco.estentrega = '"+estentrega+"' "+
                    "ORDER BY enco." + parametro + " " + indexar + " " +
                    "Limit " + offsett + "," + limitt;
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
     

        public DataTable ListarDetalheMestre(string idsaida, string estatusencomenda)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                      "INNER JOIN   origem ori " +
                      "ON    enco.idorigem = ori.idorigem " +
                      "WHERE enco.estentrega = '"+ estatusencomenda + "' AND enco.idsaida = '"+ idsaida + "'";  // "WHERE enco.idsaida ='" + idsaida+"'"+"AND  enco.estentrega = '"+ estatusencomenda + "'";
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

        public DataTable ListarDetalheMestreUnion(string idsaida, string estSaiuEntrega, string estEntregue)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT  " +
                    "  enco.estentrega AS ESTATUS,      " +
                    "  enco.dataentrega AS ENTREGUE,    " +
                    "  enco.numpacote AS PACOTE,        " +
                    "  enco.peso AS PESO                " +

                      " FROM encomendas enco            " + 
                      " INNER JOIN origem ori           " +
                      " ON enco.idorigem = ori.idorigem " +
                      
                      " WHERE   enco.estentrega     =   '"+ estSaiuEntrega + "'   " +
                      " AND     enco.idsaida        =   '"+ idsaida + "'          " +
                      
                      " UNION " +

                      " SELECT " +
                      " enco.estentrega AS ESTATUS,     " +
                      " enco.dataentrega AS ENTREGUE,   " +
                      " enco.numpacote AS PACOTE,       " +
                      " enco.peso AS PESO               " +

                      " FROM encomendas enco            " +
                      " INNER JOIN origem ori           " +
                      " ON enco.idorigem = ori.idorigem " +

                      " WHERE enco.estentrega   =   '" + estEntregue + "'" +
                      " AND enco.idsaida        =   '" + idsaida + "'";

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




        public DataTable ListarEncomendaImpotToSaida(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                classeConecta.AbrirCon();
                sql="SELECT * FROM encomendas enco " +
                    "INNER JOIN origem ori " +
                    "ON enco.idorigem = ori.idorigem " +
                    "WHERE enco.estentrega = 'Em Transito' " +
                    "AND enco.idsaida = '000'" +
                    "WHERE encomenda.idsaida = '000' ORDER BY enco." + parametro + " " + indexar + " Limit " + offsett + "," + limitt;
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



        public DataTable PesquisarComeca(string coluna, string campo, string pesquisar, string estencomendas)
        {
            try
            {
                classeConecta.AbrirCon();
                sql ="SELECT * FROM encomendas enco " +
                     "INNER JOIN origem ori " +
                     "ON enco.idorigem = ori.idorigem " +
                     "WHERE enco.estentrega = '"+ estencomendas +"' " + " AND "+ coluna + " LIKE " + campo + "";
                cmd = new MySqlCommand(sql, classeConecta.con);
                if (pesquisar == "")
                {
                    cmd.Parameters.AddWithValue(campo, "");
                }
                else
                {
                    cmd.Parameters.AddWithValue(campo,  pesquisar + "%");
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

        public DataTable PesquisarContem(string coluna, string campo, string pesquisar, string estencomendas)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                      "INNER JOIN origem ori " +
                      "ON enco.idorigem = ori.idorigem " +
                      "WHERE enco.estentrega = '" + estencomendas + "' " +
                      " AND " + coluna + " LIKE  " + campo + "";
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

        public DataTable PesquisarTermina(string coluna, string campo, string pesquisar, string estencomendas)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                     "INNER JOIN origem ori " +
                     "ON enco.idorigem = ori.idorigem " +
                     "WHERE enco.estentrega = '" + estencomendas + "' " +
                     "AND " + coluna + " LIKE  " + campo + "";
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
                classeConecta.FecharCon();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public DataTable ConfiListagemImportVS()
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                    "INNER JOIN origem ori " +
                    "ON enco.idorigem = ori.idorigem " +
                    "WHERE enco.estentrega = 'Em Transito' AND enco.idsaida = '000'";
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

        public DataTable PesquisarComecaImpES(string coluna, string campo, string pesquisar, string estencomendas)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                      "INNER JOIN enderecos ende " +
                      "INNER JOIN origem ori " +
                      "ON enco.idendereco = ende.idendereco " +
                      "AND enco.idorigem = ori.idorigem  " +
                      "WHERE enco.estencomendas = " + estencomendas + " " +
                      "AND " + coluna + " LIKE " + campo + "";
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

        public DataTable PesquisarContemImpES(string coluna, string campo, string pesquisar, string estencomendas)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                      "INNER JOIN enderecos ende " +
                      "INNER JOIN origem ori " +
                      "ON enco.idendereco = ende.idendereco " +
                      "AND enco.idorigem = ori.idorigem  " +
                      "WHERE enco.estencomendas = " + estencomendas + " " +
                      "AND " + coluna + " LIKE " + campo + "";
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

        public DataTable PesquisarTerminaImpES(string coluna, string campo, string pesquisar, string estencomendas)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM encomendas enco " +
                      "INNER JOIN enderecos ende " +
                      "INNER JOIN origem ori " +
                      "ON enco.idendereco = ende.idendereco " +
                      "AND enco.idorigem = ori.idorigem " +
                     "WHERE enco.estencomendas = " + estencomendas + " " +
                      "AND " + coluna + " LIKE " + campo + "";
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

    }
    }
