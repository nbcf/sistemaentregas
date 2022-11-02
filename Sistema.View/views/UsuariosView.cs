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
using Sistema.Controller;

namespace Sistema.View
{
    public partial class UsuariosView : Form
    {

        public string acaoDialogImportPessoa;
        public string acaoDialogImportPapeis;
        public string strLogradouro;


        public string IdPessoaVO
        {
            get { return txtBoxIdPessoa.Text; }
            set { txtBoxIdPessoa.Text = value; }
        }


        public string IdPapeisVO
        {
            get { return txtBoxIdPapeis.Text; }
            set { txtBoxIdPapeis.Text = value; }
        }
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
        //public int limitt = 0;

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

        private static UsuariosView _InstanciaformCrudUsuarios;
        public static UsuariosView GetInstanciaformCrudUsuarios()
        {
            if (_InstanciaformCrudUsuarios == null)
            {
                _InstanciaformCrudUsuarios = new UsuariosView();
            }
            return _InstanciaformCrudUsuarios;
        }

        UsuariosController controllerUsuarios = new UsuariosController();
        public UsuariosView()
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
        //    ckCadastrar.Enabled = false;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            quantidadeReg = Convert.ToInt32(controllerUsuarios.retornoQuantRegistro());
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


                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Usuario"))
                {
                    gridCrudUsuarios.DataSource = controllerUsuarios.PesquisarComecaCom("usuario", "@usuario", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerUsuarios.retornoQuantPesquisa());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Usuario"))
                {
                    gridCrudUsuarios.DataSource = controllerUsuarios.PesquisarContemCom("usuario", "@usuario", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerUsuarios.retornoQuantPesquisa());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Usuario"))
                {
                    gridCrudUsuarios.DataSource = controllerUsuarios.PesquisarTerminaCom("usuario", "@usuario", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerUsuarios.retornoQuantPesquisa());
                }
            }
        }

        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {

            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudUsuarios.DataSource = controllerUsuarios.ListarDataGrid("idusuario", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerUsuarios.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudUsuarios.DataSource = controllerUsuarios.ListarDataGrid("idusuario", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerUsuarios.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudUsuarios.DataSource = controllerUsuarios.ListarDataGrid("usuario", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerUsuarios.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudUsuarios.DataSource = controllerUsuarios.ListarDataGrid("usuario", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerUsuarios.retornoQuantRegistro());
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
            txtBoxId.Enabled = false;
            //bttnPrint.Enabled = false;
            //bttnImport.Enabled = false;
            //bttnExcel.Enabled = false;
            //       bttnTools.Enabled = true;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;

            gridCrudUsuarios.Visible = true;

            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            // tabControlAssets.TabPages.Remove(tabPageFormulario);
            // tabControlAssets.TabPages.Remove(tabPageOptListagem);
            groupBoxFormulario.Enabled = false;
            groupBoxFormulario.Visible = false;
   

            clearFieldsFormulario();
            disableFieldsFormulario();

        }

        //private void bttnTools_Click(object sender, EventArgs e)
        //{
        //    countBttnToggleTools++;
        //    if (countBttnToggleTools % 2 == 0)
        //    {
        //        tabControlAssets.Visible = true;
        //        tabControlAssets.TabPages.Remove(tabPagePesquisar);
        //        //   tabControlAssets.TabPages.Remove(tabPageFormulario);
        //        //  tabControlAssets.TabPages.Remove(tabPageOptListagem);
        //        //   tabControlAssets.TabPages.Insert(0, tabPageOptListagem);
        //        groupBoxFormulario.Enabled = false;
        //        groupBoxFormulario.Visible = false;

        //        bttnNew.Enabled = false;
        //        bttnRefresh.Enabled = false;
        //        bttnSearch.Enabled = false;

        //    }
        //    else
        //    {
        //        tabControlAssets.Visible = false;
        //        tabControlAssets.TabPages.Remove(tabPagePesquisar);
        //        //  tabControlAssets.TabPages.Remove(tabPageFormulario);
        //        // tabControlAssets.TabPages.Remove(tabPageOptListagem);
        //        groupBoxFormulario.Enabled = false;
        //        groupBoxFormulario.Visible = false;

        //        bttnNew.Enabled = true;
        //        bttnRefresh.Enabled = true;
        //        bttnSearch.Enabled = true;
        //        puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");

        //    }
        //}

        private void bttnSearch_Click_1(object sender, EventArgs e)
        {
            countBttnToggle++;
            if (countBttnToggle % 2 == 0)
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
             //   tabControlAssets.TabPages.Remove(tabPageFormulario);
             //   tabControlAssets.TabPages.Remove(tabPageOptListagem);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;

                bttnEdit.Enabled = false;
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                actBehaviorSerarch = true;
                cbButtonPesquisarEm.SelectedIndex = 0;
                radioBttnComeca.Checked = true;
                txtBoxPesquisar.Text = "";

            //    bttnTools.Enabled = false;
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
                gridCrudUsuarios.DataSource = controllerUsuarios.PesquisarComecaCom("usuario", "@usuario", "");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerUsuarios.retornoQuantPesquisa());

                typeEdition = "search";

            


            }
            else
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                //    tabControlAssets.TabPages.Remove(tabPageFormulario);
                //  tabControlAssets.TabPages.Remove(tabPageOptListagem);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;

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
          //      bttnTools.Enabled = true;

                toolStripLabel1.Visible = false;
                toolStripLabel2.Visible = false;


                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                typeEdition = "insert";
              

            }
        }

