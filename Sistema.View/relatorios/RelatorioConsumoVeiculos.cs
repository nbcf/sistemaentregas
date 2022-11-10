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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                textBox1.Text = comboBox1.SelectedValue.ToString();
               
            }
        }

        private void RelatorioConsumoVeiculos_Load(object sender, EventArgs e)
        {
            carregarPadraoComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerSaida.ListarConsumoPorVeiculoNoPeriodocontroller(Convert.ToInt32(textBox1.Text), dateTimePicker1.Value, dateTimePicker2.Value);
        }

        public void carregarPadraoComboBox()
        {
            comboBox1.DataSource = controllerVeiculos.ListarVeiculosEmComboBoxController();
            comboBox1.ValueMember = "idveiculo";
            comboBox1.DisplayMember = "nomeveiculo";


            if (comboBox1.Items.Count > 0){
                textBox1.Text = comboBox1.SelectedValue.ToString();
            }
        }

    }
}
