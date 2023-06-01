using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    public class ImpresoraColor : IMPRESORA
    {
        void start()
        {
            cyan = new Cartucho();
            cyan.Color = "Cyan";
            cyan.Nivel = 25;

            magenta = new Cartucho(30);
            magenta.Color = "Magenta";

            amarillo = new Cartucho();
            amarillo.Color = "Amarillo";
        }

        public ImpresoraColor() : base()  
        {
            start();

        }

        public ImpresoraColor(int nivelNegro) : base(15)
        {
            start();
        }


        private Cartucho cyan;

        public Cartucho Cyan
        {
            get { return cyan; }
            set { cyan = value; }
        }

        private Cartucho magenta;

        public Cartucho Magenta
        {
            get { return magenta; }
            set { magenta = value; }
        }

        private Cartucho amarillo;

        public Cartucho Amarillo
        {
            get { return amarillo; }
            set { amarillo = value; }
        }


        public string ImprimirColor()
        {
            return base.Imprimir() + " y Color";

        }

    }
}