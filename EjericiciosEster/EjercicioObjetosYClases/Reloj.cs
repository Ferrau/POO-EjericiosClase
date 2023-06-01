using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioObjetosYClases
{
    public class Reloj
    {
        int Vhoras = 0;

		public  int Horas 
		{
			get { return this.Vhoras; }
			set { 
					if (value < 0 || value >24)
					{
					MessageBox.Show("La hora debe ser mayor a 0 y menor a 24 ");
					}
					else
					{
						this.Vhoras = value;
					}
			
			    }
		}

	}
}
