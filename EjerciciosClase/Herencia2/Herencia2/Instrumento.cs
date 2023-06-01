using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia2
{
    public abstract class Instrumento
    {
        private string nombr;

        public string Nombre
        {
            get { return nombr; }
            set { nombr = value; }
        }


        public abstract string Tocar();

        public override string ToString()
        {
            return nombr;
        }
    }
}