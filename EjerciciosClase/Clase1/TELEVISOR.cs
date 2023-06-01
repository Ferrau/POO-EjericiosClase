using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase1
{
    public class TELEVISOR
    {
        public bool estado; // verdadero = prendido false = apagado

        public int canalactual;

        public string marca;

        private int maximo = 20;

        public void Encender()
        {
            estado = !estado;

        }

        public bool SubirCanal()
        {
            bool respuesta = false;

            if (estado)
            {
                canalactual = (canalactual +1 == maximo)? 1: canalactual+1 ;

                respuesta = true;
            }

            return respuesta;
        }

    }
}