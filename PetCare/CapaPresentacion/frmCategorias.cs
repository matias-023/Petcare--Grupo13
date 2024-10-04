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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvDataCat.Columns)
            {
                if (columna.Visible == true && columna.Name != "BSeleccionar")
                {
                    CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "valor";
            CBusqueda.SelectedIndex = 0;

            //Se listan todas las categorías
            List<Categoria> listaCategoria = new CN_Categoria().listar();

            foreach (Categoria cat in listaCategoria)
            {

                dgvDataCat.Rows.Add(new object[] {"", cat.idCategoria, cat.descripcion,
                cat.estado == true ? 1 : 0,
                cat.estado == true ? "Activa": "No activa"

                });
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCategorias())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dgvDataCat.Rows.Add(new object[] {"", modal.mdCategoria.idCategoria, modal.mdCategoria.descripcion,
                modal.mdCategoria.estado == true ? 1 : 0,
                modal.mdCategoria.estado == true ? "Activa": "No activa"
                });
                }
            }
        }

        private void dgvDataCat_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvDataCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataCat.Columns[e.ColumnIndex].Name == "BSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)

                {
                    DataGridViewRow filaSeleccionada = dgvDataCat.Rows[indice];

                    if (filaSeleccionada != null)
                    {
                        mdCategorias modal = new mdCategorias();
                        modal.indiceCategoria = indice;
                        modal.fila = filaSeleccionada;
                        var result = modal.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            DataGridViewRow row = dgvDataCat.Rows[indice];
                            row.Cells["idCategoria"].Value = modal.mdCategoria.idCategoria;
                            row.Cells["descripcion"].Value = modal.mdCategoria.descripcion;
                            row.Cells["estadoValor"].Value = modal.mdCategoria.estado == true ? 1 : 0;
                            row.Cells["estado"].Value = modal.mdCategoria.estado == true ? "Activa" : "No activa";
                        }
                    }
                }
            }
        }

        private void BBusqueda_Click(object sender, EventArgs e)
        {
            string filtro = ((opcionCombo)CBusqueda.SelectedItem).valor.ToString();

            if (dgvDataCat.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataCat.Rows)
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
            foreach (DataGridViewRow row in dgvDataCat.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
