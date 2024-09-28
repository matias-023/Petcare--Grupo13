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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCategorias())
            {
                var result = modal.ShowDialog();
                 /* if (result == DialogResult.OK)
                {

                } */
            }
        }
    }
}
