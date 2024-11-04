using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modals
{
    public partial class mdContraseñaRestore : Form
    {
        public mdContraseñaRestore()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crear un borde negro alrededor del formulario
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            validarContraseña();
        }

        private void validarContraseña()
        {
            if (string.IsNullOrWhiteSpace(TContraseña.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario user = new CN_Usuario().listar().Where(u => u.idUsuario == 1 && u.clave == TContraseña.Text).FirstOrDefault();
            if (user != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("La contraseña ingresada no es correcta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                validarContraseña();
        }


    }
}
