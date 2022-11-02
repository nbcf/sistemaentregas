using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Model;
using Sistema.DAO;
using System.Data;
using System.Windows.Forms;

namespace Sistema.Controller{
   public class FornecedoresController{

        FornecedoresDAO dao = new FornecedoresDAO();

        public void Salvar(string fornecedor){
            dao.Salvar(fornecedor);
            AcaoCrudFornecedoresController();
        }

        public void Excluir(int idorigem){
            dao.Excluir(idorigem);
            AcaoCrudFornecedoresController();
        }

        public void Editar(string fornecedor, int idfornecedor){
            dao.Editar( fornecedor, idfornecedor);
            AcaoCrudFornecedoresController();
        }

        public int ListarTodosVeiculosBD(){
            return dao.ListarTodosVeiculosBD();
        }

        public int RetornoQuantPesquisa(){
            return dao.ListarVeiculosPesquisados();
        }

        public string AcaoCrudFornecedoresController(){
            return dao.AcaoCrudFornecedoresDAO();
        }

        public DataTable ListaDataGrid(string parametro, string indexar, int offsett, int limitt){
            
            try{
                DataTable dt = new DataTable();
                dt = dao.ListaDataGrid(parametro, indexar, offsett, limitt);
                RetornoQuantPesquisa();
                return dt;

            }catch (Exception e) {

                throw;
            }
        }
        public DataTable ListarEmComboBox(){

            try{
                DataTable dt = new DataTable();
                dt = dao.ListarEmComboBox();
                return dt;
            }catch (Exception e){
               
                throw;
            }
        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
            
            try{
                DataTable dt = new DataTable();
                dt = dao.PesquisarComeca(coluna, campo, pesquisar);
                RetornoQuantPesquisa();
                return dt;

            }catch (Exception e){
                throw;
            }

        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar){
           
            try{

                DataTable dt = new DataTable();
                dt = dao.PesquisarContem(coluna, campo, pesquisar);
                RetornoQuantPesquisa();
                return dt;

            }catch (Exception e){
                throw;
            }

        }
        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
            
            try{

                DataTable dt = new DataTable();
                dt = dao.PesquisarTermina(coluna, campo, pesquisar);
                RetornoQuantPesquisa();
                return dt;

            }catch (Exception e){
                throw;
            }
        }
    }
}
