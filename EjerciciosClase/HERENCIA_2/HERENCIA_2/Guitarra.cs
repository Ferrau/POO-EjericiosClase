using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA_2
{
    public class Guitarra : INSTRUMENTO
    {
        //ME OBLIGA A IMPLEMENTAR EL METODO ABSTRACTO
        public override string Tocar()
        {
            return "Mujer amante";
        }
    }
}
