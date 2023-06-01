using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Pais
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private List<Ciudad> ciudades = new List<Ciudad>();

        public List<Ciudad> Ciudades
        {
            get { return ciudades ; }
        
        }

    }
}