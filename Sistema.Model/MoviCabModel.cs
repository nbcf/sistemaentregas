using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
    class MoviCabModel
    {
        private int idmovicab;
        private int idveiculo;
        private int idcondutor;
        private int idoperador;
        private DateTime dataretirada;
        private DateTime dataretorno;
        private string horaretirada;
        private string horadevolvido;
        private string destino;
        private string percurso;
        private string kminicial;
        private string kmfinal;
        private string percorrido;
        private string totalgasto;
        private string estagusmovi;



        public int Idmovicab { get => idmovicab; set => idmovicab = value; }
        public int Idveiculo { get => idveiculo; set => idveiculo = value; }
        public int Idcondutor { get => idcondutor; set => idcondutor = value; }
        public int Idoperador { get => idoperador; set => idoperador = value; }
        public DateTime Dataretirada { get => dataretirada; set => dataretirada = value; }
        public DateTime Dataretorno { get => dataretorno; set => dataretorno = value; }
        public string Horaretirada { get => horaretirada; set => horaretirada = value; }
        public string Horadevolvido { get => horadevolvido; set => horadevolvido = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Percurso { get => percurso; set => percurso = value; }
        public string Kminicial { get => kminicial; set => kminicial = value; }
        public string Kmfinal { get => kmfinal; set => kmfinal = value; }
        public string Percorrido { get => percorrido; set => percorrido = value; }
        public string Totalgasto { get => totalgasto; set => totalgasto = value; }
        public string Estagusmovi { get => estagusmovi; set => estagusmovi = value; }

        public override bool Equals(object obj)
        {
            return obj is MoviCabModel model &&
                   idmovicab == model.idmovicab &&
                   idveiculo == model.idveiculo &&
                   idcondutor == model.idcondutor &&
                   idoperador == model.idoperador &&
                   dataretirada == model.dataretirada &&
                   dataretorno == model.dataretorno &&
                   horaretirada == model.horaretirada &&
                   horadevolvido == model.horadevolvido &&
                   destino == model.destino &&
                   percurso == model.percurso &&
                   kminicial == model.kminicial &&
                   kmfinal == model.kmfinal &&
                   percorrido == model.percorrido &&
                   totalgasto == model.totalgasto &&
                   estagusmovi == model.estagusmovi;
        }

        public override int GetHashCode()
        {
            int hashCode = 1532885416;
            hashCode = hashCode * -1521134295 + idmovicab.GetHashCode();
            hashCode = hashCode * -1521134295 + idveiculo.GetHashCode();
            hashCode = hashCode * -1521134295 + idcondutor.GetHashCode();
            hashCode = hashCode * -1521134295 + idoperador.GetHashCode();
            hashCode = hashCode * -1521134295 + dataretirada.GetHashCode();
            hashCode = hashCode * -1521134295 + dataretorno.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(horaretirada);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(horadevolvido);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(destino);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(percurso);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(kminicial);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(kmfinal);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(percorrido);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(totalgasto);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(estagusmovi);
            return hashCode;
        }
    }
}
