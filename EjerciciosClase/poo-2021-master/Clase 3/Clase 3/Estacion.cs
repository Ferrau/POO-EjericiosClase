using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_3
{
    public class Estacion
    {
        private Surtidor surtidor1 = new Surtidor();

        public Surtidor Surtidor1
        {
            get { return surtidor1; }
          
        }

        private Surtidor surtidor2 = new Surtidor();

        public Surtidor Surtidor2
        {
            get { return surtidor2; }
          
        }


        private Surtidor surtidor3 = new Surtidor();

        public Surtidor Surtidor3
        {
            get { return surtidor3; }
          
        }

        private Nafta nafta1 = new Nafta();
        public Nafta Nafta1
        {
            get { return nafta1; }
        
        }

        private Nafta nafta2 = new Nafta();
        public Nafta Nafta2
        {
            get {
                return nafta2;
                }
         
        }
        private Nafta nafta3 = new Nafta();
        public Nafta Nafta3
        {
            get { return nafta3; }
            
        }

        public Surtidor ObtenerSurtidorConMayorRec()
        {
            Surtidor surtidorTMP = surtidor1;

            if (surtidorTMP.ObtenerRecaudación() < surtidor2.ObtenerRecaudación())
            {
                surtidorTMP = surtidor2;
            }
            if (surtidorTMP.ObtenerRecaudación() < surtidor3.ObtenerRecaudación())
            {
                surtidorTMP = surtidor3;
            }

            return surtidorTMP;
        }

        public Surtidor ObtenerSurtidorConMenorRec()
        {
            Surtidor surtidorTMP = surtidor1;

            if (surtidorTMP.ObtenerRecaudación() > surtidor2.ObtenerRecaudación())
            {
                surtidorTMP = surtidor2;
            }
            if (surtidorTMP.ObtenerRecaudación() > surtidor3.ObtenerRecaudación())
            {
                surtidorTMP = surtidor3;
            }

            return surtidorTMP;
        }

        public Surtidor ObtenerSurtidorConMayorVentas()
        {
            Surtidor surtidorTMP = surtidor1;

            if (surtidorTMP.CantidadVentas < surtidor2.CantidadVentas)
            {
                surtidorTMP = surtidor2;
            }
            if (surtidorTMP.CantidadVentas < surtidor3.CantidadVentas)
            {
                surtidorTMP = surtidor3;
            }

            return surtidorTMP;
        }

    }
}