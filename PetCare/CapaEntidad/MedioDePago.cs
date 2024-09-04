using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class MedioDePago
    {
        public int id_medioDePago { get; set; }
        public string descripcion { get; set; }
        public decimal incremento { get; set; }
        public string fechaRegistro { get; set; }
    }
}
