
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportEnderecos));
            this.tabControlAssets = new System.Windows.Forms.TabControl();
            this.tabPagePesquisar = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.radioBttnContem = new System.Windows.Forms.RadioButton();
            this.radioBttnTermina = new System.Windows.Forms.RadioButton();
            this.radioBttnComeca = new System.Windows.Forms.RadioButton();
            this.cbButtonPesquisarEm = new System.Windows.Forms.ComboBox();
            this.dataGridImpEndereco = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlAssets.SuspendLayout();
            this.tabPagePesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImpEndereco)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAssets
            // 
            this.tabControlAssets.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlAssets.Controls.Add(this.tabPagePesquisar);
            this.tabControlAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAssets.Location = new System.Drawing.Point(0, 0);
            this.tabControlAssets.Name = "tabControlAssets";
            this.tabControlAssets.SelectedIndex = 0;
            this.tabControlAssets.Size = new System.Drawing.Size(768, 76);
            this.tabControlAssets.TabIndex = 7;
            // 
            // tabPagePesquisar
            // 
            this.tabPagePesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPagePesquisar.Controls.Add(this.button4);
            this.tabPagePesquisar.Controls.Add(this.txtBoxPesquisar);
            this.tabPagePesquisar.Controls.Add(this.radioBttnContem);
            this.tabPagePesquisar.Controls.Add(this.radioBttnTermina);
            this.tabPagePesquisar.Controls.Add(this.radioBttnComeca);
            this.tabPagePesquisar.Controls.Add(this.cbButtonPesquisarEm);
            this.tabPagePesquisar.Location = new System.Drawing.Point(4, 27);
            this.tabPagePesquisar.Name = "tabPagePesquisar";
            this.tabPagePesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisar.Size = new System.Drawing.Size(760, 45);
            this.tabPagePesquisar.TabIndex = 1;
            this.tabPagePesquisar.Text = "Pesquisar";
            this.tabPagePesquisar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(673, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 27);
            this.button4.TabIndex = 34;
            this.button4.Text = "Novo";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxPesquisar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesquisar.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxPesquisar.Location = new System.Drawing.Point(6, 6);
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(276, 23);
            this.txtBoxPesquisar.TabIndex = 7;
            this.txtBoxPesquisar.TextChanged += new System.EventHandler(this.txtBoxPesquisar_TextChanged_4);
            // 
            // radioBttnContem
            // 
            this.radioBttnContem.AutoSize = true;
            this.radioBttnContem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnContem.Location = new System.Drawing.Point(490, 9);
            this.radioBttnContem.Name = "radioBttnContem";
            this.radioBttnContem.Size = new System.Drawing.Size(70, 20);
            this.radioBttnContem.TabIndex = 5;
            this.radioBttnContem.Text = "Contém";
            this.radioBttnContem.UseVisualStyleBackColor = true;
            this.radioBttnContem.CheckedChanged += new System.EventHandler(this.radioBttnContem_CheckedChanged_4);
            // 
            // radioBttnTermina
            // 
            this.radioBttnTermina.AutoSize = true;
            this.radioBttnTermina.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnTermina.Location = new System.Drawing.Point(561, 10);
            this.radioBttnTermina.Name = "radioBttnTermina";
            this.radioBttnTermina.Size = new System.Drawing.Size(74, 20);
            this.radioBttnTermina.TabIndex = 4;
            this.radioBttnTermina.Text = "Termina";
            this.radioBttnTermina.UseVisualStyleBackColor = true;
            this.radioBttnTermina.CheckedChanged += new System.EventHandler(this.radioBttnTermina_CheckedChanged_2);
            // 
            // radioBttnComeca
            // 
            this.radioBttnComeca.AutoSize = true;
            this.radioBttnComeca.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnComeca.Location = new System.Drawing.Point(415, 8);
            this.radioBttnComeca.Name = "radioBttnComeca";
            this.radioBttnComeca.Size = new System.Drawing.Size(72, 20);
            this.radioBttnComeca.TabIndex = 6;
            this.radioBttnComeca.Text = "Começa";
            this.radioBttnComeca.UseVisualStyleBackColor = true;
            this.radioBttnComeca.CheckedChanged += new System.EventHandler(this.radioBttnComeca_CheckedChanged_4);
            // 
            // cbButtonPesquisarEm
            // 
            this.cbButtonPesquisarEm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbButtonPesquisarEm.FormattingEnabled = true;
            this.cbButtonPesquisarEm.Items.AddRange(new object[] {
            "Logradouro",
            "Bairro"});
            this.cbButtonPesquisarEm.Location = new System.Drawing.Point(288, 5);
            this.cbButtonPesquisarEm.Name = "cbButtonPesquisarEm";
            this.cbButtonPesquisarEm.Size = new System.Drawing.Size(120, 24);
            this.cbButtonPesquisarEm.TabIndex = 1;
            this.cbButtonPesquisarEm.SelectedIndexChanged += new System.EventHandler(this.cbButtonPesquisarEm_SelectedIndexChanged_3);
            // 
            // dataGridImpEndereco
            // 
            this.dataGridImpEndereco.AllowUserToAddRows = false;
            this.dataGridImpEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridImpEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridImpEndereco.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridImpEndereco.Location = new System.Drawing.Point(0, 76);
            this.dataGridImpEndereco.MultiSelect = false;
            this.dataGridImpEndereco.Name = "dataGridImpEndereco";
            this.dataGridImpEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridImpEndereco.Size = new System.Drawing.Size(768, 292);
            this.dataGridImpEndereco.TabIndex = 8;
            this.dataGridImpEndereco.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridImpEndereco_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
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
            this.groupBox1.Location = new System.Drawing.Point(0, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 292);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Cep:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Sistema.View.Properties.Resources.redDot;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(103, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 32;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Sistema.View.Properties.Resources.greenDot;
            this.button2.Location = new System.Drawing.Point(199, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 32;
            this.button2.Text = "Salvar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(103, 106);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(171, 20);
            this.txtCep.TabIndex = 29;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(313, 80);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(84, 20);
            this.txtUf.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(103, 77);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(171, 20);
            this.txtCidade.TabIndex = 25;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(103, 48);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(294, 20);
            this.txtBairro.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bairro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(103, 19);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(294, 20);
            this.txtLogradouro.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Endereço";
            // 
            // ImportEnderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(768, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridImpEndereco);
            this.Controls.Add(this.tabControlAssets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ImportEnderecos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Endereços Offline";
            this.tabControlAssets.ResumeLayout(false);
            this.tabPagePesquisar.ResumeLayout(false);
            this.tabPagePesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImpEndereco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAssets;
        private System.Windows.Forms.TabPage tabPagePesquisar;
        private System.Windows.Forms.TextBox txtBoxPesquisar;
        private System.Windows.Forms.RadioButton radioBttnContem;
        private System.Windows.Forms.RadioButton radioBttnTermina;
        private System.Windows.Forms.RadioButton radioBttnComeca;
        private System.Windows.Forms.ComboBox cbButtonPesquisarEm;
        private System.Windows.Forms.DataGridView dataGridImpEndereco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}