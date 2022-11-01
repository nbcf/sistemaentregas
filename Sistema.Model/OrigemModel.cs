using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
    public class OrigemModel
    {
        private int idorigem;
        private string nomeorigem;
        private string codorigem;

        public OrigemModel()
        {
        }

        public int Idorigem { get => idorigem; set => idorigem = value; }
        public string Nomeorigem { get => nomeorigem; set => nomeorigem = value; }
        public string Codorigem { get => codorigem; set => codorigem = value; }

        public override bool Equals(object obj)
        {
            return obj is OrigemModel model &&
                   idorigem == model.idorigem &&
                   nomeorigem == model.nomeorigem &&
                   codorigem == model.codorigem;
        }

        public override int GetHashCode()
        {
            int hashCode = -1321371128;
            hashCode = hashCode * -1521134295 + idorigem.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomeorigem);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(codorigem);
            return hashCode;
        }
    }
}
