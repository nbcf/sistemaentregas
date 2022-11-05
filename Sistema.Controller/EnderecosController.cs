using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Model;
using Sistema.DAO;
using System.Data;
using Sistema.DAO;
using Sistema.Model;

namespace Sistema.Controller{

  public  class EnderecosController{
        EnderecosDAO dao = new EnderecosDAO();

        public void Salvar(
            string logradouro,
            string bairro,
            string cidade,
            string uf,
            string cep ){

            dao.Salvar(
                logradouro,
                bairro,
                cidade,
                uf,
                cep);
            AcaoCrudEnderecosDAO();
        }

        public void Excluir(int idendereco){
            dao.Excluir(idendereco);
            AcaoCrudEnderecosDAO();
        }

        public void Editar(int idendereco,
            string logradouro,
            string bairro, 
            string cidade,
            string uf, 
            string cep) {
            dao.Editar(
                idendereco,
                logradouro,
                bairro,
                cidade, 
                uf,  
                cep);
            AcaoCrudEnderecosDAO();
        }


        public int ListarBDEnderecosController(){
            return dao.ListarBDEnderecosDAO();
        }

        public int PesquisaEnderecosController(){
            return dao.PesquisaEnderecosDAO();
        }

        public string AcaoCrudEnderecosDAO(){
            return dao.AcaoCrudEnderecosDAO();

        }

        public DataTable ListarDataGrid(
            string parametro,
            string indexar,
            int offsett,
            int limitt){
                ListarBDEnderecosController();
            return dao.ListarDataGrid(parametro, indexar, offsett, limitt);
        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar) {
                PesquisaEnderecosController();
                return dao.PesquisarComeca(coluna, campo, pesquisar);
        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar) {
                PesquisaEnderecosController();
                return dao.PesquisarContem(coluna, campo, pesquisar);
            }

        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
                PesquisaEnderecosController();
                return dao.PesquisarTermina(coluna, campo, pesquisar);
        }
    }
}

