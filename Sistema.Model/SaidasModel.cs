    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Sistema.Model
    {
    public class SaidasModel
    {
        private int idsaida;
        private int idveiculo;
        private int idusuario;
        private int idpapel;
        private int idpessoa;

        private string nomeveiculo;
        private string placa;
        private string entregador;

        private DateTime datasaida;
        private DateTime dataretorno;
        private string horasaida;
        private string horaretorno;

        private string estsaida;
        private string regiaoentrega;
        private string kmsaida;
        private string kmretorno;
        private string kmtotal;


        public SaidasModel()
        {

        }

        public int Idsaida { get => idsaida; set => idsaida = value; }
        public int Idveiculo { get => idveiculo; set => idveiculo = value; }
        public int Idusuario { get => idusuario; set => idusuario = value; }
        public int Idpapel { get => idpapel; set => idpapel = value; }
        public int Idpessoa { get => idpessoa; set => idpessoa = value; }
        public string Nomeveiculo { get => nomeveiculo; set => nomeveiculo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Entregador { get => entregador; set => entregador = value; }
        public DateTime Datasaida { get => datasaida; set => datasaida = value; }
        public DateTime Dataretorno { get => dataretorno; set => dataretorno = value; }
        public string Horasaida { get => horasaida; set => horasaida = value; }
        public string Horaretorno { get => horaretorno; set => horaretorno = value; }
        public string Estsaida { get => estsaida; set => estsaida = value; }
        public string Regiaoentrega { get => regiaoentrega; set => regiaoentrega = value; }
        public string Kmsaida { get => kmsaida; set => kmsaida = value; }
        public string Kmretorno { get => kmretorno; set => kmretorno = value; }
        public string Kmtotal { get => kmtotal; set => kmtotal = value; }

        public override bool Equals(object obj)
        {
            return obj is SaidasModel model &&
                   idsaida == model.idsaida &&
                   idveiculo == model.idveiculo &&
                   idusuario == model.idusuario &&
                   idpapel == model.idpapel &&
                   idpessoa == model.idpessoa &&
                   nomeveiculo == model.nomeveiculo &&
                   placa == model.placa &&
                   entregador == model.entregador &&
                   datasaida == model.datasaida &&
                   dataretorno == model.dataretorno &&
                   horasaida == model.horasaida &&
                   horaretorno == model.horaretorno &&
                   estsaida == model.estsaida &&
                   regiaoentrega == model.regiaoentrega &&
                   kmsaida == model.kmsaida &&
                   kmretorno == model.kmretorno &&
                   kmtotal == model.kmtotal;
        }

        public override int GetHashCode()
        {
            int hashCode = -1806860248;
            hashCode = hashCode * -1521134295 + idsaida.GetHashCode();
            hashCode = hashCode * -1521134295 + idveiculo.GetHashCode();
            hashCode = hashCode * -1521134295 + idusuario.GetHashCode();
            hashCode = hashCode * -1521134295 + idpapel.GetHashCode();
            hashCode = hashCode * -1521134295 + idpessoa.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomeveiculo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(placa);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(entregador);
            hashCode = hashCode * -1521134295 + datasaida.GetHashCode();
            hashCode = hashCode * -1521134295 + dataretorno.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(horasaida);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(horaretorno);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(estsaida);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(regiaoentrega);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(kmsaida);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(kmretorno);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(kmtotal);
            return hashCode;
        }
    }

    }
