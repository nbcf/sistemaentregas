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
        public int encontrados;
        public int encontradosPesquisa;
        public string acaoCrudController;
        public string retornoPersistencia;


        public void Salvar(int idsaida,
            int idfornecedor, 
            int idtipogasto,
            string qtd,
            string tipound,
            string valorunitario,
            string valortotal, 
            string km,
            DateTime datagasto,
            string numeronota,
            string imgnota)
        {
            dao.Salvar(idsaida, idfornecedor, idtipogasto,  qtd, tipound,  valorunitario,  valortotal,  km, datagasto,  numeronota, imgnota);
            retornoRegistroSalvo();
        }

        //public DataTable Listar(string ordernaPor)
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        dt = dao.Listar("");
        //        return dt;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}



        public void Excluir(int idgastos)
        {
            dao.Excluir(idgastos);
        }

        public void Editar(int idsaida,
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
            dao.Editar(idsaida,idfornecedor,idtipogasto, qtd,tipound,valorunitario,valortotal,km,datagasto, numeronota,imgnota, idgasto);
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



        public DataTable ListarDataGrid(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                retornoQuantRegistro();
                DataTable dt = new DataTable();
                dt = dao.ListarDataGrid(parametro, indexar, offsett, limitt);
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
           //     dt = dao.PesquisarComeca(coluna, campo, pesquisar);
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
           //     dt = dao.PesquisarContem(coluna, campo, pesquisar);
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
            //    dt = dao.PesquisarTermina(coluna, campo, pesquisar);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
