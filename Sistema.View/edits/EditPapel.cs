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
    public partial class formEditPapel : Form
    {
        public string acaoDialog;


        public string IdVO
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string PapelVO
        {
            get { return txtNomeFuncao.Text; }
            set { txtNomeFuncao.Text = value; }
        }

        public bool CriarVO
        {
            get { return ckCadastrar.Checked; }
            set { ckCadastrar.Checked = value; }
        }

        public bool RecuperarVO
        {
            get { return ckPesquisar.Checked; }
            set { ckPesquisar.Checked = value; }
        }

        public bool AtualizarVO
        {
            get { return ckEditar.Checked; }
            set { ckEditar.Checked = value; }
        }

        public bool DeletarVO
        {
            get { return ckExcluir.Checked; }
            set { ckExcluir.Checked = value; }
        }

        public bool MenuOpVO
        {
            get { return ckMenuOpe.Checked; }
            set { ckMenuOpe.Checked = value; }
        }


        public bool MenuAdminVO
        {
            get { return ckMenuAdmin.Checked; }
            set { ckMenuAdmin.Checked = value; }
        }

        public bool MenuGenVO
        {
            get { return ckMenuGen.Checked; }
            set { ckMenuGen.Checked = value; }
        }


        public string AcaoDialogVO
        {
            get { return acaoDialog; }
            set { acaoDialog = value; }
        }
        public formEditPapel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acaoDialog = "Salvar";
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acaoDialog = "Cancelar";
            Close();
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void formEditPapel_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void formEditPapel_FormClosing(object sender, FormClosingEventArgs e)
        {
            acaoDialog = "Cancelar";
            
        }

        private void formEditPapel_FormClosed(object sender, FormClosedEventArgs e)
        {

            acaoDialog = "Cancelar";
       
        }
    }
}
