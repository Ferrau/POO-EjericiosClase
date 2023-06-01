using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Musica
{
    public abstract class Instrumento
    {
        protected string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public abstract string Tocar();

    }
}