using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objcd_venta = new CD_Venta();

        public bool RestarStock(int idProducto, int cantidad)
        {
            return objcd_venta.restarStock(idProducto, cantidad);
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            return objcd_venta.sumarStock(idProducto, cantidad);
        }


        public int ObtenerCorrelativo()
        {
            return objcd_venta.obtenerCorrelativo();
        }

        public bool registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objcd_venta.registrar(obj, DetalleVenta, out Mensaje);
        }
        

    
    
    }
}
