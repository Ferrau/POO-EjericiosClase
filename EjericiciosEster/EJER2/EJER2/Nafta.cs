using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJER2
{
    public class Nafta
    {
        private string nombre = "Sin Nombre";

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        private int cantidadVentas;

        public int CantidadVentas
        {
            get { return cantidadVentas; }            
        }

        private float recaudacion;

        public float Recaudacion
        {
            get { return recaudacion; }            
        }

        public void Vender(float litros)
        {
            cantidadVentas++;
            recaudacion += litros * precio;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}