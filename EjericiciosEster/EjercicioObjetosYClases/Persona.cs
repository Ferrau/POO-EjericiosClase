using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioObjetosYClases
{
    public class Persona
    {
        DateTime VfechaDeNacimiento;

		public DateTime FechaDeNacimiento
        {
			
			set { this.FechaDeNacimiento = value; }
		}

		public byte Edad
		{
			get 
			{
				byte anio = (byte)this.VfechaDeNacimiento.Year;
                if (this.VfechaDeNacimiento.DayOfYear <= DateTime.Now.DayOfYear)
                {
					//Le resta 1 porque falta para que cumpla años y mas abajo se lo esta restando.
					anio -= 1;
                }
                return (byte)(DateTime.Now.Year - anio);

            }
        }


	}
}
