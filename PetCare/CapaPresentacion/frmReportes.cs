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

        private List<string> etiquetas = new List<string>();
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
                pictureBoxLeyenda.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBoxLeyenda.Visible = true;
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

            etiquetas.Clear(); // se limpia la lista de las etiquetas del dgv
            pictureBox1.Invalidate(); // Redibuja el gráfico


        }

        private void marcasMasVendidas()
        {
            dgvData.Columns.Clear();

            dgvData.DataSource = objReporte.ObtenerReporte("SP_ReporteMarcasMasVendidas", TFechaInicio.Value.ToString(), TFechaFin.Value.ToString());

            dgvData.Columns["Nombre Marca"].Width = 175;
            dgvData.Columns["Cant. Vendida"].Width = 150;

            etiquetas.Clear(); // se limpia la lista de las etiquetas del dgv
            pictureBox1.Invalidate(); // Redibuja el gráfico

        }

        private void categoriasMasVendidas()
        {
            dgvData.Columns.Clear();

            dgvData.DataSource = objReporte.ObtenerReporte("SP_ReporteCatMasVendidas", TFechaInicio.Value.ToString(), TFechaFin.Value.ToString());

            dgvData.Columns["Nombre Categoria"].Width = 175;
            dgvData.Columns["Cant. Vendida"].Width = 150;

            etiquetas.Clear(); // se limpia la lista de las etiquetas del dgv
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

            etiquetas.Clear(); // se limpia la lista de las etiquetas del dgv
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

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)

        {
            Graphics g = e.Graphics;

            // Obtener las columnas específicas para el reporte seleccionado
            var opcionSeleccionada = (opcionCombo)CTipoReporte.SelectedItem;
            int valorSeleccionado = Convert.ToInt32(opcionSeleccionada.valor);

            if (valorSeleccionado == 4)
            {
                etiquetas.Clear();
                pictureBoxLeyenda.Invalidate();
                return;
            }

            var (columnaEtiqueta, columnaValor) = ObtenerColumnasParaReporte(valorSeleccionado);

            // Extraer datos del DataGridView
            List<int> valores = new List<int>();

            int maxElementos = 5; // Máximo de elementos a tomar

            //Se valida que existan esas columnas
            if (dgvData.Columns.Contains(columnaEtiqueta) && dgvData.Columns.Contains(columnaValor))
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (etiquetas.Count >= maxElementos) break;

                    if (row.Cells[columnaEtiqueta].Value != null && row.Cells[columnaValor].Value != null)
                    {
                        etiquetas.Add(row.Cells[columnaEtiqueta].Value.ToString());
                        valores.Add(Convert.ToInt32(row.Cells[columnaValor].Value));
                    }
                }
            }
            else
            {
                etiquetas.Clear();
                pictureBoxLeyenda.Invalidate();
                return;
            }

            if (valores.Count == 0)
            {
                pictureBoxLeyenda.Invalidate();
                return;  // No hay datos para graficar
            }


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

                inicioAngulo += sweepAngulo;
            }

            pictureBoxLeyenda.Invalidate(); // Se redibujan las leyendas

        }

        private (string columnaEtiqueta, string columnaValor) ObtenerColumnasParaReporte(int tipoReporte)
        {
            return tipoReporte switch
            {
                0 => ("Nombre", "Cant. Vendida"),         // Productos más vendidos
                1 => ("Nombre Marca", "Cant. Vendida"),           // Marcas más vendidas
                2 => ("Nombre Categoria", "Cant. Vendida"),       // Categorías más vendidas
                3 => ("Nombre Completo", "Cant. de Ventas"), // Cajero con más ventas
                _ => throw new ArgumentException("Tipo de reporte no válido")
            };
        }

        private void pictureBoxLeyenda_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fuente = new Font("Arial", 9);
            Color[] colores = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple };

            int xInicial = 10;
            int yInicial = 10;
            int alturaLeyenda = 20;

            // Dibuja solo hasta 5 elementos o menos si hay menos datos
            int maxElementos = Math.Min(5, etiquetas.Count);
            for (int i = 0; i < maxElementos; i++)
            {
                // Cuadro de color
                using (Brush brush = new SolidBrush(colores[i % colores.Length]))
                {
                    g.FillRectangle(brush, xInicial, yInicial + i * alturaLeyenda, 15, 15);
                }

                // Etiqueta de texto
                g.DrawString(etiquetas[i], fuente, Brushes.Black, xInicial + 20, yInicial + i * alturaLeyenda);
            }
        }

        private void frmReportes_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            etiquetas.Clear();
        }
    }
}
