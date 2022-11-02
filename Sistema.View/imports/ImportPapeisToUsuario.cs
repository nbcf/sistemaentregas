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
    public partial class ImportPapeisToUsuario : Form
    {
        public string stringID;
        public string strAcaoDialog = "";
        public string strFormAcaoDialog;

        public string IdPapeisVO{
            get { return stringID; }
            set { stringID = value; }
        }

        public string AcaoDialogVO{
            get { return strAcaoDialog; }
            set { strAcaoDialog = value; }
        }

        public string FormAcaoDialogVO {
            get { return strFormAcaoDialog; }
            set { strFormAcaoDialog = value; }
        }

        PapeisController controllerPapeis = new PapeisController();

        public ImportPapeisToUsuario(){
            InitializeComponent();
            dataGridView1.DataSource = controllerPapeis.ConfiListagemImportPU();
            DataGridModel();
        }

        private void DataGridModel(){
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Função";
            dataGridView1.Columns[2].HeaderText = "Criar";
            dataGridView1.Columns[3].HeaderText = "Recuperar";
            dataGridView1.Columns[4].HeaderText = "Atualizar";
            dataGridView1.Columns[5].HeaderText = "Excluir";
            dataGridView1.Columns[6].HeaderText = "Operacional";
            dataGridView1.Columns[7].HeaderText = "Administrativo";
            dataGridView1.Columns[8].HeaderText = "Gerencial";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].Width = 80;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

      

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e){
            
            IdPapeisVO = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            AcaoDialogVO = "Importou";
    
            Close();
        }

      
      

        private void ImportPapeisToUsuario_Load(object sender, EventArgs e)
        {

        }

        
    }
}
