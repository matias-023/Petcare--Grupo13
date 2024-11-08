using CapaDatos;
using CapaEntidad;
using CapaNegocio;
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

namespace CapaPresentacion.Modals
{
    public partial class mdBuscarProducto : Form
    {
        public Producto mdProducto { get; set; }
        public mdBuscarProducto()
        {
            InitializeComponent();
        }
        private void mdBuscarProducto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true)
                {
                    CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "valor";
            CBusqueda.SelectedIndex = 0;

            //Se listan todos los productos activos
            List<Producto> listaProducto = new CN_Producto().listar().Where(p => p.stock > 0).ToList();

            foreach (Producto prod in listaProducto)
            {
                dgvData.Rows.Add(new object[] {prod.idProducto, prod.codigo, prod.nombre, prod.oMarca.descripcion,
                    prod.oCategoria.descripcion, prod.stock, prod.precio, prod.precio_venta });
            }
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crear un borde negro alrededor del formulario
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
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

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex, iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                mdProducto = new Producto()
                {
                    idProducto = Convert.ToInt32(dgvData.Rows[iRow].Cells["idProducto"].Value.ToString()),
                    codigo = dgvData.Rows[iRow].Cells["codigo"].Value.ToString(),
                    nombre = dgvData.Rows[iRow].Cells["nombre"].Value.ToString(),
                    stock = Convert.ToInt32(dgvData.Rows[iRow].Cells["stock"].Value.ToString()),
                    precio = Convert.ToDecimal(dgvData.Rows[iRow].Cells["precioCompra"].Value.ToString()),
                    precio_venta = Convert.ToDecimal(dgvData.Rows[iRow].Cells["precioVenta"].Value.ToString())
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
