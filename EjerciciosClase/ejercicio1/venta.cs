using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio1
{

    public class venta
    {
        /*Aca se realiza la factura de la venta con una lista de ITEMS 
         y el subtotal de la venta hasta que paga y se va */

        private List<itemventa> items = new List<itemventa>();
        private float subtotal;


        public List<itemventa> Items
        {
            get { return items; }

        }

        public float Subtotal
        {
            get { return subtotal; } //solo lectura
        
        }

        /* EJERCICIO 2)	Mostrar el subtotal de la venta.*/
        public void CalcularSubtotal() //VERBOS INFINITIVOS
        {
            subtotal = 0;
            for (int i = 0; i < items.Count; i++)
            {
                subtotal += items[i].Calcular(); //para ver la definicon del metodo: click derecho > ver definicion sin salir.
            }
        }


    }
}