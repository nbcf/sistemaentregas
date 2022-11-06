using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sistema.Model;
using Sistema.Controller;


namespace Sistema.View
{
    public partial class PessoasView : Form
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



        private static PessoasView _InstanciaformCrudPessoas;
        public static PessoasView GetInstanciaformCrudPessoas()
        {
            if (_InstanciaformCrudPessoas == null)
            {
                _InstanciaformCrudPessoas = new PessoasView();
            }
            else if (_InstanciaformCrudPessoas != null) {

                MessageBox.Show("O Gerênciador de Pessoas já se encontra aberto!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return _InstanciaformCrudPessoas;

        }

        PessoasController controllerPessoa = new PessoasController();
        public PessoasView()
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

                    if (cbButtnQuantPage1.SelectedText == "Todos"){}
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
            quantidadeReg = Convert.ToInt32(controllerPessoa.ListarQtBDPessoaController());
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



        private void puxarparametroPesquisa() {

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
                    gridCrudPessoa.DataSource = controllerPessoa.PesquisarComecaCom("nomepessoa", "@nomepessoa", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerPessoa.ListarPesquisados());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudPessoa.DataSource = controllerPessoa.PesquisarContemCom("nomepessoa", "@nomepessoa", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerPessoa.ListarPesquisados());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudPessoa.DataSource = controllerPessoa.PesquisarTerminaCom("nomepessoa", "@nomepessoa", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerPessoa.ListarPesquisados());
                }
            }
        }

        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {
         //   MessageBox.Show("EnviaModelo");


            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudPessoa.DataSource = controllerPessoa.ConfiListagemDataGrid("idpessoa", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerPessoa.ListarQtBDPessoaController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudPessoa.DataSource = controllerPessoa.ConfiListagemDataGrid("idpessoa", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerPessoa.ListarQtBDPessoaController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudPessoa.DataSource = controllerPessoa.ConfiListagemDataGrid("nomepessoa", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerPessoa.ListarQtBDPessoaController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudPessoa.DataSource = controllerPessoa.ConfiListagemDataGrid("nomepessoa", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerPessoa.ListarQtBDPessoaController());
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
            gridCrudPessoa.Visible = true;
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
            txtBoxIdEndereco.Visible = false;
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
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");

            }
        }

        private void bttnSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void DataGridModel()
        {
            gridCrudPessoa.Columns[0].HeaderText = "ID";
            gridCrudPessoa.Columns[1].HeaderText = "Id Endereco";
            gridCrudPessoa.Columns[2].HeaderText = "PESSOA";
            gridCrudPessoa.Columns[3].HeaderText = "COMP.";
            gridCrudPessoa.Columns[4].HeaderText = "Id Endereco Join";
            gridCrudPessoa.Columns[5].HeaderText = "LOGRADOURO";
            gridCrudPessoa.Columns[6].HeaderText = "BAIRRO";
            gridCrudPessoa.Columns[7].HeaderText = "CIDADE";
            gridCrudPessoa.Columns[8].HeaderText = "UF";
            gridCrudPessoa.Columns[9].HeaderText = "CEP";

            gridCrudPessoa.Columns[0].Width = 50;
            gridCrudPessoa.Columns[1].Width = 0;
            gridCrudPessoa.Columns[2].Width = 150;// nome
            gridCrudPessoa.Columns[3].Width = 100;//complemento
            gridCrudPessoa.Columns[4].Width = 0;// join
            gridCrudPessoa.Columns[5].Width = 200;//logra
            gridCrudPessoa.Columns[6].Width = 200;// bairro
            gridCrudPessoa.Columns[7].Width = 200;// cidade
            gridCrudPessoa.Columns[8].Width = 70;// uf
            gridCrudPessoa.Columns[9].Width = 70;// cep
            gridCrudPessoa.Columns[1].Visible = false;
            gridCrudPessoa.Columns[4].Visible = false;

        }


        private void behaviorRefresh()
        {
            if (operationType == "updateData" && typeEdition == "search")
            {
                gridCrudPessoa.Visible = true;
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                bttnEdit.Enabled = true;
                bttnSave.Enabled = false;
                bttnSearch.Enabled = true;
                puxarparametroPesquisa();
                
            }
            else if (operationType == "" ||
                operationType == "newInsertion" || 
                operationType == "updateData" || 
                operationType == "search" && 
                typeEdition == "insert"){
                bttnDel.Enabled = false;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;
                radioBttnComeca.Checked = false;
                radioBttnContem.Checked = false;
                radioBttnTermina.Checked = false;
                gridCrudPessoa.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                gridCrudPessoa.ClearSelection();
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
            else if (operationType == "" || 
                operationType == "newInsertion" || 
                operationType == "updateData" || 
                operationType == "search" &&
                typeEdition == "search"){
                bttnDel.Enabled = false;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;
                radioBttnComeca.Checked = false;
                radioBttnContem.Checked = false;
                radioBttnTermina.Checked = false;
                gridCrudPessoa.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                gridCrudPessoa.ClearSelection();
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
        private void behaviorNewInsert(){
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
            gridCrudPessoa.Visible = false;
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
            if (operationType == "updateData" && typeEdition == "search")
            {
                controllerPessoa.Excluir(Convert.ToInt32(gridCrudPessoa.CurrentRow.Cells[0].Value));

                puxarparametroPesquisa();
                radioBttnComeca.Checked = true;
                bttnDel.Enabled = true;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;


                int tamanho_lista = gridCrudPessoa.RowCount;
                MessageBox.Show(tamanho_lista.ToString());
                if (tamanho_lista == 0)
                {
                    bttnDel.Enabled = false;
                    bttnEdit.Enabled = false;
                    bttnRefresh.Enabled = false;
                    bttnSearch.Enabled = true;
                }

            }
            else if (operationType == "" ||
                operationType == "newInsertion" ||
                operationType == "updateData" ||
                operationType == "search" &&
                typeEdition == "insert")
            {
                bttnDel.Enabled = true;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;
                controllerPessoa.Excluir(Convert.ToInt32(gridCrudPessoa.CurrentRow.Cells[0].Value));
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");


            }
            else if (operationType == "" ||
              operationType == "newInsertion" ||
              operationType == "updateData" ||
              operationType == "search" &&
              typeEdition == "search")
            {
                bttnDel.Enabled = true;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;
                controllerPessoa.Excluir(Convert.ToInt32(gridCrudPessoa.CurrentRow.Cells[0].Value));
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");

            }
        }

        private void behaviorSave(){
            string retiraEspacos = txtBoxName.Text;
            string rem = retiraEspacos.Trim();
            if (txtBoxId.Text.Trim().Equals("") || txtBoxId.Text.Trim() == null){
                if (operationType.Equals("newInsertion") && typeEdition.Equals("insert")){
                    if (rem.Length <= 3){ 
                        var resultado = MessageBox.Show("A Inserção não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        { 
                            txtBoxName.Text = "";
                            txtBoxName.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (rem.Length >= 3)
                    {
                      
                        controllerPessoa.Salvar(Convert.ToInt32(txtBoxIdEndereco.Text), txtBoxName.Text, txtComplemento.Text);
                        if ("NS".Equals(controllerPessoa.AcaoCrudPessoaDAO()))
                        {
                            txtBoxName.Focus();
                            txtBoxName.Text = "";
                         
                        }
                        else if ("S!".Equals(controllerPessoa.AcaoCrudPessoaDAO()))
                        {
                            operationType = "newInsertion"; 
                            typeEdition = "insert";
                            acoesBehaviorSave();
                        
                        }
                        else if ("S!!".Equals(controllerPessoa.AcaoCrudPessoaDAO()))
                        {
                            //bttnNew
                            acoesBehaviorSave();
                         
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

                            txtBoxName.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                           
                            behaviorRefresh();
                        }

                    }
                    else if (rem.Length >= 3)
                    {
                        controllerPessoa.Editar(Convert.ToInt32(txtBoxId.Text.Trim()), Convert.ToInt32(txtBoxIdEndereco.Text.Trim()),txtBoxName.Text, txtComplemento.Text);

                        if ("AT".Equals(controllerPessoa.AcaoCrudPessoaDAO())){
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
                            txtBoxName.Focus();
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
                        controllerPessoa.Editar(Convert.ToInt32(txtBoxId.Text.Trim()), Convert.ToInt32(txtBoxIdEndereco.Text), txtBoxName.Text, txtComplemento.Text);
                     
                        if ("AT".Equals(controllerPessoa.AcaoCrudPessoaDAO()))
                        {
                            behaviorRefresh();
                            puxarparametroPesquisa();

                        }
                    }
                  }
            }
        } 




        private void acoesBehaviorSave() {

            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            gridCrudPessoa.Visible = true;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            tabControlAssets.Visible = false;
            gridCrudPessoa.Visible = true;
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
            gridCrudPessoa.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Enabled = false;
            setaGridEmCampos();
        }

        private void behaviorEditPesquisa() {
            typeEdition = "search";
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = false;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = true;
            bttnNew.Enabled = false;
            gridCrudPessoa.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Enabled = false;
            setaGridEmCampos();
        }

    

        private void behaviorClickGrid() {

            if (operationType == "updateData" && typeEdition == "search")
            {
                bttnNew.Enabled = false;
                bttnDel.Enabled = true;
                bttnEdit.Enabled = true;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;

                radioBttnComeca.Checked = true;
                enableFieldsFormulario();
                clearFieldsFormulario();
                setaGridEmCampos();

            }
            else if (operationType == "" ||
                operationType == "newInsertion" ||
                operationType == "updateData" ||
                operationType == "search" &&
                typeEdition == "insert")
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
            else if (operationType == "" ||
                operationType == "newInsertion" ||
                operationType == "updateData" ||
                operationType == "search" &&
                typeEdition == "search")
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


            //bttnNew.Enabled             = false;
            //bttnDel.Enabled             = true;
            //bttnEdit.Enabled            = true;
            //bttnSearch.Enabled          = true;
            //bttnRefresh.Enabled         = true;
            //bttnSave.Enabled            = false;
            //radioBttnComeca.Checked     = false;
            //radioBttnContem.Checked     = false;
            //radioBttnTermina.Checked    = false;
            //enableFieldsFormulario();
            //clearFieldsFormulario();
            //setaGridEmCampos();

        }

        private void setaGridEmCampos()
        {
            txtBoxId.Text           =       gridCrudPessoa.CurrentRow.Cells[0].Value.ToString();
            txtBoxIdEndereco.Text   =       gridCrudPessoa.CurrentRow.Cells[1].Value.ToString();
            txtBoxName.Text         =       gridCrudPessoa.CurrentRow.Cells[2].Value.ToString();
            txtComplemento.Text     =       gridCrudPessoa.CurrentRow.Cells[3].Value.ToString();
            txtLogradouro.Text      =       gridCrudPessoa.CurrentRow.Cells[5].Value.ToString();
            txtBairro.Text          =       gridCrudPessoa.CurrentRow.Cells[6].Value.ToString();
            txtCidade.Text          =       gridCrudPessoa.CurrentRow.Cells[7].Value.ToString();
            txtUf.Text              =       gridCrudPessoa.CurrentRow.Cells[8].Value.ToString();
            txtCep.Text             =       gridCrudPessoa.CurrentRow.Cells[9].Value.ToString();
        }

        private void behaviorClickGridPesquisa()
        {
            bttnNew.Enabled             = false;
            bttnDel.Enabled             = true;
            bttnEdit.Enabled            = true;
            bttnSearch.Enabled          = true;
            bttnRefresh.Enabled         = false;
            bttnSave.Enabled            = false;
            enableFieldsFormulario();
            clearFieldsFormulario();
            setaGridEmCampos();
        }




        public void clearFieldsFormulario() { 
            txtBoxId.Text           = "";
            txtBoxIdEndereco.Text   = "";
            txtBoxName.Text         = "";
            txtComplemento.Text     = "";
            txtLogradouro.Text      = "";
            txtBairro.Text          = "";
            txtCidade.Text          = "";
            txtUf.Text              = "";
            txtCep.Text             = "";
        }
        public void disableFieldsFormulario() { txtBoxId.Enabled = false; txtBoxName.Enabled = false; }
        public void enableFieldsFormulario() { txtBoxId.Enabled = true; txtBoxName.Enabled = true; }
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
                txtBoxPesquisar.Text = "";
                txtBoxPesquisar.Focus();
                radioBttnComeca.Checked = true;
                gridCrudPessoa.DataSource = controllerPessoa.PesquisarComecaCom("nomepessoa", "@nomepessoa", "");
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
            if (countBttnToggle % 2 != 0){
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;

            }else{
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
            puxarparametro(0,Convert.ToInt32(cbButtnQuantPage1.SelectedItem) ,"Sim");
           
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

            var gridVazia = gridCrudPessoa.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia)) {
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

        private void button1_Click(object sender, EventArgs e)
        {
            ImportEnderecos impEnderecosToPessoas = new ImportEnderecos();
            impEnderecosToPessoas.ShowDialog();
            txtBoxIdEndereco.Text = impEnderecosToPessoas.strID;
            txtLogradouro.Text = impEnderecosToPessoas.strLogradouro;
            txtBairro.Text = impEnderecosToPessoas.strBairro;
            txtCidade.Text = impEnderecosToPessoas.strCidade;
            txtUf.Text = impEnderecosToPessoas.strUF;
            txtCep.Text = impEnderecosToPessoas.strCep;
            
        }


        private void gridCrudPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var gridVazia = gridCrudPessoa.CurrentRow.Cells[0].Value.ToString();
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

        private void PessoasView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _InstanciaformCrudPessoas = null;
        }
    }

}
