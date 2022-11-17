
namespace Sistema.View
{
    partial class EnderecosView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnderecosView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bttnNew = new System.Windows.Forms.ToolStripButton();
            this.bttnSave = new System.Windows.Forms.ToolStripButton();
            this.bttnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bttnEdit = new System.Windows.Forms.ToolStripButton();
            this.bttnSearch = new System.Windows.Forms.ToolStripButton();
            this.bttnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControlAssets = new System.Windows.Forms.TabControl();
            this.tabPagePesquisar = new System.Windows.Forms.TabPage();
            this.radioBttnTermina = new System.Windows.Forms.RadioButton();
            this.radioBttnComeca = new System.Windows.Forms.RadioButton();
            this.radioBttnContem = new System.Windows.Forms.RadioButton();
            this.cbButtonPesquisarEm = new System.Windows.Forms.ComboBox();
            this.txtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.gridCrudEndereco = new System.Windows.Forms.DataGridView();
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
            this.cbOrdenarPor = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.tabControlAssets.SuspendLayout();
            this.tabPagePesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudEndereco)).BeginInit();
            this.toolStrip2.SuspendLayout();
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
            this.bttnDel,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(914, 51);
            this.toolStrip1.TabIndex = 3;
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
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click_1);
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
            this.bttnDel.Click += new System.EventHandler(this.bttnDel_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Sistema.View.Properties.Resources.close48;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 48);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tabControlAssets
            // 
            this.tabControlAssets.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlAssets.Controls.Add(this.tabPagePesquisar);
            this.tabControlAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAssets.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAssets.Location = new System.Drawing.Point(0, 51);
            this.tabControlAssets.Name = "tabControlAssets";
            this.tabControlAssets.SelectedIndex = 0;
            this.tabControlAssets.Size = new System.Drawing.Size(914, 95);
            this.tabControlAssets.TabIndex = 4;
            // 
            // tabPagePesquisar
            // 
            this.tabPagePesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPagePesquisar.Controls.Add(this.radioBttnTermina);
            this.tabPagePesquisar.Controls.Add(this.radioBttnComeca);
            this.tabPagePesquisar.Controls.Add(this.radioBttnContem);
            this.tabPagePesquisar.Controls.Add(this.cbButtonPesquisarEm);
            this.tabPagePesquisar.Controls.Add(this.txtBoxPesquisar);
            this.tabPagePesquisar.Controls.Add(this.txtBoxId);
            this.tabPagePesquisar.Location = new System.Drawing.Point(4, 32);
            this.tabPagePesquisar.Name = "tabPagePesquisar";
            this.tabPagePesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisar.Size = new System.Drawing.Size(906, 59);
            this.tabPagePesquisar.TabIndex = 1;
            this.tabPagePesquisar.Text = "Pesquisar";
            this.tabPagePesquisar.UseVisualStyleBackColor = true;
            // 
            // radioBttnTermina
            // 
            this.radioBttnTermina.AutoSize = true;
            this.radioBttnTermina.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnTermina.Location = new System.Drawing.Point(567, 18);
            this.radioBttnTermina.Name = "radioBttnTermina";
            this.radioBttnTermina.Size = new System.Drawing.Size(74, 21);
            this.radioBttnTermina.TabIndex = 4;
            this.radioBttnTermina.Text = "Termina";
            this.radioBttnTermina.UseVisualStyleBackColor = true;
            this.radioBttnTermina.CheckedChanged += new System.EventHandler(this.radioBttnTermina_CheckedChanged);
            // 
            // radioBttnComeca
            // 
            this.radioBttnComeca.AutoSize = true;
            this.radioBttnComeca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnComeca.Location = new System.Drawing.Point(407, 18);
            this.radioBttnComeca.Name = "radioBttnComeca";
            this.radioBttnComeca.Size = new System.Drawing.Size(74, 21);
            this.radioBttnComeca.TabIndex = 6;
            this.radioBttnComeca.Text = "Começa";
            this.radioBttnComeca.UseVisualStyleBackColor = true;
            this.radioBttnComeca.CheckedChanged += new System.EventHandler(this.radioBttnComeca_CheckedChanged);
            // 
            // radioBttnContem
            // 
            this.radioBttnContem.AutoSize = true;
            this.radioBttnContem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnContem.Location = new System.Drawing.Point(487, 18);
            this.radioBttnContem.Name = "radioBttnContem";
            this.radioBttnContem.Size = new System.Drawing.Size(74, 21);
            this.radioBttnContem.TabIndex = 5;
            this.radioBttnContem.Text = "Contém";
            this.radioBttnContem.UseVisualStyleBackColor = true;
            this.radioBttnContem.CheckedChanged += new System.EventHandler(this.radioBttnContem_CheckedChanged);
            // 
            // cbButtonPesquisarEm
            // 
            this.cbButtonPesquisarEm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbButtonPesquisarEm.FormattingEnabled = true;
            this.cbButtonPesquisarEm.Items.AddRange(new object[] {
            "Logradouro",
            "Bairro",
            "Cidade",
            "Cep"});
            this.cbButtonPesquisarEm.Location = new System.Drawing.Point(263, 14);
            this.cbButtonPesquisarEm.Name = "cbButtonPesquisarEm";
            this.cbButtonPesquisarEm.Size = new System.Drawing.Size(138, 25);
            this.cbButtonPesquisarEm.TabIndex = 1;
            this.cbButtonPesquisarEm.SelectedIndexChanged += new System.EventHandler(this.cbButtonPesquisarEm_SelectedIndexChanged);
            // 
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesquisar.Location = new System.Drawing.Point(12, 14);
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(243, 25);
            this.txtBoxPesquisar.TabIndex = 0;
            this.txtBoxPesquisar.TextChanged += new System.EventHandler(this.txtBoxPesquisar_TextChanged);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(807, 10);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 27);
            this.txtBoxId.TabIndex = 8;
            // 
            // gridCrudEndereco
            // 
            this.gridCrudEndereco.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCrudEndereco.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCrudEndereco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCrudEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCrudEndereco.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridCrudEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrudEndereco.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCrudEndereco.Location = new System.Drawing.Point(0, 146);
            this.gridCrudEndereco.MultiSelect = false;
            this.gridCrudEndereco.Name = "gridCrudEndereco";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCrudEndereco.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCrudEndereco.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridCrudEndereco.RowTemplate.Height = 25;
            this.gridCrudEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCrudEndereco.Size = new System.Drawing.Size(914, 458);
            this.gridCrudEndereco.TabIndex = 5;
            this.gridCrudEndereco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCrudPessoa_CellClick);
            this.gridCrudEndereco.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCrudEndereco_CellDoubleClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbOrdenarPor});
            this.toolStrip2.Location = new System.Drawing.Point(0, 572);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(914, 32);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // bttnBeginPages
            // 
            this.bttnBeginPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnBeginPages.Image = global::Sistema.View.Properties.Resources._2leftarrow;
            this.bttnBeginPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnBeginPages.Name = "bttnBeginPages";
            this.bttnBeginPages.Size = new System.Drawing.Size(23, 29);
            this.bttnBeginPages.Text = "toolStripButton1";
            this.bttnBeginPages.Click += new System.EventHandler(this.bttnBeginPages_Click_1);
            // 
            // bttnOnePageLeft
            // 
            this.bttnOnePageLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnOnePageLeft.Image = global::Sistema.View.Properties.Resources._1leftarrow;
            this.bttnOnePageLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnOnePageLeft.Name = "bttnOnePageLeft";
            this.bttnOnePageLeft.Size = new System.Drawing.Size(23, 29);
            this.bttnOnePageLeft.Text = "toolStripButton2";
            this.bttnOnePageLeft.Click += new System.EventHandler(this.bttnOnePageLeft_Click_1);
            // 
            // labelTextPageFrom
            // 
            this.labelTextPageFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextPageFrom.Name = "labelTextPageFrom";
            this.labelTextPageFrom.Size = new System.Drawing.Size(17, 29);
            this.labelTextPageFrom.Text = "0";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(15, 29);
            this.toolStripLabel3.Text = "/";
            // 
            // labelTextTotalPages
            // 
            this.labelTextTotalPages.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextTotalPages.Name = "labelTextTotalPages";
            this.labelTextTotalPages.Size = new System.Drawing.Size(17, 29);
            this.labelTextTotalPages.Text = "0";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(15, 29);
            this.toolStripLabel5.Text = "-";
            // 
            // labelTextTotalRegFould
            // 
            this.labelTextTotalRegFould.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextTotalRegFould.Name = "labelTextTotalRegFould";
            this.labelTextTotalRegFould.Size = new System.Drawing.Size(17, 29);
            this.labelTextTotalRegFould.Text = "0";
            // 
            // bttnOnePageRight
            // 
            this.bttnOnePageRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnOnePageRight.Image = global::Sistema.View.Properties.Resources._1rightarrow;
            this.bttnOnePageRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnOnePageRight.Name = "bttnOnePageRight";
            this.bttnOnePageRight.Size = new System.Drawing.Size(23, 29);
            this.bttnOnePageRight.Text = "toolStripButton3";
            this.bttnOnePageRight.Click += new System.EventHandler(this.bttnOnePageRight_Click_1);
            // 
            // bttnEndPages
            // 
            this.bttnEndPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnEndPages.Image = global::Sistema.View.Properties.Resources._2rightarrow;
            this.bttnEndPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnEndPages.Name = "bttnEndPages";
            this.bttnEndPages.Size = new System.Drawing.Size(23, 29);
            this.bttnEndPages.Text = "toolStripButton4";
            this.bttnEndPages.Click += new System.EventHandler(this.bttnEndPages_Click_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(209, 29);
            this.toolStripLabel1.Text = "Total Registros Encontrados : ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 29);
            this.toolStripLabel2.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(54, 29);
            this.toolStripLabel6.Text = "Qt.Pg.:";
            // 
            // cbButtnQuantPage1
            // 
            this.cbButtnQuantPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbButtnQuantPage1.Items.AddRange(new object[] {
            "3",
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
            "100",
            "Todos"});
            this.cbButtnQuantPage1.Name = "cbButtnQuantPage1";
            this.cbButtnQuantPage1.Size = new System.Drawing.Size(121, 32);
            this.cbButtnQuantPage1.SelectedIndexChanged += new System.EventHandler(this.cbButtnQuantPage1_SelectedIndexChanged_3);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(77, 29);
            this.toolStripLabel7.Text = "Listar Por:";
            // 
            // cbOrdemParam1
            // 
            this.cbOrdemParam1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdemParam1.Items.AddRange(new object[] {
            "Codigo",
            "Alfabeto"});
            this.cbOrdemParam1.Name = "cbOrdemParam1";
            this.cbOrdemParam1.Size = new System.Drawing.Size(121, 32);
            this.cbOrdemParam1.SelectedIndexChanged += new System.EventHandler(this.cbOrdemParam1_Click);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(60, 29);
            this.toolStripLabel8.Text = "Ordem:";
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenarPor.Items.AddRange(new object[] {
            "Primeiros",
            "Ultimos"});
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(121, 28);
            this.cbOrdenarPor.SelectedIndexChanged += new System.EventHandler(this.cbOrdenarPor1_SelectedIndexChanged);
            // 
            // EnderecosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 604);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.gridCrudEndereco);
            this.Controls.Add(this.tabControlAssets);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnderecosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCrudEnderecos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnderecosView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnderecosView_FormClosed);
            this.Load += new System.EventHandler(this.EnderecosView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControlAssets.ResumeLayout(false);
            this.tabPagePesquisar.ResumeLayout(false);
            this.tabPagePesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudEndereco)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.DataGridView gridCrudEndereco;
        private System.Windows.Forms.TextBox txtBoxId;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cbButtnQuantPage1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripComboBox cbOrdemParam1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripComboBox cbOrdenarPor;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}