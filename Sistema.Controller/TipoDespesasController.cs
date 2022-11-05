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

   
        public void Excluir(int idtipodespesa){
            modelTipoDespesas.Idtipodespesa = idtipodespesa;

            dao.Excluir(modelTipoDespesas);
        }

        public void Editar(int idtipodespesa, string nomedespesa, string tipodespesa, string tpund){
            modelTipoDespesas.Idtipodespesa = idtipodespesa;
            modelTipoDespesas.Nomedespesa = nomedespesa;
            modelTipoDespesas.Tipodespesa = tipodespesa;
            modelTipoDespesas.Tpunid = tpund;
          
            dao.Editar(modelTipoDespesas);
            retornoRegistroSalvo();
        }


        public int ListarTodosRegistrosBD(){
            return dao.ListarTodosRegistrosBD();
        }

        public int ListarPesquisados(){
            return dao.ListarPesquisados();
        }

        public string retornoRegistroSalvo(){
            return dao.VerificarPersistencia();
        }


        public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt){
                return dao.ConfiListagemDataGrid(parametro, indexar, offsett, limitt);
        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
                //     retornoQuantPesquisa();
                return dao.PesquisarComeca(coluna, campo, pesquisar);
        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar) {

                return dao.PesquisarContem(coluna, campo, pesquisar);
        }

        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
                // retornoQuantPesquisa();
                return dao.PesquisarTermina(coluna, campo, pesquisar);
        }
    }
}
