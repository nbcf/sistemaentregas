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

namespace Sistema.View.views
{
    public partial class GastosView : Form
    {
        public string strIdFornecedores;
        public string strIdTipoGastos;
        public string strIdTipoUnit;

        public string strTipoUnit;
        public bool finalPaginaBol = false;
        public bool inicioPaginaBol = true;
        public bool estadoBotaoDesbloqueio = false;
        public bool edicaoDaPesquisa = false;
        public bool estadoBotaoDesbloqueioPesquisa = false;
        public bool edicaoDaPesquisaPesquisa = false;
        public bool finalPaginaBolPesquisa = false;
        public bool inicioPaginaBolPesquisa = true;
        public bool actBehaviorSerarch = false;
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


        private static GastosView _InstanciaGastosView;
        public static GastosView GetInstanciaGastosView()
        {
            if (_InstanciaGastosView == null)
            {
                _InstanciaGastosView = new GastosView();
            }
            return _InstanciaGastosView;
        }

        TipoGastosController    controllerTipoGastos    = new   TipoGastosController();
        TipoUndsController      controllerTipoUnds      = new   TipoUndsController();
        FornecedoresController  controllerFornecedores  = new   FornecedoresController();
        GastosController        controllerGastos        = new   GastosController();

        public GastosView()
        {
            InitializeComponent();
            carregarEstadoPadrao("CarregaPadraoIDTodosUltimos", 0);
        }

        private void puxarparametro(int deslocamento, int limiteregistro, string inicioDeslocamento)
        {

            string jcbOrdem = Convert.ToString(cbOrdemParam1.SelectedItem);
            string ordem = "";
            if (Convert.ToString(cbOrdenarPor1.SelectedItem).Equals("Primeiros"))
            {
                ordem = "primeiros";
            }
            else if (Convert.ToString(cbOrdenarPor1.SelectedItem).Equals("Ultimos"))
            {
                ordem = "ultimos";
            }

            if (actBehaviorSerarch == false)

                if (jcbOrdem.Equals("Codigo") && ordem.Equals("primeiros"))
                {
                    parametroCodigoAlfabeto = "Codigo";
                    parametroASCDESC = "primeiros";

                    if (cbButtnQuantPage1.SelectedText == "Todos") { }
                    else
                    {
                        if (inicioDeslocamento.Equals("Sim"))
                        {
                            resetarPonteiros();
                            this.EnviaModelo("CarregaPadraoIDTodosPrimeiros", deslocamento, limiteregistro);
                        }
                        else if (inicioDeslocamento.Equals("Nao"))
                        {

                            this.EnviaModelo("CarregaPadraoIDTodosPrimeiros", deslocamento, limiteregistro);
                        }
                    }
                }
                else if (jcbOrdem.Equals("Codigo") && ordem.Equals("ultimos"))
                {
                    parametroCodigoAlfabeto = "Codigo";
                    parametroASCDESC = "ultimos";

                    if (cbButtnQuantPage1.SelectedText == "Todos")
                    {
                    }
                    else
                    {

                        paginar = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
                        ultimaPagina = paginar;
                        if (inicioDeslocamento.Equals("Sim"))
                        {
                            resetarPonteiros();
                            this.EnviaModelo("CarregaPadraoIDTodosUltimos", deslocamento, limiteregistro);
                        }
                        else if (inicioDeslocamento.Equals("Nao"))
                        {
                            this.EnviaModelo("CarregaPadraoIDTodosUltimos", deslocamento, limiteregistro);
                        }
                    }
                }
                else if (jcbOrdem.Equals("Alfabeto") && ordem.Equals("primeiros"))
                {
                    parametroCodigoAlfabeto = "Alfabeto";
                    parametroASCDESC = "primeiros";

                    if (cbButtnQuantPage1.SelectedText == "Todos")
                    {
                    }
                    else
                    {
                        if (inicioDeslocamento.Equals("Sim"))
                        {
                            resetarPonteiros();
                            this.EnviaModelo("CarregaPadraoNomeTodosPrimeiros", deslocamento, limiteregistro);
                        }
                        else if (inicioDeslocamento.Equals("Nao"))
                        {
                            this.EnviaModelo("CarregaPadraoNomeTodosPrimeiros", deslocamento, limiteregistro);
                        }
                    }
                }
                else if (jcbOrdem.Equals("Alfabeto") && ordem.Equals("ultimos"))
                {
                    parametroCodigoAlfabeto = "Alfabeto";
                    parametroASCDESC = "ultimos";
                    if (cbButtnQuantPage1.SelectedText == "Todos")
                    {
                    }
                    else
                    {

                        if (inicioDeslocamento.Equals("Sim"))
                        {
                            resetarPonteiros();
                            this.EnviaModelo("CarregaPadraoNomeTodosUltimos", deslocamento, limiteregistro);
                        }
                        else if (inicioDeslocamento.Equals("Nao"))
                        {
                            this.EnviaModelo("CarregaPadraoNomeTodosUltimos", deslocamento, limiteregistro);
                        }
                    }
                }
        }




