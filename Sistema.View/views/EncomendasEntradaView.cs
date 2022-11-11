using Sistema.Controller;
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
    public partial class EncomendasEntradaView : Form
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
        public string strPesquisarEmColuna;
        EncomendasController controllerEncomendas = new EncomendasController();
        private static EncomendasEntradaView _InstanciaformCrudEncomendas;

        public static EncomendasEntradaView GetInstanciaformCrudPapeis()
        {
            if (_InstanciaformCrudEncomendas == null)
            {
                _InstanciaformCrudEncomendas = new EncomendasEntradaView();
            }
            else if (_InstanciaformCrudEncomendas != null)
            {
                MessageBox.Show("O Gerenciador 'Receber Encomendas', já se encontra aberto!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return _InstanciaformCrudEncomendas;
        }

        public EncomendasEntradaView()
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
            if (cbButtonPesquisarEm.SelectedItem.Equals("Destinatario"))        { strPesquisarEmColuna = "enco.destinatario"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Cpf"))            { strPesquisarEmColuna = "enco.cpf"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("N.Encomenda"))    { strPesquisarEmColuna = "enco.numpacote"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Origem"))         { strPesquisarEmColuna = "ori.nomeorigem"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Logradouro"))     { strPesquisarEmColuna = "enco.logradouro"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Bairro"))         { strPesquisarEmColuna = "enco.bairro"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Cidade"))         { strPesquisarEmColuna = "enco.cidade"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Cep"))            { strPesquisarEmColuna = "enco.cep"; }

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
            if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Bairro"))
            {
                // public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar, string estencomendas)
                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(strPesquisarEmColuna, "@bairro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Bairro"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(strPesquisarEmColuna, "@bairro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Bairro"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(strPesquisarEmColuna, "@bairro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            else if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Logradouro"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(strPesquisarEmColuna, "@logradouro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Logradouro"))
            {
                //
                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(strPesquisarEmColuna, "@logradouro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Logradouro"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(strPesquisarEmColuna, "@logradouro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }


            else if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("N.Encomenda"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(strPesquisarEmColuna, "@numpacote", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("N.Encomenda"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(strPesquisarEmColuna, "@numpacote", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("N.Encomenda"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(strPesquisarEmColuna, "@numpacote", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Origem"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(strPesquisarEmColuna, "@nomeorigem", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Origem"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(strPesquisarEmColuna, "@nomeorigem", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Origem"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(strPesquisarEmColuna, "@nomeorigem", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            else if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Destinatario"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(strPesquisarEmColuna, "@destinatario", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Destinatario"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(strPesquisarEmColuna, "@destinatario", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Destinatario"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(strPesquisarEmColuna, "@destinatario", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Cpf"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(strPesquisarEmColuna, "@cpf", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Cpf"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(strPesquisarEmColuna, "@cpf", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Cpf"))
            {

                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(strPesquisarEmColuna, "@cpf", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
        }
        }




        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {
            //   MessageBox.Show("EnviaModelo");


            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudEncomendas.DataSource = controllerEncomendas.ConfiListagemDataGrid("000", "Em Transito", "idencomenda", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudEncomendas.DataSource = controllerEncomendas.ConfiListagemDataGrid("000", "Em Transito", "idencomenda", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudEncomendas.DataSource = controllerEncomendas.ConfiListagemDataGrid("000", "Em Transito", "numpacote", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.retornoQuantRegistro());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudEncomendas.DataSource = controllerEncomendas.ConfiListagemDataGrid("000", "Em Transito", "numpacote", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(controllerEncomendas.retornoQuantRegistro());
                carregarInformacoes();
            }

        }

        public void carregarEstadoPadrao(string pesquisa, int offsett)
        {
            cbButtnQuantPage1.SelectedIndex = 0;
         
            cbButtonPesquisarEm.SelectedIndex = 0;
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
            gridCrudEncomendas.Visible = true;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = false;
            groupBoxFormulario.Visible = false;
            clearFieldsFormulario();
            disableFieldsFormulario();
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
            txtBoxId.Enabled = false;
            txtBoxId.Visible = false;
            lbDataRota.Visible = false;
            dateTimeRota.Visible = false;
            lbDataEntrega.Visible = false;
            dateTimeEntrega.Visible = false;
            lbFaltamDias.Visible = false;
            txtDiasVencerPrazo.Visible = false;
            lbEstatus.Visible = false;
            txtEstatusEncomenda.Visible = false;

            if (cbButtonPesquisarEm.SelectedItem.Equals("Destinatario"))        { strPesquisarEmColuna = "enco.destinatario"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Cpf"))            { strPesquisarEmColuna = "enco.cpf"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("N.Encomenda"))    { strPesquisarEmColuna = "enco.numpacote"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Origem"))         { strPesquisarEmColuna = "ori.nomeorigem"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Logradouro"))     { strPesquisarEmColuna = "enco.logradouro"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Bairro"))         { strPesquisarEmColuna = "enco.bairro"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Cidade"))         { strPesquisarEmColuna = "enco.cidade"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Cep"))            { strPesquisarEmColuna = "enco.cep"; }
            // gridCrudEncomendas.DataSource = controllerEncomendas.ListarTodosRegistrosPorEstatusDeEntrega("Em Transito");
            gridCrudEncomendas.DataSource = controllerEncomendas.ConfiListagemImportVS();
            DataGridModel();
            

        }

        private void bttnTools_Click(object sender, EventArgs e)
        {
            countBttnToggleTools++;
            if (countBttnToggleTools % 2 == 0)
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
             //   tabControlAssets.TabPages.Remove(tabPageFormulario);
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
                //     tabControlAssets.TabPages.Remove(tabPageOptListagem);

                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSearch.Enabled = true;
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");

            }
        }

        private void DataGridModel(){

            gridCrudEncomendas.Columns[0].Width = 50;
            gridCrudEncomendas.Columns[1].Width = 0;
            gridCrudEncomendas.Columns[2].Width = 0;
            gridCrudEncomendas.Columns[3].Width = 0;
            gridCrudEncomendas.Columns[4].Width = 0;
            gridCrudEncomendas.Columns[5].Width = 0;
            gridCrudEncomendas.Columns[6].Width = 0;
            gridCrudEncomendas.Columns[7].Width = 50;
            gridCrudEncomendas.Columns[8].Width = 150;
            gridCrudEncomendas.Columns[9].Width = 80;
            gridCrudEncomendas.Columns[10].Width = 100;
            gridCrudEncomendas.Columns[11].Width = 150;
            gridCrudEncomendas.Columns[12].Width = 150;
            gridCrudEncomendas.Columns[13].Width = 60;
            gridCrudEncomendas.Columns[14].Width = 150;
            gridCrudEncomendas.Columns[15].Width = 150;
            gridCrudEncomendas.Columns[16].Width = 50;
            gridCrudEncomendas.Columns[17].Width = 80;
            gridCrudEncomendas.Columns[18].Width = 80;
            gridCrudEncomendas.Columns[19].Width = 80;
            gridCrudEncomendas.Columns[20].Width = 80;
            gridCrudEncomendas.Columns[21].Width = 100;
            gridCrudEncomendas.Columns[22].Width = 80;
            gridCrudEncomendas.Columns[23].Width = 80;
            gridCrudEncomendas.Columns[24].Width = 80;

            gridCrudEncomendas.Columns[0].HeaderText = "ID";
            gridCrudEncomendas.Columns[1].HeaderText = "ID Origem";
            gridCrudEncomendas.Columns[2].HeaderText = "ID Veiculo"; //
            gridCrudEncomendas.Columns[3].HeaderText = "ID Entregador"; //
            gridCrudEncomendas.Columns[4].HeaderText = "VEÍCULO"; //
            gridCrudEncomendas.Columns[5].HeaderText = "PLACA"; //
            gridCrudEncomendas.Columns[6].HeaderText = "ENTREGADOR"; //
            gridCrudEncomendas.Columns[7].HeaderText = "PESO"; //
            gridCrudEncomendas.Columns[8].HeaderText = "ENCOMENDA"; //
            gridCrudEncomendas.Columns[9].HeaderText = "ESTATUS";
            gridCrudEncomendas.Columns[10].HeaderText = "CPF";
            gridCrudEncomendas.Columns[11].HeaderText = "DESTINATARIO";
            gridCrudEncomendas.Columns[12].HeaderText = "LOGRADOURO";
            gridCrudEncomendas.Columns[13].HeaderText = "COMP.";
            gridCrudEncomendas.Columns[14].HeaderText = "BAIRRO";
            gridCrudEncomendas.Columns[15].HeaderText = "CIDADE";
            gridCrudEncomendas.Columns[16].HeaderText = "UF";
            gridCrudEncomendas.Columns[17].HeaderText = "CEP";
            gridCrudEncomendas.Columns[18].HeaderText = "ENTREGA";
            gridCrudEncomendas.Columns[19].HeaderText = "ROTA";
            gridCrudEncomendas.Columns[20].HeaderText = "ENTRADA";
            gridCrudEncomendas.Columns[21].HeaderText = "IDSaida"; //
            gridCrudEncomendas.Columns[22].HeaderText = "ID Origem Join 1";
            gridCrudEncomendas.Columns[23].HeaderText = "ORIGEM";
            gridCrudEncomendas.Columns[24].HeaderText = "CD. ORIGEM";


            gridCrudEncomendas.Columns[1].Visible = false;
            gridCrudEncomendas.Columns[2].Visible = false;
            gridCrudEncomendas.Columns[3].Visible = false;
            gridCrudEncomendas.Columns[4].Visible = false;
            gridCrudEncomendas.Columns[5].Visible = false;
            gridCrudEncomendas.Columns[6].Visible = false;
            gridCrudEncomendas.Columns[10].Visible = false;
            //gridCrudEncomendas.Columns[11].Visible = false;
            //gridCrudEncomendas.Columns[12].Visible = false;
            //gridCrudEncomendas.Columns[13].Visible = false;
            //gridCrudEncomendas.Columns[14].Visible = false;
            //gridCrudEncomendas.Columns[15].Visible = false;
            //gridCrudEncomendas.Columns[16].Visible = false;
            //gridCrudEncomendas.Columns[17].Visible = false;
            //    gridCrudEncomendas.Columns[18].Visible = false;
            //    gridCrudEncomendas.Columns[19].Visible = false;
            //  gridCrudEncomendas.Columns[20].Visible = false;
            gridCrudEncomendas.Columns[21].Visible = false;
            gridCrudEncomendas.Columns[22].Visible = false;
            gridCrudEncomendas.Columns[23].Visible = false;
            gridCrudEncomendas.Columns[24].Visible = false;

        }


        private void behaviorRefresh()
        {

            if (operationType == "updateData" && typeEdition == "search")
            {
                gridCrudEncomendas.Visible = true;
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
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
                gridCrudEncomendas.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                toolStrip2.Visible = true;
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                DataGridModel();
                txtEstatusEncomenda.Enabled = false;
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
                gridCrudEncomendas.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                DataGridModel();
                toolStrip2.Visible = true;
                txtEstatusEncomenda.Enabled = false;
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
            gridCrudEncomendas.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            clearFieldsFormulario();
            enableFieldsFormulario();
            operationType = "newInsertion";
            txtBoxId.Enabled = false;
            toolStrip2.Visible = false;
            txtEstatusEncomenda.Enabled = false;
        }

        private void behaviorDel()
        {
            bttnDel.Enabled = true;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            controllerEncomendas.Excluir(Convert.ToInt32(gridCrudEncomendas.CurrentRow.Cells[0].Value));
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
            DataGridModel();
        }

        private void behaviorSave(){
            string retiraEspacos = txtDestinatario.Text;
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
                            clearFieldsFormulario();
                            txtDestinatario.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (rem.Length >= 3)
                    {
                    
                    controllerEncomendas.Salvar(
                                            Convert.ToInt32(txtIdOrigem.Text),
                                            0,
                                            0,
                                            "Veiculo",
                                            "Placa",
                                            "Entregador",
                                            txtPeso.Text,
                                            txtBoxNumeroPacoete.Text,
                                            "Em Transito",
                                            txtCpf.Text,
                                            txtDestinatario.Text,
                                            txtLogradouro.Text,
                                            txtComplemento.Text,
                                            txtBairro.Text,
                                            txtCidade.Text,
                                            txtUf.Text,
                                            txtCep.Text,
                                            Convert.ToDateTime(dateTimeEntrega.Value.ToString("dd/MM/yyyy HH:mm")),// dateTimeEntrega.Value,
                                            Convert.ToDateTime(dateTimeRota.Value.ToString("dd/MM/yyyy HH:mm")),// dateTimeRota.Value,
                                            Convert.ToDateTime(dtEntradaSistema.Value.ToString("dd/MM/yyyy HH:mm")), //  dateTimeEntrada.Value,// dateTimeEntrada.Value,
                                          //  Convert.ToDateTime(dtPrazo.Value.ToString("dd/MM/yyyy HH:mm")),
                                            "000");
                        if (controllerEncomendas.retornoAcaoEncomendasDAO() == "NS")
                        {
                            clearFieldsFormulario();
                            txtDestinatario.Focus();
                            txtDestinatario.Text = "";                     
                        }
                        else if (controllerEncomendas.retornoAcaoEncomendasDAO() == "S!")
                        {
                            
                            operationType = "newInsertion";
                            typeEdition = "insert";
                            acoesBehaviorSave(); 
                        }
                        else if (controllerEncomendas.retornoAcaoEncomendasDAO() ==  "S!!")
                        {
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
                            txtDestinatario.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (rem.Length >= 3)
                    {
                        controllerEncomendas.Editar(Convert.ToInt32(txtIdOrigem.Text),
                                                    0,
                                                    0,
                                                    "Vazio",
                                                    "Vazio",
                                                    "Vazio",
                                                    txtPeso.Text,
                                                    txtBoxNumeroPacoete.Text,
                                                    "Em Transito",
                                                    txtCpf.Text,
                                                    txtDestinatario.Text,
                                                    txtLogradouro.Text,
                                                    txtComplemento.Text,
                                                    txtBairro.Text,
                                                    txtCidade.Text,
                                                    txtUf.Text,
                                                    txtCep.Text,
                                                   Convert.ToDateTime(dateTimeEntrega.Value.ToString("dd/MM/yyyy HH:mm")),// dateTimeEntrega.Value,
                                                   Convert.ToDateTime(dateTimeRota.Value.ToString("dd/MM/yyyy HH:mm")),// dateTimeRota.Value,
                                                   Convert.ToDateTime(dtEntradaSistema.Value.ToString("dd/MM/yyyy HH:mm")), //  dateTimeEntrada.Value,// dateTimeEntrada.Value,
                                               //     Convert.ToDateTime(dtPrazo.Value.ToString("dd/MM/yyyy HH:mm")),
                                                   "000",
                                                    Convert.ToInt32(txtBoxId.Text));
                        if (controllerEncomendas.retornoAcaoEncomendasDAO() == "AT")
                        {
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
                            clearFieldsFormulario();
                            txtDestinatario.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (rem.Length >= 3)
                    {
                        controllerEncomendas.Editar(Convert.ToInt32(txtIdOrigem.Text),
                                                     0,
                                                     0,
                                                     "Vazio",
                                                     "Vazio",
                                                     "Vazio",
                                                     txtPeso.Text,
                                                     txtBoxNumeroPacoete.Text,
                                                     "Em Transito",
                                                     txtCpf.Text,
                                                     txtDestinatario.Text,
                                                     txtLogradouro.Text,
                                                     txtComplemento.Text,
                                                     txtBairro.Text,
                                                     txtCidade.Text,
                                                     txtUf.Text,
                                                     txtCep.Text,
                                                     Convert.ToDateTime(dateTimeEntrega.Value.ToString("dd/MM/yyyy HH:mm")),// dateTimeEntrega.Value,
                                                     Convert.ToDateTime(dateTimeRota.Value.ToString("dd/MM/yyyy HH:mm")),// dateTimeRota.Value,
                                                     Convert.ToDateTime(dtEntradaSistema.Value.ToString("dd/MM/yyyy HH:mm")), //  dateTimeEntrada.Value,// dateTimeEntrada.Value,
                                                  //    Convert.ToDateTime(dtPrazo.Value.ToString("dd/MM/yyyy HH:mm")),
                                                     "000",
                                                     Convert.ToInt32(txtBoxId.Text));
                        if (controllerEncomendas.retornoAcaoEncomendasDAO() ==  "AT")
                        {
                            behaviorRefresh();
                            puxarparametroPesquisa();
                        }
                    }
                }
            }
        }

        private void acoesBehaviorSave(){
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            gridCrudEncomendas.Visible = true;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = false;
            groupBoxFormulario.Visible = false;
            toolStrip2.Visible = true;
            clearFieldsFormulario();
            disableFieldsFormulario();
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
            DataGridModel();
            txtEstatusEncomenda.Enabled = false;
        }

        private void behaviorEdit(){
            typeEdition = "insert";
            operationType = "updateData";
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = false;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = true;
            bttnNew.Enabled = false;
            gridCrudEncomendas.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Enabled = false;

            txtBoxId.Text               =   gridCrudEncomendas.CurrentRow.Cells[0].Value.ToString();
            txtIdOrigem.Text            =   gridCrudEncomendas.CurrentRow.Cells[1].Value.ToString();
            txtPeso.Text                =   gridCrudEncomendas.CurrentRow.Cells[7].Value.ToString();
            txtBoxNumeroPacoete.Text    =   gridCrudEncomendas.CurrentRow.Cells[8].Value.ToString();
            txtCpf.Text                 =   gridCrudEncomendas.CurrentRow.Cells[10].Value.ToString();
            txtDestinatario.Text        =   gridCrudEncomendas.CurrentRow.Cells[11].Value.ToString();
            txtLogradouro.Text          =   gridCrudEncomendas.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text         =   gridCrudEncomendas.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text              =   gridCrudEncomendas.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text              =   gridCrudEncomendas.CurrentRow.Cells[15].Value.ToString();
            txtUf.Text                  =   gridCrudEncomendas.CurrentRow.Cells[16].Value.ToString();
            txtCep.Text                 =   gridCrudEncomendas.CurrentRow.Cells[17].Value.ToString();
            dateTimeEntrega.Value       =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[18].Value.ToString());
            dateTimeRota.Value          =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[19].Value.ToString());
            dtEntradaSistema.Value       =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[20].Value.ToString());
            txtOrigem.Text              =   gridCrudEncomendas.CurrentRow.Cells[22].Value.ToString();
            txtCdOri.Text               =   gridCrudEncomendas.CurrentRow.Cells[23].Value.ToString();
        }

        private void behaviorEditPesquisa(){
            typeEdition = "search";
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = false;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = true;
            bttnNew.Enabled = false;
            gridCrudEncomendas.Visible = false;
            tabControlAssets.Visible = false;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Text               =   gridCrudEncomendas.CurrentRow.Cells[0].Value.ToString();
            txtIdOrigem.Text            =   gridCrudEncomendas.CurrentRow.Cells[1].Value.ToString();
            txtPeso.Text                =   gridCrudEncomendas.CurrentRow.Cells[7].Value.ToString();
            txtBoxNumeroPacoete.Text    =   gridCrudEncomendas.CurrentRow.Cells[8].Value.ToString();
            txtDestinatario.Text        =   gridCrudEncomendas.CurrentRow.Cells[11].Value.ToString();
            txtLogradouro.Text          =   gridCrudEncomendas.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text         =   gridCrudEncomendas.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text              =   gridCrudEncomendas.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text              =   gridCrudEncomendas.CurrentRow.Cells[15].Value.ToString();
            txtUf.Text                  =   gridCrudEncomendas.CurrentRow.Cells[16].Value.ToString();
            txtCep.Text                 =   gridCrudEncomendas.CurrentRow.Cells[17].Value.ToString();
            dateTimeEntrega.Value       =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[18].Value.ToString());
            dateTimeRota.Value          =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[19].Value.ToString());
            dtEntradaSistema.Value       =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[20].Value.ToString());
            txtCpf.Text                 =   gridCrudEncomendas.CurrentRow.Cells[21].Value.ToString();
            txtOrigem.Text              =   gridCrudEncomendas.CurrentRow.Cells[22].Value.ToString();
            txtCdOri.Text               =   gridCrudEncomendas.CurrentRow.Cells[23].Value.ToString();            
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
            txtBoxId.Text               =   gridCrudEncomendas.CurrentRow.Cells[0].Value.ToString();
            txtIdOrigem.Text            =   gridCrudEncomendas.CurrentRow.Cells[1].Value.ToString();
            txtPeso.Text                =   gridCrudEncomendas.CurrentRow.Cells[7].Value.ToString();
            txtBoxNumeroPacoete.Text    =   gridCrudEncomendas.CurrentRow.Cells[8].Value.ToString();
            txtEstatusEncomenda.Text    =   gridCrudEncomendas.CurrentRow.Cells[9].Value.ToString();
            txtCpf.Text                 =   gridCrudEncomendas.CurrentRow.Cells[10].Value.ToString();
            txtDestinatario.Text        =   gridCrudEncomendas.CurrentRow.Cells[11].Value.ToString();
            txtLogradouro.Text          =   gridCrudEncomendas.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text         =   gridCrudEncomendas.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text              =   gridCrudEncomendas.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text              =   gridCrudEncomendas.CurrentRow.Cells[15].Value.ToString();
            txtUf.Text                  =   gridCrudEncomendas.CurrentRow.Cells[16].Value.ToString();
            txtCep.Text                 =   gridCrudEncomendas.CurrentRow.Cells[17].Value.ToString();
            dateTimeEntrega.Value       =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[18].Value.ToString());
            dateTimeRota.Value          =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[19].Value.ToString());
            dtEntradaSistema.Value       =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[20].Value.ToString());
            txtOrigem.Text              =   gridCrudEncomendas.CurrentRow.Cells[23].Value.ToString();
            txtCdOri.Text               =   gridCrudEncomendas.CurrentRow.Cells[24].Value.ToString();
           
        }
        private void behaviorClickGridPesquisa()
        {
            bttnNew.Enabled = false;
            bttnDel.Enabled = true;
            bttnEdit.Enabled = true;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = false;
            bttnSave.Enabled = false;
            bttnNew.Enabled = false;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Text               =   gridCrudEncomendas.CurrentRow.Cells[0].Value.ToString();
            txtIdOrigem.Text            =   gridCrudEncomendas.CurrentRow.Cells[1].Value.ToString();
            txtPeso.Text                =   gridCrudEncomendas.CurrentRow.Cells[7].Value.ToString();
            txtBoxNumeroPacoete.Text    =   gridCrudEncomendas.CurrentRow.Cells[8].Value.ToString();
            txtEstatusEncomenda.Text    =   gridCrudEncomendas.CurrentRow.Cells[9].Value.ToString();
            txtCpf.Text                 =   gridCrudEncomendas.CurrentRow.Cells[10].Value.ToString();
            txtDestinatario.Text        =   gridCrudEncomendas.CurrentRow.Cells[11].Value.ToString();
            txtLogradouro.Text          =   gridCrudEncomendas.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text         =   gridCrudEncomendas.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text              =   gridCrudEncomendas.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text              =   gridCrudEncomendas.CurrentRow.Cells[15].Value.ToString();
            txtUf.Text                  =   gridCrudEncomendas.CurrentRow.Cells[16].Value.ToString();
            txtCep.Text                 =   gridCrudEncomendas.CurrentRow.Cells[17].Value.ToString();
            dateTimeEntrega.Value       =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[18].Value.ToString());
            dateTimeRota.Value          =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[19].Value.ToString());
            dtEntradaSistema.Value       =   Convert.ToDateTime(gridCrudEncomendas.CurrentRow.Cells[20].Value.ToString());
            txtOrigem.Text              =   gridCrudEncomendas.CurrentRow.Cells[23].Value.ToString();
            txtCdOri.Text               =   gridCrudEncomendas.CurrentRow.Cells[24].Value.ToString();
        }




        public void clearFieldsFormulario(){
            txtBoxId.Text               =   "";
            txtIdOrigem.Text            =   "";
            txtPeso.Text                =   "";
            txtBoxNumeroPacoete.Text    =   "";
            txtEstatusEncomenda.Text    =   "";
            txtCpf.Text                 =   "";
            txtDestinatario.Text        =   "";
            txtLogradouro.Text          =   "";
            txtComplemento.Text         =   "";
            txtBairro.Text              =   "";
            txtCidade.Text              =   "";
            txtUf.Text                  =   "";
            txtCep.Text                 =   "";
            dtEntradaSistema.Value       =   DateTime.Now;
            txtOrigem.Text              =   "";
            txtCdOri.Text               =   "";
        }

        public void disableFieldsFormulario() { txtBoxId.Enabled = false; txtDestinatario.Enabled = false; }
        public void enableFieldsFormulario() { txtBoxId.Enabled = true; txtDestinatario.Enabled = true; }
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
                tabControlAssets.Visible    = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnEdit.Enabled            = false;
                bttnNew.Enabled             = false;
                bttnRefresh.Enabled         = false;
                actBehaviorSerarch          = true;
                cbButtonPesquisarEm.SelectedIndex = 0;
                radioBttnComeca.Checked     = true;
                txtBoxPesquisar.Text        = "";
                bttnBeginPages.Visible      = false;
                bttnOnePageLeft.Visible     = false;
                labelTextPageFrom.Visible   = false;
                toolStripLabel3.Visible     = false;
                labelTextTotalPages.Visible = false;
                toolStripLabel5.Visible     = false;
                labelTextTotalRegFould.Visible = false;
                bttnOnePageRight.Visible = false;
                bttnEndPages.Visible = false;
                toolStripLabel1.Visible = true;
                toolStripLabel2.Visible = true;
                txtBoxPesquisar.Text = "";
                txtBoxPesquisar.Focus();
                gridCrudEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom("numpacote", "@numpacote", "", "");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
                typeEdition = "search";
                 groupBoxFormulario.Enabled = false;
                 groupBoxFormulario.Visible = false;
                cbButtnQuantPage1.Visible = false;
                cbOrdemParam1.Visible = false;
                cbOrdenarPor1.Visible = false;
                toolStripLabel6.Visible = false;
                toolStripLabel7.Visible = false;
 
                toolStripLabel4.Visible = false;
                txtBoxId.Enabled = false;
                txtBoxId.Visible = false;
             
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
                DataGridModel();
                txtBoxId.Text = "";
                typeEdition = "insert";
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                cbButtnQuantPage1.Visible = true;
                cbOrdemParam1.Visible = true;
                cbOrdenarPor1.Visible = true;
                
                toolStripLabel6.Visible = true;
                toolStripLabel7.Visible = true;
                toolStripLabel4.Visible = true;
                txtBoxId.Enabled = false;
                txtBoxId.Visible = false;
        

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

  
        private void bttnSave_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIdOrigem.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                behaviorSave();
            }
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
            var gridVazia = gridCrudEncomendas.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia))
            {}
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

            var gridVazia = gridCrudEncomendas.CurrentRow.Cells[0].Value.ToString();
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
            EnderecosView frmEnd = EnderecosView.GetInstanciaformCrudEnderecos();
            frmEnd.Text = "Importar Endereços para o Formulário Cadastro de Encomendas";
            frmEnd.modoVO = "Importacao";
            frmEnd.ShowDialog();
         //  .Text = frmEnderecos.IdVO;
            txtLogradouro.Text = frmEnd.logradouroVO;
            txtBairro.Text = frmEnd.bairroVO;
            txtCidade.Text = frmEnd.cidadeVO;
            txtUf.Text = frmEnd.ufVO;
            txtCep.Text = frmEnd.cepVO;
        

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ImportOrigemToEncomendas imp = new ImportOrigemToEncomendas();
            imp.ShowDialog();
            txtIdOrigem.Text = imp.IdVO;
            txtOrigem.Text = imp.origemVO;
            txtCdOri.Text = imp.codigoOrigemVO;
        }

        private void gridCrudEncomendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridVazia = gridCrudEncomendas.CurrentRow.Cells[0].Value.ToString();
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

        private void gridCrudEncomendas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var gridVazia = gridCrudEncomendas.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia))
            { }
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

        private void formCrudEncomendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _InstanciaformCrudEncomendas = null;
        }

        private void radioBttnTermina_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnContem_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnComeca_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void cbButtonPesquisarEm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }


        private void bttnDel_Click_1(object sender, EventArgs e)
        {


            controllerEncomendas.Excluir(Convert.ToInt32(gridCrudEncomendas.CurrentRow.Cells[0].Value.ToString()));

         
            if (controllerEncomendas.retornoAcaoEncomendasDAO() == "DEL") // retornoPersistencia.Equals("DEL"))
            {
                behaviorRefresh();
            }
          

        }
        

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void EncomendasEntradaView_Load(object sender, EventArgs e)
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            //{
            //    e.Handled = true;
            //}
        }
    }
}