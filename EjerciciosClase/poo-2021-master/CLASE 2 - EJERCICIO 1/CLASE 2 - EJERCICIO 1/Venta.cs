using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASE_2___EJERCICIO_1
{
    public class Venta
    {
        private float subtotal;

        public float Subtotal
        {
            get { return subtotal; }
        }

        public void AgregarProducto(int Cantidad, Producto producto)
        {
            subtotal += (Cantidad * producto.precio);

        }

    }
}