        public void somar()
        {
            int pagina1 = Convert.ToInt32(labelTextTotalPages.Text);
            int pg = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
            if (memoria < pagina1 && finalPaginaBol == false)
            {
                deslocamento1 = paginaAtual + pg;
                paginarPesquisa = deslocamento1;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                memoria++;
                labelTextPageFrom.Text = memoria.ToString();
                bttnBeginPages.Enabled = true;
                bttnBeginPages.Enabled = true;
                this.puxarparametro(deslocamento1, pg, "Nao");
                if (memoria == pagina1)
                {
                    bttnOnePageRight.Enabled = false;
                    bttnEndPages.Enabled = false;
                    finalPaginaBol = true;
                    inicioPaginaBol = false;
                }
            }
            else if (memoria < pagina1 && finalPaginaBol == true)
            {
                deslocamento1 = paginaAtual + pg;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                memoria++;
                labelTextPageFrom.Text = memoria.ToString();
                bttnBeginPages.Enabled = true;
                bttnBeginPages.Enabled = true;
                this.puxarparametro(deslocamento1, paginar, "Nao");
                if (memoria == pagina1)
                {
                    bttnOnePageRight.Enabled = false;
                    bttnEndPages.Enabled = false;
                    finalPaginaBol = true;
                    inicioPaginaBol = false;
                }
            }
        }

