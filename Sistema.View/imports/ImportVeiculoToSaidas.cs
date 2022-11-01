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
            gridImportVS.Columns[1].HeaderText = "Veiculo";
            gridImportVS.Columns[2].HeaderText = "Placa";
            gridImportVS.Columns[3].HeaderText = "Estatus";
  
            gridImportVS.Columns[0].Width = 80;
            gridImportVS.Columns[1].Width = 150;
            gridImportVS.Columns[2].Width = 90;
            gridImportVS.Columns[3].Width = 90;
            gridImportVS.Columns[3].Visible = false;
        }

        public void behaviorClickGrid()
        {
         //   NovaSaidaView novasaida = new NovaSaidaView();

            //if (IdVO == "")
            //{

            //    MessageBox.Show("Vazio");

                strID = gridImportVS.CurrentRow.Cells[0].Value.ToString();
                strVeiculo = gridImportVS.CurrentRow.Cells[1].Value.ToString();
                strPlaca = gridImportVS.CurrentRow.Cells[2].Value.ToString();
                strEstVeiculo = gridImportVS.CurrentRow.Cells[3].Value.ToString();
              //   controllerVeiculo.EditarEstatusVeiculo(strVeiculo, strPlaca, "Em Rota", Convert.ToInt32(strID));
                Close();

            //}
            //else if (IdVO != "")
            //{
            //    string oldId;
            //    string oldVeiculo;
            //    string oldPlaca;

            //    oldId = IdVO;
            //    oldVeiculo = veiculoVO;
            //    oldPlaca = placaVO;


            //    // Metodo Atualizar
            //    controllerVeiculo.EditarEstatusVeiculo(oldVeiculo, oldPlaca, "Disponivel", Convert.ToInt32(oldId));
            //    MessageBox.Show("Cheio");

            //    strID = gridImportVS.CurrentRow.Cells[0].Value.ToString();
            //    strVeiculo = gridImportVS.CurrentRow.Cells[1].Value.ToString();
            //    strPlaca = gridImportVS.CurrentRow.Cells[2].Value.ToString();
            //    // strEstVeiculo = gridImportVS.CurrentRow.Cells[3].Value.ToString();
            //    controllerVeiculo.EditarEstatusVeiculo(strVeiculo, strPlaca, "Em Rota", Convert.ToInt32(strID));
            //    Close();


            //}

        }

  
        private void gridImportVS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            behaviorClickGrid();
        }

        private void gridImportVS_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridImportVS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
