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
   public class PapeisController
    {
        PapeisDAO dao = new PapeisDAO();
        PapeisModel modelPapeis = new PapeisModel();
        public int encontrados;
        public int encontradosPesquisa;
        public string retornoPersistencia;


        public void Salvar(string papel,
            bool cadastrar,
            bool pesquisar,
            bool editar, 
            bool excluir,
            bool menuope,
            bool menuadmin,
            bool menugen){
            dao.Salvar( papel,
                cadastrar,
                pesquisar, 
                editar,
                excluir,
                menuope, 
                menuadmin, 
                menugen);
        }

        public void Excluir(int idpapeis, string nomepapel)
        {
          
            dao.Excluir( idpapeis,  nomepapel);
      
        }

        public void Editar(
            string papel,
            bool cadastrar, 
            bool pesquisar,
            bool editar, 
            bool excluir, 
            bool menuope, 
            bool menuadm, 
            bool menugen, 
            int idpapel)
        {
            dao.Editar(
                papel,
                cadastrar,
                pesquisar, 
                editar, 
                excluir,  
                menuope, 
                menuadm, 
                menugen, 
                idpapel);
      
        }


       
        public int ListarBDPapeisControlller(){
            return dao.ListarBDPapeisDAO();
        }

        public int ListarPesquisaPapeisController(){
            return dao.ListarPesquisaPapeisDAO();
        }

        public string AcaoCrudPapeisDAO(){
            return dao.AcaoCrudPapeisDAO();
        }


        public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt) {
                return dao.ConfiListagemDataGrid(parametro, indexar, offsett, limitt);
        }

        public DataTable ConfiListagemImportPU(){ 
             //   ListarBDPapeisControlller();
                return dao.ConfiListagemImportPU();

        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
           //     ListarPesquisaPapeisController();
                return dao.PesquisarComeca(coluna, campo, pesquisar);
            }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar) {
             //   ListarPesquisaPapeisController();
                return dao.PesquisarContem(coluna, campo, pesquisar);
            }

        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
             //   ListarPesquisaPapeisController();
                return dao.PesquisarTermina(coluna, campo, pesquisar);
        }
    }
}

