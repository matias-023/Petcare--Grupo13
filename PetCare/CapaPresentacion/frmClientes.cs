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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvDataClientes.Columns)
            {
                if (columna.Visible == true && columna.Name != "BSeleccionar")
                {
                    CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "valor";
            CBusqueda.SelectedIndex = 0;

            //Se listan todos los clientes
            List<Cliente> lista = new CN_Cliente().listar();

            foreach (Cliente user in lista)
            {

                dgvDataClientes.Rows.Add(new object[] {"", user.idCliente, user.documento, user.nombreCompleto, user.correo, user.telefono,
                user.estado == true ? 1 : 0,
                user.estado == true ? "Activo": "No activo"

                });
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdClientes())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dgvDataClientes.Rows.Add(new object[] {"", modal.mdCliente.idCliente, modal.mdCliente.documento, modal.mdCliente.nombreCompleto, modal.mdCliente.correo, modal.mdCliente.telefono,
                modal.mdCliente.estado == true ? 1 : 0,
                modal.mdCliente.estado == true ? "Activo": "No activo"
                });
                }
            }
        }

        private void dgvDataClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvDataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataClientes.Columns[e.ColumnIndex].Name == "BSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)

                {
                    DataGridViewRow filaSeleccionada = dgvDataClientes.Rows[indice];

                    if (filaSeleccionada != null)
                    {
                        mdClientes modal = new mdClientes();
                        modal.indiceUsuario = indice;
                        modal.fila = filaSeleccionada;
                        var result = modal.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            DataGridViewRow row = dgvDataClientes.Rows[indice];
                            row.Cells["idCliente"].Value = modal.mdCliente.idCliente;
                            row.Cells["documento"].Value = modal.mdCliente.documento;
                            row.Cells["nombreCompleto"].Value = modal.mdCliente.nombreCompleto;
                            row.Cells["correo"].Value = modal.mdCliente.correo;
                            row.Cells["telefono"].Value = modal.mdCliente.telefono;
                            row.Cells["estadoValor"].Value = modal.mdCliente.estado == true ? 1 : 0;
                            row.Cells["estado"].Value = modal.mdCliente.estado == true ? "Activo" : "No activo";
                        }
                    }
                }
            }
        }

        private void BBusqueda_Click(object sender, EventArgs e)
        {
            string filtro = ((opcionCombo)CBusqueda.SelectedItem).valor.ToString();

            if (dgvDataClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataClientes.Rows)
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
            foreach (DataGridViewRow row in dgvDataClientes.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
