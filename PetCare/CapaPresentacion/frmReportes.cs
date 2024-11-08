using CapaNegocio;
using CapaPresentacion.Utilidades;
using iTextSharp.text.pdf.codec.wmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReportes : Form
    {
        private CN_Reporte objReporte = new CN_Reporte();
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

            CTipoReporte.Items.Add(new opcionCombo() { valor = 0, texto = "Productos más vendidos" });
            CTipoReporte.Items.Add(new opcionCombo() { valor = 1, texto = "Marcas más vendidas" });
            CTipoReporte.Items.Add(new opcionCombo() { valor = 2, texto = "Categorías más vendidas" });
            CTipoReporte.Items.Add(new opcionCombo() { valor = 3, texto = "Cajero con más ventas" });
            CTipoReporte.Items.Add(new opcionCombo() { valor = 4, texto = "Productos sin vender" });

            CTipoReporte.DisplayMember = "texto";
            CTipoReporte.ValueMember = "valor";
            CTipoReporte.SelectedIndex = 0;
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            var opcionSeleccionada = (opcionCombo)CTipoReporte.SelectedItem;

            switch (opcionSeleccionada.valor)
            {
                case 0:
                    productosMasVendidos();
                    break;
                case 1:
                    marcasMasVendidas();
                    break;
                case 2:
                    categoriasMasVendidas();
                    break;
                case 3:
                    cajeroConMasVentas();
                    break;
                case 4:
                    productosSinVender();
                    break;
                default:
                    MessageBox.Show("Seleccione una opción válida.");
                    break;
            }
        }

        private void productosMasVendidos()
        {
            dgvData.Columns.Clear();

            dgvData.DataSource = objReporte.ObtenerReporte("SP_ReporteProdMasVendidos", TFechaInicio.Value.ToString(), TFechaFin.Value.ToString());

            dgvData.Columns["Código"].Width = 150;
            dgvData.Columns["Nombre"].Width = 250;
            dgvData.Columns["Categoria"].Width = 175;
            dgvData.Columns["Marca"].Width = 175;
            dgvData.Columns["Precio de Venta"].Width = 150;
            dgvData.Columns["Cant. Vendida"].Width = 150;
            dgvData.Columns["Total"].Width = 150;

        }

        private void marcasMasVendidas()
        {
            dgvData.Columns.Clear();

            dgvData.DataSource = objReporte.ObtenerReporte("SP_ReporteMarcasMasVendidas", TFechaInicio.Value.ToString(), TFechaFin.Value.ToString());

            dgvData.Columns["Marca"].Width = 175;
            dgvData.Columns["Cant. Vendida"].Width = 150;


        }

        private void categoriasMasVendidas()
        {
            dgvData.Columns.Clear();

            dgvData.DataSource = objReporte.ObtenerReporte("SP_ReporteCatMasVendidas", TFechaInicio.Value.ToString(), TFechaFin.Value.ToString());

            dgvData.Columns["Categoria"].Width = 175;
            dgvData.Columns["Cant. Vendida"].Width = 150;


        }

        private void cajeroConMasVentas()
        {
            dgvData.Columns.Clear();

            dgvData.DataSource = objReporte.ObtenerReporte("SP_ReporteCajeros", TFechaInicio.Value.ToString(), TFechaFin.Value.ToString());

            dgvData.Columns["Documento"].Width = 200;
            dgvData.Columns["Nombre Completo"].Width = 250;
            dgvData.Columns["Cant. de Ventas"].Width = 150;
            dgvData.Columns["Productos Vendidos"].Width = 150;
        }

        private void productosSinVender()
        {
            dgvData.Columns.Clear();

            dgvData.DataSource = objReporte.ObtenerReporte("SP_ReporteProductosSinVentas", TFechaInicio.Value.ToString(), TFechaFin.Value.ToString());

            dgvData.Columns["Código"].Width = 150;
            dgvData.Columns["Nombre"].Width = 250;
            dgvData.Columns["Categoria"].Width = 175;
            dgvData.Columns["Marca"].Width = 175;
            dgvData.Columns["Precio de Venta"].Width = 150;
        }


    }
}
