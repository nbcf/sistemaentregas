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
        SomarCellDataGrid st = new SomarCellDataGrid();
        GastosController        controllerGastos        = new GastosController();
        FornecedoresController  controllerFornecedores  = new FornecedoresController();
        TipoGastosController    controllerTipoGastos    = new TipoGastosController();



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
            dataGridGastos.Enabled = false;
            carregarPadraoComboBox();
        }

        private void AddGastosSaidaView_Load(object sender, EventArgs e){
            txtIdSaida.Text = IdSaidaVO;
            refresh();
        }

        private void bttnRefresh_Click(object sender, EventArgs e){
            refresh();
        }

        public void refresh(){
           
            dataGridGastos.DataSource = controllerGastos.ListarDataGridAddSaidaController(Convert.ToInt32(IdSaidaVO));
            DataGridModel();
            limparcampos();
            desabilitarcampos();
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            bttnDel.Enabled = false;
            bttnRefresh.Enabled = true;
            toolStripButton1.Enabled = false;
            dataGridGastos.Enabled = true;
            bttnNew.Enabled = true;
            bttnSave.Enabled = false;
            toolStripLabel3.Text = SomarTotais().ToString();
            txtIdSaida.Visible = false;
            txtIdFornecedor.Visible = false;
            txtIdTipogasto.Visible = false;
            txtIdTipoUnit.Visible = false;
            txtidgastos.Visible = false;
            txtqtd.Visible = false;
            txtJoinTipoUnit.Visible = false;


        }

        public void save() {
            controllerGastos.Salvar(
                Convert.ToInt32(txtIdSaida.Text),
                Convert.ToInt32(txtIdFornecedor.Text),
                Convert.ToInt32(txtIdTipogasto.Text),
                txtqantidade.Text,
                txtIdTipoUnit.Text,
                txtvalorunt.Text,
                txtvalortotal.Text,
                txtkm.Text,
                Convert.ToDateTime(dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm")), 
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
            toolStripButton1.Enabled = false;

            txtIdSaida.Visible = false;
            txtIdFornecedor.Visible = false;
            txtIdTipogasto.Visible = false;
            txtIdTipoUnit.Visible = false;
            txtidgastos.Visible = false;
            txtqtd.Visible = false;
            txtJoinTipoUnit.Visible = false;
        }



        public void abilitarcampos(){
            cbFornecedor.Enabled = true;
            cbTipoGasto.Enabled = true;
            cbTipoUnit.Enabled = true;
            txtnumnota.Enabled = true;
            dateTimePicker1.Value = DateTime.Now;
            txtkm.Enabled = true;
            txtqantidade.Enabled = true;
            txtvalorunt.Enabled = true;
            txtvalortotal.Enabled = true;
          // txtIdTipoUnit.Enabled = true;
           // txtqtd.Enabled = true;
         //   txtIdTipogasto.Enabled = true;
         //   txtIdFornecedor.Enabled = true;
         //   txtIdSaida.Enabled = true;
         //   txtidgastos.Enabled = true;
         //   txtJoinTipoUnit.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        public void desabilitarcampos() {
            cbFornecedor.Enabled = false;
            cbTipoGasto.Enabled = false;
            cbTipoUnit.Enabled = false;
            txtnumnota.Enabled = false;
            dateTimePicker1.Value = DateTime.Now;
            txtkm.Enabled = false;
            txtqantidade.Enabled = false;
            txtvalorunt.Enabled = false;
            txtvalortotal.Enabled = false;
          //  txtIdTipoUnit.Enabled = false;
        //    txtqtd.Enabled = false;
         //   txtIdTipogasto.Enabled = false;
         //   txtIdFornecedor.Enabled = false;
         //   txtIdSaida.Enabled = false;
          //  txtidgastos.Enabled = false;
          //  txtJoinTipoUnit.Enabled = false;
            dateTimePicker1.Enabled = false;
            
        }

     

        public void limparcampos() {
            txtnumnota.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtkm.Text = "";
            txtqantidade.Text = "";
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
            toolStripButton1.Enabled = false;

        }

        private void cbTipoGasto_SelectedIndexChanged(object sender, EventArgs e){

            if (cbTipoGasto.Items.Count > 0 && cbTipoUnit.Items.Count > 0){

                cbTipoUnit.DataSource       = controllerTipoGastos.ComplementoComboBoxTipoUnds(Convert.ToInt32(cbTipoGasto.SelectedValue.ToString()));
                cbTipoUnit.ValueMember      = "idtipound";
                cbTipoUnit.DisplayMember    = "nomeund";
                strIdTipoUnit               = cbTipoUnit.SelectedValue.ToString();
                strTipoUnit                 = cbTipoUnit.Text;
                strIdTipoGastos             = cbTipoGasto.SelectedValue.ToString();
                txtIdTipoUnit.Text          = strIdTipoUnit;
                txtJoinTipoUnit.Text        = strTipoUnit;
                txtIdTipogasto.Text         = strIdTipoGastos;
                txtJoinTipoUnit.Enabled     = false;
            }
        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e){
            if (cbFornecedor.Items.Count > 0){
                txtIdFornecedor.Text = cbFornecedor.SelectedValue.ToString();
                strIdFornecedores = txtIdFornecedor.Text;
            }
        }

        private void bttnSave_Click_1(object sender, EventArgs e){
            save();
        }

        public void DataGridModel() {
             dataGridGastos.Columns[0].HeaderText = "FORNECEDOR";
             dataGridGastos.Columns[1].HeaderText = "GASTO";
             dataGridGastos.Columns[2].HeaderText = "TIPO"; 
             dataGridGastos.Columns[3].HeaderText = "QTD"; 
             dataGridGastos.Columns[4].HeaderText = "VALOR"; 
             dataGridGastos.Columns[5].HeaderText = "TOTAL"; 
             dataGridGastos.Columns[6].HeaderText = "N. NOTA";
             dataGridGastos.Columns[7].HeaderText = "DATA";
             dataGridGastos.Columns[8].HeaderText = "KM"; 
             dataGridGastos.Columns[0].Width = 180;
             dataGridGastos.Columns[1].Width = 150;
             dataGridGastos.Columns[2].Width = 60;
             dataGridGastos.Columns[3].Width = 60;
             dataGridGastos.Columns[4].Width = 60;
             dataGridGastos.Columns[5].Width = 80;
             dataGridGastos.Columns[6].Width = 80;
             dataGridGastos.Columns[7].Width = 80;
             dataGridGastos.Columns[8].Width = 80;
             dataGridGastos.Columns[9].Visible = false;
             dataGridGastos.Columns[10].Visible = false;
             dataGridGastos.Columns[11].Visible = false;
             dataGridGastos.Columns[12].Visible = false;
             dataGridGastos.Columns[13].Visible = false;

        }

        private void dataGridGastos_CellClick(object sender, DataGridViewCellEventArgs e){
            cbFornecedor.Text       =       dataGridGastos.CurrentRow.Cells[0].Value.ToString(); 
            cbTipoGasto.Text        =       dataGridGastos.CurrentRow.Cells[1].Value.ToString();
            cbTipoUnit.Text         =       dataGridGastos.CurrentRow.Cells[2].Value.ToString();
            txtJoinTipoUnit.Text    =       dataGridGastos.CurrentRow.Cells[2].Value.ToString();
            txtqantidade.Text              =       dataGridGastos.CurrentRow.Cells[3].Value.ToString();
            txtvalorunt.Text        =       dataGridGastos.CurrentRow.Cells[4].Value.ToString();
            txtvalortotal.Text      =       dataGridGastos.CurrentRow.Cells[5].Value.ToString();
            txtnumnota.Text         =       dataGridGastos.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker1.Value   =       Convert.ToDateTime(dataGridGastos.CurrentRow.Cells[7].Value.ToString());
            txtkm.Text              =       dataGridGastos.CurrentRow.Cells[8].Value.ToString();
            txtidgastos.Text        =       dataGridGastos.CurrentRow.Cells[9].Value.ToString();
      //      txtIdSaida.Text         =       dataGridGastos.CurrentRow.Cells[8].Value.ToString();
            txtIdFornecedor.Text    =       dataGridGastos.CurrentRow.Cells[11].Value.ToString();
            txtIdTipogasto.Text     =       dataGridGastos.CurrentRow.Cells[12].Value.ToString();
            txtIdTipoUnit.Text      =       dataGridGastos.CurrentRow.Cells[13].Value.ToString();
            
            bttnNew.Enabled = false;
            bttnSave.Enabled = false;
            toolStripButton1.Enabled = true;
            bttnDel.Enabled = true;

        }

        private void toolStripButton1_Click(object sender, EventArgs e){
            toolStripButton1.Enabled = false;
            abilitarcampos();
            dataGridGastos.Enabled = false;
            bttnDel.Enabled = false;
            bttnNew.Enabled = false;
            bttnSave.Enabled = true;
        }

        private void bttnDel_Click(object sender, EventArgs e) {
            excluir();
        }

        public int SomarTotais(){
            return st.SomarTotais(dataGridGastos.RowCount, dataGridGastos, "valortotal");
        }
    }
}
