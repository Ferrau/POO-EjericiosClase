using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface ITocable
    {
        string tocar();
       
        string Nombre { get; set; }   

        event  delTocando Tocando;

    }
}