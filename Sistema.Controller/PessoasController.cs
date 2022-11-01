using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Model;
using Sistema.DAO;
using System.Data;
using System.Windows.Forms;

namespace Sistema.Controller
{
            public class PessoasController{
                PessoaDAO dao = new PessoaDAO();
                PessoasModel modelPessoa = new PessoasModel();
                public int encontrados;
                public int encontradosPesquisa;
                public string retornoPersistencia;


                public  void Salvar(int idendereco, string nomepessoa, string complemento){    
                    modelPessoa.Idendereco = idendereco;
                    modelPessoa.Nomepessoa = nomepessoa;
                    modelPessoa.Complemento = complemento;
                    dao.Salvar(modelPessoa);
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
                    catch (Exception e)
                    {
                    MessageBox.Show("O Metodo 'Listar' não foi Executada\n\nA seguinte execessão foi lançada: " +e, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                    }
                }


                public  void Excluir(int idpessoa)
                {
                    modelPessoa.Idpessoa = idpessoa;
                    dao.Excluir(modelPessoa);
                }

                public void Editar(int idpessoa, int idendereco, string nomepessoa, string complemento){
                    modelPessoa.Idpessoa = idpessoa;
                    modelPessoa.Idendereco = idendereco;
                    modelPessoa.Nomepessoa = nomepessoa;
                    modelPessoa.Complemento = complemento;
                    dao.Editar(modelPessoa);
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

                public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt)
                {
                    try
                    {
                        retornoQuantRegistro();
                        DataTable dt = new DataTable();
                        dt = dao.ConfiListagemDataGridInnerJoin(parametro, indexar, offsett, limitt);
                        return dt;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("O Metodo 'ConfiListagemDataGrid' não foi Executada\n\nA seguinte execessão foi lançada: " + e,
                                        "Aviso do Sistema", 
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        throw ;
                    }
                }

                public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar)
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        dt = dao.PesquisarComeca( coluna,  campo, pesquisar);
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

