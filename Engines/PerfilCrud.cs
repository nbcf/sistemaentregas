using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engines
{
  public  class PerfilCrud{

        public void PermissoesCrud(
            ToolStripButton bttnNew,
            ToolStripButton bttnSave,
            ToolStripButton bttnRefresh, 
            ToolStripButton bttnEdit,
            ToolStripButton bbtnDel,
            ToolStripButton bbtnSearch) {

            bttnNew.Visible     =   ProgramContainer.getPapeisModel().Criar     ? true : false;
            bttnSave.Visible    =   ProgramContainer.getPapeisModel().Criar     ? true : false;
            bttnRefresh.Visible =   ProgramContainer.getPapeisModel().Atualizar ? true : false;
            bttnEdit.Visible    =   ProgramContainer.getPapeisModel().Atualizar ? true : false;
            bbtnDel.Visible     =   ProgramContainer.getPapeisModel().Excluir   ? true : false;
            bbtnSearch.Visible  =   ProgramContainer.getPapeisModel().Recuperar ? true : false;
        }

        public bool PermissaoCreate(){
          return  ProgramContainer.getPapeisModel().Criar ? true : false;
         
        }

        public bool PermissaoRequest(){
            return ProgramContainer.getPapeisModel().Recuperar ?  true : false;

        }

        public bool PermissaoUpdate(){
            return ProgramContainer.getPapeisModel().Atualizar ? true : false;

        }

        public bool PermissaoDelete(){
            return ProgramContainer.getPapeisModel().Excluir ? true : false;

        }

        public bool PermissaoDuploClickEdit() {
            return ProgramContainer.getPapeisModel().Atualizar ? true : false;

        }

    }
}
