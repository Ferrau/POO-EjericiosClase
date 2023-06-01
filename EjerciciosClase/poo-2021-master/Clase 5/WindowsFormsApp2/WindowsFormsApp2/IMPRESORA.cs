using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    public class IMPRESORA
    {

        public IMPRESORA()
        {
            cartucho = new Cartucho();
            cartucho.Color = "Negro";

        }

        public IMPRESORA(int nivelCartucho):this()
        {
            cartucho.Nivel = nivelCartucho;
        }




        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private Cartucho cartucho;

        public Cartucho CARTUCHO
        {
            get { return cartucho; }
            set { cartucho = value; }
        }



        public string Imprimir()
        {
            string texto = "Imprimir en blanco y negro";
            cartucho.Descontar();
            return texto;
        }



    }
}