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
using Engines;

namespace Sistema.View
{
    public partial class OrigemView : Form
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

        private static OrigemView _InstanciaformCrudOrigem;
        public static OrigemView GetInstanciaformCrudOrigem()
        {
            if (_InstanciaformCrudOrigem == null)
            {
                _InstanciaformCrudOrigem = new OrigemView();
            }
            else if (_InstanciaformCrudOrigem != null)
            {

                MessageBox.Show("O Gerênciador de Origem de Encomendas já se encontra aberto!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return _InstanciaformCrudOrigem;

        }

        PerfilCrud perfilCrud = new PerfilCrud();

        OrigemController controllerOrigem = new OrigemController();
        public OrigemView()
        {
            InitializeComponent();

            carregarEstadoPadrao("CarregaPadraoIDTodosUltimos", 0);
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
            int pagina1 = Convert.ToInt32(lbTotalPaginas.Text);
            int pg = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
            if (memoria < pagina1 && finalPaginaBol == false)
            {
                deslocamento1 = paginaAtual + pg;
                paginarPesquisa = deslocamento1;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                memoria++;
                lbPaginas.Text = memoria.ToString();
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
                lbPaginas.Text = memoria.ToString();
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
            int pagina1 = Convert.ToInt32(lbTotalPaginas.Text);
            int pg = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
            if (memoria > 1 && memoria <= pagina1 && inicioPaginaBol == true)
            {
                deslocamento1 = deslocamento1 - pg;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                --memoria;
                lbPaginas.Text = Convert.ToString(memoria);
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
                lbPaginas.Text = Convert.ToString(memoria);
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
            int pagina1 = Convert.ToInt32(lbTotalPaginas.Text);
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
                    lbPaginas.Text = Convert.ToString(memoria);
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
            lbPaginas.Text = Convert.ToString(1);
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
            quantidadeReg = Convert.ToInt32(controllerOrigem.ListarTodosVeiculosBD());
            int jcbPaginas = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);

            resultado = quantidadeReg / jcbPaginas;
            int resto = quantidadeReg % jcbPaginas;
            if (resto >= 1)
            {
                lbTotalPaginas.Text = Convert.ToString(resultado + 1);
            }
            else if (resto == 0)
            {
                lbTotalPaginas.Text = Convert.ToString(resultado);
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


                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Origem"))
                {

                    gridCrudOrigem.DataSource = controllerOrigem.PesquisarComecaCom("nomeorigem", "@nomeorigem", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerOrigem.RetornoQuantPesquisa());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Origem"))
                {
                    gridCrudOrigem.DataSource = controllerOrigem.PesquisarContemCom("nomeorigem", "@nomeorigem", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerOrigem.RetornoQuantPesquisa());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Origem"))
                {
                    gridCrudOrigem.DataSource = controllerOrigem.PesquisarTerminaCom("nomeorigem", "@nomeorigem", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerOrigem.RetornoQuantPesquisa());
                }
            }
        }

        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {
            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudOrigem.DataSource = controllerOrigem.ListaDataGrid("idorigem", "desc", offset, limitt);
                DataGridModel();
                lbTotalRegEncontrados.Text = Convert.ToString(controllerOrigem.ListarTodosVeiculosBD());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudOrigem.DataSource = controllerOrigem.ListaDataGrid("idorigem", "asc", offset, limitt);
                DataGridModel();
                lbTotalRegEncontrados.Text = Convert.ToString(controllerOrigem.ListarTodosVeiculosBD());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudOrigem.DataSource = controllerOrigem.ListaDataGrid("nomeorigem", "desc", offset, limitt);
                DataGridModel();
                lbTotalRegEncontrados.Text = Convert.ToString(controllerOrigem.ListarTodosVeiculosBD());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudOrigem.DataSource = controllerOrigem.ListaDataGrid("nomeorigem", "asc", offset, limitt);
                DataGridModel();
                lbTotalRegEncontrados.Text = Convert.ToString(controllerOrigem.ListarTodosVeiculosBD());
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
            gridCrudOrigem.Visible = true;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            tabControlAssets.TabPages.Remove(tabPageFormulario);
            bttnBeginPages.Visible = true;
            bttnOnePageLeft.Visible = true;
            lbPaginas.Visible = true;
            toolStripLabel3.Visible = true;
            lbTotalPaginas.Visible = true;
            toolStripLabel5.Visible = true;
            lbTotalRegEncontrados.Visible = true;
            bttnOnePageRight.Visible = true;
            bttnEndPages.Visible = true;
            toolStripLabel1.Visible = false;
            toolStripLabel2.Visible = false;
            cbButtonPesquisarEm.SelectedIndex = 0;
            radioBttnComeca.Checked = true;
            clearFieldsFormulario();
            disableFieldsFormulario();

        }

        private void bttnTools_Click(object sender, EventArgs e){
            countBttnToggleTools++;
            if (countBttnToggleTools % 2 == 0){
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Remove(tabPageFormulario);
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                bttnSearch.Enabled = false;

            }else{
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Remove(tabPageFormulario);

                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSearch.Enabled = true;
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
            }
        }

        private void DataGridModel()
        {
            gridCrudOrigem.Columns[0].HeaderText = "ID";
            gridCrudOrigem.Columns[1].HeaderText = "Origem";
            gridCrudOrigem.Columns[2].HeaderText = "Cod. Origem";
            gridCrudOrigem.Columns[0].Width = 80;
            gridCrudOrigem.Columns[1].Width = 100;
            gridCrudOrigem.Columns[2].Width = 100;

        }


        private void behaviorRefresh()
        {

            if (operationType == "updateData" && typeEdition == "search")
            {
                gridCrudOrigem.Visible = true;
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Remove(tabPageFormulario);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnEdit.Enabled = true;
                bttnSave.Enabled = false;
                bttnSearch.Enabled = true;

                puxarparametroPesquisa();

            }
            else if (operationType == "" || operationType == "newInsertion" || operationType == "updateData" || operationType == "search" && typeEdition == "insert")
            {
                bttnDel.Enabled = false;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;

                bttnBeginPages.Visible = true;
                bttnOnePageLeft.Visible = true;
                lbPaginas.Visible = true;
                toolStripLabel3.Visible = true;
                lbTotalPaginas.Visible = true;
                toolStripLabel5.Visible = true;
                lbTotalRegEncontrados.Visible = true;
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
                gridCrudOrigem.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Remove(tabPageFormulario);
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                gridCrudOrigem.ClearSelection();
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
                lbPaginas.Visible = true;
                toolStripLabel3.Visible = true;
                lbTotalPaginas.Visible = true;
                toolStripLabel5.Visible = true;
                lbTotalRegEncontrados.Visible = true;
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
                gridCrudOrigem.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Remove(tabPageFormulario);
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                gridCrudOrigem.ClearSelection();
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
            lbPaginas.Visible = false;
            toolStripLabel3.Visible = false;
            lbTotalPaginas.Visible = false;
            toolStripLabel5.Visible = false;
            lbTotalRegEncontrados.Visible = false;
            bttnOnePageRight.Visible = false;
            bttnEndPages.Visible = false;
            toolStripLabel2.Visible = false;
            toolStripLabel4.Visible = false;
            cbButtnQuantPage1.Visible = false;
            toolStripLabel6.Visible = false;
            cbOrdemParam1.Visible = false;
            toolStripLabel7.Visible = false;
            toolStrip2.Visible = false;
            gridCrudOrigem.Visible = false;
            tabControlAssets.Visible = true;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            tabControlAssets.TabPages.Remove(tabPageFormulario);
            tabControlAssets.TabPages.Insert(0, tabPageFormulario);
            clearFieldsFormulario();
            enableFieldsFormulario();
            operationType = "newInsertion";
            txtBoxId.Enabled = false;
        }
        private void behaviorDel(){

            if (operationType == "updateData" && typeEdition == "search"){

                controllerOrigem.Excluir(Convert.ToInt32(gridCrudOrigem.CurrentRow.Cells[0].Value));
              
                if ("DEL".Equals(controllerOrigem.AcaoCrudController())){
                    bttnDel.Enabled = true;
                    bttnEdit.Enabled = false;
                    bttnSearch.Enabled = true;
                    bttnRefresh.Enabled = true;
                    bttnSave.Enabled = false;
                    bttnNew.Enabled = false;
                    puxarparametroPesquisa();
                    int tamanho_lista = gridCrudOrigem.RowCount;
                  
                    if (tamanho_lista == 0){
                        bttnDel.Enabled = false;
                        bttnEdit.Enabled = false;
                        bttnRefresh.Enabled = false;
                        bttnSearch.Enabled = true;
                        puxarparametroPesquisa();
                    }

                }else if ("NDEL".Equals(controllerOrigem.AcaoCrudController())){
                   
                }
            }else if (operationType == "" || operationType == "newInsertion" || operationType == "updateData" || operationType == "search" && typeEdition == "insert"){
               
                controllerOrigem.Excluir(Convert.ToInt32(gridCrudOrigem.CurrentRow.Cells[0].Value));
               

                if ("DEL".Equals(controllerOrigem.AcaoCrudController())){
                    bttnDel.Enabled = true;
                    bttnEdit.Enabled = false;
                    bttnSearch.Enabled = true;
                    bttnRefresh.Enabled = true;
                    bttnSave.Enabled = false;
                    bttnNew.Enabled = true;

                    puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                    clearFieldsFormulario();

                }else if ("NDEL".Equals(controllerOrigem.AcaoCrudController())){}

            }else if (operationType == "" || operationType == "newInsertion" || operationType == "updateData" || operationType == "search" && typeEdition == "search"){

                controllerOrigem.Excluir(Convert.ToInt32(gridCrudOrigem.CurrentRow.Cells[0].Value));

                if ("DEL".Equals(controllerOrigem.AcaoCrudController())) {
                    bttnDel.Enabled = true;
                    bttnEdit.Enabled = false;
                    bttnSearch.Enabled = true;
                    bttnRefresh.Enabled = true;
                    bttnSave.Enabled = false;
                    bttnNew.Enabled = true;
                    puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                    clearFieldsFormulario();

                }else if ("NDEL".Equals(controllerOrigem.AcaoCrudController())){

                }
            }
        }

        private void behaviorSave()
        {
            string retiraEspacos = txtBoxName.Text;
            string rem = retiraEspacos.Trim();

            if (txtBoxId.Text.Trim().Equals("") || txtBoxId.Text.Trim() == null)
            {
                if (operationType.Equals("newInsertion") && typeEdition.Equals("insert"))
                {
                    if (rem.Length <= 2)
                    {
                        var resultado = MessageBox.Show("A Inserção não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            clearFieldsFormulario();
                            txtBoxName.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (rem.Length >= 2)
                    {
                      
                        controllerOrigem.Salvar(txtBoxName.Text, txtBoxCodOrigem.Text);
                        if ("NS".Equals(controllerOrigem.AcaoCrudController()))
                        {
                            clearFieldsFormulario();
                            txtBoxName.Focus();
                            
                        }
                        else if ("S!".Equals(controllerOrigem.AcaoCrudController()))
                        {

                            operationType = "newInsertion";
                            typeEdition = "insert";
                            acoesBehaviorSave();
                            MessageBox.Show("Registro Salvo Com Sucesso!", "Aviso de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if ("S!!".Equals(controllerOrigem.AcaoCrudController()))
                        {
                            acoesBehaviorSave();
                            MessageBox.Show("Dado Existente Salvo!", "Aviso de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else if (!txtBoxId.Text.Trim().Equals("") || txtBoxId.Text.Trim() != null)
            {

                if (operationType.Equals("updateData") && typeEdition.Equals("insert"))
                {
                    if (rem.Length <= 2)
                    {

                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            txtBoxName.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }

                    }
                    else if (rem.Length >= 2)
                    {
                        controllerOrigem.Editar( txtBoxName.Text, txtBoxCodOrigem.Text, Convert.ToInt32(txtBoxId.Text.Trim()));

                        if ("AT".Equals(controllerOrigem.AcaoCrudController()))
                        {
                            behaviorRefresh();
                        }
                    }
                }
                else if (operationType.Equals("updateData") && typeEdition.Equals("search"))
                {
                  
                    if (rem.Length <= 2)
                    {

                        var resultado = MessageBox.Show(
                            "A Edição não alcançou o número mínimo de 2 caracteres.\n" +
                            "Para tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.",
                            "Aviso do Sistema",
                            MessageBoxButtons.YesNo, 
                            MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes){
                            clearFieldsFormulario();
                            txtBoxName.Focus();
                        }else if (resultado == DialogResult.No){
                            behaviorRefresh();
                        }

                    }else if (rem.Length >= 2){
                        controllerOrigem.Editar( txtBoxName.Text, txtBoxCodOrigem.Text, Convert.ToInt32(txtBoxId.Text.Trim()));
                     
                        if ("AT".Equals(controllerOrigem.AcaoCrudController())){
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
        //    bttnPrint.Enabled = false;
            gridCrudOrigem.Visible = true;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            tabControlAssets.Visible = false;
            gridCrudOrigem.Visible = true;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            tabControlAssets.TabPages.Remove(tabPageFormulario);
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
       //     bttnPrint.Enabled = false;
            gridCrudOrigem.Visible = false;
            tabControlAssets.Visible = true;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            tabControlAssets.TabPages.Remove(tabPageFormulario);
            tabControlAssets.TabPages.Insert(0, tabPageFormulario);
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Enabled = false;
            txtBoxId.Text = gridCrudOrigem.CurrentRow.Cells[0].Value.ToString();
            txtBoxName.Text = gridCrudOrigem.CurrentRow.Cells[1].Value.ToString();
            txtBoxCodOrigem.Text = gridCrudOrigem.CurrentRow.Cells[2].Value.ToString();
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
       //     bttnPrint.Enabled = false;
            gridCrudOrigem.Visible = false;
            tabControlAssets.Visible = true;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            tabControlAssets.TabPages.Remove(tabPageFormulario);
            tabControlAssets.TabPages.Insert(0, tabPageFormulario);
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Enabled = false;
            txtBoxId.Text = gridCrudOrigem.CurrentRow.Cells[0].Value.ToString();
            txtBoxName.Text = gridCrudOrigem.CurrentRow.Cells[1].Value.ToString();
            txtBoxCodOrigem.Text = gridCrudOrigem.CurrentRow.Cells[2].Value.ToString();
        }

        private void behaviorSearch()
        {
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = false;
            bttnSave.Enabled = false;
            bttnNew.Enabled = false;
       //     bttnPrint.Enabled = false;
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
        //    bttnPrint.Enabled = false;
 
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Text = gridCrudOrigem.CurrentRow.Cells[0].Value.ToString();
            txtBoxName.Text = gridCrudOrigem.CurrentRow.Cells[1].Value.ToString();
            txtBoxCodOrigem.Text = gridCrudOrigem.CurrentRow.Cells[2].Value.ToString();
        }
        private void behaviorClickGridPesquisa()
        {
            bttnNew.Enabled = false;
            bttnDel.Enabled = true;
            bttnEdit.Enabled = true;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = false;
            bttnSave.Enabled = false;
       //     bttnPrint.Enabled = false;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Text = gridCrudOrigem.CurrentRow.Cells[0].Value.ToString();
            txtBoxName.Text = gridCrudOrigem.CurrentRow.Cells[1].Value.ToString();
            txtBoxCodOrigem.Text = gridCrudOrigem.CurrentRow.Cells[2].Value.ToString();
        }




        public void clearFieldsFormulario() { txtBoxId.Text = ""; txtBoxName.Text = ""; txtBoxCodOrigem.Text = ""; }
        public void disableFieldsFormulario() { txtBoxId.Enabled = false; txtBoxName.Enabled = false; }
        public void enableFieldsFormulario() { txtBoxId.Enabled = true; txtBoxName.Enabled = true; }
        public void clearFieldsPesquisar() { txtBoxPesquisar.Text = ""; cbButtonPesquisarEm.SelectedValue = 0; }
        public void disableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }
        public void enableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }



        private void bttnSave_Click(object sender, EventArgs e){
            behaviorSave();
        }

        private void bttnNew_Click(object sender, EventArgs e){
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
                lbPaginas.Visible = false;
                toolStripLabel3.Visible = false;
                lbTotalPaginas.Visible = false;
                toolStripLabel5.Visible = false;
                lbTotalRegEncontrados.Visible = false;
                bttnOnePageRight.Visible = false;
                bttnEndPages.Visible = false;
                toolStripLabel1.Visible = true;
                toolStripLabel2.Visible = true;
                txtBoxPesquisar.Text = "";
                txtBoxPesquisar.Focus();
                gridCrudOrigem.DataSource = controllerOrigem.PesquisarComecaCom("nomeorigem", "@nomeorigem", "");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerOrigem.RetornoQuantPesquisa());
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
                lbPaginas.Visible = true;
                toolStripLabel3.Visible = true;
                lbTotalPaginas.Visible = true;
                toolStripLabel5.Visible = true;
                lbTotalRegEncontrados.Visible = true;
                bttnOnePageRight.Visible = true;
                bttnEndPages.Visible = true;
                toolStripLabel1.Visible = false;
                toolStripLabel2.Visible = true;

                cbButtnQuantPage1.Visible = true;
                cbOrdemParam1.Visible = true;
                cbOrdenarPor1.Visible = true;
                toolStripLabel6.Visible = true;
                toolStripLabel7.Visible = true;
                toolStripLabel4.Visible = true;

                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                txtBoxId.Text = "";
                typeEdition = "insert";
                
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
                tabControlAssets.TabPages.Remove(tabPageFormulario);
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                bttnSearch.Enabled = false;
            }
            else
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Remove(tabPageFormulario);
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
                tabControlAssets.TabPages.Remove(tabPageFormulario);
                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
            }
            else
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Remove(tabPageFormulario);
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

            var gridVazia = gridCrudOrigem.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia)){
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

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbOrdenarPor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

       
        private void cbButtonPesquisarEm_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void bttnImport_Click(object sender, EventArgs e)
        {
            this.gridCrudOrigem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string id;
            
            gridCrudOrigem.CurrentCell = gridCrudOrigem.Rows[0].Cells[0];  //gridCrudOrigem.SelectedRows[0];//Rows[gridCrudOrigem.Rows.Count - 1].Cells[0];
            id = gridCrudOrigem.CurrentRow.Cells[0].Value.ToString();                                                                //     this.gridCrudOrigem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //MessageBox.Show(id);
         }

     

        private void OrigemView_FormClosing(object sender, FormClosingEventArgs e)
        {
         //   behaviorRefresh();
            _InstanciaformCrudOrigem = null;
        }

      
        private void cbButtnQuantPage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbOrdemParam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbOrdenarPor1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbOrdemParam1_Click(object sender, EventArgs e)
        {

        }

        private void gridCrudOrigem_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            var gridVazia = gridCrudOrigem.CurrentRow.Cells[0].Value.ToString();
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

        private void bttnOnePageRight_Click_1(object sender, EventArgs e)
        {

        }

        private void bttnEndPages_Click_1(object sender, EventArgs e)
        {

        }
    }

}

