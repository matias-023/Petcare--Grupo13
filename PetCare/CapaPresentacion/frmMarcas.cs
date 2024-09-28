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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdMarcas())
            {
                var result = modal.ShowDialog();
                /* if (result == DialogResult.OK)
               {

               } */
            }
        }
    }
}
