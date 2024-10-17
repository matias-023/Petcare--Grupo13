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
    public partial class mdProveedores : Form
    {
        public int indiceProveedor { get; set; }
        public DataGridViewRow fila { get; set; }
        public Proveedor mdProveedor { get; set; }
        public mdProveedores()
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

        private void mdProveedores_Load(object sender, EventArgs e)
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
                titulo.Text = "Editar Proveedor";
                rellenarCampos();
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 0)
            {
                DialogResult ask = MessageBox.Show("Los Proveedores no activos no podrán ser registrados en una compra, desea continuar?", "Confirmar estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (ask == DialogResult.Yes)
                {
                    GuardarProveedor();
                }
            }
            else
            {
                GuardarProveedor();
            }
        }

        private void GuardarProveedor()
        {
            string mensaje = string.Empty;
            mdProveedor = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(TIdProveedor.Text),
                documento = TDocumento.Text,
                razonSocial = TRazonSocial.Text,
                correo = TCorreo.Text,
                telefono = TTelefono.Text,
                estado = Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 1 ? true : false
            };

            //Si es 0 significa que se esta creando un nuevo Proveedor, caso contrario se está editando un Proveedor
            if (mdProveedor.IdProveedor == 0)
            {
                int idProveedorGenerado = new CN_Proveedor().registrar(mdProveedor, out mensaje);

                if (idProveedorGenerado != 0)
                {
                    mdProveedor.IdProveedor = idProveedorGenerado;
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
                bool resultado = new CN_Proveedor().editar(mdProveedor, out mensaje);
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

        private void rellenarCampos()
        {
            TIdProveedor.Text = fila.Cells["idProveedor"].Value.ToString();
            TDocumento.Text = fila.Cells["documento"].Value.ToString();
            TRazonSocial.Text = fila.Cells["razonSocial"].Value.ToString();
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

    }
}
