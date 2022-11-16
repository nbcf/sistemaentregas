using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engines
{
   public class PerfilMenuItemAdmin
    {

        public void PermissoesMenuMenuItemConfSis(ToolStripMenuItem menuItem) {

            if (
           true == ProgramContainer.getPapeisModel().Menuadmin &&
           false == ProgramContainer.getPapeisModel().Menuope &&
           false == ProgramContainer.getPapeisModel().Menugen){

                menuItem.Enabled = true;

            }else if (
              false == ProgramContainer.getPapeisModel().Menuadmin &&
              true == ProgramContainer.getPapeisModel().Menuope &&
              false == ProgramContainer.getPapeisModel().Menugen){
                menuItem.Enabled = false;
         
            }else if (
              false == ProgramContainer.getPapeisModel().Menuadmin &&
              false == ProgramContainer.getPapeisModel().Menuope &&
              true == ProgramContainer.getPapeisModel().Menugen){
                menuItem.Enabled = false;
                

            }else if (
              false == ProgramContainer.getPapeisModel().Menuadmin &&
              false == ProgramContainer.getPapeisModel().Menuope &&
              false == ProgramContainer.getPapeisModel().Menugen){
                menuItem.Enabled = false;
    

            }else if (
            true == ProgramContainer.getPapeisModel().Menuadmin &&
            true == ProgramContainer.getPapeisModel().Menuope &&
            false == ProgramContainer.getPapeisModel().Menugen){
                menuItem.Enabled = true;

            }else if (
           false == ProgramContainer.getPapeisModel().Menuadmin &&
           true == ProgramContainer.getPapeisModel().Menuope &&
           true == ProgramContainer.getPapeisModel().Menugen){
                menuItem.Enabled = false;
                
            }else if (
            true == ProgramContainer.getPapeisModel().Menuadmin &&
            true == ProgramContainer.getPapeisModel().Menuope &&
            true == ProgramContainer.getPapeisModel().Menugen)
            {
                menuItem.Enabled = true;

            }

        }


    }
}
