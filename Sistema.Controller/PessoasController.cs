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
                    AcaoCrudPessoaDAO();
                }
                public  void Excluir(int idpessoa){
                    modelPessoa.Idpessoa = idpessoa;
                    dao.Excluir(modelPessoa);
                    AcaoCrudPessoaDAO();
                }

                public void Editar(int idpessoa, int idendereco, string nomepessoa, string complemento){
                    modelPessoa.Idpessoa = idpessoa;
                    modelPessoa.Idendereco = idendereco;
                    modelPessoa.Nomepessoa = nomepessoa;
                    modelPessoa.Complemento = complemento;
                    dao.Editar(modelPessoa);
                    AcaoCrudPessoaDAO();
                }

                public int ListarQtBDPessoaController(){
                    return dao.ListarQtBDPessoaDAO();
                }

                public int ListarPesquisados(){
                    return dao.ListarPesquisados();
                }

                public string AcaoCrudPessoaDAO(){
                    return dao.AcaoCrudPessoaDAO();

                }

                public DataTable ConfiListagemDataGrid(string parametro, string indexar, int offsett, int limitt) {
                        ListarQtBDPessoaController();
                        return dao.ListarDataGridInnerJoin(parametro, indexar, offsett, limitt);
                }

                public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar){
                        ListarPesquisados();
                        return dao.PesquisarComeca(coluna, campo, pesquisar);
                }

                public DataTable PesquisarContemCom(string coluna, string campo, string pesquisar){
                        ListarPesquisados();
                        return dao.PesquisarContem(coluna, campo, pesquisar);
                }

                public DataTable PesquisarTerminaCom(string coluna, string campo, string pesquisar){
                    ListarPesquisados();
                    return dao.PesquisarTermina(coluna, campo, pesquisar);
                }

            }
}

