
namespace Sistema.View
{
    partial class ImportEnderecos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportEnderecos));
            this.dataGridImpEndereco = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlAssets = new System.Windows.Forms.TabControl();
            this.tabPagePesquisar = new System.Windows.Forms.TabPage();
            this.radioBttnTermina = new System.Windows.Forms.RadioButton();
            this.radioBttnContem = new System.Windows.Forms.RadioButton();
            this.cbButtonPesquisarEm = new System.Windows.Forms.ComboBox();
            this.radioBttnComeca = new System.Windows.Forms.RadioButton();
            this.txtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bttnNew = new System.Windows.Forms.ToolStripButton();
            this.bttnSave = new System.Windows.Forms.ToolStripButton();
            this.bttnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bttnEdit = new System.Windows.Forms.ToolStripButton();
            this.bttnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImpEndereco)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControlAssets.SuspendLayout();
            this.tabPagePesquisar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridImpEndereco
            // 
            this.dataGridImpEndereco.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridImpEndereco.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridImpEndereco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridImpEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridImpEndereco.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridImpEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridImpEndereco.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridImpEndereco.Location = new System.Drawing.Point(0, 0);
            this.dataGridImpEndereco.MultiSelect = false;
            this.dataGridImpEndereco.Name = "dataGridImpEndereco";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridImpEndereco.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridImpEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridImpEndereco.Size = new System.Drawing.Size(768, 450);
            this.dataGridImpEndereco.TabIndex = 8;
            this.dataGridImpEndereco.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridImpEndereco_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.txtUf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 312);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 25);
            this.button1.TabIndex = 34;
            this.button1.Text = "Cep:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(103, 106);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(171, 25);
            this.txtCep.TabIndex = 29;
            // 
            // txtUf
            // 
            this.txtUf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.Location = new System.Drawing.Point(313, 80);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(84, 25);
            this.txtUf.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(103, 77);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(171, 25);
            this.txtCidade.TabIndex = 25;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(103, 48);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(294, 25);
            this.txtBairro.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bairro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(103, 19);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(294, 25);
            this.txtLogradouro.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Endereço";
            // 
            // tabControlAssets
            // 
            this.tabControlAssets.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlAssets.Controls.Add(this.tabPagePesquisar);
            this.tabControlAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAssets.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAssets.Location = new System.Drawing.Point(0, 51);
            this.tabControlAssets.Name = "tabControlAssets";
            this.tabControlAssets.SelectedIndex = 0;
            this.tabControlAssets.Size = new System.Drawing.Size(768, 87);
            this.tabControlAssets.TabIndex = 11;
            // 
            // tabPagePesquisar
            // 
            this.tabPagePesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPagePesquisar.Controls.Add(this.radioBttnTermina);
            this.tabPagePesquisar.Controls.Add(this.radioBttnContem);
            this.tabPagePesquisar.Controls.Add(this.cbButtonPesquisarEm);
            this.tabPagePesquisar.Controls.Add(this.radioBttnComeca);
            this.tabPagePesquisar.Controls.Add(this.txtBoxPesquisar);
            this.tabPagePesquisar.Location = new System.Drawing.Point(4, 32);
            this.tabPagePesquisar.Name = "tabPagePesquisar";
            this.tabPagePesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisar.Size = new System.Drawing.Size(760, 51);
            this.tabPagePesquisar.TabIndex = 1;
            this.tabPagePesquisar.Text = "Pesquisar";
            this.tabPagePesquisar.UseVisualStyleBackColor = true;
            // 
            // radioBttnTermina
            // 
            this.radioBttnTermina.AutoSize = true;
            this.radioBttnTermina.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnTermina.Location = new System.Drawing.Point(467, 9);
            this.radioBttnTermina.Name = "radioBttnTermina";
            this.radioBttnTermina.Size = new System.Drawing.Size(74, 21);
            this.radioBttnTermina.TabIndex = 4;
            this.radioBttnTermina.Text = "Termina";
            this.radioBttnTermina.UseVisualStyleBackColor = true;
            // 
            // radioBttnContem
            // 
            this.radioBttnContem.AutoSize = true;
            this.radioBttnContem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnContem.Location = new System.Drawing.Point(391, 10);
            this.radioBttnContem.Name = "radioBttnContem";
            this.radioBttnContem.Size = new System.Drawing.Size(74, 21);
            this.radioBttnContem.TabIndex = 5;
            this.radioBttnContem.Text = "Contém";
            this.radioBttnContem.UseVisualStyleBackColor = true;
            // 
            // cbButtonPesquisarEm
            // 
            this.cbButtonPesquisarEm.AutoCompleteCustomSource.AddRange(new string[] {
            "Logradouro",
            "Bairro"});
            this.cbButtonPesquisarEm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbButtonPesquisarEm.FormattingEnabled = true;
            this.cbButtonPesquisarEm.Items.AddRange(new object[] {
            "Nome"});
            this.cbButtonPesquisarEm.Location = new System.Drawing.Point(170, 6);
            this.cbButtonPesquisarEm.Name = "cbButtonPesquisarEm";
            this.cbButtonPesquisarEm.Size = new System.Drawing.Size(138, 25);
            this.cbButtonPesquisarEm.TabIndex = 1;
            // 
            // radioBttnComeca
            // 
            this.radioBttnComeca.AutoSize = true;
            this.radioBttnComeca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnComeca.Location = new System.Drawing.Point(316, 10);
            this.radioBttnComeca.Name = "radioBttnComeca";
            this.radioBttnComeca.Size = new System.Drawing.Size(74, 21);
            this.radioBttnComeca.TabIndex = 6;
            this.radioBttnComeca.Text = "Começa";
            this.radioBttnComeca.UseVisualStyleBackColor = true;
            // 
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesquisar.Location = new System.Drawing.Point(7, 6);
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(157, 25);
            this.txtBoxPesquisar.TabIndex = 0;
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
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(768, 51);
            this.toolStrip1.TabIndex = 10;
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
            this.bttnNew.Size = new System.Drawing.Size(80, 48);
            this.bttnNew.Text = "toolStripButton1";
            this.bttnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bttnNew.Click += new System.EventHandler(this.bttnNew_Click);
            // 
            // bttnSave
            // 
            this.bttnSave.AutoSize = false;
            this.bttnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnSave.Image = global::Sistema.View.Properties.Resources.ok48;
            this.bttnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
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
            this.bttnRefresh.Image = global::Sistema.View.Properties.Resources.refresh48;
            this.bttnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(80, 48);
            this.bttnRefresh.Text = "toolStripButton3";
            // 
            // bttnEdit
            // 
            this.bttnEdit.AutoSize = false;
            this.bttnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnEdit.Image = global::Sistema.View.Properties.Resources.editForm48;
            this.bttnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
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
            this.bttnSearch.Image = global::Sistema.View.Properties.Resources.search48;
            this.bttnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(80, 48);
            this.bttnSearch.Text = "toolStripButton5";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Sistema.View.Properties.Resources.close48;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 48);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ImportEnderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControlAssets);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridImpEndereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportEnderecos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Endereços Offline";
            this.Load += new System.EventHandler(this.ImportEnderecos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImpEndereco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlAssets.ResumeLayout(false);
            this.tabPagePesquisar.ResumeLayout(false);
            this.tabPagePesquisar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridImpEndereco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControlAssets;
        private System.Windows.Forms.TabPage tabPagePesquisar;
        private System.Windows.Forms.RadioButton radioBttnTermina;
        private System.Windows.Forms.RadioButton radioBttnContem;
        private System.Windows.Forms.ComboBox cbButtonPesquisarEm;
        private System.Windows.Forms.RadioButton radioBttnComeca;
        private System.Windows.Forms.TextBox txtBoxPesquisar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bttnNew;
        private System.Windows.Forms.ToolStripButton bttnSave;
        private System.Windows.Forms.ToolStripButton bttnRefresh;
        private System.Windows.Forms.ToolStripButton bttnEdit;
        private System.Windows.Forms.ToolStripButton bttnSearch;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}