using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public class GUITARRA : Instrumento, IAfinable
    {
        string ITocable.Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        event delTocando ITocable.Tocando
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        void IAfinable.Afinar()
        {
            throw new NotImplementedException();
        }

        string ITocable.tocar()
        {
            throw new NotImplementedException();
        }
    }
}