        private void DataGridModel()
        {
            gridCrudUsuarios.Columns[0].Width = 80;
            gridCrudUsuarios.Columns[1].Width = 0;
            gridCrudUsuarios.Columns[2].Width = 0;
            gridCrudUsuarios.Columns[3].Width = 130;
            gridCrudUsuarios.Columns[4].Width = 100;
            gridCrudUsuarios.Columns[5].Width = 0;
            gridCrudUsuarios.Columns[6].Width = 130;
            gridCrudUsuarios.Columns[7].Width = 0;
            gridCrudUsuarios.Columns[8].Width = 0;
            gridCrudUsuarios.Columns[9].Width = 0;
            gridCrudUsuarios.Columns[10].Width = 0;
            gridCrudUsuarios.Columns[11].Width = 0;
            gridCrudUsuarios.Columns[12].Width = 0;
            gridCrudUsuarios.Columns[13].Width = 0;
            gridCrudUsuarios.Columns[14].Width = 0;
            gridCrudUsuarios.Columns[15].Width = 0;
            gridCrudUsuarios.Columns[16].Width = 200;
            gridCrudUsuarios.Columns[17].Width = 0;
            gridCrudUsuarios.Columns[0].HeaderText = "ID";
            gridCrudUsuarios.Columns[1].HeaderText = "ID Pessoa"; //
            gridCrudUsuarios.Columns[2].HeaderText = "ID Papel"; //
            gridCrudUsuarios.Columns[3].HeaderText = "Usuario";
            gridCrudUsuarios.Columns[4].HeaderText = "Senha";
            gridCrudUsuarios.Columns[5].HeaderText = "ID Papel";//
            gridCrudUsuarios.Columns[6].HeaderText = "Função";
            gridCrudUsuarios.Columns[16].HeaderText = "Nome Pessoa";
            gridCrudUsuarios.Columns[1].Visible = false;
            gridCrudUsuarios.Columns[2].Visible = false;
            gridCrudUsuarios.Columns[4].Visible = false;
            gridCrudUsuarios.Columns[5].Visible = false;
            gridCrudUsuarios.Columns[7].Visible = false;
            gridCrudUsuarios.Columns[8].Visible = false;
            gridCrudUsuarios.Columns[9].Visible = false;
            gridCrudUsuarios.Columns[10].Visible = false;
            gridCrudUsuarios.Columns[11].Visible = false;
            gridCrudUsuarios.Columns[12].Visible = false;
            gridCrudUsuarios.Columns[13].Visible = false;
            gridCrudUsuarios.Columns[14].Visible = false;
            gridCrudUsuarios.Columns[15].Visible = false;
            gridCrudUsuarios.Columns[17].Visible = false;

        }


