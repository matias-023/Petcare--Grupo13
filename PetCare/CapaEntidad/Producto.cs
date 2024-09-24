using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public Categoria oCategoria { get; set; }
        public Marca oMarca { get; set; }
        public int stock_min { get; set; }
        public int stock { get; set; }
        public decimal precio { get; set; }
        public decimal precio_venta { get; set; }
        public bool estado { get; set; }
        public string fechaRegistro { get; set; }


    }
}
