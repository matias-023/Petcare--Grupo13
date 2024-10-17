using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objcd_Cliente = new CD_Cliente();

        public List<Cliente> listar()
        {
            return objcd_Cliente.listar();
        }

        public int registrar(Cliente user, out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(user.nombreCompleto) || validar(user.documento) || validar(user.correo) || validar(user.telefono)
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
                return objcd_Cliente.registrar(user, out mensaje);
            }



        }

        public bool editar(Cliente user, out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(user.nombreCompleto) || validar(user.documento) || validar(user.correo) || validar(user.telefono)
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
                return objcd_Cliente.editar(user, out mensaje);
            }

        }

        private bool validar(string p)
        {
            return string.IsNullOrEmpty(p.Trim());
        }
    }
}
