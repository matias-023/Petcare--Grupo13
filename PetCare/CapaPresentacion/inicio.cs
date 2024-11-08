using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconButton menuActivo = null;
        private static Form formularioActivo = null;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //inicio funciones del diseño del formulario
        private void diseño()
        {
            panelSubMenuCompras.Visible = false;
            panelSubMenuVentas.Visible = false;
            panelSubMenuReabastecedor.Visible = false;
            panelSubMenuReportes.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (panelSubMenuCompras.Visible == true)
                panelSubMenuCompras.Visible = false;
            if (panelSubMenuVentas.Visible == true)
                panelSubMenuVentas.Visible = false;
            if (panelSubMenuReabastecedor.Visible == true)
                panelSubMenuReabastecedor.Visible = false;
            if (panelSubMenuReportes.Visible == true)
                panelSubMenuReportes.Visible = false;
        }

        private void mostrarSubMenu(Panel submenu)
        {

            if (submenu.Visible == false)
            {
                ocultarSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }



        }

        public inicio(Usuario objUsuario = null)
        {
            usuarioActual = objUsuario;

            InitializeComponent();

            if (usuarioActual.oRol.idRol == 1)
            {
                iconoUsuario.IconChar = IconChar.UserGear;
            }
            else
            {
                iconoUsuario.IconChar = IconChar.UserLarge;
                panelSubMenuReportes.Size = new System.Drawing.Size(183, 40);
                //Se ocultan los submenus de reportes a los usuarios a los que no les corresponden
                if (usuarioActual.oRol.idRol == 3)
                    subMenuEstadisticas.Visible = false;
                    
            }
            diseño();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = new CN_Permiso().listar(usuarioActual.idUsuario);

            foreach (IconButton button in menu.Controls.OfType<IconButton>())
            {
                bool encontrado = listaPermisos.Any(m => m.nombreMenu == button.Name);
                if (!encontrado)
                {
                    button.Visible = false;
                }

            }

            LUsuario.Text = usuarioActual.oRol.descripcion + ": " + usuarioActual.nombreCompleto;
            this.KeyPreview = true;
        }


        private void abrirFormulario(IconButton menu, Form formulario)
        {
            // Intentar cerrar el formulario activo
            if (formularioActivo != null)
            {
                formularioActivo.Close(); // Esto dispara el evento FormClosing

                // Verificar si el formulario aún está abierto (Close no cierra si se cancela)
                if (!formularioActivo.IsDisposed)
                {
                    return; // Si el formulario no se cerró, salir de la función y no abrir uno nuevo
                }
            }

            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.FromArgb(210, 120, 61);
                menuActivo.ForeColor = Color.White;
                menuActivo.IconColor = Color.White;
            }
            menuActivo = menu;
            menuActivo.BackColor = Color.WhiteSmoke;
            menuActivo.ForeColor = Color.FromArgb(210, 120, 61);
            menuActivo.IconColor = Color.FromArgb(210, 120, 61);

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.WhiteSmoke;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuReabastecedor_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuReabastecedor);
        }

        private void menuVentas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuVentas);
        }

        private void menuCompras_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuCompras);
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelSubMenuReportes);
        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario((IconButton)sender, new frmUsuario(usuarioActual));
        }

        private void subMenuCategorias_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario(menuReabastecedor, new frmCategorias());
        }

        private void subMenuMarcas_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario(menuReabastecedor, new frmMarcas());
        }
        private void subMenuProductos_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario(menuReabastecedor, new frmProductos());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario(menuVentas, new frmVentas(usuarioActual));
        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario(menuVentas, new frmDetalleVenta(usuarioActual));
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario(menuCompras, new frmCompras(usuarioActual));
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario(menuCompras, new frmDetalleCompra());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario((IconButton)sender, new frmClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario((IconButton)sender, new frmProveedores());
        }

        private void subMenuReportesVentas_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario(menuReportes, new frmReportesVentas(usuarioActual));

        }

        private void subMenuEstadisticas_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario(menuReportes, new frmReportes());
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario((IconButton)sender, new frmAcercaDe());
        }

        private void menuBackup_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulario((IconButton)sender, new frmBackup());
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BRestaurar.Visible = true;
            BMaximizar.Visible = false;
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            restaurarPantalla();
        }

        private void BMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (BRestaurar.Visible == false)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void inicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (BRestaurar.Visible)
                {
                    restaurarPantalla();
                }
            }
        }

        private void restaurarPantalla()
        {
            this.WindowState = FormWindowState.Normal;
            BRestaurar.Visible = false;
            BMaximizar.Visible = true;
        }

        private void inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            // Verificar si el formulario secundario está abierto
            if (formularioActivo != null && !formularioActivo.IsDisposed)
            {
                formularioActivo.Close(); // Cerrar el formulario secundario antes de cerrar la aplicación
            }

            // Asegurarse de que el formulario principal solo se cierre si el formulario secundario está cerrado
            if (formularioActivo != null && !formularioActivo.IsDisposed)
            {
                e.Cancel = true;  // Si el formulario secundario no se pudo cerrar, cancelar el cierre del formulario principal
            }
        }
    }
}
