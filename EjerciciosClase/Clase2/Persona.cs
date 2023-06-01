using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase2
{
    public class Persona
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
         
        private DateTime fn = DateTime.Now;

        public DateTime FechaNacimiento
        {
            get { return fn; }
       
        }

        public string NombreCompleto
        {
            get
            {

                return nombre + " " + fn.ToString();
            }

        }

    }
}