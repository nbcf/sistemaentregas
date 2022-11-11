using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engines.Properties
{
   public  class CalculosGerenciais
    {


        public double SomarCellsVerticaisDouble(int linhasgrid, DataGridView dataGridGastos, string nomeCell)
        {
            double total = 0.0;
            if (linhasgrid > 0)
            {
                foreach (DataGridViewRow datagrid in dataGridGastos.Rows)
                {
                    double soma = Convert.ToDouble(datagrid.Cells[nomeCell].Value.ToString());
                    total = soma + total;
                }
            }
            else if (linhasgrid == 0)
            {
            }
            return total;
        }

        public int SomarTotaisCellsVerticaisInt(int linhasgrid, DataGridView dataGridGastos, string nomeCell)
        {
            int total = 0;
            if (linhasgrid > 0)
            {
                foreach (DataGridViewRow datagrid in dataGridGastos.Rows)
                {
                    int soma = Convert.ToInt32(datagrid.Cells[nomeCell].Value.ToString());
                    total = soma + total;
                }
            }
            else if (linhasgrid == 0)
            {
            }
            return total;
        }

        public double CalculoBalancaoCampoTextoDouble(int montior,double totalSoma,double totalCusto)
        {
            double total = 0;
            if (montior > 0)
            {
                    
                    total = totalSoma - totalCusto;
            
            }
            return total;
        }
    }
}
