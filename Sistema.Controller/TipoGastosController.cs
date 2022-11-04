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
            retornoRegistroSalvo();
        }

        public DataTable Listar(string nomegasto){
                return dao.Listar(nomegasto);
        }

        public DataTable ListarEmComboBox(){
                return dao.ListarEmComboBox();
        }

        public DataTable ComplementoComboBoxTipoUnds(int idtipogasto){
            return dao.ComplementoComboBoxTipoUnds(idtipogasto);
        }

        public void Excluir(int idtipogasto){
            dao.Excluir(idtipogasto);
        }

        public void Editar(int idtipound, string nomegasto, int idtipogasto) {
            dao.Editar(idtipound,  nomegasto, idtipogasto);
            retornoRegistroSalvo();
        }

        public int retornoQuantRegistro(){
            return dao.ListarTodosRegistrosBD();
        }

        public int retornoQuantPesquisa() {
            return dao.ListarPesquisados();
        }

        public string retornoRegistroSalvo() {
            return dao.VerificarPersistencia();

        }

        public DataTable ListaDataGrid(string parametro, string indexar, int offsett, int limitt){
            return dao.ListarEmDataGrid(parametro, indexar, offsett, limitt);
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

