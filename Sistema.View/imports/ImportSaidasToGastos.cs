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

namespace Sistema.View.imports
{
    public partial class ImportSaidasToGastos : Form
    {

        public int codsaida;
        public string entregador;
        public string veiculo;
        public string placa;
        public int codSaida;
        public DateTime datasaida;
        public string acaoDialog;
        public string acaoForm;

        public int CodSaidaVO
        {
            get { return codSaida; }
            set { codSaida = value; }
        }

        public string EntregadorVO
        {
            get { return entregador; }
            set { entregador = value; }
        }

        public string VeiculoVO
        {
            get { return veiculo; }
            set { veiculo = value; }
        }
       
        public string PlacaVO
        {
            get { return placa; }
            set { placa = value; }
        }
   
        public DateTime DataSaidaVO
        {
            get { return datasaida; }
            set { datasaida = value; }
        }

        
        SaidasController controllerSaida = new SaidasController();

        public ImportSaidasToGastos()
        {
            InitializeComponent();
            gridCrudSaidas.DataSource = controllerSaida.ListarSaidaGasto();
           DataGridModel();
        }

        private void ImportSaidasToGastos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CodSaidaVO = Convert.ToInt32(gridCrudSaidas.CurrentRow.Cells[1].Value.ToString());
            EntregadorVO  = gridCrudSaidas.CurrentRow.Cells[7].Value.ToString();
            VeiculoVO = gridCrudSaidas.CurrentRow.Cells[5].Value.ToString();
            PlacaVO = gridCrudSaidas.CurrentRow.Cells[6].Value.ToString();
            DataSaidaVO = Convert.ToDateTime(gridCrudSaidas.CurrentRow.Cells[8].Value);

            Close();
        }


