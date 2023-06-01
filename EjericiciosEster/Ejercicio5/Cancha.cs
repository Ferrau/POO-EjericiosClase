using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Cancha
    {
		private int valorBase;

		public int ValorBase
        {
			get { return valorBase; }
			set { valorBase = value; }
		}

		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private float hora;

		public float Hora
		{
			get { return hora; }
			set { hora = value; }
		}


	}
}
