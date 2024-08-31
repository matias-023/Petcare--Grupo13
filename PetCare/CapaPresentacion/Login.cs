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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            inicio form = new inicio();
            form.Show();
            this.Hide();
       
            form.FormClosing += frm_closing;
        }

        private void frm_closing(object sender, EventArgs e)
        {
            this.Show();
            TDocumento.Text = "";
            TContraseña.Text = "";

        }
    }
}
