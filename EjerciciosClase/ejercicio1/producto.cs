using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio1
{
    public class producto
    {
        //Definimos los atributos:

        //Si no voy a hacer operaciones matematicas, ponerlo como String
        private string cb;

        public string Cb
        {
            //Operaciones de un objeto
            get { return cb; }
            set { cb = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private string descrip;

        public string Descrip
        {
            get { return descrip; }
            set { descrip = value; }
        }


    }
}