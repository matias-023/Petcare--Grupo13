using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Modals
{
    public partial class mdCategorias : Form
    {
        public int indiceCategoria { get; set; }
        public DataGridViewRow fila { get; set; }
        public Categoria mdCategoria { get; set; }
        public mdCategorias()
        {
            InitializeComponent();
        }

        private void BCerrarCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crear un borde negro alrededor del formulario
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void mdCategorias_Load(object sender, EventArgs e)
        {
            TDescripcion.Select();
            CEstado.Items.Add(new opcionCombo() { valor = 1, texto = "Activa" });
            CEstado.Items.Add(new opcionCombo() { valor = 0, texto = "No Activa" });
            CEstado.DisplayMember = "texto";
            CEstado.ValueMember = "valor";
            CEstado.SelectedIndex = 0;

            if (fila != null)
            {
                BAgregar.Text = "Editar";
                BAgregar.IconChar = FontAwesome.Sharp.IconChar.Edit;
                titulo.Text = "Editar Categoría";
                rellenarCampos();
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            //Muestra un mensaje si se elige la opción de categoria no activa.
            if (Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 0)
            {
                DialogResult ask = MessageBox.Show("No se podrán registrar nuevos productos con las categorías no activas, ni modificar el stock de productos de esta categoría, desea continuar?", "Confirmar estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (ask == DialogResult.Yes)
                {
                    GuardarCategoria();
                }
            }
            else
            {
                GuardarCategoria();
            }
        }

        private void GuardarCategoria()
        {

            string mensaje = string.Empty;
            mdCategoria = new Categoria()
            {
                idCategoria = Convert.ToInt32(TIdCategoria.Text),
                descripcion = TDescripcion.Text,
                estado = Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 1 ? true : false
            };

            //Si es 0 significa que se esta creando una nueva categoria, caso contrario se está editando una categoria.
            if (mdCategoria.idCategoria == 0)
            {
                int idCategoriaGenerado = new CN_Categoria().registrar(mdCategoria, out mensaje);

                if (idCategoriaGenerado != 0)
                {
                    mdCategoria.idCategoria = idCategoriaGenerado;
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
                bool resultado = new CN_Categoria().editar(mdCategoria, out mensaje);
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

        private void TDescripcion_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                mayusculas(textBox);
            }
        }

        private void rellenarCampos()
        {
            TIdCategoria.Text = fila.Cells["idCategoria"].Value.ToString();

            TDescripcion.Text = fila.Cells["descripcion"].Value.ToString();

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
