using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engines
{
    class Paginacao
    {


        public int deslocamento1;
        public int pg;
        public int memoria;
        public bool finalPaginaBol;
        public bool inicioPaginaBol;

        public int Deslocamento1VO
        {
            get { return deslocamento1; }
            set { deslocamento1 = value; }
        }
        public int PgVO
        {
            get { return pg; }
            set { pg = value; }
        }
        public int MemoriaVO
        {
            get { return memoria; }
            set { memoria = value; }
        }
        
         public bool FinalPaginaBolVO
        {
            get { return finalPaginaBol; }
            set { finalPaginaBol = value; }
        }

        public bool InicioPaginaBolVO
        {
            get { return inicioPaginaBol; }
            set { inicioPaginaBol = value; }
        }

        public void somar(
            bool finalPaginaBol,
            bool inicioPaginaBol,
            int paginar,
            int paginaAtual,
            int paginarPesquisa,
            int deslocado,
            int deslocamento1,
            int memoria,
            int pagina1,
            int pg, 
            Button bttnBeginPages,
            Button bttnOnePageRight,
            Button bttnEndPages){
            if (memoria < pagina1 && finalPaginaBol == false){
                deslocamento1 = paginaAtual + pg;
                paginarPesquisa = deslocamento1;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                memoria++;
                this.memoria = memoria;
                bttnBeginPages.Enabled = true;
                this.deslocamento1 = deslocamento1;
                this.pg = pg;
                if (memoria == pagina1){
                    bttnOnePageRight.Enabled = false;
                    bttnEndPages.Enabled = false;
                    finalPaginaBol = true;
                    inicioPaginaBol = false;
                    this.finalPaginaBol = finalPaginaBol;
                    this.inicioPaginaBol = inicioPaginaBol;
                }

            }else if (memoria < pagina1 && finalPaginaBol == true){
                deslocamento1 = paginaAtual + pg;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                memoria++;
                this.memoria = memoria;
                bttnBeginPages.Enabled = true;

                if (memoria == pagina1){
                    bttnOnePageRight.Enabled = false;
                    bttnEndPages.Enabled = false;
                    finalPaginaBol = true;
                    inicioPaginaBol = false;
                    this.finalPaginaBol = finalPaginaBol;
                    this.inicioPaginaBol = inicioPaginaBol;
                }
            }
        }
    }
}