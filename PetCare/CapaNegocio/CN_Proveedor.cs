using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();

        public List<Proveedor> listar()
        {
            return objcd_Proveedor.listar();
        }

        public int registrar(Proveedor user, out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(user.razonSocial) || validar(user.documento) || validar(user.correo) || validar(user.telefono)
                )
            {
                mensaje = "Debe completar todos los campos.";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Proveedor.registrar(user, out mensaje);
            }



        }

        public bool editar(Proveedor user, out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(user.razonSocial) || validar(user.documento) || validar(user.correo) || validar(user.telefono)
                )
            {
                mensaje = "Debe completar todos los campos.";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Proveedor.editar(user, out mensaje);
            }

        }

        private bool validar(string p)
        {
            return string.IsNullOrEmpty(p.Trim());
        }
    }
}
