using CapaDatos;
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
using System.Windows.Forms;

namespace CapaPresentacion.Modals
{
    public partial class mdMarcas : Form
    {
        public int indiceMarca { get; set; }
        public DataGridViewRow fila { get; set; }
        public Marca mdMarca { get; set; }
        public mdMarcas()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void mdMarcas_Load(object sender, EventArgs e)
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
                titulo.Text = "Editar Marca";
                rellenarCampos();
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            //Muestra un mensaje si se elige la opción de marca no activa.
            if (Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 0)
            {
                DialogResult ask = MessageBox.Show("No se podrán registrar nuevos productos con las marcas no activas, ni modificar el stock de productos de esta marca, desea continuar?", "Confirmar estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (ask == DialogResult.Yes)
                {
                    GuardarMarca();
                }
            }
            else
            {
                GuardarMarca();
            }
        }

        private void GuardarMarca()
        {

            string mensaje = string.Empty;
            mdMarca = new Marca()
            {
                idMarca = Convert.ToInt32(TIdMarca.Text),
                descripcion = TDescripcion.Text,
                estado = Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 1 ? true : false
            };

            //Si es 0 significa que se esta creando una nueva marca, caso contrario se está editando una marca
            if (mdMarca.idMarca == 0)
            {
                int idMarcaGenerado = new CN_Marca().registrar(mdMarca, out mensaje);

                if (idMarcaGenerado != 0)
                {
                    mdMarca.idMarca = idMarcaGenerado;
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
                bool resultado = new CN_Marca().editar(mdMarca, out mensaje);
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
            TIdMarca.Text = fila.Cells["idMarca"].Value.ToString();

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
