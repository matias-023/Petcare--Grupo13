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
    public partial class frmReportesVentas : Form
    {
        public frmReportesVentas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmReportesVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText });
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "value";
            CBusqueda.SelectedIndex = 0;
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
                List<reporteVenta> lista = new List<reporteVenta>();

                lista = new CN_Reporte().Venta(txtfechainicio.Value.ToString(), txtfechafin.Value.ToString());

                dgvData.Rows.Clear();

                foreach (reporteVenta rv in lista)
                {
                    dgvData.Rows.Add(new object[]
                    {
                    rv.fechaRegistro,
                    rv.tipoDocumento,
                    rv.numeroDocumento,
                    rv.montoTotal,
                    rv.usuarioRegistrado,
                    rv.documentoCliente,
                    rv.nombreCliente,
                    rv.codigoProducto,
                    rv.nombreProducto,
                    rv,categoria,
                    rv.precioVenta,
                    rv.cantidad,
                    rv.subTotal
                    });
                }


            
        }
    }
}
