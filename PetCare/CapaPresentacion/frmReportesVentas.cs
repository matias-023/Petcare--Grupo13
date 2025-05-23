﻿using System;
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
using ClosedXML.Excel;



namespace CapaPresentacion
{
    public partial class frmReportesVentas : Form
    {
        private static Usuario user;
        public frmReportesVentas(Usuario objUsuario)
        {
            user = objUsuario;
            InitializeComponent();
        }

        private void frmReportesVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "verDetalle")
                {
                    CBusqueda.Items.Add(new opcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            CBusqueda.DisplayMember = "texto";
            CBusqueda.ValueMember = "valor";
            CBusqueda.SelectedIndex = 0;
        }

        private void BBuscarReporte_Click(object sender, EventArgs e)
        {
            List<reporteVenta> lista = new List<reporteVenta>();

            lista = new CN_Reporte().Venta(txtfechainicio.Value.ToString(), txtfechafin.Value.ToString(), user);

            dgvData.Rows.Clear();

            foreach (reporteVenta rv in lista)
            {
                dgvData.Rows.Add(new object[]
                {
                    rv.idVenta,
                    "",
                    rv.fechaRegistro,
                    rv.horaRegistro,
                    rv.tipoDocumento,
                    rv.numeroDocumento,
                    rv.documentoUsuario,
                    rv.usuarioRegistro,
                    rv.documentoCliente,
                    rv.nombreCliente,
                    rv.montoTotal
                });
            }
        }

        private void BBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((opcionCombo)CBusqueda.SelectedItem).valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TBusqueda.Text.Trim().ToUpper()))
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

        private void BDescargarExcel_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvData.Columns)
                {
                    if (columna.Name != "idVenta" && columna.Name != "verDetalle")
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString()

                        });
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = savefile.FileName,
                            UseShellExecute = true
                        });
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar el reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.eye.Width;
                var h = Properties.Resources.eye.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.eye, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "verDetalle")
            {
                int indice = e.RowIndex;

                if (indice >= 0)

                {
                    dgvDetalle.Rows.Clear();
                    int idVenta = Convert.ToInt32(dgvData.Rows[indice].Cells["idVenta"].Value);
                    string nroVenta = dgvData.Rows[indice].Cells["numeroVenta"].Value.ToString();

                    LDetalleVenta.Text = "Detalle de Venta Nro: " + nroVenta;

                    List<DetalleVenta> lista = new List<DetalleVenta>();

                    lista = new CN_Venta().obtenerDetalle(idVenta);

                    foreach (DetalleVenta dv in lista)
                    {
                        dgvDetalle.Rows.Add(new object[]
                        {
                        dv.oProducto.codigo,
                        dv.oProducto.nombre,
                        dv.cantidad,
                        dv.precioVenta,
                        dv.subTotal
                        });
                    }
                }
            }
        }



    }
}
