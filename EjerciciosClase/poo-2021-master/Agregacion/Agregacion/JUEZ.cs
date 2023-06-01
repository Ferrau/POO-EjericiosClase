using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agregacion
{
    public class JUEZ
    {

        public PAREJA Casar( PERSONA persona1 , PERSONA persona2)
        {

            PAREJA pareja = null;
            if(persona1 != persona2)
            {  
                pareja = new PAREJA();
                pareja.Persona1 = persona1;
                pareja.Persona2 = persona2;
            }
            return pareja;
        }


    }
}