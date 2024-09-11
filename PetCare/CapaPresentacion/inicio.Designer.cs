namespace CapaPresentacion
{
    partial class inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            menuUsuario = new FontAwesome.Sharp.IconMenuItem();
            menuReabastecedor = new FontAwesome.Sharp.IconMenuItem();
            subMenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            subMenuProductos = new FontAwesome.Sharp.IconMenuItem();
            menuVentas = new FontAwesome.Sharp.IconMenuItem();
            subMenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            subMenuVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            menuCompras = new FontAwesome.Sharp.IconMenuItem();
            subMenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            subMenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            menuClientes = new FontAwesome.Sharp.IconMenuItem();
            menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            menuReportes = new FontAwesome.Sharp.IconMenuItem();
            menuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            menuBackup = new FontAwesome.Sharp.IconMenuItem();
            container = new Panel();
            contenedor = new Panel();
            panel1 = new Panel();
            LUsuario = new Label();
            label1 = new Label();
            LTitulo = new Label();
            panel2 = new Panel();
            menu.SuspendLayout();
            container.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menuUsuario, menuReabastecedor, menuVentas, menuCompras, menuClientes, menuProveedores, menuReportes, menuAcercaDe, menuBackup });
            menu.Location = new Point(0, 66);
            menu.Name = "menu";
            menu.Padding = new Padding(5, 2, 0, 2);
            menu.Size = new Size(1088, 76);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuUsuario
            // 
            menuUsuario.AutoSize = false;
            menuUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            menuUsuario.IconColor = Color.Black;
            menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuario.ImageScaling = ToolStripItemImageScaling.None;
            menuUsuario.Name = "menuUsuario";
            menuUsuario.Size = new Size(122, 72);
            menuUsuario.Text = "Usuarios";
            menuUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            menuUsuario.Click += menuUsuario_Click;
            // 
            // menuReabastecedor
            // 
            menuReabastecedor.AutoSize = false;
            menuReabastecedor.DropDownItems.AddRange(new ToolStripItem[] { subMenuCategorias, subMenuProductos });
            menuReabastecedor.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            menuReabastecedor.IconColor = Color.Black;
            menuReabastecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReabastecedor.ImageScaling = ToolStripItemImageScaling.None;
            menuReabastecedor.Name = "menuReabastecedor";
            menuReabastecedor.Size = new Size(132, 72);
            menuReabastecedor.Text = "Reabastecedor";
            menuReabastecedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuCategorias
            // 
            subMenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuCategorias.IconColor = Color.Black;
            subMenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuCategorias.Name = "subMenuCategorias";
            subMenuCategorias.Size = new Size(130, 22);
            subMenuCategorias.Text = "Categorias";
            subMenuCategorias.Click += subMenuCategorias_Click;
            // 
            // subMenuProductos
            // 
            subMenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuProductos.IconColor = Color.Black;
            subMenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuProductos.Name = "subMenuProductos";
            subMenuProductos.Size = new Size(130, 22);
            subMenuProductos.Text = "Productos";
            subMenuProductos.Click += subMenuProductos_Click;
            // 
            // menuVentas
            // 
            menuVentas.AutoSize = false;
            menuVentas.DropDownItems.AddRange(new ToolStripItem[] { subMenuRegistrarVenta, subMenuVerDetalleVenta });
            menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuVentas.IconColor = Color.Black;
            menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuVentas.ImageScaling = ToolStripItemImageScaling.None;
            menuVentas.Name = "menuVentas";
            menuVentas.Size = new Size(132, 72);
            menuVentas.Text = "Ventas";
            menuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarVenta
            // 
            subMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarVenta.IconColor = Color.Black;
            subMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            subMenuRegistrarVenta.Size = new Size(128, 22);
            subMenuRegistrarVenta.Text = "Registrar";
            subMenuRegistrarVenta.Click += subMenuRegistrarVenta_Click;
            // 
            // subMenuVerDetalleVenta
            // 
            subMenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetalleVenta.IconColor = Color.Black;
            subMenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetalleVenta.Name = "subMenuVerDetalleVenta";
            subMenuVerDetalleVenta.Size = new Size(128, 22);
            subMenuVerDetalleVenta.Text = "Ver detalle";
            subMenuVerDetalleVenta.Click += subMenuVerDetalleVenta_Click;
            // 
            // menuCompras
            // 
            menuCompras.AutoSize = false;
            menuCompras.DropDownItems.AddRange(new ToolStripItem[] { subMenuRegistrarCompra, subMenuVerDetalleCompra });
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            menuCompras.IconColor = Color.Black;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.ImageScaling = ToolStripItemImageScaling.None;
            menuCompras.Name = "menuCompras";
            menuCompras.Size = new Size(152, 72);
            menuCompras.Text = "Compras";
            menuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarCompra
            // 
            subMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarCompra.IconColor = Color.Black;
            subMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            subMenuRegistrarCompra.Size = new Size(128, 22);
            subMenuRegistrarCompra.Text = "Registrar";
            subMenuRegistrarCompra.Click += subMenuRegistrarCompra_Click;
            // 
            // subMenuVerDetalleCompra
            // 
            subMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetalleCompra.IconColor = Color.Black;
            subMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            subMenuVerDetalleCompra.Size = new Size(128, 22);
            subMenuVerDetalleCompra.Text = "Ver detalle";
            subMenuVerDetalleCompra.Click += subMenuVerDetalleCompra_Click;
            // 
            // menuClientes
            // 
            menuClientes.AutoSize = false;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            menuClientes.IconColor = Color.Black;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.ImageScaling = ToolStripItemImageScaling.None;
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(152, 72);
            menuClientes.Text = "Clientes";
            menuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuClientes.Click += menuClientes_Click;
            // 
            // menuProveedores
            // 
            menuProveedores.AutoSize = false;
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            menuProveedores.IconColor = Color.Black;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Size = new Size(132, 72);
            menuProveedores.Text = "Proveedores";
            menuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            menuProveedores.Click += menuProveedores_Click;
            // 
            // menuReportes
            // 
            menuReportes.AutoSize = false;
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menuReportes.IconColor = Color.Black;
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReportes.ImageScaling = ToolStripItemImageScaling.None;
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(132, 72);
            menuReportes.Text = "Reportes";
            menuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuReportes.Click += menuReportes_Click;
            // 
            // menuAcercaDe
            // 
            menuAcercaDe.AutoSize = false;
            menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuAcercaDe.IconColor = Color.Black;
            menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            menuAcercaDe.Name = "menuAcercaDe";
            menuAcercaDe.Size = new Size(132, 72);
            menuAcercaDe.Text = "Acerca de";
            menuAcercaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            menuAcercaDe.Click += menuAcercaDe_Click;
            // 
            // menuBackup
            // 
            menuBackup.AutoSize = false;
            menuBackup.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            menuBackup.IconColor = Color.Black;
            menuBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuBackup.ImageScaling = ToolStripItemImageScaling.None;
            menuBackup.Name = "menuBackup";
            menuBackup.Size = new Size(132, 72);
            menuBackup.Text = "Backup";
            menuBackup.TextImageRelation = TextImageRelation.ImageAboveText;
            menuBackup.Click += menuBackup_Click;
            // 
            // container
            // 
            container.Controls.Add(contenedor);
            container.Controls.Add(menu);
            container.Controls.Add(panel1);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Margin = new Padding(3, 2, 3, 2);
            container.Name = "container";
            container.Size = new Size(1088, 407);
            container.TabIndex = 2;
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 142);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1088, 265);
            contenedor.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(LUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LTitulo);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 66);
            panel1.TabIndex = 0;
            // 
            // LUsuario
            // 
            LUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LUsuario.ForeColor = Color.White;
            LUsuario.Location = new Point(788, 30);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(185, 19);
            LUsuario.TabIndex = 4;
            LUsuario.Text = "LUsuario";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(714, 30);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            LTitulo.ForeColor = Color.White;
            LTitulo.Location = new Point(22, 18);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(258, 31);
            LTitulo.TabIndex = 2;
            LTitulo.Text = "Sistema de Ventas";
            // 
            // panel2
            // 
            panel2.Location = new Point(1072, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(16, 76);
            panel2.TabIndex = 1;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 407);
            Controls.Add(container);
            MainMenuStrip = menu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema PetCare";
            WindowState = FormWindowState.Maximized;
            Load += inicio_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            container.ResumeLayout(false);
            container.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuUsuario;
        private FontAwesome.Sharp.IconMenuItem menuReabastecedor;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcercaDe;
        private Panel container;
        private Panel panel1;
        private Panel panel2;
        private Label LTitulo;
        private Label LUsuario;
        private Label label1;
        private FontAwesome.Sharp.IconMenuItem subMenuCategorias;
        private FontAwesome.Sharp.IconMenuItem subMenuProductos;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem menuBackup;
        private Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem subMenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem subMenuVerDetalleCompra;
    }
}
