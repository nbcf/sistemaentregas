using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engines
{

  public  class ConsultarCep
    {

        public string uf = "";
        public string cidade = "";
        public string bairro = "";
        public string logradouro = "";

        public string UfVO
        {
            get { return uf; }
        }

        public string CidadeVO
        {
            get { return cidade; }
        }

        public string BairroVO
        {
            get { return bairro; }
        }


        public string LogradouroVO
        {
            get { return logradouro; }
        }

        public void puxarCep(string txtcep){
           
            if (!string.IsNullOrWhiteSpace(txtcep))
            {
                using (var ws = new ServiceReference1.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtcep.Trim());

                        uf = endereco.uf;
                        cidade = endereco.cidade;
                        bairro = endereco.bairro;
                        logradouro = endereco.end;
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, txtcep, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
            }
            else
            {
                ///MessageBox.Show("Informe um CEP válido...", txtcep, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
