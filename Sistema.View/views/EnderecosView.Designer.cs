﻿
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bttnNew = new System.Windows.Forms.ToolStripButton();
            this.bttnSave = new System.Windows.Forms.ToolStripButton();
            this.bttnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bttnEdit = new System.Windows.Forms.ToolStripButton();
            this.bttnSearch = new System.Windows.Forms.ToolStripButton();
            this.bttnDel = new System.Windows.Forms.ToolStripButton();
            this.bttnPrint = new System.Windows.Forms.ToolStripButton();
            this.bttnExcel = new System.Windows.Forms.ToolStripButton();
            this.bttnImport = new System.Windows.Forms.ToolStripButton();
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
            this.bttnPrint,
            this.bttnExcel,
            this.bttnImport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(970, 51);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bttnNew
            // 
            this.bttnNew.AutoSize = false;
            this.bttnNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bttnNew.Image = global::Sistema.View.Properties.Resources.adicionar;
            this.bttnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnNew.Name = "bttnNew";
            this.bttnNew.Size = new System.Drawing.Size(80, 48);
            this.bttnNew.Text = "toolStripButton1";
            this.bttnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bttnNew.Click += new System.EventHandler(this.bttnNew_Click);
            // 
            // bttnSave
            // 
            this.bttnSave.AutoSize = false;
            this.bttnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnSave.Image = global::Sistema.View.Properties.Resources.salvar;
            this.bttnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(80, 48);
            this.bttnSave.Text = "toolStripButton2";
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.AutoSize = false;
            this.bttnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnRefresh.Image = global::Sistema.View.Properties.Resources.atualizar;
            this.bttnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(80, 48);
            this.bttnRefresh.Text = "toolStripButton3";
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click_1);
            // 
            // bttnEdit
            // 
            this.bttnEdit.AutoSize = false;
            this.bttnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnEdit.Image = global::Sistema.View.Properties.Resources.editar;
            this.bttnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(80, 48);
            this.bttnEdit.Text = "toolStripButton4";
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.AutoSize = false;
            this.bttnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnSearch.Image = global::Sistema.View.Properties.Resources.pesquisar;
            this.bttnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(80, 48);
            this.bttnSearch.Text = "toolStripButton5";
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click_1);
            // 
            // bttnDel
            // 
            this.bttnDel.AutoSize = false;
            this.bttnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnDel.Image = global::Sistema.View.Properties.Resources.excluir;
            this.bttnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnDel.Name = "bttnDel";
            this.bttnDel.Size = new System.Drawing.Size(80, 48);
            this.bttnDel.Text = "toolStripButton6";
            this.bttnDel.Click += new System.EventHandler(this.bttnDel_Click);
            // 
            // bttnPrint
            // 
            this.bttnPrint.AutoSize = false;
            this.bttnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnPrint.Image = global::Sistema.View.Properties.Resources.PhotoPrint;
            this.bttnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnPrint.Name = "bttnPrint";
            this.bttnPrint.Size = new System.Drawing.Size(80, 48);
            // 
            // bttnExcel
            // 
            this.bttnExcel.AutoSize = false;
            this.bttnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnExcel.Image = global::Sistema.View.Properties.Resources.Excel_icon;
            this.bttnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnExcel.Name = "bttnExcel";
            this.bttnExcel.Size = new System.Drawing.Size(80, 48);
            // 
            // bttnImport
            // 
            this.bttnImport.AutoSize = false;
            this.bttnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnImport.Image = global::Sistema.View.Properties.Resources.setaAzulAbaixo;
            this.bttnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnImport.Name = "bttnImport";
            this.bttnImport.Size = new System.Drawing.Size(80, 48);
            // 
            // tabControlAssets
            // 
            this.tabControlAssets.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlAssets.Controls.Add(this.tabPagePesquisar);
            this.tabControlAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAssets.Location = new System.Drawing.Point(0, 51);
            this.tabControlAssets.Name = "tabControlAssets";
            this.tabControlAssets.SelectedIndex = 0;
            this.tabControlAssets.Size = new System.Drawing.Size(970, 72);
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
            this.tabPagePesquisar.Location = new System.Drawing.Point(4, 25);
            this.tabPagePesquisar.Name = "tabPagePesquisar";
            this.tabPagePesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisar.Size = new System.Drawing.Size(962, 43);
            this.tabPagePesquisar.TabIndex = 1;
            this.tabPagePesquisar.Text = "Pesquisar";
            this.tabPagePesquisar.UseVisualStyleBackColor = true;
            // 
            // radioBttnTermina
            // 
            this.radioBttnTermina.AutoSize = true;
            this.radioBttnTermina.Location = new System.Drawing.Point(463, 11);
            this.radioBttnTermina.Name = "radioBttnTermina";
            this.radioBttnTermina.Size = new System.Drawing.Size(63, 17);
            this.radioBttnTermina.TabIndex = 4;
            this.radioBttnTermina.Text = "Termina";
            this.radioBttnTermina.UseVisualStyleBackColor = true;
            this.radioBttnTermina.CheckedChanged += new System.EventHandler(this.radioBttnTermina_CheckedChanged);
            // 
            // radioBttnComeca
            // 
            this.radioBttnComeca.AutoSize = true;
            this.radioBttnComeca.Location = new System.Drawing.Point(326, 10);
            this.radioBttnComeca.Name = "radioBttnComeca";
            this.radioBttnComeca.Size = new System.Drawing.Size(64, 17);
            this.radioBttnComeca.TabIndex = 6;
            this.radioBttnComeca.Text = "Começa";
            this.radioBttnComeca.UseVisualStyleBackColor = true;
            this.radioBttnComeca.CheckedChanged += new System.EventHandler(this.radioBttnComeca_CheckedChanged);
            // 
            // radioBttnContem
            // 
            this.radioBttnContem.AutoSize = true;
            this.radioBttnContem.Location = new System.Drawing.Point(396, 10);
            this.radioBttnContem.Name = "radioBttnContem";
            this.radioBttnContem.Size = new System.Drawing.Size(61, 17);
            this.radioBttnContem.TabIndex = 5;
            this.radioBttnContem.Text = "Contém";
            this.radioBttnContem.UseVisualStyleBackColor = true;
            this.radioBttnContem.CheckedChanged += new System.EventHandler(this.radioBttnContem_CheckedChanged);
            // 
            // cbButtonPesquisarEm
            // 
            this.cbButtonPesquisarEm.FormattingEnabled = true;
            this.cbButtonPesquisarEm.Items.AddRange(new object[] {
            "Logradouro",
            "Bairro",
            "Cidade",
            "Cep"});
            this.cbButtonPesquisarEm.Location = new System.Drawing.Point(182, 6);
            this.cbButtonPesquisarEm.Name = "cbButtonPesquisarEm";
            this.cbButtonPesquisarEm.Size = new System.Drawing.Size(138, 21);
            this.cbButtonPesquisarEm.TabIndex = 1;
            this.cbButtonPesquisarEm.SelectedIndexChanged += new System.EventHandler(this.cbButtonPesquisarEm_SelectedIndexChanged);
            // 
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.Location = new System.Drawing.Point(7, 6);
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(157, 20);
            this.txtBoxPesquisar.TabIndex = 0;
            this.txtBoxPesquisar.TextChanged += new System.EventHandler(this.txtBoxPesquisar_TextChanged);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(807, 10);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 8;
            // 
            // gridCrudEndereco
            // 
            this.gridCrudEndereco.AllowUserToAddRows = false;
            this.gridCrudEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCrudEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrudEndereco.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCrudEndereco.Location = new System.Drawing.Point(0, 123);
            this.gridCrudEndereco.MultiSelect = false;
            this.gridCrudEndereco.Name = "gridCrudEndereco";
            this.gridCrudEndereco.RowTemplate.Height = 25;
            this.gridCrudEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCrudEndereco.Size = new System.Drawing.Size(970, 481);
            this.gridCrudEndereco.TabIndex = 5;
            this.gridCrudEndereco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCrudPessoa_CellClick);
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
            this.cbOrdenarPor});
            this.toolStrip2.Location = new System.Drawing.Point(0, 579);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(970, 25);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // bttnBeginPages
            // 
            this.bttnBeginPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnBeginPages.Image = global::Sistema.View.Properties.Resources._2leftarrow;
            this.bttnBeginPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnBeginPages.Name = "bttnBeginPages";
            this.bttnBeginPages.Size = new System.Drawing.Size(23, 22);
            this.bttnBeginPages.Text = "toolStripButton1";
            this.bttnBeginPages.Click += new System.EventHandler(this.bttnBeginPages_Click_1);
            // 
            // bttnOnePageLeft
            // 
            this.bttnOnePageLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnOnePageLeft.Image = global::Sistema.View.Properties.Resources._1leftarrow;
            this.bttnOnePageLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnOnePageLeft.Name = "bttnOnePageLeft";
            this.bttnOnePageLeft.Size = new System.Drawing.Size(23, 22);
            this.bttnOnePageLeft.Text = "toolStripButton2";
            this.bttnOnePageLeft.Click += new System.EventHandler(this.bttnOnePageLeft_Click_1);
            // 
            // labelTextPageFrom
            // 
            this.labelTextPageFrom.Name = "labelTextPageFrom";
            this.labelTextPageFrom.Size = new System.Drawing.Size(13, 22);
            this.labelTextPageFrom.Text = "0";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(12, 22);
            this.toolStripLabel3.Text = "/";
            // 
            // labelTextTotalPages
            // 
            this.labelTextTotalPages.Name = "labelTextTotalPages";
            this.labelTextTotalPages.Size = new System.Drawing.Size(13, 22);
            this.labelTextTotalPages.Text = "0";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(12, 22);
            this.toolStripLabel5.Text = "-";
            // 
            // labelTextTotalRegFould
            // 
            this.labelTextTotalRegFould.Name = "labelTextTotalRegFould";
            this.labelTextTotalRegFould.Size = new System.Drawing.Size(13, 22);
            this.labelTextTotalRegFould.Text = "0";
            // 
            // bttnOnePageRight
            // 
            this.bttnOnePageRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnOnePageRight.Image = global::Sistema.View.Properties.Resources._1rightarrow;
            this.bttnOnePageRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnOnePageRight.Name = "bttnOnePageRight";
            this.bttnOnePageRight.Size = new System.Drawing.Size(23, 22);
            this.bttnOnePageRight.Text = "toolStripButton3";
            this.bttnOnePageRight.Click += new System.EventHandler(this.bttnOnePageRight_Click_1);
            // 
            // bttnEndPages
            // 
            this.bttnEndPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnEndPages.Image = global::Sistema.View.Properties.Resources._2rightarrow;
            this.bttnEndPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnEndPages.Name = "bttnEndPages";
            this.bttnEndPages.Size = new System.Drawing.Size(23, 22);
            this.bttnEndPages.Text = "toolStripButton4";
            this.bttnEndPages.Click += new System.EventHandler(this.bttnEndPages_Click_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(161, 22);
            this.toolStripLabel1.Text = "Total Registros Encontrados : ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel2.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel6.Text = "Qt.Pg.:";
            // 
            // cbButtnQuantPage1
            // 
            this.cbButtnQuantPage1.Items.AddRange(new object[] {
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
            this.cbButtnQuantPage1.Size = new System.Drawing.Size(121, 25);
            this.cbButtnQuantPage1.SelectedIndexChanged += new System.EventHandler(this.cbButtnQuantPage1_SelectedIndexChanged_3);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel7.Text = "Listar Por:";
            // 
            // cbOrdemParam1
            // 
            this.cbOrdemParam1.Items.AddRange(new object[] {
            "Codigo",
            "Alfabeto"});
            this.cbOrdemParam1.Name = "cbOrdemParam1";
            this.cbOrdemParam1.Size = new System.Drawing.Size(121, 25);
            this.cbOrdemParam1.SelectedIndexChanged += new System.EventHandler(this.cbOrdemParam1_Click);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel8.Text = "Ordem:";
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.Items.AddRange(new object[] {
            "Primeiros",
            "Ultimos"});
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(121, 25);
            this.cbOrdenarPor.SelectedIndexChanged += new System.EventHandler(this.cbOrdenarPor1_SelectedIndexChanged);
            // 
            // EnderecosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 604);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.gridCrudEndereco);
            this.Controls.Add(this.tabControlAssets);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EnderecosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCrudEnderecos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnderecosView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnderecosView_FormClosed);
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
        private System.Windows.Forms.ToolStripButton bttnPrint;
        private System.Windows.Forms.ToolStripButton bttnExcel;
        private System.Windows.Forms.ToolStripButton bttnImport;
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
    }
}