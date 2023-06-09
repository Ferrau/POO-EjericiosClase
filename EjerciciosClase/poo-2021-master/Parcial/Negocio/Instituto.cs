﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Instituto
    {
       private  List<Descubrimiento> descubrimientos = new List<Descubrimiento>();
        public List<Descubrimiento> Descubrimientos
        {
            get { return descubrimientos; }
        }

        private List<Arqueologo> arqueologos = new List<Arqueologo>();

        public List<Arqueologo> Arqueologos
        { get { return arqueologos; } }


        public Descubrimiento ObtenerMayorPresupuestoEx()
        {
            Descubrimiento descubrimiento = null;

            foreach (Descubrimiento tmp in descubrimientos)
            {
                if (descubrimiento == null)
                {
                    descubrimiento = tmp;
                }
                else if (descubrimiento.CalcularExcavacion() < tmp.CalcularExcavacion())
                {
                    descubrimiento = tmp;
                }
            }

            return descubrimiento;
        }

        public Descubrimiento ObtenerMayorPresupuestoMat()
        {
            Descubrimiento descubrimiento = null;

            foreach (Descubrimiento tmp in descubrimientos)
            {
                if (descubrimiento == null)
                {
                    descubrimiento = tmp;
                }
                else if (descubrimiento.CalcularMateriales() < tmp.CalcularMateriales())
                {
                    descubrimiento = tmp;
                }
            }

            return descubrimiento;
        }

        public Descubrimiento ObtenerMenorPresupuestoPer()
        {
            Descubrimiento descubrimiento = null;

            foreach (Descubrimiento tmp in descubrimientos)
            {
                if (descubrimiento == null)
                {
                    descubrimiento = tmp;
                }
                else if (descubrimiento.CalcularPermisos() > tmp.CalcularPermisos())
                {
                    descubrimiento = tmp;
                }
            }

            return descubrimiento;
        }


        public Descubrimiento ObtenerDescubirmientoMasAniguo()
        {
            Descubrimiento descubrimiento = null;

            foreach (Descubrimiento tmp in descubrimientos)
            {
                if (descubrimiento == null)
                {
                    descubrimiento = tmp;
                }
                else if (descubrimiento.Fecha > tmp.Fecha)
                {
                    descubrimiento = tmp;
                }
            }

            return descubrimiento;
        }

        public Arqueologo ObtenerArqueologoMasDescubrimientos()
        {
            Arqueologo arq = null;
            foreach (Arqueologo tmp in arqueologos)
            {
                if (arq == null)
                {
                    arq = tmp;
                }
                else if (arq.Descubrimientos.Count < tmp.Descubrimientos.Count)
                {
                    arq = tmp;
                }
            }
            return arq;
        }


    }
}