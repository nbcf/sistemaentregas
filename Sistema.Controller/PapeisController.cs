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


        public void Salvar(string papel, bool cadastrar, bool pesquisar, bool editar, bool excluir, bool menuope, bool menuadmin, bool menugen)
        {
            modelPapeis.Nomepapel = papel;
            modelPapeis.Criar = cadastrar;
            modelPapeis.Recuperar = pesquisar;
            modelPapeis.Atualizar = editar;
            modelPapeis.Excluir = excluir;
            modelPapeis.Menuope = menuope;
            modelPapeis.Menuadmin = menuadmin;
            modelPapeis.Menugen = menugen;
            dao.Salvar(modelPapeis);
            retornoRegistroSalvo();
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
            modelPapeis.Idpapel = idpapeis;
            modelPapeis.Nomepapel = nomepapel;
            dao.Excluir(modelPapeis);
            retornoRegistroSalvo();
        }

        public void Editar(int idpapel, string papel, bool cadastrar, bool pesquisar, bool editar, bool excluir, bool menuope, bool menuadm, bool menugen)
        {
            modelPapeis.Idpapel = idpapel;
            modelPapeis.Nomepapel = papel;
            modelPapeis.Criar = cadastrar;
            modelPapeis.Recuperar = pesquisar;
            modelPapeis.Atualizar = editar;
            modelPapeis.Excluir = excluir;
            modelPapeis.Menuope = menuope;
            modelPapeis.Menuadmin = menuadm;
            modelPapeis.Menugen = menugen;
            dao.Editar(modelPapeis);
            retornoRegistroSalvo();
        }


        public int retornoQuantRegistro()
        {
            encontrados = dao.ListarTodosRegistrosBD();
            return encontrados;
        }

        public int retornoQuantPesquisa()
        {
            encontradosPesquisa = dao.ListarPesquisados();
            return encontradosPesquisa;
        }

        public string retornoRegistroSalvo()
        {
            retornoPersistencia = dao.VerificarPersistencia();
            return retornoPersistencia;

        }


        public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                retornoQuantRegistro();
                DataTable dt = new DataTable();
                dt = dao.ConfiListagemDataGrid(parametro, indexar, offsett, limitt);
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
                retornoQuantRegistro();
                DataTable dt = new DataTable();
                dt = dao.ConfiListagemImportPU();
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
                //     retornoQuantPesquisa();
                DataTable dt = new DataTable();
                dt = dao.PesquisarComeca(coluna, campo, pesquisar);
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
                // retornoQuantPesquisa();
                DataTable dt = new DataTable();
                dt = dao.PesquisarContem(coluna, campo, pesquisar);
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
                //         retornoQuantPesquisa();
                DataTable dt = new DataTable();
                dt = dao.PesquisarTermina(coluna, campo, pesquisar);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

