using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnRutaGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "SQL Backup files|*.bak";
            saveFileDialog1.FileName = "PETCARE-" + DateTime.Today.ToString("dd-MM-yyyy") + "-" + DateTime.Now.ToString("HH.mm") + ".bak";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaGuardar.Text = saveFileDialog1.FileName;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

            string ruta = txtRutaGuardar.Text;

            string mensaje;

            bool backupExitoso = new CN_Backup().backup(ruta, out mensaje);
            if (backupExitoso)
            {
                MessageBox.Show(mensaje, "Backup completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string ruta = txtRutaRestaurar.Text;

            string mensaje;

            bool restoreExitoso = new CN_Backup().restore(ruta, out mensaje);
            if (restoreExitoso)
            {
                MessageBox.Show(mensaje, "Restauración completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
