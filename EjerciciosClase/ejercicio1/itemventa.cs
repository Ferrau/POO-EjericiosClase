using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio1
{


    // Calcula el valor total de un item * precio (carrito)
    public class itemventa
    {

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private producto producto ;

        public producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        public string descripcion
        {
            get {
                return producto.Nombre + " $" + (cantidad * producto.Precio).ToString()
                  ;
            }

        }

       
        public float Calcular()
        {
            return cantidad * producto.Precio;
        }
    }
}