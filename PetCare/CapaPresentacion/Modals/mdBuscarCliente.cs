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
    public partial class mdBuscarCliente : Form
    {
        public Cliente mdCliente { get; set; }
        public mdBuscarCliente()
        {
            InitializeComponent();
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
                mdCliente = new Cliente()
                {
                    idCliente = Convert.ToInt32(dgvData.Rows[iRow].Cells["idCliente"].Value.ToString()),
                    documento = dgvData.Rows[iRow].Cells["nroDocumento"].Value.ToString(),
                    nombreCompleto = dgvData.Rows[iRow].Cells["nombreCompleto"].Value.ToString()
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

        private void mdBuscarCliente_Load(object sender, EventArgs e)
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

            //Se listan todos los clientes activos.
            List<Cliente> listaCliente = new CN_Cliente().listar().Where(c => c.estado == true).ToList();

            foreach (Cliente cl in listaCliente)
            {
                if (cl.estado == true)
                {
                    dgvData.Rows.Add(new object[] { cl.idCliente, cl.documento, cl.nombreCompleto });
                }
            }
        }
    }
}
