using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
    public class PessoasModel 
    {
        private int idpessoa;
        private int idendereco;
        private string nomepessoa;
        private string complemento;
        

        public PessoasModel()
        {

        }

        public int Idpessoa { get => idpessoa; set => idpessoa = value; }
        public int Idendereco { get => idendereco; set => idendereco = value; }
        public string Nomepessoa { get => nomepessoa; set => nomepessoa = value; }
        public string Complemento { get => complemento; set => complemento = value; }

        public override bool Equals(object obj)
        {
            return obj is PessoasModel model &&
                   idpessoa == model.idpessoa &&
                   idendereco == model.idendereco &&
                   nomepessoa == model.nomepessoa &&
                   complemento == model.complemento;
        }

        public override int GetHashCode()
        {
            int hashCode = 1052860019;
            hashCode = hashCode * -1521134295 + idpessoa.GetHashCode();
            hashCode = hashCode * -1521134295 + idendereco.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomepessoa);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(complemento);
            return hashCode;
        }
    }
}
