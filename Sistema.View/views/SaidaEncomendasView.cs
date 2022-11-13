using Sistema.Controller;
using Sistema.View.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View
{
    public partial class SaidaEncomendasView : Form 
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


        public System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        public System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

        private static SaidaEncomendasView _InstSaidaEncomendasView;
        public static SaidaEncomendasView GetInst()
        {
            if (_InstSaidaEncomendasView == null)
            {
                _InstSaidaEncomendasView = new SaidaEncomendasView();
            }
            else if (_InstSaidaEncomendasView != null)
            {

                MessageBox.Show("Janela já se encontra aberta!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return _InstSaidaEncomendasView;
        }
        public int posicaoTamanhoFonte = 1;

        EncomendasController controllerEncomendas = new EncomendasController();
        SaidasController controllerSaida = new SaidasController();
        VeiculosController veiculosController = new VeiculosController();


        public SaidaEncomendasView()
        {
            InitializeComponent();
            carregarEstadoPadrao("CarregaPadraoIDTodosUltimos", 0);
            toolStripButton4.Enabled = false;
        }


        private void puxarparametro(int deslocamento, int limiteregistro, string inicioDeslocamento)
        {

            string jcbOrdem = Convert.ToString(cbOrdemParam.SelectedItem);
            string ordem = "";
            if (Convert.ToString(cbOrdenarPor.SelectedItem).Equals("Primeiros"))
            {
                ordem = "primeiros";
            }
            else if (Convert.ToString(cbOrdenarPor.SelectedItem).Equals("Ultimos"))
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

                    if (cbButtnQuantPage1.SelectedText == "Todos") {
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

                    if (cbButtnQuantPage1.SelectedText == "Todos") {
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
                    gridCrudSaidas.DataSource = controllerSaida.PesquisarComecaCom("nomepessoa", "@nomepessoa", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerSaida.ListarPesquisaController());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudSaidas.DataSource = controllerSaida.PesquisarContemCom("nomepessoa", "@nomepessoa", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerSaida.ListarPesquisaController());
                }
                else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudSaidas.DataSource = controllerSaida.PesquisarTerminaCom("nomepessoa", "@nomepessoa", txtBoxPesquisar.Text);
                    DataGridModel();
                    toolStripLabel2.Text = Convert.ToString(controllerSaida.ListarPesquisaController());
                }
            }
        }

        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {
            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudSaidas.DataSource = controllerSaida.ListarSaidasGridController("idpessoa", cbEstatusSaida.SelectedItem.ToString(), "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerSaida.ListarBDSaidasController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudSaidas.DataSource = controllerSaida.ListarSaidasGridController("idpessoa", cbEstatusSaida.SelectedItem.ToString(), "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerSaida.ListarBDSaidasController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudSaidas.DataSource = controllerSaida.ListarSaidasGridController("nomepessoa", cbEstatusSaida.SelectedItem.ToString(), "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerSaida.ListarBDSaidasController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudSaidas.DataSource = controllerSaida.ListarSaidasGridController("nomepessoa", cbEstatusSaida.SelectedItem.ToString(), "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerSaida.ListarBDSaidasController());
                carregarInformacoes();
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
            quantidadeReg = Convert.ToInt32(controllerSaida.ListarBDSaidasController());
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



     
        public void carregarEstadoPadrao(string pesquisa, int offsett){
            cbEstatusSaida.SelectedIndex        = 0;
            cbButtnQuantPage1.SelectedIndex     = 0;
            cbEstatusSaida.SelectedIndex        = 0;
            int quantRegPage = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
            cbOrdenarPor.SelectedIndex          = 1;
            cbOrdemParam.SelectedIndex          = 0;
            resetarPonteiros();
            this.puxarparametro(0, quantRegPage, "Nao");
            bttnDel.Enabled                 = false;
            bttnSearch.Enabled              = true;
            bttnRefresh.Enabled             = true;
            bttnSave.Enabled                = false;
            bttnNew.Enabled                 = true;
            bttnImport.Enabled              = false;
            btnRotaConcluida.Enabled        = false;
            btnEmRota.Enabled               = false;
            bttnImport.Enabled              = false;
            radioBttnComeca.Checked         = false;
            radioBttnContem.Checked         = false;
            radioBttnTermina.Checked        = false;
            gridCrudSaidas.Visible          = true;
            tabControlAssets.Visible        = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled      = false;
            groupBoxFormulario.Visible      = false;
            groupBox1.Enabled               = false;
            groupBox1.Visible               = false;
            toolStrip2.Visible              = true;
            bttnBeginPages.Visible          = true;
            bttnOnePageLeft.Visible         = true;
            labelTextPageFrom.Visible       = true;
            toolStripLabel3.Visible         = true;
            labelTextTotalPages.Visible     = true;
            toolStripLabel5.Visible         = true;
            labelTextTotalRegFould.Visible  = true;
            bttnOnePageRight.Visible        = true;
            bttnEndPages.Visible            = true;
            tabControlAssets.Visible        = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            toolStripLabel1.Visible         = false;
            toolStripLabel2.Visible         = false;
            clearFieldsFormulario();
            disableFieldsFormulario();
            toolStrip2.Visible              = true;
            txtIdSaida.Enabled              = false;
            btnImportarEntregador.Enabled   = false;
            btnImportarVeiculo.Enabled      = false;
            btConfirmarRetorno.Enabled      = false;
            btConfirmarRetorno.Visible      = false;
            button5.Enabled                 = false;
            lbveiculo.Visible               = true;
            txtKmTotal.Visible              = false;

            lbTotalKm.Visible = false;
            lbFechamento.Visible = false;
            txtHoraRetorno.Visible = false;
            lbHoraSaida.Visible = false;
            txtHoraSaida.Visible = false;
            txtEstatusSaida.Visible = false;
            lbEstatus.Visible = false;

            datePckSaida.Value              = DateTime.Now;
            datePckRetorno.Value            = DateTime.Now;
            label4.Visible                  = true;
            txtIdSaida.Visible              = true;
            txtIdVeiculo.Visible            = false;
            label9.Visible                  = false;
            txtEstatuVeiculo.Visible        = false;
            label10.Visible                 = false;
            txtIdUsuario.Visible            = false;
            label11.Visible                 = false;
            txtIdPapel.Visible              = false;
            label13.Visible                 = false;
            txtIdPessoa.Visible             = false;
            btnCalcularKmTotal.Enabled      = false;
            btnCalcularKmTotal.Visible      = false;
            btConfirmarRetorno.Enabled      = false;
            btnDespesas.Enabled             = false;
            lbEstatus.Visible                 = false;
            txtEstatusSaida.Enabled         = false;
            txtEstatusSaida.Visible         = false;
            btnDespesas.Enabled = false;
            
        }

        private void bttnTools_Click(object sender, EventArgs e){
            countBttnToggleTools++;
            if (countBttnToggleTools % 2 == 0){
                tabControlAssets.Visible        = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnNew.Enabled                 = false;
                bttnRefresh.Enabled             = false;
                bttnSearch.Enabled              = false;

            }else{

                tabControlAssets.Visible        = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnNew.Enabled                 = true;
                bttnRefresh.Enabled             = true;
                bttnSearch.Enabled              = true;
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");

            }
        }

        private void DataGridModel(){
            gridCrudSaidas.Columns[0].HeaderText = "ID";
            gridCrudSaidas.Columns[1].HeaderText = "Id veiculo";
            gridCrudSaidas.Columns[2].HeaderText = "id usuario ";
            gridCrudSaidas.Columns[3].HeaderText = "id idpapel";
            gridCrudSaidas.Columns[4].HeaderText = "id idpessoa";
            gridCrudSaidas.Columns[5].HeaderText = "VEICULO";
            gridCrudSaidas.Columns[6].HeaderText = "PLACA";
            gridCrudSaidas.Columns[7].HeaderText = "ENTREGADOR";
            gridCrudSaidas.Columns[8].HeaderText = "SAÍDA";
            gridCrudSaidas.Columns[9].HeaderText = "REGRESSO";
            gridCrudSaidas.Columns[10].HeaderText = "HORA SAÍDA";
            gridCrudSaidas.Columns[11].HeaderText = "HORA REGRESSO";
            gridCrudSaidas.Columns[12].HeaderText = "ESTATUS";
            gridCrudSaidas.Columns[13].HeaderText = "REGIÃO";
            gridCrudSaidas.Columns[14].HeaderText = "KM SAÍDA";
            gridCrudSaidas.Columns[15].HeaderText = "KM REGRESSO";
            gridCrudSaidas.Columns[16].HeaderText = "KM TOTAL";
            gridCrudSaidas.Columns[17].HeaderText = "id usuario join 1";
            gridCrudSaidas.Columns[18].HeaderText = "id idpapel join 1";
            gridCrudSaidas.Columns[19].HeaderText = "id idpessoa join1";
            gridCrudSaidas.Columns[20].HeaderText = "usuario";
            gridCrudSaidas.Columns[21].HeaderText = "senha";
            gridCrudSaidas.Columns[22].HeaderText = "id idpapel join 2";
            gridCrudSaidas.Columns[23].HeaderText = "Funcao";
            gridCrudSaidas.Columns[24].HeaderText = "criar";
            gridCrudSaidas.Columns[25].HeaderText = "recuperar";
            gridCrudSaidas.Columns[26].HeaderText = "atualizar";
            gridCrudSaidas.Columns[27].HeaderText = "excluir";
            gridCrudSaidas.Columns[28].HeaderText = "menuope";
            gridCrudSaidas.Columns[29].HeaderText = "menuadmin";
            gridCrudSaidas.Columns[30].HeaderText = "menugen";
            gridCrudSaidas.Columns[31].HeaderText = "id idpessoa join 2";
            gridCrudSaidas.Columns[32].HeaderText = "id endereco";
            gridCrudSaidas.Columns[33].HeaderText = "Motorista";
            gridCrudSaidas.Columns[34].HeaderText = "complemento/ numero";
            gridCrudSaidas.Columns[35].HeaderText = "idveiculo join 1";
            gridCrudSaidas.Columns[36].HeaderText = "nome veiculo 1";
            gridCrudSaidas.Columns[37].HeaderText = "placa 1";
            gridCrudSaidas.Columns[38].HeaderText = "estatus veiculo";

            gridCrudSaidas.Columns[0].Width = 60;
            gridCrudSaidas.Columns[1].Width = 0;
            gridCrudSaidas.Columns[2].Width = 0;
            gridCrudSaidas.Columns[3].Width = 0;
            gridCrudSaidas.Columns[4].Width = 0;
            gridCrudSaidas.Columns[5].Width = 100;
            gridCrudSaidas.Columns[6].Width = 100;
            gridCrudSaidas.Columns[7].Width = 180;
            gridCrudSaidas.Columns[8].Width = 100;
            gridCrudSaidas.Columns[9].Width = 100;
            gridCrudSaidas.Columns[10].Width = 100;
            gridCrudSaidas.Columns[11].Width = 100;
            gridCrudSaidas.Columns[12].Width = 130;
            gridCrudSaidas.Columns[13].Width = 200;
            gridCrudSaidas.Columns[14].Width = 100;
            gridCrudSaidas.Columns[15].Width = 100;
            gridCrudSaidas.Columns[16].Width = 100;
            gridCrudSaidas.Columns[17].Width = 0;
            gridCrudSaidas.Columns[18].Width = 0;
            gridCrudSaidas.Columns[19].Width = 0;
            gridCrudSaidas.Columns[20].Width = 0;
            gridCrudSaidas.Columns[21].Width = 0;
            gridCrudSaidas.Columns[22].Width = 0;
            gridCrudSaidas.Columns[23].Width = 0;
            gridCrudSaidas.Columns[24].Width = 0;
            gridCrudSaidas.Columns[25].Width = 0;
            gridCrudSaidas.Columns[26].Width = 0;
            gridCrudSaidas.Columns[27].Width = 0;
            gridCrudSaidas.Columns[28].Width = 0;
            gridCrudSaidas.Columns[29].Width = 0;
            gridCrudSaidas.Columns[30].Width = 0;
            gridCrudSaidas.Columns[31].Width = 0;
            gridCrudSaidas.Columns[32].Width = 0;
            gridCrudSaidas.Columns[33].Width = 0;
            gridCrudSaidas.Columns[34].Width = 0;
            gridCrudSaidas.Columns[35].Width = 0;
            gridCrudSaidas.Columns[36].Width = 0;
            gridCrudSaidas.Columns[37].Width = 0;
            gridCrudSaidas.Columns[38].Width = 100;

            gridCrudSaidas.Columns[0].Visible = true;
            gridCrudSaidas.Columns[1].Visible = false;
            gridCrudSaidas.Columns[2].Visible = false;
            gridCrudSaidas.Columns[3].Visible = false;
            gridCrudSaidas.Columns[4].Visible = false;
            gridCrudSaidas.Columns[5].Visible = true;
            gridCrudSaidas.Columns[6].Visible = true;
            gridCrudSaidas.Columns[7].Visible = true;
            gridCrudSaidas.Columns[8].Visible = true;
            gridCrudSaidas.Columns[9].Visible = true;
            gridCrudSaidas.Columns[10].Visible = true;
            gridCrudSaidas.Columns[11].Visible = true;
            gridCrudSaidas.Columns[12].Visible = true;
            gridCrudSaidas.Columns[13].Visible = true;
            gridCrudSaidas.Columns[14].Visible = false;
            gridCrudSaidas.Columns[15].Visible = false;
            gridCrudSaidas.Columns[16].Visible = false;
            gridCrudSaidas.Columns[17].Visible = false;
            gridCrudSaidas.Columns[18].Visible = false;
            gridCrudSaidas.Columns[19].Visible = false;
            gridCrudSaidas.Columns[20].Visible = false;
            gridCrudSaidas.Columns[21].Visible = false;
            gridCrudSaidas.Columns[22].Visible = false;
            gridCrudSaidas.Columns[23].Visible = false;
            gridCrudSaidas.Columns[24].Visible = false;
            gridCrudSaidas.Columns[25].Visible = false;
            gridCrudSaidas.Columns[26].Visible = false;
            gridCrudSaidas.Columns[27].Visible = false;
            gridCrudSaidas.Columns[28].Visible = false;
            gridCrudSaidas.Columns[29].Visible = false;
            gridCrudSaidas.Columns[30].Visible = false;
            gridCrudSaidas.Columns[31].Visible = false;
            gridCrudSaidas.Columns[32].Visible = false;
            gridCrudSaidas.Columns[33].Visible = false;
            gridCrudSaidas.Columns[34].Visible = false;
            gridCrudSaidas.Columns[35].Visible = false;
            gridCrudSaidas.Columns[36].Visible = false;
            gridCrudSaidas.Columns[37].Visible = false;
            gridCrudSaidas.Columns[38].Visible = false;
        }


        public void DataGridModelDetalhe(){

            gridCurdMestreDetalhe.Columns[0].HeaderText = "ID";
            gridCurdMestreDetalhe.Columns[1].HeaderText = "ID Origem";
            gridCurdMestreDetalhe.Columns[2].HeaderText = "ID Veiculo"; 
            gridCurdMestreDetalhe.Columns[3].HeaderText = "ID Entregador";
            gridCurdMestreDetalhe.Columns[4].HeaderText = "Nome Veiculo";
            gridCurdMestreDetalhe.Columns[5].HeaderText = "Placa"; 
            gridCurdMestreDetalhe.Columns[6].HeaderText = "Entregador"; 
            gridCurdMestreDetalhe.Columns[7].HeaderText = "PESO"; 
            gridCurdMestreDetalhe.Columns[8].HeaderText = "NUM. ENCO.";
            gridCurdMestreDetalhe.Columns[9].HeaderText = "ESTATUS";
            gridCurdMestreDetalhe.Columns[10].HeaderText = "CPF";
            gridCurdMestreDetalhe.Columns[11].HeaderText = "DESTINATARIO";
            gridCurdMestreDetalhe.Columns[12].HeaderText = "LOGRADOURO";
            gridCurdMestreDetalhe.Columns[13].HeaderText = "COMPLEMENTO";
            gridCurdMestreDetalhe.Columns[14].HeaderText = "BAIRRO";
            gridCurdMestreDetalhe.Columns[15].HeaderText = "CIDADE";
            gridCurdMestreDetalhe.Columns[16].HeaderText = "UF";
            gridCurdMestreDetalhe.Columns[17].HeaderText = "CEP";
            gridCurdMestreDetalhe.Columns[18].HeaderText = "Data Entrega";
            gridCurdMestreDetalhe.Columns[19].HeaderText = "Data Rota";
            gridCurdMestreDetalhe.Columns[20].HeaderText = "Data Entrada";
            gridCurdMestreDetalhe.Columns[21].HeaderText = "IDSaida"; //
            gridCurdMestreDetalhe.Columns[22].HeaderText = "ID Origem Join 1";
            gridCurdMestreDetalhe.Columns[23].HeaderText = "ORIGEM";
            gridCurdMestreDetalhe.Columns[24].HeaderText = "CD. ORIGEM";

            gridCurdMestreDetalhe.Columns[1].Visible = false;
            gridCurdMestreDetalhe.Columns[2].Visible = false;
            gridCurdMestreDetalhe.Columns[3].Visible = false;
            gridCurdMestreDetalhe.Columns[21].Visible = false;
            gridCurdMestreDetalhe.Columns[22].Visible = false;
            gridCurdMestreDetalhe.Columns[23].Visible = false;
            gridCurdMestreDetalhe.Columns[24].Visible = false;
        }

        private void behaviorRefresh() {
            if (operationType == "updateData" && typeEdition == "search") {

                gridCrudSaidas.Visible = true;
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                toolStrip2.Visible = false;
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnSave.Enabled = false;
                bttnSearch.Enabled = true;
                btConfirmarRetorno.Enabled = false;
                btConfirmarRetorno.Visible = false;
                btnDespesas.Enabled = false;
                lbveiculo.Visible = true;

            } else if (operationType == ""          ||
                 operationType == "newInsertion"    ||
                 operationType == "updateData"      ||
                 operationType == "search"          &&
                 typeEdition == "insert"){
                btnDespesas.Enabled = false;
                bttnDel.Enabled             = false;
                bttnSearch.Enabled          = true;
                bttnRefresh.Enabled         = true;
                bttnSave.Enabled            = false;
                bttnNew.Enabled             = true;
                bttnImport.Enabled          = false;
                radioBttnComeca.Checked     = false;
                radioBttnContem.Checked     = false;
                radioBttnTermina.Checked    = false;
                gridCrudSaidas.Visible      = true;
                tabControlAssets.Visible    = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                datePckSaida.Value          = DateTime.Now;
                datePckRetorno.Value        = DateTime.Now;
                groupBoxFormulario.Enabled  = false;
                groupBoxFormulario.Visible  = false;
                toolStrip2.Visible          = true;
                btnEmRota.Enabled           = false;
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                txtEstatusSaida.Enabled         = false;
                btnEmRota.Enabled               = false;
                btnRotaConcluida.Enabled        = false;
                btnCalcularKmTotal.Enabled      = false;
                btnCalcularKmTotal.Visible      = false;
                lbveiculo.Visible                = true;
                txtKmTotal.Visible              = false;
              
                btConfirmarRetorno.Enabled      = false;
                btConfirmarRetorno.Visible      = false;
                btConfirmarRetorno.Enabled      = false;
                gridCrudSaidas.ClearSelection();

            } else if (operationType == ""          ||
                 operationType == "newInsertion"    ||
                 operationType == "updateData"      ||
                 operationType == "search"          &&
                 typeEdition == "search"){
                btnDespesas.Enabled = false;
                bttnDel.Enabled                 = false;
                bttnSearch.Enabled              = true;
                bttnRefresh.Enabled             = true;
                bttnSave.Enabled                = false;
                bttnNew.Enabled                 = true;
                bttnImport.Enabled              = false;
                btnEmRota.Enabled               = false;
                radioBttnComeca.Checked         = false;
                radioBttnContem.Checked         = false;
                radioBttnTermina.Checked        = false;
                gridCrudSaidas.Visible          = true;
                tabControlAssets.Visible        = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled      = false;
                groupBoxFormulario.Visible      = false;
                toolStrip2.Visible              = true;
                datePckSaida.Value              = DateTime.Now;
                datePckRetorno.Value            = DateTime.Now;
                clearFieldsFormulario();
                disableFieldsFormulario();
                txtEstatusSaida.Enabled         = false;
                btnEmRota.Enabled               = false;
                btnRotaConcluida.Enabled        = false;
                lbveiculo.Visible = true;
                txtKmTotal.Visible              = false;
                btnCalcularKmTotal.Enabled      = false;
                btnCalcularKmTotal.Visible      = false;
                btConfirmarRetorno.Enabled      = false;
                btConfirmarRetorno.Visible      = false;
                gridCrudSaidas.ClearSelection();
            }
        }

        private void behaviorNewInsert() {
            cbEstatusSaida.SelectedIndex        = 0;
            bttnDel.Enabled                     = false;
            bttnSearch.Enabled                  = false;
            bttnRefresh.Enabled                 = true;
            bttnSave.Enabled                    = true;
            bttnNew.Enabled                     = false;
            gridCrudSaidas.Visible              = false;
            tabControlAssets.Visible            = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            clearFieldsFormulario();
            enableFieldsFormulario();
            operationType = "newInsertion";
            txtIdSaida.Enabled                  = false;
            txtEstatusSaida.Text                = "Em Rota";
            toolStrip2.Visible                  = false;
            groupBoxFormulario.Enabled          = true;
            groupBoxFormulario.Visible          = true;
            txtEstatusSaida.Enabled             = false;
            btnImportarEntregador.Enabled       = true;
            btnImportarVeiculo.Enabled          = true;
            button5.Enabled                     = true;
            txtRegiaoEntrega.Text               = "";
            txtKmSaida.Text                     = "";
            datePckRetorno.Enabled              = false;
            txtRegiaoEntrega.Enabled            = true;
            txtKmSaida.Enabled                  = true;
            txtKmRetorno.Enabled                = false;

            lbdataRetorno.Visible = false;
            datePckRetorno.Visible = false;
            lbKmRetorno.Visible = false;
            txtKmRetorno.Visible = false;
            lbTotalKm.Visible = false;
            btnCalcularKmTotal.Visible = false;
            txtKmTotal.Visible = false;
            lbFechamento.Visible = false;
            txtHoraRetorno.Visible = false;

            txtKmTotal.Enabled                  = false;
            label4.Visible                      = true;
            txtIdVeiculo.Visible                = false;
            label9.Visible                      = false;
            txtEstatuVeiculo.Visible            = false;
            label10.Visible                     = false;
            txtIdUsuario.Visible                = false;
            label11.Visible                     = false;
            txtIdPapel.Visible                  = false;
            label13.Visible                     = false;
            txtIdPessoa.Visible                 = false;
            btConfirmarRetorno.Enabled          = false;
            btConfirmarRetorno.Visible          = false;
        }


        private void behaviorSave()
        {
            string retiraEspacosPlaca   =   txtPlacaVeiculo.Text;
            string retiraEntregador     =   txtPessoa.Text;
            string remEspacosPlaca      =   retiraEspacosPlaca.Trim();
            string remEntregador        =   retiraEntregador.Trim();

            if (remEspacosPlaca.Length < 3 || remEntregador.Length < 3) {

            } else {
                if (txtIdSaida.Text.Trim().Equals("") || txtIdSaida.Text.Trim() == null) {
                    if (operationType.Equals("newInsertion") && typeEdition.Equals("insert")) {
                        if (remEspacosPlaca.Length <= 3 && remEntregador.Length <= 3) {
                            var resultado = MessageBox.Show(
                                "A Inserção não alcançou o número mínimo de 3 caracteres.\n" +
                                "Para tentar novamente clique no botão 'Sim'. " +
                                "E no botão 'Não' para cancelar e sair do modo de Inserção.",
                                "Aviso do Sistema", 
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                            if (resultado == DialogResult.Yes) {

                            } else if (resultado == DialogResult.No) {
                                behaviorRefresh();
                            }
                        }
                        else if (remEspacosPlaca.Length >= 3 && remEntregador.Length >= 3)
                        {
                            bttnRefresh.Enabled = false;
                            bttnRefresh.Enabled = false;
                            controllerSaida.Salvar(Convert.ToInt32(txtIdVeiculo.Text),
                                                    Convert.ToInt32(txtIdUsuario.Text),
                                                    Convert.ToInt32(txtIdPapel.Text),
                                                    Convert.ToInt32(txtIdPessoa.Text),
                                                    txtVeiculo.Text,
                                                    txtPlacaVeiculo.Text,
                                                    txtPessoa.Text,
                                                    Convert.ToDateTime(DateTime.Today.ToString("dd/MM/yyyy")),
                                                    Convert.ToDateTime(DateTime.Today.ToString("dd/MM/yyyy")),
                                                    "",
                                                    "",
                                                    "Preparando",
                                                    txtRegiaoEntrega.Text,
                                                    txtKmSaida.Text,
                                                    txtKmRetorno.Text,
                                                    txtKmTotal.Text);

                            if ("NSP".Equals(controllerSaida.AcaoCrudSaidasController()))
                            {
                                txtIdVeiculo.Text = "";
                                txtVeiculo.Text = "";
                                txtPlacaVeiculo.Text = "";
                            }
                            else if ("NS".Equals(controllerSaida.AcaoCrudSaidasController()))
                            {
                                operationType = "newInsertion";
                                typeEdition = "insert";
                                acoesBehaviorSave();
                            }
                            else if ("S!".Equals(controllerSaida.AcaoCrudSaidasController()))
                            {
                                txtRegiaoEntrega.Enabled = true;
                                bttnImport.Enabled = true;
                                txtKmSaida.Enabled = true;
                                txtKmRetorno.Enabled = false;
                                txtKmTotal.Enabled = false;
                                var resultado = MessageBox.Show(
                               "Deseja dar entrada em uma saida agora?\n" +
                               "\nClique em 'Sim para adicionar itens e 'Não' para cancelar",
                                "Pergunda do sistema",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                                string id;
                                gridCrudSaidas.DataSource = controllerSaida.UltimoRegistro();
                                gridCrudSaidas.CurrentCell = gridCrudSaidas.Rows[0].Cells[0];
                                id = gridCrudSaidas.CurrentRow.Cells[0].Value.ToString();


                                if (resultado == DialogResult.Yes)
                                {
                                    bttnSave.Enabled = false;
                                    txtIdSaida.Text = id;
                                    groupBox1.Enabled = true;
                                    groupBox1.Visible = true;
                                    veiculosController.EditarEstatusVeiculo(
                                        txtVeiculo.Text, 
                                        txtPlacaVeiculo.Text,
                                        "Em Rota",
                                        Convert.ToInt32(txtIdVeiculo.Text));

                                } else if (resultado == DialogResult.No) {

                                    controllerSaida.Excluir(Convert.ToInt32(id));
                                    veiculosController.EditarEstatusVeiculo(
                                        txtVeiculo.Text,
                                        txtPlacaVeiculo.Text,
                                        "Disponivel", 
                                        Convert.ToInt32(txtIdVeiculo.Text));

                                    operationType = "newInsertion";
                                    typeEdition = "insert";
                                    behaviorRefresh();
                                }

                            } else if ("S!!".Equals(controllerSaida.AcaoCrudSaidasController())) {
                                acoesBehaviorSave();
                                MessageBox.Show(
                                    "Dado Existente Salvo!",
                                    "Aviso de Confirmação",
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                } else if (!txtIdSaida.Text.Trim().Equals("") || txtIdSaida.Text.Trim() != null) {
                    if (operationType.Equals("updateData") && typeEdition.Equals("insert")) {
                        if (remEspacosPlaca.Length <= 3 && remEntregador.Length <= 3) {

                            var resultado = MessageBox.Show(
                                "A Edição não alcançou o número mínimo de 3 caracteres.\n" +
                                "Para tentar novamente clique no botão 'Sim'. " +
                                "E no botão 'Não' para cancelar e sair do modo de Inserção.",
                                "Aviso do Sistema", 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question);

                            if (resultado == DialogResult.Yes) {
                            
                            }else if (resultado == DialogResult.No) {
                                behaviorRefresh();
                            }
                        }else if (remEspacosPlaca.Length >= 3 && remEntregador.Length >= 3){
                            if ("AT".Equals(controllerSaida.AcaoCrudSaidasController())){
                                behaviorRefresh();
                            }
                        }
                    }else if (operationType.Equals("updateData") && typeEdition.Equals("search")){
                        if (remEspacosPlaca.Length <= 3 && remEntregador.Length <= 3){

                            var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (resultado == DialogResult.Yes){
                            
                            }else if (resultado == DialogResult.No){
                                behaviorRefresh();
                            }

                        }else if (remEspacosPlaca.Length >= 3 && remEntregador.Length >= 3){

                            if ("AT".Equals(controllerSaida.AcaoCrudSaidasController())){
                                behaviorRefresh();
                                puxarparametroPesquisa();
                                MessageBox.Show("Registro Pesquisado foi Atualizado !  \n else if (operationType.Equals(search) && typeEdition.Equals(search))", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }

        private void acoesBehaviorSave(){
            bttnDel.Enabled             = false;
            bttnSearch.Enabled          = true;
            bttnRefresh.Enabled         = true;
            bttnSave.Enabled            = false;
            bttnNew.Enabled             = true;
            gridCrudSaidas.Visible      = true;
            radioBttnComeca.Checked     = false;
            radioBttnContem.Checked     = false;
            radioBttnTermina.Checked    = false;
            tabControlAssets.Visible    = false;
            gridCrudSaidas.Visible      = true;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled  = false;
            groupBoxFormulario.Visible  = false;
            toolStrip2.Visible          = true;
            clearFieldsFormulario();
            disableFieldsFormulario();
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
            txtEstatusSaida.Enabled     = false;
        }

        private void behaviorClickGrid(){
            bttnDel.Enabled             = true;
            bttnSearch.Enabled          = true;
            bttnRefresh.Enabled         = true;
            bttnSave.Enabled            = false;
            bttnNew.Enabled             = true;
            bttnImport.Enabled          = false;
            btnEmRota.Enabled           = true;
            radioBttnComeca.Checked     = false;
            radioBttnContem.Checked     = false;
            radioBttnTermina.Checked    = false;
            radioBttnComeca.Checked     = false;
            radioBttnContem.Checked     = false;
            radioBttnTermina.Checked    = false;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtIdSaida.Text             =   gridCrudSaidas.CurrentRow.Cells[0].Value.ToString();
            txtIdVeiculo.Text           =   gridCrudSaidas.CurrentRow.Cells[1].Value.ToString();
            txtIdUsuario.Text           =   gridCrudSaidas.CurrentRow.Cells[2].Value.ToString();
            txtIdPapel.Text             =   gridCrudSaidas.CurrentRow.Cells[3].Value.ToString();
            txtIdPessoa.Text            =   gridCrudSaidas.CurrentRow.Cells[4].Value.ToString();
            txtVeiculo.Text             =   gridCrudSaidas.CurrentRow.Cells[5].Value.ToString();
            txtPlacaVeiculo.Text        =   gridCrudSaidas.CurrentRow.Cells[6].Value.ToString();
            txtPessoa.Text              =   gridCrudSaidas.CurrentRow.Cells[7].Value.ToString();
            datePckSaida.Value          =   Convert.ToDateTime(gridCrudSaidas.CurrentRow.Cells[8].Value.ToString());
            txtEstatusSaida.Text        =   gridCrudSaidas.CurrentRow.Cells[12].Value.ToString();
            txtRegiaoEntrega.Text       =   gridCrudSaidas.CurrentRow.Cells[13].Value.ToString();
            txtKmSaida.Text             =   gridCrudSaidas.CurrentRow.Cells[14].Value.ToString();
            txtKmRetorno.Text           =   gridCrudSaidas.CurrentRow.Cells[15].Value.ToString();
            txtKmTotal.Text             =   gridCrudSaidas.CurrentRow.Cells[16].Value.ToString();
            setaGridEmCampos();

        }

        private void setaGridEmCampos(){

            txtIdSaida.Text         =   gridCrudSaidas.CurrentRow.Cells[0].Value.ToString();
            txtIdVeiculo.Text       =   gridCrudSaidas.CurrentRow.Cells[1].Value.ToString();
            txtIdUsuario.Text       =   gridCrudSaidas.CurrentRow.Cells[2].Value.ToString();
            txtIdPapel.Text         =   gridCrudSaidas.CurrentRow.Cells[3].Value.ToString();
            txtIdPessoa.Text        =   gridCrudSaidas.CurrentRow.Cells[4].Value.ToString();
            txtVeiculo.Text         =   gridCrudSaidas.CurrentRow.Cells[5].Value.ToString(); ;
            txtPlacaVeiculo.Text    =   gridCrudSaidas.CurrentRow.Cells[6].Value.ToString(); ;
            txtPessoa.Text          =   gridCrudSaidas.CurrentRow.Cells[7].Value.ToString();
            datePckSaida.Value      =   Convert.ToDateTime(gridCrudSaidas.CurrentRow.Cells[8].Value.ToString());
            txtEstatusSaida.Text    =   gridCrudSaidas.CurrentRow.Cells[12].Value.ToString();
            txtRegiaoEntrega.Text   =   gridCrudSaidas.CurrentRow.Cells[13].Value.ToString();
            txtKmSaida.Text         =   gridCrudSaidas.CurrentRow.Cells[14].Value.ToString();
            txtKmRetorno.Text       =   gridCrudSaidas.CurrentRow.Cells[15].Value.ToString();
            txtKmTotal.Text         =   gridCrudSaidas.CurrentRow.Cells[16].Value.ToString();
            txtEstatusSaida.Text    =   gridCrudSaidas.CurrentRow.Cells[12].Value.ToString();

            if (!String.IsNullOrEmpty(txtIdSaida.Text) || txtIdSaida.Text != ""){
                gridCurdMestreDetalhe.DataSource    =   controllerEncomendas.ListarDetalheMestre(txtIdSaida.Text, "Saiu para entrega");
                DataGridModelDetalhe();
                ListaView lista                     =   new ListaView();
                lista.IdSaidaVO                     =   txtIdSaida.Text;
                lista.ShowDialog();
            }
        }



        public void clearFieldsFormulario(){
            txtIdSaida.Text         = "";
            txtIdVeiculo.Text       = "";
            txtIdUsuario.Text       = "";
            txtIdPapel.Text         = "";
            txtIdPessoa.Text        = "";
            txtVeiculo.Text         = "";
            txtPlacaVeiculo.Text    = "";
            txtPessoa.Text          = "";
            datePckSaida.Value      = DateTime.Now;
            datePckRetorno.Value    = DateTime.Now;
            txtEstatusSaida.Text    = "";
            txtRegiaoEntrega.Text   = "";
            txtKmSaida.Text         = "";
            txtKmRetorno.Text       = "";
            txtKmTotal.Text         = "";
            txtHoraSaida.Text       = "";
            txtHoraRetorno.Text     = "";
        }

        public void disableFieldsFormulario() { txtIdSaida.Enabled = false; }

        public void enableFieldsFormulario(){
            txtIdSaida.Enabled = true;
        }

        public void clearFieldsPesquisar(){
            txtBoxPesquisar.Text = ""; cbButtonPesquisarEm.SelectedValue = 0;
        }

        public void disableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }
        public void enableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }

        private void bttnSave_Click(object sender, EventArgs e){
            if (txtVeiculo.Text.Length > 0 && txtPessoa.Text.Length > 0){
                behaviorSave();

            } else{}
        }

        private void bttnNew_Click(object sender, EventArgs e) {
            behaviorNewInsert();
        }

        private void bttnSearch_Click(object sender, EventArgs e){

            countBttnToggle++;
            if (countBttnToggle % 2 == 0){
                tabControlAssets.Visible        =  true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnNew.Enabled                 = false;
                bttnRefresh.Enabled             = false;
                actBehaviorSerarch              = true;
                cbButtonPesquisarEm.SelectedIndex = 0;
                radioBttnComeca.Checked         = true;
                txtBoxPesquisar.Text            = "";
                bttnBeginPages.Visible          = false;
                bttnOnePageLeft.Visible         = false;
                labelTextPageFrom.Visible       = false;
                toolStripLabel3.Visible         = false;
                labelTextTotalPages.Visible     = false;
                toolStripLabel5.Visible         = false;
                labelTextTotalRegFould.Visible  = false;
                bttnOnePageRight.Visible        = false;
                bttnEndPages.Visible            = false;
                toolStripLabel1.Visible         = true;
                toolStripLabel2.Visible         = true;
                txtBoxPesquisar.Text            = "";
                txtBoxPesquisar.Focus();
                txtBoxPesquisar.Text            = "";
                txtBoxPesquisar.Focus();
                radioBttnComeca.Checked         = true;
                gridCrudSaidas.DataSource       = controllerSaida.PesquisarComecaCom("nomepessoa", "@nomepessoa", "");
                DataGridModel();
                typeEdition                     = "search";
                cbButtnQuantPage1.Visible       = false;
                cbOrdemParam.Visible            = false;
                cbOrdenarPor.Visible            = false;
                cbEstatusSaida.Visible          = false;
                lbCbEstatusSaida.Visible        = false;
                toolStripLabel6.Visible         = false;
                toolStripLabel7.Visible         = false;
                toolStripLabel4.Visible         = false;
            
            }else{

                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnNew.Enabled                 = true;
                bttnRefresh.Enabled             = true;
                actBehaviorSerarch              = false;
                bttnBeginPages.Visible          = true;
                bttnOnePageLeft.Visible         = true;
                labelTextPageFrom.Visible       = true;
                toolStripLabel3.Visible         = true;
                labelTextTotalPages.Visible     = true;
                toolStripLabel5.Visible         = true; 
                labelTextTotalRegFould.Visible  = true;
                bttnOnePageRight.Visible        = true;
                bttnEndPages.Visible            = true;
                toolStripLabel1.Visible         = false;
                toolStripLabel2.Visible         = false;
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                txtIdSaida.Text                 = "";
                typeEdition                     = "insert";
                cbButtnQuantPage1.Visible       = true;
                cbOrdemParam.Visible            = true;
                cbOrdenarPor.Visible            = true;
                cbEstatusSaida.Visible          = true;
                lbCbEstatusSaida.Visible        = true;
                toolStripLabel6.Visible         = true;
                toolStripLabel7.Visible         = true;
                toolStripLabel4.Visible         = false;
            }
        }

        private void bttnRefresh_Click(object sender, EventArgs e){
            behaviorRefresh();
        }

        private void toolStripButton7_Click(object sender, EventArgs e){
            countBttnToggleTools++;
            if (countBttnToggleTools % 2 == 0){
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                bttnSearch.Enabled = false;

            }else{
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSearch.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e){
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

        private void bttnOnePageRight_Click(object sender, EventArgs e){
            somar();
        }

        private void bttnEndPages_Click(object sender, EventArgs e){
            finalDaPagina();
        }

        private void bttnOnePageLeft_Click(object sender, EventArgs e){
            descontar();
        }

        private void bttnBeginPages_Click(object sender, EventArgs e){
            inicioPagina();
        }

        private void cbButtnQuantPage_SelectedIndexChanged(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");

        }

        private void bttnSave_Click_1(object sender, EventArgs e){
            behaviorSave();
        }

        private void radBttnFirst_CheckedChanged(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void radBttnLast_CheckedChanged(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }


        private void bttnNew_Click_1(object sender, EventArgs e){
            behaviorNewInsert();
        }

        private void bttnRefresh_Click_1(object sender, EventArgs e){
            behaviorRefresh();
        }

        private void radioBttnContem_CheckedChanged(object sender, EventArgs e){
            puxarparametroPesquisa();
        }

        private void radioBttnTermina_CheckedChanged(object sender, EventArgs e){
            puxarparametroPesquisa();
        }

        private void radioBttnComeca_CheckedChanged(object sender, EventArgs e){
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_TextChanged(object sender, EventArgs e){
            puxarparametroPesquisa();
        }

    


        private void bttnDel_Click(object sender, EventArgs e){
            gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre(txtIdSaida.Text, "Saiu para entrega");
            DataGridModelDetalhe();
            
            int linhasDetalhes  =   gridCurdMestreDetalhe.RowCount;
            string veiculo      =   gridCrudSaidas.CurrentRow.Cells[5].Value.ToString();
            string placa        =   gridCrudSaidas.CurrentRow.Cells[6].Value.ToString();
            string entregador   =   gridCrudSaidas.CurrentRow.Cells[7].Value.ToString();
            int idsaida         =   Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[0].Value.ToString());
            string estatus      =   "Em Transito";


            if (linhasDetalhes > 0){

                int idorigem            =       Convert.ToInt32(gridCurdMestreDetalhe.CurrentRow.Cells[1].Value.ToString());
                int idVeiculo           =       Convert.ToInt32(gridCurdMestreDetalhe.CurrentRow.Cells[2].Value.ToString());
                int idEntregador        =       Convert.ToInt32(gridCurdMestreDetalhe.CurrentRow.Cells[3].Value.ToString());
                DateTime dataEntrega    =       Convert.ToDateTime(gridCurdMestreDetalhe.CurrentRow.Cells[18].Value);
                DateTime dataRota       =       Convert.ToDateTime(gridCurdMestreDetalhe.CurrentRow.Cells[19].Value);
                DateTime dataEntrada    =       Convert.ToDateTime(gridCurdMestreDetalhe.CurrentRow.Cells[20].Value);
                gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre(idsaida.ToString(), "Saiu para entrega");
                DataGridModelDetalhe();

                int linhasDetalhe = gridCurdMestreDetalhe.RowCount;
                for (int i = 1; i <= linhasDetalhe; i++){

                    string idDetalhe;
                    int ajustalinha = i - 1;
                    gridCurdMestreDetalhe.CurrentCell = gridCurdMestreDetalhe.Rows[ajustalinha].Cells[0];
                    idDetalhe = gridCurdMestreDetalhe.CurrentRow.Cells[0].Value.ToString();

                    controllerEncomendas.Editar(idorigem,
                                                0,
                                                0,
                                                "",
                                                "",
                                                "",
                                                gridCurdMestreDetalhe.CurrentRow.Cells[7].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[8].Value.ToString(),
                                                estatus,
                                                gridCurdMestreDetalhe.CurrentRow.Cells[10].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[11].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[12].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[13].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[14].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[15].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[16].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[17].Value.ToString(),
                                                DateTime.Now,
                                                DateTime.Now,
                                                dataEntrada,
                                                "000",
                                                Convert.ToInt32(idDetalhe));


                }

                veiculosController.EditarEstatusVeiculo(veiculo, placa, "Disponivel", Convert.ToInt32(idVeiculo));
                controllerSaida.Excluir(Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[0].Value.ToString()));
                gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre("000", "Saiu para entrega");
                DataGridModelDetalhe();
                behaviorRefresh();

            }else if (linhasDetalhes == 0){
                veiculosController.EditarEstatusVeiculo(veiculo, placa, "Disponivel", Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[1].Value.ToString()));
                controllerSaida.Excluir(Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[0].Value.ToString()));
                behaviorRefresh();
         
            }
        }
    

        private void cbButtonPesquisarEm_SelectedIndexChanged(object sender, EventArgs e){
            puxarparametroPesquisa();
        }

        private void cbOrdemParam_SelectedIndexChanged(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbOrdenarPor1_SelectedIndexChanged(object sender, EventArgs e){
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }


        private void button1_Click_1(object sender, EventArgs e){
            ImportVeiculoToSaidas importVeiculoToSaidas = new ImportVeiculoToSaidas();
            importVeiculoToSaidas.ShowDialog();
            txtIdVeiculo.Text       =   importVeiculoToSaidas.IdVO;
            txtVeiculo.Text         =   importVeiculoToSaidas.veiculoVO;
            txtPlacaVeiculo.Text    =   importVeiculoToSaidas.placaVO;
        }

        private void button2_Click_1(object sender, EventArgs e){
            ImportEntregadorToSaidas importEntregadorToSaidas = new ImportEntregadorToSaidas();
            importEntregadorToSaidas.ShowDialog();
            txtIdPessoa.Text = importEntregadorToSaidas.IdVO;
            txtPessoa.Text = importEntregadorToSaidas.nomeVO;

        }


        private void gridCrudSaidas_Click(object sender, EventArgs e){
            behaviorClickGrid();
        }

        private void button5_Click(object sender, EventArgs e){
            setaGridEmCampos();
        }



        private void bttnRefresh_Click_2(object sender, EventArgs e){
            if (String.IsNullOrEmpty(txtIdVeiculo.Text) || txtIdVeiculo.Text == ""){
                behaviorRefresh();

            } else if (!String.IsNullOrEmpty(txtIdVeiculo.Text) || txtIdVeiculo.Text != ""){
                veiculosController.EditarEstatusVeiculo(txtVeiculo.Text, txtPlacaVeiculo.Text, "Disponivel", Convert.ToInt32(txtIdVeiculo.Text));
                behaviorRefresh();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ImportEncomendasToSaida importEncomendaToSaidas = new ImportEncomendasToSaida();
            importEncomendaToSaidas.IdVeiculoVO = Convert.ToInt32(txtIdVeiculo.Text);
            importEncomendaToSaidas.IdEntregadorVO = Convert.ToInt32(txtIdUsuario.Text);
            importEncomendaToSaidas.NomeVeiculoVO = txtVeiculo.Text;
            importEncomendaToSaidas.PlacaVeiculoVO = txtPlacaVeiculo.Text;
            importEncomendaToSaidas.EntregadorVO = txtPessoa.Text;
            importEncomendaToSaidas.IdSaidaVO = txtIdSaida.Text;
            importEncomendaToSaidas.ShowDialog();
        }

        private void bttnImport_Click(object sender, EventArgs e)
        {
            ImportEncomendasToSaida importEncomendaToSaidas = new ImportEncomendasToSaida();
            importEncomendaToSaidas.IdVeiculoVO = Convert.ToInt32(txtIdVeiculo.Text);
            importEncomendaToSaidas.IdEntregadorVO = Convert.ToInt32(txtIdUsuario.Text);
            importEncomendaToSaidas.NomeVeiculoVO = txtVeiculo.Text;
            importEncomendaToSaidas.PlacaVeiculoVO = txtPlacaVeiculo.Text;
            importEncomendaToSaidas.EntregadorVO = txtPessoa.Text;
            importEncomendaToSaidas.IdSaidaVO = txtIdSaida.Text;
            importEncomendaToSaidas.DataEmRotaVO = datePckSaida.Value;
            importEncomendaToSaidas.DataEntradaVO = datePckRetorno.Value;
            importEncomendaToSaidas.DataEntregaVO = datePckRetorno.Value;
            importEncomendaToSaidas.ShowDialog();

            if (importEncomendaToSaidas.AcaoDialogVO == "Cancelar" && importEncomendaToSaidas.AcaoFormVO == "Fechar"){

            }else if (importEncomendaToSaidas.AcaoDialogVO == "Cancelar"){
            
            }else if (importEncomendaToSaidas.AcaoDialogVO == "Atualizar"){

                if (!String.IsNullOrEmpty(txtIdSaida.Text) || txtIdSaida.Text != ""){

                    gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre(txtIdSaida.Text, "Saiu para entrega");
                    DataGridModelDetalhe();
                    gridCurdMestreDetalhe.CurrentCell = gridCurdMestreDetalhe.Rows[0].Cells[0];

                    if (gridCurdMestreDetalhe.CurrentRow.Cells[0].Value.ToString().Length == 0){
                        btnEmRota.Enabled = false;
                        btnRotaConcluida.Enabled = false;

                    }else if (gridCurdMestreDetalhe.CurrentRow.Cells[0].Value.ToString().Length > 0){
                        btnEmRota.Enabled = true;
                        btnRotaConcluida.Enabled = false;
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtKmSaida.Text.Length < 3)
            {
                MessageBox.Show("Não preencheu o campo KmSaida ");
                //  "1".Equals(reader["Criar"]) ? true : false;
            }
            if (txtRegiaoEntrega.Text.Length < 3)
            {
                MessageBox.Show("Não preencheu o campo Regiao ");
            }


            if (txtKmSaida.Text.Length > 3 && txtRegiaoEntrega.Text.Length > 3)
            {
                gridCrudSaidas.DataSource   =   controllerSaida.UltimoRegistro();
                gridCrudSaidas.CurrentCell  =   gridCrudSaidas.Rows[0].Cells[0];
                txtIdSaida.Text             =   gridCrudSaidas.CurrentRow.Cells[0].Value.ToString();
                string strHoraSaida         =   DateTime.Now.ToString("HH:mm:ss");

                controllerSaida.Editar(
                   Convert.ToInt32(txtIdVeiculo.Text),
                   Convert.ToInt32(txtIdUsuario.Text),
                   Convert.ToInt32(txtIdPapel.Text),
                   Convert.ToInt32(txtIdPessoa.Text),
                   txtVeiculo.Text,
                   txtPlacaVeiculo.Text,
                   txtPessoa.Text,
                   Convert.ToDateTime(datePckSaida.Value.ToString()),
                   Convert.ToDateTime(datePckRetorno.Value.ToString()),
                   strHoraSaida,
                   "",
                   "Em Rota",
                   txtRegiaoEntrega.Text,
                   txtKmSaida.Text,
                   txtKmRetorno.Text,
                   txtKmTotal.Text,
                   Convert.ToInt32(txtIdSaida.Text));

                if ("AT".Equals(controllerSaida.AcaoCrudSaidasController())){
                    behaviorRefresh();
                    MessageBox.Show("Saida Conclúida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e){
            behaviorRefresh();
        }

        private void button1_Click_2(object sender, EventArgs e){

            ImportEncomendasToSaida importEncomendaToSaidas     =   new ImportEncomendasToSaida();
            importEncomendaToSaidas.IdVeiculoVO                 =   Convert.ToInt32(txtIdVeiculo.Text);
            importEncomendaToSaidas.IdEntregadorVO              =   Convert.ToInt32(txtIdUsuario.Text);
            importEncomendaToSaidas.NomeVeiculoVO               =   txtVeiculo.Text;
            importEncomendaToSaidas.PlacaVeiculoVO              =   txtPlacaVeiculo.Text;
            importEncomendaToSaidas.EntregadorVO                =   txtPessoa.Text;
            importEncomendaToSaidas.IdSaidaVO                   =   txtIdSaida.Text;
            importEncomendaToSaidas.ShowDialog();
            if (!String.IsNullOrEmpty(txtIdSaida.Text) || txtIdSaida.Text != ""){
                gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre(txtIdSaida.Text, "Saiu para entrega");
                DataGridModelDetalhe();
            }

        }

        private void button5_Click_1(object sender, EventArgs e){
            if (!String.IsNullOrEmpty(txtIdSaida.Text) || txtIdSaida.Text != ""){
                gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre(txtIdSaida.Text, "Saiu para entrega");
                DataGridModelDetalhe();
            }
        }

        private void button5_Click_2(object sender, EventArgs e){
            int linhasDetalhes = gridCurdMestreDetalhe.RowCount;


            if (linhasDetalhes > 0){

                var resultado = MessageBox.Show("Deseja dar entrada em uma saida agora?", "Pergunda do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes){

                    gridCrudSaidas.DataSource   =   controllerSaida.UltimoRegistro();
                    gridCrudSaidas.CurrentCell  =   gridCrudSaidas.Rows[0].Cells[0];

                    int linhas              =   gridCrudSaidas.RowCount;
                    int idorigem            =   Convert.ToInt32(gridCurdMestreDetalhe.CurrentRow.Cells[1].Value.ToString());
                    int idVeiculo           =   Convert.ToInt32(gridCurdMestreDetalhe.CurrentRow.Cells[2].Value.ToString());
                    int idEntregador        =   Convert.ToInt32(gridCurdMestreDetalhe.CurrentRow.Cells[3].Value.ToString());
                    string idDetalhe        =   gridCurdMestreDetalhe.CurrentRow.Cells[0].Value.ToString();
                    string veiculo          =   gridCrudSaidas.CurrentRow.Cells[5].Value.ToString();
                    string placa            =   gridCrudSaidas.CurrentRow.Cells[6].Value.ToString();
                    string entregador       =   gridCrudSaidas.CurrentRow.Cells[7].Value.ToString();
                    int idsaida             =   Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[0].Value.ToString());
                    string estatus          =   "Em Transito";
                    DateTime dataEntrega    =   Convert.ToDateTime(gridCurdMestreDetalhe.CurrentRow.Cells[18].Value);
                    DateTime dataRota       =   Convert.ToDateTime(gridCurdMestreDetalhe.CurrentRow.Cells[19].Value);
                    DateTime dataEntrada    =   Convert.ToDateTime(gridCurdMestreDetalhe.CurrentRow.Cells[20].Value);

                    controllerEncomendas.Editar(idorigem,
                                                0,
                                                0,
                                                "",
                                                "",
                                                "",
                                                gridCurdMestreDetalhe.CurrentRow.Cells[7].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[8].Value.ToString(),
                                                "Em Transito",
                                                gridCurdMestreDetalhe.CurrentRow.Cells[10].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[11].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[12].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[13].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[14].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[15].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[16].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[17].Value.ToString(),
                                                dataEntrega,
                                                dataRota,
                                                dataEntrada,
                                                "000",
                                                Convert.ToInt32(idDetalhe));
                                                gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre(txtIdSaida.Text, "Saiu para entrega");
                                                DataGridModelDetalhe();
                    }else if (resultado == DialogResult.No){}
                }else if (linhasDetalhes == 0){
                MessageBox.Show("Não há itens para remover");
                }
        }

                private void dataGridMestreDetalhe_CellClick(object sender, DataGridViewCellEventArgs e){

                }


        private void toolStripButton2_Click(object sender, EventArgs e){
            if ("Rota Concluída".Equals(txtEstatusSaida.Text = gridCrudSaidas.CurrentRow.Cells[12].Value.ToString())) {
                groupBoxFormulario.Enabled      =   true;
                groupBoxFormulario.Visible      =   true;
                datePckSaida.Enabled            =   false;
                txtKmTotal.Visible              =   true;

                lbTotalKm.Visible = true;
                lbFechamento.Visible = true;
                txtHoraRetorno.Visible = true;
                lbHoraSaida.Visible = true;
                txtHoraSaida.Visible = true;
                txtEstatusSaida.Visible = true;
                lbEstatus.Visible = true;
                lbdataRetorno.Visible = true;
                lbKmRetorno.Visible = true;
                lbTotalKm.Visible = true;
                btnRotaConcluida.Enabled = false;
                btnDespesas.Enabled = true;
                btnCalcularKmTotal.Visible      =   true;
                btnCalcularKmTotal.Enabled      =   true;
                txtKmSaida.Visible              =   true;
                txtKmSaida.Enabled              =   false;
                txtKmRetorno.Visible            =   true;
                txtKmRetorno.Enabled            =   true;
                datePckRetorno.Visible          =   true;
                datePckRetorno.Enabled          =   true;
                txtRegiaoEntrega.Enabled        =   false;
                int idsaida                     =   Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[0].Value.ToString());
                groupBoxFormulario.Visible      =   true;
                groupBox1.Visible               =   true;

                txtIdSaida.Text                 =   gridCrudSaidas.CurrentRow.Cells[0].Value.ToString();
                txtIdVeiculo.Text               =   gridCrudSaidas.CurrentRow.Cells[1].Value.ToString();
                txtIdUsuario.Text               =   gridCrudSaidas.CurrentRow.Cells[2].Value.ToString();
                txtIdPapel.Text                 =   gridCrudSaidas.CurrentRow.Cells[3].Value.ToString();
                txtIdPessoa.Text                =   gridCrudSaidas.CurrentRow.Cells[4].Value.ToString();
                txtVeiculo.Text                 =   gridCrudSaidas.CurrentRow.Cells[5].Value.ToString();
                txtPlacaVeiculo.Text            =   gridCrudSaidas.CurrentRow.Cells[6].Value.ToString();
                txtPessoa.Text                  =   gridCrudSaidas.CurrentRow.Cells[7].Value.ToString();
                datePckSaida.Value              =   Convert.ToDateTime(gridCrudSaidas.CurrentRow.Cells[8].Value.ToString());
                txtHoraSaida.Text               =   gridCrudSaidas.CurrentRow.Cells[10].Value.ToString();
                txtHoraRetorno.Text             =   gridCrudSaidas.CurrentRow.Cells[11].Value.ToString();
                txtEstatusSaida.Text            =   gridCrudSaidas.CurrentRow.Cells[12].Value.ToString();
                txtRegiaoEntrega.Text           =   gridCrudSaidas.CurrentRow.Cells[13].Value.ToString();
                txtKmSaida.Text                 =   gridCrudSaidas.CurrentRow.Cells[14].Value.ToString();
                txtKmRetorno.Text               =   gridCrudSaidas.CurrentRow.Cells[15].Value.ToString();
                txtKmTotal.Text                 =   gridCrudSaidas.CurrentRow.Cells[16].Value.ToString();
                btnCalcularKmTotal.Visible = true;
                btnCalcularKmTotal.Visible = true;
                bttnNew.Enabled = false;
                bttnSearch.Enabled = false;


            }
        }


        private void toolStripButton3_Click(object sender, EventArgs e){

            var resultadoRetorno = MessageBox.Show(
                                        "Deseja concluir a saida de rota ?",
                                        "Aviso do Sistema",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (resultadoRetorno == DialogResult.Yes){
                controllerSaida.Editar(
                Convert.ToInt32(txtIdVeiculo.Text),
                Convert.ToInt32(txtIdUsuario.Text),
                Convert.ToInt32(txtIdPapel.Text),
                Convert.ToInt32(txtIdPessoa.Text),
                txtVeiculo.Text,
                txtPlacaVeiculo.Text,
                txtPessoa.Text,
                Convert.ToDateTime(datePckSaida.Value.ToString("dd/MM/yyyy")),
                Convert.ToDateTime(datePckRetorno.Value.ToString("dd/MM/yyyy")),
                gridCrudSaidas.CurrentRow.Cells[10].Value.ToString(),
                DateTime.Now.ToString("HH:mm:ss"),
                "Concluida",
                txtRegiaoEntrega.Text,
                txtKmSaida.Text,
                txtKmRetorno.Text,
                txtKmTotal.Text,
                Convert.ToInt32(txtIdSaida.Text));
                veiculosController.EditarEstatusVeiculo(
                txtVeiculo.Text, 
                txtPlacaVeiculo.Text,
                "Disponivel", 
                Convert.ToInt32(txtIdVeiculo.Text));

                if ("AT".Equals(controllerSaida.AcaoCrudSaidasController())){
                    behaviorRefresh();
                    bttnNew.Enabled = true;
                    bttnSearch.Enabled = true;
                }

            }else if (resultadoRetorno == DialogResult.No){
                behaviorRefresh();
            }

            btConfirmarRetorno.Enabled = false;
            btConfirmarRetorno.Visible = false;
        }


        private void gridCrudSaidas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e){
            groupBoxFormulario.Visible = true;
            groupBox1.Visible = true;
            gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre(txtIdSaida.Text, "Saiu para entrega");
            DataGridModelDetalhe();
        }


        private void button1_Click(object sender, EventArgs e){
            if (String.IsNullOrEmpty(txtKmSaida.Text) == false
               && String.IsNullOrEmpty(txtKmRetorno.Text) == false){

                bool conteudoStringNuloOuVazio = String.IsNullOrEmpty(txtKmRetorno.Text);
                bool isNumeric = int.TryParse(txtKmRetorno.Text, out int n);

                if (conteudoStringNuloOuVazio == false){
                    txtEstatusSaida.Text = gridCrudSaidas.CurrentRow.Cells[12].Value.ToString();
                    int kmsaida = Convert.ToInt32(txtKmSaida.Text);
                    int kmretorno = Convert.ToInt32(txtKmRetorno.Text);

                    if (kmretorno - kmsaida <= 0){
                        MessageBox.Show("O KM do veículo no retorno não" +
                            " pode ser menor, ou igual, do que foi infromado na saída\n",
                            "Alerta do Sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }else if (kmretorno - kmsaida > 0){
                        var escolhaTotalizar = MessageBox.Show("Confirma a kilometragem de retorno?",
                            "Aviso do Sistema",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (escolhaTotalizar == DialogResult.Yes){

                            int kmtotal = kmretorno - kmsaida;
                            txtKmTotal.Text = Convert.ToString(kmtotal);
                            btConfirmarRetorno.Enabled = true;
                            btConfirmarRetorno.Visible = true;

                        }else if (escolhaTotalizar == DialogResult.No){}
                    }
                }else if (conteudoStringNuloOuVazio == true) {
                        MessageBox.Show("O Campo 'Km Retorno' não pode estar vazio para que seja contabilizado o km total",
                                        "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

  

        private void txtKmSaida_KeyPress(object sender, KeyPressEventArgs e){
            
        if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back)){
                e.Handled = true;
            }
        }

        private void txtKmRetorno_KeyPress(object sender, KeyPressEventArgs e){
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back)){
                e.Handled = true;
            }
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e){
            int linhasDetalhes = gridCurdMestreDetalhe.RowCount;
            MessageBox.Show(linhasDetalhes.ToString());

            if (linhasDetalhes > 0){
                int linhas = gridCrudSaidas.RowCount;

                int idorigem            =   Convert.ToInt32(gridCurdMestreDetalhe.CurrentRow.Cells[1].Value.ToString());
                int idVeiculo           =   Convert.ToInt32(gridCurdMestreDetalhe.CurrentRow.Cells[2].Value.ToString());
                int idEntregador        =   Convert.ToInt32(gridCurdMestreDetalhe.CurrentRow.Cells[3].Value.ToString());
                string veiculo          =   gridCrudSaidas.CurrentRow.Cells[5].Value.ToString();
                string placa            =   gridCrudSaidas.CurrentRow.Cells[6].Value.ToString();
                string entregador       =   gridCrudSaidas.CurrentRow.Cells[7].Value.ToString();
                int idsaida             =   Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[0].Value.ToString());
                string estatus          =   "Em Transito";
                DateTime dataEntrega    =   Convert.ToDateTime(gridCurdMestreDetalhe.CurrentRow.Cells[18].Value);
                DateTime dataRota       =   Convert.ToDateTime(gridCurdMestreDetalhe.CurrentRow.Cells[19].Value);
                DateTime dataEntrada    =   Convert.ToDateTime(gridCurdMestreDetalhe.CurrentRow.Cells[20].Value);
                gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre(idsaida.ToString(), "Saiu para entrega");
                DataGridModelDetalhe();
                
                int linhasDetalhe = gridCurdMestreDetalhe.RowCount;
                for (int i = 1; i <= linhasDetalhe; i++){

                    string idDetalhe;
                    int ajustalinha = i - 1;
                    gridCurdMestreDetalhe.CurrentCell = gridCurdMestreDetalhe.Rows[ajustalinha].Cells[0];
                    idDetalhe = gridCurdMestreDetalhe.CurrentRow.Cells[0].Value.ToString();
   
                    
                    controllerEncomendas.Editar(idorigem,
                                                0,
                                                0,
                                                "",
                                                "",
                                                "",
                                                gridCurdMestreDetalhe.CurrentRow.Cells[7].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[8].Value.ToString(),
                                                estatus,
                                                gridCurdMestreDetalhe.CurrentRow.Cells[10].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[11].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[12].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[13].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[14].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[15].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[16].Value.ToString(),
                                                gridCurdMestreDetalhe.CurrentRow.Cells[17].Value.ToString(),
                                                DateTime.Now,
                                                DateTime.Now,
                                                dataEntrada,
                                                "000",
                                                Convert.ToInt32(idDetalhe));
                 

                }
                veiculosController.EditarEstatusVeiculo(veiculo, placa, "Disponivel", Convert.ToInt32(idVeiculo));
                controllerSaida.Excluir(Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[0].Value.ToString()));
                gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre("000", "Saiu para entrega");
                DataGridModelDetalhe();
                behaviorRefresh();
            }
            else if (linhasDetalhes == 0)
            {
                veiculosController.EditarEstatusVeiculo(gridCrudSaidas.CurrentRow.Cells[5].Value.ToString(), gridCrudSaidas.CurrentRow.Cells[6].Value.ToString(), "Disponivel", Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[0].Value.ToString()));
                controllerSaida.Excluir(Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[0].Value.ToString()));

                behaviorRefresh();

            }
        }

        private void gridCrudSaidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int tamanhoGridSaidas = gridCrudSaidas.Rows.Count;
            var gridVazia = gridCrudSaidas.CurrentRow.Cells[0].Value.ToString();

            if (tamanhoGridSaidas == 0){
                bttnDel.Enabled = false;
                bttnNew.Enabled = false;

            }else if (tamanhoGridSaidas > 0) {

                if (gridCrudSaidas.CurrentRow.Cells[12].Value.ToString().Equals("Rota Concluída"))
                {

                    btConfirmarRetorno.Enabled = true;
                    btnRotaConcluida.Enabled = true;
                    bttnDel.Enabled = false;

                }
                
                else if (gridCrudSaidas.CurrentRow.Cells[12].Value.ToString().Equals("Em Rota")){
                }else if (gridCrudSaidas.CurrentRow.Cells[12].Value.ToString().Equals("Preparando")){

                    btConfirmarRetorno.Enabled = false;
                    bttnDel.Enabled = true;
                    btnRotaConcluida.Enabled = false;
                    toolStripButton4.Enabled = true;
                    bttnDel.Enabled = true;
                    datePckRetorno.Enabled = false;
                    txtIdSaida.Text         =   gridCrudSaidas.CurrentRow.Cells[0].Value.ToString();
                    txtIdVeiculo.Text       =   gridCrudSaidas.CurrentRow.Cells[1].Value.ToString();
                    txtIdUsuario.Text       =   gridCrudSaidas.CurrentRow.Cells[2].Value.ToString();
                    txtIdPapel.Text         =   gridCrudSaidas.CurrentRow.Cells[3].Value.ToString();
                    txtIdPessoa.Text        =   gridCrudSaidas.CurrentRow.Cells[4].Value.ToString();
                    txtVeiculo.Text         =   gridCrudSaidas.CurrentRow.Cells[5].Value.ToString(); ;
                    txtPlacaVeiculo.Text    =   gridCrudSaidas.CurrentRow.Cells[6].Value.ToString(); ;
                    txtPessoa.Text          =   gridCrudSaidas.CurrentRow.Cells[7].Value.ToString();
                    datePckSaida.Value      =   Convert.ToDateTime(gridCrudSaidas.CurrentRow.Cells[8].Value.ToString());
                    txtEstatusSaida.Text    =   gridCrudSaidas.CurrentRow.Cells[12].Value.ToString();
                    txtRegiaoEntrega.Text   =   gridCrudSaidas.CurrentRow.Cells[13].Value.ToString();
                    txtKmSaida.Text         =   gridCrudSaidas.CurrentRow.Cells[14].Value.ToString();
                    txtKmRetorno.Text       =   gridCrudSaidas.CurrentRow.Cells[15].Value.ToString();
                    txtKmTotal.Text         =   gridCrudSaidas.CurrentRow.Cells[16].Value.ToString();
                    txtEstatusSaida.Text    =   gridCrudSaidas.CurrentRow.Cells[12].Value.ToString();
                    gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre(txtIdSaida.Text, "Saiu para entrega");
                    DataGridModelDetalhe();
                }
            }
       }
            

        private void SaidaEncomendasView_FormClosing(object sender, FormClosingEventArgs e){
            _InstSaidaEncomendasView = null;
        }


        private void toolStripComboBox1_SelectedIndexChanged_1(object sender, EventArgs e){

            int qtLinhasSaidas  =   gridCrudSaidas.RowCount;
            int qtLinhasMD      =   gridCurdMestreDetalhe.RowCount;

            if (cbEstatusSaida.SelectedItem.Equals("Preparando")){

                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                toolStripButton4.Enabled = true;
                bttnNew.Enabled = true;
                bttnSearch.Enabled = true;

            }else if (cbEstatusSaida.SelectedItem.Equals("Rota Concluída")){
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                btnCalcularKmTotal.Visible = true;
                bttnNew.Enabled = false;
                bttnSearch.Enabled = false;
            } else {
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                toolStripButton4.Enabled = false;

            }      

           

        }


        private void gridCrudSaidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e){
            if (cbEstatusSaida.SelectedItem.ToString().Equals("Rota Concluída")){
                //toolStrip2.Visible          =   false;
                //groupBoxFormulario.Enabled  =   true;
                //groupBoxFormulario.Visible  =   true;
                //txtEstatusSaida.Enabled     =   false;
                //datePckSaida.Enabled        =   false;
                //datePckRetorno.Enabled      =   true;
                //txtKmRetorno.Enabled        =   true;
                //txtKmSaida.Enabled          =   false;
                //lbveiculo.Visible           =   true;
                //txtKmTotal.Visible          =   true;

                //lbTotalKm.Visible = true;
                //lbFechamento.Visible = true;
                //txtHoraRetorno.Visible = true;
                //lbHoraSaida.Visible = true;
                //txtHoraSaida.Visible = true;
                //txtEstatusSaida.Visible = true;
                //lbEstatus.Visible = true;

                //txtRegiaoEntrega.Enabled    =   false;
                //txtIdSaida.Text             =   gridCrudSaidas.CurrentRow.Cells[0].Value.ToString();
                //txtIdVeiculo.Text           =   gridCrudSaidas.CurrentRow.Cells[1].Value.ToString();
                //txtIdUsuario.Text           =   gridCrudSaidas.CurrentRow.Cells[2].Value.ToString();
                //txtIdPapel.Text             =   gridCrudSaidas.CurrentRow.Cells[3].Value.ToString();
                //txtIdPessoa.Text            =   gridCrudSaidas.CurrentRow.Cells[4].Value.ToString();
                //txtVeiculo.Text             =   gridCrudSaidas.CurrentRow.Cells[5].Value.ToString();
                //txtPlacaVeiculo.Text        =   gridCrudSaidas.CurrentRow.Cells[6].Value.ToString();
                //txtPessoa.Text              =   gridCrudSaidas.CurrentRow.Cells[7].Value.ToString();
                //datePckSaida.Value          =   Convert.ToDateTime(gridCrudSaidas.CurrentRow.Cells[8].Value.ToString());
                //txtHoraSaida.Text           =   gridCrudSaidas.CurrentRow.Cells[10].Value.ToString();
                //txtHoraRetorno.Text         =   gridCrudSaidas.CurrentRow.Cells[11].Value.ToString();
                //txtEstatusSaida.Text        =   gridCrudSaidas.CurrentRow.Cells[12].Value.ToString();
                //txtRegiaoEntrega.Text       =   gridCrudSaidas.CurrentRow.Cells[13].Value.ToString();
                //txtKmSaida.Text             =   gridCrudSaidas.CurrentRow.Cells[14].Value.ToString();
                //txtKmRetorno.Text           =   gridCrudSaidas.CurrentRow.Cells[15].Value.ToString();
                //txtKmTotal.Text             =   gridCrudSaidas.CurrentRow.Cells[16].Value.ToString();


                groupBoxFormulario.Enabled = true;
                groupBoxFormulario.Visible = true;
                datePckSaida.Enabled = false;
                txtKmTotal.Visible = true;

                lbTotalKm.Visible = true;
                lbFechamento.Visible = true;
                txtHoraRetorno.Visible = true;
                lbHoraSaida.Visible = true;
                txtHoraSaida.Visible = true;
                txtEstatusSaida.Visible = true;
                lbEstatus.Visible = true;
                lbdataRetorno.Visible = true;
                lbKmRetorno.Visible = true;
                lbTotalKm.Visible = true;
                btnRotaConcluida.Enabled = false;
                btnDespesas.Enabled = true;
                btnCalcularKmTotal.Visible = true;
                btnCalcularKmTotal.Enabled = true;
                txtKmSaida.Visible = true;
                txtKmSaida.Enabled = false;
                txtKmRetorno.Visible = true;
                txtKmRetorno.Enabled = true;
                datePckRetorno.Visible = true;
                datePckRetorno.Enabled = true;
                txtRegiaoEntrega.Enabled = false;
                int idsaida = Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[0].Value.ToString());
                groupBoxFormulario.Visible = true;
                groupBox1.Visible = true;

                txtIdSaida.Text = gridCrudSaidas.CurrentRow.Cells[0].Value.ToString();
                txtIdVeiculo.Text = gridCrudSaidas.CurrentRow.Cells[1].Value.ToString();
                txtIdUsuario.Text = gridCrudSaidas.CurrentRow.Cells[2].Value.ToString();
                txtIdPapel.Text = gridCrudSaidas.CurrentRow.Cells[3].Value.ToString();
                txtIdPessoa.Text = gridCrudSaidas.CurrentRow.Cells[4].Value.ToString();
                txtVeiculo.Text = gridCrudSaidas.CurrentRow.Cells[5].Value.ToString();
                txtPlacaVeiculo.Text = gridCrudSaidas.CurrentRow.Cells[6].Value.ToString();
                txtPessoa.Text = gridCrudSaidas.CurrentRow.Cells[7].Value.ToString();
                datePckSaida.Value = Convert.ToDateTime(gridCrudSaidas.CurrentRow.Cells[8].Value.ToString());
                txtHoraSaida.Text = gridCrudSaidas.CurrentRow.Cells[10].Value.ToString();
                txtHoraRetorno.Text = gridCrudSaidas.CurrentRow.Cells[11].Value.ToString();
                txtEstatusSaida.Text = gridCrudSaidas.CurrentRow.Cells[12].Value.ToString();
                txtRegiaoEntrega.Text = gridCrudSaidas.CurrentRow.Cells[13].Value.ToString();
                txtKmSaida.Text = gridCrudSaidas.CurrentRow.Cells[14].Value.ToString();
                txtKmRetorno.Text = gridCrudSaidas.CurrentRow.Cells[15].Value.ToString();
                txtKmTotal.Text = gridCrudSaidas.CurrentRow.Cells[16].Value.ToString();
                btnCalcularKmTotal.Visible = true;
                btnCalcularKmTotal.Visible = true;

            } else {
                setaGridEmCampos();
            }
        }

 
        private void button4_Click_1(object sender, EventArgs e){

            ImportVeiculoToSaidas importVS = new ImportVeiculoToSaidas();
            
            importVS.IdVO           =   txtIdVeiculo.Text;
            importVS.veiculoVO      =   txtVeiculo.Text;
            importVS.placaVO        =   txtPlacaVeiculo.Text;
            importVS.estatusVO      =   txtPessoa.Text;

            importVS.ShowDialog();

            txtIdVeiculo.Text       =   Convert.ToString(importVS.IdVO);
            txtVeiculo.Text         =   importVS.veiculoVO;
            txtPlacaVeiculo.Text    =   importVS.placaVO;
            txtEstatuVeiculo.Text   =   importVS.estatusVO;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ImportEntregadorToSaidas importEntregadorToSaidas = new ImportEntregadorToSaidas();

            importEntregadorToSaidas.ShowDialog();

            txtIdUsuario.Text   =   importEntregadorToSaidas.IdVO;
            txtIdPessoa.Text    =   importEntregadorToSaidas.IdPessoaVO;
            txtIdPapel.Text     =   importEntregadorToSaidas.IdPapelVO;
            txtPessoa.Text      =   importEntregadorToSaidas.nomeVO;
        }

        private void SaidaEncomendasView_Load(object sender, EventArgs e){
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         //   gridCrudSaidas.
        }

        private void toolStripButton4_Click(object sender, EventArgs e){
            int qtlinhasSaida = gridCrudSaidas.RowCount;
            if (gridCrudSaidas.CurrentRow.Cells[12].Value.ToString().Equals("Preparando") && qtlinhasSaida > 0){

                groupBoxFormulario.Enabled      = true;
                groupBoxFormulario.Visible      = true;
                groupBox1.Enabled               = true;
                groupBox1.Visible               = true;
                bttnNew.Enabled                 = false;
                bttnDel.Enabled                 = false;
                bttnSearch.Enabled              = false;
                bttnImport.Enabled              = true;
                btnEmRota.Enabled               = true;
                button5.Enabled                 = true;

                txtIdSaida.Text         =   gridCrudSaidas.CurrentRow.Cells[0].Value.ToString();
                txtIdVeiculo.Text       =   gridCrudSaidas.CurrentRow.Cells[1].Value.ToString();
                txtIdUsuario.Text       =   gridCrudSaidas.CurrentRow.Cells[2].Value.ToString();
                txtIdPapel.Text         =   gridCrudSaidas.CurrentRow.Cells[3].Value.ToString();
                txtIdPessoa.Text        =   gridCrudSaidas.CurrentRow.Cells[4].Value.ToString();
                txtVeiculo.Text         =   gridCrudSaidas.CurrentRow.Cells[5].Value.ToString();
                txtPlacaVeiculo.Text    =   gridCrudSaidas.CurrentRow.Cells[6].Value.ToString();
                txtPessoa.Text          =   gridCrudSaidas.CurrentRow.Cells[7].Value.ToString();
                datePckSaida.Value      =   Convert.ToDateTime(gridCrudSaidas.CurrentRow.Cells[8].Value.ToString());
                txtHoraSaida.Text       =   gridCrudSaidas.CurrentRow.Cells[10].Value.ToString();
                txtHoraRetorno.Text     =   gridCrudSaidas.CurrentRow.Cells[11].Value.ToString();
                txtEstatusSaida.Text    =   gridCrudSaidas.CurrentRow.Cells[12].Value.ToString();
                txtRegiaoEntrega.Text   =   gridCrudSaidas.CurrentRow.Cells[13].Value.ToString();
                txtKmSaida.Text         =   gridCrudSaidas.CurrentRow.Cells[14].Value.ToString();
                txtKmRetorno.Text       =   gridCrudSaidas.CurrentRow.Cells[15].Value.ToString();
                txtKmTotal.Text         =   gridCrudSaidas.CurrentRow.Cells[16].Value.ToString();

                gridCurdMestreDetalhe.DataSource = controllerEncomendas.ListarDetalheMestre(txtIdSaida.Text, "Saiu para entrega");
                DataGridModelDetalhe(); 
            }
        }

        private void btnDespesas_Click(object sender, EventArgs e){

            AddGastosSaidaView chamarAddGastosSaidaView = new AddGastosSaidaView();
            chamarAddGastosSaidaView.IdSaidaVO = gridCrudSaidas.CurrentRow.Cells[0].Value.ToString();
            chamarAddGastosSaidaView.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
          //  aumentarFonte();
        }


        //public void aumentarFonte()
        //{
        //    if (posicaoTamanhoFonte == 1)
        //    {

        //        posicaoTamanhoFonte++;
        //     //   gridCrudSaidas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.ColumnHeadersHeight = 28;
        //        //  dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        //jTableDadosModel.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N  
        //        //jTableDadosModel.setRowHeight(16);

        //    }
        //    else if (posicaoTamanhoFonte == 2)
        //    {
        //        posicaoTamanhoFonte++;
        //       // gridCrudSaidas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.ColumnHeadersHeight = 32;
        //        //  dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        //jTableDadosModel.setFont(new java.awt.Font("Tahoma", 0, 26));
        //        //jTableDadosModel.setRowHeight(18);

        //    }
        //    else if (posicaoTamanhoFonte == 3)
        //    {
        //        posicaoTamanhoFonte++;
        //      //  gridCrudSaidas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.ColumnHeadersHeight = 36;
        //        //  dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        //jTableDadosModel.setFont(new java.awt.Font("Tahoma", 0, 18));
        //        //jTableDadosModel.setRowHeight(24);

        //    }
        //    else if (posicaoTamanhoFonte == 4)
        //    {
        //        gridCrudSaidas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.ColumnHeadersHeight = 42;
        //        // dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        //jTableDadosModel.setFont(new java.awt.Font("Tahoma", 0, 24));
        //        //jTableDadosModel.setRowHeight(30);


        //    }
        //}

        //public void reduzirFonte()
        //{
           
        //    if (posicaoTamanhoFonte == 1)
        //    {
        //        // jTableDadosModel.setFont(new java.awt.Font("Tahoma", 0, 12));
        //        // jTableDadosModel.setRowHeight(16);
        //      //  gridCrudSaidas.DefaultCellStyle.Font  = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.ColumnHeadersHeight = 18;
        //        //   dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    }
        //    else if (posicaoTamanhoFonte == 2)
        //    {
        //        posicaoTamanhoFonte--;
        //      //  gridCrudSaidas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.ColumnHeadersHeight = 26;
        //        //     dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        //jTableDadosModel.setFont(new java.awt.Font("Tahoma", 0, 14));
        //        //jTableDadosModel.setRowHeight(16);

        //    }
        //    else if (posicaoTamanhoFonte == 3)
        //    {
        //        posicaoTamanhoFonte--;
        //    //    gridCrudSaidas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.ColumnHeadersHeight = 26;
        //        //   dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        //jTableDadosModel.setFont(new java.awt.Font("Tahoma", 0, 16));
        //        //jTableDadosModel.setRowHeight(18);

        //    }
        //    else if (posicaoTamanhoFonte == 4)
        //    {
        //        posicaoTamanhoFonte--;
        //     //   gridCrudSaidas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.RowsDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        gridCrudSaidas.ColumnHeadersHeight = 32;
        //        //    dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        //jTableDadosModel.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N  
        //        //jTableDadosModel.setRowHeight(24);

        //    }
        //}

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
          //  reduzirFonte();
        }

      
    }
}
