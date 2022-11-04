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
      

                public  void Salvar(int idendereco, string nomepessoa, string complemento){    
                    modelPessoa.Idendereco = idendereco;
                    modelPessoa.Nomepessoa = nomepessoa;
                    modelPessoa.Complemento = complemento;
                    dao.Salvar(modelPessoa);
                    retornoRegistroSalvo();
                }
                public  void Excluir(int idpessoa){
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

                public int retornoQuantRegistro(){
                    return dao.ListarTodosRegistrosBD();
                }

                public int retornoQuantPesquisa(){
                    return dao.ListarPesquisados();
                }

                public string retornoRegistroSalvo(){
                    return dao.VerificarPersistencia();

                }

                public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt) {
                        retornoQuantRegistro();
                        return dao.ConfiListagemDataGridInnerJoin(parametro, indexar, offsett, limitt);
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

