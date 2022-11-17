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
    public partial class ImportEntregadorToSaidas : Form
    {
        public string strID;
        public string strIdPapel;
        public string strIdPessoa;
        public string strNome;
        public string strFuncao;


        public string IdVO
        {
            get { return strID; }
            set { strID = value; }
        }

        public string IdPapelVO
        {
            get { return strIdPapel; }
            set { strIdPapel = value; }
        }

        public string IdPessoaVO
        {
            get { return strIdPessoa; }
            set { strIdPessoa = value; }
        }

        public string nomeVO
        {
            get { return strNome; }
            set { strNome = value; }
        }
       
        UsuariosController controllerImpES = new UsuariosController();

        public ImportEntregadorToSaidas()
        {
            InitializeComponent();
            gridImportES.DataSource = controllerImpES.ListarImportEntregador("Entregador");
            DataGridModel();
        }


        public void behaviorClickGrid()
        {
            strID = gridImportES.CurrentRow.Cells[0].Value.ToString();
            strIdPapel = gridImportES.CurrentRow.Cells[1].Value.ToString();
            strIdPessoa = gridImportES.CurrentRow.Cells[2].Value.ToString();
            strNome = gridImportES.CurrentRow.Cells[16].Value.ToString();
            Close();
        }
        private void DataGridModel()
        {
            gridImportES.Columns[0].Width = 60;
            gridImportES.Columns[6].Width = 150;
            gridImportES.Columns[16].Width = 208;
            gridImportES.Columns[0].HeaderText = "ID";
            gridImportES.Columns[6].HeaderText = "FUNÇÃO";
            gridImportES.Columns[16].HeaderText = "NOME";
            gridImportES.Columns[1].Visible = false;
            gridImportES.Columns[2].Visible = false;
            gridImportES.Columns[3].Visible = false;
            gridImportES.Columns[4].Visible = false;
            gridImportES.Columns[5].Visible = false;
            gridImportES.Columns[7].Visible = false;
            gridImportES.Columns[8].Visible = false;
            gridImportES.Columns[9].Visible = false;
            gridImportES.Columns[10].Visible = false;
            gridImportES.Columns[11].Visible = false;
            gridImportES.Columns[12].Visible = false;
            gridImportES.Columns[13].Visible = false;
            gridImportES.Columns[14].Visible = false;
            gridImportES.Columns[15].Visible = false;
            gridImportES.Columns[17].Visible = false;

        }
        private void gridImportES_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            behaviorClickGrid();
        }

        private void ImportEntregadorToSaidas_Load(object sender, EventArgs e)
        {

        }
    }
}
