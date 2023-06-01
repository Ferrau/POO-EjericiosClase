using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Impresora
    {

        public Impresora()
        {
            this.cartuchoNegro = new Cartucho();
            this.cartuchoNegro.Color = "Negro";
        }

        public Impresora(string m):this()
        {
            this.marca = m;
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        protected Cartucho cartuchoNegro  ;

        public Cartucho CartuchoNegro
        {
            get { return cartuchoNegro; }
           
        }

        public virtual string Imprimir()
        {
            this.CartuchoNegro.Nivel -= 1;
            return "Prueba";
        }

    }
}