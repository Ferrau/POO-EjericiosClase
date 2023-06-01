using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_3
{
    public class Nafta
    {
        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private float recaudacion;

        public float Recaudacion
        {
            get { return recaudacion; }
      
        }

        private int ventas;

        public int Ventas
        {
            get { return ventas; }
         
        }

        public float  Vender(float litros)
        {
            this.ventas++;
            float subtotal = this.precio * litros;
            recaudacion += subtotal;

            return subtotal;
        }


    }
}