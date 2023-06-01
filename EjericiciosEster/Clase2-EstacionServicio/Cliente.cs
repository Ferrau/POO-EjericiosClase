using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_EstacionServicio
{
    public class Cliente
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
            }   

        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
            }
        }

        private string dni;

        public string Dni
        {
            get { return dni; }
            set
            {
                dni = value;
            }
        }
        
    }
}
