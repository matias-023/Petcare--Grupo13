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
using System.Windows.Documents;
using System.Windows.Forms;

namespace CapaPresentacion.Modals
{
    public partial class mdUsuarios : Form
    {
        public int indiceUsuario { get; set; }
        public DataGridViewRow fila { get; set; }
        public int idUsuarioLogeado { get; set; }
        public Usuario mdUsuario { get; set; }
        public mdUsuarios()
        {
            InitializeComponent();
        }
        private void mdUsuarios_Load(object sender, EventArgs e)
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


            if (fila != null)
            {
                BAgregar.Text = "Editar";
                BAgregar.IconChar = FontAwesome.Sharp.IconChar.Edit;
                titulo.Text = "Editar Usuario";
                rellenarCampos();
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

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAgregar_Click(object sender, EventArgs e)
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

        private void GuardarUsuario()
        {

            string mensaje = string.Empty;
            mdUsuario = new Usuario()
            {
                idUsuario = Convert.ToInt32(TIdUsuario.Text),
                documento = TDocumento.Text,
                nombreCompleto = TNombreCompleto.Text,
                correo = TCorreo.Text,
                telefono = TTelefono.Text,
                clave = TContraseña.Text,
                oRol = new Rol(){
                    idRol = Convert.ToInt32(((opcionCombo)CRol.SelectedItem).valor),
                    descripcion = ((opcionCombo)CRol.SelectedItem).texto.ToString()
                },
                estado = Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 1 ? true : false
            };

            //Si es 0 significa que se esta creando un nuevo usuario, caso contrario se está editando un usuario
            if (mdUsuario.idUsuario == 0)
            {
                int idUsuarioGenerado = new CN_Usuario().registrar(mdUsuario, out mensaje);

                if (idUsuarioGenerado != 0)
                {
                    MessageBox.Show(mensaje, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                bool resultado = new CN_Usuario().editar(mdUsuario, out mensaje);
                if (resultado)
                {
                    MessageBox.Show(mensaje, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void TNombreCompleto_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                mayusculas(textBox);
            }
        }

        private void rellenarCampos()
        {
            TIdUsuario.Text = fila.Cells["idUsuario"].Value.ToString();

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

            TDocumento.Text = fila.Cells["documento"].Value.ToString();
            TNombreCompleto.Text = fila.Cells["nombreCompleto"].Value.ToString();
            TCorreo.Text = fila.Cells["correo"].Value.ToString();
            TTelefono.Text = fila.Cells["telefono"].Value.ToString();
            TContraseña.Text = fila.Cells["contraseña"].Value.ToString();
            TConfirmarContraseña.Text = fila.Cells["contraseña"].Value.ToString();

            foreach (opcionCombo oc in CRol.Items)
            {
                if (oc.texto == fila.Cells["rol"].Value.ToString())
                {
                    int indice_combo = CRol.Items.IndexOf(oc);
                    CRol.SelectedIndex = indice_combo;
                    break;
                }
            }

            foreach (opcionCombo oc in CEstado.Items)
            {
                if (Convert.ToInt32(oc.valor) == Convert.ToInt32(fila.Cells["estadoValor"].Value))
                {
                    int indice_combo = CEstado.Items.IndexOf(oc);
                    CEstado.SelectedIndex = indice_combo;
                    break;
                }
            }
        }
    }
}
