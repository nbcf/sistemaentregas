using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
   public class FornecedoresModel
    {
        private int idfornecedor;
        private string fornecedor;

        public FornecedoresModel()
        {
           
        }

        public int Idfornecedor { get => idfornecedor; set => idfornecedor = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }

        public override bool Equals(object obj)
        {
            return obj is FornecedoresModel model &&
                   idfornecedor == model.idfornecedor &&
                   fornecedor == model.fornecedor;
        }

        public override int GetHashCode()
        {
            int hashCode = -1932123727;
            hashCode = hashCode * -1521134295 + idfornecedor.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(fornecedor);
            return hashCode;
        }
    }
}
