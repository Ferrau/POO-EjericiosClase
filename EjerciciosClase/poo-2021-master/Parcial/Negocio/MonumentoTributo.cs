﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class MonumentoTributoDios : Monumento
    {
        private List<Dios> dioses = new List<Dios>();

        public List<Dios> Dioses
        {
            get { return dioses; }

        }

    }
}