using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAO;
using Sistema.Model;

namespace Sistema.Controller
{
    public class EncomendasController
    {

        EncomendasDAO dao = new EncomendasDAO();
        EncomendasModel modelEncomendas = new EncomendasModel();
        public int encontrados;
        public int encontradosPesquisa;
      
        public int verificaEstatusParaRetorno;
        public int listarTodosRegistrosBDEstatus;
        public PapeisModel pmc = new PapeisModel();
        public PessoasModel pec = new PessoasModel();
        public void Salvar(int idorigem,
                           int idveiculo,
                           int identregador,
                           string nomeveiculo,
                           string placa,
                           string entregador,
                           string peso,
                           string numpacote,
                           string estentrega,
                           string cpf,
                           string destinatario,
                           string logradouro,
                           string complemento,
                           string bairro,
                           string cidade,
                           string uf,
                           string cep,
                           DateTime dataentrega,
                           DateTime datarota,
                           DateTime dataentrada,
                           string idsaida) {
            modelEncomendas.Idorigem        =       idorigem;
            modelEncomendas.Idveiculo       =       idveiculo;
            modelEncomendas.Identregador    =       identregador;
            modelEncomendas.Nomeveiculo     =       nomeveiculo;
            modelEncomendas.Placa           =       placa;
            modelEncomendas.Entregador      =       entregador;
            modelEncomendas.Peso            =       peso;
            modelEncomendas.Numpacote       =       numpacote;
            modelEncomendas.Estentrega      =       estentrega;
            modelEncomendas.Cpf             =       cpf;
            modelEncomendas.Destinatario    =       destinatario;
            modelEncomendas.Logradouro      =       logradouro;
            modelEncomendas.Complemento     =       complemento;
            modelEncomendas.Bairro          =       bairro;
            modelEncomendas.Cidade          =       cidade;
            modelEncomendas.Uf              =       uf;
            modelEncomendas.Cep             =       cep;
            modelEncomendas.Dataentrega     =       dataentrega;
            modelEncomendas.Datarota        =       datarota;
            modelEncomendas.Dataentrada     =       dataentrada;
            modelEncomendas.Idsaida         =       idsaida;
            dao.Salvar(modelEncomendas);
            
        }



        public DataTable Listar(string ordernaPor)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Listar("");
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Excluir(int idencomenda)
        {
            dao.Excluir(idencomenda);
        }

       
        
        
        
        public void Editar(int idorigem,
                           int idveiculo,
                           int identregador,
                           string nomeveiculo,
                           string placa,
                           string entregador,
                           string peso,
                           string numpacote,
                           string estentrega,
                           string cpf,
                           string destinatario,
                           string logradouro,
                           string complemento,
                           string bairro,
                           string cidade,
                           string uf,
                           string cep,
                           DateTime dataentrega,
                           DateTime datarota,
                           DateTime dataentrada,
                            string idsaida,
                           int idencomenda) {
            modelEncomendas.Idorigem        =   idorigem;
            modelEncomendas.Idveiculo       =   idveiculo;
            modelEncomendas.Identregador    =   identregador;
            modelEncomendas.Nomeveiculo     =   nomeveiculo;
            modelEncomendas.Placa           =   placa;
            modelEncomendas.Entregador      =   entregador;
            modelEncomendas.Peso            =   peso;
            modelEncomendas.Numpacote       =   numpacote;
            modelEncomendas.Estentrega      =   estentrega;
            modelEncomendas.Cpf = cpf;
            modelEncomendas.Destinatario    =   destinatario;
            modelEncomendas.Logradouro      =   logradouro;
            modelEncomendas.Complemento     =   complemento;
            modelEncomendas.Bairro          =   bairro;
            modelEncomendas.Cidade          =   cidade;
            modelEncomendas.Uf              =   uf;
            modelEncomendas.Cep             =   cep;
            modelEncomendas.Dataentrega     =   dataentrega;
            modelEncomendas.Datarota        =   datarota;
            modelEncomendas.Dataentrada     =   dataentrada;
            modelEncomendas.Idsaida = idsaida;
            modelEncomendas.Idencomenda     =   idencomenda;
            dao.Editar(modelEncomendas);
       
        }
        public void EditarSaidaEncomendaRota(int idorigem,
                      int idveiculo,
                      int identregador,
                      string idsaida,
                      DateTime datarota,
                      int idencomenda) {
            modelEncomendas.Idorigem = idorigem;
            modelEncomendas.Idveiculo = idveiculo;
            modelEncomendas.Identregador = identregador;
            modelEncomendas.Idsaida = idsaida;
            modelEncomendas.Datarota = datarota;
            modelEncomendas.Idencomenda = idencomenda;
            dao.Editar(modelEncomendas);
            

        }

        public void EditarSaidaEncomendaRotaDel(
            int idorigem,
                           int idveiculo,
                           int identregador,
                           string nomeveiculo,
                           string placa,
                           string entregador,
                           string estentrega,
                           string idsaida,
                           int idencomenda)
        {
            modelEncomendas.Idorigem        =   idorigem;
            modelEncomendas.Idveiculo       =   idveiculo;
            modelEncomendas.Identregador    =   identregador;
            modelEncomendas.Nomeveiculo     =   nomeveiculo;
            modelEncomendas.Placa           =   placa;
            modelEncomendas.Entregador      =   entregador;
            modelEncomendas.Estentrega      =   estentrega;
            modelEncomendas.Idsaida         =   idsaida;
            modelEncomendas.Idencomenda     =   idencomenda;
            dao.Editar(modelEncomendas);
           
    
        }

