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



        public AddGastosSaidaView() {
            InitializeComponent();
            carregarEstadoPadrao();


        }

   

        private void bttnNew_Click(object sender, EventArgs e){
            limparcampos();
            abilitarcampos();
            bttnSave.Enabled = true;
            bttnNew.Enabled = false;
            bttnDel.Enabled = false;
            bttnRefresh.Enabled = true;
            carregarPadraoComboBox();
        }

        private void AddGastosSaidaView_Load(object sender, EventArgs e){
            txtIdSaida.Text = IdSaidaVO;
            refresh();
        }

        private void bttnRefresh_Click(object sender, EventArgs e){
            refresh();
        }

        public void refresh() {

            dataGridGastos.DataSource = controllerGastos.ListarDataGridAddSaidaController(Convert.ToInt32(IdSaidaVO));
            DataGridModel();
            limparcampos();
            desabilitarcampos();
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            bttnDel.Enabled = false;
            bttnRefresh.Enabled = true;
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
                Convert.ToDateTime(dateTimePicker1.Value.ToString("dd/MM/yyyy")), 
                txtnumnota.Text,
                "");
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            bttnDel.Enabled = false;
            bttnRefresh.Enabled = true;
            refresh();

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
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            bttnDel.Enabled = false;
            bttnRefresh.Enabled = true;
            //txtIdTipogasto.Visible     = false;
            //txtIdFornecedor.Visible     = false;
            //txtIdSaida.Visible          = false;
            //txtidgastos.Visible         = false;
            //txtJoinTipoUnit.Visible     = false;
            //txtIdTipoUnit.Visible = false;
            //txtqtd.Visible = false;
          //  dataGridGastos.DataSource = controllerGastos.ListarDataGridAddSaidaController(Convert.ToInt32(IdSaidaVO));
         //   DataGridModel();

        }



        public void abilitarcampos(){
            cbFornecedor.Enabled = true;
            cbTipoGasto.Enabled = true;
            cbTipoUnit.Enabled = true;
            txtnumnota.Enabled = true;
            dateTimePicker1.Value = DateTime.Now;
            txtkm.Enabled = true;
            txtqt.Enabled = true;
            txtvalorunt.Enabled = true;
            txtvalortotal.Enabled = true;
            txtIdTipoUnit.Enabled = true;
            txtqtd.Enabled = true;
            txtIdTipogasto.Enabled = true;
            txtIdFornecedor.Enabled = true;
            txtIdSaida.Enabled = true;
            txtidgastos.Enabled = true;
            txtJoinTipoUnit.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        public void desabilitarcampos() {

            cbFornecedor.Enabled = false;
            cbTipoGasto.Enabled = false;
            cbTipoUnit.Enabled = false;
            txtnumnota.Enabled = false;
            dateTimePicker1.Value = DateTime.Now;
            txtkm.Enabled = false;
            txtqt.Enabled = false;
            txtvalorunt.Enabled = false;
            txtvalortotal.Enabled = false;
            txtIdTipoUnit.Enabled = false;
            txtqtd.Enabled = false;
            txtIdTipogasto.Enabled = false;
            txtIdFornecedor.Enabled = false;
            txtIdSaida.Enabled = false;
            txtidgastos.Enabled = false;
            txtJoinTipoUnit.Enabled = false;
            dateTimePicker1.Enabled = false;
            
        }

     

        public void limparcampos() {
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
            txtidgastos.Text = "";
            txtJoinTipoUnit.Text = "";
            dataGridGastos.ClearSelection();

        }


        public void excluir() {
            controllerGastos.Excluir(Convert.ToInt32(txtidgastos.Text));
            refresh();
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

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e){
            if (cbFornecedor.Items.Count > 0){
                txtIdFornecedor.Text = cbFornecedor.SelectedValue.ToString();
                strIdFornecedores = txtIdFornecedor.Text;


            }
        }

        private void bttnSave_Click_1(object sender, EventArgs e)
        {
            save();
            
        }

        public void DataGridModel() {


             dataGridGastos.Columns[0].HeaderText = "ID";
            //dataGridGastos.Columns[1].HeaderText = "ID Origem";
            //dataGridGastos.Columns[2].HeaderText = "ID Veiculo"; //
            //dataGridGastos.Columns[3].HeaderText = "ID Entregador"; //
            //dataGridGastos.Columns[4].HeaderText = "VEÍCULO"; //
            //dataGridGastos.Columns[5].HeaderText = "PLACA"; //
            //dataGridGastos.Columns[6].HeaderText = "ENTREGADOR"; //
            //dataGridGastos.Columns[7].HeaderText = "PESO"; //
            //dataGridGastos.Columns[8].HeaderText = "ENCOMENDA"; //
            //dataGridGastos.Columns[9].HeaderText = "ESTATUS";
            //dataGridGastos.Columns[10].HeaderText = "CPF";
            //dataGridGastos.Columns[11].HeaderText = "DESTINATARIO";
           //dataGridGastos.Columns[0].Visible = false;
           //dataGridGastos.Columns[1].Visible = false;
           //dataGridGastos.Columns[2].Visible = false;
           //dataGridGastos.Columns[3].Visible = false;
           //dataGridGastos.Columns[11].Visible = false;


        }

        private void dataGridGastos_CellClick(object sender, DataGridViewCellEventArgs e){
            
                txtidgastos.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
                txtIdSaida.Text =  dataGridGastos.CurrentRow.Cells[1].Value.ToString();
                txtIdFornecedor.Text =  dataGridGastos.CurrentRow.Cells[2].Value.ToString();
                txtIdTipogasto.Text = dataGridGastos.CurrentRow.Cells[3].Value.ToString();
                txtqt.Text = dataGridGastos.CurrentRow.Cells[4].Value.ToString();
                
            //dateTimePicker1.Value = Convert.ToDateTime(dataGridGastos.CurrentRow.Cells[0].Value);
            //txtvalorunt.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();
            //txtvalortotal.Text = dataGridGastos.CurrentRow.Cells[0].Value.ToString();





        }
    }
}
