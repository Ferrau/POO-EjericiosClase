using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJER2
{
    public class ESTACION_SERVICIO
    {
        public ESTACION_SERVICIO()
        {
            surtidor1.Nombre += "1";
            surtidor2.Nombre += "2";
            surtidor3.Nombre += "3";
            surtidor1.Capacidad = 100;
            surtidor2.Capacidad = 100;
            surtidor3.Capacidad = 100;
        }

        private SURTIDOR surtidor1 = new SURTIDOR();

        public SURTIDOR Surtidor1
        {
            get { return surtidor1; }
        }


        private SURTIDOR surtidor2 = new SURTIDOR();

        public SURTIDOR Surtidor2
        {
            get { return surtidor2; }
        }


        private SURTIDOR surtidor3 = new SURTIDOR();

        public SURTIDOR Surtidor3
        {
            get { return surtidor3; }
        }

        private Nafta super = new Nafta();

        public Nafta Super
        {
            get { return super; }
        }


        private Nafta normal = new Nafta();

        public Nafta Normal
        {
            get { return normal; }
        }

        private Nafta premium = new Nafta();

        public Nafta Premium
        {
            get { return premium; }
        }

        public SURTIDOR MostrarSurtiMasRecargas()
        {
            SURTIDOR temp = (surtidor1.CantidadRecargas > surtidor2.CantidadRecargas) ? surtidor1 : surtidor2;
            temp = (surtidor3.CantidadRecargas > temp.CantidadRecargas) ? surtidor3 : temp;

            return temp;
        }

        public SURTIDOR MostrarSurtiMasVentas()
        {
            SURTIDOR temp = (surtidor1.CantidadVentas> surtidor2.CantidadVentas) ? surtidor1 : surtidor2;
            temp = (surtidor3.CantidadVentas > temp.CantidadVentas) ? surtidor3 : temp;

            return temp;
        }

        public SURTIDOR MostrarSurtiMasRecaudacion()
        {
            SURTIDOR temp = (surtidor1.Recaudacion > surtidor2.Recaudacion) ? surtidor1 : surtidor2;
            temp = (surtidor3.Recaudacion > temp.Recaudacion) ? surtidor3 : temp;

            return temp;
        }

        public SURTIDOR MostrarSurtiMenorRecaudacion()
        {
            SURTIDOR temp = (surtidor1.Recaudacion <surtidor2.Recaudacion) ? surtidor1 : surtidor2;
            temp = (surtidor3.Recaudacion > temp.Recaudacion) ? surtidor3 : temp;

            return temp;
        }

        public float ObtenerRecaudacion()
        {
            float total = surtidor1.Recaudacion + surtidor2.Recaudacion + surtidor3.Recaudacion;
            return total;
        }
    }
}