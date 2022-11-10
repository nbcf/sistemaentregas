using Sistema.Controller;
using Sistema.View.edits;
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
    public partial class EntregasView : Form
    {
        public string strIdEncomenda;
        public string strIdOrigem;
        public string strIdVeiculo;
        public string strIdEntregador;
        public string strVeiculo;
        public string strPlaca;
        public string strEntregador;
        public string strIdSaida;
        public string strDestinatario;
        public string strLogradouro;
        public string strComplemento;
        public string strBairro;
        public string strCidade;
        public string strUf;
        public string strCep;
        public string strCpf;
        public string strOrigem;
        public string strIdCombo;
        public string strNumeroEncomenda;
        public string strEstatusEntrega;
        public DateTime dtDataEntrega;
        public DateTime dtDatarota;
        public DateTime dtDataEntrada;
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
        public string strPesquisarEmColuna;

        private static EntregasView _InstanciaEntregasView;
        public static EntregasView GetInstanciaEntregasView()
        {
            if (_InstanciaEntregasView == null)
            {
                _InstanciaEntregasView = new EntregasView();
            }
            return _InstanciaEntregasView;
        }


        EncomendasController controllerEncomendas = new EncomendasController();
        SaidasController controllerSaida = new SaidasController();
        public EntregasView()
        {
            InitializeComponent();
          carregarEstadoPadrao("CarregaPadraoIDTodosUltimos", 0);

        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
            DataGridModel();
           
        }

        private void puxarparametro(int deslocamento, int limiteregistro, string inicioDeslocamento)
        {

            string jcbOrdem = Convert.ToString(cbOrdemParam1.SelectedItem);
            string ordem = "";
            if (Convert.ToString(cbOrdenarPor1.SelectedItem).Equals("Primeiros")){
                ordem = "primeiros";
            }else if (Convert.ToString(cbOrdenarPor1.SelectedItem).Equals("Ultimos")){
                ordem = "ultimos";
            }

            if (actBehaviorSerarch == false)

                if (jcbOrdem.Equals("Codigo") && ordem.Equals("primeiros")){
                    parametroCodigoAlfabeto = "Codigo";
                    parametroASCDESC = "primeiros";

                    if (cbButtnQuantPage1.SelectedText == "Todos") {
                    }else{
                        if (inicioDeslocamento.Equals("Sim")){
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

                    if (cbButtnQuantPage1.SelectedText == "Todos"){
                    }else{
                        paginar = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
                        ultimaPagina = paginar;
                        if (inicioDeslocamento.Equals("Sim")){
                            resetarPonteiros();
                            this.EnviaModelo("CarregaPadraoIDTodosUltimos", deslocamento, limiteregistro);
                        }else if (inicioDeslocamento.Equals("Nao")){
                            this.EnviaModelo("CarregaPadraoIDTodosUltimos", deslocamento, limiteregistro);
                        }
                    }
                }
                else if (jcbOrdem.Equals("Alfabeto") && ordem.Equals("primeiros"))
                {
                    parametroCodigoAlfabeto = "Alfabeto";
                    parametroASCDESC = "primeiros";

                    if (cbButtnQuantPage1.SelectedText == "Todos"){
                    }else{
                        if (inicioDeslocamento.Equals("Sim")){
                            resetarPonteiros();
                            this.EnviaModelo("CarregaPadraoNomeTodosPrimeiros", deslocamento, limiteregistro);
                        }
                        else if (inicioDeslocamento.Equals("Nao"))
                        {
                            this.EnviaModelo("CarregaPadraoNomeTodosPrimeiros", deslocamento, limiteregistro);
                        }
                    }
                }
                else if (jcbOrdem.Equals("Alfabeto") && ordem.Equals("ultimos")){
                    parametroCodigoAlfabeto = "Alfabeto";
                    parametroASCDESC = "ultimos";
                    if (cbButtnQuantPage1.SelectedText == "Todos"){
                    }
                    else{

                        if (inicioDeslocamento.Equals("Sim")){
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


        public void inicioPagina(){
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
            quantidadeReg = Convert.ToInt32(controllerEncomendas.retornoQuantRegistro());
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



        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {
            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudEnc.DataSource = controllerEncomendas.ListarTodasEntregaSaida(strIdCombo, "Saiu para Entrega","idencomenda", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.ListarTodosRegistrosBDEstatus("Saiu para Entrega"));
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
            
                gridCrudEnc.DataSource = controllerEncomendas.ListarTodasEntregaSaida(strIdCombo, "Saiu para Entrega", "idencomenda", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.ListarTodosRegistrosBDEstatus("Saiu para Entrega"));
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudEnc.DataSource = controllerEncomendas.ListarTodasEntregaSaida(strIdCombo, "Saiu para Entrega", "numpacote", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.ListarTodosRegistrosBDEstatus("Saiu para Entrega"));
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudEnc.DataSource = controllerEncomendas.ListarTodasEntregaSaida(strIdCombo, "Saiu para Entrega", "numpacote", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.ListarTodosRegistrosBDEstatus("Saiu para Entrega"));
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
        //    this.puxarparametro(0, quantRegPage, "Nao");
            gridCrudEnc.Visible = true;
            tabControlAssets.Visible = true;
            tabControlAssets.TabPages.Insert (0, tabPrincipal);
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
            txtIdSaida.Enabled = false;
            txtIdOrigem.Enabled = false;

            txtIdSaida.Visible = false;
            txtIdOrigem.Visible = false;
        }

       
        private void DataGridModel()
        {


            gridCrudEnc.Columns[0].HeaderText = "ID";
            gridCrudEnc.Columns[1].HeaderText = "ID Origem";
            gridCrudEnc.Columns[2].HeaderText = "ID Veiculo"; //
            gridCrudEnc.Columns[3].HeaderText = "ID Entregador"; //
            gridCrudEnc.Columns[4].HeaderText = "Nome Veiculo"; //
            gridCrudEnc.Columns[5].HeaderText = "Placa"; //
            gridCrudEnc.Columns[6].HeaderText = "Entregador"; //
            gridCrudEnc.Columns[7].HeaderText = "PESO"; //
            gridCrudEnc.Columns[8].HeaderText = "NUM. ENCO."; //
            gridCrudEnc.Columns[9].HeaderText = "ESTATUS";
            gridCrudEnc.Columns[10].HeaderText = "CPF";
            gridCrudEnc.Columns[11].HeaderText = "DESTINATARIO";
            gridCrudEnc.Columns[12].HeaderText = "LOGRADOURO";
            gridCrudEnc.Columns[13].HeaderText = "COMPLEMENTO";
            gridCrudEnc.Columns[14].HeaderText = "BAIRRO";
            gridCrudEnc.Columns[15].HeaderText = "CIDADE";
            gridCrudEnc.Columns[16].HeaderText = "UF";
            gridCrudEnc.Columns[17].HeaderText = "CEP";
            gridCrudEnc.Columns[18].HeaderText = "Data Entrega";
            gridCrudEnc.Columns[19].HeaderText = "Data Rota";
            gridCrudEnc.Columns[20].HeaderText = "Data Entrada";
            gridCrudEnc.Columns[21].HeaderText = "IDSaida"; //
            gridCrudEnc.Columns[22].HeaderText = "ID Origem Join 1";
            gridCrudEnc.Columns[23].HeaderText = "ORIGEM";
            gridCrudEnc.Columns[24].HeaderText = "CD. ORIGEM";
            gridCrudEnc.Columns[0].Visible = false;
            gridCrudEnc.Columns[1].Visible = false;
            gridCrudEnc.Columns[2].Visible = false;
            gridCrudEnc.Columns[3].Visible = false;
            //gridCrudEnc.Columns[4].Visible = true;
            //gridCrudEnc.Columns[5].Visible = true;
            //gridCrudEnc.Columns[6].Visible = true;
              gridCrudEnc.Columns[7].Visible = true;

            //gridCrudEnc.Columns[10].Visible = true;
            //gridCrudEnc.Columns[11].Visible = true;
            //gridCrudEnc.Columns[12].Visible = true;
            //gridCrudEnc.Columns[13].Visible = true;
            //gridCrudEnc.Columns[14].Visible = true;
            //gridCrudEnc.Columns[15].Visible = true;
            //gridCrudEnc.Columns[16].Visible = true;
            //gridCrudEnc.Columns[17].Visible = true;
            //gridCrudEnc.Columns[18].Visible = true;
            //gridCrudEnc.Columns[19].Visible = false;
            //gridCrudEnc.Columns[20].Visible = false;
            //gridCrudEnc.Columns[21].Visible = true;
            //gridCrudEnc.Columns[22].Visible = false;
        }

        public void clickPegaLinhas() {
            behaviorClickGrid();
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void gridCrudEnc_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e){
            clickPegaLinhas();
        }


        public int ContarFaltantes(){
            return  controllerEncomendas.ContarEncomendas(strIdCombo,Convert.ToInt32(strIdVeiculo),Convert.ToInt32(strIdEntregador), "Saiu para Entrega", dtDatarota);
        }


        private void behaviorClickGrid(){
            EditSaidas editSaidas = new EditSaidas();
            editSaidas.IdEncomendaVO        =       gridCrudEnc.CurrentRow.Cells[0].Value.ToString();
            editSaidas.IdOrigemVO           =       gridCrudEnc.CurrentRow.Cells[1].Value.ToString();
            editSaidas.IdVeiculoVO          =       gridCrudEnc.CurrentRow.Cells[2].Value.ToString();
            editSaidas.IdEntregadorVO       =       gridCrudEnc.CurrentRow.Cells[3].Value.ToString();
            editSaidas.VeiculoVO            =       gridCrudEnc.CurrentRow.Cells[4].Value.ToString();
            editSaidas.PlacaVO              =       gridCrudEnc.CurrentRow.Cells[5].Value.ToString();
            editSaidas.EntregadorVO         =       gridCrudEnc.CurrentRow.Cells[6].Value.ToString();
            editSaidas.NumeroEncomendaVO    =       gridCrudEnc.CurrentRow.Cells[8].Value.ToString();
            editSaidas.EstatusEntregaVO     =       gridCrudEnc.CurrentRow.Cells[9].Value.ToString();
            editSaidas.CpfVO                =       gridCrudEnc.CurrentRow.Cells[10].Value.ToString();
            editSaidas.DestinatarioVO       =       gridCrudEnc.CurrentRow.Cells[11].Value.ToString();
            editSaidas.LogradouroVO         =       gridCrudEnc.CurrentRow.Cells[12].Value.ToString();
            editSaidas.ComplementoVO        =       gridCrudEnc.CurrentRow.Cells[13].Value.ToString();
            editSaidas.BairroVO             =       gridCrudEnc.CurrentRow.Cells[14].Value.ToString();
            editSaidas.CidadeVO             =       gridCrudEnc.CurrentRow.Cells[15].Value.ToString();
            editSaidas.UfVO                 =       gridCrudEnc.CurrentRow.Cells[16].Value.ToString();
            editSaidas.CepVO                =       gridCrudEnc.CurrentRow.Cells[17].Value.ToString();
            editSaidas.DataEntregaVO        =       Convert.ToDateTime(gridCrudEnc.CurrentRow.Cells[18].Value.ToString());
            editSaidas.DataRotaVO           =       Convert.ToDateTime(gridCrudEnc.CurrentRow.Cells[19].Value.ToString());
            editSaidas.DataEntradaVO        =       Convert.ToDateTime(gridCrudEnc.CurrentRow.Cells[20].Value.ToString());
            editSaidas.IdSaidaVO            =       gridCrudEnc.CurrentRow.Cells[21].Value.ToString();
            editSaidas.OrigemVO             =       gridCrudEnc.CurrentRow.Cells[23].Value.ToString();
            editSaidas.ShowDialog();
            /*"SELECT  COUNT (*) " +
                   " FROM encomendas enco " +
                   " WHERE enco.idsaida = '"+ stridsaida + "' " +
                   " AND  enco.idveiculo = '"+ idveiculo + "' " +
                   " AND  enco.identregador = '"+ identregador + "' " +
                   " AND enco.estentrega = '"+ estentrega + "'" +
                   " AND enco.datarota= '"+datarota+"'";*/
           
           
            if (editSaidas.AcaoDialogoVO.Equals("Cancelar"))
            {
                strIdOrigem     = "";
                strIdVeiculo    = "";
                strIdEntregador = "";
                strVeiculo      = "";
                strPlaca        = "";
                strEntregador   = "";
                strIdSaida      = "";
                strDestinatario = "";
                strLogradouro   = "";
                strComplemento  = "";
                strBairro       = "";
                strCidade       = "";
                strUf           = "";
                strCep          = "";
                strCpf          = "";
                strOrigem       = "";
                strNumeroEncomenda = "";
                strEstatusEntrega = "";

            }

            else if (editSaidas.AcaoDialogoVO.Equals("Salvar")){

                strIdEncomenda      =       editSaidas.IdEncomendaVO;
                strIdOrigem         =       editSaidas.IdOrigemVO;
                strIdVeiculo        =       editSaidas.IdVeiculoVO;
                strIdEntregador     =       editSaidas.IdEntregadorVO;
                strVeiculo          =       editSaidas.VeiculoVO;
                strPlaca            =       editSaidas.PlacaVO;
                strEntregador       =       editSaidas.EntregadorVO;
                strNumeroEncomenda  =       editSaidas.NumeroEncomendaVO;
                strEstatusEntrega   =       editSaidas.EstatusEntregaVO;
                strCpf              =       editSaidas.CpfVO;
                strDestinatario     =       editSaidas.DestinatarioVO;
                strLogradouro       =       editSaidas.LogradouroVO;
                strComplemento      =       editSaidas.ComplementoVO;
                strBairro           =       editSaidas.BairroVO;
                strCidade           =       editSaidas.CidadeVO;
                strUf               =       editSaidas.UfVO;
                strCep              =       editSaidas.CepVO;
                dtDataEntrega       =       editSaidas.  DataEntregaVO;
                dtDatarota          =       editSaidas.DataRotaVO;
                dtDataEntrada       =       editSaidas.DataEntradaVO;
                strIdSaida          =       editSaidas.IdSaidaVO;
                strOrigem           =       editSaidas.OrigemVO;

                   controllerEncomendas.Editar(Convert.ToInt32(strIdOrigem),
                                               Convert.ToInt32(strIdVeiculo),
                                               Convert.ToInt32(strIdEntregador),
                                               strVeiculo,
                                               strPlaca,
                                               strEntregador,
                                               gridCrudEnc.CurrentRow.Cells[7].Value.ToString(),
                                               strNumeroEncomenda,
                                               strEstatusEntrega,
                                               strCpf,
                                               strDestinatario,
                                               strLogradouro,
                                               strComplemento,
                                               strBairro,
                                               strCidade,
                                               strUf,
                                               strCep,
                                               dtDataEntrega,
                                               dtDatarota,
                                               dtDataEntrada,
                                               strIdSaida,
                                               Convert.ToInt32(strIdEncomenda));

                int qt = ContarFaltantes();

                MessageBox.Show(qt.ToString());

                if (controllerEncomendas.retornoAcaoEncomendasDAO() == "AT")
                {
                    if (ContarFaltantes() == 0)
                    {
                         
                      controllerSaida.EditarFimDeRota(Convert.ToInt32(strIdVeiculo), Convert.ToInt32(strIdEntregador), "Rota Concluída", Convert.ToInt32(txtIdSaida.Text));
                    }
                    else if (ContarFaltantes() > 0)
                    {
                      
                        //    controllerSaida.EditarFimDeRota(Convert.ToInt32(strIdVeiculo), Convert.ToInt32(strIdEntregador), "Rota Concluída", Convert.ToInt32(txtIdSaida.Text));
                    }
                }
            }
        }
     

   

        private void bttnOnePageRight_Click(object sender, EventArgs e)
        {
            somar();
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

        private void cbOrdemParam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

        private void cbOrdenarPor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
        }

     

        private void bttnEndPages_Click_1(object sender, EventArgs e)
        {
            finalDaPagina();
        }

        private void bttnOnePageRight_Click_1(object sender, EventArgs e)
        {
            somar();
        }

        private void bttnOnePageLeft_Click_1(object sender, EventArgs e)
        {
            descontar();
        }

        private void bttnBeginPages_Click_1(object sender, EventArgs e)
        {
            inicioPagina();
        }

        private void gridCrudEnc_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            clickPegaLinhas();
        }

        private void EntregasView_Load(object sender, EventArgs e)
        {
           
            comboBox1.DataSource = controllerSaida.ListarEstatusSaidaController("Em Rota");
            comboBox1.ValueMember = "idsaida";
            comboBox1.DisplayMember = "entregador";
            if (comboBox1.Items.Count > 0)
            {
                txtIdSaida.Text = comboBox1.SelectedValue.ToString();
                strIdCombo = txtIdSaida.Text;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0) {

                txtIdSaida.Text = comboBox1.SelectedValue.ToString();
                strIdCombo = txtIdSaida.Text;
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");

            }
           
        }

      
        private void EntregasView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _InstanciaEntregasView = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
