using CapaEntidad;
using CapaNegocio;
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
    public partial class mdEditarVenta : Form
    {
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public int nuevaCantidad { get; set; }
        public decimal nuevoSubTotal { get; set; }

        private Producto product;
        public mdEditarVenta()
        {
            InitializeComponent();
        }

        private void mdEditarVenta_Load(object sender, EventArgs e)
        {
            product = new CN_Producto().listar().Where(p => p.idProducto == idProducto).FirstOrDefault();
            TCantidad.Value = cantidad;
            TCantidad.Select();
            if (product != null)
            {
                LProducto.Text = product.nombre;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crear un borde negro alrededor del formulario
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            agregar();        
        }

        private void TCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                agregar();
        }

        private void agregar()
        {
            string mensaje = string.Empty;
            nuevaCantidad = Convert.ToInt32(TCantidad.Value);
            if (nuevaCantidad >= cantidad)
            {
                bool respuesta = new CN_Venta().RestarStock(
                    product.idProducto,
                    (nuevaCantidad - cantidad),
                    out mensaje);
                if (respuesta)
                {
                    nuevoSubTotal = nuevaCantidad * product.precio_venta;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool respuesta = new CN_Venta().SumarStock(
                product.idProducto,
                (cantidad - nuevaCantidad));
                nuevoSubTotal = nuevaCantidad * product.precio_venta;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
