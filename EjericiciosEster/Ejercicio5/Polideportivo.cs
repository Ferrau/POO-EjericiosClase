using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ejercicio5
{
	public class Polideportivo
	{
		private List <Cancha> cancha;

		public List<Cancha> Cancha
		{
			get { return cancha; }
			set { cancha = value; }
		}

		 private List<Alquiler> alquiler;

		public List<Alquiler> Alquiler
        {
			get { return alquiler; }
			set { alquiler = value; }
		}

		private List<Empleado> empleado;

		public List<Empleado> Empleado
		{
			get { return empleado; }
			set { empleado = value; }
		}



	}
}