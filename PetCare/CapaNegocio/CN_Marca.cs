using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Marca
    {
        private CD_Marca objcd_marca = new CD_Marca();

        public List<Marca> listar()
        {
            return objcd_marca.listar();
        }

        public int registrar(Marca marca, out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(marca.descripcion))
                mensaje = "Debe completar todos los campos.";

            if (mensaje != string.Empty)
                return 0;
            else
                return objcd_marca.registrar(marca, out mensaje);

        }

        public bool editar(Marca marca, out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(marca.descripcion))
                mensaje = "Debe completar todos los campos.";

            if (mensaje != string.Empty)
                return false;
            else
                return objcd_marca.editar(marca, out mensaje);

        }

        private bool validar(string p)
        {
            return string.IsNullOrEmpty(p.Trim());
        }
    }
}
