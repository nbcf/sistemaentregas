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
using Sistema.View;

namespace Sistema.View.views
{
    public partial class Login : Form
    {
      
        private static Login _InstanciaLogin;
        public static Login GetInstanciaLogin()
        {
            if (_InstanciaLogin == null)
            {
                _InstanciaLogin = new Login();
            }
            return _InstanciaLogin;
        }

        UsuariosController controllerUsuario = new UsuariosController();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Usuário", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt1.Text = "";
                txt1.Focus();
                return;

            }if (txt2.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha a Senha", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt2.Text = "";
                txt2.Focus();
                return;
            }

            controllerUsuario.VerificarSenhaController(txt1.Text, txt2.Text);

           if("201".Equals(controllerUsuario.SenhaVerificadaController()))
            {
                 
                Menu form = new Menu();
                //this.Hide();

                form.AcaoFormVO = "AbriuMenu";
                Limpar();
                this.Hide();
                form.ShowDialog();

                if (form.AcaoFormVO.Equals("FechouSistema")) {

                    Close();
                
                }
               

            }else if ("404".Equals(controllerUsuario.SenhaVerificadaController())){
                MessageBox.Show("Usuário e Senha Inválidos", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Limpar()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt1.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetInstanciaLogin().Close();
        }
    }
}
