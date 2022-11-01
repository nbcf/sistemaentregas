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

namespace Sistema.ImportsView
{
    public partial class ImportEncomendaToSaidas : Form
    {
        public string acaoDialog;
        public string idmestre;

        public string IdMestreVO
        {
            get { return idmestre; }
            set { idmestre = value; }
        }

        public string AcaoDialogVO
        {
            get { return acaoDialog; }
            set { acaoDialog = value; }
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
        public string cbpesquisarEmColuna;

        EncomendasController controllerEncomendas = new EncomendasController();
        public ImportEncomendaToSaidas()
        {
            InitializeComponent();

            carregarEstadoPadrao("CarregaPadraoIDTodosUltimos", 0);

        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
           // dataGridImportEncomendas.DataSource = controllerEncomendas.ListarTodosRegistrosPorEstatusDeEntrega("Em Transito");
        }
        private void puxarparametroPesquisa()
        {
            string estadoPesquisa = "";
            string pesquisarEmColuna = Convert.ToString(cbButtonPesquisarEm.SelectedItem);

            if (radioBttnComeca.Checked == true) { estadoPesquisa = "ComecaCom"; }
            else if (radioBttnContem.Checked == true) { estadoPesquisa = "Contem"; }
            else if (radioBttnTermina.Checked == true) { estadoPesquisa = "TerminaCom"; }
            else if (radioBttnComeca.Checked == false) { estadoPesquisa = ""; }
            else if (radioBttnContem.Checked == false) { estadoPesquisa = ""; }
            else if (radioBttnTermina.Checked == false) { estadoPesquisa = ""; }

            if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Bairro"))
            {
                // public DataTable PesquisarComecaCom(string coluna, string campo, string pesquisar, string estencomendas)
            //    dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(cbpesquisarEmColuna, "@ende.bairro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Bairro"))
            {

            //   dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(cbpesquisarEmColuna, "@ende.bairro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Bairro"))
            {

             //   dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(cbpesquisarEmColuna, "@ende.bairro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                 toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            else if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Logradouro"))
            {

              //  dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(cbpesquisarEmColuna, "@ende.logradouro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                 toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Logradouro"))
            {
//
             //   dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(cbpesquisarEmColuna, "@ende.logradouro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Logradouro"))
            {

             //   dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(cbpesquisarEmColuna, "@ende.logradouro", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }


            else if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Numero Encomenda"))
            {

             //   dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(cbpesquisarEmColuna, "@enco.numeropacote", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Numero Encomenda"))
            {

              //  dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(cbpesquisarEmColuna, "@enco.numeropacote", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Numero Encomenda"))
            {

            //    dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(cbpesquisarEmColuna, "@enco.numeropacote", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Origem"))
            {

             //   dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(cbpesquisarEmColuna, "@ori.nomeorigem", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Origem"))
            {

            //    dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(cbpesquisarEmColuna, "@ori.nomeorigem", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Origem"))
            {

            //    dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(cbpesquisarEmColuna, "@ori.nomeorigem", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            else if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Destinatario"))
            {

             //   dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(cbpesquisarEmColuna, "@enco.destinatario", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Destinatario"))
            {

              //  dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(cbpesquisarEmColuna, "@enco.destinatario", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Destinatario"))
            {

            //    dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(cbpesquisarEmColuna, "@enco.destinatario", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }

            if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Cpf"))
            {

           //    dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarComecaCom(cbpesquisarEmColuna, "@enco.cpf", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Cpf"))
            {

             //   dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarContemCom(cbpesquisarEmColuna, "@enco.cpf", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Cpf"))
            {

             //   dataGridImportEncomendas.DataSource = controllerEncomendas.PesquisarTerminaCom(cbpesquisarEmColuna, "@enco.cpf", txtBoxPesquisar.Text, "Em Transito");
                DataGridModel();
                toolStripLabel2.Text = Convert.ToString(controllerEncomendas.retornoQuantPesquisa());
            }
        }


        private void DataGridModel()
        {
            //dataGridImportEncomendas.Columns[0].Width = 80;
            //dataGridImportEncomendas.Columns[1].Width = 0;
            //dataGridImportEncomendas.Columns[2].Width = 0;
            //dataGridImportEncomendas.Columns[3].Width = 100;
            //dataGridImportEncomendas.Columns[4].Width = 100;
            //dataGridImportEncomendas.Columns[5].Width = 80;
            //dataGridImportEncomendas.Columns[6].Width = 130;
            //dataGridImportEncomendas.Columns[7].Width = 130;
            //dataGridImportEncomendas.Columns[8].Width = 100;
            //dataGridImportEncomendas.Columns[9].Width = 100;
            //dataGridImportEncomendas.Columns[10].Width = 0;
            //dataGridImportEncomendas.Columns[11].Width = 150;
            //dataGridImportEncomendas.Columns[12].Width = 150;
            //dataGridImportEncomendas.Columns[13].Width = 150;
            //dataGridImportEncomendas.Columns[14].Width = 100;
            //dataGridImportEncomendas.Columns[15].Width = 130;
            //dataGridImportEncomendas.Columns[16].Width = 0;
            //dataGridImportEncomendas.Columns[17].Width = 100;
            //dataGridImportEncomendas.Columns[18].Width = 80;
            //dataGridImportEncomendas.Columns[0].HeaderText = "ID";
            //dataGridImportEncomendas.Columns[1].HeaderText = "ID Endereco"; //
            //dataGridImportEncomendas.Columns[2].HeaderText = "ID Origem"; //
            //dataGridImportEncomendas.Columns[3].HeaderText = "Numero Pacote";
            //dataGridImportEncomendas.Columns[4].HeaderText = "Estatus";
            //dataGridImportEncomendas.Columns[5].HeaderText = "Peso";//
            //dataGridImportEncomendas.Columns[6].HeaderText = "CPF";
            //dataGridImportEncomendas.Columns[7].HeaderText = "Destinatario";
            //dataGridImportEncomendas.Columns[8].HeaderText = "Data Entrega";
            //dataGridImportEncomendas.Columns[9].HeaderText = "Hora Entrega";
            //dataGridImportEncomendas.Columns[10].HeaderText = "ID Endereco Join";
            //dataGridImportEncomendas.Columns[11].HeaderText = "Logradouro";
            //dataGridImportEncomendas.Columns[12].HeaderText = "Bairro";
            //dataGridImportEncomendas.Columns[13].HeaderText = "Cidade";
            //dataGridImportEncomendas.Columns[14].HeaderText = "UF";
            //dataGridImportEncomendas.Columns[15].HeaderText = "CEP";
            //dataGridImportEncomendas.Columns[16].HeaderText = "ID Origem Join";
            //dataGridImportEncomendas.Columns[17].HeaderText = "Nome Origem";
            //dataGridImportEncomendas.Columns[18].HeaderText = "Codigo Origem";

            //dataGridImportEncomendas.Columns[1].Visible = false;
            //dataGridImportEncomendas.Columns[2].Visible = false;
            ////  dataGridImportEncomendas.Columns[6].Visible = false;
            ////   dataGridImportEncomendas.Columns[7].Visible = false;
            //dataGridImportEncomendas.Columns[8].Visible = false;
            //dataGridImportEncomendas.Columns[9].Visible = false;
            //dataGridImportEncomendas.Columns[10].Visible = false;
            //dataGridImportEncomendas.Columns[16].Visible = false;
            //dataGridImportEncomendas.Columns[18].Visible = false;
            //dataGridImportEncomendas.Columns[11].Visible = false;
            //dataGridImportEncomendas.Columns[12].Visible = false;
            //dataGridImportEncomendas.Columns[13].Visible = false;
            //dataGridImportEncomendas.Columns[14].Visible = false;
            //dataGridImportEncomendas.Columns[15].Visible = false;
        }


        public void carregarEstadoPadrao(string pesquisa, int offsett)
        {
            cbButtonPesquisarEm.SelectedIndex = 0;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;

            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            tabControlAssets.Visible = false;


            tabControlAssets.TabPages.Remove(tabPagePesquisar);


            if (cbButtonPesquisarEm.SelectedItem.Equals("Destinatario")) { cbpesquisarEmColuna = "enco.destinatario"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Cpf")) { cbpesquisarEmColuna = "enco.cpf"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Numero Encomenda")) { cbpesquisarEmColuna = "enco.numeropacote"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Origem")) { cbpesquisarEmColuna = "ori.nomeorigem"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Logradouro")) { cbpesquisarEmColuna = "ende.logradouro"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Bairro")) { cbpesquisarEmColuna = "ende.bairro"; }
         //   dataGridImportEncomendas.DataSource = controllerEncomendas.ListarTodosRegistrosPorEstatusDeEntrega("Em Transito");
            DataGridModel();

        }

        private void radioBttnComeca_CheckedChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnTermina_CheckedChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnContem_CheckedChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void tabPagePesquisar_Click(object sender, EventArgs e)
        {

        }


        private void txtBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }



        //private void dataGridImportEncomendas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{


        //   if (cbButtonPesquisarEm.SelectedItem.Equals("Destinatario")) { cbpesquisarEmColuna = "enco.destinatario"; }
        //    else if (cbButtonPesquisarEm.SelectedItem.Equals("Cpf")) { cbpesquisarEmColuna = "enco.cpf"; }
        //    else if (cbButtonPesquisarEm.SelectedItem.Equals("Numero Encomenda")) { cbpesquisarEmColuna = "enco.numeropacote"; }
        //    else if (cbButtonPesquisarEm.SelectedItem.Equals("Origem")) { cbpesquisarEmColuna = "ori.nomeorigem"; }
        //    else if (cbButtonPesquisarEm.SelectedItem.Equals("Logradouro")) { cbpesquisarEmColuna = "ende.logradouro"; }
        //    else if (cbButtonPesquisarEm.SelectedItem.Equals("Bairro")) { cbpesquisarEmColuna = "ende.bairro"; }


        //    puxarparametroPesquisa();


        //}

        private void cbButtonPesquisarEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbButtonPesquisarEm.SelectedItem.Equals("Destinatario")) { cbpesquisarEmColuna = "enco.destinatario"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Cpf")) { cbpesquisarEmColuna = "enco.cpf"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Numero Encomenda")) { cbpesquisarEmColuna = "enco.numeropacote"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Origem")) { cbpesquisarEmColuna = "ori.nomeorigem"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Logradouro")) { cbpesquisarEmColuna = "ende.logradouro"; }
            else if (cbButtonPesquisarEm.SelectedItem.Equals("Bairro")) { cbpesquisarEmColuna = "ende.bairro"; }

            puxarparametroPesquisa();
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            countBttnToggle++;
            if (countBttnToggle % 2 == 0)
            {
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                //   bttnEdit.Enabled = false;
                //   bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                actBehaviorSerarch = true;
                cbButtonPesquisarEm.SelectedIndex = 0;
                radioBttnComeca.Checked = true;
                txtBoxPesquisar.Text = "";
                //    bttnBeginPages.Visible = false;
                //   bttnOnePageLeft.Visible = false;
                //    labelTextPageFrom.Visible = false;
                //   toolStripLabel3.Visible = false;
                //   labelTextTotalPages.Visible = false;
                //   toolStripLabel5.Visible = false;
                ///  labelTextTotalRegFould.Visible = false;
                //  bttnOnePageRight.Visible = false;
                //  bttnEndPages.Visible = false;
                //  toolStripLabel1.Visible = true;
                //  toolStripLabel2.Visible = true;
                //  txtBoxPesquisar.Text = "";
                // txtBoxPesquisar.Focus();
                //   cbButtonPesquisarEm.SelectedIndex = 0;
                txtBoxPesquisar.Text = "";
                txtBoxPesquisar.Focus();
                radioBttnComeca.Checked = true;
                //  gridCrudPessoa.DataSource = controllerPessoa.PesquisarComecaCom("nomepessoa", "@nomepessoa", "");
                //  DataGridModel();
                //  typeEdition = "search";
                //  cbButtnQuantPage1.Visible = false;
                //  cbOrdemParam1.Visible = false;
                //  cbOrdenarPor1.Visible = false;
                //  toolStripLabel6.Visible = false;
                //  toolStripLabel7.Visible = false;
                // toolStripLabel8.Visible = false;
                puxarparametroPesquisa();
            }
            else
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                //  bttnEdit.Enabled = false;
                // bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
                actBehaviorSerarch = false;
                //  bttnBeginPages.Visible = true;
                //  bttnOnePageLeft.Visible = true;
                //  labelTextPageFrom.Visible = true;
                //  toolStripLabel3.Visible = true;
                //  labelTextTotalPages.Visible = true;
                //  toolStripLabel5.Visible = true;
                //  labelTextTotalRegFould.Visible = true;
                // bttnOnePageRight.Visible = true;
                // bttnEndPages.Visible = true;
                // toolStripLabel1.Visible = false;
                // toolStripLabel2.Visible = false;
                //puxarparametro(0, Convert.ToInt32(cbButtnQuantPage1.SelectedItem), "Sim");
                //>>>
                //  stringPapel = "";
                // txtBoxId.Text = "";
                //typeEdition = "insert";


                //cbButtnQuantPage1.Visible = true;
                //cbOrdemParam1.Visible = true;
                //cbOrdenarPor1.Visible = true;
                //toolStripLabel6.Visible = true;
                //toolStripLabel7.Visible = true;
                //  toolStripLabel8.Visible = true;
                puxarparametroPesquisa();
            }
        }

        private void dataGridImportEncomendas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string idmestreDetalhe = IdMestreVO;
           // controllerEncomendas.SalvarDetalhe("Saiu para entrega", Convert.ToInt32(idmestreDetalhe), Convert.ToInt32(dataGridImportEncomendas.CurrentRow.Cells[0].Value));
            //controllerEncomendas.SalvarDetalhe("Saiu para entrega", Convert.ToInt32(idmestreDetalhe), Convert.ToInt32(dataGridImportEncomendas.CurrentRow.Cells[0].Value));
            //    dataGridImportEncomendas.DataSource = controllerEncomendas.ListarTodosRegistrosPorEstatusDeEntrega("Em Transito");
            //   DataGridModel();

            MessageBox.Show("Saiu para entrega"+" "+ idmestreDetalhe+ "  " + Convert.ToInt32(dataGridImportEncomendas.CurrentRow.Cells[0].Value).ToString());
           
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
            quantidadeReg = Convert.ToInt32(controllerPapeis.retornoQuantRegistro());
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


    }
}
