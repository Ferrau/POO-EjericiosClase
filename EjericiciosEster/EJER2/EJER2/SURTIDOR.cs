using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJER2
{
    public class SURTIDOR
    {

        private float recaudacion;

        public float Recaudacion
        {
            get { return recaudacion; }
 
        }


        private string nombre = "Surtidor ";

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int cantidadrecargas;

        public int CantidadRecargas
        {
            get { return cantidadrecargas; }         
        }

        private int cantidadVentas;

        public int CantidadVentas
        {
            get { return cantidadVentas; }
            
        }

        private Nafta nafta;

        public Nafta Nafta
        {
            get { return nafta; }
            set { nafta = value; }
        }

        private float capacidad;

        public float Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }


        private float litrosRestantes;

        public float LitrosRestantes
        {
            get { return litrosRestantes; }
        
        }

        public bool Vender(float litros)
        {
            bool ok = (litrosRestantes >= litros);
            if (ok )
            { 
                nafta.Vender(litros);
                if (recaudacion == 0)
                {
                    recaudacion = nafta.Precio * litros;
                }
                else
                {
                    recaudacion += nafta.Precio * litros;
                }

                litrosRestantes -= litros;
                cantidadVentas++;
            }
            return ok;
        }

        public float ObtenerPrecio(float litros)
        {
            return nafta.Precio * litros;
        }

        public void Recargar()
        {
            litrosRestantes = capacidad;
            cantidadrecargas++;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}