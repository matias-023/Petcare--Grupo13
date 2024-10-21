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
    public partial class mdBuscarProveedor : Form
    {
        public Proveedor mdProveedor { get; set; }
        public mdBuscarProveedor()
        {
            InitializeComponent();
        }
        private void mdBuscarProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true)
                {
                    CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "valor";
            CBusqueda.SelectedIndex = 0;

            //Se listan todos los Proveedores activos.
            List<Proveedor> listaProveedor = new CN_Proveedor().listar().Where(p => p.estado == true).ToList();

            foreach (Proveedor prov in listaProveedor)
            {
                if (prov.estado == true)
                {
                    dgvData.Rows.Add(new object[] { prov.IdProveedor, prov.documento, prov.razonSocial });
                }
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

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex, iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                mdProveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dgvData.Rows[iRow].Cells["idProveedor"].Value.ToString()),
                    documento = dgvData.Rows[iRow].Cells["nroDocumento"].Value.ToString(),
                    razonSocial = dgvData.Rows[iRow].Cells["razonSocial"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
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
    }
}
