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
  public  class TipoDespesasController
    {
        TipoDespesasDAO dao = new TipoDespesasDAO();
        TipoDespesasModel modelTipoDespesas = new TipoDespesasModel();
        public int encontrados;
        public int encontradosPesquisa;
        public string retornoPersistencia;


        public void Salvar(string nomedespesa, string tipodespesa, string tpund)
        {
            modelTipoDespesas.Nomedespesa = nomedespesa;
            modelTipoDespesas.Tipodespesa = tipodespesa;
            modelTipoDespesas.Tpunid = tpund;
            dao.Salvar(modelTipoDespesas);
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



        public void Excluir(int idtipodespesa)
        {
            modelTipoDespesas.Idtipodespesa = idtipodespesa;

            dao.Excluir(modelTipoDespesas);
        }

        public void Editar(int idtipodespesa, string nomedespesa, string tipodespesa, string tpund)
        {

            modelTipoDespesas.Idtipodespesa = idtipodespesa;
            modelTipoDespesas.Nomedespesa = nomedespesa;
            modelTipoDespesas.Tipodespesa = tipodespesa;
            modelTipoDespesas.Tpunid = tpund;
          
            dao.Editar(modelTipoDespesas);
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


        //encontradosPesquisa

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
