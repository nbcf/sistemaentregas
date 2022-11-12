using Sistema.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engines{
    public class ProgramContainer{
        private static UsuariosModel usuariosModel;
        private static PessoasModel pessoasModel;
        private static PapeisModel papeisModel;


        public static UsuariosModel getUsuariosModel(){
            return usuariosModel;
        }

        public static void setUsuariosModel(UsuariosModel usuariosModel){
            ProgramContainer.usuariosModel = usuariosModel;
        }

        public static PessoasModel getPessoasModel(){
            return pessoasModel;
        }

        public static void setPessoasModel(PessoasModel pessoasModel){
            ProgramContainer.pessoasModel = pessoasModel;
        }

        public static PapeisModel getPapeisModel()
        {
            return papeisModel;
        }

        public static void setPapeisModel(PapeisModel papeisModel)
        {
            ProgramContainer.papeisModel = papeisModel;
        }
    }
}