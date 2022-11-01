using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
   public class TipoUndsModel
    {
        private int idtipound;
        private string nomeund;

        public TipoUndsModel()
        {
        }

        public int Idtipound { get => idtipound; set => idtipound = value; }
        public string Nomeund { get => nomeund; set => nomeund = value; }

        public override bool Equals(object obj)
        {
            return obj is TipoUndsModel model &&
                   idtipound == model.idtipound &&
                   nomeund == model.nomeund;
        }

        public override int GetHashCode()
        {
            int hashCode = 1866968368;
            hashCode = hashCode * -1521134295 + idtipound.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomeund);
            return hashCode;
        }
    }
}
