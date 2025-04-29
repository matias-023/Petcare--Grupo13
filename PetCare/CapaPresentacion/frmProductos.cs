using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modals;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            DoubleBuffered = true;
            EnableDoubleBuffer(dgvDataProd);
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvDataProd.Columns)
            {
                if (columna.Visible == true && columna.Name != "BSeleccionar")
                {
                    CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "valor";
            CBusqueda.SelectedIndex = 0;

            //Se listan todos los productos
            List<Producto> listaProducto = new CN_Producto().listar();

            foreach (Producto prod in listaProducto)
            {
                int rowIndex = dgvDataProd.Rows.Add(new object[] {"", prod.idProducto, prod.codigo, prod.nombre, prod.oCategoria.idCategoria, prod.oCategoria.descripcion, prod.oMarca.idMarca, prod.oMarca.descripcion, prod.stock, prod.stock_min, prod.precio, prod.precio_venta,
                prod.estado == true ? 1 : 0,
                prod.estado == true ? "Activo": "No activo"

                });

                if (prod.stock <= prod.stock_min)
                {
                    dgvDataProd.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral; // Cambia el color de fondo si el stock se encuentra por debajo del stock mínimo
                }
            }
        }
        private void EnableDoubleBuffer(DataGridView dgv)
        {
            Type dgvType = dgv.GetType();
            System.Reflection.PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            pi.SetValue(dgv, true, null);
        }

        private void dgvDataProd_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvDataProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataProd.Columns[e.ColumnIndex].Name == "BSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)

                {
                    DataGridViewRow filaSeleccionada = dgvDataProd.Rows[indice];

                    if (filaSeleccionada != null)
                    {
                        mdProductos modal = new mdProductos();
                        modal.indiceProducto = indice;
                        modal.fila = filaSeleccionada;
                        var result = modal.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            DataGridViewRow row = dgvDataProd.Rows[indice];
                            row.Cells["idProducto"].Value = modal.mdProducto.idProducto;
                            row.Cells["codigo"].Value = modal.mdProducto.codigo;
                            row.Cells["nombre"].Value = modal.mdProducto.nombre;
                            row.Cells["idCategoria"].Value = modal.mdProducto.oCategoria.idCategoria;
                            row.Cells["categoria"].Value = modal.mdProducto.oCategoria.descripcion;
                            row.Cells["idMarca"].Value = modal.mdProducto.oMarca.idMarca;
                            row.Cells["marca"].Value = modal.mdProducto.oMarca.descripcion;
                            row.Cells["stock"].Value = modal.mdProducto.stock;
                            row.Cells["stock_minimo"].Value = modal.mdProducto.stock_min;
                            row.Cells["precio"].Value = modal.mdProducto.precio;
                            row.Cells["precioVenta"].Value = modal.mdProducto.precio_venta;
                            row.Cells["estadoValor"].Value = modal.mdProducto.estado == true ? 1 : 0;
                            row.Cells["estado"].Value = modal.mdProducto.estado == true ? "Activo" : "No activo";

                            if (modal.mdProducto.stock <= modal.mdProducto.stock_min)
                                dgvDataProd.Rows[indice].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                            else
                                row.DefaultCellStyle.BackColor = dgvDataProd.DefaultCellStyle.BackColor;
                        }
                    }
                }
            }
        }

        private void BBusqueda_Click(object sender, EventArgs e)
        {
            string filtro = ((opcionCombo)CBusqueda.SelectedItem).valor.ToString();

            if (dgvDataProd.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataProd.Rows)
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
            foreach (DataGridViewRow row in dgvDataProd.Rows)
            {
                row.Visible = true;
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {


                int rowIndex = dgvDataProd.Rows.Add(new object[] {"", modal.mdProducto.idProducto, modal.mdProducto.codigo, modal.mdProducto.nombre, modal.mdProducto.oCategoria.idCategoria, modal.mdProducto.oCategoria.descripcion, modal.mdProducto.oMarca.idMarca, modal.mdProducto.oMarca.descripcion,
                modal.mdProducto.stock, modal.mdProducto.stock_min, modal.mdProducto.precio, modal.mdProducto.precio_venta,
                modal.mdProducto.estado == true ? 1 : 0,
                modal.mdProducto.estado == true ? "Activo": "No activo"
                });

                    if (modal.mdProducto.stock <= modal.mdProducto.stock_min)
                        dgvDataProd.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                }
            }
        }
    }
}
