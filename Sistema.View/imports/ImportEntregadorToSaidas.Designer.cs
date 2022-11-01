
namespace Sistema.View
{
    partial class ImportEntregadorToSaidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportEntregadorToSaidas));
            this.gridImportES = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportES)).BeginInit();
            this.SuspendLayout();
            // 
            // gridImportES
            // 
            this.gridImportES.AllowUserToAddRows = false;
            this.gridImportES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImportES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridImportES.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridImportES.Location = new System.Drawing.Point(0, 0);
            this.gridImportES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridImportES.MultiSelect = false;
            this.gridImportES.Name = "gridImportES";
            this.gridImportES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridImportES.Size = new System.Drawing.Size(390, 307);
            this.gridImportES.TabIndex = 11;
            this.gridImportES.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridImportES_CellMouseDoubleClick);
            // 
            // ImportEntregadorToSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 307);
            this.Controls.Add(this.gridImportES);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportEntregadorToSaidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Motorista";
            ((System.ComponentModel.ISupportInitialize)(this.gridImportES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridImportES;
    }
}