        public void EditarSaidaEncomendaEntrega(int idorigem,
                           int idveiculo,
                           int identregador,
                           string nomeveiculo,
                           string placa,
                           string entregador,
                           string peso,
                           string numpacote,
                           string estentrega,
                           string idsaida,
                           string destinatario,
                           string logradouro,
                           string complemento,
                           string bairro,
                           string cidade,
                           string uf,
                           string cep,
                           DateTime dataentrega,
                           string cpf,
                           int idencomenda){
            modelEncomendas.Idorigem = idorigem;
            modelEncomendas.Idveiculo = idveiculo;
            modelEncomendas.Identregador = identregador;
            modelEncomendas.Nomeveiculo = nomeveiculo;
            modelEncomendas.Placa = placa;
            modelEncomendas.Entregador = entregador;
            modelEncomendas.Peso = peso;
            modelEncomendas.Numpacote = numpacote;
            modelEncomendas.Estentrega = estentrega;
            modelEncomendas.Idsaida = idsaida;
            modelEncomendas.Destinatario = destinatario;
            modelEncomendas.Logradouro = logradouro;
            modelEncomendas.Complemento = complemento;
            modelEncomendas.Bairro = bairro;
            modelEncomendas.Cidade = cidade;
            modelEncomendas.Uf = uf;
            modelEncomendas.Cep = cep;
            modelEncomendas.Dataentrega = dataentrega;
            modelEncomendas.Cpf = cpf;
            modelEncomendas.Idencomenda = idencomenda;
            dao.Editar(modelEncomendas);
           
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


        public string retornoAcaoEncomendasDAO()
        {
            return dao.AcaoCrud();
        }

      
        public int ContarEncomendas(string stridsaida,int idveiculo,int identregador,DateTime datarota,string esentrega) {
            return dao.ContarEncomendas( stridsaida, idveiculo, identregador, datarota, esentrega);
        }


        public DataTable ConfiListagemDataGrid(string idsaida, string estentrega, string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                retornoQuantRegistro();
                DataTable dt = new DataTable();
                dt = dao.ConfiListagemDataGrid(idsaida, estentrega, parametro, indexar, offsett, limitt);
                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public DataTable ListarDetalheMestre(string idsaida, string estatusencomenda)
        {
            try
            {
                retornoQuantRegistro();
                DataTable dt = new DataTable();
                dt = dao.ListarDetalheMestre(idsaida, estatusencomenda);
                return dt;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public DataTable ListarDetalheMestreUnion(string idsaida, string estSaiuEntrega, string estEntregue)
        {
            try
            {
                retornoQuantRegistro();
                DataTable dt = new DataTable();
                dt = dao.ListarDetalheMestreUnion( idsaida, estSaiuEntrega, estEntregue);
                return dt;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public DataTable ConfiListagemImportVS()
        {
            try
            {
                retornoQuantRegistro();
                DataTable dt = new DataTable();
                dt = dao.ConfiListagemImportVS(); 
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public int ListarTodosRegistrosBDEstatus(string estatusencomenda){
            listarTodosRegistrosBDEstatus = dao.ListarTodosRegistrosBDEstatus( estatusencomenda);
            return listarTodosRegistrosBDEstatus;
        }


        public DataTable ListarTodasEntregaSaida(string idsaida,string estencomendas,string parametro,string indexar,int offsett,int limitt){
            try {
                DataTable dt = new DataTable();
                dt = dao.ListarTodasEntregaSaida(idsaida, estencomendas, parametro, indexar, offsett, limitt);
                return dt;
            }
            catch (Exception e){
                throw e;
            }
        }


        public DataTable ListarEntregaSaida(string estencomendas, string parametro,  string indexar, int offsett, int limitt){
            try{
             
                DataTable dt = new DataTable();
                dt = dao.ListarEntregaSaida(estencomendas, parametro, indexar, offsett, limitt);
                return dt;

            }catch (Exception e){
                throw e;
            }
        }


        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar, string estencomendas){
            try{
                retornoQuantPesquisa();
                DataTable dt = new DataTable();
                dt = dao.PesquisarComeca(coluna, campo, pesquisar, estencomendas);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar, string estencomendas){
            try{
                retornoQuantPesquisa();
                DataTable dt = new DataTable();
                dt = dao.PesquisarContem(coluna, campo, pesquisar, estencomendas);
                return dt;

            }catch (Exception e){
                throw;
            }

        }
        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar, string estencomendas){
            try
            {
                retornoQuantPesquisa();
                DataTable dt = new DataTable();
                dt = dao.PesquisarTermina(coluna, campo, pesquisar, estencomendas);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable PesquisarComecaImpES(string coluna, string campo, string pesquisar, string estencomendas)
        {
            try
            {
                retornoQuantPesquisa();
                DataTable dt = new DataTable();
                dt = dao.PesquisarComecaImpES(coluna, campo, pesquisar, estencomendas);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public DataTable PesquisarContemImpES(string coluna, string campo, string pesquisar, string estencomendas)
        {
            try
            {
                retornoQuantPesquisa();
                DataTable dt = new DataTable();
                dt = dao.PesquisarContemImpES(coluna, campo, pesquisar, estencomendas);
                return dt;
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public DataTable PesquisarTerminaImpES(string coluna, string campo, string pesquisar, string estencomendas)
        {
            try
            {
                retornoQuantPesquisa();
                DataTable dt = new DataTable();
                dt = dao.PesquisarTerminaImpES(coluna, campo, pesquisar, estencomendas);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}

