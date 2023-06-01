using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase3
{
    public class JUEZ
    {
        public PAREJA Casar(PERSONA p1, PERSONA p2)
        {
            PAREJA nuevaPareja = new PAREJA();

            nuevaPareja.Persona1 = p1;

            nuevaPareja.Persona2 = p2;

            p1.EstadoCivil = ESTADOCIVIL.C;
            p2.EstadoCivil = ESTADOCIVIL.C;
            return nuevaPareja;
        }


        public List<PERSONA> Divorciar(PAREJA pareja)
        {
            List<PERSONA> felices = new List<PERSONA>();

            pareja.Persona1.EstadoCivil = ESTADOCIVIL.D;
            pareja.Persona2.EstadoCivil = ESTADOCIVIL.D;

            felices.Add(pareja.Persona1);
            felices.Add(pareja.Persona2);
            return felices;
        }

    }
}