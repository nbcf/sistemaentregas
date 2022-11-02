using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Model;
using Sistema.DAO;
using System.Data;

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
            bool menugen)
        {
            
            dao.Salvar( papel,
                cadastrar,
                pesquisar, 
                editar,
                excluir,
                menuope, 
                menuadmin, 
                menugen);
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

        public void Excluir(int idpapeis, string nomepapel)
        {
          
            dao.Excluir( idpapeis,  nomepapel);
      
        }

        public void Editar(string papel,
            bool cadastrar, 
            bool pesquisar,
            bool editar, 
            bool excluir, 
            bool menuope, 
            bool menuadm, 
            bool menugen, 
            int idpapel)
        {
            dao.Editar(papel,
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


        public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ConfiListagemDataGrid(parametro, indexar, offsett, limitt);
                ListarBDPapeisControlller();
                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public DataTable ConfiListagemImportPU()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ConfiListagemImportPU();
                ListarBDPapeisControlller();
                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarComeca(coluna, campo, pesquisar);
                ListarPesquisaPapeisController();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarContem(coluna, campo, pesquisar);
                ListarPesquisaPapeisController();
                return dt;
            }
            catch (Exception e)
            {

                throw;
            }

        }
        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarTermina(coluna, campo, pesquisar);
                ListarPesquisaPapeisController();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

