
namespace Sistema.View
{
    partial class UsuariosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bttnNew = new System.Windows.Forms.ToolStripButton();
            this.bttnSave = new System.Windows.Forms.ToolStripButton();
            this.bttnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bttnEdit = new System.Windows.Forms.ToolStripButton();
            this.bttnSearch = new System.Windows.Forms.ToolStripButton();
            this.bttnDel = new System.Windows.Forms.ToolStripButton();
            this.tabControlAssets = new System.Windows.Forms.TabControl();
            this.tabPagePesquisar = new System.Windows.Forms.TabPage();
            this.cbButtonPesquisarEm = new System.Windows.Forms.ComboBox();
            this.txtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.radioBttnTermina = new System.Windows.Forms.RadioButton();
            this.radioBttnContem = new System.Windows.Forms.RadioButton();
            this.radioBttnComeca = new System.Windows.Forms.RadioButton();
            this.txtBoxIdPapeis = new System.Windows.Forms.TextBox();
            this.txtBoxIdPessoa = new System.Windows.Forms.TextBox();
            this.bttImportPessoa = new System.Windows.Forms.Button();
            this.ckMenuGen = new System.Windows.Forms.CheckBox();
            this.ckMenuAdmin = new System.Windows.Forms.CheckBox();
            this.ckMenuOp = new System.Windows.Forms.CheckBox();
            this.ckDeletar = new System.Windows.Forms.CheckBox();
            this.ckEditar = new System.Windows.Forms.CheckBox();
            this.ckPesquisar = new System.Windows.Forms.CheckBox();
            this.ckCadastrar = new System.Windows.Forms.CheckBox();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.txtNomePapel = new System.Windows.Forms.TextBox();
            this.bttImportaPapel = new System.Windows.Forms.Button();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.bttnBeginPages = new System.Windows.Forms.ToolStripButton();
            this.bttnOnePageLeft = new System.Windows.Forms.ToolStripButton();
            this.labelTextPageFrom = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.labelTextTotalPages = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.labelTextTotalRegFould = new System.Windows.Forms.ToolStripLabel();
            this.bttnOnePageRight = new System.Windows.Forms.ToolStripButton();
            this.bttnEndPages = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cbButtnQuantPage1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.cbOrdemParam1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.cbOrdenarPor1 = new System.Windows.Forms.ToolStripComboBox();
            this.gridCrudUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBoxFormulario = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.tabControlAssets.SuspendLayout();
            this.tabPagePesquisar.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudUsuarios)).BeginInit();
            this.groupBoxFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttnNew,
            this.bttnSave,
            this.bttnRefresh,
            this.bttnEdit,
            this.bttnSearch,
            this.bttnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(674, 51);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bttnNew
            // 
            this.bttnNew.AutoSize = false;
            this.bttnNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bttnNew.Image = global::Sistema.View.Properties.Resources.add48;
            this.bttnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnNew.Name = "bttnNew";
            this.bttnNew.Size = new System.Drawing.Size(100, 48);
            this.bttnNew.Text = "toolStripButton1";
            this.bttnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bttnNew.Click += new System.EventHandler(this.bttnNew_Click);
            // 
            // bttnSave
            // 
            this.bttnSave.AutoSize = false;
            this.bttnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnSave.Image = global::Sistema.View.Properties.Resources.save48;
            this.bttnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(100, 48);
            this.bttnSave.Text = "toolStripButton2";
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.AutoSize = false;
            this.bttnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnRefresh.Image = global::Sistema.View.Properties.Resources.refresh48;
            this.bttnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(100, 48);
            this.bttnRefresh.Text = "toolStripButton3";
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click_1);
            // 
            // bttnEdit
            // 
            this.bttnEdit.AutoSize = false;
            this.bttnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnEdit.Image = global::Sistema.View.Properties.Resources.editForm48;
            this.bttnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(100, 48);
            this.bttnEdit.Text = "toolStripButton4";
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.AutoSize = false;
            this.bttnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnSearch.Image = global::Sistema.View.Properties.Resources.search48;
            this.bttnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(100, 48);
            this.bttnSearch.Text = "toolStripButton5";
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // bttnDel
            // 
            this.bttnDel.AutoSize = false;
            this.bttnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnDel.Image = global::Sistema.View.Properties.Resources.del48;
            this.bttnDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnDel.Name = "bttnDel";
            this.bttnDel.Size = new System.Drawing.Size(100, 48);
            this.bttnDel.Text = "toolStripButton6";
            // 
            // tabControlAssets
            // 
            this.tabControlAssets.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlAssets.Controls.Add(this.tabPagePesquisar);
            this.tabControlAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAssets.Location = new System.Drawing.Point(0, 51);
            this.tabControlAssets.Name = "tabControlAssets";
            this.tabControlAssets.SelectedIndex = 0;
            this.tabControlAssets.Size = new System.Drawing.Size(674, 68);
            this.tabControlAssets.TabIndex = 4;
            // 
            // tabPagePesquisar
            // 
            this.tabPagePesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPagePesquisar.Controls.Add(this.cbButtonPesquisarEm);
            this.tabPagePesquisar.Controls.Add(this.txtBoxPesquisar);
            this.tabPagePesquisar.Controls.Add(this.radioBttnTermina);
            this.tabPagePesquisar.Controls.Add(this.radioBttnContem);
            this.tabPagePesquisar.Controls.Add(this.radioBttnComeca);
            this.tabPagePesquisar.Location = new System.Drawing.Point(4, 25);
            this.tabPagePesquisar.Name = "tabPagePesquisar";
            this.tabPagePesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisar.Size = new System.Drawing.Size(666, 39);
            this.tabPagePesquisar.TabIndex = 1;
            this.tabPagePesquisar.Text = "Pesquisar";
            this.tabPagePesquisar.UseVisualStyleBackColor = true;
            // 
            // cbButtonPesquisarEm
            // 
            this.cbButtonPesquisarEm.FormattingEnabled = true;
            this.cbButtonPesquisarEm.Items.AddRange(new object[] {
            "Usuario"});
            this.cbButtonPesquisarEm.Location = new System.Drawing.Point(237, 6);
            this.cbButtonPesquisarEm.Name = "cbButtonPesquisarEm";
            this.cbButtonPesquisarEm.Size = new System.Drawing.Size(138, 21);
            this.cbButtonPesquisarEm.TabIndex = 1;
            this.cbButtonPesquisarEm.SelectedIndexChanged += new System.EventHandler(this.cbButtonPesquisarEm_SelectedIndexChanged);
            // 
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.Location = new System.Drawing.Point(7, 6);
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(224, 20);
            this.txtBoxPesquisar.TabIndex = 0;
            this.txtBoxPesquisar.TextChanged += new System.EventHandler(this.txtBoxPesquisar_TextChanged_1);
            // 
            // radioBttnTermina
            // 
            this.radioBttnTermina.AutoSize = true;
            this.radioBttnTermina.Location = new System.Drawing.Point(518, 10);
            this.radioBttnTermina.Name = "radioBttnTermina";
            this.radioBttnTermina.Size = new System.Drawing.Size(63, 17);
            this.radioBttnTermina.TabIndex = 4;
            this.radioBttnTermina.Text = "Termina";
            this.radioBttnTermina.UseVisualStyleBackColor = true;
            this.radioBttnTermina.CheckedChanged += new System.EventHandler(this.radioBttnTermina_CheckedChanged_1);
            // 
            // radioBttnContem
            // 
            this.radioBttnContem.AutoSize = true;
            this.radioBttnContem.Location = new System.Drawing.Point(451, 10);
            this.radioBttnContem.Name = "radioBttnContem";
            this.radioBttnContem.Size = new System.Drawing.Size(61, 17);
            this.radioBttnContem.TabIndex = 5;
            this.radioBttnContem.Text = "Contém";
            this.radioBttnContem.UseVisualStyleBackColor = true;
            this.radioBttnContem.CheckedChanged += new System.EventHandler(this.radioBttnContem_CheckedChanged_1);
            // 
            // radioBttnComeca
            // 
            this.radioBttnComeca.AutoSize = true;
            this.radioBttnComeca.Location = new System.Drawing.Point(381, 10);
            this.radioBttnComeca.Name = "radioBttnComeca";
            this.radioBttnComeca.Size = new System.Drawing.Size(64, 17);
            this.radioBttnComeca.TabIndex = 6;
            this.radioBttnComeca.Text = "Começa";
            this.radioBttnComeca.UseVisualStyleBackColor = true;
            this.radioBttnComeca.CheckedChanged += new System.EventHandler(this.radioBttnComeca_CheckedChanged_1);
            // 
            // txtBoxIdPapeis
            // 
            this.txtBoxIdPapeis.Enabled = false;
            this.txtBoxIdPapeis.Location = new System.Drawing.Point(89, 99);
            this.txtBoxIdPapeis.Name = "txtBoxIdPapeis";
            this.txtBoxIdPapeis.Size = new System.Drawing.Size(40, 20);
            this.txtBoxIdPapeis.TabIndex = 20;
            // 
            // txtBoxIdPessoa
            // 
            this.txtBoxIdPessoa.Enabled = false;
            this.txtBoxIdPessoa.Location = new System.Drawing.Point(89, 130);
            this.txtBoxIdPessoa.Name = "txtBoxIdPessoa";
            this.txtBoxIdPessoa.Size = new System.Drawing.Size(40, 20);
            this.txtBoxIdPessoa.TabIndex = 19;
            // 
            // bttImportPessoa
            // 
            this.bttImportPessoa.Image = ((System.Drawing.Image)(resources.GetObject("bttImportPessoa.Image")));
            this.bttImportPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttImportPessoa.Location = new System.Drawing.Point(15, 130);
            this.bttImportPessoa.Name = "bttImportPessoa";
            this.bttImportPessoa.Size = new System.Drawing.Size(68, 20);
            this.bttImportPessoa.TabIndex = 18;
            this.bttImportPessoa.Text = "Pessoa:";
            this.bttImportPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttImportPessoa.UseVisualStyleBackColor = true;
            this.bttImportPessoa.Click += new System.EventHandler(this.bttImportPessoa_Click);
            // 
            // ckMenuGen
            // 
            this.ckMenuGen.AutoSize = true;
            this.ckMenuGen.Enabled = false;
            this.ckMenuGen.Location = new System.Drawing.Point(231, 209);
            this.ckMenuGen.Name = "ckMenuGen";
            this.ckMenuGen.Size = new System.Drawing.Size(107, 17);
            this.ckMenuGen.TabIndex = 17;
            this.ckMenuGen.Text = "Acesso Gerência";
            this.ckMenuGen.UseVisualStyleBackColor = true;
            // 
            // ckMenuAdmin
            // 
            this.ckMenuAdmin.AutoSize = true;
            this.ckMenuAdmin.Enabled = false;
            this.ckMenuAdmin.Location = new System.Drawing.Point(231, 186);
            this.ckMenuAdmin.Name = "ckMenuAdmin";
            this.ckMenuAdmin.Size = new System.Drawing.Size(129, 17);
            this.ckMenuAdmin.TabIndex = 16;
            this.ckMenuAdmin.Text = "Acesso Administrativo";
            this.ckMenuAdmin.UseVisualStyleBackColor = true;
            // 
            // ckMenuOp
            // 
            this.ckMenuOp.AutoSize = true;
            this.ckMenuOp.Enabled = false;
            this.ckMenuOp.Location = new System.Drawing.Point(231, 163);
            this.ckMenuOp.Name = "ckMenuOp";
            this.ckMenuOp.Size = new System.Drawing.Size(121, 17);
            this.ckMenuOp.TabIndex = 15;
            this.ckMenuOp.Text = "Acesso Operacional";
            this.ckMenuOp.UseVisualStyleBackColor = true;
            // 
            // ckDeletar
            // 
            this.ckDeletar.AutoSize = true;
            this.ckDeletar.Enabled = false;
            this.ckDeletar.Location = new System.Drawing.Point(89, 232);
            this.ckDeletar.Name = "ckDeletar";
            this.ckDeletar.Size = new System.Drawing.Size(60, 17);
            this.ckDeletar.TabIndex = 14;
            this.ckDeletar.Text = "Deletar";
            this.ckDeletar.UseVisualStyleBackColor = true;
            // 
            // ckEditar
            // 
            this.ckEditar.AutoSize = true;
            this.ckEditar.Enabled = false;
            this.ckEditar.Location = new System.Drawing.Point(89, 209);
            this.ckEditar.Name = "ckEditar";
            this.ckEditar.Size = new System.Drawing.Size(53, 17);
            this.ckEditar.TabIndex = 13;
            this.ckEditar.Text = "Editar";
            this.ckEditar.UseVisualStyleBackColor = true;
            // 
            // ckPesquisar
            // 
            this.ckPesquisar.AutoSize = true;
            this.ckPesquisar.Enabled = false;
            this.ckPesquisar.Location = new System.Drawing.Point(89, 186);
            this.ckPesquisar.Name = "ckPesquisar";
            this.ckPesquisar.Size = new System.Drawing.Size(72, 17);
            this.ckPesquisar.TabIndex = 12;
            this.ckPesquisar.Text = "Pesquisar";
            this.ckPesquisar.UseVisualStyleBackColor = true;
            // 
            // ckCadastrar
            // 
            this.ckCadastrar.AutoSize = true;
            this.ckCadastrar.Enabled = false;
            this.ckCadastrar.Location = new System.Drawing.Point(90, 163);
            this.ckCadastrar.Name = "ckCadastrar";
            this.ckCadastrar.Size = new System.Drawing.Size(71, 17);
            this.ckCadastrar.TabIndex = 11;
            this.ckCadastrar.Text = "Cadastrar";
            this.ckCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Enabled = false;
            this.txtNomePessoa.Location = new System.Drawing.Point(136, 130);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(216, 20);
            this.txtNomePessoa.TabIndex = 10;
            // 
            // txtNomePapel
            // 
            this.txtNomePapel.Enabled = false;
            this.txtNomePapel.Location = new System.Drawing.Point(135, 99);
            this.txtNomePapel.Name = "txtNomePapel";
            this.txtNomePapel.Size = new System.Drawing.Size(216, 20);
            this.txtNomePapel.TabIndex = 7;
            // 
            // bttImportaPapel
            // 
            this.bttImportaPapel.Image = ((System.Drawing.Image)(resources.GetObject("bttImportaPapel.Image")));
            this.bttImportaPapel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttImportaPapel.Location = new System.Drawing.Point(15, 97);
            this.bttImportaPapel.Name = "bttImportaPapel";
            this.bttImportaPapel.Size = new System.Drawing.Size(68, 20);
            this.bttImportaPapel.TabIndex = 6;
            this.bttImportaPapel.Text = "Função:";
            this.bttImportaPapel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttImportaPapel.UseVisualStyleBackColor = true;
            this.bttImportaPapel.Click += new System.EventHandler(this.bttImportaPapel_Click);
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(87, 71);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(262, 20);
            this.txtBoxSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário";
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(87, 45);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(265, 20);
            this.txtBoxUsuario.TabIndex = 2;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Enabled = false;
            this.txtBoxId.Location = new System.Drawing.Point(87, 18);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(86, 20);
            this.txtBoxId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttnBeginPages,
            this.bttnOnePageLeft,
            this.labelTextPageFrom,
            this.toolStripLabel3,
            this.labelTextTotalPages,
            this.toolStripLabel5,
            this.labelTextTotalRegFould,
            this.bttnOnePageRight,
            this.bttnEndPages,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.toolStripLabel6,
            this.cbButtnQuantPage1,
            this.toolStripLabel7,
            this.cbOrdemParam1,
            this.toolStripLabel8,
            this.cbOrdenarPor1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 383);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(674, 27);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // bttnBeginPages
            // 
            this.bttnBeginPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnBeginPages.Image = global::Sistema.View.Properties.Resources._2leftarrow;
            this.bttnBeginPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnBeginPages.Name = "bttnBeginPages";
            this.bttnBeginPages.Size = new System.Drawing.Size(23, 24);
            this.bttnBeginPages.Text = "toolStripButton1";
            this.bttnBeginPages.Click += new System.EventHandler(this.bttnBeginPages_Click_1);
            // 
            // bttnOnePageLeft
            // 
            this.bttnOnePageLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnOnePageLeft.Image = global::Sistema.View.Properties.Resources._1leftarrow;
            this.bttnOnePageLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnOnePageLeft.Name = "bttnOnePageLeft";
            this.bttnOnePageLeft.Size = new System.Drawing.Size(23, 24);
            this.bttnOnePageLeft.Text = "toolStripButton2";
            this.bttnOnePageLeft.Click += new System.EventHandler(this.bttnOnePageLeft_Click_1);
            // 
            // labelTextPageFrom
            // 
            this.labelTextPageFrom.Name = "labelTextPageFrom";
            this.labelTextPageFrom.Size = new System.Drawing.Size(13, 24);
            this.labelTextPageFrom.Text = "0";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(12, 24);
            this.toolStripLabel3.Text = "/";
            // 
            // labelTextTotalPages
            // 
            this.labelTextTotalPages.Name = "labelTextTotalPages";
            this.labelTextTotalPages.Size = new System.Drawing.Size(13, 24);
            this.labelTextTotalPages.Text = "0";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(12, 24);
            this.toolStripLabel5.Text = "-";
            // 
            // labelTextTotalRegFould
            // 
            this.labelTextTotalRegFould.Name = "labelTextTotalRegFould";
            this.labelTextTotalRegFould.Size = new System.Drawing.Size(13, 24);
            this.labelTextTotalRegFould.Text = "0";
            // 
            // bttnOnePageRight
            // 
            this.bttnOnePageRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnOnePageRight.Image = global::Sistema.View.Properties.Resources._1rightarrow;
            this.bttnOnePageRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnOnePageRight.Name = "bttnOnePageRight";
            this.bttnOnePageRight.Size = new System.Drawing.Size(23, 24);
            this.bttnOnePageRight.Text = "toolStripButton3";
            this.bttnOnePageRight.Click += new System.EventHandler(this.bttnOnePageRight_Click_1);
            // 
            // bttnEndPages
            // 
            this.bttnEndPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnEndPages.Image = global::Sistema.View.Properties.Resources._2rightarrow;
            this.bttnEndPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnEndPages.Name = "bttnEndPages";
            this.bttnEndPages.Size = new System.Drawing.Size(23, 24);
            this.bttnEndPages.Text = "toolStripButton4";
            this.bttnEndPages.Click += new System.EventHandler(this.bttnEndPages_Click_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(161, 24);
            this.toolStripLabel1.Text = "Total Registros Encontrados : ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 24);
            this.toolStripLabel2.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(43, 24);
            this.toolStripLabel6.Text = "Qt.Pg.:";
            // 
            // cbButtnQuantPage1
            // 
            this.cbButtnQuantPage1.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "75",
            "100"});
            this.cbButtnQuantPage1.Name = "cbButtnQuantPage1";
            this.cbButtnQuantPage1.Size = new System.Drawing.Size(121, 27);
            this.cbButtnQuantPage1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(59, 24);
            this.toolStripLabel7.Text = "Listar Por:";
            // 
            // cbOrdemParam1
            // 
            this.cbOrdemParam1.Items.AddRange(new object[] {
            "Codigo",
            "Alfabeto"});
            this.cbOrdemParam1.Name = "cbOrdemParam1";
            this.cbOrdemParam1.Size = new System.Drawing.Size(121, 23);
            this.cbOrdemParam1.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(47, 15);
            this.toolStripLabel8.Text = "Ordem:";
            // 
            // cbOrdenarPor1
            // 
            this.cbOrdenarPor1.Items.AddRange(new object[] {
            "Primeiros",
            "Ultimos"});
            this.cbOrdenarPor1.Name = "cbOrdenarPor1";
            this.cbOrdenarPor1.Size = new System.Drawing.Size(121, 23);
            this.cbOrdenarPor1.Click += new System.EventHandler(this.toolStripComboBox3_Click);
            // 
            // gridCrudUsuarios
            // 
            this.gridCrudUsuarios.AllowUserToAddRows = false;
            this.gridCrudUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCrudUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCrudUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrudUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCrudUsuarios.Location = new System.Drawing.Point(0, 119);
            this.gridCrudUsuarios.MultiSelect = false;
            this.gridCrudUsuarios.Name = "gridCrudUsuarios";
            this.gridCrudUsuarios.RowTemplate.Height = 25;
            this.gridCrudUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCrudUsuarios.Size = new System.Drawing.Size(674, 291);
            this.gridCrudUsuarios.TabIndex = 6;
            this.gridCrudUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCrudPessoa_CellClick_1);
            // 
            // groupBoxFormulario
            // 
            this.groupBoxFormulario.Controls.Add(this.ckMenuGen);
            this.groupBoxFormulario.Controls.Add(this.txtBoxIdPessoa);
            this.groupBoxFormulario.Controls.Add(this.ckMenuAdmin);
            this.groupBoxFormulario.Controls.Add(this.txtBoxIdPapeis);
            this.groupBoxFormulario.Controls.Add(this.ckMenuOp);
            this.groupBoxFormulario.Controls.Add(this.bttImportaPapel);
            this.groupBoxFormulario.Controls.Add(this.ckDeletar);
            this.groupBoxFormulario.Controls.Add(this.ckEditar);
            this.groupBoxFormulario.Controls.Add(this.label1);
            this.groupBoxFormulario.Controls.Add(this.ckPesquisar);
            this.groupBoxFormulario.Controls.Add(this.bttImportPessoa);
            this.groupBoxFormulario.Controls.Add(this.ckCadastrar);
            this.groupBoxFormulario.Controls.Add(this.label2);
            this.groupBoxFormulario.Controls.Add(this.label3);
            this.groupBoxFormulario.Controls.Add(this.txtNomePessoa);
            this.groupBoxFormulario.Controls.Add(this.txtBoxId);
            this.groupBoxFormulario.Controls.Add(this.txtBoxUsuario);
            this.groupBoxFormulario.Controls.Add(this.txtBoxSenha);
            this.groupBoxFormulario.Controls.Add(this.txtNomePapel);
            this.groupBoxFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFormulario.Location = new System.Drawing.Point(0, 119);
            this.groupBoxFormulario.Name = "groupBoxFormulario";
            this.groupBoxFormulario.Size = new System.Drawing.Size(674, 264);
            this.groupBoxFormulario.TabIndex = 8;
            this.groupBoxFormulario.TabStop = false;
            // 
            // UsuariosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 410);
            this.Controls.Add(this.groupBoxFormulario);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.gridCrudUsuarios);
            this.Controls.Add(this.tabControlAssets);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UsuariosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCrudUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.formCrudUsuarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControlAssets.ResumeLayout(false);
            this.tabPagePesquisar.ResumeLayout(false);
            this.tabPagePesquisar.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudUsuarios)).EndInit();
            this.groupBoxFormulario.ResumeLayout(false);
            this.groupBoxFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bttnNew;
        private System.Windows.Forms.ToolStripButton bttnSave;
        private System.Windows.Forms.ToolStripButton bttnRefresh;
        private System.Windows.Forms.ToolStripButton bttnEdit;
        private System.Windows.Forms.ToolStripButton bttnSearch;
        private System.Windows.Forms.ToolStripButton bttnDel;
        private System.Windows.Forms.TabControl tabControlAssets;
        private System.Windows.Forms.TabPage tabPagePesquisar;
        private System.Windows.Forms.RadioButton radioBttnContem;
        private System.Windows.Forms.RadioButton radioBttnComeca;
        private System.Windows.Forms.RadioButton radioBttnTermina;
        private System.Windows.Forms.ComboBox cbButtonPesquisarEm;
        private System.Windows.Forms.TextBox txtBoxPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton bttnBeginPages;
        private System.Windows.Forms.ToolStripButton bttnOnePageLeft;
        private System.Windows.Forms.ToolStripLabel labelTextPageFrom;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel labelTextTotalPages;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel labelTextTotalRegFould;
        private System.Windows.Forms.ToolStripButton bttnOnePageRight;
        private System.Windows.Forms.ToolStripButton bttnEndPages;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridView gridCrudUsuarios;
        private System.Windows.Forms.TextBox txtNomePessoa;
        private System.Windows.Forms.TextBox txtNomePapel;
        private System.Windows.Forms.Button bttImportaPapel;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttImportPessoa;
        private System.Windows.Forms.TextBox txtBoxIdPapeis;
        private System.Windows.Forms.TextBox txtBoxIdPessoa;
        private System.Windows.Forms.CheckBox ckMenuGen;
        private System.Windows.Forms.CheckBox ckMenuAdmin;
        private System.Windows.Forms.CheckBox ckMenuOp;
        private System.Windows.Forms.CheckBox ckDeletar;
        private System.Windows.Forms.CheckBox ckEditar;
        private System.Windows.Forms.CheckBox ckPesquisar;
        private System.Windows.Forms.CheckBox ckCadastrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cbButtnQuantPage1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripComboBox cbOrdemParam1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripComboBox cbOrdenarPor1;
        private System.Windows.Forms.GroupBox groupBoxFormulario;
    }
}