using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_3
{
    public class Surtidor
    {
        private int numero;
        private float recaudacion;
        private int capacidad;
        private float nivel;
        private Nafta nafta;
        private int cantidadVentas;
        private int cantidadRecargas;




        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }


        public float Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
       
        public Nafta Nafta
        {
            get { return nafta; }
            set
            {
                nafta = value;
            }
        }

        public int CantidadVentas
        {
            get { return cantidadVentas; }
         
        }

        public int CantidadRecargas
        {
            get { return cantidadRecargas; }
   
        }



        //COMPORTAMIENTO
        public bool Vender(float litros)
        {
            bool ok = (litros <= this.nivel);

            if(ok)
            {
                recaudacion += this.nafta.Vender(litros) ;
                cantidadVentas++;
                nivel -= litros;
            }

            return ok;
        }

        public void Recargar()
        {
            this.cantidadRecargas++;
            this.nivel = this.capacidad;
        }

        public float ObtenerRecaudación()
        {
            return recaudacion;
        }

    }
}