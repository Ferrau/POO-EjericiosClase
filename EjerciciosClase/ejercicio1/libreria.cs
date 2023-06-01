using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio1
{
    public class libreria

    {
        private List<venta> ventas = new List<venta>();
        private List<producto> productos = new List<producto>();
        private float recaudacion;

        public List<venta> Ventas
        {
            //Operacion: Solo lectura
            get { return ventas; }

        }

        public List<producto> Productos
        {
            //Operacion: Solo lectura
            get { return productos;}
      
        }

        public float Recaudacion
        {
            //Operacion: Solo lectura
            get { return recaudacion; }
        
        }
        public void CalcularTotalRecaudado()
        {
            recaudacion = 0;
            for (int i = 0; i < ventas.Count; i++)
            {
                ventas[i].CalcularSubtotal();
                recaudacion += ventas[i].Subtotal;

            }
        }
    }
}