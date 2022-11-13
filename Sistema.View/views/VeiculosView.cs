using Engines;
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

namespace Sistema.View
{
    public partial class VeiculosView : Form
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
        public string strVeiculo;
        public string strPlaca;

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


        private static VeiculosView _InstanciaformCrudVeiculos;
        public static VeiculosView GetInstanciaformCrudVeiculos()
        {
            if (_InstanciaformCrudVeiculos == null)
            {
                _InstanciaformCrudVeiculos = new VeiculosView();
            }
            else if (_InstanciaformCrudVeiculos != null)
            {

                MessageBox.Show("O Gerênciador de Veiculos já se encontra aberto!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return _InstanciaformCrudVeiculos;

        }

        PerfilCrud perfilCrud = new PerfilCrud();

        VeiculosController controllerVeiculos = new VeiculosController();
        public VeiculosView()
        {
            InitializeComponent();
            carregarEstadoPadrao("CarregaPadraoIDTodosUltimos", 0);
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
            perfilCrud.PermissoesCrud(bttnNew, bttnSave, bttnRefresh, bttnEdit, bttnDel, bttnSearch);



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
                    if (cbButtnQuantPage1.SelectedText == "Todos")
                    {
                    }
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
            quantidadeReg = Convert.ToInt32(controllerVeiculos.RetornoTodosRegistroBD());
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

                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Veiculo"))
                {
                    gridCrudVeiculos.DataSource = controllerVeiculos.PesquisarComecaCom("nomeveiculo", "@nomeveiculo", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerVeiculos.RetornoQuantVeiclosEncontrados());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Veiculo"))
                {
                    gridCrudVeiculos.DataSource = controllerVeiculos.PesquisarContemCom("nomeveiculo", "@nomeveiculo", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerVeiculos.RetornoQuantVeiclosEncontrados());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Veiculo"))
                {
                    gridCrudVeiculos.DataSource = controllerVeiculos.PesquisarTerminaCom("nomeveiculo", "@nomeveiculo", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerVeiculos.RetornoQuantVeiclosEncontrados());
                }

                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Placa"))
                {
                    gridCrudVeiculos.DataSource = controllerVeiculos.PesquisarComecaCom("placa", "@placa", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerVeiculos.RetornoQuantVeiclosEncontrados());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Placa"))
                {
                    gridCrudVeiculos.DataSource = controllerVeiculos.PesquisarContemCom("placa", "@placa", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerVeiculos.RetornoQuantVeiclosEncontrados());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Placa"))
                {
                    gridCrudVeiculos.DataSource = controllerVeiculos.PesquisarTerminaCom("Placa", "@placa", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerVeiculos.RetornoQuantVeiclosEncontrados());//nomepessoa
                }
             
            }
        }

        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {

            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudVeiculos.DataSource = controllerVeiculos.ListarDataGrid("idveiculo", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerVeiculos.RetornoTodosRegistroBD());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudVeiculos.DataSource = controllerVeiculos.ListarDataGrid("idveiculo", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerVeiculos.RetornoTodosRegistroBD());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudVeiculos.DataSource = controllerVeiculos.ListarDataGrid("nomeveiculo", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerVeiculos.RetornoTodosRegistroBD());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudVeiculos.DataSource = controllerVeiculos.ListarDataGrid("nomeveiculo", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerVeiculos.RetornoTodosRegistroBD());
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
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
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
        }
        private void bttnSearch_Click_1(object sender, EventArgs e)
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
                gridCrudVeiculos.DataSource = controllerVeiculos.PesquisarComecaCom("nomeveiculo", "@nomeveiculo", "");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerVeiculos.RetornoQuantVeiclosEncontrados());
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
                strVeiculo = "";
                txtBoxId.Text = "";
                typeEdition = "insert";
                cbButtnQuantPage1.Visible = true;
                cbOrdemParam1.Visible = true;
                cbOrdenarPor1.Visible = true;
                toolStripLabel6.Visible = true;
                toolStripLabel7.Visible = true;
                toolStripLabel4.Visible = true;

            }
        }

        private void DataGridModel()
        {
            gridCrudVeiculos.Columns[0].HeaderText = "ID";
            gridCrudVeiculos.Columns[1].HeaderText = "Veiculo";
            gridCrudVeiculos.Columns[2].HeaderText = "Placa";
            gridCrudVeiculos.Columns[3].HeaderText = "Estatus";
            gridCrudVeiculos.Columns[0].Width = 80;
            gridCrudVeiculos.Columns[1].Width = 200;
            gridCrudVeiculos.Columns[2].Width = 150;
            gridCrudVeiculos.Columns[3].Width = 200;
       //     gridCrudVeiculos.Columns[3].Visible = false;

        }


        private void behaviorRefresh()
        {
            if (operationType == "updateData" && typeEdition == "search")
            {
                gridCrudVeiculos.Visible = true;
                tabControlAssets.Visible = true;
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
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;
                radioBttnComeca.Checked = false;
                radioBttnContem.Checked = false;
                radioBttnTermina.Checked = false;
                gridCrudVeiculos.Visible = true;
                   tabControlAssets.Visible = false;
                    tabControlAssets.TabPages.Remove(tabPagePesquisar);

                clearFieldsFormulario();
     
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                gridCrudVeiculos.ClearSelection();
            }
            else if (operationType == "" || operationType == "newInsertion" || operationType == "updateData" || operationType == "search" && typeEdition == "search")
            {
                bttnDel.Enabled = false;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
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
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;
                radioBttnComeca.Checked = false;
                radioBttnContem.Checked = false;
                radioBttnTermina.Checked = false;
                gridCrudVeiculos.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                clearFieldsFormulario();

                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                gridCrudVeiculos.ClearSelection();
            

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
            txtBoxId.Text = "";

            formEditVeiculos frmEdVeiculos = new formEditVeiculos();
             strVeiculo = "";
             strPlaca = "";
             frmEdVeiculos.VeiculoVO = strVeiculo;
             frmEdVeiculos.PlacaVO = strPlaca;
             frmEdVeiculos.ShowDialog();

            if ("sair".Equals(frmEdVeiculos.AcaoDialogVO))
            {
                txtBoxId.Text = "";
                strVeiculo = "";
                strPlaca = "";
                behaviorRefresh();
            }

            else if ("ok".Equals(frmEdVeiculos.AcaoDialogVO))
            {
                strVeiculo = frmEdVeiculos.VeiculoVO;
                strPlaca = frmEdVeiculos.PlacaVO;
                behaviorSave();
            }
        }

        private void behaviorDel()
        {
            if (operationType == "updateData" && typeEdition == "search")
            {

                controllerVeiculos.Excluir(Convert.ToInt32(gridCrudVeiculos.CurrentRow.Cells[0].Value));

                if ("DEL".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                {
                    bttnDel.Enabled = true;
                    bttnEdit.Enabled = false;
                    bttnSearch.Enabled = true;
                    bttnRefresh.Enabled = true;
                    bttnSave.Enabled = false;
                    bttnNew.Enabled = false;
                    puxarparametroPesquisa();
                    int tamanho_lista = gridCrudVeiculos.RowCount;

                    if (tamanho_lista == 0)
                    {
                        bttnDel.Enabled = false;
                        bttnEdit.Enabled = false;
                        bttnRefresh.Enabled = false;
                        bttnSearch.Enabled = true;
                        puxarparametroPesquisa();
                    }

                }
                else if ("NDEL".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                {

                }
            }
            else if (operationType == "" || operationType == "newInsertion" || operationType == "updateData" || operationType == "search" && typeEdition == "insert")
            {

                controllerVeiculos.Excluir(Convert.ToInt32(gridCrudVeiculos.CurrentRow.Cells[0].Value));


                if ("DEL".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                {
                    bttnDel.Enabled = true;
                    bttnEdit.Enabled = false;
                    bttnSearch.Enabled = true;
                    bttnRefresh.Enabled = true;
                    bttnSave.Enabled = false;
                    bttnNew.Enabled = true;

                    puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                    clearFieldsFormulario();

                }
                else if ("NDEL".Equals(controllerVeiculos.AcaoCrudVeiculosController())) { }

            }
            else if (operationType == "" || operationType == "newInsertion" || operationType == "updateData" || operationType == "search" && typeEdition == "search")
            {

                controllerVeiculos.Excluir(Convert.ToInt32(gridCrudVeiculos.CurrentRow.Cells[0].Value));

                if ("DEL".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                {
                    bttnDel.Enabled = true;
                    bttnEdit.Enabled = false;
                    bttnSearch.Enabled = true;
                    bttnRefresh.Enabled = true;
                    bttnSave.Enabled = false;
                    bttnNew.Enabled = true;
                    puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                    clearFieldsFormulario();

                }
                else if ("NDEL".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                {

                }
                //    bttnDel.Enabled = true;
                //    bttnEdit.Enabled = false;
                //    bttnSearch.Enabled = true;
                //    bttnRefresh.Enabled = true;
                //    bttnSave.Enabled = false;
                //    bttnNew.Enabled = true;
                //    controllerVeiculos.Excluir(Convert.ToInt32(gridCrudVeiculos.CurrentRow.Cells[0].Value));

                //    if ("DEL".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                //    {
                //        MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                //        behaviorRefresh();
                //    }
                //    else if ("NDEL".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                //    {
                //        MessageBox.Show("Exclusão Cancelada", "Registro Não Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                //        behaviorRefresh();
                    }
            }

        private void behaviorSave()
        {
            string retiraEspacos = strVeiculo;
            string remVeiculo = retiraEspacos.Trim();

            string retiraEspacosId = txtBoxId.Text;
            string remEspacosId = retiraEspacosId.Trim();

            if (remEspacosId.Equals("") || remEspacosId == null)
            {
                if (operationType.Equals("newInsertion") && typeEdition.Equals("insert"))
                {
                    if (remVeiculo.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Inserção não alcançou o número mínimo de 3 caracteres.\n" +
                        "Para tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.",
                        "Aviso do Sistema",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            strVeiculo = "";
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (remVeiculo.Length >= 3)
                    {
                        controllerVeiculos.Salvar(strVeiculo, strPlaca,"");
                        if ("NS".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                        {
                            strVeiculo = "";
                            behaviorRefresh();
                        }
                        else if ("S!".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                        {
                            operationType = "newInsertion";
                            typeEdition = "insert";
                            behaviorRefresh();
                            MessageBox.Show("Registro Salvo Com Sucesso!", "Aviso de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if ("S!!".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                        {
                            operationType = "newInsertion";
                            typeEdition = "insert";
                            behaviorRefresh();
                            MessageBox.Show("Dado Existente Salvo!", "Aviso de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if ("NS".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                    {
                        operationType = "newInsertion";
                        typeEdition = "insert";
                        behaviorRefresh();
                    }
                }
            }
            else if (!remEspacosId.Equals("") || remEspacosId != null)
            {
                if (operationType.Equals("updateData") && typeEdition.Equals("insert"))
                {
                    if (remVeiculo.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            strVeiculo = "";
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (remVeiculo.Length >= 3)
                    {

                        controllerVeiculos.Editar(Convert.ToInt32(txtBoxId.Text), strVeiculo, strPlaca,"");
                        if ("AT".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                        {
                            behaviorRefresh();
                        }
                    }
                    if ("NS".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                    {
                        behaviorRefresh();
                    }
                }
                else if (operationType.Equals("updateData") && typeEdition.Equals("search"))
                {

                    if (remVeiculo.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            strVeiculo = "";
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (remVeiculo.Length >= 3)
                    {
                        controllerVeiculos.Editar(Convert.ToInt32(txtBoxId.Text), strVeiculo, strPlaca,"");
                       
                        if ("AT".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                        {
                            behaviorRefresh();
                            puxarparametroPesquisa();
                          
                        }
                    }
                    if ("NS".Equals(controllerVeiculos.AcaoCrudVeiculosController()))
                    {
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
            txtBoxId.Text = gridCrudVeiculos.CurrentRow.Cells[0].Value.ToString();
            strVeiculo = gridCrudVeiculos.CurrentRow.Cells[1].Value.ToString();

            formEditVeiculos frmEdVeiculos = new formEditVeiculos();
            frmEdVeiculos.VeiculoVO = strVeiculo;
            frmEdVeiculos.PlacaVO = strPlaca;
            frmEdVeiculos.ShowDialog();

            if ("sair".Equals(frmEdVeiculos.AcaoDialogVO))
            {
                bttnRefresh.Enabled = false;
                strVeiculo = "";
                strPlaca = "";
                behaviorRefresh();
            }

            else if ("ok".Equals(frmEdVeiculos.AcaoDialogVO))
            {
                strVeiculo  =  frmEdVeiculos.VeiculoVO ;
                strPlaca = frmEdVeiculos.PlacaVO ;
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
            txtBoxId.Text = gridCrudVeiculos.CurrentRow.Cells[0].Value.ToString();
            strVeiculo = gridCrudVeiculos.CurrentRow.Cells[1].Value.ToString();

            formEditVeiculos frmEdVeiculos = new formEditVeiculos();


            frmEdVeiculos.VeiculoVO = strVeiculo;
            frmEdVeiculos.PlacaVO = strPlaca;
            frmEdVeiculos.ShowDialog();

            if ("sair".Equals(frmEdVeiculos.AcaoDialogVO))
            {
                bttnRefresh.Enabled = false;
                strVeiculo = "";
                strPlaca = "";
                strPlaca = "";
                bttnRefresh.Enabled = false;
                behaviorRefresh();
            }

            else if ("ok".Equals(frmEdVeiculos.AcaoDialogVO))
            {
                strVeiculo = frmEdVeiculos.VeiculoVO;
                strPlaca = frmEdVeiculos.PlacaVO;
                bttnRefresh.Enabled = false;
                behaviorSave();
            }
        }


        private void behaviorClickGrid() {
            txtBoxId.Text = gridCrudVeiculos.CurrentRow.Cells[0].Value.ToString();
            strVeiculo = gridCrudVeiculos.CurrentRow.Cells[1].Value.ToString();
            strPlaca = gridCrudVeiculos.CurrentRow.Cells[2].Value.ToString();

            bttnNew.Enabled = false;
            bttnDel.Enabled = true;
            bttnEdit.Enabled = true;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            clearFieldsFormulario();
            txtBoxId.Text = gridCrudVeiculos.CurrentRow.Cells[0].Value.ToString();
            strVeiculo = gridCrudVeiculos.CurrentRow.Cells[1].Value.ToString();


        }
        private void behaviorClickGridPesquisa()
        {


            txtBoxId.Text = gridCrudVeiculos.CurrentRow.Cells[0].Value.ToString();
            strVeiculo = gridCrudVeiculos.CurrentRow.Cells[1].Value.ToString();
            strPlaca = gridCrudVeiculos.CurrentRow.Cells[2].Value.ToString();

            bttnNew.Enabled = false;
            bttnDel.Enabled = true;
            bttnEdit.Enabled = true;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = false;
            bttnSave.Enabled = false;
       

        }
        public void clearFieldsFormulario() { txtBoxId.Text = ""; strVeiculo = ""; }
        public void clearFieldsPesquisar() { txtBoxPesquisar.Text = ""; cbButtonPesquisarEm.SelectedValue = 0; }
        public void disableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }
        public void enableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }




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

        private void cbButtnQuantPage1_SelectedIndexChanged(object sender, EventArgs e){
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

        private void radBttnLast_CheckedChanged(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }



        private void bttnNew_Click_1(object sender, EventArgs e) {

            behaviorNewInsert();
        }

        private void bttnRefresh_Click_1(object sender, EventArgs e){
            behaviorRefresh();
        }

        private void radioBttnContem_CheckedChanged(object sender, EventArgs e) {
            puxarparametroPesquisa();
        }

        private void radioBttnTermina_CheckedChanged(object sender, EventArgs e){
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
            if (perfilCrud.PermissaoUpdate() == true)
            {
                if ("Em Rota".Equals(gridCrudVeiculos.CurrentRow.Cells[3].Value.ToString()))
                {
                }
                else if (gridCrudVeiculos.CurrentRow.Cells[3].Value.ToString().Equals("Disponivel") ||
                         gridCrudVeiculos.CurrentRow.Cells[3].Value.ToString().Equals(""))
                {


                    var gridVazia = gridCrudVeiculos.CurrentRow.Cells[0].Value.ToString();
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
            }
            else { MessageBox.Show("Este perfil não possui autorização para Editar"); }

        }

        private void gridCrudPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridVazia = gridCrudVeiculos.CurrentRow.Cells[0].Value.ToString();
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

        private void button2_Click_1(object sender, EventArgs e)
        {

            countBttnToggle++;
            if (countBttnToggle % 2 == 0)
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);

                bttnSearch.Enabled = false;
                bttnEdit.Enabled = false;
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                actBehaviorSerarch = true;
                cbButtonPesquisarEm.SelectedIndex = 0;
                radioBttnComeca.Checked = true;
                txtBoxPesquisar.Text = "";

                // bttnTools.Enabled = false;
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
                gridCrudVeiculos.DataSource = controllerVeiculos.PesquisarComecaCom("nomeveiculo", "@nomeveiculo", "");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerVeiculos.RetornoQuantVeiclosEncontrados());
                operationType = "search";


            }
            else
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnEdit.Enabled = false;
                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
                actBehaviorSerarch = false;
                bttnSearch.Enabled = true;
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
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                typeEdition = "insert";
                operationType = "newInsertion";
            }
        }

        private void bttnDel_Click(object sender, EventArgs e)
        {
            behaviorDel();
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

        private void cbOrdemParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }


        private void radBttnLast_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void radBttnFirst_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbButtnQuantPage1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

    


        private void cbOrdemParam1_Click(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbOrdenarPor_Click(object sender, EventArgs e)
        {

            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbButtnQuantPage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbButtnQuantPage1_Click(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbOrdenarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbOrdemParam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbButtnQuantPage1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void bttnOnePageRight_Click_1(object sender, EventArgs e)
        {
            somar();
        }

        private void bttnEndPages_Click_1(object sender, EventArgs e)
        {
            finalDaPagina();
        }

        private void bttnOnePageLeft_Click_1(object sender, EventArgs e)
        {
            descontar();
        }

        private void bttnBeginPages_Click_1(object sender, EventArgs e)
        {

            inicioPagina();
        }

        private void cbOrdenarPor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbButtnQuantPage1_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void txtBoxPesquisar_TextChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void cbButtonPesquisarEm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnComeca_CheckedChanged_2(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void radioBttnContem_CheckedChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnTermina_CheckedChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

    

      

        private void gridCrudVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (perfilCrud.PermissaoUpdate() == true)
            {
                if ("Em Rota".Equals(gridCrudVeiculos.CurrentRow.Cells[3].Value.ToString())) {
                
                MessageBox.Show("Não é possível editar veículos que estão em rota");

            } else if (gridCrudVeiculos.CurrentRow.Cells[3].Value.ToString().Equals("Disponivel") ||
                       gridCrudVeiculos.CurrentRow.Cells[3].Value.ToString().Equals("")) {

                var gridVazia = gridCrudVeiculos.CurrentRow.Cells[0].Value.ToString();
                if (string.IsNullOrEmpty(gridVazia)) {

                } else if (gridVazia.Length > 0) {
                    if (typeEdition.Equals("insert")) {
                        operationType = "newInsertion";
                        behaviorClickGrid();

                    } else if (typeEdition.Equals("search")) {
                        operationType = "updateData";
                        behaviorClickGridPesquisa();
                    }
                }
              }
            }else { MessageBox.Show("Este perfil não possui autorização para Editar"); }
        }

        private void bttnRefresh_Click_2(object sender, EventArgs e)
        {
            behaviorRefresh();
        }

      

        private void formCrudVeiculos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _InstanciaformCrudVeiculos = null;
        }

        private void bttnSave_Click_2(object sender, EventArgs e)
        {

        }

        private void VeiculosView_Load(object sender, EventArgs e)
        {

        }

        private void gridCrudVeiculos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (perfilCrud.PermissaoUpdate() == true)
            {
                if ("Em Rota".Equals(gridCrudVeiculos.CurrentRow.Cells[3].Value.ToString()))
                {
                }
                else if (gridCrudVeiculos.CurrentRow.Cells[3].Value.ToString().Equals("Disponivel") ||
                         gridCrudVeiculos.CurrentRow.Cells[3].Value.ToString().Equals(""))
                {


                    var gridVazia = gridCrudVeiculos.CurrentRow.Cells[0].Value.ToString();
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
            }
            else { MessageBox.Show("Este perfil não possui autorização para Editar"); }
        }
    }

}
