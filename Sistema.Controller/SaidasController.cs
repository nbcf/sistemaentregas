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
                        modelSaida.Idveiculo        = idveiculo;
                        modelSaida.Idusuario        = idusuario;
                        modelSaida.Idpapel          = idpapel;
                        modelSaida.Idpessoa         = idpessoa;
                        modelSaida.Nomeveiculo      = nomeveiculo;
                        modelSaida.Placa            = placa;
                        modelSaida.Entregador       = entregador;
                        modelSaida.Datasaida        = datasaida;
                        modelSaida.Dataretorno      = dataretorno;
                        modelSaida.Horasaida        = horasaida;
                        modelSaida.Horaretorno      = horaretorno;
                        modelSaida.Estsaida         = estsaida;
                        modelSaida.Regiaoentrega    = regiaoentrega;
                        modelSaida.Kmsaida          = kmsaida;
                        modelSaida.Kmretorno        = kmretorno;
                        modelSaida.Kmtotal          = kmtotal;
                        dao.Salvar(modelSaida);
                        AcaoCrudSaidasController();
        }

        public DataTable ListarEstatusSaidaController(string estsaidas){
            return dao.ListarEstatusSaidaDAO(estsaidas);

        }

        public DataTable ListarSaidaGasto(){
            return  dao.ListarSaidaGasto();
        }


        public void Excluir(int idsaida){
            dao.Excluir( idsaida);
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
                        modelSaida.Idveiculo        =   idveiculo;
                        modelSaida.Idusuario        =   idusuario;
                        modelSaida.Idpapel          =   idpapel;
                        modelSaida.Idpessoa         =   idpessoa;
                        modelSaida.Nomeveiculo      =   nomeveiculo;
                        modelSaida.Placa            =   placa;
                        modelSaida.Entregador       =   entregador;
                        modelSaida.Datasaida        =   datasaida;
                        modelSaida.Dataretorno      =   dataretorno;
                        modelSaida.Horasaida        =   horasaida;
                        modelSaida.Horaretorno      =   horaretorno;
                        modelSaida.Estsaida         =   estsaida;
                        modelSaida.Regiaoentrega    =   regiaoentrega;
                        modelSaida.Kmsaida          =   kmsaida;
                        modelSaida.Kmretorno        =   kmretorno;
                        modelSaida.Kmtotal          =   kmtotal;
                        modelSaida.Idsaida          =   idsaida;
                        dao.Editar(modelSaida);
                        AcaoCrudSaidasController();
                        }

        public void EditarFimDeRota(int idveiculo, int idusuario,string estsaida, int idsaida){
            dao.EditarFimDeRota(idveiculo, idusuario,estsaida,idsaida);
            AcaoCrudSaidasController();
        }

        public int ListarBDSaidasController(){
            return  dao.ListarBDSaidasDAO();
        }

        public int ListarPesquisaController(){
            return dao.ListarPesquisaDAO();
        }

        public string AcaoCrudSaidasController(){
            return dao.AcaoCrudSaidasDAO();
        }

        public DataTable UltimoRegistro(){
            return dao.UltimoRegistro();

        }

        public DataTable ListarSaidasGridController(
            string parametro,
            string estatusSaida,
            string indexar,
            int offsett,
            int limitt){
                ListarBDSaidasController();
                return dao.ListarDataGridDAO(parametro, estatusSaida, indexar, offsett, limitt);
            
        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
              return dao.PesquisarComeca(coluna, campo, pesquisar);
        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar){
               return dao.PesquisarContem(coluna, campo, pesquisar);
        }

        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
            return dao.PesquisarTermina(coluna, campo, pesquisar);
            
        }
    }
}
