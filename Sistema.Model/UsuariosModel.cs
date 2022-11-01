using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
    public class UsuariosModel 
    {
        private int idusuario;
        private int idpessoa;
        private int idpapel;
        private string usuario;
        private string senha;

        public UsuariosModel()
        {

        }

        public int Idusuario {
            get => idusuario;
            set => idusuario = value; 
        }
        public int Idpessoa { 
            get => idpessoa;
            set => idpessoa = value; 
        }

        public int Idpapel { 
            get => idpapel; 
            set => idpapel = value; 
        }

        public string Usuario {
            get => usuario;
            set => usuario = value; 
        }

        public string Senha { 
            get => senha; 
            set => senha = value; 
        }

        public override bool Equals(object obj)
        {
            return obj is UsuariosModel model &&
                   idusuario == model.idusuario &&
                   idpessoa == model.idpessoa &&
                   idpapel == model.idpapel &&
                   usuario == model.usuario &&
                   senha == model.senha;
        }

        public override int GetHashCode()
        {
            int hashCode = 1556401730;
            hashCode = hashCode * -1521134295 + idusuario.GetHashCode();
            hashCode = hashCode * -1521134295 + idpessoa.GetHashCode();
            hashCode = hashCode * -1521134295 + idpapel.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(usuario);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(senha);
            return hashCode;
        }
    }
}
