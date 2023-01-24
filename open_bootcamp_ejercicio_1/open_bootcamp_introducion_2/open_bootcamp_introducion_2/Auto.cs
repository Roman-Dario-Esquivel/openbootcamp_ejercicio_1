using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_bootcamp_introducion_2
{
    internal class Auto
    {
        private int Puertas;

        public Auto(int puertas)
        {
            Puertas = puertas;
        }

        public void setPuertas(int puertas)
        {
            this.Puertas=puertas;
        }
        public int getPuertas()
        {
            return this.Puertas;
        }

        public void aumentarPuertas()
        {
            this.Puertas=this.Puertas+1;
        }



    }
}
