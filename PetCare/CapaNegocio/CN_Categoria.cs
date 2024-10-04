using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objcd_categoria = new CD_Categoria();

        public List<Categoria> listar()
        {
            return objcd_categoria.listar();
        }

        public int registrar(Categoria cat, out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(cat.descripcion))
                mensaje = "Debe completar todos los campos.";

            if (mensaje != string.Empty)
                return 0;
            else
                return objcd_categoria.registrar(cat, out mensaje);

        }

        public bool editar(Categoria cat, out string mensaje)
        {
            mensaje = string.Empty;

            if (validar(cat.descripcion))
                mensaje = "Debe completar todos los campos.";

            if (mensaje != string.Empty)
                return false;
            else
                return objcd_categoria.editar(cat, out mensaje);

        }

        private bool validar(string p)
        {
            return string.IsNullOrEmpty(p.Trim());
        }
    }
}
