using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase3
{
    public class PERSONA
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private ESTADOCIVIL estadocivil;

        public ESTADOCIVIL EstadoCivil
        {
            get { return estadocivil; }
            set { estadocivil = value; }
        }


        public string NomApe
        {
            get { return nombre + " " + apellido + " (" + estadocivil.ToString() + ")" ; }

        }
    }
}