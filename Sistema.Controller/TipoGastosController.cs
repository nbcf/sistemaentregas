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
     
        public int encontrados;
        public int encontradosPesquisa;
        public string retornoPersistencia;


        public void Salvar(int idtipound, string nomegasto)
        {

            dao.Salvar(idtipound, nomegasto);
            retornoRegistroSalvo();
        }

        public DataTable Listar(string nomegasto)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Listar(nomegasto);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("O Metodo 'Listar' não foi Executada\n\nA seguinte execessão foi lançada: " + e, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public DataTable ListarEmComboBox()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ListarEmComboBox();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("O Metodo 'Listar' não foi Executada\n\nA seguinte execessão foi lançada: " + e, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //ComplementoComboBoxTipoUnds

        public DataTable ComplementoComboBoxTipoUnds(int idtipogasto)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.ComplementoComboBoxTipoUnds(idtipogasto);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("O Metodo 'Listar' não foi Executada\n\nA seguinte execessão foi lançada: " + e, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        public void Excluir(int idtipogasto)
        {
            dao.Excluir(idtipogasto);
        }

        public void Editar(int idtipound, string nomegasto, int idtipogasto)
        {
            
            dao.Editar(idtipound,  nomegasto, idtipogasto);
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

        public DataTable ListaDataGrid(string parametro, string indexar, int offsett, int limitt)
        {
            try
            {
                retornoQuantRegistro();
                DataTable dt = new DataTable();
                dt = dao.ListarEmDataGrid(parametro, indexar, offsett, limitt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("O Metodo 'ConfiListagemDataGrid' não foi Executada\n\nA seguinte execessão foi lançada: " + e,
                                "Aviso do Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw;
            }
        }//ConfiListagemImportOE()


    
        public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarComeca(coluna, campo, pesquisar);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("O Metodo 'PesquisarComecaCom' não foi Executada\n\nA seguinte execessão foi lançada: " + e,
                                "Aviso do Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw;
            }

        }

        public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarContem(coluna, campo, pesquisar);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("O Metodo 'PesquisarContemCom' não foi Executada\n\nA seguinte execessão foi lançada: " + e,
                                "Aviso do Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw;
            }

        }
        public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarTermina(coluna, campo, pesquisar);
                return dt;
            }
            catch (Exception e)
            {

                MessageBox.Show("O Metodo 'PesquisarTerminaCom' não foi Executada\n\nA seguinte execessão foi lançada: " + e,
                                "Aviso do Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw;

            }

        }
    }
}

