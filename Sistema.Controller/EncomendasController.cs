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
        

        public int retornoQuantRegistro(){
            return dao.ListarTodosRegistrosBD();
        }

        public int retornoQuantPesquisa(){
            return dao.ListarPesquisados();
        }


        public string retornoAcaoEncomendasDAO(){
            return dao.AcaoCrud();
        }

      
        public int ContarEncomendas(
            string stridsaida,
            int idveiculo,
            int identregador,
            string esentrega,
            DateTime datarota){
            return dao.ContarEncomendas(stridsaida, idveiculo, identregador, esentrega, datarota);
        }


        public DataTable ConfiListagemDataGrid(string idsaida, string estentrega,string parametro,string indexar, int offsett,int limitt){
                return dao.ConfiListagemDataGrid(idsaida, estentrega, parametro, indexar, offsett, limitt);
        }

        public DataTable ListarDetalheMestre(string idsaida, string estatusencomenda){
                retornoQuantRegistro();
                return dao.ListarDetalheMestre(idsaida, estatusencomenda);
        }

        public DataTable ListarDetalheMestreUnion(string idsaida, string estSaiuEntrega, string estEntregue) {
                retornoQuantRegistro();
                return dao.ListarDetalheMestreUnion(idsaida, estSaiuEntrega, estEntregue);
        }

        public DataTable ConfiListagemImportVS() {
                retornoQuantRegistro();
                return dao.ConfiListagemImportVS();
        }
        
        public int ListarTodosRegistrosBDEstatus(string estatusencomenda){
            return dao.ListarTodosRegistrosBDEstatus(estatusencomenda);
        }


        public DataTable ListarTodasEntregaSaida(string idsaida,string estencomendas,string parametro,string indexar,int offsett,int limitt){
                return dao.ListarTodasEntregaSaida(idsaida, estencomendas, parametro, indexar, offsett, limitt);
        }


        public DataTable ListarEntregaSaida(string estencomendas, string parametro,  string indexar, int offsett, int limitt){
                     return dao.ListarEntregaSaida(estencomendas, parametro, indexar, offsett, limitt);
        }


        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar, string estencomendas){
                retornoQuantPesquisa();
                return dao.PesquisarComeca(coluna, campo, pesquisar, estencomendas);
        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar, string estencomendas){
                retornoQuantPesquisa();
                return dao.PesquisarContem(coluna, campo, pesquisar, estencomendas);
        }

        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar, string estencomendas){
                retornoQuantPesquisa();
                return dao.PesquisarTermina(coluna, campo, pesquisar, estencomendas);
        }

        public DataTable PesquisarComecaImpES(string coluna, string campo, string pesquisar, string estencomendas){
                retornoQuantPesquisa();
                return dao.PesquisarComecaImpES(coluna, campo, pesquisar, estencomendas);
        }

        public DataTable PesquisarContemImpES(string coluna, string campo, string pesquisar, string estencomendas){
                retornoQuantPesquisa();
                return dao.PesquisarContemImpES(coluna, campo, pesquisar, estencomendas);
        }

        public DataTable PesquisarTerminaImpES(string coluna, string campo, string pesquisar, string estencomendas){
                retornoQuantPesquisa();
                return dao.PesquisarTerminaImpES(coluna, campo, pesquisar, estencomendas);
        }
    }
}

