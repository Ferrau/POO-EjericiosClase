using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObjetosYClases
{
    public class Cliente
    {
        //Atributos
        string Vnombre = "";
        string Vapellido = "";

        //Propiedades de lecto-escritura
      

        public string Nombre
        {
            get { return Vnombre; }

            //protected: desde afuera no se puede
            //consumir pero cuando yo heredo, mi herencia
            //si va a recibir todas las propiedades y métodos.

            set { Vnombre = value; }
        }

        public string Apellido
        {
            get { return Vapellido; }
            set { Vapellido = value; }
        }
    }
}
