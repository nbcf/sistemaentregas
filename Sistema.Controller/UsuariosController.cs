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

        public PapeisModel pmc = new PapeisModel();
        public PessoasModel pec = new PessoasModel();

        public void Salvar(
            string usuario,
            string senha,
            string idpessoa,
            string idpapel){
            dao.Salvar(
                Convert.ToInt32(idpessoa),
                Convert.ToInt32(idpapel),
                usuario, 
                senha);
            AcaoCrudUsuariosController();
        }


        public void Excluir(int idpessoa){
            dao.Excluir(idpessoa);
        }
        public void Editar(
            string idpessoa,
            string idpapel,
            string usuario,
            string senha,
            int idusuario){

            dao.Editar(
                Convert.ToInt32(idpessoa),
                Convert.ToInt32(idpapel),
                usuario,
                senha,
                idusuario);
            AcaoCrudUsuariosController();
        }


        public int retornoQuantRegistro(){
            return dao.ListarTodosVeiculoBD();
        }

        public int retornoQuantPesquisa(){
            return dao.ListarPesquisados();
        }

        public string AcaoCrudUsuariosController(){
            return dao.AcaoCrudUsuariosDAO();
        }

        public object retornoDadosPapeis(string idpapel){
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
            pec.Nomepessoa = dao.ExibirDadosPessoa(idpessoa);
            return pec;
        }


        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt){
                retornoQuantRegistro();
                return dao.ListarDataGrid(parametro, indexar, offsett, limitt);
        }
       
        public DataTable ListarEntregador(string funcao){
                retornoQuantRegistro();
                return dao.ListarImportEntregador(funcao); 
        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
                retornoQuantPesquisa();
                return dao.PesquisarComeca(coluna, campo, pesquisar);
            }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar){
                retornoQuantPesquisa();
                return dao.PesquisarContem(coluna, campo, pesquisar);
            }

        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar) {
                retornoQuantPesquisa();
                return dao.PesquisarTermina(coluna, campo, pesquisar);
        }
    }
}

