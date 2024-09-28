using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Net;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> listar()
        {
            return objcd_usuario.listar();
        }

        public int registrar(Usuario user,out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(user.nombreCompleto) || validar(user.documento) || validar(user.correo) || validar(user.telefono)
                || validar(user.clave))
            {
                mensaje = "Debe completar todos los campos.";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuario.registrar(user, out mensaje);
            }


            
        }

        public bool editar(Usuario user, out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(user.nombreCompleto) || validar(user.documento) || validar(user.correo) || validar(user.telefono)
                || validar(user.clave))
            {
                mensaje = "Debe completar todos los campos.";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.editar(user, out mensaje);
            }
            
        }

        private bool validar(string p)
        {
            return string.IsNullOrEmpty(p.Trim());
        }


    }
}
