using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public class Rallador : ITocable
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public event delTocando Tocando;

        public string tocar()
        {
           return "LA VENTANITA";
        }
    }
}