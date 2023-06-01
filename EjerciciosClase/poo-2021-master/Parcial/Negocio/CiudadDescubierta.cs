using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class CiudadDescubierta : Descubrimiento
    {
        private Ciudad ciudadantigua = new Ciudad();
        public Ciudad CiudadAntigua
        {
            get { return ciudadantigua; }
            
        }

        private int desde;

        public int Desde
        {
            get { return desde; }
            set { desde = value; }
        }
        private int hasta;

        public int Hasta
        {
            get { return hasta; }
            set { hasta = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public override float CalcularExcavacion()
        {
            return (float) (this.presupuesto * 45)/100 ; 
        }
        public override float CalcularMateriales()
        {
            return (float)(this.presupuesto * 35) / 100;
        }
        public override float CalcularPermisos()
        {
            return (float)(this.presupuesto * 20) / 100;
        }
    }
}