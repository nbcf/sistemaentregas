using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
    class EntregasModel
    {
        private int identrega;
        private int idmovicab;

        private int idendereco;
        private string numeropacote;
        private string estatus;
        private DateTime dataentregue;
        private string horaentregue;
        private DateTime datarecebido;
        private string horarecebido;
        private string codigosistema;
        private string peso;

        public int Identrega { get => identrega; set => identrega = value; }
        public int Idendereco { get => idendereco; set => idendereco = value; }
        public string Numeropacote { get => numeropacote; set => numeropacote = value; }
        public string Estatus { get => estatus; set => estatus = value; }
        public DateTime Dataentregue { get => dataentregue; set => dataentregue = value; }
        public string Horaentregue { get => horaentregue; set => horaentregue = value; }
        public DateTime Datarecebido { get => datarecebido; set => datarecebido = value; }
        public string Horarecebido { get => horarecebido; set => horarecebido = value; }
        public string Codigosistema { get => codigosistema; set => codigosistema = value; }
        public string Peso { get => peso; set => peso = value; }
        public int Idmovicab { get => idmovicab; set => idmovicab = value; }

        public override bool Equals(object obj)
        {
            return obj is EntregasModel model &&
                   identrega == model.identrega &&
                   idmovicab == model.idmovicab &&
                   idendereco == model.idendereco &&
                   numeropacote == model.numeropacote &&
                   estatus == model.estatus &&
                   dataentregue == model.dataentregue &&
                   horaentregue == model.horaentregue &&
                   datarecebido == model.datarecebido &&
                   horarecebido == model.horarecebido &&
                   codigosistema == model.codigosistema &&
                   peso == model.peso;
        }

        public override int GetHashCode()
        {
            int hashCode = -1276378965;
            hashCode = hashCode * -1521134295 + identrega.GetHashCode();
            hashCode = hashCode * -1521134295 + idmovicab.GetHashCode();
            hashCode = hashCode * -1521134295 + idendereco.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(numeropacote);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(estatus);
            hashCode = hashCode * -1521134295 + dataentregue.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(horaentregue);
            hashCode = hashCode * -1521134295 + datarecebido.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(horarecebido);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(codigosistema);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(peso);
            return hashCode;
        }
    }
}
