using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autostrade
{

    


    internal class Vettura
    {
        public String macchina;

        public Vettura()
        {
            macchina ="";
        }

        public Vettura(string macchina)
        {
            this.macchina = macchina;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
