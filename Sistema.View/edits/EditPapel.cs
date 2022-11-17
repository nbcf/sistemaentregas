using System;

using System.Windows.Forms;

namespace Sistema.View
{
    public partial class formEditPapel : Form
    {
        public string acaoDialog = "";
        public string acaoFormDialog = "";


        public string PapelVO
        {
            get { return cbCargo.SelectedItem.ToString(); }
            set { cbCargo.SelectedItem = value; }
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

        public string AcaoFormDialogVO
        {
            get { return acaoFormDialog; }
            set { acaoFormDialog = value; }
        }

        public formEditPapel(){
            InitializeComponent();
        }


        public void Sair(){
            AcaoDialogVO = "sair";
            Close();

        }
        public void Ok(){
            AcaoDialogVO = "ok";
            Close();
        }


     

        private void btnOk_Click(object sender, EventArgs e){
            Ok();
        }

        private void btnSair_Click(object sender, EventArgs e){
            Sair();
        }
    }
}
