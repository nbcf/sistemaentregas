
namespace Sistema.View
{
    partial class ImportPessoasToUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportPessoasToUsuario));
            this.tabControlAssets = new System.Windows.Forms.TabControl();
            this.tabPagePesquisar = new System.Windows.Forms.TabPage();
            this.txtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.radioBttnContem = new System.Windows.Forms.RadioButton();
            this.radioBttnTermina = new System.Windows.Forms.RadioButton();
            this.radioBttnComeca = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlAssets.SuspendLayout();
            this.tabPagePesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControlAssets.Size = new System.Drawing.Size(817, 70);
            this.tabControlAssets.TabIndex = 7;
            // 
            // tabPagePesquisar
            // 
            this.tabPagePesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPagePesquisar.Controls.Add(this.txtBoxPesquisar);
            this.tabPagePesquisar.Controls.Add(this.radioBttnContem);
            this.tabPagePesquisar.Controls.Add(this.radioBttnTermina);
            this.tabPagePesquisar.Controls.Add(this.radioBttnComeca);
            this.tabPagePesquisar.Location = new System.Drawing.Point(4, 27);
            this.tabPagePesquisar.Name = "tabPagePesquisar";
            this.tabPagePesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisar.Size = new System.Drawing.Size(809, 39);
            this.tabPagePesquisar.TabIndex = 1;
            this.tabPagePesquisar.Text = "Pesquisar";
            this.tabPagePesquisar.UseVisualStyleBackColor = true;
            // 
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxPesquisar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesquisar.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxPesquisar.Location = new System.Drawing.Point(6, 6);
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(288, 23);
            this.txtBoxPesquisar.TabIndex = 7;
            this.txtBoxPesquisar.TextChanged += new System.EventHandler(this.txtBoxPesquisar_TextChanged_4);
            // 
            // radioBttnContem
            // 
            this.radioBttnContem.AutoSize = true;
            this.radioBttnContem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnContem.Location = new System.Drawing.Point(374, 11);
            this.radioBttnContem.Name = "radioBttnContem";
            this.radioBttnContem.Size = new System.Drawing.Size(68, 18);
            this.radioBttnContem.TabIndex = 5;
            this.radioBttnContem.Text = "Contém";
            this.radioBttnContem.UseVisualStyleBackColor = true;
            this.radioBttnContem.CheckedChanged += new System.EventHandler(this.radioBttnContem_CheckedChanged_4);
            // 
            // radioBttnTermina
            // 
            this.radioBttnTermina.AutoSize = true;
            this.radioBttnTermina.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnTermina.Location = new System.Drawing.Point(448, 11);
            this.radioBttnTermina.Name = "radioBttnTermina";
            this.radioBttnTermina.Size = new System.Drawing.Size(69, 18);
            this.radioBttnTermina.TabIndex = 4;
            this.radioBttnTermina.Text = "Termina";
            this.radioBttnTermina.UseVisualStyleBackColor = true;
            this.radioBttnTermina.CheckedChanged += new System.EventHandler(this.radioBttnTermina_CheckedChanged_2);
            // 
            // radioBttnComeca
            // 
            this.radioBttnComeca.AutoSize = true;
            this.radioBttnComeca.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnComeca.Location = new System.Drawing.Point(300, 11);
            this.radioBttnComeca.Name = "radioBttnComeca";
            this.radioBttnComeca.Size = new System.Drawing.Size(68, 18);
            this.radioBttnComeca.TabIndex = 6;
            this.radioBttnComeca.Text = "Começa";
            this.radioBttnComeca.UseVisualStyleBackColor = true;
            this.radioBttnComeca.CheckedChanged += new System.EventHandler(this.radioBttnComeca_CheckedChanged_4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(817, 420);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_2);
            // 
            // ImportPessoasToUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 490);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControlAssets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportPessoasToUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Pessoa";
            this.tabControlAssets.ResumeLayout(false);
            this.tabPagePesquisar.ResumeLayout(false);
            this.tabPagePesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAssets;
        private System.Windows.Forms.TabPage tabPagePesquisar;
        private System.Windows.Forms.TextBox txtBoxPesquisar;
        private System.Windows.Forms.RadioButton radioBttnContem;
        private System.Windows.Forms.RadioButton radioBttnTermina;
        private System.Windows.Forms.RadioButton radioBttnComeca;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}