        private void behaviorRefresh()
        {

            if (operationType == "updateData" && typeEdition == "search")
            {
                gridCrudUsuarios.Visible = true;
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                //   tabControlAssets.TabPages.Remove(tabPageFormulario);
                //   tabControlAssets.TabPages.Remove(tabPageOptListagem);
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
                gridCrudUsuarios.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                // tabControlAssets.TabPages.Remove(tabPageFormulario);
                //   tabControlAssets.TabPages.Remove(tabPageOptListagem);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                gridCrudUsuarios.ClearSelection();
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
                gridCrudUsuarios.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);

                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                gridCrudUsuarios.ClearSelection();
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
            gridCrudUsuarios.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            clearFieldsFormulario();
            enableFieldsFormulario();
            operationType = "newInsertion";

            txtBoxId.Enabled = false;
        }
        private void behaviorDel()
        {
            bttnDel.Enabled = true;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            controllerUsuarios.Excluir(Convert.ToInt32(gridCrudUsuarios.CurrentRow.Cells[0].Value));
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void behaviorSave()
        {
            string retiraEspacos = txtBoxUsuario.Text;
            string rem = retiraEspacos.Trim();

            if (txtBoxId.Text.Trim().Equals("") || txtBoxId.Text.Trim() == null)
            {
                if (operationType.Equals("newInsertion") && typeEdition.Equals("insert"))
                {
                    if (rem.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Inserção não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            txtBoxUsuario.Text = "";
                            txtBoxUsuario.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (rem.Length >= 3)
                    {
                       
                        controllerUsuarios.Salvar( txtBoxUsuario.Text, txtBoxSenha.Text, txtBoxIdPessoa.Text, txtBoxIdPapeis.Text);
                        if (controllerUsuarios.retornoPersistencia.Equals("NS"))
                        {
                            txtBoxUsuario.Focus();
                            txtBoxUsuario.Text = "";
                            MessageBox.Show("Operação Cancelada!", "Aviso" + Convert.ToString(controllerUsuarios.retornoPersistencia), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (controllerUsuarios.retornoPersistencia.Equals("S!"))
                        {

                            operationType = "newInsertion";
                            typeEdition = "insert";
                            acoesBehaviorSave();
                            MessageBox.Show("Registro Salvo Com Sucesso!" + Convert.ToString(controllerUsuarios.retornoPersistencia), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (controllerUsuarios.retornoPersistencia.Equals("S!!"))
                        {
                            acoesBehaviorSave();
                            MessageBox.Show("Dado Existente Salvo!" + Convert.ToString(controllerUsuarios.retornoPersistencia), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else if (!txtBoxId.Text.Trim().Equals("") || txtBoxId.Text.Trim() != null)
            {

                if (operationType.Equals("updateData") && typeEdition.Equals("insert"))
                {
                    if (rem.Length <= 3)
                    {

                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            txtBoxUsuario.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {

                            behaviorRefresh();
                        }

                    }
                    else if (rem.Length >= 3)
                    {


                        controllerUsuarios.Editar(Convert.ToInt32(txtBoxId.Text.Trim()), txtBoxUsuario.Text, txtBoxSenha.Text ,txtBoxIdPessoa.Text, txtBoxIdPapeis.Text);

                        if (controllerUsuarios.retornoPersistencia.Equals("AT"))
                        {

                            operationType = "";
                            typeEdition = "";
                            behaviorRefresh();

                            MessageBox.Show(" Resgistro Listado doi Editado !   \n    else if (operationType.Equals(updateData) && typeEdition.Equals(insert) ) ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else if (operationType.Equals("updateData") && typeEdition.Equals("search"))
                {
                    MessageBox.Show("Entrou onde eu esperava", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (rem.Length <= 3)
                    {

                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {

                            // txtBoxName.Text = "";
                            txtBoxUsuario.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {

                            behaviorRefresh();
                        }

                    }
                    else if (rem.Length >= 3)
                    {
                        controllerUsuarios.Editar(Convert.ToInt32(txtBoxId.Text.Trim()), txtBoxUsuario.Text, txtBoxSenha.Text, txtBoxIdPessoa.Text, txtBoxIdPapeis.Text);
                      
                        if (controllerUsuarios.retornoPersistencia.Equals("AT"))
                        {
                           
                            behaviorRefresh();
                            puxarparametroPesquisa();

                            MessageBox.Show("Registro Pesquisado foi Atualizado !  \n else if (operationType.Equals(search) && typeEdition.Equals(search))", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            gridCrudUsuarios.Visible = true;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            tabControlAssets.Visible = false;
            gridCrudUsuarios.Visible = true;
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
            gridCrudUsuarios.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);

            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
  

            enableFieldsFormulario();
            clearFieldsFormulario();

            txtBoxId.Text           = gridCrudUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtBoxUsuario.Text      = gridCrudUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtBoxSenha.Text        = gridCrudUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtBoxIdPapeis.Text     = gridCrudUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtBoxIdPessoa.Text     = gridCrudUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtBoxId.Enabled = false;
            carregarComplementosPapeis();
            carregarComplementosPessoas();

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
            gridCrudUsuarios.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Text = gridCrudUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtBoxUsuario.Text = gridCrudUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtBoxSenha.Text = gridCrudUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtBoxIdPapeis.Text = gridCrudUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtBoxIdPessoa.Text = gridCrudUsuarios.CurrentRow.Cells[1].Value.ToString();

            carregarComplementosPapeis();
            carregarComplementosPessoas();
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

            txtBoxId.Text  = gridCrudUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtBoxUsuario.Text = gridCrudUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtBoxSenha.Text = gridCrudUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtBoxIdPapeis.Text = gridCrudUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtBoxIdPessoa.Text = gridCrudUsuarios.CurrentRow.Cells[1].Value.ToString();
            carregarComplementosPapeis();
            carregarComplementosPessoas();
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
           
            txtBoxId.Text = gridCrudUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtBoxUsuario.Text = gridCrudUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtBoxSenha.Text = gridCrudUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtBoxIdPapeis.Text = gridCrudUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtBoxIdPessoa.Text = gridCrudUsuarios.CurrentRow.Cells[1].Value.ToString();
            carregarComplementosPapeis();
            carregarComplementosPessoas();
        }




        public void clearFieldsFormulario()
        {
            txtBoxId.Text = "";
            txtBoxUsuario.Text = "";
            txtBoxIdPapeis.Text = "";
            txtBoxIdPessoa.Text = "";
            txtNomePapel.Text = "";
            txtNomePessoa.Text = "";

            txtBoxUsuario.Text = "";
            txtBoxSenha.Text = "";

            ckCadastrar.Checked = false;
            ckPesquisar.Checked = false;
            ckEditar.Checked = false;
            ckDeletar.Checked = false;
            ckMenuOp.Checked = false;
            ckMenuAdmin.Checked = false;
            ckMenuGen.Checked = false;

        }
        public void disableFieldsFormulario() { txtBoxId.Enabled = false; txtBoxUsuario.Enabled = false; }
        public void enableFieldsFormulario() { txtBoxId.Enabled = true; txtBoxUsuario.Enabled = true; }
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
                  cbButtonPesquisarEm.SelectedIndex = 0;
                txtBoxPesquisar.Text = "";
                txtBoxPesquisar.Focus();
                radioBttnComeca.Checked = true;
                gridCrudUsuarios.DataSource = controllerUsuarios.PesquisarComecaCom("usuario", "@usuario", "");
              //  DataGridModel();
                typeEdition = "search";
                cbButtnQuantPage1.Visible = false;
                cbOrdemParam1.Visible = false;
                cbOrdenarPor1.Visible = false;
                toolStripLabel6.Visible = false;
                toolStripLabel7.Visible = false;
                // toolStripLabel8.Visible = false;
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
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
                txtBoxId.Text = "";
                typeEdition = "insert";


                cbButtnQuantPage1.Visible = true;
                cbOrdemParam1.Visible = true;
                cbOrdenarPor1.Visible = true;
                toolStripLabel6.Visible = true;
                toolStripLabel7.Visible = true;
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;

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
                //  tabControlAssets.TabPages.Remove(tabPageFormulario);
                //   tabControlAssets.TabPages.Remove(tabPageOptListagem);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
            }
            else
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                //tabControlAssets.TabPages.Remove(tabPageFormulario);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                //   tabControlAssets.TabPages.Remove(tabPageOptListagem);
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
            gridCrudUsuarios.DataSource = controllerUsuarios.PesquisarComecaCom("usuario", "@usuario", "");
            DataGridModel();
            toolStripLabel2.Text = Convert.ToString(controllerUsuarios.retornoQuantPesquisa());
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
            var gridVazia = gridCrudUsuarios.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia)){
            }

            else if (gridVazia.Length > 0)
            {
                if (typeEdition.Equals("insert") && operationType.Equals("newInsertion"))
                {

                    operationType = "newInsertion";
                    behaviorEdit();
                }
                else if (typeEdition.Equals("search") && operationType.Equals("updateData"))
                {
                    operationType = "updateData";
                    behaviorEditPesquisa();
                }


            }
        }

        private void gridCrudPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridVazia = gridCrudUsuarios.CurrentRow.Cells[0].Value.ToString();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            countBttnToggle++;
            if (countBttnToggle % 2 == 0)
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                //   tabControlAssets.TabPages.Remove(tabPageFormulario);
                //  tabControlAssets.TabPages.Remove(tabPageOptListagem);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnSearch.Enabled = false;
                bttnEdit.Enabled = false;
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                actBehaviorSerarch = true;
                cbButtonPesquisarEm.SelectedIndex = 0;
                radioBttnComeca.Checked = true;
                txtBoxPesquisar.Text = "";
      //          bttnTools.Enabled = false;
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
                gridCrudUsuarios.DataSource = controllerUsuarios.PesquisarComecaCom("usuario", "@usuario", "");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerUsuarios.retornoQuantPesquisa());
                operationType = "search";


            }
            else
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                //tabControlAssets.TabPages.Remove(tabPageFormulario);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                //  tabControlAssets.TabPages.Remove(tabPageOptListagem);

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
      //          bttnTools.Enabled = true;
                toolStripLabel1.Visible = false;
                toolStripLabel2.Visible = false;
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                typeEdition = "insert";
                operationType = "newInsertion";


            }
        }

        private void bttnRefresh_Click_2(object sender, EventArgs e)
        {
            behaviorRefresh();
            DataGridModel();
        }

        private void carregarComplementosPapeis() 
        {
            controllerUsuarios.retornoDadosPapeis(txtBoxIdPapeis.Text);
            txtNomePapel.Text = controllerUsuarios.pmc.Nomepapel;
            ckCadastrar.Checked = controllerUsuarios.pmc.Criar;
            ckEditar.Checked = controllerUsuarios.pmc.Atualizar;
            ckPesquisar.Checked = controllerUsuarios.pmc.Recuperar;
            ckDeletar.Checked = controllerUsuarios.pmc.Excluir;
            ckMenuOp.Checked = controllerUsuarios.pmc.Menuope;
            ckMenuAdmin.Checked = controllerUsuarios.pmc.Menuadmin;
            ckMenuGen.Checked = controllerUsuarios.pmc.Menugen;
        }

        private void carregarComplementosPessoas()
        {
            controllerUsuarios.retornoDadoPessoas(txtBoxIdPessoa.Text);
            txtNomePessoa.Text = controllerUsuarios.pec.Nomepessoa;
        }

        private void gridCrudPessoa_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var gridVazia = gridCrudUsuarios.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia))
            {

            }
            else if (gridVazia.Length > 0)
            {
                carregarComplementosPapeis();
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

        private void bttImportaPapel_Click(object sender, EventArgs e){
            ImportPapeisToUsuario imp = new ImportPapeisToUsuario();
            imp.ShowDialog();
            if (imp.AcaoDialogVO.Equals("Importou"))
            {
                txtBoxIdPapeis.Text = imp.IdPapeisVO;
                carregarComplementosPapeis();
            }
           

        }

        private void bttImportPessoa_Click(object sender, EventArgs e)
        {
            ImportPessoasToUsuario impPessoasToUsuario = new ImportPessoasToUsuario();
            impPessoasToUsuario.ShowDialog();
            
            if (impPessoasToUsuario.AcaoDialogVO.Equals("Importou"))
            {
                txtBoxIdPessoa.Text = impPessoasToUsuario.IdPessoasVO;
                carregarComplementosPessoas();
            }
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

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void toolStripComboBox3_Click(object sender, EventArgs e)
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

        private void radioBttnComeca_CheckedChanged_1(object sender, EventArgs e)
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

        private void formCrudUsuarios_Load(object sender, EventArgs e)
        {
            _InstanciaformCrudUsuarios = null;
            
        }

        private void formCrudUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            _InstanciaformCrudUsuarios = null;
        }

       
    }
  
}
