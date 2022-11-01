
namespace Sistema.View
{
    partial class ImportEncomendasToSaida
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
            this.bttnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bttnSearch = new System.Windows.Forms.ToolStripButton();
            this.tabControlAssets = new System.Windows.Forms.TabControl();
            this.tabPagePesquisar = new System.Windows.Forms.TabPage();
            this.cbButtonPesquisarEm = new System.Windows.Forms.ComboBox();
            this.txtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.radioBttnTermina = new System.Windows.Forms.RadioButton();
            this.radioBttnContem = new System.Windows.Forms.RadioButton();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.radioBttnComeca = new System.Windows.Forms.RadioButton();
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
            this.gridCrudImporES = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tabControlAssets.SuspendLayout();
            this.tabPagePesquisar.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudImporES)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttnRefresh,
            this.bttnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(774, 51);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
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
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
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
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // tabControlAssets
            // 
            this.tabControlAssets.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlAssets.Controls.Add(this.tabPagePesquisar);
            this.tabControlAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAssets.Location = new System.Drawing.Point(0, 51);
            this.tabControlAssets.Name = "tabControlAssets";
            this.tabControlAssets.SelectedIndex = 0;
            this.tabControlAssets.Size = new System.Drawing.Size(774, 72);
            this.tabControlAssets.TabIndex = 6;
            // 
            // tabPagePesquisar
            // 
            this.tabPagePesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPagePesquisar.Controls.Add(this.cbButtonPesquisarEm);
            this.tabPagePesquisar.Controls.Add(this.txtBoxPesquisar);
            this.tabPagePesquisar.Controls.Add(this.radioBttnTermina);
            this.tabPagePesquisar.Controls.Add(this.radioBttnContem);
            this.tabPagePesquisar.Controls.Add(this.txtBoxId);
            this.tabPagePesquisar.Controls.Add(this.radioBttnComeca);
            this.tabPagePesquisar.Location = new System.Drawing.Point(4, 25);
            this.tabPagePesquisar.Name = "tabPagePesquisar";
            this.tabPagePesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisar.Size = new System.Drawing.Size(766, 43);
            this.tabPagePesquisar.TabIndex = 1;
            this.tabPagePesquisar.Text = "Pesquisar";
            this.tabPagePesquisar.UseVisualStyleBackColor = true;
            // 
            // cbButtonPesquisarEm
            // 
            this.cbButtonPesquisarEm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbButtonPesquisarEm.FormattingEnabled = true;
            this.cbButtonPesquisarEm.Items.AddRange(new object[] {
            "Destinatario",
            "Cpf",
            "Numero Encomenda",
            "Origem",
            "Logradouro",
            "Bairro"});
            this.cbButtonPesquisarEm.Location = new System.Drawing.Point(193, 6);
            this.cbButtonPesquisarEm.Name = "cbButtonPesquisarEm";
            this.cbButtonPesquisarEm.Size = new System.Drawing.Size(121, 24);
            this.cbButtonPesquisarEm.TabIndex = 1;
            // 
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesquisar.Location = new System.Drawing.Point(6, 6);
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(180, 23);
            this.txtBoxPesquisar.TabIndex = 0;
            // 
            // radioBttnTermina
            // 
            this.radioBttnTermina.AutoSize = true;
            this.radioBttnTermina.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnTermina.Location = new System.Drawing.Point(457, 10);
            this.radioBttnTermina.Name = "radioBttnTermina";
            this.radioBttnTermina.Size = new System.Drawing.Size(74, 20);
            this.radioBttnTermina.TabIndex = 4;
            this.radioBttnTermina.Text = "Termina";
            this.radioBttnTermina.UseVisualStyleBackColor = true;
            // 
            // radioBttnContem
            // 
            this.radioBttnContem.AutoSize = true;
            this.radioBttnContem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnContem.Location = new System.Drawing.Point(390, 10);
            this.radioBttnContem.Name = "radioBttnContem";
            this.radioBttnContem.Size = new System.Drawing.Size(70, 20);
            this.radioBttnContem.TabIndex = 5;
            this.radioBttnContem.Text = "Contém";
            this.radioBttnContem.UseVisualStyleBackColor = true;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(537, 11);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 8;
            // 
            // radioBttnComeca
            // 
            this.radioBttnComeca.AutoSize = true;
            this.radioBttnComeca.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnComeca.Location = new System.Drawing.Point(320, 10);
            this.radioBttnComeca.Name = "radioBttnComeca";
            this.radioBttnComeca.Size = new System.Drawing.Size(72, 20);
            this.radioBttnComeca.TabIndex = 6;
            this.radioBttnComeca.Text = "Começa";
            this.radioBttnComeca.UseVisualStyleBackColor = true;
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
            this.toolStrip2.Location = new System.Drawing.Point(0, 502);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(774, 25);
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
            // 
            // bttnOnePageLeft
            // 
            this.bttnOnePageLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnOnePageLeft.Image = global::Sistema.View.Properties.Resources._1leftarrow;
            this.bttnOnePageLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnOnePageLeft.Name = "bttnOnePageLeft";
            this.bttnOnePageLeft.Size = new System.Drawing.Size(23, 22);
            this.bttnOnePageLeft.Text = "toolStripButton2";
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
            // 
            // bttnEndPages
            // 
            this.bttnEndPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnEndPages.Image = global::Sistema.View.Properties.Resources._2rightarrow;
            this.bttnEndPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnEndPages.Name = "bttnEndPages";
            this.bttnEndPages.Size = new System.Drawing.Size(23, 22);
            this.bttnEndPages.Text = "toolStripButton4";
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
            "100"});
            this.cbButtnQuantPage1.Name = "cbButtnQuantPage1";
            this.cbButtnQuantPage1.Size = new System.Drawing.Size(75, 25);
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
            this.cbOrdemParam1.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel8.Text = "Ordem:";
            // 
            // cbOrdenarPor1
            // 
            this.cbOrdenarPor1.Items.AddRange(new object[] {
            "Primeiros",
            "Ultimos"});
            this.cbOrdenarPor1.Name = "cbOrdenarPor1";
            this.cbOrdenarPor1.Size = new System.Drawing.Size(80, 25);
            // 
            // gridCrudImporES
            // 
            this.gridCrudImporES.AllowUserToAddRows = false;
            this.gridCrudImporES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCrudImporES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrudImporES.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCrudImporES.Location = new System.Drawing.Point(0, 123);
            this.gridCrudImporES.MultiSelect = false;
            this.gridCrudImporES.Name = "gridCrudImporES";
            this.gridCrudImporES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCrudImporES.Size = new System.Drawing.Size(774, 379);
            this.gridCrudImporES.TabIndex = 10;
            this.gridCrudImporES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCrudImporES_CellContentClick);
            this.gridCrudImporES.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCrudImporES_CellMouseDoubleClick);
            // 
            // ImportEncomendasToSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 527);
            this.Controls.Add(this.gridCrudImporES);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.tabControlAssets);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportEncomendasToSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despachar Encomendas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImportEncomendasToSaida_FormClosed);
            this.Load += new System.EventHandler(this.ImportEncomendasToSaida_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControlAssets.ResumeLayout(false);
            this.tabPagePesquisar.ResumeLayout(false);
            this.tabPagePesquisar.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudImporES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bttnRefresh;
        private System.Windows.Forms.ToolStripButton bttnSearch;
        private System.Windows.Forms.TabControl tabControlAssets;
        private System.Windows.Forms.TabPage tabPagePesquisar;
        private System.Windows.Forms.ComboBox cbButtonPesquisarEm;
        private System.Windows.Forms.TextBox txtBoxPesquisar;
        private System.Windows.Forms.RadioButton radioBttnTermina;
        private System.Windows.Forms.RadioButton radioBttnContem;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.RadioButton radioBttnComeca;
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
        private System.Windows.Forms.ToolStripComboBox cbOrdenarPor1;
        private System.Windows.Forms.DataGridView gridCrudImporES;
    }
}