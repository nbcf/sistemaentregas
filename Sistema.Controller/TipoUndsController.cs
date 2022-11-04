using Sistema.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Controller
{
  public  class TipoUndsController
    {
        TipoUndsDAO dao = new TipoUndsDAO();
      
   

        public void Salvar(string nomeund){
            dao.Salvar(nomeund);
            AcaoCrudTipoUndsController();
        }


        public DataTable ListComboBoxTipoUndController(){
                return dao.ListComboBoxTipoUndDAO();
            }

        public void Excluir(int idorigem){
            dao.Excluir(idorigem);
            AcaoCrudTipoUndsController();
        }

        public void Editar(int idtipound, string nomeund){
            dao.Editar(idtipound, nomeund);
            AcaoCrudTipoUndsController();
        }

        public int retornoQuantRegistro(){
            return dao.ListarTodosRegistrosBD(); ;
        }

        public int retornoQuantPesquisa(){
            return dao.ListarPesquisados();
        }

        public string AcaoCrudTipoUndsController(){
            return dao.AcaoCrudTipoUndsDAO();
        }

        public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt){
                retornoQuantRegistro();
                return dao.ConfiListagemDataGrid(parametro, indexar, offsett, limitt);
        }

        public DataTable ConfiListagemImpOE(){
            retornoQuantRegistro();
            return dao.ConfiListagemImportOE();
        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
            retornoQuantPesquisa();
            return dao.PesquisarComeca(coluna, campo, pesquisar);
        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar){
            retornoQuantPesquisa();
            return dao.PesquisarContem(coluna, campo, pesquisar);
        }

        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
            retornoQuantPesquisa();
            return dao.PesquisarTermina(coluna, campo, pesquisar);
        }
    }
}