        private void DataGridModel()
        {
            gridCrudSaidas.Columns[0].HeaderText = "ID";
            gridCrudSaidas.Columns[1].HeaderText = "Id veiculo";
            gridCrudSaidas.Columns[2].HeaderText = "id usuario ";
            gridCrudSaidas.Columns[3].HeaderText = "id idpapel";
            gridCrudSaidas.Columns[4].HeaderText = "id idpessoa";
            gridCrudSaidas.Columns[5].HeaderText = "VEICULO";
            gridCrudSaidas.Columns[6].HeaderText = "PLACA";
            gridCrudSaidas.Columns[7].HeaderText = "ENTREGADOR";
            gridCrudSaidas.Columns[8].HeaderText = "DATA";
            gridCrudSaidas.Columns[9].HeaderText = "REGRESSO";
            gridCrudSaidas.Columns[10].HeaderText = "HORA SAÍDA";
            gridCrudSaidas.Columns[11].HeaderText = "HORA REGRESSO";
            gridCrudSaidas.Columns[12].HeaderText = "ESTATUS";
            gridCrudSaidas.Columns[13].HeaderText = "REGIÃO";
            gridCrudSaidas.Columns[14].HeaderText = "KM SAÍDA";
            gridCrudSaidas.Columns[15].HeaderText = "KM REGRESSO";
            gridCrudSaidas.Columns[16].HeaderText = "KM TOTAL";
            //gridCrudSaidas.Columns[17].HeaderText = "id usuario join 1";
            //gridCrudSaidas.Columns[18].HeaderText = "id idpapel join 1";
            //gridCrudSaidas.Columns[19].HeaderText = "id idpessoa join1";
            //gridCrudSaidas.Columns[20].HeaderText = "usuario";
            //gridCrudSaidas.Columns[21].HeaderText = "senha";
            //gridCrudSaidas.Columns[22].HeaderText = "id idpapel join 2";
            //gridCrudSaidas.Columns[23].HeaderText = "Funcao";
            //gridCrudSaidas.Columns[24].HeaderText = "criar";
            //gridCrudSaidas.Columns[25].HeaderText = "recuperar";
            //gridCrudSaidas.Columns[26].HeaderText = "atualizar";
            //gridCrudSaidas.Columns[27].HeaderText = "excluir";
            //gridCrudSaidas.Columns[28].HeaderText = "menuope";
            //gridCrudSaidas.Columns[29].HeaderText = "menuadmin";
            //gridCrudSaidas.Columns[30].HeaderText = "menugen";
            //gridCrudSaidas.Columns[31].HeaderText = "id idpessoa join 2";
            //gridCrudSaidas.Columns[32].HeaderText = "id endereco";
            //gridCrudSaidas.Columns[33].HeaderText = "Motorista";
            //gridCrudSaidas.Columns[34].HeaderText = "complemento/ numero";
            //gridCrudSaidas.Columns[35].HeaderText = "idveiculo join 1";
            //gridCrudSaidas.Columns[36].HeaderText = "nome veiculo 1";
            //gridCrudSaidas.Columns[37].HeaderText = "placa 1";
            //gridCrudSaidas.Columns[38].HeaderText = "estatus veiculo";


            gridCrudSaidas.Columns[0].Width = 50;
            gridCrudSaidas.Columns[1].Width = 0;
            gridCrudSaidas.Columns[2].Width = 0;
            gridCrudSaidas.Columns[3].Width = 0;
            gridCrudSaidas.Columns[4].Width = 0;
            gridCrudSaidas.Columns[5].Width = 150;
            gridCrudSaidas.Columns[6].Width = 80;
            gridCrudSaidas.Columns[7].Width = 200;
            gridCrudSaidas.Columns[8].Width = 100;
            gridCrudSaidas.Columns[9].Width = 100;
            gridCrudSaidas.Columns[10].Width = 100;
            gridCrudSaidas.Columns[11].Width = 100;
            gridCrudSaidas.Columns[12].Width = 80;
            gridCrudSaidas.Columns[13].Width = 100;
            gridCrudSaidas.Columns[14].Width = 100;
            gridCrudSaidas.Columns[15].Width = 100;
            gridCrudSaidas.Columns[16].Width = 100;
            //gridCrudSaidas.Columns[17].Width = 0;
            //gridCrudSaidas.Columns[18].Width = 0;
            //gridCrudSaidas.Columns[19].Width = 0;
            //gridCrudSaidas.Columns[20].Width = 0;
            //gridCrudSaidas.Columns[21].Width = 0;
            //gridCrudSaidas.Columns[22].Width = 0;
            //gridCrudSaidas.Columns[23].Width = 0;
            //gridCrudSaidas.Columns[24].Width = 0;
            //gridCrudSaidas.Columns[25].Width = 0;
            //gridCrudSaidas.Columns[26].Width = 0;
            //gridCrudSaidas.Columns[27].Width = 0;
            //gridCrudSaidas.Columns[28].Width = 0;
            //gridCrudSaidas.Columns[29].Width = 0;
            //gridCrudSaidas.Columns[30].Width = 0;
            //gridCrudSaidas.Columns[31].Width = 0;
            //gridCrudSaidas.Columns[32].Width = 0;
            //gridCrudSaidas.Columns[33].Width = 0;
            //gridCrudSaidas.Columns[34].Width = 0;
            //gridCrudSaidas.Columns[35].Width = 0;
            //gridCrudSaidas.Columns[36].Width = 0;
            //gridCrudSaidas.Columns[37].Width = 0;
            //gridCrudSaidas.Columns[38].Width = 100;

            gridCrudSaidas.Columns[0].Visible = true;
            gridCrudSaidas.Columns[1].Visible = false;
            gridCrudSaidas.Columns[2].Visible = false;
            gridCrudSaidas.Columns[3].Visible = false;
            gridCrudSaidas.Columns[4].Visible = false;
            gridCrudSaidas.Columns[5].Visible = true;
            gridCrudSaidas.Columns[6].Visible = true;
            gridCrudSaidas.Columns[7].Visible = true;
            gridCrudSaidas.Columns[8].Visible = true;
            gridCrudSaidas.Columns[9].Visible = false;
            gridCrudSaidas.Columns[10].Visible = false;
            gridCrudSaidas.Columns[11].Visible = false;
            gridCrudSaidas.Columns[12].Visible = true;
            gridCrudSaidas.Columns[13].Visible = false;

            gridCrudSaidas.Columns[14].Visible = false;
            gridCrudSaidas.Columns[15].Visible = false;
            gridCrudSaidas.Columns[16].Visible = false;


        }

        private void gridCrudSaidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
