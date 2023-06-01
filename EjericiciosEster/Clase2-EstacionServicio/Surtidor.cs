using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_EstacionServicio
{
    public class Surtidor
    {
		private string codSurtidor;
        private float medidor;
        private Nafta nafta;
        private float capacidad;
        private int cantRecargas;
        private float totalRecaudacion;
		private int cantClientes;
        private float litrosRestantes;
        private String nombre = "Surtidor";



        public string CodSurtidor
        {
			get { return codSurtidor; }
			set { codSurtidor = value; }
		}

		

		public float Medidir
		{
			get { return medidor; }
			set { medidor = value; }
		}

		

		public Nafta Nafta 
		{
			get { return nafta; }
			set { nafta = value; }
		}
		

		public float Capacidad
		{
			get { return capacidad; }
			set { capacidad = value; }
		}

		

		public int CantRecargas
        {
			get { return cantRecargas; }
			//set { cantRecaras = value; }
		}

		

		public float TotalRecaudacion
		{
			get { return totalRecaudacion; }
			//set { totalRecaudacion = value; }
		}

        public int CantClientes
        {
            get { return cantClientes; }
            //set { cantClientes = value; }
        }


        public float LitrosRestantes
        {
            get { return litrosRestantes; }
            set { litrosRestantes = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /* ****************** METODOS **********************/
        public float VentaNafta(float litros)
        {
            return nafta.Precio * litros;
        }
 
        //2)	Obtener la recaudación total de un surtidor.
        public bool Vender(float litros)
        {
            bool ok = (litrosRestantes >= litros);
            if (ok)
            {
                totalRecaudacion += nafta.Vender(litros);
                litrosRestantes -= litros;
                cantClientes++; 
            }
            return ok;
        }

        //8) Recargar el surtidor cuando éste haya quedado vacío.
        public void Recarcar()
		{
			
                litrosRestantes = capacidad; // va a recargar lo que queda del tanque al tope de la capacidad
                cantRecargas++;

            
		}

        public override string ToString()
        {
            return nombre;
        }











    }
}
