using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            string documento = TDocumento.Text, contraseña = TContraseña.Text;
            if (!validarNull(documento) && !validarNull(contraseña))
            {
                if (validarNum(documento))
                {
                    Usuario objUsuario = new CN_Usuario().listar().Where(u => u.documento == documento && u.clave == contraseña).FirstOrDefault();
                    if (objUsuario != null)
                    {
                        if (objUsuario.estado == false)
                        {
                            MessageBox.Show("El usuario se encuentra inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            inicio form = new inicio(objUsuario);
                            form.Show();
                            this.Hide();

                            form.FormClosing += frm_closing;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("Debe completar los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frm_closing(object sender, EventArgs e)
        {
            this.Show();
            TDocumento.Text = "";
            TContraseña.Text = "";
        }

        private bool validarNum(string p)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(p, @"^-?\d+$");
        }

        private bool validarNull(string p)
        {
            return string.IsNullOrEmpty(p);
        }
    }
}
