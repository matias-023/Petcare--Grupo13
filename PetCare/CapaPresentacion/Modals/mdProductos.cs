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
    public partial class mdProductos : Form
    {
        public int indiceProducto { get; set; }
        public DataGridViewRow fila { get; set; }
        public Producto mdProducto { get; set; }
        public mdProductos()
        {
            InitializeComponent();
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crear un borde negro alrededor del formulario
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void mdProductos_Load(object sender, EventArgs e)
        {
            TCodigo.Select();
            CEstado.Items.Add(new opcionCombo() { valor = 1, texto = "Activo" });
            CEstado.Items.Add(new opcionCombo() { valor = 0, texto = "No Activo" });
            CEstado.DisplayMember = "texto";
            CEstado.ValueMember = "valor";
            CEstado.SelectedIndex = 0;

            if (fila != null)
            {
                listarCategorias(1);
                listarMarcas(1);
                BAgregar.Text = "Editar";
                BAgregar.IconChar = FontAwesome.Sharp.IconChar.Edit;
                titulo.Text = "Editar Producto";
                rellenarCampos();
            }
            else
            {
                listarCategorias(0);
                listarMarcas(0);
            }
        }

        private void listarCategorias(int aux, string nombreCat = null)
        {
            List<Categoria> listaCategoria = new CN_Categoria().listar();

            if (aux == 0)
                listaCategoria = listaCategoria.Where(c => c.estado == true).ToList();
            if (aux == 1 && nombreCat != null)
                listaCategoria = listaCategoria.Where(c => c.estado == true || c.descripcion == nombreCat).ToList();


            CCategoria.Items.Clear();
            foreach (Categoria item in listaCategoria)
            {
                CCategoria.Items.Add(new opcionCombo() { valor = item.idCategoria, texto = item.descripcion });
            }
            CCategoria.DisplayMember = "texto";
            CCategoria.ValueMember = "valor";
            CCategoria.SelectedIndex = 0;
        }

        private void listarMarcas(int aux, string nombreMarca = null)
        {
            List<Marca> listaMarca = new CN_Marca().listar();

            if (aux == 0)
                listaMarca = listaMarca.Where(m => m.estado == true).ToList();
            if (aux == 1 && nombreMarca != null)
                listaMarca = listaMarca.Where(m => m.estado == true || m.descripcion == nombreMarca).ToList();


            CMarca.Items.Clear();
            foreach (Marca item in listaMarca)
            {
                CMarca.Items.Add(new opcionCombo() { valor = item.idMarca, texto = item.descripcion });
            }
            CMarca.DisplayMember = "texto";
            CMarca.ValueMember = "valor";
            CMarca.SelectedIndex = 0;


        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            //Muestra un mensaje si se elige la opción de producto no activo.
            if (Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 0)
            {
                DialogResult ask = MessageBox.Show("No se podrá modificar el stock de un producto no activo, desea continuar?", "Confirmar estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (ask == DialogResult.Yes)
                {
                    GuardarProducto();
                }
            }
            else
            {
                GuardarProducto();
            }
            
        }

        private void GuardarProducto()
        {

            string mensaje = string.Empty;
            mdProducto = new Producto()
            {
                idProducto = Convert.ToInt32(TIdProducto.Text),
                codigo = TCodigo.Text,
                nombre = TNombre.Text,
                stock = (int)numStock.Value,
                stock_min = (int)numStockMin.Value,
                precio = Math.Round(numPrecio.Value, 2),
                precio_venta = Math.Round(numPrecioVenta.Value, 2),
                oMarca = new Marca()
                {
                    idMarca = Convert.ToInt32(((opcionCombo)CMarca.SelectedItem).valor),
                    descripcion = ((opcionCombo)CMarca.SelectedItem).texto.ToString()
                },
                oCategoria = new Categoria()
                {
                    idCategoria = Convert.ToInt32(((opcionCombo)CCategoria.SelectedItem).valor),
                    descripcion = ((opcionCombo)CCategoria.SelectedItem).texto.ToString()
                },
                estado = Convert.ToInt32(((opcionCombo)CEstado.SelectedItem).valor) == 1 ? true : false
            };

            //Si es 0 significa que se esta creando un nuevo producto, caso contrario se está editando un producto
            if (mdProducto.idProducto == 0)
            {
                int idProductoGenerado = new CN_Producto().registrar(mdProducto, out mensaje);

                if (idProductoGenerado != 0)
                {
                    mdProducto.idProducto = idProductoGenerado;
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
                bool resultado = new CN_Producto().editar(mdProducto, out mensaje);
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
            TIdProducto.Text = fila.Cells["idProducto"].Value.ToString();
            TCodigo.Text = fila.Cells["codigo"].Value.ToString();
            TNombre.Text = fila.Cells["nombre"].Value.ToString();
            numStock.Value = Convert.ToDecimal(fila.Cells["stock"].Value);
            numStockMin.Value = Convert.ToDecimal(fila.Cells["stock_minimo"].Value);
            numPrecio.Value = Convert.ToDecimal(fila.Cells["precio"].Value);
            numPrecioVenta.Value = Convert.ToDecimal(fila.Cells["precioVenta"].Value);

            foreach (opcionCombo oc in CMarca.Items)
            {
                if (oc.texto == fila.Cells["marca"].Value.ToString())
                {
                    int indice_combo = CMarca.Items.IndexOf(oc);
                    CMarca.SelectedIndex = indice_combo;

                    Marca marcaSeleccionada = new CN_Marca().listar().FirstOrDefault(m => m.descripcion == oc.texto);
                    string nombreMarcaSeleccionada = oc.texto;

                    if (marcaSeleccionada != null && !marcaSeleccionada.estado)
                    {
                        numStock.Enabled = false;

                        listarMarcas(1, oc.texto);
                    }
                    else
                    {
                        listarMarcas(0);
                    }

                    int indiceSeleccionado = CMarca.Items.Cast<opcionCombo>().ToList().FindIndex(item => item.texto == nombreMarcaSeleccionada);
                    CMarca.SelectedIndex = indiceSeleccionado;


                    break;
                }

                if (oc.texto == fila.Cells["categoria"].Value.ToString())
                {
                    int indice_combo = CCategoria.Items.IndexOf(oc);
                    CCategoria.SelectedIndex = indice_combo;

                    Categoria categoriaSeleccionada = new CN_Categoria().listar().FirstOrDefault(c => c.descripcion == oc.texto);

                    string nombreCategoriaSeleccionada = oc.texto;

                    if (categoriaSeleccionada != null && !categoriaSeleccionada.estado)
                    {
                        numStock.Enabled = false;

                        listarCategorias(1, oc.texto);
                    }

                    else
                    {
                        listarCategorias(0);
                    }

                    int indiceSeleccionado = CCategoria.Items.Cast<opcionCombo>().ToList().FindIndex(item => item.texto == nombreCategoriaSeleccionada);
                    CCategoria.SelectedIndex = indiceSeleccionado;

                    break;
                }
            }

            foreach (opcionCombo oc in CCategoria.Items)
            {
                if (oc.texto == fila.Cells["categoria"].Value.ToString())
                {
                    int indice_combo = CCategoria.Items.IndexOf(oc);
                    CCategoria.SelectedIndex = indice_combo;

                    Categoria categoriaSeleccionada = new CN_Categoria().listar().FirstOrDefault(c => c.descripcion == oc.texto);

                    string nombreCategoriaSeleccionada = oc.texto;

                    if (categoriaSeleccionada != null && !categoriaSeleccionada.estado)
                    {
                        numStock.Enabled = false;

                        listarCategorias(1, oc.texto);
                    }

                    else
                    {
                        listarCategorias(0);
                    }

                    int indiceSeleccionado = CCategoria.Items.Cast<opcionCombo>().ToList().FindIndex(item => item.texto == nombreCategoriaSeleccionada);
                    CCategoria.SelectedIndex = indiceSeleccionado;

                    break;
                }
            }

            foreach (opcionCombo oc in CEstado.Items)
            {
                if (Convert.ToInt32(oc.valor) == Convert.ToInt32(fila.Cells["estadoValor"].Value))
                {
                    int indice_combo = CEstado.Items.IndexOf(oc);
                    CEstado.SelectedIndex = indice_combo;
                    break;
                }
            }

            opcionCombo seleccion = (opcionCombo)CEstado.SelectedItem;

            if (Convert.ToInt32(seleccion.valor) == 0)
            {
                numStock.Enabled = false;
            }

        }


    }
}