using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public class Piano : Instrumento, ITocable
    {
        public string Nombre { get
            { return nombre; }
            set { nombre = value; }
        }

        public event delTocando Tocando;

        public string tocar()
        {
            return "Claro de luna";
        }
    }
}