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

        public string strId;

        public string IdSaidaVO

        {
            get { return strId; }
            set { strId = value; }
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
            strId = IdSaidaVO;
            atualizar(IdSaidaVO);
        }


        public void DataGridModel() {
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].Width = 138;


        }
        private void ListaView_Load(object sender, EventArgs e)
        {
            carregarEstadoPadrao();
        }

       

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            carregarEstadoPadrao();
        }
    }
}
