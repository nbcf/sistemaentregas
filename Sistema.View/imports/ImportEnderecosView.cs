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
    public partial class ImportEnderecos : Form
    {
        public string strID;
        public string strLogradouro;
        public string strBairro;
        public string strCidade;
        public string strUF;
        public string strCep;
        public string IdVO
        {
            get { return strID; }
            set { strID = value; }
        }
        public string logradouroVO
        {
            get { return strLogradouro; }
            set { strLogradouro = value; }
        }
        public string bairroVO
        {
            get { return strBairro; }
            set { strBairro = value; }
        }
        public string cidadeVO
        {
            get { return strCidade; }
            set { strCidade = value; }
        }
        public string ufVO
        {
            get { return strUF; }
            set { strUF = value; }
        }
        public string cepVO
        {
            get { return strCep; }
            set { strCep = value; }
        }

        EnderecosController controllerEnderecos = new EnderecosController();

        public ImportEnderecos()
        {
            InitializeComponent();
            radioBttnComeca.Checked = true;
            cbButtonPesquisarEm.SelectedIndex = 0;
            txtBoxPesquisar.Focus();
            txtBoxPesquisar.Select(0, 0);
          //  txtBoxIdEndereco.Visible = false;
            groupBox1.Visible = false;
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

            if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Logradouro"))
            {

                dataGridImpEndereco.DataSource = controllerEnderecos.PesquisarComecaCom("logradouro", "@logradouro", txtBoxPesquisar.Text);
                DataGridModel();
                // toolStripLabel2.Text = Convert.ToString(controllerEnderecos.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Logradouro"))
            {

                dataGridImpEndereco.DataSource = controllerEnderecos.PesquisarContemCom("logradouro", "@logradouro", txtBoxPesquisar.Text);
                DataGridModel();
                //  toolStripLabel2.Text = Convert.ToString(controllerEnderecos.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Logradouro"))
            {

                dataGridImpEndereco.DataSource = controllerEnderecos.PesquisarTerminaCom("logradouro", "@logradouro", txtBoxPesquisar.Text);
                DataGridModel();
                // toolStripLabel2.Text = Convert.ToString(controllerEnderecos.retornoQuantPesquisa());
            }

            if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Bairro"))
            {

                dataGridImpEndereco.DataSource = controllerEnderecos.PesquisarComecaCom("bairro", "@bairro", txtBoxPesquisar.Text);
                DataGridModel();
                // toolStripLabel2.Text = Convert.ToString(controllerEnderecos.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Bairro"))
            {

                dataGridImpEndereco.DataSource = controllerEnderecos.PesquisarContemCom("bairro", "@bairro", txtBoxPesquisar.Text);
                DataGridModel();
                //  toolStripLabel2.Text = Convert.ToString(controllerEnderecos.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Bairro"))
            {

                dataGridImpEndereco.DataSource = controllerEnderecos.PesquisarTerminaCom("bairro", "@bairro", txtBoxPesquisar.Text);
                DataGridModel();
                // toolStripLabel2.Text = Convert.ToString(controllerEnderecos.retornoQuantPesquisa());
            }
        }

        private void DataGridModel()
        {
            dataGridImpEndereco.Columns[0].HeaderText = "ID";
            dataGridImpEndereco.Columns[1].HeaderText = "Logradouro";
            dataGridImpEndereco.Columns[2].HeaderText = "Bairro";
            dataGridImpEndereco.Columns[3].HeaderText = "Cidade";
            dataGridImpEndereco.Columns[4].HeaderText = "UF";
            dataGridImpEndereco.Columns[5].HeaderText = "Cep";
            dataGridImpEndereco.Columns[0].Width = 80;
            dataGridImpEndereco.Columns[1].Width = 150;
            dataGridImpEndereco.Columns[2].Width = 150;
            dataGridImpEndereco.Columns[3].Width = 150;
            dataGridImpEndereco.Columns[4].Width = 80;
            dataGridImpEndereco.Columns[5].Width = 100;
        }

        public void behaviorClickGrid()
        {
            strID           =  Convert.ToString(dataGridImpEndereco.CurrentRow.Cells[0].Value.ToString());
            strLogradouro   =  dataGridImpEndereco.CurrentRow.Cells[1].Value.ToString();
            strBairro       =  dataGridImpEndereco.CurrentRow.Cells[2].Value.ToString();
            strCidade       =  dataGridImpEndereco.CurrentRow.Cells[3].Value.ToString();
            strUF           =  dataGridImpEndereco.CurrentRow.Cells[4].Value.ToString();
            strCep          =  dataGridImpEndereco.CurrentRow.Cells[5].Value.ToString();
            Close();
        }


        public void salvarNovoEndereco() {
            EnderecosController novoEndereco = new EnderecosController();
            novoEndereco.Salvar(txtLogradouro.Text, txtBairro.Text, txtCidade.Text, txtUf.Text, txtCep.Text);
        }
        private void cbButtnQuantPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        public void limparCampos() {
            txtBoxPesquisar.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            txtCep.Text = "";

        }

        private void formCrudPessoas_Load(object sender, EventArgs e)
        {

        }

        private void radBttnFirst_CheckedChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radBttnLast_CheckedChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
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
            puxarparametroPesquisa();
        }


        private void radBttnLast_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radBttnFirst_CheckedChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void cbButtnQuantPage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_ClientSizeChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void cbButtonPesquisarEm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnContem_CheckedChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_TextChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnComeca_CheckedChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            behaviorClickGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            behaviorClickGrid();
        }

        private void radioBttnComeca_CheckedChanged_3(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnContem_CheckedChanged_3(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void cbButtonPesquisarEm_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_TextChanged_3(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            behaviorClickGrid();
        }

        private void txtBoxPesquisar_TextChanged_4(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnComeca_CheckedChanged_4(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void dataGridImpEndereco_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            behaviorClickGrid();
        }

        private void radioBttnContem_CheckedChanged_4(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnTermina_CheckedChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void cbButtonPesquisarEm_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            salvarNovoEndereco();
            limparCampos();
            groupBox1.Visible = false;
            tabControlAssets.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControlAssets.Visible = false;
            limparCampos();
            puxarparametroPesquisa();
            groupBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limparCampos();
            groupBox1.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ImportEnderecos_Load(object sender, EventArgs e)
        {

        }
    }

}
