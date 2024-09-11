using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        private static int idUsuarioLogeado;
        public frmUsuario(Usuario objUsuario)
        {
            InitializeComponent();
            if (objUsuario == null)
            {
                idUsuarioLogeado = 1;
            }
            else
            {
                idUsuarioLogeado = objUsuario.idUsuario;
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            TDocumento.Select();
            CEstado.Items.Add(new opcionCombo() { valor = 1, texto = "Activo" });
            CEstado.Items.Add(new opcionCombo() { valor = 0, texto = "No Activo" });
            CEstado.DisplayMember = "texto";
            CEstado.ValueMember = "valor";
            CEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().listar();

            foreach (Rol item in listaRol)
            {
                CRol.Items.Add(new opcionCombo() { valor = item.idRol, texto = item.descripcion });
            }
            CRol.DisplayMember = "texto";
            CRol.ValueMember = "valor";
            CRol.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "BSeleccionar")
                {
                    CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "valor";
            CBusqueda.SelectedIndex = 0;

            //Se listan todos los usuarios
            List<Usuario> listaUsuario = new CN_Usuario().listar();

            foreach (Usuario user in listaUsuario)
            {
                if (user.idUsuario != 1)
                {

                    dgvData.Rows.Add(new object[] {"", user.idUsuario, user.documento, user.nombreCompleto, user.correo, user.telefono, user.clave,
                user.oRol.idRol,
                user.oRol.descripcion,
                user.estado == true ? 1 : 0,
                user.estado == true ? "Activo": "No activo"

                });
                }


            }
        }

        //Botón para editar o guardar usuarios.
        private void BGuardar_Click(object sender, EventArgs e)
        {
            //Muestra un mensaje si se elige la opción de usuario no activo.
            if (TContraseña.Text == TConfirmarContraseña.Text)
            {
                if (Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 0)
                {
                    DialogResult ask = MessageBox.Show("Los usuarios no activos no podrán ingresar al sistema, desea continuar?", "Confirmar estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (ask == DialogResult.Yes)
                    {
                        GuardarUsuario();
                    }
                }
                else
                {
                    GuardarUsuario();
                }
            }
            else
            {
                MessageBox.Show("La contraseña y su confirmación no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Función para guardar o editar usuarios.
        private void GuardarUsuario()
        {

            string mensaje = string.Empty;
            Usuario user = new Usuario()
            {
                idUsuario = Convert.ToInt32(TIdUsuario.Text),
                documento = TDocumento.Text,
                nombreCompleto = TNombreCompleto.Text,
                correo = TCorreo.Text,
                telefono = TTelefono.Text,
                clave = TContraseña.Text,
                oRol = new Rol() { idRol = Convert.ToInt32(((opcionCombo)CRol.SelectedItem).valor) },
                estado = Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 1 ? true : false
            };



            //Si es 0 significa que se esta creando un nuevo usuario, caso contrario se está editando un usuario
            if (user.idUsuario == 0)
            {
                int idUsuarioGenerado = new CN_Usuario().registrar(user, out mensaje);

                if (idUsuarioGenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {"", idUsuarioGenerado, TDocumento.Text, TNombreCompleto.Text, TCorreo.Text, TTelefono.Text, TContraseña.Text,
                ((opcionCombo)CRol.SelectedItem).valor.ToString(),
                ((opcionCombo)CRol.SelectedItem).texto.ToString(),
                ((opcionCombo)CEstado.SelectedItem).valor.ToString(),
                ((opcionCombo)CEstado.SelectedItem).texto.ToString(),
                });

                    limpiar();
                    MessageBox.Show(mensaje, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool resultado = new CN_Usuario().editar(user, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(TIndice.Text)];
                    row.Cells["idUsuario"].Value = TIdUsuario.Text;
                    row.Cells["documento"].Value = TDocumento.Text;
                    row.Cells["nombreCompleto"].Value = TNombreCompleto.Text;
                    row.Cells["correo"].Value = TCorreo.Text;
                    row.Cells["telefono"].Value = TTelefono.Text;
                    row.Cells["contraseña"].Value = TContraseña.Text;
                    row.Cells["idRol"].Value = ((opcionCombo)CRol.SelectedItem).valor.ToString();
                    row.Cells["rol"].Value = ((opcionCombo)CRol.SelectedItem).texto.ToString();
                    row.Cells["estadoValor"].Value = ((opcionCombo)CEstado.SelectedItem).valor.ToString();
                    row.Cells["estado"].Value = ((opcionCombo)CEstado.SelectedItem).texto.ToString();

                    limpiar();
                    MessageBox.Show(mensaje, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limpiar()
        {
            TIndice.Text = "-1";
            TIdUsuario.Text = "0";
            TDocumento.Text = "";
            TNombreCompleto.Text = "";
            TCorreo.Text = "";
            TTelefono.Text = "";
            TContraseña.Text = "";
            TConfirmarContraseña.Text = "";
            CRol.SelectedIndex = 0;
            CEstado.SelectedIndex = 0;

            TDocumento.Select();
            BGuardar.Text = "Crear usuario";
            BGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            CRol.Enabled = true;
            CEstado.Enabled = true;
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.edit.Width;
                var h = Properties.Resources.edit.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "BSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)

                {
                    BGuardar.Text = "Editar usuario";
                    BGuardar.IconChar = FontAwesome.Sharp.IconChar.Edit;

                    TIndice.Text = indice.ToString();
                    TIdUsuario.Text = dgvData.Rows[indice].Cells["idUsuario"].Value.ToString();

                    //Se ocultan los campos para cambiar roles y estado, ya que un usuario no puede cambiarse su rol ni su estado a si mismo.
                    if (TIdUsuario.Text == idUsuarioLogeado.ToString())
                    {
                        CRol.Enabled = false;
                        CEstado.Enabled = false;
                    }
                    else
                    {
                        CRol.Enabled = true;
                        CEstado.Enabled = true;
                    }

                    TDocumento.Text = dgvData.Rows[indice].Cells["documento"].Value.ToString();
                    TNombreCompleto.Text = dgvData.Rows[indice].Cells["nombreCompleto"].Value.ToString();
                    TCorreo.Text = dgvData.Rows[indice].Cells["correo"].Value.ToString();
                    TTelefono.Text = dgvData.Rows[indice].Cells["telefono"].Value.ToString();
                    TContraseña.Text = dgvData.Rows[indice].Cells["contraseña"].Value.ToString();
                    TConfirmarContraseña.Text = dgvData.Rows[indice].Cells["contraseña"].Value.ToString();

                    foreach (opcionCombo oc in CRol.Items)
                    {
                        if (oc.texto == dgvData.Rows[indice].Cells["rol"].Value.ToString())
                        {
                            int indice_combo = CRol.Items.IndexOf(oc);
                            CRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (opcionCombo oc in CEstado.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["estadoValor"].Value))
                        {
                            int indice_combo = CEstado.Items.IndexOf(oc);
                            CEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }
            }
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

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TNombreCompleto_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                mayusculas(textBox);
            }
        }

        private void mayusculas(TextBox p)
        {
            int selectionStart = p.SelectionStart;
            int selectionLength = p.SelectionLength;

            // Convierte el texto en formato Título
            p.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p.Text.ToLower());

            // Restablece la posición del cursor
            p.SelectionStart = selectionStart;
            p.SelectionLength = selectionLength;
        }
    }
}
