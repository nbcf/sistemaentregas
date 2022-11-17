
using Engines;
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
    public partial class formEditEnderecos : Form
    {
        public string acaoDialog = "";
        public string formAcaoDialog = "";


        public string IdVO
        {
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }
        public string LogradouroVO
        {
            get { return txtLogradouro.Text; }
            set { txtLogradouro.Text = value; }
        }


        public string BairroVO
        {
            get { return txtBairro.Text; }
            set { txtBairro.Text = value; }
        }

        public string CidadeVO
        {
            get { return txtCidade.Text; }
            set { txtCidade.Text = value; }
        }

        public string UfVO
        {
            get { return txtUf.Text; }
            set { txtUf.Text = value; }
        }

        public string CepVO
        {
            get { return txtCep.Text; }
            set { txtCep.Text = value; }
        }

        public string FormAcaoDialogVO
        {
            get { return formAcaoDialog; }
            set { formAcaoDialog = value; }
        }

        public string AcaoDialogVO
        {
            get { return acaoDialog; }
            set { acaoDialog = value; }
        }
         ConsultarCep cp = new ConsultarCep();
        public formEditEnderecos()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            AcaoDialogVO = "sair";
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcaoDialogVO = "ok";
            Close();
         
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            puxarCep();
        }
     

        private void formEditEnderecos_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAcaoDialogVO = "S"; //acaoDialog = "Cancelar";
        }

        private void formEditEnderecos_FormClosed(object sender, FormClosedEventArgs e)
        {
           // acaoDialog = "Cancelar";
        }

        private void formEditEnderecos_Load(object sender, EventArgs e)
        {
            txtId.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e){
            puxarCep();

        }

        public void puxarCep() {
            cp.puxarCep(txtCep.Text);
            txtLogradouro.Text = cp.LogradouroVO;
            txtBairro.Text = cp.BairroVO;
            txtCidade.Text = cp.CidadeVO;
            txtUf.Text = cp.UfVO;
   
        }

            public  void limpar(){
                txtCep.Text = string.Empty;
                txtUf.Text = string.Empty;
                txtCidade.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtLogradouro.Text = string.Empty;
            }

        }
    }
