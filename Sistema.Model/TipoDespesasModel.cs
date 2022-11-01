using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
   public class TipoDespesasModel
    {
        private int idtipodespesa;
        private string nomedespesa;
        private string tipodespesa;
        private string tpunid;

        public int Idtipodespesa { get => idtipodespesa; set => idtipodespesa = value; }
        public string Nomedespesa { get => nomedespesa; set => nomedespesa = value; }
        public string Tipodespesa { get => tipodespesa; set => tipodespesa = value; }
        public string Tpunid { get => tpunid; set => tpunid = value; }

        public override bool Equals(object obj)
        {
            return obj is TipoDespesasModel model &&
                   idtipodespesa == model.idtipodespesa &&
                   nomedespesa == model.nomedespesa &&
                   tipodespesa == model.tipodespesa &&
                   tpunid == model.tpunid;
        }

        public override int GetHashCode()
        {
            int hashCode = 102300429;
            hashCode = hashCode * -1521134295 + idtipodespesa.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomedespesa);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tipodespesa);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tpunid);
            return hashCode;
        }
    }
}
