using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View.edits
{

   
    public partial class EditSaidas : Form
    {

       
        public string acaoDialogo;
        public string acaoForm;
        public string VeiculoVO
        {
            get { return txtVeiculo.Text; }
            set { txtVeiculo.Text = value; }
        }

        public string PlacaVO
        {
            get { return txtPlaca.Text; }
            set { txtPlaca.Text = value; }
        }

        public string DestinatarioVO
        {
            get { return txtDestinatario.Text; }
            set { txtDestinatario.Text = value; }
        }
        
        public string EntregadorVO 
        {
            get { return txtEntregador.Text; }
            set { txtEntregador.Text = value; }
        }

        public string NumeroEncomendaVO 
        {
            get { return txtNumeroEncomenda.Text; }
            set { txtNumeroEncomenda.Text = value; }
        }

        public string EstatusEntregaVO 
        {
            get { return cbEstatusPacote.SelectedItem.ToString(); }
            set { cbEstatusPacote.Text = value; }
        }

        public DateTime DataEntregaVO 
        {
            get { return datePDataEntregue.Value; }
            set { datePDataEntregue.Value = value; }// Convert.ToDateTime(datePckSaida.Value.ToString("dd/MM/yyyy")),
        }

        public DateTime DataEntradaVO
        {
            get { return datePDataEntrada.Value; }
            set { datePDataEntrada.Value = value; }
        }

        public DateTime DataRotaVO
        {
            get { return datePDataRota.Value; }
            set { datePDataRota.Value = value; }
        }

        public string LogradouroVO
        {
            get { return txtLogradoruo.Text; }
            set { txtLogradoruo.Text = value; }
        }

        public string ComplementoVO
        {
            get { return txtComplemento.Text; }
            set { txtComplemento.Text = value; }
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

        public string CpfVO
        {
            get { return txtCpf.Text; }
            set { txtCpf.Text = value; }
        }

        public string OrigemVO
        {
            get { return txtOrigem.Text; }
            set { txtOrigem.Text = value; }
        }


        public string IdOrigemVO
        {
            get { return txtIdorigem.Text; }
            set { txtIdorigem.Text = value; }
        }

        public string IdVeiculoVO
        {
            get { return txtIdVeiculo.Text; }
            set { txtIdVeiculo.Text = value; }
        }

        public string IdEntregadorVO
        {
            get { return txtIdEntregador.Text; }
            set { txtIdEntregador.Text = value; }
        }
        public string IdSaidaVO
        {
            get { return txtIdSaida.Text; }
            set { txtIdSaida.Text = value; }
        }


        public string IdEncomendaVO
        {
            get { return txtIdEncomenda.Text; }
            set { txtIdEncomenda.Text = value; }
        }
        
        public string AcaoDialogoVO
        {
            get { return acaoDialogo; }
            set { acaoDialogo = value; }
        }
        public string AcaoFormVO
        {
            get { return acaoForm; }
            set { acaoForm = value; }
        }

        public EditSaidas()
        {
            InitializeComponent();
        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            acaoDialogo = "Editar";
            Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            acaoDialogo = "Salvar";
            Close();
        }

        private void SaidasEdit_Load(object sender, EventArgs e)
        {
           
            txtIdorigem.Visible = false;
            txtIdVeiculo.Visible = false;
            txtIdEntregador.Visible = false;
            datePDataEntregue.Value = DateTime.Now;
        }

        private void cbEstatusPacote_SelectedValueChanged(object sender, EventArgs e)
        {
            EstatusEntregaVO = cbEstatusPacote.SelectedItem.ToString();
        }

        private void dtPDataEntrega_ValueChanged(object sender, EventArgs e)
        {
            DataEntregaVO = datePDataEntregue.Value;
        }

        private void EditSaidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            AcaoFormVO = "Fechado";
        }

        private void EditSaidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                acaoDialogo = "Salvar";
                Close();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                AcaoFormVO = "Fechado";
                acaoDialogo = "Editar";
                Close();
            }
        }
    }
}
