using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
    class MoviDetModel
    {
        private int idmovidet;
        private int idtipodespesa;
        private int idmovicab;
        private string qtd;
        private string valor;
        private string kmabastecimento;
        private string dataabastecimento;

        public int Idmovidet { get => idmovidet; set => idmovidet = value; }
        public int Idtipodespesa { get => idtipodespesa; set => idtipodespesa = value; }
        public int Idmovicab { get => idmovicab; set => idmovicab = value; }
        public string Qtd { get => qtd; set => qtd = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Kmabastecimento { get => kmabastecimento; set => kmabastecimento = value; }
        public string Dataabastecimento { get => dataabastecimento; set => dataabastecimento = value; }

        public override bool Equals(object obj)
        {
            return obj is MoviDetModel model &&
                   idmovidet == model.idmovidet &&
                   idtipodespesa == model.idtipodespesa &&
                   idmovicab == model.idmovicab &&
                   qtd == model.qtd &&
                   valor == model.valor &&
                   kmabastecimento == model.kmabastecimento &&
                   dataabastecimento == model.dataabastecimento;
        }

        public override int GetHashCode()
        {
            int hashCode = -386652931;
            hashCode = hashCode * -1521134295 + idmovidet.GetHashCode();
            hashCode = hashCode * -1521134295 + idtipodespesa.GetHashCode();
            hashCode = hashCode * -1521134295 + idmovicab.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(qtd);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(valor);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(kmabastecimento);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dataabastecimento);
            return hashCode;
        }
    }
}
