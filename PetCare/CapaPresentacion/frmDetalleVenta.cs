using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace CapaPresentacion
{
    public partial class frmDetalleVenta : Form
    {
        private static Usuario user;
        public frmDetalleVenta(Usuario oUsuario)
        {
            user = oUsuario;
            InitializeComponent();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            buscarVenta();
        }

        private void TCodigoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarVenta();
            }
        }

        private void buscarVenta(string nroVenta = "")
        {
            if (!string.IsNullOrEmpty(nroVenta))
            {
                TCodigoVenta.Text = nroVenta;
            }

            Venta oVenta = new Venta();
            if(user.oRol.idRol == 1)
            {
                oVenta = new CN_Venta().obtenerVenta(TCodigoVenta.Text, 0);
            }
            else
            {
                oVenta = new CN_Venta().obtenerVenta(TCodigoVenta.Text, user.idUsuario);
            }

            if (oVenta.idVenta != 0)
            {
                TIdVenta.Text = oVenta.idVenta.ToString();
                TNroDocumento.Text = oVenta.numeroDocumento.ToString();

                TDocumentoCajero.Text = oVenta.oUsuario.documento;
                TNombreCajero.Text = oVenta.oUsuario.nombreCompleto;

                TDocumentoCliente.Text = oVenta.documentoCliente;
                TNombreCliente.Text = oVenta.nombreCliente;

                DateTime fechaRegistro = DateTime.ParseExact(oVenta.fechaRegistro, "dd-MM-yyyy HH:mm:ss", null);
                TFecha.Text = fechaRegistro.ToString("dd-MM-yyyy");
                THora.Text = fechaRegistro.ToString("HH:mm:ss");

                TTipoDocumento.Text = oVenta.tipoDocumento;

                dgvData.Rows.Clear();
                foreach (DetalleVenta dv in oVenta.oDetalleVenta)
                {
                    dgvData.Rows.Add(new object[]
                    {
                        dv.oProducto.nombre, dv.precioVenta, dv.cantidad, dv.subTotal
                    });
                }

                TTotal.Text = oVenta.montoTotal.ToString("0.00");
                TMontoPago.Text = oVenta.montoPago.ToString("0.00");
                TMontoCambio.Text = oVenta.montoCambio.ToString("0.00");
            }
            else
            {
                MessageBox.Show("No se encontró la venta buscada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TNroDocumento.Text = "";
            TIdVenta.Text = "";
            TDocumentoCajero.Text = "";
            TNombreCajero.Text = "";
            TDocumentoCliente.Text = "";
            TNombreCliente.Text = "";
            TFecha.Text = "";
            THora.Text = "";
            TTipoDocumento.Text = "";
            dgvData.Rows.Clear();
            TTotal.Text = "";
            TMontoPago.Text = "";
            TMontoCambio.Text = "";
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            TCodigoVenta.Select();
        }

        private void BDescargar_Click(object sender, EventArgs e)
        {
            guardarPDF();
        }

        public void guardarPDF(string nroVenta = "")
        {
            if (!string.IsNullOrEmpty(nroVenta))
            {
                buscarVenta(nroVenta);
            }

            if (TIdVenta.Text == "")
            {
                MessageBox.Show("No se encontraron resultados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string texto_html = Properties.Resources.PlantillaVenta.ToString();

            texto_html = texto_html.Replace("@tipodocumento", TTipoDocumento.Text.ToUpper());
            texto_html = texto_html.Replace("@numerodocumento", TNroDocumento.Text);

            texto_html = texto_html.Replace("@fecharegistro", TFecha.Text);
            texto_html = texto_html.Replace("@horaregistro", THora.Text);

            texto_html = texto_html.Replace("@doccliente", TDocumentoCliente.Text);
            texto_html = texto_html.Replace("@nombrecliente", TNombreCliente.Text);
            texto_html = texto_html.Replace("@docusuario", TDocumentoCajero.Text);
            texto_html = texto_html.Replace("@nombreusuario", TNombreCajero.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["subTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            texto_html = texto_html.Replace("@filas", filas);

            texto_html = texto_html.Replace("@montototal", TTotal.Text);
            texto_html = texto_html.Replace("@pagocon", TMontoPago.Text);
            texto_html = texto_html.Replace("@cambio", TMontoCambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", TNroDocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Obtener la imagen desde los recursos
                    System.Drawing.Image imgFromResources = Properties.Resources.logoFactura;

                    // Convertir la imagen a un MemoryStream para iTextSharp
                    using (MemoryStream ms = new MemoryStream())
                    {
                        imgFromResources.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] imgBytes = ms.ToArray();

                        // Cargar la imagen en iTextSharp desde los bytes
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imgBytes);

                        // Escalar y posicionar la imagen
                        img.ScaleToFit(55, 55);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(45));

                        // Añadir la imagen al documento PDF
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(texto_html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


    }
}
