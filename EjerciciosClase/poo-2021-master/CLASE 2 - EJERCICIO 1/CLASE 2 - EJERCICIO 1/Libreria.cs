using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASE_2___EJERCICIO_1
{
    public class Libreria
    {
        public Venta ventaActual;

        public float total;

        public float RecuperarRecaudacion()
        {
            return total;
        }

        public bool IniciarVenta()
        {
            bool ok = true;
            if (ventaActual == null)
            {
                ventaActual = new Venta();
            }
            else
            {
                ok = false;
            }
            return ok;
        }


        public void FinalizarVenta()
        {
            if (ventaActual != null)
            {
                total += ventaActual.Subtotal;
                ventaActual = null;
            }
        }

    }
}