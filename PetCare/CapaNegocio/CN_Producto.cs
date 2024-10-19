using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objcd_Producto = new CD_Producto();

        public List<Producto> listar()
        {
            return objcd_Producto.listar();
        }

        public int registrar(Producto prod, out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(prod.codigo) || validar(prod.nombre))
            {
                mensaje = "Debe completar todos los campos.";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Producto.registrar(prod, out mensaje);
            }



        }

        public bool editar(Producto prod, out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(prod.codigo) || validar(prod.nombre))
            {
                mensaje = "Debe completar todos los campos.";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Producto.editar(prod, out mensaje);
            }

        }

        private bool validar(string p)
        {
            return string.IsNullOrEmpty(p.Trim());
        }

    }
}
