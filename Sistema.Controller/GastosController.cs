using Sistema.DAO;
using Sistema.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Controller
{
  public  class GastosController
    {
        GastosDAO dao = new GastosDAO();
        GastosModel modelGastos = new GastosModel();
        //public int encontrados;
        //public int encontradosPesquisa;
        //public string acaoCrudController;
        //public string retornoPersistencia;


        public void Salvar(
                            int idsaida,
                            int idfornecedor, 
                            int idtipogasto,
                            string qtd,
                            string tipound,
                            string valorunitario,
                            string valortotal, 
                            string km,
                            DateTime datagasto,
                            string numeronota,
                            string imgnota){
             dao.Salvar(idsaida,
                        idfornecedor,
                        idtipogasto, 
                        qtd,
                        tipound,
                        valorunitario,
                        valortotal,
                        km,
                        datagasto,
                        numeronota,
                        imgnota);
            ListarGridBDGastosController();
        }

      

        public void Excluir(int idgastos){
            dao.Excluir(idgastos);
        }

        public void Editar(
                            int idsaida,
                            int idfornecedor,
                            int idtipogasto,
                            string qtd,
                            string tipound,
                            string valorunitario,
                            string valortotal,
                            string km,
                            DateTime datagasto,
                            string numeronota,
                            string imgnota,
                            int idgasto){
            dao.Editar(
                idsaida,
                idfornecedor,
                idtipogasto,
                qtd,
                tipound,
                valorunitario,
                valortotal,
                km,
                datagasto,
                numeronota,
                imgnota,
                idgasto);
            AcaoCrudGastosController();
        }


        public int ListarGridBDGastosController() {
            return dao.ListarGridBDGastosDAO();
        }

        public int ListarPesquisadosGastosController(){
            return dao.ListarPesquisadosGastosDAO();
        }

        public string AcaoCrudGastosController(){
            return dao.AcaoCrudGastosDAO();
        }


        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt){
            AcaoCrudGastosController();
                return dao.ListarDataGridGastosDAO(parametro, indexar, offsett, limitt);
        }

        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
            ListarPesquisadosGastosController();
            return dao.PesquisarComeca(coluna, campo, pesquisar);
        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar){
            ListarPesquisadosGastosController();
            return dao.PesquisarContem(coluna, campo, pesquisar);
        }

        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
            ListarPesquisadosGastosController();
            return dao.PesquisarTermina(coluna, campo, pesquisar);
        }
    }
}
