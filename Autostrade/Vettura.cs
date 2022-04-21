using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autostrade
{

    


    internal class Vettura
    {
        public String marca;
        public String modello;
        public String targa;
        public String pathLibretto;
        public DateTime annoImm;
        public Double consBenz;
        public DateTime scadBolli;
        //tagliandi
        public DateTime cambioPne;
        public String pathRCA;

        public Vettura(string marca, string modello, string targa, string pathLibretto, DateTime annoImm, double consBenz, DateTime scadBolli, DateTime cambioPne, string pathRCA)
        {
            this.marca = marca;
            this.modello = modello;
            this.targa = targa;
            this.pathLibretto = pathLibretto;
            this.annoImm = annoImm;
            this.consBenz = consBenz;
            this.scadBolli = scadBolli;
            this.cambioPne = cambioPne;
            this.pathRCA = pathRCA;
        }
        //eventuali sinistri


    }
}
