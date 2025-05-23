﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte objcd_reporte = new CD_Reporte();

        public List <reporteVenta> Venta (string fechainicio, string fechafin, Usuario user)
        {
            return objcd_reporte.Venta(fechainicio, fechafin, user);
        }

        public DataTable ObtenerReporte(string nombreProc, string fechainicio, string fechafin)
        {
            return objcd_reporte.productosMasVendidos(nombreProc, fechainicio, fechafin);
        }


    }
}
