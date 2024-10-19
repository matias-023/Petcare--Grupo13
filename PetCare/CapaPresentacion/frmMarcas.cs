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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvDataMarcas.Columns)
            {
                if (columna.Visible == true && columna.Name != "BSeleccionar")
                {
                    CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "valor";
            CBusqueda.SelectedIndex = 0;

            //Se listan todas las marcas
            List<Marca> listaMarca = new CN_Marca().listar();

            foreach (Marca marca in listaMarca)
            {

                dgvDataMarcas.Rows.Add(new object[] {"", marca.idMarca, marca.descripcion,
                marca.estado == true ? 1 : 0,
                marca.estado == true ? "Activa": "No activa"

                });
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdMarcas())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dgvDataMarcas.Rows.Add(new object[] {"", modal.mdMarca.idMarca, modal.mdMarca.descripcion,
                modal.mdMarca.estado == true ? 1 : 0,
                modal.mdMarca.estado == true ? "Activa": "No activa"
                });
                }
            }
        }

        private void dgvDataMarcas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvDataMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataMarcas.Columns[e.ColumnIndex].Name == "BSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)

                {
                    DataGridViewRow filaSeleccionada = dgvDataMarcas.Rows[indice];

                    if (filaSeleccionada != null)
                    {
                        mdMarcas modal = new mdMarcas();
                        modal.indiceMarca = indice;
                        modal.fila = filaSeleccionada;
                        var result = modal.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            DataGridViewRow row = dgvDataMarcas.Rows[indice];
                            row.Cells["idMarca"].Value = modal.mdMarca.idMarca;
                            row.Cells["descripcion"].Value = modal.mdMarca.descripcion;
                            row.Cells["estadoValor"].Value = modal.mdMarca.estado == true ? 1 : 0;
                            row.Cells["estado"].Value = modal.mdMarca.estado == true ? "Activa" : "No activa";
                        }
                    }
                }
            }
        }

        private void BBusqueda_Click(object sender, EventArgs e)
        {
            string filtro = ((opcionCombo)CBusqueda.SelectedItem).valor.ToString();

            if (dgvDataMarcas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataMarcas.Rows)
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
            foreach (DataGridViewRow row in dgvDataMarcas.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
