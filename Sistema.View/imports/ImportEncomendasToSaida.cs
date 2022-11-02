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
    public partial class ImportEncomendasToSaida : Form
    {
       
        public int idveiculo;
        public int identregador;
        public string nomeveiculo;
        public string placa;
        public string entregador;
        public string estentrega;
        public string idsaida;
        public DateTime dataentrega;
        public DateTime dataentrada;
        public DateTime dataEmRota;
        public string acaoDialog;
        public string acaoForm;

        public string AcaoDialogVO
        {
            get { return acaoDialog; }
            set { acaoDialog = value; }
        }

        public string AcaoFormVO
        {
            get { return acaoForm; }
            set { acaoForm = value; }
        }

        public int IdVeiculoVO
        {
            get { return idveiculo; }
            set { idveiculo = value; }
        }
        public int IdEntregadorVO
        {
            get { return identregador; }
            set { identregador = value; }
        }
        public string NomeVeiculoVO
        {
            get { return nomeveiculo; }
            set { nomeveiculo = value; }
        }
        public string PlacaVeiculoVO
        {
            get { return placa; }
            set { placa = value; }
        }
        public string EntregadorVO
        {
            get { return entregador; }
            set { entregador = value; }
        }

        public string EstatusEntregaVO
        {
            get { return estentrega; }
            set { estentrega = value; }
        }
        public string IdSaidaVO
        {
            get { return idsaida; }
            set { idsaida = value; }
        }

        public DateTime DataEntregaVO
        {
            get { return dataentrega; }
            set { dataentrega = value; }
        }

        public DateTime DataEntradaVO
        {
            get { return dataentrada; }
            set { dataentrada = value; }
        }
        public DateTime DataEmRotaVO
        {
            get { return dataEmRota; }
            set { dataEmRota = value; }
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
        public string strPesquisarEmColuna;
        EncomendasController controllerEncomendas = new EncomendasController();
        public ImportEncomendasToSaida()
        {
            InitializeComponent();
            carregarEstadoPadrao("CarregaPadraoIDTodosUltimos", 0);
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            gridCrudImporES.DataSource = controllerEncomendas.ConfiListagemImportVS();
            DataGridModel();
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

        private void DataGridModel() {
            //{
            //    gridCrudImporES.Columns[0].Width = 80;
            //    gridCrudImporES.Columns[1].Width = 0;
            //    gridCrudImporES.Columns[2].Width = 0;
            //    gridCrudImporES.Columns[3].Width = 0;
            //    gridCrudImporES.Columns[4].Width = 0;
            //    gridCrudImporES.Columns[5].Width = 0;
            //    gridCrudImporES.Columns[6].Width = 0;
            //    gridCrudImporES.Columns[7].Width = 150;
            //    gridCrudImporES.Columns[8].Width = 150;
            //    gridCrudImporES.Columns[9].Width = 150;
            //    gridCrudImporES.Columns[10].Width = 130;
            //    gridCrudImporES.Columns[11].Width = 150;
            //    gridCrudImporES.Columns[12].Width = 150;
            //    gridCrudImporES.Columns[13].Width = 0;
            //    gridCrudImporES.Columns[14].Width = 0;
            //    gridCrudImporES.Columns[15].Width = 0;
            //    gridCrudImporES.Columns[16].Width = 0;
            //    gridCrudImporES.Columns[17].Width = 0;
            //    gridCrudImporES.Columns[18].Width = 0;
            //    gridCrudImporES.Columns[19].Width = 0;
            //    gridCrudImporES.Columns[20].Width = 150;
            //    gridCrudImporES.Columns[21].Width = 150;

            gridCrudImporES.Columns[0].HeaderText = "ID";
            gridCrudImporES.Columns[1].HeaderText = "ID Origem";
            gridCrudImporES.Columns[2].HeaderText = "ID Veiculo"; //
            gridCrudImporES.Columns[3].HeaderText = "ID Entregador"; //
            gridCrudImporES.Columns[4].HeaderText = "Nome Veiculo"; //
            gridCrudImporES.Columns[5].HeaderText = "Placa"; //
            gridCrudImporES.Columns[6].HeaderText = "Entregador"; //
            gridCrudImporES.Columns[7].HeaderText = "PESO"; //
            gridCrudImporES.Columns[8].HeaderText = "NUM. ENCO."; //
            gridCrudImporES.Columns[9].HeaderText = "ESTATUS";
            gridCrudImporES.Columns[10].HeaderText = "CPF";
            gridCrudImporES.Columns[11].HeaderText = "DESTINATARIO";
            gridCrudImporES.Columns[12].HeaderText = "LOGRADOURO";
            gridCrudImporES.Columns[13].HeaderText = "COMPLEMENTO";
            gridCrudImporES.Columns[14].HeaderText = "BAIRRO";
            gridCrudImporES.Columns[15].HeaderText = "CIDADE";
            gridCrudImporES.Columns[16].HeaderText = "UF";
            gridCrudImporES.Columns[17].HeaderText = "CEP";
            gridCrudImporES.Columns[18].HeaderText = "Data Entrega";
            gridCrudImporES.Columns[19].HeaderText = "Data Rota";
            gridCrudImporES.Columns[20].HeaderText = "Data Entrada";
            gridCrudImporES.Columns[21].HeaderText = "IDSaida"; //
            gridCrudImporES.Columns[22].HeaderText = "ID Origem Join 1";
            gridCrudImporES.Columns[23].HeaderText = "ORIGEM";
            gridCrudImporES.Columns[24].HeaderText = "CD. ORIGEM";

            gridCrudImporES.Columns[1].Visible = false;
            gridCrudImporES.Columns[2].Visible = false;
            gridCrudImporES.Columns[3].Visible = false;
            gridCrudImporES.Columns[4].Visible = false;
            gridCrudImporES.Columns[5].Visible = false;
            gridCrudImporES.Columns[6].Visible = false;
            gridCrudImporES.Columns[10].Visible = false;
            gridCrudImporES.Columns[11].Visible = false;
            gridCrudImporES.Columns[12].Visible = false;
            gridCrudImporES.Columns[13].Visible = false;
            gridCrudImporES.Columns[14].Visible = false;
            gridCrudImporES.Columns[15].Visible = false;
            gridCrudImporES.Columns[16].Visible = false;
            gridCrudImporES.Columns[17].Visible = false;
            gridCrudImporES.Columns[18].Visible = false;
            gridCrudImporES.Columns[19].Visible = false;
            gridCrudImporES.Columns[21].Visible = false;
            gridCrudImporES.Columns[22].Visible = false;
            gridCrudImporES.Columns[24].Visible = false;
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
            if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Bairro"))
            {
                // public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar, string estencomendas)
                gridCrudImporES.DataSource = controllerEncomendas.PesquisarComecaImpES(strPesquisarEmColuna, "@ende.bairro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Bairro"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarContemImpES(strPesquisarEmColuna, "@ende.bairro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Bairro"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarTerminaImpES(strPesquisarEmColuna, "@ende.bairro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            else if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Logradouro"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarComecaImpES(strPesquisarEmColuna, "@ende.logradouro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Logradouro"))
            {
                //
                gridCrudImporES.DataSource = controllerEncomendas.PesquisarContemImpES(strPesquisarEmColuna, "@ende.logradouro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Logradouro"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarTerminaImpES(strPesquisarEmColuna, "@ende.logradouro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }


            else if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Numero Encomenda"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarComecaImpES(strPesquisarEmColuna, "@enco.numeropacote", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Numero Encomenda"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarContemImpES(strPesquisarEmColuna, "@enco.numeropacote", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Numero Encomenda"))
            {

                  gridCrudImporES.DataSource = controllerEncomendas.PesquisarTerminaImpES(strPesquisarEmColuna, "@enco.numeropacote", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Origem"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarComecaImpES(strPesquisarEmColuna, "@ori.nomeorigem", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Origem"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarContemImpES(strPesquisarEmColuna, "@ori.nomeorigem", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Origem"))
            {

                    gridCrudImporES.DataSource = controllerEncomendas.PesquisarTerminaImpES(strPesquisarEmColuna, "@ori.nomeorigem", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            else if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Destinatario"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarComecaImpES(strPesquisarEmColuna, "@enco.destinatario", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Destinatario"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarContemImpES(strPesquisarEmColuna, "@enco.destinatario", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Destinatario"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarTerminaImpES(strPesquisarEmColuna, "@enco.destinatario", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Cpf"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarComecaImpES(strPesquisarEmColuna, "@enco.cpf", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Cpf"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarContemImpES(strPesquisarEmColuna, "@enco.cpf", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Cpf"))
            {

                gridCrudImporES.DataSource = controllerEncomendas.PesquisarTerminaImpES(strPesquisarEmColuna, "@enco.cpf", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
          }
    }

        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {

            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudImporES.DataSource = controllerEncomendas.ConfiListagemDataGrid("000", "Em Transito", "idpapel", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudImporES.DataSource = controllerEncomendas.ConfiListagemDataGrid("000", "Em Transito", "idpapel", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudImporES.DataSource = controllerEncomendas.ConfiListagemDataGrid("000", "Em Transito", "nomepapel", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudImporES.DataSource = controllerEncomendas.ConfiListagemDataGrid("000", "Em Transito", "nomepapel", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.retornoQuantRegistro());
                carregarInformacoes();
            }
        }


        private void bttnSearch_Click(object sender, EventArgs e)
        {
            countBttnToggle++;
            if (countBttnToggle % 2 == 0){
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
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
                //  gridCrudPapeis.DataSource = controllerPapeis.PesquisarComecaCom("nomepapel", "@nomepapel", "");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
                typeEdition = "search";
                cbButtnQuantPage1.Visible = false;
                cbOrdemParam1.Visible = false;
                cbOrdenarPor1.Visible = false;
                toolStripLabel6.Visible = false;
                toolStripLabel7.Visible = false;
                toolStripLabel8.Visible = false;
            } else {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
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

                DataGridModel();
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

        public void carregarEstadoPadrao(string pesquisa, int offsett){
            cbButtnQuantPage1.SelectedIndex = 0;
            cbButtonPesquisarEm.SelectedIndex = 0;
            int quantRegPage = Convert.ToInt32(cbButtnQuantPage1.SelectedItem);
            cbOrdenarPor1.SelectedIndex = 1;
            cbOrdemParam1.SelectedIndex = 0;
            resetarPonteiros();
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
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
            
            if (cbButtonPesquisarEm.SelectedItem.Equals("Destinatario")) { strPesquisarEmColuna = "enco.destinatario"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Cpf")) { strPesquisarEmColuna = "enco.cpf"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Numero Encomenda")) { strPesquisarEmColuna = "enco.numeropacote"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Origem")) { strPesquisarEmColuna = "ori.nomeorigem"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Logradouro")) { strPesquisarEmColuna = "ende.logradouro"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Bairro")) { strPesquisarEmColuna = "ende.bairro"; }
            // gridCrudImporES.DataSource = controllerEncomendas.ListarTodosRegistrosPorEstatusDeEntrega("Em Transito");
            gridCrudImporES.DataSource = controllerEncomendas.ConfiListagemImportVS();
            DataGridModel();

        }
       

        private void gridCrudImporES_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (gridCrudImporES.CurrentRow.Cells[0].Value.ToString().Length > 0){
                string numeropacote = gridCrudImporES.CurrentRow.Cells[8].Value.ToString();

                var resultado = MessageBox.Show("Confirma o despacho do item numero :" +
                    numeropacote,
                    "Aviso deDespacho",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    gridCrudImporES.Columns[0].HeaderText = "ID";
                    gridCrudImporES.Columns[1].HeaderText = "ID Origem";
                    gridCrudImporES.Columns[2].HeaderText = "ID Veiculo"; //
                    gridCrudImporES.Columns[3].HeaderText = "ID Entregador"; //
                    gridCrudImporES.Columns[4].HeaderText = "Nome Veiculo"; //
                    gridCrudImporES.Columns[5].HeaderText = "Placa"; //
                    gridCrudImporES.Columns[6].HeaderText = "Entregador"; //
                    gridCrudImporES.Columns[7].HeaderText = "PESO"; //
                    gridCrudImporES.Columns[8].HeaderText = "NUM. ENCO."; //
                    gridCrudImporES.Columns[9].HeaderText = "ESTATUS";
                    gridCrudImporES.Columns[10].HeaderText = "CPF";
                    gridCrudImporES.Columns[11].HeaderText = "DESTINATARIO";
                    gridCrudImporES.Columns[12].HeaderText = "LOGRADOURO";
                    gridCrudImporES.Columns[13].HeaderText = "COMPLEMENTO";
                    gridCrudImporES.Columns[14].HeaderText = "BAIRRO";
                    gridCrudImporES.Columns[15].HeaderText = "CIDADE";
                    gridCrudImporES.Columns[16].HeaderText = "UF";
                    gridCrudImporES.Columns[17].HeaderText = "CEP";
                    gridCrudImporES.Columns[18].HeaderText = "Data Entrega";
                    gridCrudImporES.Columns[19].HeaderText = "Data Rota";
                    gridCrudImporES.Columns[20].HeaderText = "Data Entrada";
                    gridCrudImporES.Columns[21].HeaderText = "IDSaida";
                    gridCrudImporES.Columns[22].HeaderText = "ID Origem Join 1";
                    gridCrudImporES.Columns[23].HeaderText = "ORIGEM";
                    gridCrudImporES.Columns[24].HeaderText = "CD. ORIGEM";


                    int id                  = Convert.ToInt32(gridCrudImporES.CurrentRow.Cells[0].Value.ToString());
                    int idorigem            = Convert.ToInt32(gridCrudImporES.CurrentRow.Cells[1].Value.ToString()); //"ID Origem";
                    int idveiculo           = IdVeiculoVO;
                    int identregador        = IdEntregadorVO;
                    string nomeVeiculo      = NomeVeiculoVO;
                    string placa            = PlacaVeiculoVO;
                    string entregador       = EntregadorVO;
                    string peso             = gridCrudImporES.CurrentRow.Cells[7].Value.ToString();// "PESO ENCOMENDA"; //
                    string numpacote        = gridCrudImporES.CurrentRow.Cells[8].Value.ToString(); //"NUMERO PACOTE"; //
                    string estEntrega       = "Saiu para entrega";
                    string cpf              = gridCrudImporES.CurrentRow.Cells[10].Value.ToString(); //"Destinatario";
                    string destinatario     = gridCrudImporES.CurrentRow.Cells[11].Value.ToString(); //"Destinatario";
                    string logradouro       = gridCrudImporES.CurrentRow.Cells[12].Value.ToString(); ///"Logradouro";
                    string completo         = gridCrudImporES.CurrentRow.Cells[13].Value.ToString(); //"Complento";
                    string bairro           = gridCrudImporES.CurrentRow.Cells[14].Value.ToString(); ///"Bairro";
                    string cidade           = gridCrudImporES.CurrentRow.Cells[15].Value.ToString();/// "Cidade";
                    string uf               = gridCrudImporES.CurrentRow.Cells[16].Value.ToString(); ///"UF";
                    string cep              = gridCrudImporES.CurrentRow.Cells[17].Value.ToString(); ///"CEP";
                    DateTime drEntrega      = DataEntregaVO;
                    DateTime drRota         = DataEmRotaVO;
                    DateTime drEntrada      = Convert.ToDateTime(gridCrudImporES.CurrentRow.Cells[20].Value.ToString());
                    string idSaida          = IdSaidaVO;                                                                                                //string origem = gridCrudImporES.CurrentRow.Cells[20].Value.ToString(); //"NOME ORIGEM";
                    int idorigemjoin1       = Convert.ToInt32(gridCrudImporES.CurrentRow.Cells[22].Value.ToString());
                    string origem           = gridCrudImporES.CurrentRow.Cells[23].Value.ToString();
                    string codorigem        = gridCrudImporES.CurrentRow.Cells[24].Value.ToString();

                    controllerEncomendas.Editar(idorigem,
                                                idveiculo,
                                                identregador,
                                                nomeVeiculo,
                                                placa,
                                                entregador,
                                                peso,
                                                numpacote,
                                                estEntrega,
                                                cpf,
                                                destinatario,
                                                logradouro,
                                                completo,
                                                bairro,
                                                cidade,
                                                uf,
                                                cep,
                                                drEntrega,
                                                drRota,
                                                drEntrada,
                                                idSaida,
                                                id);

                                                AcaoDialogVO = "Atualizar";
                                                Close();
                }
                else if (resultado == DialogResult.No)
                {

                    AcaoDialogVO = "Cancelar";
                    MessageBox.Show(AcaoDialogVO);
                    Close();
                }


            }
        }



        private void ImportEncomendasToSaida_FormClosed(object sender, FormClosedEventArgs e)
        {
            AcaoFormVO = "Fechar";
        }
    }
}
