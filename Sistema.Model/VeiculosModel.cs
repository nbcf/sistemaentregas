using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
   public class VeiculosModel
    {
        private int idveiculo;
        private string nomeveiculo;
        private string placa;
        private string estatusveiculo;

        public VeiculosModel()
        {
        }

        public int Idveiculo { get => idveiculo; set => idveiculo = value; }
        public string Nomeveiculo { get => nomeveiculo; set => nomeveiculo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Estatusveiculo { get => estatusveiculo; set => estatusveiculo = value; }

        public override bool Equals(object obj)
        {
            return obj is VeiculosModel model &&
                   idveiculo == model.idveiculo &&
                   nomeveiculo == model.nomeveiculo &&
                   placa == model.placa &&
                   estatusveiculo == model.estatusveiculo;
        }

        public override int GetHashCode()
        {
            int hashCode = -1664484267;
            hashCode = hashCode * -1521134295 + idveiculo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomeveiculo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(placa);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(estatusveiculo);
            return hashCode;
        }
    }
}
