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

        public Boolean PermissaoCreate(){
          return  ProgramContainer.getPapeisModel().Criar ? true : false;
         
        }

        public Boolean PermissaoRequest(){
            return ProgramContainer.getPapeisModel().Recuperar ? true : false;

        }

        public Boolean PermissaoUpdate(){
            return ProgramContainer.getPapeisModel().Atualizar ? true : false;

        }

        public Boolean PermissaoDelete(){
            return ProgramContainer.getPapeisModel().Excluir ? true : false;

        }

        public Boolean PermissaoDuploClickEdit() {
            return ProgramContainer.getPapeisModel().Atualizar ? true : false;

        }

    }
}
