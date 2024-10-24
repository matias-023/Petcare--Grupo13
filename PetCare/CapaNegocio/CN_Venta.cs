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

        public bool RestarStock(int idProducto, int cantidad, out string mensaje)
        {
            return objcd_venta.restarStock(idProducto, cantidad, out mensaje);
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

        public Venta obtenerVenta(string numero, int idUsuario)
        {
            Venta oVenta = objcd_venta.obtenerVenta(numero);

            if (oVenta.idVenta != 0)
            {
                if (idUsuario != 0)
                {
                    if (oVenta.oUsuario.idUsuario == idUsuario)
                    {
                        List<DetalleVenta> oDetalleVenta = objcd_venta.obtenerDetalleVenta(oVenta.idVenta);
                        oVenta.oDetalleVenta = oDetalleVenta;
                    }
                    else
                    {
                        oVenta = new Venta();
                    }
                }
                else
                {
                    List<DetalleVenta> oDetalleVenta = objcd_venta.obtenerDetalleVenta(oVenta.idVenta);
                    oVenta.oDetalleVenta = oDetalleVenta;
                }
            }
            return oVenta;
        }
        

    
    
    }
}
