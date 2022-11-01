using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAO;
using Sistema.Model;


namespace Sistema.Controller
{
   public class VeiculosController{
        VeiculosDAO dao = new VeiculosDAO();
  
        public void Salvar(string nomeveiculo, string placa, string estatusveiculo){
            dao.Salvar(nomeveiculo, placa,  estatusveiculo);
            RetornoQuantVeiclosEncontrados();
        }

     

        public void Excluir(int idveiculo){
            dao.Excluir(idveiculo);
            AcaoCrudVeiculosController();
        }

        public void Editar(int idveiculo, string nomeveiculo, string placa, string estatusveiculo){
            dao.Editar( nomeveiculo,  placa,  estatusveiculo, idveiculo);
            AcaoCrudVeiculosController();
        }

        public void EditarEstatusVeiculo(string nomeveiculo, string placa, string estatusveiculo, int idveiculo) {
            dao.EditarEstatusVeiculo(nomeveiculo,  placa,  estatusveiculo, idveiculo);
            AcaoCrudVeiculosController();


        }
        public int RetornoTodosRegistroBD(){
            return dao.ListarTodosRegistrosBD();
        }

        public int RetornoQuantVeiclosEncontrados(){
            return dao.ListarVeiculosEncontradosDAO();
        }

        public string AcaoCrudVeiculosController(){
            return dao.AcaoCrudVeiculosDAO();

        }


        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt){
            try {
                DataTable dt = new DataTable();
                dt = dao.ListarDataGrid(parametro, indexar, offsett, limitt);
                RetornoQuantVeiclosEncontrados();
                return dt;

            }catch (Exception e) {
                throw e;
            }
        }

        public DataTable ConfiListagemImportVS() {
            try{
              
                DataTable dt = new DataTable();
                dt = dao.ConfiListagemImportVS();
                RetornoQuantVeiclosEncontrados();
                return dt;

            }catch (Exception e){
                throw e;
            }
        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
            try{
                DataTable dt = new DataTable();
                dt = dao.PesquisarComeca(coluna, campo, pesquisar);
                RetornoQuantVeiclosEncontrados();
                return dt;

            }catch (Exception){
                throw;
            }

        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar){
            try{
                DataTable dt = new DataTable();
                dt = dao.PesquisarContem(coluna, campo, pesquisar);
                RetornoQuantVeiclosEncontrados();
                return dt;

            }catch (Exception e){
                throw;
            }

        }
        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
            try{
                DataTable dt = new DataTable();
                dt = dao.PesquisarTermina(coluna, campo, pesquisar);
                RetornoQuantVeiclosEncontrados();
                return dt;

            }catch (Exception) {

                throw;
            }

        }
    }
}
