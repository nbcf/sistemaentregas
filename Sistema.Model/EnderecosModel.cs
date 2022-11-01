using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
    public class EnderecosModel
    {
        private int idendereco;
        private string endereco;
        private string logradouro;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;

        public int Idendereco { get => idendereco; set => idendereco = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cep { get => cep; set => cep = value; }

        public override bool Equals(object obj)
        {
            return obj is EnderecosModel model &&
                   idendereco == model.idendereco &&
                   endereco == model.endereco &&
                   logradouro == model.logradouro &&
                   bairro == model.bairro &&
                   cidade == model.cidade &&
                   uf == model.uf &&
                   cep == model.cep;
        }

        public override int GetHashCode()
        {
            int hashCode = -1244987638;
            hashCode = hashCode * -1521134295 + idendereco.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(endereco);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(logradouro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(bairro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cidade);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(uf);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cep);
            return hashCode;
        }
    }
}
