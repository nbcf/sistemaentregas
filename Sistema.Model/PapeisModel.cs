using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
  public  class PapeisModel
    {
        private int idpapel;
        private string nomepapel;
        private bool criar;
        private bool recuperar;
        private bool atualizar;
        private bool excluir;
        private bool menuope;
        private bool menuadmin;
        private bool menugen;

        public int Idpapel { get => idpapel; set => idpapel = value; }
        public string Nomepapel { get => nomepapel; set => nomepapel = value; }
        public bool Criar { get => criar; set => criar = value; }
        public bool Recuperar { get => recuperar; set => recuperar = value; }
        public bool Atualizar { get => atualizar; set => atualizar = value; }
        public bool Excluir { get => excluir; set => excluir = value; }
        public bool Menuope { get => menuope; set => menuope = value; }
        public bool Menuadmin { get => menuadmin; set => menuadmin = value; }
        public bool Menugen { get => menugen; set => menugen = value; }

        public override bool Equals(object obj)
        {
            return obj is PapeisModel model &&
                   idpapel == model.idpapel &&
                   nomepapel == model.nomepapel &&
                   criar == model.criar &&
                   recuperar == model.recuperar &&
                   atualizar == model.atualizar &&
                   excluir == model.excluir &&
                   menuope == model.menuope &&
                   menuadmin == model.menuadmin &&
                   menugen == model.menugen;
        }

        public override int GetHashCode()
        {
            int hashCode = 1839947857;
            hashCode = hashCode * -1521134295 + idpapel.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomepapel);
            hashCode = hashCode * -1521134295 + criar.GetHashCode();
            hashCode = hashCode * -1521134295 + recuperar.GetHashCode();
            hashCode = hashCode * -1521134295 + atualizar.GetHashCode();
            hashCode = hashCode * -1521134295 + excluir.GetHashCode();
            hashCode = hashCode * -1521134295 + menuope.GetHashCode();
            hashCode = hashCode * -1521134295 + menuadmin.GetHashCode();
            hashCode = hashCode * -1521134295 + menugen.GetHashCode();
            return hashCode;
        }
    }
}
