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
    public partial class ImportOrigemToEncomendas : Form
    {
        public string strAcaoDialog = "";
        public string strAcaoForm = "";
        public string strID;
        public string strOrigem;
        public string strCodigoOrigem;

        public string IdVO
        {
            get { return strID; }
            set { strID = value; }
        }
        public string origemVO
        {
            get { return strOrigem; }
            set { strOrigem = value; }
        }
        public string codigoOrigemVO
        {
            get { return strCodigoOrigem; }
            set { strCodigoOrigem = value; }
        }


        public string AcaoDialogVO {

            get { return strAcaoDialog; }
            set { strAcaoDialog = value; }
        }
        public string AcaoFormVO {

            get { return strAcaoForm; }
            set { strAcaoForm = value; }
        }
        OrigemController controllerOrigem = new OrigemController();

        public ImportOrigemToEncomendas()
        {           

        InitializeComponent();

            dataGridView1.DataSource = controllerOrigem.ConfiListagemImpOE();
            DataGridModel();

        }


        private void DataGridModel()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Origem";
            dataGridView1.Columns[2].HeaderText = "Codigo Origem";


            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[0].Visible = false;

        }

        public void behaviorClickGrid()
        {
            strID = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            strOrigem = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            strCodigoOrigem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            AcaoDialogVO = "Confirmado";
            AcaoFormVO = "MC";
            Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            behaviorClickGrid();
        }

        private void ImportOrigemToEncomendas_Load(object sender, EventArgs e)
        {

        }

        private void ImportOrigemToEncomendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            AcaoFormVO = "btnFechar";
        }


        //private void cbButtnQuantPage_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}



        //private void formCrudPessoas_Load(object sender, EventArgs e)
        //{

        //}

        //private void radBttnFirst_CheckedChanged(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void radBttnLast_CheckedChanged(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void radioBttnContem_CheckedChanged(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void radioBttnTermina_CheckedChanged(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void radioBttnComeca_CheckedChanged(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void txtBoxPesquisar_TextChanged(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}



        //private void radioBttnTermina_CheckedChanged_1(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void radioBttnComeca_CheckedChanged_1(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void radioBttnContem_CheckedChanged_1(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void cbButtonPesquisarEm_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void txtBoxPesquisar_TextChanged_1(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void cbOrdemParam_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}


        //private void radBttnLast_CheckedChanged_1(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void radBttnFirst_CheckedChanged_1(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void cbButtnQuantPage_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void txtBoxPesquisar_ClientSizeChanged(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void cbButtonPesquisarEm_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void radioBttnContem_CheckedChanged_2(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void txtBoxPesquisar_TextChanged_2(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void radioBttnComeca_CheckedChanged_2(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void tabPagePesquisar_Click(object sender, EventArgs e)
        //{

        //}



        //private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    behaviorClickGrid();
        //}

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    behaviorClickGrid();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void radioBttnComeca_CheckedChanged_3(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void radioBttnContem_CheckedChanged_3(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void cbButtonPesquisarEm_SelectedIndexChanged_2(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void txtBoxPesquisar_TextChanged_3(object sender, EventArgs e)
        //{
        //    puxarparametroPesquisa();
        //}

        //private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        //{
        //    behaviorClickGrid();
        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    Close();
        //}
    }
}


