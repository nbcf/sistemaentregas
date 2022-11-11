using Sistema.Controller;
using Sistema.View.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View.relatorios
{
    public partial class RelatorioConsumoVeiculos : Form
    {
        public RelatorioConsumoVeiculos()
        {
            InitializeComponent();

        }
        SaidasController controllerSaida = new SaidasController();
        VeiculosController controllerVeiculos = new VeiculosController();
        GastosController controllerGastos = new GastosController();
        TipoGastosController controllerTipoGastos = new TipoGastosController();
        SomarCellDataGrid somarCellTotal = new SomarCellDataGrid();


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVeiculo.Items.Count > 0)
            {
                DataRowView dataRowView = (DataRowView)cbVeiculo.SelectedItem;
                txtPlaca.Text = Convert.ToString(dataRowView.Row["placa"]);
                textBox1.Text = cbVeiculo.SelectedValue.ToString();

            }
        }

        private void RelatorioConsumoVeiculos_Load(object sender, EventArgs e)
        {
            carregarPadraoComboBox();
            textBox1.Visible = false;
            textBox6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerSaida.ListarConsumoPorVeiculoNoPeriodocontroller(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox6.Text), dateTimePicker1.Value, dateTimePicker2.Value);
            ModelDataGrid();
            txtTotal.Text           = somarCellTotal.SomarTotais(dataGridView1.RowCount, dataGridView1, "TOTAL_NTA").ToString();
            txtKmPercorrido.Text    = somarCellTotal.SomarTotais(dataGridView1.RowCount, dataGridView1, "PERCORRIDO").ToString();
            txtQtd.Text             = somarCellTotal.SomarTotais(dataGridView1.RowCount, dataGridView1, "QTD").ToString();
            lbContagemLinhas.Text = dataGridView1.RowCount.ToString();



        }


        public void carregarPadraoComboBox()
        {
            cbVeiculo.DataSource = controllerVeiculos.ListarVeiculosEmComboBoxController();
            cbVeiculo.ValueMember = "idveiculo";
            cbVeiculo.DisplayMember = "nomeveiculo";
            DataRowView dataRowView = (DataRowView)cbVeiculo.SelectedItem;
            txtPlaca.Text = Convert.ToString(dataRowView.Row["placa"]);

            cbTipoGasto.DataSource = controllerTipoGastos.ListarEmComboBox();
            cbTipoGasto.ValueMember = "idtipogasto";
            cbTipoGasto.DisplayMember = "nomegasto";

            if (cbTipoGasto.Items.Count > 0)
            {
                textBox6.Text = cbTipoGasto.SelectedValue.ToString();
            }

            if (cbVeiculo.Items.Count > 0)
            {
                textBox1.Text = cbVeiculo.SelectedValue.ToString();
               
            }
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {

        }

        public void ModelDataGrid() {

            dataGridView1.Columns[0].HeaderText = "DATA NOTA";
            dataGridView1.Columns[1].HeaderText = "REGIÃO";
            dataGridView1.Columns[2].HeaderText = "ENTREGADOR";
            dataGridView1.Columns[3].HeaderText = "KM SDA.";
            dataGridView1.Columns[4].HeaderText = "KM NT.";
            dataGridView1.Columns[5].HeaderText = "KM VT.";
            dataGridView1.Columns[6].HeaderText = "PERC.";
            dataGridView1.Columns[7].HeaderText = "DESPE.";
            dataGridView1.Columns[8].HeaderText = "VL.UND.";
            dataGridView1.Columns[9].HeaderText = "QTD";
            dataGridView1.Columns[10].HeaderText = "TOTAL";
            dataGridView1.Columns[11].HeaderText = "FORNECEDOR";
            dataGridView1.Columns[12].HeaderText = "NUM. NOTA";

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 50;
            dataGridView1.Columns[7].Width = 110;
            dataGridView1.Columns[8].Width = 50;
            dataGridView1.Columns[9].Width = 50;
            dataGridView1.Columns[10].Width = 50;
            dataGridView1.Columns[11].Width = 150;
            dataGridView1.Columns[12].Width = 80;




        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoGasto.Items.Count > 0)
            {
                textBox6.Text = cbTipoGasto.SelectedValue.ToString();

            }
        }
    }
}
