using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modals;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvDataProveedores.Columns)
            {
                if (columna.Visible == true && columna.Name != "BSeleccionar")
                {
                    CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "valor";
            CBusqueda.SelectedIndex = 0;

            //Se listan todos los Proveedors
            List<Proveedor> listaProveedor = new CN_Proveedor().listar();

            foreach (Proveedor user in listaProveedor)
            {
                dgvDataProveedores.Rows.Add(new object[] {"", user.IdProveedor, user.documento, user.razonSocial, user.correo, user.telefono,
                user.estado == true ? 1 : 0,
                user.estado == true ? "Activo": "No activo"

                });
            }
        }
        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedores())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dgvDataProveedores.Rows.Add(new object[] {"", modal.mdProveedor.IdProveedor, modal.mdProveedor.documento, modal.mdProveedor.razonSocial, modal.mdProveedor.correo, modal.mdProveedor.telefono,
                modal.mdProveedor.estado == true ? 1 : 0,
                modal.mdProveedor.estado == true ? "Activo": "No activo"
                });
                }
            }
        }

        private void dgvDataProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvDataProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataProveedores.Columns[e.ColumnIndex].Name == "BSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)

                {
                    DataGridViewRow filaSeleccionada = dgvDataProveedores.Rows[indice];

                    if (filaSeleccionada != null)
                    {
                        mdProveedores modal = new mdProveedores();
                        modal.indiceProveedor = indice;
                        modal.fila = filaSeleccionada;
                        var result = modal.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            DataGridViewRow row = dgvDataProveedores.Rows[indice];
                            row.Cells["idProveedor"].Value = modal.mdProveedor.IdProveedor;
                            row.Cells["documento"].Value = modal.mdProveedor.documento;
                            row.Cells["razonSocial"].Value = modal.mdProveedor.razonSocial;
                            row.Cells["correo"].Value = modal.mdProveedor.correo;
                            row.Cells["telefono"].Value = modal.mdProveedor.telefono;
                            row.Cells["estadoValor"].Value = modal.mdProveedor.estado == true ? 1 : 0;
                            row.Cells["estado"].Value = modal.mdProveedor.estado == true ? "Activo" : "No activo";
                        }
                    }
                }
            }
        }

        private void BBusqueda_Click(object sender, EventArgs e)
        {
            string filtro = ((opcionCombo)CBusqueda.SelectedItem).valor.ToString();

            if (dgvDataProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataProveedores.Rows)
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
            foreach (DataGridViewRow row in dgvDataProveedores.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
