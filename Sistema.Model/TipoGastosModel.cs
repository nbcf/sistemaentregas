using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
  public class TipoGastosModel
    {

        private int idtipogasto;
        private int idtipound;
        private string nomegasto;

        public TipoGastosModel()
        {
        }

        public int Idtipogasto { get => idtipogasto; set => idtipogasto = value; }
        public int Idtipound { get => idtipound; set => idtipound = value; }
        public string Nomegasto { get => nomegasto; set => nomegasto = value; }

        public override bool Equals(object obj)
        {
            return obj is TipoGastosModel model &&
                   idtipogasto == model.idtipogasto &&
                   idtipound == model.idtipound &&
                   nomegasto == model.nomegasto;
        }

        public override int GetHashCode()
        {
            int hashCode = 856318385;
            hashCode = hashCode * -1521134295 + idtipogasto.GetHashCode();
            hashCode = hashCode * -1521134295 + idtipound.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomegasto);
            return hashCode;
        }
    }
}
