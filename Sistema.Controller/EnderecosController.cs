using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Model;
using Sistema.DAO;
using System.Data;
using Sistema.DAO;
using Sistema.Model;

namespace Sistema.Controller
{
  public  class EnderecosController
    {
        EnderecosDAO dao = new EnderecosDAO();
        EnderecosModel modelEnderecos = new EnderecosModel();
        public int encontrados;
        public int encontradosPesquisa;
        public string retornoPersistencia;


        public void Salvar(string logradouro,  string bairro, string cidade, string uf, string cep )
        {

            modelEnderecos.Logradouro = logradouro;
            modelEnderecos.Bairro = bairro;
            modelEnderecos.Cidade = cidade;
            modelEnderecos.Uf = uf;
            modelEnderecos.Cep = cep;
            dao.Salvar(modelEnderecos);
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



        public void Excluir(int idendereco)
        {
            modelEnderecos.Idendereco = idendereco;
            dao.Excluir(modelEnderecos);
            retornoRegistroSalvo();
        }

        public void Editar(int idendereco, string logradouro, string bairro, string cidade, string uf, string cep)
        {

            modelEnderecos.Idendereco= idendereco;
            modelEnderecos.Logradouro = logradouro;
            modelEnderecos.Bairro = bairro;
            modelEnderecos.Cidade = cidade;
            modelEnderecos.Uf = uf;
            modelEnderecos.Cep = cep;
            dao.Editar(modelEnderecos);
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

