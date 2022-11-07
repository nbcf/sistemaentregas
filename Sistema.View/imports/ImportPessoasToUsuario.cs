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
    public partial class ImportPessoasToUsuario : Form
    {
        public string stringID;
        public string strAcaoDialog = "";
        public string strFormAcaoDialogVO = "";
        public string IdPessoasVO
        {
            get { return stringID; }
            set { stringID = value; }
        }

        public string AcaoDialogVO
        {

            get { return strAcaoDialog; }
            set { strAcaoDialog = value; }
        }
        public string FormAcaoDialogVO
        {

            get { return strFormAcaoDialogVO; }
            set { strFormAcaoDialogVO = value; }
        }

        PessoasController controllerPessoas = new PessoasController();

        public ImportPessoasToUsuario()
        {
            InitializeComponent();
            radioBttnComeca.Checked = true;
            txtBoxPesquisar.Focus();

        }

        private void puxarparametroPesquisa()
        {
            string estadoPesquisa = "";
            //string pesquisarEmColuna = Convert.ToString(cbButtonPesquisarEm.SelectedItem);

            if (radioBttnComeca.Checked == true) { estadoPesquisa = "ComecaCom"; }
            else if (radioBttnContem.Checked == true) { estadoPesquisa = "Contem"; }
            else if (radioBttnTermina.Checked == true) { estadoPesquisa = "TerminaCom"; }
            else if (radioBttnComeca.Checked == false) { estadoPesquisa = ""; }
            else if (radioBttnContem.Checked == false) { estadoPesquisa = ""; }
            else if (radioBttnTermina.Checked == false) { estadoPesquisa = ""; }

            if (estadoPesquisa.Equals("ComecaCom"))
            {

                dataGridView1.DataSource = controllerPessoas.PesquisarComecaCom("nomepessoa", "@nomepessoa", txtBoxPesquisar.Text);
                DataGridModel();
                // toolStripLabel2.Text = Convert.ToString(controllerPessoas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("Contem"))
            {

                dataGridView1.DataSource = controllerPessoas.PesquisarContemCom("nomepessoa", "@nomepessoa", txtBoxPesquisar.Text);
                DataGridModel();
                //  toolStripLabel2.Text = Convert.ToString(controllerPessoas.retornoQuantPesquisa());
            }
            else if (estadoPesquisa.Equals("TerminaCom"))
            {

                dataGridView1.DataSource = controllerPessoas.PesquisarTerminaCom("nomepessoa", "@nomepessoa", txtBoxPesquisar.Text);
                DataGridModel();
                // toolStripLabel2.Text = Convert.ToString(controllerPessoas.retornoQuantPesquisa());
            }
        }


        private void DataGridModel()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "IDNOMEPESSOA";
            dataGridView1.Columns[2].HeaderText = "PESSOA";
            dataGridView1.Columns[3].HeaderText = "Comp./N°";
            dataGridView1.Columns[4].HeaderText = "IDENDERECO";
            dataGridView1.Columns[5].HeaderText = "LOGRADOURO";
            dataGridView1.Columns[6].HeaderText = "BAIRRO";
            dataGridView1.Columns[7].HeaderText = "CIDADE";
            dataGridView1.Columns[8].HeaderText = "UF";
            dataGridView1.Columns[9].HeaderText = "CEP";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 0;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 0;
            dataGridView1.Columns[5].Width = 200;
            dataGridView1.Columns[6].Width = 200;
            dataGridView1.Columns[7].Width = 150;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[9].Width = 100;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
           

        }

        public void behaviorClickGrid()
        {
            stringID = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());
           
        }


        private void cbButtnQuantPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();

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


        private void radioBttnTermina_CheckedChanged_2(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnContem_CheckedChanged_4(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void radioBttnComeca_CheckedChanged_4(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void cbButtonPesquisarEm_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_TextChanged_4(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }



        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdPessoasVO = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            AcaoDialogVO = "Importou";
           
            Close();
         //   AcaoDialogVO.Equals("Importou") FormAcaoDialogVO.Equals("N"))
            
}
       

        private void ImportPessoasToUsuario_Load(object sender, EventArgs e)
        {

        }

      
    }

}
