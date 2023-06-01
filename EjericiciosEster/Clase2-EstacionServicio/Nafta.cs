using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_EstacionServicio
{
    public class Nafta
    {
        //Definimos los atributos
        private string tipo;
        private float precio;
        private float litros;
        private int cantVentas;


        //GETTERS AND SETTERS:
        //son mecanismos de control de acceso que proporciona el ENCAPSULAMIENTO.
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }

        }
        public float Precio

        {
            get { return precio; }
            set { precio = value; }

        }
        public float Litros
        {
            get { return litros; }
            set { litros = value; }

        }

        public int Ventas
        {
            get { return cantVentas; }
            //set { ventas = value; } -- no quiero que puedan modificarlo
        }


        public float Vender(float litros)
        {
            
            this.cantVentas++; //sumo cantidad de ventas
            float subtotal = precio * litros; //sumo el costo de esa venta
            return subtotal;

        }

        private float recaudacion;

        public float Recaudacion
        {
            get { return recaudacion; }
            
        }

        public override string ToString()
        {
            return tipo;
        }




    }
}
