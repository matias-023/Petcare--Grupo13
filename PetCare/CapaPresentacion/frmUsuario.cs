using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CEstado.Items.Add(new opcionCombo() { valor = 1, texto = "Activo" });
            CEstado.Items.Add(new opcionCombo() { valor = 0, texto = "No Activo" });
            CEstado.DisplayMember = "texto";
            CEstado.ValueMember = "valor";
            CEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().listar();

            foreach (Rol item in listaRol)
            {
                CRol.Items.Add(new opcionCombo() { valor = item.idRol, texto = item.descripcion });
                CRol.DisplayMember = "texto";
                CRol.ValueMember = "valor";

            }

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "BSeleccionar")
                {
                    CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText});
                }
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "valor";
            CBusqueda.SelectedIndex = 0;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Add(new object[] {"", TIdUsuario.Text, TDocumento.Text, TNombreCompleto.Text, TCorreo.Text, TTelefono.Text, TContraseña.Text,
            ((opcionCombo)CRol.SelectedItem).valor.ToString(),
            ((opcionCombo)CRol.SelectedItem).texto.ToString(),
            ((opcionCombo)CEstado.SelectedItem).valor.ToString(),
            ((opcionCombo)CEstado.SelectedItem).texto.ToString(),
            });


            limpiar();
        }

        private void limpiar()
        {
            TIdUsuario.Text = "0";
            TDocumento.Text = "";
            TNombreCompleto.Text = "";
            TCorreo.Text = "";
            TTelefono.Text = "";
            TContraseña.Text = "";
            TConfirmarContraseña.Text = "";
            CRol.SelectedIndex = 0;
            CEstado.SelectedIndex = 0;

        }
    }
}
