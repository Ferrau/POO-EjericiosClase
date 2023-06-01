using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class ImpresoraColor : Impresora
    {

        public ImpresoraColor():base("Sin Marca")
        {

            this.cartuchoAmarillo = new Cartucho();
            this.cartuchoAmarillo.Color = "Amarillo";
            this.cartuchoAzul = new Cartucho();
            this.cartuchoAzul.Color = "Azul";
            this.cartuchoMagenta = new Cartucho();
            this.cartuchoMagenta.Color = "Magenta";


        }

        private Cartucho cartuchoAmarillo;
        private Cartucho cartuchoAzul;
        private Cartucho cartuchoMagenta;


        public Cartucho CartuchoAmarillo
        {
            get { return cartuchoAmarillo; }
        
        }
    

        public Cartucho CartuchoAzul
        {
            get { return cartuchoAzul; }

        }
    

        public Cartucho CartuchoMagenta
        {
            get { return cartuchoMagenta; }
        
        }

        public override string Imprimir()
        {
            this.cartuchoAmarillo.Nivel -= 2;
            this.cartuchoAzul.Nivel -= 3;
            this.cartuchoMagenta.Nivel -= 4;
            return base.Imprimir();
        }
    }
}