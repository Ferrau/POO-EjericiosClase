using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class TumbaAutoridad : Tumba
    {
        private Autoridad autoridad;
        public Autoridad Autoridad
        {
            get { return autoridad; }
            set
            {
                autoridad = value; 
            }
        }
    }
}