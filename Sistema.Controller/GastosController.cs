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
            retornoRegistroSalvo();
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
            retornoRegistroSalvo();
        }


        public int retornoQuantRegistro() {
            return dao.ListarTodosRegistrosBD();
        }

        public int retornoQuantPesquisa(){
            return dao.ListarPesquisados();
        }

        public string retornoRegistroSalvo(){
            return dao.VerificarPersistencia();
        }


        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt){
                retornoQuantRegistro();
                return dao.ListarDataGrid(parametro, indexar, offsett, limitt);
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
