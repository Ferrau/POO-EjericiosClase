﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public abstract class Descubrimiento
    {
        private Ciudad ciudad;
        public Ciudad Ciudad
        {
            get {return ciudad; }
            set
            {
                ciudad = value;
            }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        protected float presupuesto;

        public float Presupuesto
        {
            get { return presupuesto; }
            set { presupuesto = value; }
        }

        public abstract float CalcularExcavacion();
        public abstract float CalcularMateriales();
        public abstract float CalcularPermisos();

    }
}