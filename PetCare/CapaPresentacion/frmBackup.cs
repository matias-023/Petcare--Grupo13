using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CapaPresentacion
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string conString = @"server=localhost\SQLEXPRESS;Integrated Security=True;database=master;";

            using (SqlConnection conexion = new SqlConnection(conString))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        cboBaseDatos.Items.Add(fila[0].ToString());
                    }

                    cboBaseDatos.SelectedIndex = 0;
                }
            }
        }

        private void btnRutaGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "SQL Backup files|*.bak";
            saveFileDialog1.FileName = cboBaseDatos.Text + "-" + DateTime.Today.ToString("dd-MM-yyyy") + "-" + DateTime.Now.ToString("h.mm") + ".bak";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaGuardar.Text = saveFileDialog1.FileName;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el nombre de la máquina (hostname)
                string machineName = Environment.MachineName;

                // Definir un directorio de backup seguro
                string backupDirectory = @"D:\Backup";
                if (!Directory.Exists(backupDirectory))
                {
                    Directory.CreateDirectory(backupDirectory);
                }

                // Construir la ruta donde se guardará el archivo de backup
                string backupFilePath = Path.Combine(backupDirectory, cboBaseDatos.Text + "-" + DateTime.Now.ToString("yyyyMMdd-HHmm") + ".bak");

                // Construir el comando de backup, usando el nombre de la máquina
                string backupCommand = $"sqlcmd -S {machineName}\\SQLEXPRESS -E -Q \"BACKUP DATABASE [{cboBaseDatos.Text}] TO DISK='{backupFilePath}'\"";

                // Ejecutar el proceso para realizar el backup y cerrar la consola automáticamente
                Process.Start("cmd", "/c " + backupCommand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnRutaBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "SQL Backup Files|*.bak";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaRestaurar.Text = openFileDialog1.FileName;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el nombre de la máquina
                string machineName = Environment.MachineName;

                // Poner la base de datos en modo SINGLE_USER para liberar conexiones
                string singleUserCommand = $"sqlcmd -S {machineName}\\SQLEXPRESS -E -Q \"ALTER DATABASE [{cboBaseDatos.Text}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE\"";

                // Comando para restaurar la base de datos
                string restoreCommand = $"sqlcmd -S {machineName}\\SQLEXPRESS -E -Q \"RESTORE DATABASE [{cboBaseDatos.Text}] FROM DISK='{txtRutaRestaurar.Text}' WITH REPLACE\"";

                // Comando para devolver la base de datos a modo MULTI_USER
                string multiUserCommand = $"sqlcmd -S {machineName}\\SQLEXPRESS -E -Q \"ALTER DATABASE [{cboBaseDatos.Text}] SET MULTI_USER\"";

                // Ejecutar el proceso para poner la base en SINGLE_USER
                ExecuteSqlCommand(singleUserCommand);

                // Restaurar la base de datos
                ExecuteSqlCommand(restoreCommand);

                // Volver a poner la base de datos en modo MULTI_USER
                ExecuteSqlCommand(multiUserCommand);

                MessageBox.Show("La base de datos ha sido restaurada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar la base de datos: " + ex.Message);
            }
        }

        private void ExecuteSqlCommand(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd", "/c " + command);
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            using (Process process = Process.Start(psi))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    // Puedes mostrar el resultado si lo necesitas:
                    // MessageBox.Show(result);
                }
            }
        }
    }
}
