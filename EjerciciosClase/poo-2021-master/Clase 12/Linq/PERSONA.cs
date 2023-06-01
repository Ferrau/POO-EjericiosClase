using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class PERSONA:IComparable, ICloneable,IDisposable
    {
        public static Random rnd = new Random();

        public static int instancia;

        public PERSONA()
        {
            nombre = "Persona " + instancia.ToString();
            instancia++;

            edad = rnd.Next(20, 50);
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }



        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public override string ToString()
        {
            return nombre + ": " + edad.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj is null)
            {
                return 1;
            }
            else
            {
                PERSONA p = (PERSONA)obj;

                return this.edad.CompareTo(p.edad);
            
            }          
        }

        public object Clone()
        {
             return this.MemberwiseClone() ;
        }



        private bool disposing = false;

        private void Dispose(bool d)
        {
            if (!d)
            {
                GC.SuppressFinalize(this);


                disposing = true;
            }
        
        
        }


        
        public void Dispose()
        {
            Dispose(disposing);
        }
    }
}
