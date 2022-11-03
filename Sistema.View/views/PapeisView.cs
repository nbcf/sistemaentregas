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
    public partial class PapeisView : Form
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
        public bool bolCriar = false;
        public bool bolRecuperar = false;
        public bool bolEditar = false;
        public bool bolExcluir = false;
        public bool bolMenuOp = false;
        public bool bolMenuAdmin = false;
        public bool bolMenuGen = false;
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


        private static PapeisView _InstanciaformCrudPapeis;
        public static PapeisView GetInstanciaformCrudPapeis()
        {
            if (_InstanciaformCrudPapeis == null)
            {
                _InstanciaformCrudPapeis = new PapeisView();
            }
            else if (_InstanciaformCrudPapeis != null)
            {

                MessageBox.Show("Janela já se encontra aberta!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return _InstanciaformCrudPapeis;
           
        }

        PapeisController controllerPapeis = new PapeisController();

        public PapeisView()
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
                    { }
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
            quantidadeReg = Convert.ToInt32(controllerPapeis.ListarBDPapeisControlller());
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

                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudPapeis.DataSource = controllerPapeis.PesquisarComecaCom("nomepapel", "@nomepapel", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudPapeis.DataSource = controllerPapeis.PesquisarContemCom("nomepapel", "@nomepapel", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudPapeis.DataSource = controllerPapeis.PesquisarTerminaCom("nomepapel", "@nomepapel", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
                }
            }
        }

        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {

            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudPapeis.DataSource = controllerPapeis.ConfiListagemDataGrid("idpapel", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerPapeis.ListarBDPapeisControlller());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudPapeis.DataSource = controllerPapeis.ConfiListagemDataGrid("idpapel", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerPapeis.ListarBDPapeisControlller());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudPapeis.DataSource = controllerPapeis.ConfiListagemDataGrid("nomepapel", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerPapeis.ListarBDPapeisControlller());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudPapeis.DataSource = controllerPapeis.ConfiListagemDataGrid("nomepapel", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerPapeis.ListarBDPapeisControlller());
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
            txtBoxId.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
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
                gridCrudPapeis.DataSource = controllerPapeis.PesquisarComecaCom("nomepapel", "@nomepapel", "");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
                typeEdition = "search";
                cbButtnQuantPage1.Visible = false;
                cbOrdemParam1.Visible = false;
                cbOrdenarPor1.Visible = false;
                toolStripLabel6.Visible = false;
                toolStripLabel7.Visible = false;
                toolStripLabel8.Visible = false;
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
                stringPapel = "";
                txtBoxId.Text = "";
                typeEdition = "insert";
                cbButtnQuantPage1.Visible = true;
                cbOrdemParam1.Visible = true;
                cbOrdenarPor1.Visible = true;
                toolStripLabel6.Visible = true;
                toolStripLabel7.Visible = true;
                toolStripLabel8.Visible = true;

            }
        }

        private void DataGridModel()
        {
            gridCrudPapeis.Columns[0].HeaderText = "ID";
            gridCrudPapeis.Columns[1].HeaderText = "Função";
            gridCrudPapeis.Columns[2].HeaderText = "Criar";
            gridCrudPapeis.Columns[3].HeaderText = "Recuperar";
            gridCrudPapeis.Columns[4].HeaderText = "Atualizar";
            gridCrudPapeis.Columns[5].HeaderText = "Excluir";
            gridCrudPapeis.Columns[6].HeaderText = "Operacional";
            gridCrudPapeis.Columns[7].HeaderText = "Administrativo";
            gridCrudPapeis.Columns[8].HeaderText = "Gerencial";
            gridCrudPapeis.Columns[0].Width = 100;
            gridCrudPapeis.Columns[1].Width = 200;
            gridCrudPapeis.Columns[2].Width = 130;
            gridCrudPapeis.Columns[3].Width = 130;
            gridCrudPapeis.Columns[4].Width = 130;
            gridCrudPapeis.Columns[5].Width = 130;
            gridCrudPapeis.Columns[6].Width = 130;
            gridCrudPapeis.Columns[7].Width = 130;
            gridCrudPapeis.Columns[8].Width = 130;
            gridCrudPapeis.Columns[2].Visible = false;
            gridCrudPapeis.Columns[3].Visible = false;
            gridCrudPapeis.Columns[4].Visible = false;
            gridCrudPapeis.Columns[5].Visible = false;
            gridCrudPapeis.Columns[6].Visible = false;
            gridCrudPapeis.Columns[7].Visible = false;
            gridCrudPapeis.Columns[8].Visible = false;

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
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                gridCrudPapeis.ClearSelection();

            } else if (operationType == "" ||
                    operationType == "newInsertion" ||
                    operationType == "updateData" ||
                    operationType == "search" && typeEdition == "search"){

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
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                gridCrudPapeis.ClearSelection();
            }
        }
        private void behaviorNewInsert(){
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = false;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = true;
            bttnNew.Enabled = false;

            operationType = "newInsertion";
            txtBoxId.Enabled = false;
            formEditPapel frmEditPapel = new formEditPapel();
            stringPapel = "";
            bolCriar = false;
            bolRecuperar = false;
            bolEditar = false;
            bolExcluir = false;
            bolMenuOp = false;
            bolMenuAdmin = false;
            bolMenuGen = false;
            frmEditPapel.PapelVO = stringPapel;
            frmEditPapel.CriarVO = bolCriar;
            frmEditPapel.RecuperarVO = bolRecuperar;
            frmEditPapel.AtualizarVO = bolEditar;
            frmEditPapel.DeletarVO = bolExcluir;
            frmEditPapel.MenuOpVO = bolMenuOp;
            frmEditPapel.MenuAdminVO = bolMenuAdmin;
            frmEditPapel.MenuGenVO = bolMenuGen;
            frmEditPapel.ShowDialog();


            if (frmEditPapel.AcaoDialogVO.Equals("sair")){
                stringPapel = "";
                txtBoxId.Text = "";
                bolCriar = false;
                bolRecuperar = false;
                bolEditar = false;
                bolExcluir = false;
                bolMenuOp = false;
                bolMenuAdmin = false;
                bolMenuGen = false;
                behaviorRefresh();

            }

            if (frmEditPapel.AcaoDialogVO.Equals("ok")){
                stringPapel = frmEditPapel.PapelVO;
                bolCriar = frmEditPapel.CriarVO;
                bolRecuperar = frmEditPapel.RecuperarVO;
                bolEditar = frmEditPapel.AtualizarVO;
                bolExcluir = frmEditPapel.DeletarVO;
                bolMenuOp = frmEditPapel.MenuOpVO;
                bolMenuAdmin = frmEditPapel.MenuAdminVO;
                bolMenuGen = frmEditPapel.MenuGenVO;
                behaviorSave();
            }
        }





        private void behaviorDel()
        {
            bttnDel.Enabled = true;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            controllerPapeis.Excluir(Convert.ToInt32(gridCrudPapeis.CurrentRow.Cells[0].Value), Convert.ToString(gridCrudPapeis.CurrentRow.Cells[1].Value));
            if ("DEL".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
            {
                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                behaviorRefresh();
            }
            else if ("NDEL".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
            {
                MessageBox.Show("Exclusão Cancelada", "Registro Não Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                behaviorRefresh();
            }
        }






        private void behaviorSave()
        {
            string retiraEspacos = stringPapel;
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

                            stringPapel = "";
                        }
                        else if (resultado == DialogResult.No)
                        {

                            behaviorRefresh();
                        }
                    }
                    else if (remPapel.Length >= 3)
                    {
                        controllerPapeis.Salvar(stringPapel, bolCriar, bolRecuperar, bolEditar, bolExcluir, bolMenuOp, bolMenuAdmin, bolMenuGen);
                        if ("NS".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
                        {

                            stringPapel = "";
                            behaviorRefresh();
                        }
                        else if ("S!".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
                        {

                            operationType = "newInsertion";
                            typeEdition = "insert";

                            behaviorRefresh();
                            MessageBox.Show("Registro Salvo Com Sucesso!", "Aviso de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if ("S!!".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
                        {

                            operationType = "newInsertion";
                            typeEdition = "insert";

                            behaviorRefresh();
                            MessageBox.Show("Dado Existente Salvo!", "Aviso de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if ("NS".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
                    {

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
                        controllerPapeis.Editar(stringPapel, bolCriar, bolRecuperar, bolEditar, bolExcluir, bolMenuOp, bolMenuAdmin, bolMenuGen, Convert.ToInt32(txtBoxId.Text));//  controllerPapeis.Editar(Convert.ToInt32(txtBoxId.Text), stringPapel, bolCriar, bolRecuperar, bolEditar, bolExcluir, bolMenuOp, bolMenuAdmin, bolMenuGen);

                        if ("AT".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
                        {

                            behaviorRefresh();

                        }
                    }
                    if ("NS".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
                    {

                        behaviorRefresh();
                    }
                }
                else if (operationType.Equals("updateData") && typeEdition.Equals("search"))
                {
                    /* else if (operationType.Equals("updateData") && typeEdition.Equals("search"))
//                {
//                    if (remPapel.Length <= 1)
//                    {
//                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//                        if (resultado == DialogResult.Yes)
//                        {
//                            stringPapel = "";

//                        }
//                        else if (resultado == DialogResult.No)
//                        {
//                            behaviorRefresh();
//                        }

//                    }
//                    else if (remPapel.Length >= 1)
//                    {
//                        controllerPapeis.Editar( stringPapel, bolCriar, bolRecuperar, bolEditar, bolExcluir, bolMenuOp, bolMenuAdmin, bolMenuGen, Convert.ToInt32(txtBoxId.Text));

//                        if ("AT".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
//                        {
//                            behaviorRefresh();
//                            puxarparametroPesquisa();

                           

//                        }
//                    }*/

                    MessageBox.Show("8!");
                    if (remPapel.Length <= 1)
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
                    else if (remPapel.Length >= 1)
                    {
                        controllerPapeis.Editar(stringPapel, bolCriar, bolRecuperar, bolEditar, bolExcluir, bolMenuOp, bolMenuAdmin, bolMenuGen, Convert.ToInt32(txtBoxId.Text));
                        if ("AT".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
                        {
                            MessageBox.Show("Salvou?");
                            behaviorRefresh();
                            puxarparametroPesquisa();
                           
                        }
                    }
                    if ("NS".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
                    {
                        behaviorRefresh();
                    }
                }
            }
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

        private void cbButtnQuantPage1_SelectedIndexChanged(object sender, EventArgs e)
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            txtBoxPesquisar.Text = "";
            gridCrudPapeis.DataSource = controllerPapeis.PesquisarComecaCom("nomepapel", "@nomepapel", "");
            DataGridModel();
            toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
            operationType = "search";

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
            editarRegistro();
        }

        private void gridCrudPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridVazia = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
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
                    //behaviorClickGridPesquisa();
                    behaviorClickGrid();

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
                gridCrudPapeis.DataSource = controllerPapeis.PesquisarComecaCom("nomepapel", "@nomepapel", "");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
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
                //  bttnTools.Enabled = true;

                toolStripLabel1.Visible = false;
                toolStripLabel2.Visible = false;


                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                typeEdition = "insert";
                operationType = "newInsertion";


            }
        }

        private void bttnDel_Click(object sender, EventArgs e){
            behaviorDel();
        }


        private void radioBttnTermina_CheckedChanged_1(object sender, EventArgs e){
            puxarparametroPesquisa();
        }

        private void radioBttnComeca_CheckedChanged_1(object sender, EventArgs e){
            puxarparametroPesquisa();
        }

        private void radioBttnContem_CheckedChanged_1(object sender, EventArgs e){
            puxarparametroPesquisa();
        }

        private void cbButtonPesquisarEm_SelectedIndexChanged(object sender, EventArgs e) {
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_TextChanged_1(object sender, EventArgs e){
            puxarparametroPesquisa();
        }

        private void cbOrdemParam_SelectedIndexChanged(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }


        private void radBttnLast_CheckedChanged_1(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void radBttnFirst_CheckedChanged_1(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbButtnQuantPage1_SelectedIndexChanged_1(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }



        private void gridCrudPapeis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridVazia = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
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
                    behaviorClickGrid();
                }
            }

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

        private void formCrudPapeis_FormClosed(object sender, FormClosedEventArgs e)
        {
            _InstanciaformCrudPapeis = null;
        }

        private void formCrudPapeis_Load(object sender, EventArgs e)
        {
            //funciona inicializacao maximizada
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void formCrudPapeis_FormClosing(object sender, FormClosingEventArgs e)
        {
            _InstanciaformCrudPapeis = null;
        }

        private void gridCrudPapeis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editarRegistro();
        }


        public void editarRegistro()
        {
            var gridVazia = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
            
            if (string.IsNullOrEmpty(gridVazia)){ }

            else if (gridVazia.Length > 0){

                if (typeEdition.Equals("insert") && operationType.Equals("newInsertion")){
                    operationType = "newInsertion";
                    typeEdition = "insert";
                    bttnDel.Enabled = false;
                    bttnEdit.Enabled = false;
                    bttnSearch.Enabled = false;
                    bttnRefresh.Enabled = true;
                    bttnSave.Enabled = true;
                    bttnNew.Enabled = false;
                    clearFieldsFormulario();
                    txtBoxId.Enabled = false;
                    txtBoxId.Text = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
                    stringPapel = gridCrudPapeis.CurrentRow.Cells[1].Value.ToString();

                    formEditPapel frmEditPapel = new formEditPapel();

                    frmEditPapel.PapelVO = stringPapel;
                    frmEditPapel.CriarVO = bolCriar;
                    frmEditPapel.RecuperarVO = bolRecuperar;
                    frmEditPapel.AtualizarVO = bolRecuperar;
                    frmEditPapel.DeletarVO = bolExcluir;
                    frmEditPapel.MenuOpVO = bolMenuOp;
                    frmEditPapel.MenuAdminVO = bolMenuAdmin;
                    frmEditPapel.MenuGenVO = bolMenuGen;
                    frmEditPapel.ShowDialog();
                  
                    if (frmEditPapel.AcaoDialogVO.Equals("sair"))
                    {
                        stringPapel = "";
                        bolCriar = false;
                        bolRecuperar = false;
                        bolEditar = false;
                        bolEditar = false;
                        bolMenuOp = false;
                        bolMenuAdmin = false;
                        bolMenuGen = false;
                        bttnRefresh.Enabled = false;
                        behaviorRefresh();
                    }

                    else if (frmEditPapel.AcaoDialogVO.Equals("ok"))
                    {

                        stringPapel = frmEditPapel.PapelVO;
                        bolCriar = frmEditPapel.CriarVO;
                        bolRecuperar = frmEditPapel.RecuperarVO;
                        bolEditar = frmEditPapel.AtualizarVO;
                        bolExcluir = frmEditPapel.DeletarVO;
                        bolMenuOp = frmEditPapel.MenuOpVO;
                        bolMenuAdmin = frmEditPapel.MenuAdminVO;
                        bolMenuGen = frmEditPapel.MenuGenVO;
                        bttnRefresh.Enabled = false;
                        behaviorSave();

                    }

                }
                else if (typeEdition.Equals("search") && operationType.Equals("updateData"))
                {
                    operationType = "updateData";
                    typeEdition = "search";
                    bttnDel.Enabled = false;
                    bttnEdit.Enabled = false;
                    bttnSearch.Enabled = false;
                    bttnRefresh.Enabled = true;
                    bttnSave.Enabled = true;
                    bttnNew.Enabled = false;
                    clearFieldsFormulario();
                    txtBoxId.Enabled = false;
                    txtBoxId.Text = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
                    stringPapel = gridCrudPapeis.CurrentRow.Cells[1].Value.ToString();


                    formEditPapel frmEditPapel = new formEditPapel();

                    frmEditPapel.PapelVO = stringPapel;
                    frmEditPapel.CriarVO = bolCriar;
                    frmEditPapel.RecuperarVO = bolRecuperar;
                    frmEditPapel.AtualizarVO = bolRecuperar;
                    frmEditPapel.DeletarVO = bolExcluir;
                    frmEditPapel.MenuOpVO = bolMenuOp;
                    frmEditPapel.MenuAdminVO = bolMenuAdmin;
                    frmEditPapel.MenuGenVO = bolMenuGen;
                    frmEditPapel.ShowDialog();

                    if (frmEditPapel.AcaoDialogVO.Equals("sair"))
                    {
                        stringPapel = "";
                        bolCriar = false;
                        bolRecuperar = false;
                        bolEditar = false;
                        bolEditar = false;
                        bolMenuOp = false;
                        bolMenuAdmin = false;
                        bolMenuGen = false;
                        bttnRefresh.Enabled = false;
                        behaviorRefresh();
                    }

                    else if (frmEditPapel.AcaoDialogVO.Equals("ok"))
                    {

                        stringPapel = frmEditPapel.PapelVO;
                        bolCriar = frmEditPapel.CriarVO;
                        bolRecuperar = frmEditPapel.RecuperarVO;
                        bolEditar = frmEditPapel.AtualizarVO;
                        bolExcluir = frmEditPapel.DeletarVO;
                        bolMenuOp = frmEditPapel.MenuOpVO;
                        bolMenuAdmin = frmEditPapel.MenuAdminVO;
                        bolMenuGen = frmEditPapel.MenuGenVO;
                        bttnRefresh.Enabled = false;
                        behaviorSave();

                    }
                }
            }
        }

        private void behaviorClickGrid()
        {
            bolCriar = "1".Equals(gridCrudPapeis.CurrentRow.Cells[2].Value.ToString()) ? true : false;
            bolRecuperar = "1".Equals(gridCrudPapeis.CurrentRow.Cells[3].Value.ToString()) ? true : false;
            bolEditar = "1".Equals(gridCrudPapeis.CurrentRow.Cells[4].Value.ToString()) ? true : false;
            bolExcluir = "1".Equals(gridCrudPapeis.CurrentRow.Cells[5].Value.ToString()) ? true : false;
            bolMenuOp = "1".Equals(gridCrudPapeis.CurrentRow.Cells[6].Value.ToString()) ? true : false;
            bolMenuAdmin = "1".Equals(gridCrudPapeis.CurrentRow.Cells[7].Value.ToString()) ? true : false;
            bolMenuGen = "1".Equals(gridCrudPapeis.CurrentRow.Cells[8].Value.ToString()) ? true : false;

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
            txtBoxId.Text = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
            stringPapel = gridCrudPapeis.CurrentRow.Cells[1].Value.ToString();


        }


        public void clearFieldsFormulario() { txtBoxId.Text = ""; stringPapel = ""; }
        public void clearFieldsPesquisar() { txtBoxPesquisar.Text = ""; cbButtonPesquisarEm.SelectedValue = 0; }
        public void disableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }
        public void enableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }





    }

}

//        private void puxarparametro(int deslocamento, int limiteregistro, string inicioDeslocamento)
//        {
//            string jcbOrdem = Convert.ToString(cbOrdemParam1.SelectedItem);
//            string ordem = "";
//            if (Convert.ToString(cbOrdenarPor1.SelectedItem).Equals("Primeiros"))
//            {
//                ordem = "primeiros";
//            }
//            else if (Convert.ToString(cbOrdenarPor1.SelectedItem).Equals("Ultimos"))
//            {
//                ordem = "ultimos";
//            }

//            if (actBehaviorSerarch == false)
//                if (jcbOrdem.Equals("Codigo") && ordem.Equals("primeiros"))
//                {
//                    parametroCodigoAlfabeto = "Codigo";
//                    parametroASCDESC = "primeiros";
//                    if (cbButtnQuantPage1.SelectedText == "Todos")
//                    {
//                    }
//                    else
//                    {
//                        if (inicioDeslocamento.Equals("Sim"))
//                        {
//                            resetarPonteiros();
//                            this.EnviaModelo("CarregaPadraoIDTodosPrimeiros", deslocamento, limiteregistro);
//                        }
//                        else if (inicioDeslocamento.Equals("Nao"))
//                        {

//                            this.EnviaModelo("CarregaPadraoIDTodosPrimeiros", deslocamento, limiteregistro);
//                        }
//                    }
//                }
//                else if (jcbOrdem.Equals("Codigo") && ordem.Equals("ultimos"))
//                {
//                    parametroCodigoAlfabeto = "Codigo";
//                    parametroASCDESC = "ultimos";
//                    if (cbButtnQuantPage1.SelectedText == "Todos")
//                    {
//                    }
//                    else
//                    {
//                        paginar = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
//                        ultimaPagina = paginar;
//                        if (inicioDeslocamento.Equals("Sim"))
//                        {
//                            resetarPonteiros();
//                            this.EnviaModelo("CarregaPadraoIDTodosUltimos", deslocamento, limiteregistro);
//                        }
//                        else if (inicioDeslocamento.Equals("Nao"))
//                        {
//                            this.EnviaModelo("CarregaPadraoIDTodosUltimos", deslocamento, limiteregistro);
//                        }
//                    }
//                }
//                else if (jcbOrdem.Equals("Alfabeto") && ordem.Equals("primeiros"))
//                {
//                    parametroCodigoAlfabeto = "Alfabeto";
//                    parametroASCDESC = "primeiros";
//                    if (cbButtnQuantPage1.SelectedText == "Todos")
//                    {
//                    }
//                    else
//                    {
//                        if (inicioDeslocamento.Equals("Sim"))
//                        {
//                            resetarPonteiros();
//                            this.EnviaModelo("CarregaPadraoNomeTodosPrimeiros", deslocamento, limiteregistro);
//                        }
//                        else if (inicioDeslocamento.Equals("Nao"))
//                        {
//                            this.EnviaModelo("CarregaPadraoNomeTodosPrimeiros", deslocamento, limiteregistro);
//                        }
//                    }
//                }
//                else if (jcbOrdem.Equals("Alfabeto") && ordem.Equals("ultimos"))
//                {
//                    parametroCodigoAlfabeto = "Alfabeto";
//                    parametroASCDESC = "ultimos";
//                    if (cbButtnQuantPage1.SelectedText == "Todos")
//                    { }
//                    else
//                    {
//                        if (inicioDeslocamento.Equals("Sim"))
//                        {
//                            resetarPonteiros();
//                            this.EnviaModelo("CarregaPadraoNomeTodosUltimos", deslocamento, limiteregistro);
//                        }
//                        else if (inicioDeslocamento.Equals("Nao"))
//                        {
//                            this.EnviaModelo("CarregaPadraoNomeTodosUltimos", deslocamento, limiteregistro);
//                        }
//                    }
//                }
//        }


//        public void somar()
//        {
//            int pagina1 = Convert.ToInt32(labelTextTotalPages.Text);
//            int pg = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
//            if (memoria < pagina1 && finalPaginaBol == false)
//            {
//                deslocamento1 = paginaAtual + pg;
//                paginarPesquisa = deslocamento1;
//                deslocado = deslocamento1;
//                paginaAtual = deslocado;
//                memoria++;
//                labelTextPageFrom.Text = memoria.ToString();
//                bttnBeginPages.Enabled = true;
//                bttnBeginPages.Enabled = true;
//                this.puxarparametro(deslocamento1, pg, "Nao");
//                if (memoria == pagina1)
//                {
//                    bttnOnePageRight.Enabled = false;
//                    bttnEndPages.Enabled = false;
//                    finalPaginaBol = true;
//                    inicioPaginaBol = false;
//                }
//            }
//            else if (memoria < pagina1 && finalPaginaBol == true)
//            {
//                deslocamento1 = paginaAtual + pg;
//                deslocado = deslocamento1;
//                paginaAtual = deslocado;
//                memoria++;
//                labelTextPageFrom.Text = memoria.ToString();
//                bttnBeginPages.Enabled = true;
//                bttnBeginPages.Enabled = true;
//                this.puxarparametro(deslocamento1, paginar, "Nao");
//                if (memoria == pagina1)
//                {
//                    bttnOnePageRight.Enabled = false;
//                    bttnEndPages.Enabled = false;
//                    finalPaginaBol = true;
//                    inicioPaginaBol = false;
//                }
//            }
//        }

//        public void descontar()
//        {
//            int pagina1 = Convert.ToInt32(labelTextTotalPages.Text);
//            int pg = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
//            if (memoria > 1 && memoria <= pagina1 && inicioPaginaBol == true)
//            {
//                deslocamento1 = deslocamento1 - pg;
//                deslocado = deslocamento1;
//                paginaAtual = deslocado;
//                --memoria;
//                labelTextPageFrom.Text = Convert.ToString(memoria);
//                bttnOnePageRight.Enabled = true;
//                bttnEndPages.Enabled = true;
//                this.puxarparametro(deslocamento1, pg, "Nao");
//                if (memoria == 1)
//                {
//                    bttnOnePageRight.Enabled = true;
//                    bttnEndPages.Enabled = true;
//                    inicioPaginaBol = true;
//                    finalPaginaBol = false;
//                    MessageBox.Show("Início da Paginação", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//            }

//            else if (memoria > 1 && memoria <= pagina1 && inicioPaginaBol == false)
//            {
//                deslocamento1 = deslocamento1 - pg;
//                deslocado = deslocamento1;
//                paginaAtual = deslocado;
//                --memoria;
//                labelTextPageFrom.Text = Convert.ToString(memoria);
//                this.puxarparametro(deslocamento1, pg, "Nao");
//                bttnOnePageRight.Enabled = true;
//                bttnEndPages.Enabled = true;
//                if (finalPaginaBol == true)
//                {
//                    bttnOnePageRight.Enabled = true;
//                    bttnEndPages.Enabled = true;
//                }
//                if (memoria == 1)
//                {
//                    inicioPaginaBol = true;
//                    finalPaginaBol = false;
//                }
//            }
//        }

//        public void inicioPagina()
//        {
//            resetarPonteiros();
//            this.puxarparametro(deslocamento1, paginar, "Nao");
//        }


//        public void finalDaPagina()
//        {
//            int pagina1 = Convert.ToInt32(labelTextTotalPages.Text);
//            int ajustaPaginacao = pagina1 - 1;
//            int pg = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
//            for (int i = memoria; memoria <= ajustaPaginacao; i++)
//            {
//                deslocamento1 = paginaAtual + pg;
//                deslocado = deslocamento1;
//                paginaAtual = deslocado;
//                memoria++;
//                if (memoria == pagina1)
//                {
//                    bttnOnePageRight.Enabled = false;
//                    bttnEndPages.Enabled = false;
//                    bttnBeginPages.Enabled = true;
//                    bttnBeginPages.Enabled = true;
//                    labelTextPageFrom.Text = Convert.ToString(memoria);
//                    inicioPaginaBol = false;
//                    finalPaginaBol = true;
//                    this.puxarparametro(deslocamento1, pg, "Nao");
//                }
//            }
//        }

//        public void resetarPonteiros()
//        {
//            finalPaginaBol = false;
//            inicioPaginaBol = true;
//            bttnOnePageRight.Enabled = true;
//            bttnEndPages.Enabled = true;
//            labelTextPageFrom.Text = Convert.ToString(1);
//            paginaAtual = 0;
//            paginar = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
//            deslocado = 0;
//            memoria = 1;
//            deslocamento1 = 0;
//            paginarPesquisa = 0;
//            actBehaviorSerarch = false;
//        }

//        public void carregarInformacoes()
//        {
//            resultado = 0;
//            int quantidadeReg = 0;
//            quantidadeReg = Convert.ToInt32(controllerPapeis.ListarBDPapeisControlller());
//            int jcbPaginas = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);

//            resultado = quantidadeReg / jcbPaginas;
//            int resto = quantidadeReg % jcbPaginas;
//            if (resto >= 1)
//            {
//                labelTextTotalPages.Text = Convert.ToString(resultado + 1);
//            }
//            else if (resto == 0)
//            {
//                labelTextTotalPages.Text = Convert.ToString(resultado);
//            }
//        }


//        private void puxarparametroPesquisa()
//        {
//            string estadoPesquisa = "";
//            string pesquisarEmColuna = Convert.ToString(cbButtonPesquisarEm.SelectedItem);
//            if (radioBttnComeca.Checked == true)
//            {
//                estadoPesquisa = "ComecaCom";
//            }
//            else if (radioBttnContem.Checked == true)
//            {
//                estadoPesquisa = "Contem";
//            }
//            else if (radioBttnTermina.Checked == true)
//            {
//                estadoPesquisa = "TerminaCom";
//            }
//            else if (radioBttnComeca.Checked == false)
//            {
//                estadoPesquisa = "";
//            }
//            else if (radioBttnContem.Checked == false)
//            {
//                estadoPesquisa = "";
//            }
//            else if (radioBttnTermina.Checked == false)
//            {
//                estadoPesquisa = "";
//            }

//            if (actBehaviorSerarch == true)
//            {

//                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Nome"))
//                {
//                    gridCrudPapeis.DataSource = controllerPapeis.PesquisarComecaCom("nomepapel", "@nomepapel", txtBoxPesquisar.Text);
//                    DataGridModel();
//                    toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
//                }
//                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Nome"))
//                {
//                    gridCrudPapeis.DataSource = controllerPapeis.PesquisarContemCom("nomepapel", "@nomepapel", txtBoxPesquisar.Text);
//                    DataGridModel();
//                    toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
//                }
//                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Nome"))
//                {
//                    gridCrudPapeis.DataSource = controllerPapeis.PesquisarTerminaCom("nomepapel", "@nomepapel", txtBoxPesquisar.Text);
//                    DataGridModel();
//                    toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
//                }
//            }
//        }

//        public void EnviaModelo(string pesquisa, int offset, int limitt)
//        {

//            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
//            {
//                gridCrudPapeis.DataSource = controllerPapeis.ConfiListagemDataGrid("idpapel", "desc", offset, limitt);
//                DataGridModel();
//                labelTextTotalRegFould.Text = Convert.ToString(controllerPapeis.ListarBDPapeisControlller());
//                carregarInformacoes();
//            }
//            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
//            {
//                gridCrudPapeis.DataSource = controllerPapeis.ConfiListagemDataGrid("idpapel", "asc", offset, limitt);
//                DataGridModel();
//                labelTextTotalRegFould.Text = Convert.ToString(controllerPapeis.ListarBDPapeisControlller());
//                carregarInformacoes();
//            }
//            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
//            {
//                gridCrudPapeis.DataSource = controllerPapeis.ConfiListagemDataGrid("nomepapel", "desc", offset, limitt);
//                DataGridModel();
//                labelTextTotalRegFould.Text = Convert.ToString(controllerPapeis.ListarBDPapeisControlller());
//                carregarInformacoes();
//            }
//            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
//            {
//                gridCrudPapeis.DataSource = controllerPapeis.ConfiListagemDataGrid("nomepapel", "asc", offset, limitt);
//                DataGridModel();
//                labelTextTotalRegFould.Text = Convert.ToString(controllerPapeis.ListarBDPapeisControlller());
//                carregarInformacoes();
//            }
//        }

//        public void carregarEstadoPadrao(string pesquisa, int offsett)
//        {
//            cbButtnQuantPage1.SelectedIndex = 0;
//            int quantRegPage = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
//            cbOrdenarPor1.SelectedIndex = 1;
//            cbOrdemParam1.SelectedIndex = 0;
//            resetarPonteiros();
//            this.puxarparametro(0, quantRegPage, "Nao");
//            bttnDel.Enabled = false;
//            bttnEdit.Enabled = false;
//            bttnSearch.Enabled = true;
//            bttnRefresh.Enabled = true;
//            bttnSave.Enabled = false;
//            bttnNew.Enabled = true;
//            radioBttnComeca.Checked = false;
//            radioBttnContem.Checked = false;
//            radioBttnTermina.Checked = false;
//            tabControlAssets.Visible = false;
//            bttnBeginPages.Visible = true;
//            bttnOnePageLeft.Visible = true;
//            labelTextPageFrom.Visible = true;
//            toolStripLabel3.Visible = true;
//            labelTextTotalPages.Visible = true;
//            toolStripLabel5.Visible = true;
//            labelTextTotalRegFould.Visible = true;
//            bttnOnePageRight.Visible = true;
//            bttnEndPages.Visible = true;
//            toolStripLabel1.Visible = false;
//            toolStripLabel2.Visible = false;
//            txtBoxId.Visible = false;
//            tabControlAssets.TabPages.Remove(tabPagePesquisar);
//            clearFieldsFormulario();
//        }

//        private void bttnSearch_Click_1(object sender, EventArgs e)
//        {
//            countBttnToggle++;
//            if (countBttnToggle % 2 == 0)
//            {
//                tabControlAssets.Visible = true;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);
//                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
//                bttnEdit.Enabled = false;
//                bttnNew.Enabled = false;
//                bttnRefresh.Enabled = false;
//                actBehaviorSerarch = true;
//                cbButtonPesquisarEm.SelectedIndex = 0;
//                radioBttnComeca.Checked = true;
//                txtBoxPesquisar.Text = "";
//                bttnBeginPages.Visible = false;
//                bttnOnePageLeft.Visible = false;
//                labelTextPageFrom.Visible = false;
//                toolStripLabel3.Visible = false;
//                labelTextTotalPages.Visible = false;
//                toolStripLabel5.Visible = false;
//                labelTextTotalRegFould.Visible = false;
//                bttnOnePageRight.Visible = false;
//                bttnEndPages.Visible = false;
//                toolStripLabel1.Visible = true;
//                toolStripLabel2.Visible = true;
//                txtBoxPesquisar.Text = "";
//                txtBoxPesquisar.Focus();
//                gridCrudPapeis.DataSource = controllerPapeis.PesquisarComecaCom("nomepapel", "@nomepapel", "");
//                DataGridModel();
//                toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
//                typeEdition = "search";
//                cbButtnQuantPage1.Visible = false;
//                cbOrdemParam1.Visible = false;
//                cbOrdenarPor1.Visible = false;
//                toolStripLabel6.Visible = false;
//                toolStripLabel7.Visible = false;
//                toolStripLabel8.Visible = false;
//            }
//            else
//            {
//                tabControlAssets.Visible = false;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);
//                bttnEdit.Enabled = false;
//                bttnNew.Enabled = true;
//                bttnRefresh.Enabled = true;
//                actBehaviorSerarch = false;
//                bttnBeginPages.Visible = true;
//                bttnOnePageLeft.Visible = true;
//                labelTextPageFrom.Visible = true;
//                toolStripLabel3.Visible = true;
//                labelTextTotalPages.Visible = true;
//                toolStripLabel5.Visible = true;
//                labelTextTotalRegFould.Visible = true;
//                bttnOnePageRight.Visible = true;
//                bttnEndPages.Visible = true;
//                toolStripLabel1.Visible = false;
//                toolStripLabel2.Visible = false;
//                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//                stringPapel = "";
//                txtBoxId.Text = "";
//                typeEdition = "insert";
//                cbButtnQuantPage1.Visible = true;
//                cbOrdemParam1.Visible = true;
//                cbOrdenarPor1.Visible = true;
//                toolStripLabel6.Visible = true;
//                toolStripLabel7.Visible = true;
//                toolStripLabel8.Visible = true;

//            }
//        }

//        private void DataGridModel()
//        {
//            gridCrudPapeis.Columns[0].HeaderText = "ID";
//            gridCrudPapeis.Columns[1].HeaderText = "Função";
//            gridCrudPapeis.Columns[2].HeaderText = "Criar";
//            gridCrudPapeis.Columns[3].HeaderText = "Recuperar";
//            gridCrudPapeis.Columns[4].HeaderText = "Atualizar";
//            gridCrudPapeis.Columns[5].HeaderText = "Excluir";
//            gridCrudPapeis.Columns[6].HeaderText = "Operacional";
//            gridCrudPapeis.Columns[7].HeaderText = "Administrativo";
//            gridCrudPapeis.Columns[8].HeaderText = "Gerencial";
//            gridCrudPapeis.Columns[0].Width = 100;
//            gridCrudPapeis.Columns[1].Width = 200;
//            gridCrudPapeis.Columns[2].Width = 130;
//            gridCrudPapeis.Columns[3].Width = 130;
//            gridCrudPapeis.Columns[4].Width = 130;
//            gridCrudPapeis.Columns[5].Width = 130;
//            gridCrudPapeis.Columns[6].Width = 130;
//            gridCrudPapeis.Columns[7].Width = 130;
//            gridCrudPapeis.Columns[8].Width = 130;
//            gridCrudPapeis.Columns[2].Visible = false;
//            gridCrudPapeis.Columns[3].Visible = false;
//            gridCrudPapeis.Columns[4].Visible = false;
//            gridCrudPapeis.Columns[5].Visible = false;
//            gridCrudPapeis.Columns[6].Visible = false;
//            gridCrudPapeis.Columns[7].Visible = false;
//            gridCrudPapeis.Columns[8].Visible = false;

//        }


//        private void behaviorRefresh()
//        {

//            if (operationType == "updateData" && typeEdition == "search")
//            {
//                tabControlAssets.Visible = true;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);
//                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
//                bttnEdit.Enabled = true;
//                bttnSave.Enabled = false;
//                bttnSearch.Enabled = true;
//                puxarparametroPesquisa();
//            }
//            else if (operationType == "" ||
//                    operationType == "newInsertion" ||
//                    operationType == "updateData" ||
//                    operationType == "search" && typeEdition == "insert")
//            {
//                bttnDel.Enabled = false;
//                bttnEdit.Enabled = false;
//                bttnSearch.Enabled = true;
//                bttnRefresh.Enabled = true;
//                bttnSave.Enabled = false;
//                bttnNew.Enabled = true;
//                radioBttnComeca.Checked = false;
//                radioBttnContem.Checked = false;
//                radioBttnTermina.Checked = false;
//                tabControlAssets.Visible = false;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);
//                clearFieldsFormulario();
//                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//                gridCrudPapeis.ClearSelection();
//            }
//            else if (operationType == "" ||
//                    operationType == "newInsertion" ||
//                    operationType == "updateData" ||
//                    operationType == "search" && typeEdition == "search")
//            {
//                bttnDel.Enabled = false;
//                bttnEdit.Enabled = false;
//                bttnSearch.Enabled = true;
//                bttnRefresh.Enabled = true;
//                bttnSave.Enabled = false;
//                bttnNew.Enabled = true;
//                radioBttnComeca.Checked = false;
//                radioBttnContem.Checked = false;
//                radioBttnTermina.Checked = false;
//                tabControlAssets.Visible = false;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);
//                clearFieldsFormulario();
//                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//                gridCrudPapeis.ClearSelection();
//            }
//        }
//        private void behaviorNewInsert()
//        {
//            bttnDel.Enabled = false;
//            bttnEdit.Enabled = false;
//            bttnSearch.Enabled = false;
//            bttnRefresh.Enabled = true;
//            bttnSave.Enabled = true;
//            bttnNew.Enabled = false;

//            operationType = "newInsertion";
//            txtBoxId.Enabled = false;
//            //   gridCrudPapeis.Visible = false;
//            formEditPapel frmEditPapel = new formEditPapel();
//            stringPapel = "";
//            bolCriar = false;
//            bolRecuperar = false;
//            bolEditar = false;
//            bolExcluir = false;
//            bolMenuOp = false;
//            bolMenuAdmin = false;
//            bolMenuGen = false;

//            frmEditPapel.PapelVO = stringPapel;
//            frmEditPapel.CriarVO = bolCriar;
//            frmEditPapel.RecuperarVO = bolRecuperar;
//            frmEditPapel.AtualizarVO = bolEditar;
//            frmEditPapel.DeletarVO = bolExcluir;
//            frmEditPapel.MenuOpVO = bolMenuOp;
//            frmEditPapel.MenuAdminVO = bolMenuAdmin;
//            frmEditPapel.MenuGenVO = bolMenuGen;
//            frmEditPapel.ShowDialog();


//            if (frmEditPapel.AcaoDialogVO.Equals("sair"))
//            {
//                stringPapel = "";
//                txtBoxId.Text = "";
//                bolCriar = false;
//                bolRecuperar = false;
//                bolEditar = false;
//                bolExcluir = false;
//                bolMenuOp = false;
//                bolMenuAdmin = false;
//                bolMenuGen = false;
//                behaviorRefresh();

//            }

//            if (frmEditPapel.AcaoDialogVO.Equals("ok"))
//            {
//                stringPapel = frmEditPapel.PapelVO;
//                bolCriar = frmEditPapel.CriarVO;
//                bolRecuperar = frmEditPapel.RecuperarVO;
//                bolEditar = frmEditPapel.AtualizarVO;
//                bolExcluir = frmEditPapel.DeletarVO;
//                bolMenuOp = frmEditPapel.MenuOpVO;
//                bolMenuAdmin = frmEditPapel.MenuAdminVO;
//                bolMenuGen = frmEditPapel.MenuGenVO;
//                behaviorSave();
//            }


//        }
//        private void behaviorDel()
//        {
//            bttnDel.Enabled = true;
//            bttnEdit.Enabled = false;
//            bttnSearch.Enabled = true;
//            bttnRefresh.Enabled = true;
//            bttnSave.Enabled = false;
//            bttnNew.Enabled = true;
//            controllerPapeis.Excluir(Convert.ToInt32(gridCrudPapeis.CurrentRow.Cells[0].Value), Convert.ToString(gridCrudPapeis.CurrentRow.Cells[1].Value));
//            if (controllerPapeis.retornoPersistencia.Equals("DEL"))
//            {
//                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//                behaviorRefresh();
//            }
//            else if (controllerPapeis.retornoPersistencia.Equals("NDEL"))
//            {
//                MessageBox.Show("Exclusão Cancelada", "Registro Não Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//                behaviorRefresh();
//            }
//        }

//        private void behaviorSave()
//        {
//            string retiraEspacos = stringPapel;
//            string remPapel = retiraEspacos.Trim();
//            string retiraEspacosId = txtBoxId.Text;
//            string remEspacosId = retiraEspacosId.Trim();
//            if (remEspacosId.Equals("") || remEspacosId == null)
//            {
//                if (operationType.Equals("newInsertion") && typeEdition.Equals("insert"))
//                {
//                    if (remPapel.Length <= 1)
//                    {
//                        var resultado = MessageBox.Show("A Inserção não alcançou o número mínimo de 3 caracteres.\n" +
//                        "Para tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.",
//                        "Aviso do Sistema",
//                        MessageBoxButtons.YesNo,
//                        MessageBoxIcon.Question);
//                        if (resultado == DialogResult.Yes)
//                        {

//                            stringPapel = "";
//                        }
//                        else if (resultado == DialogResult.No)
//                        {

//                            behaviorRefresh();
//                        }
//                    }
//                    else if (remPapel.Length >= 1)
//                    {
//                        controllerPapeis.Salvar(stringPapel, bolCriar, bolRecuperar, bolEditar, bolExcluir, bolMenuOp, bolMenuAdmin, bolMenuGen);//  controllerUsuarios.Salvar(txtBoxUsuario.Text, txtBoxSenha.Text, txtBoxIdPessoa.Text, txtBoxIdPapeis.Text);//   controllerTipoUnds.Salvar(txtBoxName.Text);

//                        if ("NS".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
//                        {

//                            stringPapel = "";
//                            behaviorRefresh();
//                        }
//                        else if ("S!".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
//                        {

//                            operationType = "newInsertion";
//                            typeEdition = "insert";

//                            behaviorRefresh();

//                        }
//                        else if ("S!!".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
//                        {

//                            operationType = "newInsertion";
//                            typeEdition = "insert";

//                            behaviorRefresh();

//                        }
//                    }
//                    if ("NS".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
//                    {

//                        operationType = "newInsertion";
//                        typeEdition = "insert";
//                        behaviorRefresh();
//                    }
//                }
//            }
//            else if (!remEspacosId.Equals("") || remEspacosId != null)
//            {

//                if (operationType.Equals("updateData") && typeEdition.Equals("insert"))
//                {
//                    if (remPapel.Length <= 1)
//                    {
//                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//                        if (resultado == DialogResult.Yes)
//                        {
//                            stringPapel = "";
//                        }
//                        else if (resultado == DialogResult.No)
//                        {
//                            behaviorRefresh();
//                        }
//                    }
//                    else if (remPapel.Length >= 1)
//                    {
//                        controllerPapeis.Editar(stringPapel, bolCriar, bolRecuperar, bolEditar, bolExcluir, bolMenuOp, bolMenuAdmin, bolMenuGen, Convert.ToInt32(txtBoxId.Text));

//                        if ("AT".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
//                        {

//                       //     stringPapel = "";
//                          behaviorRefresh();

//                        }
//                    }
//                    if ("NS".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
//                    {

//                        //operationType = "newInsertion";
//                        //typeEdition = "insert";
//                        ////acoesBehaviorSave();
//                        behaviorRefresh();
//                    }
//                }
//                else if (operationType.Equals("updateData") && typeEdition.Equals("search"))
//                {
//                    if (remPapel.Length <= 1)
//                    {
//                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//                        if (resultado == DialogResult.Yes)
//                        {
//                            stringPapel = "";

//                        }
//                        else if (resultado == DialogResult.No)
//                        {
//                            behaviorRefresh();
//                        }

//                    }
//                    else if (remPapel.Length >= 1)
//                    {
//                        controllerPapeis.Editar( stringPapel, bolCriar, bolRecuperar, bolEditar, bolExcluir, bolMenuOp, bolMenuAdmin, bolMenuGen, Convert.ToInt32(txtBoxId.Text));

//                        if ("AT".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
//                        {
//                            behaviorRefresh();
//                            puxarparametroPesquisa();

                           

//                        }
//                    }
//                    if ("NS".Equals(controllerPapeis.AcaoCrudPapeisDAO()))
//                    {
//                        behaviorRefresh();
//                    }
//                }
//            }
//        }




//        private void acoesBehaviorSave()
//        {

//            bttnDel.Enabled = false;
//            bttnEdit.Enabled = false;
//            bttnSearch.Enabled = true;
//            bttnRefresh.Enabled = true;
//            bttnSave.Enabled = false;
//            bttnNew.Enabled = true;
//            //bttnPrint.Enabled = false;
//            //bttnImport.Enabled = false;
//            //bttnExcel.Enabled = false;
//            radioBttnComeca.Checked = false;
//            radioBttnContem.Checked = false;
//            radioBttnTermina.Checked = false;
//            tabControlAssets.Visible = false;
//            tabControlAssets.TabPages.Remove(tabPagePesquisar);
//            clearFieldsFormulario();
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }



//      private void bttnSave_Click(object sender, EventArgs e)
//        {
//            behaviorSave();
//        }

//        private void bttnNew_Click(object sender, EventArgs e)
//        {
//            behaviorNewInsert();
//        }

//        private void bttnSearch_Click(object sender, EventArgs e)
//        {
//            countBttnToggle++;
//            if (countBttnToggle % 2 == 0)
//            {
//                tabControlAssets.Visible = true;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);
//                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
//                bttnNew.Enabled = false;
//                bttnRefresh.Enabled = false;
//                actBehaviorSerarch = true;
//            }
//            else
//            {
//                tabControlAssets.Visible = false;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);
//                bttnNew.Enabled = true;
//                bttnRefresh.Enabled = true;
//                actBehaviorSerarch = false;
//            }
//        }

//        private void bttnRefresh_Click(object sender, EventArgs e)
//        {
//            behaviorRefresh();
//        }

//        private void toolStripButton7_Click(object sender, EventArgs e)
//        {
//            countBttnToggleTools++;
//            if (countBttnToggleTools % 2 == 0)
//            {
//                tabControlAssets.Visible = true;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);
//                bttnNew.Enabled = false;
//                bttnRefresh.Enabled = false;
//                bttnSearch.Enabled = false;
//            }
//            else
//            {
//                tabControlAssets.Visible = false;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);

//                bttnNew.Enabled = true;
//                bttnRefresh.Enabled = true;
//                bttnSearch.Enabled = true;
//            }
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            countBttnToggle++;
//            if (countBttnToggle % 2 != 0)
//            {
//                tabControlAssets.Visible = false;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);
//                bttnNew.Enabled = true;
//                bttnRefresh.Enabled = true;
//            }
//            else
//            {
//                tabControlAssets.Visible = true;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);
//                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
//                bttnNew.Enabled = false;
//                bttnRefresh.Enabled = false;
//            }
//        }

//        private void bttnOnePageRight_Click(object sender, EventArgs e)
//        {
//            somar();
//        }

//        private void bttnEndPages_Click(object sender, EventArgs e)
//        {
//            finalDaPagina();
//        }

//        private void bttnOnePageLeft_Click(object sender, EventArgs e)
//        {
//            descontar();
//        }

//        private void bttnBeginPages_Click(object sender, EventArgs e)
//        {
//            inicioPagina();
//        }

//        private void cbButtnQuantPage1_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");

//        }



//        private void formCrudPessoas_Load(object sender, EventArgs e)
//        {

//        }

//        private void bttnSave_Click_1(object sender, EventArgs e)
//        {

//            behaviorSave();
//        }

//        private void radBttnFirst_CheckedChanged(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }

//        private void radBttnLast_CheckedChanged(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }



//        private void bttnNew_Click_1(object sender, EventArgs e)
//        {

//            behaviorNewInsert();
//        }

//        private void bttnRefresh_Click_1(object sender, EventArgs e)
//        {
//            behaviorRefresh();
//        }


//        private void button1_Click_1(object sender, EventArgs e)
//        {
//            txtBoxPesquisar.Text = "";
//            gridCrudPapeis.DataSource = controllerPapeis.PesquisarComecaCom("nomepapel", "@nomepapel", "");
//            DataGridModel();
//            toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
//            operationType = "search";

//        }

//        private void radioBttnContem_CheckedChanged(object sender, EventArgs e)
//        {
//            puxarparametroPesquisa();
//        }

//        private void radioBttnTermina_CheckedChanged(object sender, EventArgs e)
//        {
//            puxarparametroPesquisa();
//        }

//        private void radioBttnComeca_CheckedChanged(object sender, EventArgs e)
//        {
//            puxarparametroPesquisa();
//        }

//        private void txtBoxPesquisar_TextChanged(object sender, EventArgs e)
//        {
//            puxarparametroPesquisa();
//        }

//        private void bttnEdit_Click(object sender, EventArgs e)
//        {
//            editarRegistro();
//        }


//        private void button2_Click_1(object sender, EventArgs e)
//        {

//            countBttnToggle++;
//            if (countBttnToggle % 2 == 0)
//            {
//                tabControlAssets.Visible = true;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);

//                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);

//                bttnSearch.Enabled = false;
//                bttnEdit.Enabled = false;
//                bttnNew.Enabled = false;
//                bttnRefresh.Enabled = false;
//                actBehaviorSerarch = true;
//                cbButtonPesquisarEm.SelectedIndex = 0;
//                radioBttnComeca.Checked = true;
//                txtBoxPesquisar.Text = "";
//                bttnBeginPages.Visible = false;
//                bttnOnePageLeft.Visible = false;
//                labelTextPageFrom.Visible = false;
//                toolStripLabel3.Visible = false;
//                labelTextTotalPages.Visible = false;
//                toolStripLabel5.Visible = false;
//                labelTextTotalRegFould.Visible = false;
//                bttnOnePageRight.Visible = false;
//                bttnEndPages.Visible = false;
//                toolStripLabel1.Visible = true;
//                toolStripLabel2.Visible = true;
//                txtBoxPesquisar.Text = "";
//                txtBoxPesquisar.Focus();
//                gridCrudPapeis.DataSource = controllerPapeis.PesquisarComecaCom("nomepapel", "@nomepapel", "");
//                DataGridModel();
//                toolStripLabel2.Text = Convert.ToString(controllerPapeis.ListarPesquisaPapeisController());
//                operationType = "search";


//            }
//            else
//            {
//                tabControlAssets.Visible = false;
//                tabControlAssets.TabPages.Remove(tabPagePesquisar);
//                bttnEdit.Enabled = false;
//                bttnNew.Enabled = true;
//                bttnRefresh.Enabled = true;
//                actBehaviorSerarch = false;
//                bttnSearch.Enabled = true;
//                bttnBeginPages.Visible = true;
//                bttnOnePageLeft.Visible = true;
//                labelTextPageFrom.Visible = true;
//                toolStripLabel3.Visible = true;
//                labelTextTotalPages.Visible = true;
//                toolStripLabel5.Visible = true;
//                labelTextTotalRegFould.Visible = true;
//                bttnOnePageRight.Visible = true;
//                bttnEndPages.Visible = true;
//                //  bttnTools.Enabled = true;
//                toolStripLabel1.Visible = false;
//                toolStripLabel2.Visible = false;


//                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//                typeEdition = "insert";
//                operationType = "newInsertion";


//            }
//        }

//        private void bttnDel_Click(object sender, EventArgs e)
//        {
//            behaviorDel();
//        }

     

//        private void radioBttnTermina_CheckedChanged_1(object sender, EventArgs e)
//        {
//            puxarparametroPesquisa();
//        }

//        private void radioBttnComeca_CheckedChanged_1(object sender, EventArgs e)
//        {
//            puxarparametroPesquisa();
//        }

//        private void radioBttnContem_CheckedChanged_1(object sender, EventArgs e)
//        {
//            puxarparametroPesquisa();
//        }

//        private void cbButtonPesquisarEm_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            puxarparametroPesquisa();
//        }

//        private void txtBoxPesquisar_TextChanged_1(object sender, EventArgs e)
//        {
//            puxarparametroPesquisa();
//        }

//        private void cbOrdemParam_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }


//        private void radBttnLast_CheckedChanged_1(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }

//        private void radBttnFirst_CheckedChanged_1(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }

//        private void cbButtnQuantPage1_SelectedIndexChanged_1(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }



//        private void gridCrudPapeis_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            var gridVazia = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
//            if (string.IsNullOrEmpty(gridVazia))
//            {
//            }
//            else if (gridVazia.Length > 0)
//            {
//                if (typeEdition.Equals("insert"))
//                {
//                    operationType = "newInsertion";
//                    behaviorClickGrid();
//                }
//                else if (typeEdition.Equals("search"))
//                {
//                    operationType = "updateData";
//                    behaviorClickGridPesquisa();
//                }
//            }

//        }



//        private void cbOrdemParam1_Click(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }

//        private void cbOrdenarPor_Click(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }

//        private void cbButtnQuantPage_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void cbButtnQuantPage1_Click(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }

//        private void cbOrdenarPor_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }

//        private void cbOrdemParam1_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }

//        private void cbButtnQuantPage1_SelectedIndexChanged_2(object sender, EventArgs e)
//        {
//            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
//        }

//        private void bttnOnePageRight_Click_1(object sender, EventArgs e)
//        {
//            somar();
//        }

//        private void bttnEndPages_Click_1(object sender, EventArgs e)
//        {
//            finalDaPagina();
//        }

//        private void bttnOnePageLeft_Click_1(object sender, EventArgs e)
//        {
//            descontar();
//        }

//        private void bttnBeginPages_Click_1(object sender, EventArgs e)
//        {
//            inicioPagina();
//        }

      

//        private void formCrudPapeis_Load(object sender, EventArgs e)
//        {
//            //funciona inicializacao maximizada
//        //    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

//        }

//        private void formCrudPapeis_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            _InstanciaformCrudPapeis = null;
//        }

//        private void gridCrudPapeis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
//        {
//            editarRegistro();
//        }



//        public void editarRegistro()
//        {
//            var gridVazia = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
//            if (string.IsNullOrEmpty(gridVazia))
//            {
//            }
//            else if (gridVazia.Length > 0)
//            {
//                if (typeEdition.Equals("insert") && operationType.Equals("newInsertion"))
//                {
//                    operationType = "newInsertion";
//                    behaviorEdit();
//                    typeEdition = "insert";
//                    operationType = "updateData";
//                    bttnDel.Enabled = false;
//                    bttnEdit.Enabled = false;
//                    bttnSearch.Enabled = false;
//                    bttnRefresh.Enabled = true;
//                    bttnSave.Enabled = true;
//                    bttnNew.Enabled = false;
//                    clearFieldsFormulario();
//                    txtBoxId.Enabled = false;
//                    txtBoxId.Text = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
//                    stringPapel = gridCrudPapeis.CurrentRow.Cells[1].Value.ToString();

//                    formEditPapel frmEditPapel = new formEditPapel();
//                    frmEditPapel.PapelVO = stringPapel;
//                    frmEditPapel.CriarVO = bolCriar;
//                    frmEditPapel.RecuperarVO = bolRecuperar;
//                    frmEditPapel.AtualizarVO = bolRecuperar;
//                    frmEditPapel.DeletarVO = bolExcluir;
//                    frmEditPapel.MenuOpVO = bolMenuOp;
//                    frmEditPapel.MenuAdminVO = bolMenuAdmin;
//                    frmEditPapel.MenuGenVO = bolMenuGen;
//                    frmEditPapel.ShowDialog();


//                    if (frmEditPapel.AcaoDialogVO.Equals("sair"))
//                    {
//                        stringPapel = "";
//                        bolCriar = false;
//                        bolRecuperar = false;
//                        bolEditar = false;
//                        bolEditar = false;
//                        bolMenuOp = false;
//                        bolMenuAdmin = false;
//                        bolMenuGen = false;
//                        bttnRefresh.Enabled = false;
//                        behaviorRefresh();
//                    }

//                    else if (frmEditPapel.AcaoDialogVO.Equals("ok"))
//                    {

//                        stringPapel = frmEditPapel.PapelVO;
//                        bolCriar = frmEditPapel.CriarVO;
//                        bolRecuperar = frmEditPapel.RecuperarVO;
//                        bolEditar = frmEditPapel.AtualizarVO;
//                        bolExcluir = frmEditPapel.DeletarVO;
//                        bolMenuOp = frmEditPapel.MenuOpVO;
//                        bolMenuAdmin = frmEditPapel.MenuAdminVO;
//                        bolMenuGen = frmEditPapel.MenuGenVO;
//                        bttnRefresh.Enabled = false;
//                        behaviorSave();

//                    }

//                    if (frmEditPapel.AcaoDialogVO.Equals("sair"))
//                    {

//                        bttnRefresh.Enabled = false;
//                        stringPapel = "";
//                        bolCriar = false;
//                        bolRecuperar = false;
//                        bolEditar = false;
//                        bolEditar = false;
//                        bolMenuOp = false;
//                        bolMenuAdmin = false;
//                        bolMenuGen = false;
//                        behaviorRefresh();
//                    }

//                    else if (frmEditPapel.AcaoDialogVO.Equals("ok"))
//                    {
//                        stringPapel = frmEditPapel.PapelVO;
//                        bolCriar = frmEditPapel.CriarVO;
//                        bolRecuperar = frmEditPapel.RecuperarVO;
//                        bolEditar = frmEditPapel.AtualizarVO;
//                        bolExcluir = frmEditPapel.DeletarVO;
//                        bolMenuOp = frmEditPapel.MenuOpVO;
//                        bolMenuAdmin = frmEditPapel.MenuAdminVO;
//                        bolMenuGen = frmEditPapel.MenuGenVO;
//                        behaviorSave();
//                    }

//                }
//                else if (typeEdition.Equals("search") && operationType.Equals("updateData"))
//                {
//                    operationType = "updateData";
//                    typeEdition = "search";
//                    bttnDel.Enabled = false;
//                    bttnEdit.Enabled = false;
//                    bttnSearch.Enabled = false;
//                    bttnRefresh.Enabled = true;
//                    bttnSave.Enabled = true;
//                    bttnNew.Enabled = false;
//                    clearFieldsFormulario();
//                    txtBoxId.Enabled = false;
//                    txtBoxId.Text = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
//                    stringPapel = gridCrudPapeis.CurrentRow.Cells[1].Value.ToString();

//                    formEditPapel frmEditPapel = new formEditPapel();
//                    frmEditPapel.PapelVO = stringPapel;
//                    frmEditPapel.CriarVO = bolCriar;
//                    frmEditPapel.RecuperarVO = bolRecuperar;
//                    frmEditPapel.AtualizarVO = bolRecuperar;
//                    frmEditPapel.DeletarVO = bolExcluir;
//                    frmEditPapel.MenuOpVO = bolMenuOp;
//                    frmEditPapel.MenuAdminVO = bolMenuAdmin;
//                    frmEditPapel.MenuGenVO = bolMenuGen;
//                    frmEditPapel.ShowDialog();
//                    MessageBox.Show(frmEditPapel.AcaoDialogVO);
//                    if (frmEditPapel.AcaoDialogVO.Equals("ok")){
//                        stringPapel = "";
//                        bolCriar = false;
//                        bolRecuperar = false;
//                        bolEditar = false;
//                        bolEditar = false;
//                        bolMenuOp = false;
//                        bolMenuAdmin = false;
//                        bolMenuGen = false;
//                        bttnRefresh.Enabled = false;
//                        behaviorRefresh();
//                    }

//                    else if (frmEditPapel.AcaoDialogVO.Equals("sair")){
//                        stringPapel = frmEditPapel.PapelVO;
//                        bolCriar = frmEditPapel.CriarVO;
//                        bolRecuperar = frmEditPapel.RecuperarVO;
//                        bolEditar = frmEditPapel.AtualizarVO;
//                        bolExcluir = frmEditPapel.DeletarVO;
//                        bolMenuOp = frmEditPapel.MenuOpVO;
//                        bolMenuAdmin = frmEditPapel.MenuAdminVO;
//                        bolMenuGen = frmEditPapel.MenuGenVO;
//                        bttnRefresh.Enabled = false;
//                        behaviorSave();

//                    }
//                }
//            }
//        }

//        private void behaviorClickGrid()
//        {
//            bolCriar = "1".Equals(gridCrudPapeis.CurrentRow.Cells[2].Value.ToString()) ? true : false;
//            bolRecuperar = "1".Equals(gridCrudPapeis.CurrentRow.Cells[3].Value.ToString()) ? true : false;
//            bolEditar = "1".Equals(gridCrudPapeis.CurrentRow.Cells[4].Value.ToString()) ? true : false;
//            bolExcluir = "1".Equals(gridCrudPapeis.CurrentRow.Cells[5].Value.ToString()) ? true : false;
//            bolMenuOp = "1".Equals(gridCrudPapeis.CurrentRow.Cells[6].Value.ToString()) ? true : false;
//            bolMenuAdmin = "1".Equals(gridCrudPapeis.CurrentRow.Cells[7].Value.ToString()) ? true : false;
//            bolMenuGen = "1".Equals(gridCrudPapeis.CurrentRow.Cells[8].Value.ToString()) ? true : false;

//            bttnNew.Enabled = false;
//            bttnDel.Enabled = true;
//            bttnEdit.Enabled = true;
//            bttnSearch.Enabled = true;
//            bttnRefresh.Enabled = true;
//            bttnSave.Enabled = false;

//            radioBttnComeca.Checked = false;
//            radioBttnContem.Checked = false;
//            radioBttnTermina.Checked = false;
//            clearFieldsFormulario();
//            txtBoxId.Text = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
//            stringPapel = gridCrudPapeis.CurrentRow.Cells[1].Value.ToString();


//        }
//        private void behaviorClickGridPesquisa()
//        {
//            bolCriar = "1".Equals(Convert.ToInt32(gridCrudPapeis.CurrentRow.Cells[2].Value.ToString())) ? true : false;
//            bolRecuperar = "1".Equals(Convert.ToInt32(gridCrudPapeis.CurrentRow.Cells[3].Value.ToString())) ? true : false;
//            bolEditar = "1".Equals(Convert.ToInt32(gridCrudPapeis.CurrentRow.Cells[4].Value.ToString())) ? true : false;
//            bolExcluir = "1".Equals(Convert.ToInt32(gridCrudPapeis.CurrentRow.Cells[5].Value.ToString())) ? true : false;
//            bolMenuOp = "1".Equals(Convert.ToInt32(gridCrudPapeis.CurrentRow.Cells[6].Value.ToString())) ? true : false;
//            bolMenuAdmin = "1".Equals(Convert.ToInt32(gridCrudPapeis.CurrentRow.Cells[7].Value.ToString())) ? true : false;
//            bolMenuGen = "1".Equals(Convert.ToInt32(gridCrudPapeis.CurrentRow.Cells[8].Value.ToString())) ? true : false;

//            bttnNew.Enabled = false;
//            bttnDel.Enabled = true;
//            bttnEdit.Enabled = true;
//            bttnSearch.Enabled = true;
//            bttnRefresh.Enabled = false;
//            bttnSave.Enabled = false;


//            clearFieldsFormulario();
//            txtBoxId.Text = gridCrudPapeis.CurrentRow.Cells[0].Value.ToString();
//            stringPapel = gridCrudPapeis.CurrentRow.Cells[1].Value.ToString();
//        }




//        public void clearFieldsFormulario() { txtBoxId.Text = ""; stringPapel = ""; }
//        public void clearFieldsPesquisar() { txtBoxPesquisar.Text = ""; cbButtonPesquisarEm.SelectedValue = 0; }
//        public void disableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }
//        public void enableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }





//    }

//}
