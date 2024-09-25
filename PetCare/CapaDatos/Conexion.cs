using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static string ObtenerCadenaConexion()
        {
            // Obtener el nombre de la máquina
            string machineName = Environment.MachineName;

            // Crear el Data Source dinámicamente
            string dataSource = $@"{machineName}\SQLEXPRESS";

            // Obtener la cadena de conexión base desde app.config
            string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

            // Reemplazar el Data Source en la cadena de conexión
            cadena = cadena.Replace("{DataSource}", dataSource);

            return cadena;
        }

    }
}
