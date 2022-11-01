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
  public  class TipoUndsController
    {
        TipoUndsDAO dao = new TipoUndsDAO();
      
        public int encontrados;
        public int encontradosPesquisa;
        public string retornoPersistencia;


        public void Salvar(string nomeund)
        {
            dao.Salvar(nomeund);
            AcaoCrudTipoUndsController();
        }


        public DataTable ListComboBoxTipoUndController(){
            try{
                DataTable dt = new DataTable();
                dt = dao.ListComboBoxTipoUndDAO();
                return dt;

            } catch (Exception e){

                MessageBox.Show("O Metodo 'Listar' não foi Executada\n\nA seguinte execessão foi lançada: " + e, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void Excluir(int idorigem)
        {
            dao.Excluir(idorigem);
            AcaoCrudTipoUndsController();
        }

        public void Editar(int idtipound, string nomeund)
        {
            dao.Editar(idtipound, nomeund);
            AcaoCrudTipoUndsController();
        }

        public int retornoQuantRegistro(){
            return dao.ListarTodosRegistrosBD(); ;
        }

        public int retornoQuantPesquisa()
        {
            encontradosPesquisa = dao.ListarPesquisados();
            return encontradosPesquisa;
        }

        public string AcaoCrudTipoUndsController()
        {
            return dao.AcaoCrudTipoUndsDAO();
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
                MessageBox.Show("O Metodo 'ConfiListagemDataGrid' não foi Executada\n\nA seguinte execessão foi lançada: " + e,
                                "Aviso do Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw;
            }
        }

        public DataTable ConfiListagemImpOE()
        {

            retornoQuantRegistro();
            DataTable dt = new DataTable();
            dt = dao.ConfiListagemImportOE();
            return dt;

        }

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

