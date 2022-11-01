using Sistema.DAO;
using Sistema.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Controller
{
   public class SaidasController
    {
        SaidasDAO dao = new SaidasDAO();
      
        SaidasModel modelSaida = new SaidasModel();
        public int encontrados;
        public int encontradosPesquisa;
        public string retornoPersistencia;


        public void Salvar(
                         int idveiculo,
                         int idusuario,
                         int idpapel,
                         int idpessoa,
                         string nomeveiculo,
                         string placa,
                         string entregador,

                         DateTime datasaida,
                         DateTime dataretorno,
                         string horasaida,
                         string horaretorno,

                         string estsaida,
                         string regiaoentrega,
                         string kmsaida,
                         string kmretorno,
                         string kmtotal){ 
            modelSaida.Idveiculo    = idveiculo;
            modelSaida.Idusuario    = idusuario;
            modelSaida.Idpapel      = idpapel;
            modelSaida.Idpessoa     = idpessoa;
            modelSaida.Nomeveiculo = nomeveiculo;
            modelSaida.Placa = placa;
            modelSaida.Entregador = entregador;
            modelSaida.Datasaida = datasaida;
            modelSaida.Dataretorno = dataretorno;
            modelSaida.Horasaida = horasaida;
            modelSaida.Horaretorno = horaretorno;
            modelSaida.Estsaida = estsaida;
            modelSaida.Regiaoentrega = regiaoentrega;
            modelSaida.Kmsaida = kmsaida;
            modelSaida.Kmretorno = kmretorno;
            modelSaida.Kmtotal = kmtotal;
            dao.Salvar(modelSaida);
            retornoRegistroSalvo();
        }

        public DataTable ListEstSaidaDataGrid(string estsaidas)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListEstSaidaDataGrid(estsaidas);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("O Metodo 'Listar' não foi Executada\n\nA seguinte execessão foi lançada: " + e, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public DataTable ListarSaidaGasto(){
            try{

                DataTable dt = new DataTable();
                return dt = dao.ListarSaidaGasto();

            }catch (Exception e){
                MessageBox.Show("O Metodo 'Listar' não foi Executada\n\nA seguinte execessão foi lançada: " + e, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        public void Excluir(int idsaida)
        {
            modelSaida.Idsaida = idsaida;
            dao.Excluir(modelSaida);
        }
      
                  
                
            public void Editar( 
                                int idveiculo,
                                int idusuario,
                                int idpapel,
                                int idpessoa,
                                string nomeveiculo,
                                string placa,
                                string entregador,
                                DateTime datasaida,
                                DateTime dataretorno,
                                string horasaida,
                                string horaretorno,
                                string estsaida,
                                string regiaoentrega,
                                string kmsaida,
                                string kmretorno,
                                string kmtotal, 
                                int idsaida){
            modelSaida.Idveiculo = idveiculo;
            modelSaida.Idusuario = idusuario;
            modelSaida.Idpapel = idpapel;
            modelSaida.Idpessoa = idpessoa;
            modelSaida.Nomeveiculo = nomeveiculo;
            modelSaida.Placa = placa;
            modelSaida.Entregador = entregador;
            modelSaida.Datasaida = datasaida;
            modelSaida.Dataretorno = dataretorno;
            modelSaida.Horasaida = horasaida;
            modelSaida.Horaretorno = horaretorno;
            modelSaida.Estsaida = estsaida;
            modelSaida.Regiaoentrega = regiaoentrega;
            modelSaida.Kmsaida = kmsaida;
            modelSaida.Kmretorno = kmretorno;
            modelSaida.Kmtotal = kmtotal;
            modelSaida.Idsaida = idsaida;
            dao.Editar(modelSaida);
            retornoRegistroSalvo();

        }

               public void EditarFimDeRota(
                   int idveiculo,
                   int idusuario,
              //     int idpapel,
                //   int idpessoa,
                   string estsaida,
                   int idsaida)
                        {
                            modelSaida.Idveiculo = idveiculo;
                            modelSaida.Idusuario = idusuario;
                        //    modelSaida.Idpapel = idpapel;
                         //   modelSaida.Idpessoa = idpessoa;
                            modelSaida.Estsaida = estsaida;
                            modelSaida.Idsaida = idsaida;
                            dao.EditarFimDeRota(modelSaida);
                            retornoRegistroSalvo();

                        }

        public int retornoQuantRegistro()
        {
            encontrados = dao.ListarTodosRegistrosBD();
            return encontrados;
        }

        public int retornoQuantPesquisa()
        {
            encontradosPesquisa = dao.ListarPesquisados();
            return encontradosPesquisa;
        }

        public string retornoRegistroSalvo()
        {
            retornoPersistencia = dao.VerificarPersistencia();
            return retornoPersistencia;

        }

        public DataTable UltimoRegistro()
        {
            DataTable dt = new DataTable();
            dt = dao.UltimoRegistro();
            return dt;

        }

        public DataTable ConfiListagemDataGrid(string parametro,string estatusSaida, string indexar, int offsett, int limitt)
        {
            try
            {
                retornoQuantRegistro();
                DataTable dt = new DataTable();
               dt = dao.ConfiListagemDataGrid(parametro, estatusSaida, indexar, offsett, limitt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("O Metodo 'ConfiListagemDataGrid' não foi Executada\n\nA seguinte execessão foi lançada: " + e,
                                "Aviso do Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw;
            }
        }

    

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarComeca(coluna, campo, pesquisar);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("O Metodo 'PesquisarComecaCom' não foi Executada\n\nA seguinte execessão foi lançada: " + e,
                                "Aviso do Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw;
            }

        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarContem(coluna, campo, pesquisar);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("O Metodo 'PesquisarContemCom' não foi Executada\n\nA seguinte execessão foi lançada: " + e,
                                "Aviso do Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw;
            }

        }
        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarTermina(coluna, campo, pesquisar);
                return dt;
            }
            catch (Exception e)
            {

                MessageBox.Show("O Metodo 'PesquisarTerminaCom' não foi Executada\n\nA seguinte execessão foi lançada: " + e,
                                "Aviso do Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw;

            }




        }
    }
}
