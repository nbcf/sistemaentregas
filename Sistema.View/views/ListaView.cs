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
    public partial class ListaView : Form
    {
        public string IdSaidaVO
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        EncomendasController controllerEncomendas = new EncomendasController();
        public ListaView()
        {
            InitializeComponent();
            
        }



        public void atualizar(string idsaida) {
          dataGridView1.DataSource =  controllerEncomendas.ListarDetalheMestreUnion(idsaida, "Saiu para entrega", "Entregue");
          DataGridModel();
        }

        public void carregarEstadoPadrao() {
            textBox1.Text = IdSaidaVO;
            atualizar(IdSaidaVO);
        }


        public void DataGridModel() {
            //dataGridView1.Columns[0].Width = 50;
            //dataGridView1.Columns[1].Width = 0;
            //dataGridView1.Columns[2].Width = 0;
            //dataGridView1.Columns[3].Width = 0;
            //dataGridView1.Columns[4].Width = 0;
            //dataGridView1.Columns[5].Width = 0;
            //dataGridView1.Columns[6].Width = 0;
            //dataGridView1.Columns[7].Width = 70;
            //dataGridView1.Columns[8].Width = 100;
            //dataGridView1.Columns[9].Width = 0;
            //dataGridView1.Columns[10].Width = 0;
            //dataGridView1.Columns[11].Width = 150;
            //dataGridView1.Columns[12].Width = 150;
            //dataGridView1.Columns[13].Width = 100;
            //dataGridView1.Columns[14].Width = 150;
            //dataGridView1.Columns[15].Width = 150;
            //dataGridView1.Columns[16].Width = 50;
            //dataGridView1.Columns[17].Width = 80;
            //dataGridView1.Columns[18].Width = 0;
            //dataGridView1.Columns[19].Width = 0;
            //dataGridView1.Columns[20].Width = 0;
            //dataGridView1.Columns[21].Width = 100;
            //dataGridView1.Columns[22].Width = 0;
            //dataGridView1.Columns[0].Visible = true;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[6].Visible = false;
            //dataGridView1.Columns[9].Visible = false;
            //dataGridView1.Columns[10].Visible = false;
            //dataGridView1.Columns[18].Visible = false;
            //dataGridView1.Columns[19].Visible = false;
            //dataGridView1.Columns[20].Visible = false;
            //dataGridView1.Columns[22].Visible = false;


            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ID Origem";
            dataGridView1.Columns[2].HeaderText = "ID Veiculo"; //
            dataGridView1.Columns[3].HeaderText = "ID Entregador"; //
            dataGridView1.Columns[4].HeaderText = "Nome Veiculo"; //
            dataGridView1.Columns[5].HeaderText = "Placa"; //
            dataGridView1.Columns[6].HeaderText = "Entregador"; //
            dataGridView1.Columns[7].HeaderText = "PESO"; //
            dataGridView1.Columns[8].HeaderText = "NUM. ENCO."; //
            dataGridView1.Columns[9].HeaderText = "ESTATUS";
            dataGridView1.Columns[10].HeaderText = "CPF";
            dataGridView1.Columns[11].HeaderText = "DESTINATARIO";
            dataGridView1.Columns[12].HeaderText = "LOGRADOURO";
            dataGridView1.Columns[13].HeaderText = "COMPLEMENTO";
            dataGridView1.Columns[14].HeaderText = "BAIRRO";
            dataGridView1.Columns[15].HeaderText = "CIDADE";
            dataGridView1.Columns[16].HeaderText = "UF";
            dataGridView1.Columns[17].HeaderText = "CEP";
            dataGridView1.Columns[18].HeaderText = "Data Entrega";
            dataGridView1.Columns[19].HeaderText = "Data Rota";
            dataGridView1.Columns[20].HeaderText = "Data Entrada";
            dataGridView1.Columns[21].HeaderText = "IDSaida"; //
            dataGridView1.Columns[22].HeaderText = "ID Origem Join 1";
            dataGridView1.Columns[23].HeaderText = "ORIGEM";
            dataGridView1.Columns[24].HeaderText = "CD. ORIGEM";

        }
        private void ListaView_Load(object sender, EventArgs e)
        {
            carregarEstadoPadrao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregarEstadoPadrao();
        }
    }
}
