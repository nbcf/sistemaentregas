using Sistema.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View.imports
{
    public partial class ImportEndereco : Form
    {
        public bool finalPaginaBol = false;
        public bool inicioPaginaBol = true;
        public bool estadoBotaoDesbloqueio = false;
        public bool edicaoDaPesquisa = false;
        public bool estadoBotaoDesbloqueioPesquisa = false;
        public bool edicaoDaPesquisaPesquisa = false;
        public bool finalPaginaBolPesquisa = false;
        public bool inicioPaginaBolPesquisa = true;
        public bool actBehaviorSerarch = false;
        public string strLogradouro;
        public string strBairro;
        public string strCidade;
        public string strUf;
        public string strCep;

        public string porteiro = "fechado";
        public string switchSalvarFlag = "vazio";
        public string name = "";
        public string gender = "";
        public string programmingLanguage = "";
        public string Subject = "";
        public string excelImagePath = "";
        public string operationType = "newInsertion";
        public string typeEdition = "insert";
        public string pegaDirPadrao;
        public string parametroCodigoAlfabeto = "null";
        public string parametroASCDESC = "null";
        public string stringPapel;
        public int paginaAtual = 0;
        public int paginar = 0;
        public int paginarListagemGrid = 0;
        public int deslocado = 0;
        public int ultimaPagina = 0;
        public int deslocamento1;
        public int fimDePagina = 0;
        public int resultado = 0;
        public int totalPaginas = 0;
        public int memoria = 1;
        public int countBttnToggle = 1;
        public int offsettPag = 0;
        public int countBttnToggleTools = 1;
        public int paginaAtualPesquisa = 0;
        public int paginarPesquisa = 0;
        public int deslocadoPesquisa = 0;
        public int ultimaPaginaPesquisa = 0;
        public int posicaoTamanhoFontePesquisa = 1;
        public int getOffSettPesquisa;
        public int fimDePaginaPesquisa = 0;
        public int resultadoPesquisa = 0;
        public int totalPaginasPesquisa = 0;
        public int memoriaPesquisa = 1;


        private static ImportEndereco _InstanciaformImportEndereco;
        public static ImportEndereco GetInstanciaformImportEndereco()
        {
            if (_InstanciaformImportEndereco == null)
            {
                _InstanciaformImportEndereco = new ImportEndereco();
            }
            return _InstanciaformImportEndereco;
        }


        EnderecosController controllerEnderecos = new EnderecosController();

        public ImportEndereco()
        {
            InitializeComponent();
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {

        }


        private void puxarparametroPesquisa()
        {
            string estadoPesquisa = "";
            string pesquisarEmColuna = Convert.ToString(cbButtonPesquisarEm.SelectedItem);
            if (radioBttnComeca.Checked == true)
            {
                estadoPesquisa = "ComecaCom";
            }
            else if (radioBttnContem.Checked == true)
            {
                estadoPesquisa = "Contem";
            }
            else if (radioBttnTermina.Checked == true)
            {
                estadoPesquisa = "TerminaCom";
            }
            else if (radioBttnComeca.Checked == false)
            {
                estadoPesquisa = "";
            }
            else if (radioBttnContem.Checked == false)
            {
                estadoPesquisa = "";
            }
            else if (radioBttnTermina.Checked == false)
            {
                estadoPesquisa = "";
            }

            if (actBehaviorSerarch == true)
            {

                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Logradouro"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarComecaCom("logradouro", "@logradouro", txtBoxPesquisar.Text);
                    DataGridModel();
                    // toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Logradouro"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarContemCom("logradouro", "@logradouro", txtBoxPesquisar.Text);
                    DataGridModel();
                    //  toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Logradouro"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarTerminaCom("logradouro", "@logradouro", txtBoxPesquisar.Text);
                    DataGridModel();
                    //  toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                //***********************

                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Complemento"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarComecaCom("complemento", "@complemento", txtBoxPesquisar.Text);
                    DataGridModel();
                    //  toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Complemento"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarContemCom("complemento", "@complemento", txtBoxPesquisar.Text);
                    DataGridModel();
                    //  toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Complemento"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarTerminaCom("complemento", "@complemento", txtBoxPesquisar.Text);
                    DataGridModel();
                    //   toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                //*************************************
                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Bairro"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarComecaCom("bairro", "@bairro", txtBoxPesquisar.Text);
                    DataGridModel();
                    // toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Bairro"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarContemCom("bairro", "@bairro", txtBoxPesquisar.Text);
                    DataGridModel();
                    // toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Bairro"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarTerminaCom("bairro", "@bairro", txtBoxPesquisar.Text);
                    DataGridModel();
                    //  toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }

                //************************************* 
                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Cidade"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarComecaCom("cidade", "@cidade", txtBoxPesquisar.Text);
                    DataGridModel();
                    //   toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Cidade"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarContemCom("cidade", "@cidade", txtBoxPesquisar.Text);
                    DataGridModel();
                    //    toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Cidade"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarTerminaCom("cidade", "@cidade", txtBoxPesquisar.Text);
                    DataGridModel();
                    //    toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                //************************************* 
                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Cep"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarComecaCom("cep", "@cep", txtBoxPesquisar.Text);
                    DataGridModel();
                    //    toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Cep"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarContemCom("cep", "@cep", txtBoxPesquisar.Text);
                    DataGridModel();
                    //  toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Cep"))
                {
                    gridCrudEndereco.DataSource = controllerEnderecos.PesquisarTerminaCom("cep", "@cep", txtBoxPesquisar.Text);
                    DataGridModel();
                    //  toolStripLabel2.Text = Convert.ToString(controllerEnderecos.PesquisaEnderecosController());
                }
            }
        }

        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {

            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudEndereco.DataSource = controllerEnderecos.ListarDataGrid("idendereco", "desc", offset, limitt);
                DataGridModel();
                //  labelTextTotalRegFould.Text = Convert.ToString(controllerEnderecos.ListarBDEnderecosController());
                // carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudEndereco.DataSource = controllerEnderecos.ListarDataGrid("idendereco", "asc", offset, limitt);
                DataGridModel();
                //  labelTextTotalRegFould.Text = Convert.ToString(controllerEnderecos.ListarBDEnderecosController());
                // carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudEndereco.DataSource = controllerEnderecos.ListarDataGrid("logradouro", "desc", offset, limitt);
                DataGridModel();
                //  labelTextTotalRegFould.Text = Convert.ToString(controllerEnderecos.ListarBDEnderecosController());
                //  carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudEndereco.DataSource = controllerEnderecos.ListarDataGrid("logradouro", "asc", offset, limitt);
                DataGridModel();
                //  labelTextTotalRegFould.Text = Convert.ToString(controllerEnderecos.ListarBDEnderecosController());
                //  carregarInformacoes();
            }
        }

    

        private void DataGridModel()
        {
            gridCrudEndereco.Columns[0].HeaderText = "ID";
            gridCrudEndereco.Columns[1].HeaderText = "Logradouro";
            gridCrudEndereco.Columns[2].HeaderText = "Bairro";
            gridCrudEndereco.Columns[3].HeaderText = "Cidade";
            gridCrudEndereco.Columns[4].HeaderText = "Uf";
            gridCrudEndereco.Columns[5].HeaderText = "Cep";
            gridCrudEndereco.Columns[0].Width = 80;
            gridCrudEndereco.Columns[1].Width = 200;
            gridCrudEndereco.Columns[2].Width = 200;
            gridCrudEndereco.Columns[3].Width = 150;
            gridCrudEndereco.Columns[4].Width = 100;
            gridCrudEndereco.Columns[5].Width = 100;
        }


        private void behaviorRefresh()
        {

            if (operationType == "updateData" && typeEdition == "search")
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnEdit.Enabled = true;
                bttnSave.Enabled = false;
                bttnSearch.Enabled = true;
                puxarparametroPesquisa();
            }
            else if (operationType == "" ||
                    operationType == "newInsertion" ||
                    operationType == "updateData" ||
                    operationType == "search" && typeEdition == "insert")
            {
                bttnDel.Enabled = false;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;
                radioBttnComeca.Checked = false;
                radioBttnContem.Checked = false;
                radioBttnTermina.Checked = false;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                clearFieldsFormulario();
                //   puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
            }
            else if (operationType == "" ||
                    operationType == "newInsertion" ||
                    operationType == "updateData" ||
                    operationType == "search" && typeEdition == "search")
            {
                bttnDel.Enabled = false;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;
                radioBttnComeca.Checked = false;
                radioBttnContem.Checked = false;
                radioBttnTermina.Checked = false;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                clearFieldsFormulario();
                //      puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
            }
        }
        private void behaviorNewInsert()
        {
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = false;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = true;
            bttnNew.Enabled = false;
            operationType = "newInsertion";
            txtBoxId.Enabled = false;
            txtBoxId.Enabled = false;

            formEditEnderecos frmEditEnderecos = new formEditEnderecos();
            strLogradouro = "";

            strBairro = "";
            strCidade = "";
            strUf = "";
            strCep = "";

            frmEditEnderecos.LogradouroVO = strLogradouro;

            frmEditEnderecos.BairroVO = strBairro;
            frmEditEnderecos.CidadeVO = strCidade;
            frmEditEnderecos.UfVO = strUf;
            frmEditEnderecos.CepVO = strCep;
            frmEditEnderecos.ShowDialog();

            if ("sair".Equals(frmEditEnderecos.AcaoDialogVO))
            {
                strLogradouro = "";
                txtBoxId.Text = "";

                strBairro = "";
                strCidade = "";
                strUf = "";
                strCep = "";
                behaviorRefresh();
            }

            else if ("ok".Equals(frmEditEnderecos.AcaoDialogVO))
            {
                strLogradouro = frmEditEnderecos.LogradouroVO;

                strBairro = frmEditEnderecos.BairroVO;
                strCidade = frmEditEnderecos.CidadeVO;
                strUf = frmEditEnderecos.UfVO;
                strCep = frmEditEnderecos.CepVO;
                behaviorSave();
            }

        }

     

        private void behaviorSave()
        {


            string retiraEspacos = strLogradouro;
            string remPapel = retiraEspacos.Trim();

            string retiraEspacosId = txtBoxId.Text;
            string remEspacosId = retiraEspacosId.Trim();




            if (remEspacosId.Equals("") || remEspacosId == null)
            {
                if (operationType.Equals("newInsertion") && typeEdition.Equals("insert"))
                {
                    if (remPapel.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Inserção não alcançou o número mínimo de 3 caracteres.\n" +
                        "Para tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.",
                        "Aviso do Sistema",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            MessageBox.Show("1");
                            stringPapel = "";
                        }
                        else if (resultado == DialogResult.No)
                        {
                            MessageBox.Show("2");
                            behaviorRefresh();
                        }
                    }
                    else if (remPapel.Length >= 3)
                    {
                        controllerEnderecos.Salvar(strLogradouro, strBairro, strCidade, strUf, strCep);

                        //  if (controllerEnderecos.retornoPersistencia.Equals("NS"))
                        if ("NS".Equals(controllerEnderecos.AcaoCrudEnderecosDAO()))
                        {
                            MessageBox.Show("3");
                            stringPapel = "";
                            behaviorRefresh();
                        }
                        else if ("S!".Equals(controllerEnderecos.AcaoCrudEnderecosDAO()))
                        {
                            MessageBox.Show("4");
                            operationType = "newInsertion";
                            typeEdition = "insert";
                            //  acoesBehaviorSave();
                            behaviorRefresh();
                            MessageBox.Show("Registro Salvo Com Sucesso!", "Aviso de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if ("S!!".Equals(controllerEnderecos.AcaoCrudEnderecosDAO()))
                        {
                            MessageBox.Show("5");
                            operationType = "newInsertion";
                            typeEdition = "insert";
                            //acoesBehaviorSave();
                            behaviorRefresh();
                            MessageBox.Show("Dado Existente Salvo!", "Aviso de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if ("NS".Equals(controllerEnderecos.AcaoCrudEnderecosDAO()))
                    {
                        MessageBox.Show("6");
                        operationType = "newInsertion";
                        typeEdition = "insert";
                        //acoesBehaviorSave();
                        behaviorRefresh();
                    }
                }

            }
            else if (!remEspacosId.Equals("") || remEspacosId != null)
            {

                if (operationType.Equals("updateData") && typeEdition.Equals("insert"))
                {
                    if (remPapel.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            stringPapel = "";
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (remPapel.Length >= 3)
                    {
                        controllerEnderecos.Editar(Convert.ToInt32(txtBoxId.Text), strLogradouro, strBairro, strCidade, strUf, strCep);

                        if ("AT".Equals(controllerEnderecos.AcaoCrudEnderecosDAO()))
                        {

                            // operationType = "";
                            //  typeEdition = "";
                            behaviorRefresh();
                            MessageBox.Show(" Resgistro Listado doi Editado !   \n    else if (operationType.Equals(updateData) && typeEdition.Equals(insert) ) ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    if ("NS".Equals(controllerEnderecos.AcaoCrudEnderecosDAO()))
                    {
                        // operationType = "newInsertion";
                        //   typeEdition = "insert";
                        //acoesBehaviorSave();
                        behaviorRefresh();
                    }
                }
                else if (operationType.Equals("updateData") && typeEdition.Equals("search"))
                {

                    MessageBox.Show("8!");
                    if (remPapel.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {

                            stringPapel = "";
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }

                    }
                    else if (remPapel.Length >= 3)
                    {
                        controllerEnderecos.Editar(Convert.ToInt32(txtBoxId.Text), strLogradouro, strBairro, strCidade, strUf, strCep);

                        if ("AT".Equals(controllerEnderecos.AcaoCrudEnderecosDAO()))
                        {
                            behaviorRefresh();
                            puxarparametroPesquisa();
                            MessageBox.Show("Registro Pesquisado foi Atualizado !  \n else if (operationType.Equals(search) && typeEdition.Equals(search))", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    if ("NS".Equals(controllerEnderecos.AcaoCrudEnderecosDAO()))
                    {
                        //operationType = "newInsertion";
                        //typeEdition = "insert";
                        //acoesBehaviorSave();
                        behaviorRefresh();
                    }
                }
            }
        }


        private void behaviorEdit()
        {
            typeEdition = "insert";
            operationType = "updateData";
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = false;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = true;
            bttnNew.Enabled = false;
            txtBoxId.Enabled = false;
            txtBoxId.Text = gridCrudEndereco.CurrentRow.Cells[0].Value.ToString();
            stringPapel = gridCrudEndereco.CurrentRow.Cells[1].Value.ToString();

            formEditEnderecos frmEditEnderecos = new formEditEnderecos();
            frmEditEnderecos.LogradouroVO = strLogradouro;

            frmEditEnderecos.BairroVO = strBairro;
            frmEditEnderecos.CidadeVO = strCidade;
            frmEditEnderecos.UfVO = strUf;
            frmEditEnderecos.CepVO = strCep;
            frmEditEnderecos.ShowDialog();

            if ("sair".Equals(frmEditEnderecos.AcaoDialogVO))
            {
                bttnRefresh.Enabled = false;
                stringPapel = "";
                strLogradouro = "";
                strBairro = "";
                strCidade = "";
                strUf = "";
                strCep = "";
                bttnRefresh.Enabled = false;
                behaviorRefresh();
            }

            else if ("ok".Equals(frmEditEnderecos.AcaoDialogVO))
            {
                strLogradouro = frmEditEnderecos.LogradouroVO;
                strBairro = frmEditEnderecos.BairroVO;
                strCidade = frmEditEnderecos.CidadeVO;
                strUf = frmEditEnderecos.UfVO;
                strCep = frmEditEnderecos.CepVO;
                bttnRefresh.Enabled = false;
                behaviorSave();
            }
        }

        private void behaviorEditPesquisa()
        {
            typeEdition = "search";
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = false;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = true;
            bttnNew.Enabled = false;
            clearFieldsFormulario();
            txtBoxId.Enabled = false;
            txtBoxId.Text = gridCrudEndereco.CurrentRow.Cells[0].Value.ToString();
            stringPapel = gridCrudEndereco.CurrentRow.Cells[1].Value.ToString();

            formEditEnderecos frmEditEnderecos = new formEditEnderecos();


            frmEditEnderecos.LogradouroVO = strLogradouro;

            frmEditEnderecos.BairroVO = strBairro;
            frmEditEnderecos.CidadeVO = strCidade;
            frmEditEnderecos.UfVO = strUf;
            frmEditEnderecos.CepVO = strCep;
            frmEditEnderecos.ShowDialog();




            if ("sair".Equals(frmEditEnderecos.AcaoDialogVO))
            {

                bttnRefresh.Enabled = false;
                stringPapel = "";
                strLogradouro = "";

                strBairro = "";
                strCidade = "";
                strUf = "";
                strCep = "";
                bttnRefresh.Enabled = false;
                behaviorRefresh();

            }

            else if ("ok".Equals(frmEditEnderecos.AcaoDialogVO))
            {
                strLogradouro = frmEditEnderecos.LogradouroVO;

                strBairro = frmEditEnderecos.BairroVO;
                strCidade = frmEditEnderecos.CidadeVO;
                strUf = frmEditEnderecos.UfVO;
                strCep = frmEditEnderecos.CepVO;
                bttnRefresh.Enabled = false;
                behaviorSave();

            }

        }

        private void behaviorClickGrid()
        {
            txtBoxId.Text = gridCrudEndereco.CurrentRow.Cells[0].Value.ToString();
            strLogradouro = gridCrudEndereco.CurrentRow.Cells[1].Value.ToString();
            strBairro = gridCrudEndereco.CurrentRow.Cells[2].Value.ToString();
            strCidade = gridCrudEndereco.CurrentRow.Cells[3].Value.ToString();
            strUf = gridCrudEndereco.CurrentRow.Cells[4].Value.ToString();
            strCep = gridCrudEndereco.CurrentRow.Cells[5].Value.ToString();


            bttnNew.Enabled = true;
            bttnDel.Enabled = true;
            bttnEdit.Enabled = true;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = false;
            bttnSave.Enabled = false;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            clearFieldsFormulario();
            txtBoxId.Text = gridCrudEndereco.CurrentRow.Cells[0].Value.ToString();
            stringPapel = gridCrudEndereco.CurrentRow.Cells[1].Value.ToString();

        }

        private void behaviorClickGridPesquisa()
        {

            txtBoxId.Text = gridCrudEndereco.CurrentRow.Cells[0].Value.ToString();
            strLogradouro = gridCrudEndereco.CurrentRow.Cells[1].Value.ToString();
            strBairro = gridCrudEndereco.CurrentRow.Cells[2].Value.ToString();
            strCidade = gridCrudEndereco.CurrentRow.Cells[3].Value.ToString();
            strUf = gridCrudEndereco.CurrentRow.Cells[4].Value.ToString();
            strCep = gridCrudEndereco.CurrentRow.Cells[5].Value.ToString();

            bttnNew.Enabled = false;
            bttnDel.Enabled = true;
            bttnEdit.Enabled = true;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = false;
            bttnSave.Enabled = false;

            txtBoxId.Text = gridCrudEndereco.CurrentRow.Cells[0].Value.ToString();
            stringPapel = gridCrudEndereco.CurrentRow.Cells[1].Value.ToString();
        }




        public void clearFieldsFormulario() { txtBoxId.Text = ""; stringPapel = ""; }
        public void clearFieldsPesquisar() { txtBoxPesquisar.Text = ""; cbButtonPesquisarEm.SelectedValue = 0; }
        public void disableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }
        public void enableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }




      

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            countBttnToggle++;
            if (countBttnToggle % 2 == 0)
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                actBehaviorSerarch = true;
            }
            else
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
                actBehaviorSerarch = false;
            }
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            behaviorRefresh();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            countBttnToggleTools++;
            if (countBttnToggleTools % 2 == 0)
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                bttnSearch.Enabled = false;
            }
            else
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSearch.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            countBttnToggle++;
            if (countBttnToggle % 2 != 0)
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
            }
            else
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
            }
        }




      



        private void radioBttnContem_CheckedChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnTermina_CheckedChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnComeca_CheckedChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {

            var gridVazia = gridCrudEndereco.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia))
            {
            }
            else if (gridVazia.Length > 0)
            {
                if (typeEdition.Equals("insert") && operationType.Equals("newInsertion"))
                {
                    behaviorEdit();
                }
                else if (typeEdition.Equals("search") && operationType.Equals("updateData"))
                {
                    behaviorEditPesquisa();
                }


            }
        }

        private void gridCrudPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridVazia = gridCrudEndereco.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia))
            { }
            else if (gridVazia.Length > 0)
            {
                if (typeEdition.Equals("insert"))
                {
                    operationType = "newInsertion";
                    behaviorClickGrid();
                }
                else if (typeEdition.Equals("search"))
                {
                    operationType = "updateData";
                    behaviorClickGridPesquisa();

                }
            }
        }

     
      

        private void gridCrudPapeis_CellClick(object sender, EventArgs e)
        {
            var gridVazia = gridCrudEndereco.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia))
            {

            }
            else if (gridVazia.Length > 0)
            {

                //    operationType = "newInsertion";
                //    typeEdition = "insert";   operationType.Equals("newInsertion") &&  operationType.Equals("search") &&

                if (typeEdition.Equals("insert"))
                {
                    operationType = "newInsertion";
                    //  MessageBox.Show("Metodo:  gridCrudPessoa_CellClick" + "operationType :" + operationType + " typeEdition: " + typeEdition + "\n");

                    behaviorClickGrid();
                }
                else if (typeEdition.Equals("search"))
                {
                    operationType = "updateData";
                    // MessageBox.Show("Metodo:  gridCrudPessoa_CellClick" + "operationType :" + operationType + " typeEdition: " + typeEdition + "\n");
                    behaviorClickGridPesquisa();
                    //  MessageBox.Show(typeEdition);
                }


            }
        }

        private void radioBttnTermina_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnComeca_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnContem_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void cbButtonPesquisarEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

      
        private void gridCrudPapeis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridVazia = gridCrudEndereco.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia))
            {

            }
            else if (gridVazia.Length > 0)
            {

                if (typeEdition.Equals("insert"))
                {
                    operationType = "newInsertion";
                    behaviorClickGrid();
                }
                else if (typeEdition.Equals("search"))
                {
                    operationType = "updateData";
                    behaviorClickGridPesquisa();
                }


            }
        }


    }

}

