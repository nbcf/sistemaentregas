using Sistema.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Controller
{
  public class TipoGastosController
    {
        TipoGastosDAO dao = new TipoGastosDAO();
     
        public void Salvar(int idtipound, string nomegasto){
            dao.Salvar(idtipound, nomegasto);
       //     AcaoCrudTipoGastosDAO();
        }

        //public DataTable ListarGrid(string nomegasto){
        //        return dao.Listar(nomegasto);
        //}

        public DataTable ListarEmComboBox(){
                return dao.ListarEmComboBox();
        }

        public DataTable ComplementoComboBoxTipoUnds(int idtipogasto){
            return dao.ComplementoComboBoxTipoUnds(idtipogasto);
        }

        public void Excluir(int idtipogasto){
            dao.Excluir(idtipogasto);
           // AcaoCrudTipoGastosDAO();
        }

        public void Editar(int idtipound, string nomegasto, int idtipogasto) {
            dao.Editar(idtipound,  nomegasto, idtipogasto);
         //   AcaoCrudTipoGastosDAO();
        }

        public int ListarBDTipoGastosController(){
            return dao.ListarBDTipoGastosDAO();
        }

        public int ListarPesquisaTipoGastosController() {
            return dao.ListarPesquisaTipoGastosDAO();
        }

        public string AcaoCrudTipoGastosDAO() {
            return dao.AcaoCrudTipoGastosDAO();

        }

        public DataTable ListaDataGrid(string parametro, string indexar, int offsett, int limitt){
            return dao.ListarDataGrid(parametro, indexar, offsett, limitt);
        }
    
        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
             return dao.PesquisarComeca(coluna, campo, pesquisar);
        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar){
             return dao.PesquisarContem(coluna, campo, pesquisar);
        }

        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
            return dao.PesquisarTermina(coluna, campo, pesquisar);
        }
    }
}

