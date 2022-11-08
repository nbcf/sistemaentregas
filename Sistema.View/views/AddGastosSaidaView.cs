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

namespace Sistema.View.views
{
   

    public partial class AddGastosSaidaView : Form
    {
        public string strIdFornecedores;
        public string strIdTipoGastos;
        public string strIdTipoUnit;
        public string strTipoUnit;

        public string strAcaoDialog = "";
        public string strAcaoForm = "";
        public string strIdSaida = "";

        public string IdSaidaVO{
            get { return strIdSaida; }
            set { strIdSaida = value; }
        }

        public string AcaoDialogVO{
            get { return strAcaoDialog; }
            set { strAcaoDialog = value; }
        }

        public string AcaoFormVO{
            get { return strAcaoForm; }
            set { strAcaoForm = value; }
        }

        GastosController controllerGastos = new GastosController();
        FornecedoresController controllerFornecedores = new FornecedoresController();
        TipoGastosController controllerTipoGastos = new TipoGastosController();
        TipoUndsController controllerTipoUnds = new TipoUndsController();



        public AddGastosSaidaView()
        {
            InitializeComponent();
           
        }

   

        private void bttnNew_Click(object sender, EventArgs e)
        {
            carregarPadraoComboBox();
        }

        private void AddGastosSaidaView_Load(object sender, EventArgs e)
        {
            txtIdSaida.Text = IdSaidaVO;
            refresh();
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh() {

            dataGridView1.DataSource = controllerGastos.ListarDataGridAddSaidaController(Convert.ToInt32(IdSaidaVO));


        }

        public void save() {
            controllerGastos.Salvar(
                Convert.ToInt32(txtIdSaida.Text),
                Convert.ToInt32(txtIdFornecedor.Text),
                Convert.ToInt32(txtIdTipogasto.Text),
                txtqt.Text,
                txtIdTipoUnit.Text,
                txtvalorunt.Text,
                txtvalortotal.Text,
                txtkm.Text,
                dateTimePicker1.Value,
                txtnumnota.Text,
                "");
              
        }


        public void edit() {

            controllerGastos.Editar(Convert.ToInt32(txtIdSaida.Text),
              Convert.ToInt32(txtIdFornecedor.Text),
              Convert.ToInt32(txtIdTipogasto.Text),
              txtqtd.Text,
              txtIdTipoUnit.Text,
              txtvalorunt.Text,
              txtvalortotal.Text,
              txtkm.Text,
              dateTimePicker1.Value,
              txtnumnota.Text,
              "",
              Convert.ToInt32(txtidgastos.Text));
            refresh();

        }

        public void carregarEstadoPadrao() {
            desabilitarcampos();
            limparcampos();



        }


        public void desabilitarcampos() {
            txtIdTipoUnit.Enabled = false;
            txtqtd.Enabled = false;
            txtIdTipogasto.Enabled = false;
            txtIdFornecedor.Enabled = false;
            txtIdSaida.Enabled = false;
            txtidgastos.Enabled = false;
            txtJoinTipoUnit.Enabled = false;



        }

        public void SetarId() { 
        
        txtidgastos.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();



        }
        public void limparcampos() {

            cbFornecedor.Items.Clear();
            cbTipoGasto.Items.Clear();
            cbTipoUnit.Items.Clear();
            txtnumnota.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            txtkm.Text = "";
            txtqt.Text = "";
            txtvalorunt.Text = "";
            txtvalortotal.Text = "";

            txtIdTipoUnit.Text = "";
            txtqtd.Text = "";
            txtIdTipogasto.Text = "";
            txtIdFornecedor.Text = "";
           // txtIdSaida.Text = "";
            txtidgastos.Text = "";
            txtJoinTipoUnit.Text = "";

        }


        public void excluir() {
            controllerGastos.Excluir(Convert.ToInt32(txtidgastos.Text));
            refresh();
        }
        private void bttnSave_Click(object sender, EventArgs e)
        {

        }

        private void bttnDel_Click(object sender, EventArgs e)
        {

        }


        public void carregarPadraoComboBox(){

            cbFornecedor.DataSource = controllerFornecedores.ListarEmComboBox();
            cbFornecedor.ValueMember = "idfornecedor";
            cbFornecedor.DisplayMember = "fornecedor";

            if (cbFornecedor.Items.Count > 0){
                txtIdFornecedor.Text = cbFornecedor.SelectedValue.ToString();
                strIdFornecedores = txtIdFornecedor.Text;
            }


            cbTipoGasto.DataSource = controllerTipoGastos.ListarEmComboBox();
            cbTipoGasto.ValueMember = "idtipogasto";
            cbTipoGasto.DisplayMember = "nomegasto";

            if (cbTipoGasto.Items.Count > 0){
                cbTipoUnit.DataSource = controllerTipoGastos.ComplementoComboBoxTipoUnds(Convert.ToInt32(cbTipoGasto.SelectedValue.ToString()));
                cbTipoUnit.ValueMember = "idtipound";
                cbTipoUnit.DisplayMember = "nomeund";

                strIdTipoUnit = cbTipoUnit.SelectedValue.ToString();
                strTipoUnit = cbTipoUnit.Text;
                strIdTipoGastos = cbTipoGasto.SelectedValue.ToString();

                txtIdTipoUnit.Text = strIdTipoUnit;
                txtJoinTipoUnit.Text = strTipoUnit;
                txtIdTipogasto.Text = strIdTipoGastos;
                txtJoinTipoUnit.Enabled = false;
            }

        }

        private void cbTipoGasto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoGasto.Items.Count > 0 && cbTipoUnit.Items.Count > 0)
            {
                cbTipoUnit.DataSource = controllerTipoGastos.ComplementoComboBoxTipoUnds(Convert.ToInt32(cbTipoGasto.SelectedValue.ToString()));
                cbTipoUnit.ValueMember = "idtipound";
                cbTipoUnit.DisplayMember = "nomeund";

                strIdTipoUnit = cbTipoUnit.SelectedValue.ToString();
                strTipoUnit = cbTipoUnit.Text;
                strIdTipoGastos = cbTipoGasto.SelectedValue.ToString();

                txtIdTipoUnit.Text = strIdTipoUnit;
                txtJoinTipoUnit.Text = strTipoUnit;
                txtIdTipogasto.Text = strIdTipoGastos;

                txtJoinTipoUnit.Enabled = false;
                //txtIdTipoUnit.Text          =   cbTipoUnit.SelectedValue.ToString();
                //txtJoinTipoUnit.Text        =   cbTipoUnit.Text;
                //txtIdTipogasto.Text         =   cbTipoGasto.SelectedValue.ToString();
            }

        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFornecedor.Items.Count > 0)
            {

                txtIdFornecedor.Text = cbFornecedor.SelectedValue.ToString();
                strIdFornecedores = txtIdFornecedor.Text;


            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnSave_Click_1(object sender, EventArgs e)
        {
            save();
        }
    }
}
