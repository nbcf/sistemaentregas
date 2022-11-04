using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Model;
using Sistema.DAO;
using System.Data;
using System.Windows.Forms;

namespace Sistema.Controller
{
   public class OrigemController
    {
        OrigemDAO dao = new OrigemDAO();

        public void Salvar(string nomeorigem, string codorigem){
            dao.Salvar( nomeorigem,  codorigem);
            AcaoCrudController();
        }

     
        public void Excluir(int idorigem){
            dao.Excluir(idorigem);
        }

        public void Editar( string nomeorigem, string codorigem, int idorigem){
            dao.Editar( nomeorigem,  codorigem, idorigem);
            AcaoCrudController();
        }

        public int ListarTodosVeiculosBD(){
            return  dao.ListarTodosVeiculosBD();
        }

        public int RetornoQuantPesquisa(){
            return  dao.ListarVeiculosPesquisados();
        }

        public string AcaoCrudController(){
            return  dao.AcaoCrudDAO();
        }

        public DataTable ListaDataGrid(string parametro, string indexar, int offsett, int limitt) {
            RetornoQuantPesquisa();
            return dao.ListaDataGrid(parametro, indexar, offsett, limitt);
        }

        public DataTable ConfiListagemImpOE(){
                RetornoQuantPesquisa();
                return dao.ConfiListagemImportOE();
        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
            RetornoQuantPesquisa();
            return dao.PesquisarComeca(coluna, campo, pesquisar);
        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar){
                RetornoQuantPesquisa();
                return dao.PesquisarContem(coluna, campo, pesquisar);
        }

        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
                RetornoQuantPesquisa();
                return dao.PesquisarTermina(coluna, campo, pesquisar);
        }
    }
}


