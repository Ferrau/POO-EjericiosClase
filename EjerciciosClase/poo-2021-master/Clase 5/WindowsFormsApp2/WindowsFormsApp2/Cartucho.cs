using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    public class Cartucho
    {

        public Cartucho()
        {
            nivel = 10;
        }

        public Cartucho (int c )
        {
            nivel = c;
        }


        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int nivel;

        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        public void Descontar()
        {
            this.nivel--;
        }

    }
}