
namespace Sistema.View.imports
{
    partial class ImportSaidasToGastos
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
            this.gridCrudSaidas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCrudSaidas
            // 
            this.gridCrudSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCrudSaidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrudSaidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCrudSaidas.Location = new System.Drawing.Point(0, 0);
            this.gridCrudSaidas.MultiSelect = false;
            this.gridCrudSaidas.Name = "gridCrudSaidas";
            this.gridCrudSaidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCrudSaidas.Size = new System.Drawing.Size(646, 373);
            this.gridCrudSaidas.TabIndex = 0;
            this.gridCrudSaidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCrudSaidas_CellContentClick);
            this.gridCrudSaidas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // ImportSaidasToGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 373);
            this.Controls.Add(this.gridCrudSaidas);
            this.MaximizeBox = false;
            this.Name = "ImportSaidasToGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportSaidasToGastos";
            this.Load += new System.EventHandler(this.ImportSaidasToGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudSaidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCrudSaidas;
    }
}