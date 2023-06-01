using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    class GuitarraElectrica:Guitarra //HERENCIA 
    {
        private int voltaje = 5;

        public int Voltaje
        {
            get { return voltaje; }
            set { voltaje = value; }
        }

        public override string Afinar()
        {
            return base.Afinar() +" pero con el aparatito" ;
        }

        public override string Tocar()
        {
            return "De música ligera";
        }

    }
}
