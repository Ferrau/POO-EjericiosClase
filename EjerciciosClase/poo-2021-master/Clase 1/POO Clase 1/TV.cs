using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Clase_1
{
    public class TV
    {

        private int Max = 99;
        private int min = 2;

        public string marca;

        public int canal =2;

        public bool encendido;


        public void Encender()
        {
            encendido = !encendido;
        }

        public bool SubirCanal()
        {
            bool ok = false;

            if (this.encendido )
            {
                ok = true;
                canal++;
                if (canal > Max)
                {
                    canal = 2;
                }
            }

            return ok;
        }

        public bool BajarCanal()
        {
            bool ok = false;
            if (this.encendido)
            {
                ok = true;
                canal--;
                if (canal < min)
                {
                    canal = 99;
                }

            }
            return ok;
        }

    }
}