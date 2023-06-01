using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    sealed class Piano:Instrumento
    {
        public Piano()
        {
            this.Nombre = "Piano";
        }
        public override string Tocar()
        {
            return "Claro de luna";
        }

        public override string ToString()
        {
            return Nombre;
        }


    }
}
