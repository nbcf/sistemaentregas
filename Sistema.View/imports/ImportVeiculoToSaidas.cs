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
    public partial class ImportVeiculoToSaidas : Form
    {
        public string strID;
        public string strVeiculo;
        public string strPlaca;
        public string strEstVeiculo;

        public string IdVO
        {
            get { return strID; }
            set { strID = value; }
        }
        public string veiculoVO
        {
            get { return strVeiculo; }
            set { strVeiculo = value; }
        }
        public string placaVO
        {
            get { return strPlaca; }
            set { strPlaca = value; }
        }

        public string estatusVO
        {
            get { return strEstVeiculo; }
            set { strEstVeiculo = value; }
        }
        VeiculosController controllerVeiculo = new VeiculosController();

        public ImportVeiculoToSaidas()
        {
            InitializeComponent();
            gridImportVS.DataSource = controllerVeiculo.ConfiListagemImportVS();
            DataGridModel();

        }

        private void DataGridModel()
        {
            gridImportVS.Columns[0].HeaderText = "ID";
            gridImportVS.Columns[1].HeaderText = "VEÍCULO";
            gridImportVS.Columns[2].HeaderText = "PLACA";
            gridImportVS.Columns[3].HeaderText = "ESTATUS";
  
            gridImportVS.Columns[0].Width = 60;
            gridImportVS.Columns[1].Width = 250;
            gridImportVS.Columns[2].Width = 100;
            gridImportVS.Columns[3].Width = 100;
            gridImportVS.Columns[3].Visible = false;
        }

        public void behaviorClickGrid(){
                strID = gridImportVS.CurrentRow.Cells[0].Value.ToString();
                strVeiculo = gridImportVS.CurrentRow.Cells[1].Value.ToString();
                strPlaca = gridImportVS.CurrentRow.Cells[2].Value.ToString();
                strEstVeiculo = gridImportVS.CurrentRow.Cells[3].Value.ToString();
                Close();
        }

  
        private void gridImportVS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            behaviorClickGrid();
        }

      
    }

}
