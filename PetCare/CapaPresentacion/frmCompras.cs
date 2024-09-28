using CapaPresentacion.Modals;
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
        public frmCompras()
        {
            InitializeComponent();
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdBuscarProducto())
            {
                var result = modal.ShowDialog();
                /* if (result == DialogResult.OK)
               {

               } */
            }
        }

        private void BBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdBuscarProveedor())
            {
                var result = modal.ShowDialog();
                /* if (result == DialogResult.OK)
               {

               } */
            }
        }
    }
}