        public void descontar()
        {
            int pagina1 = Convert.ToInt32(labelTextTotalPages.Text);
            int pg = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
            if (memoria > 1 && memoria <= pagina1 && inicioPaginaBol == true)
            {
                deslocamento1 = deslocamento1 - pg;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                --memoria;
                labelTextPageFrom.Text = Convert.ToString(memoria);
                bttnOnePageRight.Enabled = true;
                bttnEndPages.Enabled = true;
                this.puxarparametro(deslocamento1, pg, "Nao");
                if (memoria == 1)
                {
                    bttnOnePageRight.Enabled = true;
                    bttnEndPages.Enabled = true;
                    inicioPaginaBol = true;
                    finalPaginaBol = false;
                    MessageBox.Show("Início da Paginação", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (memoria > 1 && memoria <= pagina1 && inicioPaginaBol == false)
            {
                deslocamento1 = deslocamento1 - pg;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                --memoria;
                labelTextPageFrom.Text = Convert.ToString(memoria);
                this.puxarparametro(deslocamento1, pg, "Nao");
                bttnOnePageRight.Enabled = true;
                bttnEndPages.Enabled = true;
                if (finalPaginaBol == true)
                {
                    bttnOnePageRight.Enabled = true;
                    bttnEndPages.Enabled = true;
                }
                if (memoria == 1)
                {
                    inicioPaginaBol = true;
                    finalPaginaBol = false;
                }
            }
        }


        public void inicioPagina()
        {

            resetarPonteiros();
            this.puxarparametro(deslocamento1, paginar, "Nao");
        }


        public void finalDaPagina()
        {
            int pagina1 = Convert.ToInt32(labelTextTotalPages.Text);
            int ajustaPaginacao = pagina1 - 1;
            int pg = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
            for (int i = memoria; memoria <= ajustaPaginacao; i++)
            {
                deslocamento1 = paginaAtual + pg;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                memoria++;
                if (memoria == pagina1)
                {
                    bttnOnePageRight.Enabled = false;
                    bttnEndPages.Enabled = false;
                    bttnBeginPages.Enabled = true;
                    bttnBeginPages.Enabled = true;
                    labelTextPageFrom.Text = Convert.ToString(memoria);
                    inicioPaginaBol = false;
                    finalPaginaBol = true;
                    this.puxarparametro(deslocamento1, pg, "Nao");
                }
            }
        }


        public void resetarPonteiros()
        {
            finalPaginaBol = false;
            inicioPaginaBol = true;
            bttnOnePageRight.Enabled = true;
            bttnEndPages.Enabled = true;
            labelTextPageFrom.Text = Convert.ToString(1);
            paginaAtual = 0;
            paginar = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
            deslocado = 0;
            memoria = 1;
            deslocamento1 = 0;
            paginarPesquisa = 0;
            actBehaviorSerarch = false;
        }



        public void carregarInformacoes()
        {
            resultado = 0;
            int quantidadeReg = 0;
            quantidadeReg = Convert.ToInt32(controllerGastos.retornoQuantRegistro());
            int jcbPaginas = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);

            resultado = quantidadeReg / jcbPaginas;
            int resto = quantidadeReg % jcbPaginas;
            if (resto >= 1)
            {
                labelTextTotalPages.Text = Convert.ToString(resultado + 1);
            }
            else if (resto == 0)
            {
                labelTextTotalPages.Text = Convert.ToString(resultado);
            }
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
                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Entregador"))
                {
                    dataGridGastos.DataSource = controllerGastos.PesquisarComecaCom("nomegasto", "@nomegasto", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerGastos.retornoQuantPesquisa());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Entregador"))
                {
                    dataGridGastos.DataSource = controllerGastos.PesquisarContemCom("nomegasto", "@nomegasto", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerGastos.retornoQuantPesquisa());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Entregador"))
                {
                    dataGridGastos.DataSource = controllerGastos.PesquisarTerminaCom("nomegasto", "@nomegasto", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerGastos.retornoQuantPesquisa());
                }


                else if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Veiculo"))
                {
                    dataGridGastos.DataSource = controllerGastos.PesquisarComecaCom("nomegasto", "@nomegasto", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerGastos.retornoQuantPesquisa());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Veiculo"))
                {
                    dataGridGastos.DataSource = controllerGastos.PesquisarContemCom("nomegasto", "@nomegasto", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerGastos.retornoQuantPesquisa());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Veiculo"))
                {
                    dataGridGastos.DataSource = controllerGastos.PesquisarTerminaCom("nomegasto", "@nomegasto", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerGastos.retornoQuantPesquisa());
                }



               else if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Saida"))
                {
                    dataGridGastos.DataSource = controllerGastos.PesquisarComecaCom("nomegasto", "@nomegasto", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerGastos.retornoQuantPesquisa());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Saida"))
                {
                    dataGridGastos.DataSource = controllerGastos.PesquisarContemCom("nomegasto", "@nomegasto", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerGastos.retornoQuantPesquisa());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Saida"))
                {
                    dataGridGastos.DataSource = controllerGastos.PesquisarTerminaCom("nomegasto", "@nomegasto", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerGastos.retornoQuantPesquisa());
                }




            }
        }

        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {
            //   MessageBox.Show("EnviaModelo");


            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                dataGridGastos.DataSource = controllerGastos.ListarDataGrid("idtipound", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerGastos.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                dataGridGastos.DataSource = controllerGastos.ListarDataGrid("idtipound", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerGastos.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                dataGridGastos.DataSource = controllerGastos.ListarDataGrid("nomegasto", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerGastos.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                dataGridGastos.DataSource = controllerGastos.ListarDataGrid("nomegasto", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerGastos.retornoQuantRegistro());
                carregarInformacoes();
            }

        }

        public void carregarEstadoPadrao(string pesquisa, int offsett)
        {
            cbButtnQuantPage1.SelectedIndex = 0;
            int quantRegPage = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
            cbOrdenarPor1.SelectedIndex = 1;
            cbOrdemParam1.SelectedIndex = 0;
            resetarPonteiros();
            this.puxarparametro(0, quantRegPage, "Nao");
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            //    bttnPrint.Enabled = false;
            //   bttnImport.Enabled = false;
            //    bttnExcel.Enabled = false;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            dataGridGastos.Visible = true;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = false;
            groupBoxFormulario.Visible = false;
            bttnBeginPages.Visible = true;
            bttnOnePageLeft.Visible = true;
            labelTextPageFrom.Visible = true;
            toolStripLabel3.Visible = true;
            labelTextTotalPages.Visible = true;
            toolStripLabel5.Visible = true;
            labelTextTotalRegFould.Visible = true;
            bttnOnePageRight.Visible = true;
            bttnEndPages.Visible = true;
            toolStripLabel1.Visible = false;
            toolStripLabel2.Visible = false;

            clearFieldsFormulario();
            disableFieldsFormulario();

        }

        private void bttnTools_Click(object sender, EventArgs e)
        {
            countBttnToggleTools++;
            if (countBttnToggleTools % 2 == 0)
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                //  tabControlAssets.TabPages.Remove(tabPageFormulario);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                //  tabControlAssets.TabPages.Remove(tabPageOptListagem);
                //   tabControlAssets.TabPages.Insert(0, tabPageOptListagem);

                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                bttnSearch.Enabled = false;

            }
            else
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                //tabControlAssets.TabPages.Remove(tabPageFormulario);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                //     tabControlAssets.TabPages.Remove(tabPageOptListagem);

                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSearch.Enabled = true;
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");

            }
        }

        private void behaviorRefresh()
        {

            if (operationType == "updateData" && typeEdition == "search")
            {
                dataGridGastos.Visible = true;
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnEdit.Enabled = true;
                bttnSave.Enabled = false;
                bttnSearch.Enabled = true;


            }
            else if (operationType == "" || operationType == "newInsertion" || operationType == "updateData" || operationType == "search" && typeEdition == "insert")
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
                dataGridGastos.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                dataGridGastos.ClearSelection();
                bttnBeginPages.Visible = true;
                bttnOnePageLeft.Visible = true;
                labelTextPageFrom.Visible = true;
                toolStripLabel3.Visible = true;
                labelTextTotalPages.Visible = true;
                toolStripLabel5.Visible = true;
                labelTextTotalRegFould.Visible = true;
                bttnOnePageRight.Visible = true;
                bttnEndPages.Visible = true;
                toolStripLabel2.Visible = false;
                toolStripLabel4.Visible = true;
                cbButtnQuantPage1.Visible = true;
                toolStripLabel6.Visible = true;
                cbOrdemParam1.Visible = true;
                toolStripLabel7.Visible = true;
                toolStrip2.Visible = true;

            }
            else if (operationType == "" || operationType == "newInsertion" || operationType == "updateData" || operationType == "search" && typeEdition == "search")
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
                dataGridGastos.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                dataGridGastos.ClearSelection();
                toolStripLabel2.Visible = false;
                bttnBeginPages.Visible = true;
                bttnOnePageLeft.Visible = true;
                labelTextPageFrom.Visible = true;
                toolStripLabel3.Visible = true;
                labelTextTotalPages.Visible = true;
                toolStripLabel5.Visible = true;
                labelTextTotalRegFould.Visible = true;
                bttnOnePageRight.Visible = true;
                bttnEndPages.Visible = true;
                toolStripLabel4.Visible = true;
                cbButtnQuantPage1.Visible = true;
                toolStripLabel6.Visible = true;
                cbOrdemParam1.Visible = true;
                toolStripLabel7.Visible = true;
                toolStrip2.Visible = true;
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

            bttnBeginPages.Visible = false;
            bttnOnePageLeft.Visible = false;
            labelTextPageFrom.Visible = false;
            toolStripLabel3.Visible = false;
            labelTextTotalPages.Visible = false;
            toolStripLabel5.Visible = false;
            labelTextTotalRegFould.Visible = false;
            bttnOnePageRight.Visible = false;
            bttnEndPages.Visible = false;

            toolStripLabel2.Visible = false;
            toolStripLabel4.Visible = false;
            cbButtnQuantPage1.Visible = false;
            toolStripLabel6.Visible = false;
            cbOrdemParam1.Visible = false;
            toolStripLabel7.Visible = false;
            toolStrip2.Visible = false;

            dataGridGastos.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);

            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            clearFieldsFormulario();
            enableFieldsFormulario();
            operationType = "newInsertion";

            txtBoxIdGastos.Enabled = false;
            carregarPadraoComboBox();
            groupBoxOculto.Visible = false;
        }
        private void behaviorDel()
        {
            //    bttnDel.Enabled = true;
            //    bttnEdit.Enabled = false;
            //    bttnSearch.Enabled = true;
            //    bttnRefresh.Enabled = true;
            //    bttnSave.Enabled = false;
            //    bttnNew.Enabled = true;
            //    controllerGastos.Excluir(Convert.ToInt32(dataGridGastos.CurrentRow.Cells[0].Value));
            //    puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");


            if (operationType == "updateData" && typeEdition == "search")
            {
                controllerGastos.Excluir(Convert.ToInt32(dataGridGastos.CurrentRow.Cells[0].Value));
                //controllerTipoUnds.Excluir(Convert.ToInt32(dataGridGastos.CurrentRow.Cells[0].Value));
                puxarparametroPesquisa();

                bttnDel.Enabled = true;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = false;
                txtBoxPesquisar.Text = "";

                int tamanho_lista = dataGridGastos.RowCount;
                MessageBox.Show(tamanho_lista.ToString());
                if (tamanho_lista == 0)
                {


                    bttnDel.Enabled = false;
                    bttnEdit.Enabled = false;
                    bttnRefresh.Enabled = false;
                    bttnSearch.Enabled = true;
                }

            }
            else if (operationType == "" || operationType == "newInsertion" || operationType == "updateData" || operationType == "search" && typeEdition == "insert")
            {
                bttnDel.Enabled = true;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;

                controllerGastos.Excluir(Convert.ToInt32(dataGridGastos.CurrentRow.Cells[0].Value));
                //controllerTipoUnds.Excluir(Convert.ToInt32(dataGridGastos.CurrentRow.Cells[0].Value));
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");


            }
            else if (operationType == "" || operationType == "newInsertion" || operationType == "updateData" || operationType == "search" && typeEdition == "search")
            {

                bttnDel.Enabled = true;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;

                controllerGastos.Excluir(Convert.ToInt32(dataGridGastos.CurrentRow.Cells[0].Value));
                //controllerTipoUnds.Excluir(Convert.ToInt32(dataGridGastos.CurrentRow.Cells[0].Value));
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");

            }
        }

        private void behaviorSave()
        {
            string retiraEspacos = txtBoxNumeroNota.Text;
            string rem = retiraEspacos.Trim();
            if (txtBoxIdGastos.Text.Trim().Equals("") || txtBoxIdGastos.Text.Trim() == null)
            {
                if (operationType.Equals("newInsertion") && typeEdition.Equals("insert"))
                {
                    if (rem.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Inserção não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            txtBoxNumeroNota.Text = "";
                            txtBoxNumeroNota.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (rem.Length >= 3)
                    {

                        controllerGastos.Salvar(
                            Convert.ToInt32(txtCodSaida.Text),
                            Convert.ToInt32(txtIdFornecedor.Text),
                            Convert.ToInt32(txtIdTipogasto.Text),
                            txtQuant.Text,
                            txtIdTipoUnit.Text,
                            txtvalorunit.Text,
                            txtValorTotal.Text,
                            txtKm.Text,
                            dtDataGasto.Value,
                            txtBoxNumeroNota.Text, 
                            "" );

                        if (controllerGastos.retornoPersistencia.Equals("NS"))
                        {
                            txtBoxNumeroNota.Focus();
                            txtBoxNumeroNota.Text = "";

                        }
                        else if (controllerGastos.retornoPersistencia.Equals("S!"))
                        {
                            operationType = "newInsertion";
                            typeEdition = "insert";
                            acoesBehaviorSave();

                        }
                        else if (controllerGastos.retornoPersistencia.Equals("S!!"))
                        {
                            //bttnNew
                            acoesBehaviorSave();

                        }
                    }
                }
            }
            else if (!txtBoxIdGastos.Text.Trim().Equals("") || txtBoxIdGastos.Text.Trim() != null)
            {

                if (operationType.Equals("updateData") && typeEdition.Equals("insert"))
                {
                    if (rem.Length <= 3)
                    {

                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            txtBoxNumeroNota.Focus();
                           
                        }
                        else if (resultado == DialogResult.No)
                        {

                            behaviorRefresh();
                        }

                    }
                    else if (rem.Length >= 3)
                    {

                        controllerGastos.Editar( 
                                                   Convert.ToInt32(txtCodSaida.Text),
                                                   Convert.ToInt32(txtIdFornecedor.Text),
                                                   Convert.ToInt32(txtIdTipogasto.Text),
                                                   txtQuant.Text,
                                                   txtIdTipoUnit.Text,
                                                   txtvalorunit.Text,
                                                   txtValorTotal.Text,
                                                   txtKm.Text,
                                                   dtDataGasto.Value,
                                                   txtBoxNumeroNota.Text,
                                                   "", 
                                                   Convert.ToInt32(txtBoxIdGastos.Text));
                        if (controllerGastos.retornoPersistencia.Equals("AT"))
                        {

                            operationType = "newInsertion";
                            typeEdition = "insert";

                            behaviorRefresh();


                        }
                    }
                }
                else if (operationType.Equals("updateData") && typeEdition.Equals("search"))
                {

                    if (rem.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            txtBoxNumeroNota.Focus();
                           
                        }
                        else if (resultado == DialogResult.No)
                        {
                            operationType = "updateData";
                            typeEdition = "search";
                            behaviorRefresh();
                        }

                    }
                    else if (rem.Length >= 3)
                    {
                        controllerGastos.Editar(
                                                  Convert.ToInt32(txtCodSaida.Text),
                                                  Convert.ToInt32(txtIdFornecedor.Text),
                                                  Convert.ToInt32(txtIdTipogasto.Text),
                                                  txtQuant.Text,
                                                  txtIdTipoUnit.Text,
                                                  txtvalorunit.Text,
                                                  txtValorTotal.Text,
                                                  txtKm.Text,
                                                  dtDataGasto.Value,
                                                  txtBoxNumeroNota.Text,
                                                  "",
                                                  Convert.ToInt32(txtBoxIdGastos.Text));
                        if (controllerGastos.retornoPersistencia.Equals("AT"))
                        {
                            behaviorRefresh();
                            puxarparametroPesquisa();

                        }
                    }
                }
            }
        }




        private void acoesBehaviorSave()
        {

            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            dataGridGastos.Visible = true;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            tabControlAssets.Visible = false;
            dataGridGastos.Visible = true;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = false;
            groupBoxFormulario.Visible = false;
            clearFieldsFormulario();
            disableFieldsFormulario();
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
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
            dataGridGastos.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxIdGastos.Enabled = false;
            setaGridEmCampos();
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
            dataGridGastos.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxIdGastos.Enabled = false;
            setaGridEmCampos();
        }

        private void behaviorSearch()
        {
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = false;
            bttnSave.Enabled = false;
            bttnNew.Enabled = false;
            tabControlAssets.Visible = true;
        }

        private void behaviorClickGrid()
        {

            bttnNew.Enabled = false;
            bttnDel.Enabled = true;
            bttnEdit.Enabled = true;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            enableFieldsFormulario();
            clearFieldsFormulario();
            setaGridEmCampos();

        }

        private void setaGridEmCampos()
        {
            //txtBoxId.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //txtBoxName.Text = dataGridGastos.CurrentRow.Cells[1].Value.ToString();

            //txtBoxId.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //txtCodSaida.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //txtIdFornecedor.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //txtIdTipogasto.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //txtQuant.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //txtIdTipoUnit.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //txtvalorunit.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //txtValorTotal.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //txtKm.Text =   dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //dtDataGasto.Value = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //txtBoxNumeroNota.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();

        }

        private void behaviorClickGridPesquisa()
        {
            bttnNew.Enabled = false;
            bttnDel.Enabled = true;
            bttnEdit.Enabled = true;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = false;
            bttnSave.Enabled = false;
            enableFieldsFormulario();
            clearFieldsFormulario();
            setaGridEmCampos();
        }




        public void clearFieldsFormulario()
        {
            txtBoxIdGastos.Text = "";
            txtCodSaida.Text = "";
            txtIdFornecedor.Text = "";
            txtIdTipogasto.Text = "";
            txtQuant.Text = "";
            txtIdTipoUnit.Text = "";
            txtvalorunit.Text = "";
            txtValorTotal.Text = "";
            txtKm.Text = "";
            dtDataGasto.Value = DateTime.Now;
            txtBoxNumeroNota.Text = "";
        }
        public void disableFieldsFormulario()
        {
            cbFornecedor.Enabled = false;
            cbTipoGasto.Enabled = false;
            cbTipoUnit.Enabled = false;
            txtBoxIdGastos.Enabled = false;
            txtCodSaida.Enabled = false;
            txtIdFornecedor.Enabled = false;
            txtIdTipogasto.Enabled = false;
            txtvalorunit.Text = "";
            txtQuant.Enabled = false;
            txtIdTipoUnit.Enabled = false;
            txtValorTotal.Enabled = false;
            txtKm.Enabled = false;
            dtDataGasto.Enabled = false;
            txtBoxNumeroNota.Enabled = false;
        }
        public void enableFieldsFormulario()
        {
            cbFornecedor.Enabled = true;
            cbTipoGasto.Enabled = true;
            cbTipoUnit.Enabled = true;
            txtBoxIdGastos.Enabled = true;
            txtCodSaida.Enabled = true;
            txtIdFornecedor.Enabled = true;
            txtIdTipogasto.Enabled = true;
            txtQuant.Enabled = true;
            txtIdTipoUnit.Enabled = true;
            txtValorTotal.Enabled = true;
            txtKm.Enabled = true;
            dtDataGasto.Enabled = true;
            txtBoxNumeroNota.Enabled = true;
        }
        public void clearFieldsPesquisar()
        {
            txtBoxPesquisar.Text = "";
            cbButtonPesquisarEm.SelectedValue = 0;
        }
        public void disableFieldsPesquisar()
        {
            cbButtonPesquisarEm.Enabled = false;
            txtBoxPesquisar.Enabled = false;
        }
        public void enableFieldsPesquisar() {
            cbButtonPesquisarEm.Enabled = true;
            txtBoxPesquisar.Enabled = true;
        }




        private void bttnSave_Click(object sender, EventArgs e)
        {
            behaviorSave();
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            behaviorNewInsert();
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {

            countBttnToggle++;
            if (countBttnToggle % 2 == 0)
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnEdit.Enabled = false;
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                actBehaviorSerarch = true;
                cbButtonPesquisarEm.SelectedIndex = 0;
                radioBttnComeca.Checked = true;
                txtBoxPesquisar.Text = "";
                bttnBeginPages.Visible = false;
                bttnOnePageLeft.Visible = false;
                labelTextPageFrom.Visible = false;
                toolStripLabel3.Visible = false;
                labelTextTotalPages.Visible = false;
                toolStripLabel5.Visible = false;
                labelTextTotalRegFould.Visible = false;
                bttnOnePageRight.Visible = false;
                bttnEndPages.Visible = false;
                toolStripLabel1.Visible = true;
                toolStripLabel2.Visible = true;
                txtBoxPesquisar.Text = "";
                txtBoxPesquisar.Focus();
                txtBoxPesquisar.Text = "";
                txtBoxPesquisar.Focus();
                radioBttnComeca.Checked = true;
                dataGridGastos.DataSource = controllerGastos.PesquisarComecaCom("nomegasto", "@nomegasto", "");
                DataGridModel();
                typeEdition = "search";
                cbButtnQuantPage1.Visible = false;
                cbOrdemParam1.Visible = false;
                cbOrdenarPor1.Visible = false;
                toolStripLabel6.Visible = false;
                toolStripLabel7.Visible = false;
                toolStripLabel4.Visible = false;
            }
            else
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnEdit.Enabled = false;
                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
                actBehaviorSerarch = false;
                bttnBeginPages.Visible = true;
                bttnOnePageLeft.Visible = true;
                labelTextPageFrom.Visible = true;
                toolStripLabel3.Visible = true;
                labelTextTotalPages.Visible = true;
                toolStripLabel5.Visible = true;
                labelTextTotalRegFould.Visible = true;
                bttnOnePageRight.Visible = true;
                bttnEndPages.Visible = true;
                toolStripLabel1.Visible = false;
                toolStripLabel2.Visible = false;
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                txtBoxIdGastos.Text = "";
                typeEdition = "insert";
                cbButtnQuantPage1.Visible = true;
                cbOrdemParam1.Visible = true;
                cbOrdenarPor1.Visible = true;
                toolStripLabel6.Visible = true;
                toolStripLabel7.Visible = true;
                toolStripLabel4.Visible = true;

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

                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;

                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                bttnSearch.Enabled = false;
            }
            else
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);

                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
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
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
            }
            else
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
            }
        }

