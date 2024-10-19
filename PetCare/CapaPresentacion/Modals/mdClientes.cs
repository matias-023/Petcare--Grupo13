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
    public partial class mdClientes : Form
    {
        public int indiceUsuario { get; set; }
        public DataGridViewRow fila { get; set; }
        public Cliente mdCliente { get; set; }
        public mdClientes()
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

        private void mdClientes_Load(object sender, EventArgs e)
        {
            TDocumento.Select();
            CEstado.Items.Add(new opcionCombo() { valor = 1, texto = "Activo" });
            CEstado.Items.Add(new opcionCombo() { valor = 0, texto = "No Activo" });
            CEstado.DisplayMember = "texto";
            CEstado.ValueMember = "valor";
            CEstado.SelectedIndex = 0;


            if (fila != null)
            {
                BAgregar.Text = "Editar";
                BAgregar.IconChar = FontAwesome.Sharp.IconChar.Edit;
                titulo.Text = "Editar Usuario";
                rellenarCampos();
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 0)
            {
                DialogResult ask = MessageBox.Show("Los Clientes no activos no podrán ser registrados en una venta, desea continuar?", "Confirmar estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (ask == DialogResult.Yes)
                {
                    GuardarCliente();
                }
            }
            else
            {
                GuardarCliente();
            }
        }
        private void GuardarCliente()
        {

            string mensaje = string.Empty;
            mdCliente = new Cliente()
            {
                idCliente = Convert.ToInt32(TIdCliente.Text),
                documento = TDocumento.Text,
                nombreCompleto = TNombreCompleto.Text,
                correo = TCorreo.Text,
                telefono = TTelefono.Text,
                estado = Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 1 ? true : false
            };

            //Si es 0 significa que se esta creando un nuevo Cliente, caso contrario se está editando un Cliente
            if (mdCliente.idCliente == 0)
            {
                int idClienteGenerado = new CN_Cliente().registrar(mdCliente, out mensaje);

                if (idClienteGenerado != 0)
                {
                    mdCliente.idCliente = idClienteGenerado;
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
                bool resultado = new CN_Cliente().editar(mdCliente, out mensaje);
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

        private void rellenarCampos()
        {
            TIdCliente.Text = fila.Cells["idCliente"].Value.ToString();
            TDocumento.Text = fila.Cells["documento"].Value.ToString();
            TNombreCompleto.Text = fila.Cells["nombreCompleto"].Value.ToString();
            TCorreo.Text = fila.Cells["correo"].Value.ToString();
            TTelefono.Text = fila.Cells["telefono"].Value.ToString();


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

        private void TNombreCompleto_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                mayusculas(textBox);
            }
        }
    }
}
