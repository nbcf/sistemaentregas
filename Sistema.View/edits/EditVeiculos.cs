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
    public partial class formEditVeiculos : Form
    {

        public string acaoDialog;
        public string acaoForm;
        public string VeiculoVO
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string PlacaVO
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string AcaoDialogVO
        {
            get { return acaoDialog; }
            set { acaoDialog = value; }
        }

        public string AcaoFormVO
        {
            get { return acaoForm; }
            set { acaoForm = value; }
        }

        public formEditVeiculos()
        {
            InitializeComponent();
        }

        private void formEditUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            acaoDialog = "Cancelar";
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acaoDialog = "Salvar";
            Close();
        }

        private void formEditVeiculos_FormClosing(object sender, FormClosingEventArgs e)
        {
            acaoForm = "Fechou";
        }
    }
}
