using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engines
{


  public class PerfilMenu
    {

        public void PermissoesMenus(
            ToolStripMenuItem CadastroMenuItem,
            ToolStripMenuItem EntregasMenuItem,
            ToolStripMenuItem FinanceiroMenuItem){

            if (
             true == ProgramContainer.getPapeisModel().Menuadmin &&
             false == ProgramContainer.getPapeisModel().Menuope &&
             false == ProgramContainer.getPapeisModel().Menugen)
            {
                CadastroMenuItem.Enabled = true;
                EntregasMenuItem.Enabled = false;
                FinanceiroMenuItem.Enabled = false;

            }


            else if (
              false == ProgramContainer.getPapeisModel().Menuadmin &&
              true == ProgramContainer.getPapeisModel().Menuope &&
              false == ProgramContainer.getPapeisModel().Menugen)
            {
                CadastroMenuItem.Enabled = false;
                EntregasMenuItem.Enabled = true;
                FinanceiroMenuItem.Enabled = false;

            }
            else if (
              false == ProgramContainer.getPapeisModel().Menuadmin &&
              false == ProgramContainer.getPapeisModel().Menuope &&
              true == ProgramContainer.getPapeisModel().Menugen)
            {
                CadastroMenuItem.Enabled = false;
                EntregasMenuItem.Enabled = false;
                FinanceiroMenuItem.Enabled = true;


            }
            else if (
              false == ProgramContainer.getPapeisModel().Menuadmin &&
              false == ProgramContainer.getPapeisModel().Menuope &&
              false == ProgramContainer.getPapeisModel().Menugen)
            {
                CadastroMenuItem.Enabled = false;
                EntregasMenuItem.Enabled = false;
                FinanceiroMenuItem.Enabled = false;


            }
            else if (
            true == ProgramContainer.getPapeisModel().Menuadmin &&
            false == ProgramContainer.getPapeisModel().Menuope &&
            false == ProgramContainer.getPapeisModel().Menugen)
            {
                CadastroMenuItem.Enabled = true;
                EntregasMenuItem.Enabled = false;
                FinanceiroMenuItem.Enabled = false;


            }

            else if (
            true == ProgramContainer.getPapeisModel().Menuadmin &&
            true == ProgramContainer.getPapeisModel().Menuope &&
            false == ProgramContainer.getPapeisModel().Menugen)
            {
                CadastroMenuItem.Enabled = true;
                EntregasMenuItem.Enabled = true;
                FinanceiroMenuItem.Enabled = false;


            }



            else if (
            true == ProgramContainer.getPapeisModel().Menuadmin &&
            true == ProgramContainer.getPapeisModel().Menuope &&
            true == ProgramContainer.getPapeisModel().Menugen)
            {
                CadastroMenuItem.Enabled = true;
                EntregasMenuItem.Enabled = true;
                FinanceiroMenuItem.Enabled = true;


            }

        }



    }
}
