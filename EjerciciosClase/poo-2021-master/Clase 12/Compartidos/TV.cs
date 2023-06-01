using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartidos
{
    class TV
    {

        static TV()
        {
            canal = 9;
        }

        public TV()
        {
            marca = "LG";
        }

        public TV(string m)
        {
            marca = m;
        }

        private static int canal;


        public static int Canal
        {
            get { return canal; }
            set { canal = value;
                 }
        }


        public static void CambiarCanal(int numero)
        {
            canal = numero;
        }


        public int CanalActual
        {
            get { return canal; }
            set { canal = value; }
        }

        private string marca;

        public string  Marca
        {
            get { return marca; }
            set { marca = value; }
        }

    }
}