        private void bttnOnePageRight_Click(object sender, EventArgs e)
        {
            somar();
        }

        private void bttnEndPages_Click(object sender, EventArgs e)
        {
            finalDaPagina();
        }

        private void bttnOnePageLeft_Click(object sender, EventArgs e)
        {
            descontar();
        }

        private void bttnBeginPages_Click(object sender, EventArgs e)
        {
            inicioPagina();
        }

        private void cbButtnQuantPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");

        }



        private void formCrudPessoas_Load(object sender, EventArgs e)
        {

        }

        private void bttnSave_Click_1(object sender, EventArgs e)
        {

            behaviorSave();
        }

        private void radBttnFirst_CheckedChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void radBttnLast_CheckedChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }



        private void bttnNew_Click_1(object sender, EventArgs e)
        {

            behaviorNewInsert();
        }

        private void bttnRefresh_Click_1(object sender, EventArgs e)
        {
            behaviorRefresh();
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

            var gridVazia = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia))
            {
            }


            else if (gridVazia.Length > 0)
            {
                operationType = "newInsertion";
                typeEdition = "insert";
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

        private void bttnDel_Click(object sender, EventArgs e)
        {
            behaviorDel();
        }

        private void cbButtonPesquisarEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void cbOrdemParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }



        private void cbOrdenarPor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }



        public void DataGridModel() { }

        private void cbButtonPesquisarEm_SelectedValueChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnComeca_TextChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnContem_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnTermina_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }



        private void TipoGastosView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _InstanciaGastosView = null;
        }

       
        private void gridCrudTipoGastos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var gridVazia = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia))
            {

            }
            else if (gridVazia.Length > 0)
            {
                operationType = "newInsertion";
                typeEdition = "insert";

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

   
        private void cbButtonPesquisarEm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_TextChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnComeca_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnContem_CheckedChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnTermina_CheckedChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void GastosView_Load(object sender, EventArgs e)
        {
            /*
          
        public string strIdFornecedores;
        public string strIdTipoGastos;
        public string strIdTipoUnit;*/


        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFornecedor.Items.Count > 0)
            {

                txtIdFornecedor.Text = cbFornecedor.SelectedValue.ToString();
                strIdFornecedores = txtIdFornecedor.Text;
  

            }
        }
        public void carregarPadraoComboBox() {


            cbFornecedor.DataSource = controllerFornecedores.ListarEmComboBox();
            cbFornecedor.ValueMember = "idfornecedor";
            cbFornecedor.DisplayMember = "fornecedor";
            if (cbFornecedor.Items.Count > 0)
            {
                txtIdFornecedor.Text = cbFornecedor.SelectedValue.ToString();
                strIdFornecedores = txtIdFornecedor.Text;
            }


            cbTipoGasto.DataSource = controllerTipoGastos.ListarEmComboBox();
            cbTipoGasto.ValueMember = "idtipogasto";
            cbTipoGasto.DisplayMember = "nomegasto";

            if (cbTipoGasto.Items.Count > 0)
            {
                cbTipoUnit.DataSource       =       controllerTipoGastos.ComplementoComboBoxTipoUnds(Convert.ToInt32(cbTipoGasto.SelectedValue.ToString()));
                cbTipoUnit.ValueMember      =       "idtipound";
                cbTipoUnit.DisplayMember    =       "nomeund";
               
                strIdTipoUnit = cbTipoUnit.SelectedValue.ToString();
                strTipoUnit = cbTipoUnit.Text;
                strIdTipoGastos = cbTipoGasto.SelectedValue.ToString();

                txtIdTipoUnit.Text = strIdTipoUnit;
                txtJoinTipoUnit.Text = strTipoUnit;
                txtIdTipogasto.Text = strIdTipoGastos;
                txtJoinTipoUnit.Enabled = false;
            }



        }
        private void cbTipoGasto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoGasto.Items.Count > 0  && cbTipoUnit.Items.Count > 0)
            {
                cbTipoUnit.DataSource       =   controllerTipoGastos.ComplementoComboBoxTipoUnds(Convert.ToInt32(cbTipoGasto.SelectedValue.ToString()));
                cbTipoUnit.ValueMember      =   "idtipound";
                cbTipoUnit.DisplayMember    =   "nomeund";

                strIdTipoUnit = cbTipoUnit.SelectedValue.ToString();
                strTipoUnit = cbTipoUnit.Text;
                strIdTipoGastos = cbTipoGasto.SelectedValue.ToString();

                txtIdTipoUnit.Text = strIdTipoUnit;
                txtJoinTipoUnit.Text = strTipoUnit;
                txtIdTipogasto.Text = strIdTipoGastos;

                txtJoinTipoUnit.Enabled = false;
                //txtIdTipoUnit.Text          =   cbTipoUnit.SelectedValue.ToString();
                //txtJoinTipoUnit.Text        =   cbTipoUnit.Text;
                //txtIdTipogasto.Text         =   cbTipoGasto.SelectedValue.ToString();
            }

        }

        private void GastosView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _InstanciaGastosView = null;
        }
    }

}
