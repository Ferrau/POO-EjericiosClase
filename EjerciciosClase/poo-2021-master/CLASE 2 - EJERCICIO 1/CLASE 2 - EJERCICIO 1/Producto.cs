using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASE_2___EJERCICIO_1
{
    public class Producto
    {
        // DATOS MIEMBRO
        private string codigo;

        //OPERACION
        public string Codigo
        {
            get { return codigo;  }
            set { codigo = value;  }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }



        public string descripcion;

        public float precio;

    }
}