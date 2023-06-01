using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObjetosYClases
{
    public class AlmacenaArrayString
    {
        //Se declara un array para almacenar 10 string
        private string[] ArrayString = new string[10];

        //Se define el inicializador
        public string this[int i]
        {
            //obtiene el valor segun posicion
            get { return ArrayString[i]; }

            //setea el valor a la posicion 
            set { ArrayString[i] = value; }
        }




    }
}
