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
using CapaPresentacion.Modals;
using CapaEntidad;
using CapaNegocio;
using Microsoft.VisualBasic.ApplicationServices;

namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        private static int idUsuarioLogeado;
        public frmUsuario(Usuario objUsuario)
        {
            InitializeComponent();
            if (objUsuario == null)
            {
                idUsuarioLogeado = 1;
            }
            else
            {
                idUsuarioLogeado = objUsuario.idUsuario;
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "BSeleccionar")
                {
                    CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "valor";
            CBusqueda.SelectedIndex = 0;

            //Se listan todos los usuarios
            List<Usuario> listaUsuario = new CN_Usuario().listar();

            foreach (Usuario user in listaUsuario)
            {
                if (user.idUsuario != 1)
                {

                dgvData.Rows.Add(new object[] {"", user.idUsuario, user.documento, user.nombreCompleto, user.correo, user.telefono, user.clave, user.sexo, user.fechaNacimiento,
                user.oRol.idRol,
                user.oRol.descripcion,
                user.estado == true ? 1 : 0,
                user.estado == true ? "Activo": "No activo"

                });
                }
            }
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.edit.Width;
                var h = Properties.Resources.edit.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "BSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)

                {
                    DataGridViewRow filaSeleccionada = dgvData.Rows[indice];

                    if (filaSeleccionada != null)
                    {
                        mdUsuarios modal = new mdUsuarios();
                        modal.indiceUsuario = indice;
                        modal.fila = filaSeleccionada;
                        modal.idUsuarioLogeado = idUsuarioLogeado;
                        var result = modal.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            DataGridViewRow row = dgvData.Rows[indice];
                            row.Cells["idUsuario"].Value = modal.mdUsuario.idUsuario;
                            row.Cells["documento"].Value = modal.mdUsuario.documento;
                            row.Cells["nombreCompleto"].Value = modal.mdUsuario.nombreCompleto;
                            row.Cells["correo"].Value = modal.mdUsuario.correo;
                            row.Cells["telefono"].Value = modal.mdUsuario.telefono;
                            row.Cells["contraseña"].Value = modal.mdUsuario.clave;
                            row.Cells["sexo"].Value = modal.mdUsuario.sexo;
                            row.Cells["fechaNacimiento"].Value = modal.mdUsuario.fechaNacimiento;
                            row.Cells["idRol"].Value = modal.mdUsuario.oRol.idRol;
                            row.Cells["rol"].Value = modal.mdUsuario.oRol.descripcion;
                            row.Cells["estadoValor"].Value = modal.mdUsuario.estado == true ? 1 : 0;
                            row.Cells["estado"].Value = modal.mdUsuario.estado == true ? "Activo" : "No activo";
                        }
                    }
                }
            }
        }

        private void BBusqueda_Click(object sender, EventArgs e)
        {
            string filtro = ((opcionCombo)CBusqueda.SelectedItem).valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[filtro].Value.ToString().Trim().ToLower().Contains(TBusqueda.Text.Trim().ToLower()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void BLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            TBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdUsuarios())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dgvData.Rows.Add(new object[] {"", modal.mdUsuario.idUsuario, modal.mdUsuario.documento, modal.mdUsuario.nombreCompleto, modal.mdUsuario.correo, modal.mdUsuario.telefono, modal.mdUsuario.clave, modal.mdUsuario.sexo, modal.mdUsuario.fechaNacimiento,
                modal.mdUsuario.oRol.idRol,
                modal.mdUsuario.oRol.descripcion,
                modal.mdUsuario.estado == true ? 1 : 0,
                modal.mdUsuario.estado == true ? "Activo": "No activo"
                });
                }
            }
        }
    }
}
