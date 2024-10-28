using CapaDatos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Backup
    {
        private CD_Backup objcd_backup = new CD_Backup();
        public bool backup(string ruta, out string mensaje)
        {
            bool backupExitoso = false;
            mensaje = string.Empty;
            if (ruta.Trim() != string.Empty && Directory.Exists(Path.GetDirectoryName(ruta)))
            {
                backupExitoso = objcd_backup.Backup(ruta, out mensaje);
            }
            else
            {
                mensaje = "Debe seleccionar una ruta donde realizar el backup!";
            }
            return backupExitoso;
        }

        public bool restore(string ruta, out string mensaje)
        {
            bool restoreExitoso = false;
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(ruta))
            {
                mensaje = "Debe seleccionar un archivo .bak para restaurar la base de datos!";
                restoreExitoso = false;
            }
            else
            {
                if (!File.Exists(ruta) || Path.GetExtension(ruta).ToLower() != ".bak")
                {
                    mensaje = "El archivo seleccionado no es válido. Debe ser un archivo .bak.";
                    restoreExitoso = false;
                }
                else
                {
                    restoreExitoso = objcd_backup.Restore(ruta, out mensaje);
                }
            }
            return restoreExitoso;
        }

    }
}
