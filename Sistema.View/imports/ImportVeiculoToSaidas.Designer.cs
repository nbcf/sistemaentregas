
namespace Sistema.View
{
    partial class ImportVeiculoToSaidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportVeiculoToSaidas));
            this.gridImportVS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportVS)).BeginInit();
            this.SuspendLayout();
            // 
            // gridImportVS
            // 
            this.gridImportVS.AllowUserToAddRows = false;
            this.gridImportVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImportVS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridImportVS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridImportVS.Location = new System.Drawing.Point(0, 0);
            this.gridImportVS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridImportVS.MultiSelect = false;
            this.gridImportVS.Name = "gridImportVS";
            this.gridImportVS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridImportVS.Size = new System.Drawing.Size(394, 311);
            this.gridImportVS.TabIndex = 8;
            this.gridImportVS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridImportVS_CellClick);
            this.gridImportVS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridImportVS_CellContentClick);
            this.gridImportVS.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridImportVS_CellMouseDoubleClick);
            // 
            // ImportVeiculoToSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 311);
            this.Controls.Add(this.gridImportVS);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportVeiculoToSaidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Veiculos";
            this.Load += new System.EventHandler(this.ImportVeiculoToSaidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridImportVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridImportVS;
    }
}