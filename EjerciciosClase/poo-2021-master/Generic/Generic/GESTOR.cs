using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public abstract class GESTOR<T>
    {
        public abstract List<T> Listar();

        public abstract int Insertar(T objeto);
        public abstract int Editar(T objeto);
        public abstract int Borrar(T objeto);

    }
}
