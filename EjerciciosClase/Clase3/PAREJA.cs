using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase3
{
    public class PAREJA
    {
        private PERSONA persona1;

        public PERSONA Persona1
        {
            get { return persona1; }
            set { persona1 = value; }
        }

        private PERSONA persona2;

        public PERSONA Persona2
        {
            get { return persona2; }
            set { persona2 = value; }
        }

        public override string ToString()
        {
            return persona1.NomApe + " y " + persona2.NomApe;
        }
    }
}