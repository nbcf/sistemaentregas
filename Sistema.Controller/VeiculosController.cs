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

        public DataTable ListarVeiculosEmComboBoxController(){
            return dao.ListarVeiculosEmComboBoxDAO();
        }

        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt){
                RetornoQuantVeiclosEncontrados();
                return dao.ListarDataGrid(parametro, indexar, offsett, limitt);
        }

        public DataTable ConfiListagemImportVS(){
                RetornoQuantVeiclosEncontrados();
                return dao.ConfiListagemImportVS();
        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
                return dao.PesquisarComeca(coluna, campo, pesquisar);
        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar){
                RetornoQuantVeiclosEncontrados();
                return dao.PesquisarContem(coluna, campo, pesquisar);
        }

        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
                RetornoQuantVeiclosEncontrados();
                return dao.PesquisarTermina(coluna, campo, pesquisar);

        }
    }
}
