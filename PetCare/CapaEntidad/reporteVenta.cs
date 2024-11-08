using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class reporteVenta
    {
        public int idVenta { get; set; }
        public string fechaRegistro { get; set; }
        public string horaRegistro { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string documentoUsuario { get; set; }
        public string usuarioRegistro { get; set; }
        public string documentoCliente { get; set; }
        public string nombreCliente { get; set; }
        public string montoTotal { get; set; }
    }
}
