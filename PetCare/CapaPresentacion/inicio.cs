using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
using System.Security.Cryptography;

namespace CapaPresentacion
{
    public partial class inicio : Form
    {

        private static Usuario usuarioActual;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;

        public inicio(Usuario objUsuario = null)
        {
            if (objUsuario == null) //
                usuarioActual = new Usuario() { nombreCompleto = "Usuario predefinido", idUsuario = 1 };
            else
                usuarioActual = objUsuario;


            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = new CN_Permiso().listar(usuarioActual.idUsuario);

            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = listaPermisos.Any(m => m.nombreMenu == iconMenu.Name);
                if (!encontrado)
                {
                    iconMenu.Visible = false;
                }

            }

            LUsuario.Text = usuarioActual.nombreCompleto;
        }


        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SandyBrown;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmUsuario());
        }

        private void subMenuCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuReabastecedor, new frmCategorias());
        }

        private void subMenuProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuReabastecedor, new frmProductos());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmVentas());

        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmDetalleVenta());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmReportes());
        }

        private void menuBackup_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmBackup());
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmAcercaDe());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmCompras());
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmDetalleCompra());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmProveedores());
        }
    }
}
