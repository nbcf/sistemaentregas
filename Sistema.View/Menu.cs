using Sistema.View.relatorios;
using Sistema.View.views;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void papeisToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PapeisView frmPapeis =  PapeisView.GetInstanciaformCrudPapeis();
            frmPapeis.MdiParent = this;
            frmPapeis.Text = "Gerenciamento de Papéis de Usuários";
            frmPapeis.Show();

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PessoasView frmPessoas = PessoasView.GetInstanciaformCrudPessoas();
            frmPessoas.MdiParent = this;
            frmPessoas.Text = "Gerenciamento de Pessoas no Sistema";
            frmPessoas.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosView frmUsuarios = UsuariosView.GetInstanciaformCrudUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Text = "Gerenciamento de Usuários";
            frmUsuarios.Show();
        }

        private void endereçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnderecosView frmEnderecos = EnderecosView.GetInstanciaformCrudEnderecos();
            frmEnderecos.MdiParent = this;
            frmEnderecos.Text = "Gerenciamento de Endereços Offline";
            frmEnderecos.Show();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeiculosView frmVeiculos = VeiculosView.GetInstanciaformCrudVeiculos();
            frmVeiculos.MdiParent = this;
            frmVeiculos.Text = "Gerenciamento de Veículos";
            frmVeiculos.Show();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formCrudGastos frmGastos = new formCrudGastos();
            //frmGastos.MdiParent = this;
            //frmGastos.Text = "Gerenciamento de Papéis de Usuários";
            //frmGastos.Show();
        }

   
        private void origemEcomendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrigemView frmOrigem = OrigemView.GetInstanciaformCrudOrigem();
            frmOrigem.MdiParent = this;
            frmOrigem.Text = "Gerenciamento de Origens das Encomendas";
            frmOrigem.Show();
        }

        private void receberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncomendasEntradaView frmCrudEncomendas = EncomendasEntradaView.GetInstanciaformCrudPapeis();
            frmCrudEncomendas.MdiParent = this;
            frmCrudEncomendas.Text = "Gerenciamento de Recebimento de Encomendas";
            frmCrudEncomendas.Show();
           
        }

        private void despacharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaidaEncomendasView frmSaidasEncomendas = SaidaEncomendasView.GetInst();
            frmSaidasEncomendas.MdiParent = this;
            frmSaidasEncomendas.Text = "Gerenciamento de Entregas";
            frmSaidasEncomendas.Show();
        }

        private void hjgfjhgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntregasView frmEntregasView = new EntregasView();
            frmEntregasView.MdiParent = this;
            frmEntregasView.Text = "Entrega de Encomendas";
            frmEntregasView.Show();
        }

        private void entradaDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioConsumoVeiculos frmRelConsumoVeiculos = new RelatorioConsumoVeiculos();
            frmRelConsumoVeiculos.MdiParent = this;
            frmRelConsumoVeiculos.Text = "Ainda em Contrucao";
            frmRelConsumoVeiculos.Show();
        }

        private void tipoGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {


            TipoGastosView frmTipoGastosView = TipoGastosView.GetInstanciaTipoGastosView();
            frmTipoGastosView.MdiParent = this;
            frmTipoGastosView.Text = "Gerenciamento de Tipo Gastos";
            frmTipoGastosView.Show();
        }

        private void tipoUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoUndsView frmTipoUndsView = TipoUndsView.GetInstanciaTipoUndsView();
            frmTipoUndsView.MdiParent = this;
            frmTipoUndsView.Text = "Gerenciamento de Tipo Unidades";
            frmTipoUndsView.Show();

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedoresView frmFornecedoresView = FornecedoresView.GetInstanciaFornecedoresView();
            frmFornecedoresView.MdiParent = this;
            frmFornecedoresView.Text = "Gerenciamento de Fornecedores";
            frmFornecedoresView.Show();

        }

        private void relatoriosDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abastecimentoPorDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerênciaDeEntregasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
