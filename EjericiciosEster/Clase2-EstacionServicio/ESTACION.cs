using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2_EstacionServicio
{
    public class ESTACION
    {
        private Surtidor surtidor1 = new Surtidor();
        private Surtidor surtidor2 = new Surtidor();
        private Surtidor surtidor3 = new Surtidor();
        private float recaudacion;
        private Nafta super = new Nafta();
        private Nafta normal = new Nafta();
        private Nafta premium = new Nafta();


        //CONSTRUCTOR
        public ESTACION(){
            surtidor1.Nombre = surtidor1 + "1";
            surtidor2.Nombre = surtidor2 + "2";
            surtidor3.Nombre = surtidor3 + "3";

            normal.Tipo = "Normal";
            super.Tipo = "Súper";
            premium.Tipo = "Premium";

            surtidor1.Capacidad = 100;
            surtidor2.Capacidad = 100;
            surtidor3.Capacidad = 100;

        }

        public Surtidor Surtidor1
        {
            get { return surtidor1; }
            set { surtidor1 = value; }
        }

        public Surtidor Surtidor2
        {
            get { return surtidor2; }
            set { surtidor2 = value; }
        }

        public Surtidor Surtidor3
        {
            get { return surtidor3; }
            set { surtidor3 = value; }
        }

        public float Recaudacion
        {
            get { return recaudacion; }
           
        }

        public Nafta Super
        {
            get { return super; }
        }


        public Nafta Normal
        {
            get { return normal; }
           
        }



        public Nafta Premium
        {
            get { return premium; }
            
        }



        //1)	Obtener la recaudación total de la estación de servicio.
        public float ObtenerRecaudacion()
        {
            
            return recaudacion += surtidor1.TotalRecaudacion + surtidor2.TotalRecaudacion + surtidor3.TotalRecaudacion;
        }

        //3)	Obtener el surtidor que más recaudó
        public Surtidor SurtidorMasRecaudacion()
        {
           Surtidor surtidorTemporal = (surtidor1.TotalRecaudacion > surtidor2.TotalRecaudacion) ? surtidor1 : surtidor2;
           surtidorTemporal = (surtidor3.TotalRecaudacion > surtidorTemporal.TotalRecaudacion) ? surtidor3 : surtidorTemporal;
        
            return surtidorTemporal;
        }
        

        //4)	Obtener el surtidor que menos recaudó
        public Surtidor SurtidorMenosRecaudacion()
        {
            Surtidor surtidorTemporal = (surtidor1.TotalRecaudacion < surtidor2.TotalRecaudacion) ? surtidor1 : surtidor2;
            surtidorTemporal = (surtidor3.TotalRecaudacion > surtidorTemporal.TotalRecaudacion) ? surtidor3 : surtidorTemporal;
            return surtidorTemporal;
        }

        //5)	Obtener el surtidor que más clientes tuvo. 
        public Surtidor MayorCantClientes()
        {
            Surtidor surtidorTemporal = (surtidor1.CantClientes > surtidor2.CantClientes) ? surtidor1 : surtidor2;
            surtidorTemporal = (surtidor3.CantClientes > surtidorTemporal.CantClientes) ? surtidor3 : surtidorTemporal;
            return surtidorTemporal;
        }

        //9)	Mostrar el surtidor con mayor cantidad recargas.
        public Surtidor MayorCantRecargas()
        {
            Surtidor surtidorTemporal = (surtidor1.CantRecargas < surtidor2.CantRecargas) ? surtidor1 : surtidor2;
            surtidorTemporal = (surtidor3.CantRecargas > surtidorTemporal.CantRecargas) ? surtidor3: surtidorTemporal;    
            return surtidorTemporal;
        }

        
        

    }
}
