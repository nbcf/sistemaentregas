using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
   public  class GastosModel
    {
        private int idgasto;
        private int idsaida;
        private int idfornecedor;
        private int idtipogasto;
        private string qtd;
        private string tipound;
        private string valorunitario;
        private string valototal;
        private string km;
        private DateTime datagasto;
        private string numeronota;
        private string imgnota;

        public GastosModel()
        {
        }

        public int Idgasto { get => idgasto; set => idgasto = value; }
        public int Idsaida { get => idsaida; set => idsaida = value; }
        public int Idfornecedor { get => idfornecedor; set => idfornecedor = value; }
        public int Idtipogasto { get => idtipogasto; set => idtipogasto = value; }
        public string Qtd { get => qtd; set => qtd = value; }
        public string Tipound { get => tipound; set => tipound = value; }
        public string Valorunitario { get => valorunitario; set => valorunitario = value; }
        public string Valototal { get => valototal; set => valototal = value; }

        public string Km { get => km; set => km = value; }
        public DateTime Datagasto { get => datagasto; set => datagasto = value; }
        public string Numeronota { get => numeronota; set => numeronota = value; }
        public string Imgnota { get => imgnota; set => imgnota = value; }

        public override bool Equals(object obj)
        {
            return obj is GastosModel model &&
                   idgasto == model.idgasto &&
                   idsaida == model.idsaida &&
                   idfornecedor == model.idfornecedor &&
                   idtipogasto == model.idtipogasto &&
                   qtd == model.qtd &&
                   tipound == model.tipound &&
                   valorunitario == model.valorunitario &&
                   valototal == model.valototal &&
                   km == model.km &&
                   datagasto == model.datagasto &&
                   numeronota == model.numeronota &&
                   imgnota == model.imgnota;
        }

        public override int GetHashCode()
        {
            int hashCode = 1793742811;
            hashCode = hashCode * -1521134295 + idgasto.GetHashCode();
            hashCode = hashCode * -1521134295 + idsaida.GetHashCode();
            hashCode = hashCode * -1521134295 + idfornecedor.GetHashCode();
            hashCode = hashCode * -1521134295 + idtipogasto.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(qtd);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tipound);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(valorunitario);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(valototal);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(km);
            hashCode = hashCode * -1521134295 + datagasto.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(numeronota);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(imgnota);
            return hashCode;
        }
    }
}
