using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View.views
{
   public  class SomarCellDataGrid{
        public int SomarTotais(int linhasgrid, DataGridView dataGridGastos, string nomeCell)
        {
            int total = 0;
            if (linhasgrid > 0){
                foreach (DataGridViewRow datagrid in dataGridGastos.Rows){
                    int soma = Convert.ToInt32(datagrid.Cells[nomeCell].Value.ToString());
                    total = soma + total;
                }
            }else if (linhasgrid == 0) {
                MessageBox.Show("Não há valores para somar!",
                 "Aviso do Sistema",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            return total;
        }
    }
}
