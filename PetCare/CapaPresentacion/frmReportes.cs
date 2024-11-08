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

            // Ocultar el gráfico de pastel si se selecciona "Productos sin vender"
            if (Convert.ToInt32(opcionSeleccionada.valor) == 4) // Asumiendo que 4 es el valor para "Productos sin vender"
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }

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
            pictureBox1.Invalidate(); // Redibuja el gráfico de pastel cada vez que se selecciona un nuevo reporte
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

            pictureBox1.Invalidate(); // Redibuja el gráfico


        }

        private void marcasMasVendidas()
        {
            dgvData.Columns.Clear();

            dgvData.DataSource = objReporte.ObtenerReporte("SP_ReporteMarcasMasVendidas", TFechaInicio.Value.ToString(), TFechaFin.Value.ToString());

            dgvData.Columns["Marca"].Width = 175;
            dgvData.Columns["Cant. Vendida"].Width = 150;

            pictureBox1.Invalidate(); // Redibuja el gráfico

        }

        private void categoriasMasVendidas()
        {
            dgvData.Columns.Clear();

            dgvData.DataSource = objReporte.ObtenerReporte("SP_ReporteCatMasVendidas", TFechaInicio.Value.ToString(), TFechaFin.Value.ToString());

            dgvData.Columns["Categoria"].Width = 175;
            dgvData.Columns["Cant. Vendida"].Width = 150;

            pictureBox1.Invalidate(); // Redibuja el gráfico

        }

        private void cajeroConMasVentas()
        {
            dgvData.Columns.Clear();

            dgvData.DataSource = objReporte.ObtenerReporte("SP_ReporteCajeros", TFechaInicio.Value.ToString(), TFechaFin.Value.ToString());

            dgvData.Columns["Documento"].Width = 200;
            dgvData.Columns["Nombre Completo"].Width = 250;
            dgvData.Columns["Cant. de Ventas"].Width = 150;
            dgvData.Columns["Productos Vendidos"].Width = 150;

            pictureBox1.Invalidate(); // Redibuja el gráfico

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

            pictureBox1.Invalidate(); // Redibuja el gráfico

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)

        {
            Graphics g = e.Graphics;

            // Obtener las columnas específicas para el reporte seleccionado
            var opcionSeleccionada = (opcionCombo)CTipoReporte.SelectedItem;
            int valorSeleccionado = Convert.ToInt32(opcionSeleccionada.valor);
            var (columnaEtiqueta, columnaValor) = ObtenerColumnasParaReporte(valorSeleccionado);

            // Extraer datos del DataGridView
            List<string> etiquetas = new List<string>();
            List<int> valores = new List<int>();

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[columnaEtiqueta].Value != null && row.Cells[columnaValor].Value != null)
                {
                    etiquetas.Add(row.Cells[columnaEtiqueta].Value.ToString());
                    valores.Add(Convert.ToInt32(row.Cells[columnaValor].Value));
                }
            }

            if (valores.Count == 0)
                return;  // No hay datos para graficar

            // Calcular el total y los ángulos de cada segmento
            int total = valores.Sum();
            float inicioAngulo = 0;
            Color[] colores = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple };  // Colores para los segmentos
            int centroX = pictureBox1.Width / 2;
            int centroY = pictureBox1.Height / 2;
            int radio = Math.Min(centroX, centroY) - 20;  // Radio del pastel

            for (int i = 0; i < valores.Count; i++)
            {
                float sweepAngulo = (valores[i] * 360f) / total;
                g.FillPie(new SolidBrush(colores[i % colores.Length]), new Rectangle(centroX - radio, centroY - radio, radio * 2, radio * 2), inicioAngulo, sweepAngulo);

                // Calcular la posición de la etiqueta
                float anguloEtiqueta = inicioAngulo + sweepAngulo / 2;
                double radianes = anguloEtiqueta * (Math.PI / 180);
                int distanciaEtiqueta = radio + 20;  // Distancia desde el centro para la etiqueta
                int xEtiqueta = centroX + (int)(distanciaEtiqueta * Math.Cos(radianes));
                int yEtiqueta = centroY + (int)(distanciaEtiqueta * Math.Sin(radianes));

                // Dibujar la etiqueta
                g.DrawString(etiquetas[i], new Font("Arial", 8), Brushes.Black, new PointF(xEtiqueta, yEtiqueta));

                inicioAngulo += sweepAngulo;
            }
        }

        private (string columnaEtiqueta, string columnaValor) ObtenerColumnasParaReporte(int tipoReporte)
        {
            return tipoReporte switch
            {
                0 => ("Nombre", "Cant. Vendida"),         // Productos más vendidos
                1 => ("Marca", "Cant. Vendida"),           // Marcas más vendidas
                2 => ("Categoria", "Cant. Vendida"),       // Categorías más vendidas
                3 => ("Nombre Completo", "Cant. de Ventas"), // Cajero con más ventas
                4 => ("Código", "Precio de Venta"),          // Productos sin vender
                _ => throw new ArgumentException("Tipo de reporte no válido")
            };
        }

        private void frmReportes_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                pictureBox1.Visible = true; // Mostrar el gráfico al maximizar
            }
            else
            {
                pictureBox1.Visible = false; // Ocultar el gráfico si no está maximizado
            }

            // Colocar el gráfico en la esquina inferior derecha si está visible
            if (pictureBox1.Visible)
            {
                int margenDerecho = 20;
                int margenInferior = 20;

                pictureBox1.Location = new System.Drawing.Point(
                      this.ClientSize.Width - pictureBox1.Width - margenDerecho,
                      this.ClientSize.Height - pictureBox1.Height - margenInferior
                );

            }
        }
    }
}
