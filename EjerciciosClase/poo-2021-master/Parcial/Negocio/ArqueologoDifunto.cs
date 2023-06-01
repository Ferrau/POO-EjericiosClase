using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class ArqueologoDifunto : Arqueologo
    {
        private DateTime fechaMuerte;

        public DateTime FechaMuerte
        {
            get { return fechaMuerte; }
            set { fechaMuerte = value; }
        }

    }
}