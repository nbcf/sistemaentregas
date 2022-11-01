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
 public   class UsuariosController
    {
        UsuariosDAO dao = new UsuariosDAO();
        UsuariosModel modelUsuarios = new UsuariosModel();
        public int encontrados;
        public int encontradosPesquisa;
        public string retornoPersistencia;
        public PapeisModel pmc = new PapeisModel();
        public PessoasModel pec = new PessoasModel();

        public void Salvar(string usuario, string senha, string idpessoa, string idpapel){
            dao.Salvar(Convert.ToInt32(idpessoa), Convert.ToInt32(idpapel), usuario,    senha);
            retornoRegistroSalvo();
        }


        public void Excluir(int idpessoa){
            dao.Excluir(idpessoa);
        }

        public void Editar(int idusuario, string usuario, string senha, string idpessoa, string idpapel) {
            dao.Editar(Convert.ToInt32(idpessoa), Convert.ToInt32(idpapel),  usuario,  senha, idusuario);
            retornoRegistroSalvo();
        }


        public int retornoQuantRegistro(){
            return dao.ListarTodosVeiculoBD();
        }

        public int retornoQuantPesquisa(){
            return dao.ListarPesquisados();
        }

        public string retornoRegistroSalvo(){
            return dao.VerificarPersistencia();
        }

        public object retornoDadosPapeis(string idpapel)
        {
           dao.ExibirDadosPapeis(idpapel);
            pmc.Nomepapel = dao.pmodelDAO.Nomepapel;
            pmc.Criar = dao.pmodelDAO.Criar;
            pmc.Recuperar = dao.pmodelDAO.Recuperar;
            pmc.Atualizar = dao.pmodelDAO.Atualizar;
            pmc.Recuperar = dao.pmodelDAO.Recuperar;
            pmc.Excluir = dao.pmodelDAO.Excluir;
            pmc.Menuope = dao.pmodelDAO.Menuope;
            pmc.Menuadmin = dao.pmodelDAO.Menuadmin;
            pmc.Menugen = dao.pmodelDAO.Menugen;

            return pmc;
        }

        public object retornoDadoPessoas(string idpessoa){

            dao.ExibirDadosPessoa(idpessoa);
            pec.Nomepessoa = dao.pessmodelDAO.Nomepessoa;
            return pec;
        }


        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                
                DataTable dt = new DataTable();
                dt = dao.ListarDataGrid(parametro, indexar, offsett, limitt);
                retornoQuantRegistro();
                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }


        }
       
        public DataTable ListarEntregador(string funcao)
        {
            try
            {
                
                DataTable dt = new DataTable();
                dt = dao.ListarImportEntregador(funcao);
                retornoQuantRegistro();
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
                retornoQuantPesquisa();
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
                retornoQuantPesquisa();
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
                retornoQuantPesquisa();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

