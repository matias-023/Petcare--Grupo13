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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        private static Usuario user;
        public frmVentas(Usuario objUsuario)
        {
            user = objUsuario;
            InitializeComponent();
        }
        private void frmVentas_Load(object sender, EventArgs e)
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

            TIdCliente.Text = "0";
            TIdProducto.Text = "0";
            TDocumentoCliente.Select();
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
                    TPrecio.Text = modal.mdProducto.precio_venta.ToString();
                    TStock.Text = modal.mdProducto.stock.ToString();
                    TCantidad.Select();
                }
                else
                {
                    TCodProducto.Select();
                }
            }
        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdBuscarCliente())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TIdCliente.Text = modal.mdCliente.idCliente.ToString();
                    TDocumentoCliente.Text = modal.mdCliente.documento;
                    TNombreCompleto.Text = modal.mdCliente.nombreCompleto.ToString();
                    TCodProducto.Select();
                }
                else
                {
                    TDocumentoCliente.Select();
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
                    TPrecio.Text = oProducto.precio_venta.ToString();
                    TStock.Text = oProducto.stock.ToString();
                    TCantidad.Select();
                }
                else
                {
                    TIdProducto.Text = "0";
                    TProducto.Text = "";
                    TPrecio.Text = "";
                    TStock.Text = "";
                }
            }
        }

        private void TDocumentoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cliente oCliente = new CN_Cliente().listar().Where(c => c.documento == TDocumentoCliente.Text && c.estado == true).FirstOrDefault();
                if (oCliente != null)
                {
                    TIdCliente.Text = oCliente.idCliente.ToString();
                    TDocumentoCliente.Text = oCliente.documento;
                    TNombreCompleto.Text = oCliente.nombreCompleto.ToString();
                    TCodProducto.Select();
                }
                else
                {
                    TIdCliente.Text = "0";
                    TNombreCompleto.Text = "";
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
                    decimal precioCompra = Convert.ToDecimal(fila.Cells["precio"].Value);
                    fila.Cells["subTotal"].Value = (nuevaCantidad * precioCompra).ToString();

                    break;
                }
            }

            if (!producto_existe)
            {
                dgvData.Rows.Add(new object[]
                {
                    TIdProducto.Text, TProducto.Text, TPrecio.Text, TCantidad.Value.ToString(),
                    (TCantidad.Value * Convert.ToDecimal(TPrecio.Text)).ToString(),
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
            TPrecio.Text = "";
            TStock.Text = "";
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
