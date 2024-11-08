using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Claims;
using System.Xml.Linq;
using System.Diagnostics;
using System.IO;

namespace CapaDatos
{
    public class CD_Backup
    {
        public bool Backup(string ruta, out string mensaje)
        {
            bool backupExitoso = false;
            mensaje = string.Empty;

            using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    objConexion.Open();

                    string restoreQuery = @"BACKUP DATABASE [PETCARE] TO  DISK = @ruta
                    WITH NOFORMAT, NOINIT, NAME = N'PETCARE-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

                    using (SqlCommand command = new SqlCommand(restoreQuery, objConexion))
                    {
                        command.Parameters.AddWithValue("@ruta", ruta); // Parámetro para la ruta

                        command.ExecuteNonQuery();
                        mensaje = "Backup completado con éxito.";
                        backupExitoso = true;
                    }
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    backupExitoso = false;
                }
            }
            return backupExitoso;
        }

        public bool Restore(string ruta, out string mensaje)
        {
            bool restauracionExitoso = false;
            mensaje = string.Empty;

            using (SqlConnection objConexion = new SqlConnection(Conexion.ObtenerCadenaConexion()))
            {
                try
                {
                    objConexion.Open();

                    // El comando T-SQL para restaurar la base de datos
                    string restoreQuery = @"
                    USE [master];
                    ALTER DATABASE [PETCARE] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                    RESTORE DATABASE [PETCARE] FROM DISK = @ruta WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 5;
                    ALTER DATABASE [PETCARE] SET MULTI_USER;";

                    using (SqlCommand command = new SqlCommand(restoreQuery, objConexion))
                    {
                        command.Parameters.AddWithValue("@ruta", ruta); // Parámetro para la ruta

                        command.ExecuteNonQuery();
                        mensaje = "Restauración completada con éxito.";
                        restauracionExitoso = true;
                    }
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message; // Manejo de errores
                    restauracionExitoso = false;
                }
            }
            return restauracionExitoso;
        }

    }
}
