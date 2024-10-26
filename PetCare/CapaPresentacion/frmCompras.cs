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
    public partial class frmCompras : Form
    {
        private static Usuario user;
        public frmCompras(Usuario objUsuario)
        {
            user = objUsuario;
            InitializeComponent();
        }
        private void frmCompras_Load(object sender, EventArgs e)
        {
            CTipoDocumento.Items.Add(new opcionCombo() { valor = "Boleta", texto = "Boleta" });
            CTipoDocumento.Items.Add(new opcionCombo() { valor = "Factura", texto = "Factura" });
            CTipoDocumento.DisplayMember = "texto";
            CTipoDocumento.ValueMember = "valor";
            CTipoDocumento.SelectedIndex = 0;

            TFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            THora.Text = DateTime.Now.ToString("HH:mm:ss");

            timer1.Start();
            timer1.Interval = 1000;

            TIdProveedor.Text = "0";
            TIdProducto.Text = "0";
            TDocumentoProveedor.Select();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            THora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdBuscarProducto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TIdProducto.Text = modal.mdProducto.idProducto.ToString();
                    TCodProducto.Text = modal.mdProducto.codigo;
                    TProducto.Text = modal.mdProducto.nombre.ToString();
                    TPrecioCompra.Text = modal.mdProducto.precio.ToString();
                    TPrecioVenta.Text = modal.mdProducto.precio_venta.ToString();
                    TCantidad.Select();
                }
                else
                {
                    TCodProducto.Select();
                }
            }
        }

        private void BBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdBuscarProveedor())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TIdProveedor.Text = modal.mdProveedor.IdProveedor.ToString();
                    TDocumentoProveedor.Text = modal.mdProveedor.documento;
                    TRazonSocial.Text = modal.mdProveedor.razonSocial.ToString();
                    TCodProducto.Select();
                }
                else
                {
                    TDocumentoProveedor.Select();
                }
            }
        }

        private void TCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().listar().Where(p => p.codigo == TCodProducto.Text && p.estado == true).FirstOrDefault();
                if (oProducto != null)
                {
                    TIdProducto.Text = oProducto.idProducto.ToString();
                    TProducto.Text = oProducto.nombre;
                    TPrecioCompra.Text = oProducto.precio.ToString();
                    TPrecioVenta.Text = oProducto.precio_venta.ToString();
                    TCantidad.Select();
                }
                else
                {
                    TIdProducto.Text = "0";
                    TProducto.Text = "";
                    TPrecioCompra.Text = "";
                    TPrecioVenta.Text = "";
                }
            }
        }

        private void TDocumentoProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Proveedor oProveedor = new CN_Proveedor().listar().Where(p => p.documento == TDocumentoProveedor.Text && p.estado == true).FirstOrDefault();
                if (oProveedor != null)
                {
                    TIdProveedor.Text = oProveedor.IdProveedor.ToString();
                    TDocumentoProveedor.Text = oProveedor.documento;
                    TRazonSocial.Text = oProveedor.razonSocial.ToString();
                    TCodProducto.Select();
                }
                else
                {
                    TIdProveedor.Text = "0";
                    TRazonSocial.Text = "";
                }
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            bool producto_existe = false;

            if (int.Parse(TIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow fila in dgvData.Rows)
            {
                if (fila.Cells["idProducto"].Value.ToString() == TIdProducto.Text)
                {
                    producto_existe = true;
                    // Actualizar la cantidad sumando la nueva cantidad
                    int cantidadActual = Convert.ToInt32(fila.Cells["cantidad"].Value);
                    int nuevaCantidad = cantidadActual + Convert.ToInt32(TCantidad.Value);

                    fila.Cells["cantidad"].Value = nuevaCantidad;

                    // Actualizar el total
                    decimal precioCompra = Convert.ToDecimal(fila.Cells["precioCompra"].Value);
                    fila.Cells["subTotal"].Value = (nuevaCantidad * precioCompra).ToString();

                    break;
                }
            }

            if (!producto_existe)
            {
                dgvData.Rows.Add(new object[]
                {
                    TIdProducto.Text, TProducto.Text, TPrecioCompra.Text, TPrecioVenta.Text, TCantidad.Value.ToString(),
                    (TCantidad.Value * Convert.ToDecimal(TPrecioCompra.Text)).ToString(),
                    ""
                });
            }

            calcularTotal();
            limpiarProducto();
            TCodProducto.Select();
        }

        private void limpiarProducto()
        {
            TIdProducto.Text = "0";
            TCodProducto.Text = "";
            TProducto.Text = "";
            TPrecioCompra.Text = "";
            TPrecioVenta.Text = "";
            TCantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                    total += Convert.ToDecimal(row.Cells["subTotal"].Value.ToString());
            }
            TTotal.Text = total.ToString();
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.trash.Width;
                var h = Properties.Resources.trash.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.trash, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "BEliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    string nombreProducto = dgvData.Rows[indice].Cells["nombre"].Value.ToString();

                    DialogResult ask = MessageBox.Show("Desea eliminar el producto: " + nombreProducto + ", de la lista?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (ask == DialogResult.Yes)
                    {
                        dgvData.Rows.RemoveAt(indice);
                        calcularTotal();
                    }
                }
            }
        }

    }
}
