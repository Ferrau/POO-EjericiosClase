using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    class Guitarra:Instrumento
    {
        public override string Tocar()
        {
           return "Mujer amante";
        }

        public virtual string Afinar()
        {
            return "Afinando la guitarra";

        }

    }
}
