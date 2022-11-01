﻿using MySql.Data.MySqlClient;
using Sistema.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema.DAO
{
    public class SaidasDAO
    {
        SaidasModel saidaModel = new SaidasModel();
        public int quantidadeBD = 0;
        //public int quantidadePaginada = 0;
        public int resQuantSearch;
        public string registroInserido = "";
        Sistema.Conexao.ClasseConexao classeConecta = new Sistema.Conexao.ClasseConexao();
        string sql;
        MySqlCommand cmd;
        MySqlCommand cmdVerificar;
        public bool conexao = false;
        public VeiculosModel veiculoModelDAO;
        public PessoasModel pessoaModelDAO;
        public PapeisModel funcaoModelDAO;

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
        public void Salvar(SaidasModel modelSaida)
        {
            try
            {
                classeConecta.AbrirCon();
                    sql = "INSERT INTO saidas (idveiculo," +
                        " idusuario, " +
                        "idpapel, " +
                        "idpessoa, " +
                        "nomeveiculo," +
                        " placa, " +
                        "entregador, " +
                        "datasaida, " +
                        "dataretorno, " +
                        "horasaida, " +
                        "horaretorno, " +
                        "estsaida, " +
                        "regiaoentrega, " +
                        "kmsaida, " +
                        "kmretorno, " +
                        "kmtotal) " +
                        "VALUES (@idveiculo, " +
                        "@idusuario, " +
                        "@idpapel, " +
                        "@idpessoa, " +
                        "@nomeveiculo, " +
                        "@placa, " +
                        "@entregador, " +
                        "@datasaida, " +
                        "@dataretorno, " +
                        "@horasaida, " +
                        "@horaretorno, " +
                        "@estsaida, " +
                        "@regiaoentrega," +
                        " @kmsaida, " +
                        "@kmretorno, " +
                        "@kmtotal)";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idveiculo", modelSaida.Idveiculo);
                    cmd.Parameters.AddWithValue("@idusuario", modelSaida.Idusuario);
                    cmd.Parameters.AddWithValue("@idpapel", modelSaida.Idpapel);
                    cmd.Parameters.AddWithValue("@idpessoa", modelSaida.Idpessoa);
                    cmd.Parameters.AddWithValue("@nomeveiculo", modelSaida.Nomeveiculo);
                    cmd.Parameters.AddWithValue("@placa", modelSaida.Placa);
                    cmd.Parameters.AddWithValue("@entregador", modelSaida.Entregador);
                    cmd.Parameters.AddWithValue("@datasaida", modelSaida.Datasaida);
                    cmd.Parameters.AddWithValue("@dataretorno", modelSaida.Dataretorno);
                    cmd.Parameters.AddWithValue("@horasaida", modelSaida.Horasaida);
                    cmd.Parameters.AddWithValue("@horaretorno", modelSaida.Horaretorno);
                    cmd.Parameters.AddWithValue("@estsaida", modelSaida.Estsaida);
                    cmd.Parameters.AddWithValue("@regiaoentrega", modelSaida.Regiaoentrega);
                    cmd.Parameters.AddWithValue("@kmsaida", modelSaida.Kmsaida);
                    cmd.Parameters.AddWithValue("@kmretorno", modelSaida.Kmretorno);
                    cmd.Parameters.AddWithValue("@kmtotal", modelSaida.Kmtotal);
                    cmd.ExecuteNonQuery();
                    registroInserido = "S!";
                    classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Seguinte Excessão foi lançada quando o método Salvar foi operado " + ex, "Erro na classe PessoaDAO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }




        public void Editar(SaidasModel modelSaida)
        {
            try
            {
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE saidas SET " +
                             " idveiculo        =   @idveiculo, " +
                             " idusuario        =   @idusuario, " +
                             " idpapel          =   @idpapel," +
                             " idpessoa         =   @idpessoa," +
                             " nomeveiculo      =   @nomeveiculo," +
                             " placa            =   @placa," +
                             " entregador       =   @entregador," +
                             " datasaida        =   @datasaida," +
                             " dataretorno      =   @dataretorno," +
                             " horasaida        =   @horasaida," +
                             " horaretorno      =   @horaretorno," +
                             " estsaida         =   @estsaida," +
                             " regiaoentrega    =   @regiaoentrega," +
                             " kmsaida          =   @kmsaida, " +
                             " kmretorno        =   @kmretorno," +
                             " kmtotal          =   @kmtotal " +
                               "WHERE idsaida   =   @idsaida", classeConecta.con);

                cmd.Parameters.AddWithValue("@idveiculo",       modelSaida.Idveiculo);
                cmd.Parameters.AddWithValue("@idusuario",       modelSaida.Idusuario);
                cmd.Parameters.AddWithValue("@idpapel",         modelSaida.Idpapel);
                cmd.Parameters.AddWithValue("@idpessoa",        modelSaida.Idpessoa);

                cmd.Parameters.AddWithValue("@nomeveiculo",     modelSaida.Nomeveiculo);
                cmd.Parameters.AddWithValue("@placa",           modelSaida.Placa);
                cmd.Parameters.AddWithValue("@entregador",      modelSaida.Entregador);

                cmd.Parameters.AddWithValue("@datasaida",       modelSaida.Datasaida);
                cmd.Parameters.AddWithValue("@dataretorno",     modelSaida.Dataretorno);
                cmd.Parameters.AddWithValue("@horasaida",       modelSaida.Horasaida);
                cmd.Parameters.AddWithValue("@horaretorno",     modelSaida.Horaretorno);

                cmd.Parameters.AddWithValue("@estsaida",        modelSaida.Estsaida);
                cmd.Parameters.AddWithValue("@regiaoentrega",   modelSaida.Regiaoentrega);
                cmd.Parameters.AddWithValue("@kmsaida",         modelSaida.Kmsaida);
                cmd.Parameters.AddWithValue("@kmretorno",       modelSaida.Kmretorno);
                cmd.Parameters.AddWithValue("@kmtotal",         modelSaida.Kmtotal);

                cmd.Parameters.AddWithValue("@idsaida",         modelSaida.Idsaida);
                cmd.ExecuteNonQuery();
                registroInserido = "AT";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex);
            }
          
        }


        public void EditarFimDeRota(SaidasModel modelSaida)
        {
            try
            {
                classeConecta.AbrirCon();
                cmd = new MySqlCommand("UPDATE saidas SET " +
                             " idveiculo        =   @idveiculo, " +
                             " idusuario        =   @idusuario, " +
              //               " idpapel          =   @idpapel," +
                 //            " idpessoa         =   @idpessoa," +
                             " estsaida         =   @estsaida" +
                             " WHERE idsaida    =   @idsaida", classeConecta.con);

                cmd.Parameters.AddWithValue("@idveiculo", modelSaida.Idveiculo);
                cmd.Parameters.AddWithValue("@idusuario", modelSaida.Idusuario);
         //       cmd.Parameters.AddWithValue("@idpapel", modelSaida.Idpapel);
            //    cmd.Parameters.AddWithValue("@idpessoa", modelSaida.Idpessoa);
                cmd.Parameters.AddWithValue("@estsaida", modelSaida.Estsaida);
                cmd.Parameters.AddWithValue("@idsaida", modelSaida.Idsaida);
                cmd.ExecuteNonQuery();
                registroInserido = "AT";
                classeConecta.FecharCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex);
            }

        }

        public void Excluir(SaidasModel modelSaida)
        {
                try
                {
                    classeConecta.AbrirCon();
                    sql = "DELETE FROM saidas where idsaida = @idsaida";
                    cmd = new MySqlCommand(sql, classeConecta.con);
                    cmd.Parameters.AddWithValue("@idsaida", modelSaida.Idsaida);
                    cmd.ExecuteNonQuery();
                    classeConecta.FecharCon();
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir " + ex);
                    classeConecta.FecharCon();
                }
        
        }

        public DataTable ListarSaidaGasto(){
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM saidas WHERE estsaida = 'Em Rota'";
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

        public int ListarTodosRegistrosBD(){
            try{
                classeConecta.AbrirCon();
                sql = "SELECT * FROM saidas";
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

        public DataTable UltimoRegistro()
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM saidas ORDER BY idsaida DESC LIMIT 1";
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

        public DataTable ConfiListagemDataGrid(string parametro, string estatusSaida , string indexar, int offsett, int limitt)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM saidas sai " +
                    "INNER JOIN usuarios usuario " +
                    "INNER JOIN papeis pap " +
                    "INNER JOIN pessoas pess " +
                    "INNER JOIN veiculos veic " +
                    "ON  sai.idveiculo = veic.idveiculo " +
                    "AND sai.idusuario = usuario.idusuario " +
                    "AND usuario.idpapel = pap.idpapel " +
                    "AND usuario.idpessoa = pess.idpessoa " +
                    "WHERE sai.estsaida = '"+ estatusSaida +"' " +
                    "ORDER BY pess.nomepessoa " + indexar + " Limit " + offsett + "," + limitt;
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


        public DataTable ListEstSaidaDataGrid(string estsaidas)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM saidas where estsaida = '" + estsaidas + "'";
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

        //ConfiListagemDataGridInnerJoin
        public DataTable ConfiListagemDataGridInnerJoin(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                classeConecta.AbrirCon();
                sql = "SELECT * FROM saidas sai " +
                    "INNER JOIN veiculos veic " +
                    "INNER JOIN usuarios entregador " +
                    "INNER JOIN papeis pap " +
                    "INNER JOIN pessoas pess " +
                    "ON sai.idveiculo = veic.idveiculo " +
                    "AND sai.idusuario = entregador.idusuario " +
                    "AND entregador.idpapel = pap.idpapel " +
                    "AND entregador.idpessoa = pess.idpessoa " +
                    "ORDER BY " + parametro + "   " + indexar + " Limit " + offsett + "," + limitt;
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
                sql = "SELECT * FROM saidas said " +
                    "INNER JOIN enderecos ende " +
                    "INNER JOIN usuarios usu  " +
                    "INNER JOIN papeis pape  " +
                    "INNER JOIN pessoas pes  " +
                    "INNER JOIN veiculos veic " +
                    "ON said.idveiculo = veic.idveiculo " +
                    "AND said.idusuario = usu.idusuario " +
                    "AND usu.idpessoa = pes.idpessoa " +
                    "AND usu.idpapel = pape.idpapel " +
                    "WHERE pes.nomepessoa Like " + campo + "";
                //sql = "SELECT * FROM saidas pes where pes.nomepessoa Like pes." + campo + " INNER JOIN enderecos ende on pes.idendereco = ende.idendereco";
                //   sql = "SELECT * FROM saidas where nomepessoa Like "+campo+"";
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
                // sql = "SELECt * from saidas pes inner join enderecos ende on pes.idendereco = ende.idendereco where pes.nomepessoa Like " + campo + "";
                //  sql = "SELECT * FROM saidas where nomepessoa Like  " + campo + "";
                sql = "SELECT * FROM saidas said " +
                    "INNER JOIN enderecos ende " +
                    "INNER JOIN usuarios usu  " +
                    "INNER JOIN papeis pape  " +
                    "INNER JOIN pessoas pes  " +
                    "INNER JOIN veiculos veic " +
                    "ON said.idveiculo = veic.idveiculo " +
                    "AND said.idusuario = usu.idusuario " +
                    "AND usu.idpessoa = pes.idpessoa " +
                    "AND usu.idpapel = pape.idpapel " +
                    "WHERE pes.nomepessoa Like " + campo + "";
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
                // sql = "SELECT * from saidas pes inner join enderecos ende on pes.idendereco = ende.idendereco where pes.nomepessoa Like " + campo + "";
                //sql = "SELECT * FROM saidas pes where pes.nomepessoa Like pes." + campo+" INNER JOIN enderecos ende on pes.idendereco = ende.idendereco";
                //sql = "SELECT * FROM saidas where nomepessoa Like  " + campo + "";
                sql = "SELECT * FROM saidas said " +
                    "INNER JOIN enderecos ende " +
                    "INNER JOIN usuarios usu  " +
                    "INNER JOIN papeis pape  " +
                    "INNER JOIN pessoas pes  " +
                    "INNER JOIN veiculos veic " +
                    "ON said.idveiculo = veic.idveiculo " +
                    "AND said.idusuario = usu.idusuario " +
                    "AND usu.idpessoa = pes.idpessoa " +
                    "AND usu.idpapel = pape.idpapel " +
                    "WHERE pes.nomepessoa Like " + campo + "";
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
