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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            container = new Panel();
            contenedor = new Panel();
            menu = new Panel();
            menuBackup = new FontAwesome.Sharp.IconButton();
            menuAcercaDe = new FontAwesome.Sharp.IconButton();
            panelSubMenuReportes = new Panel();
            subMenuReportesCompras = new FontAwesome.Sharp.IconButton();
            subMenuReportesVentas = new FontAwesome.Sharp.IconButton();
            menuReportes = new FontAwesome.Sharp.IconButton();
            menuProveedores = new FontAwesome.Sharp.IconButton();
            menuClientes = new FontAwesome.Sharp.IconButton();
            panelSubMenuCompras = new Panel();
            subMenuVerDetalleCompra = new FontAwesome.Sharp.IconButton();
            subMenuRegistrarCompra = new FontAwesome.Sharp.IconButton();
            menuCompras = new FontAwesome.Sharp.IconButton();
            panelSubMenuVentas = new Panel();
            subMenuRegistrarVenta = new FontAwesome.Sharp.IconButton();
            subMenuVerDetalleVenta = new FontAwesome.Sharp.IconButton();
            menuVentas = new FontAwesome.Sharp.IconButton();
            panelSubMenuReabastecedor = new Panel();
            subMenuProductos = new FontAwesome.Sharp.IconButton();
            subMenuCategorias = new FontAwesome.Sharp.IconButton();
            menuReabastecedor = new FontAwesome.Sharp.IconButton();
            menuUsuario = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            BRestaurar = new PictureBox();
            BMinimizar = new PictureBox();
            BMaximizar = new PictureBox();
            BCerrar = new PictureBox();
            iconoUsuario = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            LUsuario = new Label();
            label1 = new Label();
            LTitulo = new Label();
            panel2 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            container.SuspendLayout();
            menu.SuspendLayout();
            panelSubMenuReportes.SuspendLayout();
            panelSubMenuCompras.SuspendLayout();
            panelSubMenuVentas.SuspendLayout();
            panelSubMenuReabastecedor.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
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
            container.Size = new Size(1150, 550);
            container.TabIndex = 2;
            // 
            // contenedor
            // 
            contenedor.BackColor = Color.WhiteSmoke;
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(200, 66);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(950, 484);
            contenedor.TabIndex = 1;
            // 
            // menu
            // 
            menu.AutoScroll = true;
            menu.BackColor = Color.FromArgb(210, 120, 61);
            menu.Controls.Add(menuBackup);
            menu.Controls.Add(menuAcercaDe);
            menu.Controls.Add(panelSubMenuReportes);
            menu.Controls.Add(menuReportes);
            menu.Controls.Add(menuProveedores);
            menu.Controls.Add(menuClientes);
            menu.Controls.Add(panelSubMenuCompras);
            menu.Controls.Add(menuCompras);
            menu.Controls.Add(panelSubMenuVentas);
            menu.Controls.Add(menuVentas);
            menu.Controls.Add(panelSubMenuReabastecedor);
            menu.Controls.Add(menuReabastecedor);
            menu.Controls.Add(menuUsuario);
            menu.Dock = DockStyle.Left;
            menu.Location = new Point(0, 66);
            menu.Name = "menu";
            menu.Size = new Size(200, 484);
            menu.TabIndex = 2;
            // 
            // menuBackup
            // 
            menuBackup.Cursor = Cursors.Hand;
            menuBackup.Dock = DockStyle.Top;
            menuBackup.FlatAppearance.BorderSize = 0;
            menuBackup.FlatStyle = FlatStyle.Flat;
            menuBackup.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            menuBackup.ForeColor = Color.White;
            menuBackup.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            menuBackup.IconColor = Color.White;
            menuBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuBackup.IconSize = 35;
            menuBackup.ImageAlign = ContentAlignment.MiddleLeft;
            menuBackup.Location = new Point(0, 640);
            menuBackup.Name = "menuBackup";
            menuBackup.Padding = new Padding(5, 0, 0, 0);
            menuBackup.Size = new Size(183, 45);
            menuBackup.TabIndex = 8;
            menuBackup.Text = "Backup";
            menuBackup.TextAlign = ContentAlignment.MiddleLeft;
            menuBackup.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuBackup.UseVisualStyleBackColor = true;
            menuBackup.Click += menuBackup_Click;
            // 
            // menuAcercaDe
            // 
            menuAcercaDe.Cursor = Cursors.Hand;
            menuAcercaDe.Dock = DockStyle.Top;
            menuAcercaDe.FlatAppearance.BorderSize = 0;
            menuAcercaDe.FlatStyle = FlatStyle.Flat;
            menuAcercaDe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            menuAcercaDe.ForeColor = Color.White;
            menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuAcercaDe.IconColor = Color.White;
            menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuAcercaDe.IconSize = 35;
            menuAcercaDe.ImageAlign = ContentAlignment.MiddleLeft;
            menuAcercaDe.Location = new Point(0, 595);
            menuAcercaDe.Name = "menuAcercaDe";
            menuAcercaDe.Padding = new Padding(5, 0, 0, 0);
            menuAcercaDe.Size = new Size(183, 45);
            menuAcercaDe.TabIndex = 7;
            menuAcercaDe.Text = "Acerca de";
            menuAcercaDe.TextAlign = ContentAlignment.MiddleLeft;
            menuAcercaDe.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuAcercaDe.UseVisualStyleBackColor = true;
            menuAcercaDe.Click += menuAcercaDe_Click;
            // 
            // panelSubMenuReportes
            // 
            panelSubMenuReportes.BackColor = Color.FromArgb(245, 145, 73);
            panelSubMenuReportes.Controls.Add(subMenuReportesCompras);
            panelSubMenuReportes.Controls.Add(subMenuReportesVentas);
            panelSubMenuReportes.Dock = DockStyle.Top;
            panelSubMenuReportes.Location = new Point(0, 525);
            panelSubMenuReportes.Name = "panelSubMenuReportes";
            panelSubMenuReportes.Size = new Size(183, 70);
            panelSubMenuReportes.TabIndex = 11;
            // 
            // subMenuReportesCompras
            // 
            subMenuReportesCompras.Cursor = Cursors.Hand;
            subMenuReportesCompras.Dock = DockStyle.Top;
            subMenuReportesCompras.FlatAppearance.BorderSize = 0;
            subMenuReportesCompras.FlatStyle = FlatStyle.Flat;
            subMenuReportesCompras.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subMenuReportesCompras.ForeColor = Color.White;
            subMenuReportesCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuReportesCompras.IconColor = Color.Black;
            subMenuReportesCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuReportesCompras.Location = new Point(0, 35);
            subMenuReportesCompras.Name = "subMenuReportesCompras";
            subMenuReportesCompras.Padding = new Padding(35, 0, 0, 0);
            subMenuReportesCompras.Size = new Size(183, 35);
            subMenuReportesCompras.TabIndex = 6;
            subMenuReportesCompras.Text = "Compras";
            subMenuReportesCompras.TextAlign = ContentAlignment.MiddleLeft;
            subMenuReportesCompras.UseVisualStyleBackColor = true;
            subMenuReportesCompras.Click += subMenuReportesCompras_Click;
            // 
            // subMenuReportesVentas
            // 
            subMenuReportesVentas.Cursor = Cursors.Hand;
            subMenuReportesVentas.Dock = DockStyle.Top;
            subMenuReportesVentas.FlatAppearance.BorderSize = 0;
            subMenuReportesVentas.FlatStyle = FlatStyle.Flat;
            subMenuReportesVentas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subMenuReportesVentas.ForeColor = Color.White;
            subMenuReportesVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuReportesVentas.IconColor = Color.Black;
            subMenuReportesVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuReportesVentas.Location = new Point(0, 0);
            subMenuReportesVentas.Name = "subMenuReportesVentas";
            subMenuReportesVentas.Padding = new Padding(35, 0, 0, 0);
            subMenuReportesVentas.Size = new Size(183, 35);
            subMenuReportesVentas.TabIndex = 5;
            subMenuReportesVentas.Text = "Ventas";
            subMenuReportesVentas.TextAlign = ContentAlignment.MiddleLeft;
            subMenuReportesVentas.UseVisualStyleBackColor = true;
            subMenuReportesVentas.Click += subMenuReportesVentas_Click;
            // 
            // menuReportes
            // 
            menuReportes.Cursor = Cursors.Hand;
            menuReportes.Dock = DockStyle.Top;
            menuReportes.FlatAppearance.BorderSize = 0;
            menuReportes.FlatStyle = FlatStyle.Flat;
            menuReportes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            menuReportes.ForeColor = Color.White;
            menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menuReportes.IconColor = Color.White;
            menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReportes.IconSize = 35;
            menuReportes.ImageAlign = ContentAlignment.MiddleLeft;
            menuReportes.Location = new Point(0, 480);
            menuReportes.Name = "menuReportes";
            menuReportes.Padding = new Padding(5, 0, 0, 0);
            menuReportes.Size = new Size(183, 45);
            menuReportes.TabIndex = 6;
            menuReportes.Text = "Reportes";
            menuReportes.TextAlign = ContentAlignment.MiddleLeft;
            menuReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuReportes.UseVisualStyleBackColor = true;
            menuReportes.Click += menuReportes_Click;
            // 
            // menuProveedores
            // 
            menuProveedores.Cursor = Cursors.Hand;
            menuProveedores.Dock = DockStyle.Top;
            menuProveedores.FlatAppearance.BorderSize = 0;
            menuProveedores.FlatStyle = FlatStyle.Flat;
            menuProveedores.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            menuProveedores.ForeColor = Color.White;
            menuProveedores.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            menuProveedores.IconColor = Color.White;
            menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedores.IconSize = 35;
            menuProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            menuProveedores.Location = new Point(0, 435);
            menuProveedores.Name = "menuProveedores";
            menuProveedores.Padding = new Padding(5, 0, 0, 0);
            menuProveedores.Size = new Size(183, 45);
            menuProveedores.TabIndex = 5;
            menuProveedores.Text = "Proveedores";
            menuProveedores.TextAlign = ContentAlignment.MiddleLeft;
            menuProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuProveedores.UseVisualStyleBackColor = true;
            menuProveedores.Click += menuProveedores_Click;
            // 
            // menuClientes
            // 
            menuClientes.Cursor = Cursors.Hand;
            menuClientes.Dock = DockStyle.Top;
            menuClientes.FlatAppearance.BorderSize = 0;
            menuClientes.FlatStyle = FlatStyle.Flat;
            menuClientes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            menuClientes.ForeColor = Color.White;
            menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            menuClientes.IconColor = Color.White;
            menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuClientes.IconSize = 35;
            menuClientes.ImageAlign = ContentAlignment.MiddleLeft;
            menuClientes.Location = new Point(0, 390);
            menuClientes.Name = "menuClientes";
            menuClientes.Padding = new Padding(5, 0, 0, 0);
            menuClientes.Size = new Size(183, 45);
            menuClientes.TabIndex = 4;
            menuClientes.Text = "Clientes";
            menuClientes.TextAlign = ContentAlignment.MiddleLeft;
            menuClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuClientes.UseVisualStyleBackColor = true;
            menuClientes.Click += menuClientes_Click;
            // 
            // panelSubMenuCompras
            // 
            panelSubMenuCompras.BackColor = Color.FromArgb(245, 145, 73);
            panelSubMenuCompras.Controls.Add(subMenuVerDetalleCompra);
            panelSubMenuCompras.Controls.Add(subMenuRegistrarCompra);
            panelSubMenuCompras.Dock = DockStyle.Top;
            panelSubMenuCompras.Location = new Point(0, 320);
            panelSubMenuCompras.Name = "panelSubMenuCompras";
            panelSubMenuCompras.Size = new Size(183, 70);
            panelSubMenuCompras.TabIndex = 7;
            // 
            // subMenuVerDetalleCompra
            // 
            subMenuVerDetalleCompra.Cursor = Cursors.Hand;
            subMenuVerDetalleCompra.Dock = DockStyle.Top;
            subMenuVerDetalleCompra.FlatAppearance.BorderSize = 0;
            subMenuVerDetalleCompra.FlatStyle = FlatStyle.Flat;
            subMenuVerDetalleCompra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subMenuVerDetalleCompra.ForeColor = Color.White;
            subMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetalleCompra.IconColor = Color.Black;
            subMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetalleCompra.Location = new Point(0, 35);
            subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            subMenuVerDetalleCompra.Padding = new Padding(35, 0, 0, 0);
            subMenuVerDetalleCompra.Size = new Size(183, 35);
            subMenuVerDetalleCompra.TabIndex = 5;
            subMenuVerDetalleCompra.Text = "Ver detalle";
            subMenuVerDetalleCompra.TextAlign = ContentAlignment.MiddleLeft;
            subMenuVerDetalleCompra.UseVisualStyleBackColor = true;
            subMenuVerDetalleCompra.Click += subMenuVerDetalleCompra_Click;
            // 
            // subMenuRegistrarCompra
            // 
            subMenuRegistrarCompra.Cursor = Cursors.Hand;
            subMenuRegistrarCompra.Dock = DockStyle.Top;
            subMenuRegistrarCompra.FlatAppearance.BorderSize = 0;
            subMenuRegistrarCompra.FlatStyle = FlatStyle.Flat;
            subMenuRegistrarCompra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subMenuRegistrarCompra.ForeColor = Color.White;
            subMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarCompra.IconColor = Color.Black;
            subMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarCompra.Location = new Point(0, 0);
            subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            subMenuRegistrarCompra.Padding = new Padding(35, 0, 0, 0);
            subMenuRegistrarCompra.Size = new Size(183, 35);
            subMenuRegistrarCompra.TabIndex = 4;
            subMenuRegistrarCompra.Text = "Registrar";
            subMenuRegistrarCompra.TextAlign = ContentAlignment.MiddleLeft;
            subMenuRegistrarCompra.UseVisualStyleBackColor = true;
            subMenuRegistrarCompra.Click += subMenuRegistrarCompra_Click;
            // 
            // menuCompras
            // 
            menuCompras.Cursor = Cursors.Hand;
            menuCompras.Dock = DockStyle.Top;
            menuCompras.FlatAppearance.BorderSize = 0;
            menuCompras.FlatStyle = FlatStyle.Flat;
            menuCompras.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            menuCompras.ForeColor = Color.White;
            menuCompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            menuCompras.IconColor = Color.White;
            menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompras.IconSize = 35;
            menuCompras.ImageAlign = ContentAlignment.MiddleLeft;
            menuCompras.Location = new Point(0, 275);
            menuCompras.Name = "menuCompras";
            menuCompras.Padding = new Padding(5, 0, 0, 0);
            menuCompras.Size = new Size(183, 45);
            menuCompras.TabIndex = 3;
            menuCompras.Text = "Compras";
            menuCompras.TextAlign = ContentAlignment.MiddleLeft;
            menuCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuCompras.UseVisualStyleBackColor = true;
            menuCompras.Click += menuCompras_Click;
            // 
            // panelSubMenuVentas
            // 
            panelSubMenuVentas.BackColor = Color.FromArgb(245, 145, 73);
            panelSubMenuVentas.Controls.Add(subMenuRegistrarVenta);
            panelSubMenuVentas.Controls.Add(subMenuVerDetalleVenta);
            panelSubMenuVentas.Dock = DockStyle.Top;
            panelSubMenuVentas.Location = new Point(0, 205);
            panelSubMenuVentas.Name = "panelSubMenuVentas";
            panelSubMenuVentas.Size = new Size(183, 70);
            panelSubMenuVentas.TabIndex = 5;
            // 
            // subMenuRegistrarVenta
            // 
            subMenuRegistrarVenta.Cursor = Cursors.Hand;
            subMenuRegistrarVenta.Dock = DockStyle.Top;
            subMenuRegistrarVenta.FlatAppearance.BorderSize = 0;
            subMenuRegistrarVenta.FlatStyle = FlatStyle.Flat;
            subMenuRegistrarVenta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subMenuRegistrarVenta.ForeColor = Color.White;
            subMenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuRegistrarVenta.IconColor = Color.Black;
            subMenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuRegistrarVenta.Location = new Point(0, 0);
            subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            subMenuRegistrarVenta.Padding = new Padding(35, 0, 0, 0);
            subMenuRegistrarVenta.Size = new Size(183, 35);
            subMenuRegistrarVenta.TabIndex = 4;
            subMenuRegistrarVenta.Text = "Registrar";
            subMenuRegistrarVenta.TextAlign = ContentAlignment.MiddleLeft;
            subMenuRegistrarVenta.UseVisualStyleBackColor = true;
            subMenuRegistrarVenta.Click += subMenuRegistrarVenta_Click;
            // 
            // subMenuVerDetalleVenta
            // 
            subMenuVerDetalleVenta.Cursor = Cursors.Hand;
            subMenuVerDetalleVenta.Dock = DockStyle.Bottom;
            subMenuVerDetalleVenta.FlatAppearance.BorderSize = 0;
            subMenuVerDetalleVenta.FlatStyle = FlatStyle.Flat;
            subMenuVerDetalleVenta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subMenuVerDetalleVenta.ForeColor = Color.White;
            subMenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuVerDetalleVenta.IconColor = Color.Black;
            subMenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuVerDetalleVenta.Location = new Point(0, 35);
            subMenuVerDetalleVenta.Name = "subMenuVerDetalleVenta";
            subMenuVerDetalleVenta.Padding = new Padding(35, 0, 0, 0);
            subMenuVerDetalleVenta.Size = new Size(183, 35);
            subMenuVerDetalleVenta.TabIndex = 5;
            subMenuVerDetalleVenta.Text = "Ver detalle";
            subMenuVerDetalleVenta.TextAlign = ContentAlignment.MiddleLeft;
            subMenuVerDetalleVenta.UseVisualStyleBackColor = true;
            subMenuVerDetalleVenta.Click += subMenuVerDetalleVenta_Click;
            // 
            // menuVentas
            // 
            menuVentas.Cursor = Cursors.Hand;
            menuVentas.Dock = DockStyle.Top;
            menuVentas.FlatAppearance.BorderSize = 0;
            menuVentas.FlatStyle = FlatStyle.Flat;
            menuVentas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            menuVentas.ForeColor = Color.White;
            menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuVentas.IconColor = Color.White;
            menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuVentas.IconSize = 35;
            menuVentas.ImageAlign = ContentAlignment.MiddleLeft;
            menuVentas.Location = new Point(0, 160);
            menuVentas.Name = "menuVentas";
            menuVentas.Padding = new Padding(5, 0, 0, 0);
            menuVentas.Size = new Size(183, 45);
            menuVentas.TabIndex = 2;
            menuVentas.Text = "Ventas";
            menuVentas.TextAlign = ContentAlignment.MiddleLeft;
            menuVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuVentas.UseVisualStyleBackColor = true;
            menuVentas.Click += menuVentas_Click;
            // 
            // panelSubMenuReabastecedor
            // 
            panelSubMenuReabastecedor.BackColor = Color.FromArgb(245, 145, 73);
            panelSubMenuReabastecedor.Controls.Add(subMenuProductos);
            panelSubMenuReabastecedor.Controls.Add(subMenuCategorias);
            panelSubMenuReabastecedor.Dock = DockStyle.Top;
            panelSubMenuReabastecedor.Location = new Point(0, 90);
            panelSubMenuReabastecedor.Name = "panelSubMenuReabastecedor";
            panelSubMenuReabastecedor.Size = new Size(183, 70);
            panelSubMenuReabastecedor.TabIndex = 3;
            // 
            // subMenuProductos
            // 
            subMenuProductos.Cursor = Cursors.Hand;
            subMenuProductos.Dock = DockStyle.Top;
            subMenuProductos.FlatAppearance.BorderSize = 0;
            subMenuProductos.FlatStyle = FlatStyle.Flat;
            subMenuProductos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subMenuProductos.ForeColor = Color.White;
            subMenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuProductos.IconColor = Color.Black;
            subMenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuProductos.Location = new Point(0, 35);
            subMenuProductos.Name = "subMenuProductos";
            subMenuProductos.Padding = new Padding(35, 0, 0, 0);
            subMenuProductos.Size = new Size(183, 35);
            subMenuProductos.TabIndex = 3;
            subMenuProductos.Text = "Productos";
            subMenuProductos.TextAlign = ContentAlignment.MiddleLeft;
            subMenuProductos.UseVisualStyleBackColor = true;
            subMenuProductos.Click += subMenuProductos_Click;
            // 
            // subMenuCategorias
            // 
            subMenuCategorias.Cursor = Cursors.Hand;
            subMenuCategorias.Dock = DockStyle.Top;
            subMenuCategorias.FlatAppearance.BorderSize = 0;
            subMenuCategorias.FlatStyle = FlatStyle.Flat;
            subMenuCategorias.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subMenuCategorias.ForeColor = Color.White;
            subMenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            subMenuCategorias.IconColor = Color.Black;
            subMenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subMenuCategorias.Location = new Point(0, 0);
            subMenuCategorias.Name = "subMenuCategorias";
            subMenuCategorias.Padding = new Padding(35, 0, 0, 0);
            subMenuCategorias.Size = new Size(183, 35);
            subMenuCategorias.TabIndex = 2;
            subMenuCategorias.Text = "Categorias";
            subMenuCategorias.TextAlign = ContentAlignment.MiddleLeft;
            subMenuCategorias.UseVisualStyleBackColor = true;
            subMenuCategorias.Click += subMenuCategorias_Click;
            // 
            // menuReabastecedor
            // 
            menuReabastecedor.Cursor = Cursors.Hand;
            menuReabastecedor.Dock = DockStyle.Top;
            menuReabastecedor.FlatAppearance.BorderSize = 0;
            menuReabastecedor.FlatStyle = FlatStyle.Flat;
            menuReabastecedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            menuReabastecedor.ForeColor = Color.White;
            menuReabastecedor.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            menuReabastecedor.IconColor = Color.White;
            menuReabastecedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReabastecedor.IconSize = 35;
            menuReabastecedor.ImageAlign = ContentAlignment.MiddleLeft;
            menuReabastecedor.Location = new Point(0, 45);
            menuReabastecedor.Name = "menuReabastecedor";
            menuReabastecedor.Padding = new Padding(5, 0, 0, 0);
            menuReabastecedor.Size = new Size(183, 45);
            menuReabastecedor.TabIndex = 1;
            menuReabastecedor.Text = "Reabastecedor";
            menuReabastecedor.TextAlign = ContentAlignment.MiddleLeft;
            menuReabastecedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuReabastecedor.UseVisualStyleBackColor = true;
            menuReabastecedor.Click += menuReabastecedor_Click;
            // 
            // menuUsuario
            // 
            menuUsuario.Cursor = Cursors.Hand;
            menuUsuario.Dock = DockStyle.Top;
            menuUsuario.FlatAppearance.BorderSize = 0;
            menuUsuario.FlatStyle = FlatStyle.Flat;
            menuUsuario.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuUsuario.ForeColor = Color.White;
            menuUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            menuUsuario.IconColor = Color.White;
            menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuario.IconSize = 35;
            menuUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            menuUsuario.Location = new Point(0, 0);
            menuUsuario.Name = "menuUsuario";
            menuUsuario.Padding = new Padding(5, 0, 0, 0);
            menuUsuario.Size = new Size(183, 45);
            menuUsuario.TabIndex = 0;
            menuUsuario.Text = "Usuarios";
            menuUsuario.TextAlign = ContentAlignment.MiddleLeft;
            menuUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuUsuario.UseVisualStyleBackColor = true;
            menuUsuario.Click += menuUsuario_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 145, 73);
            panel1.Controls.Add(BRestaurar);
            panel1.Controls.Add(BMinimizar);
            panel1.Controls.Add(BMaximizar);
            panel1.Controls.Add(BCerrar);
            panel1.Controls.Add(iconoUsuario);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(LUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LTitulo);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 66);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // BRestaurar
            // 
            BRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BRestaurar.Cursor = Cursors.Hand;
            BRestaurar.Image = Properties.Resources.res;
            BRestaurar.Location = new Point(1090, 7);
            BRestaurar.Name = "BRestaurar";
            BRestaurar.Size = new Size(20, 20);
            BRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            BRestaurar.TabIndex = 10;
            BRestaurar.TabStop = false;
            BRestaurar.Visible = false;
            BRestaurar.Click += BRestaurar_Click;
            // 
            // BMinimizar
            // 
            BMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMinimizar.Cursor = Cursors.Hand;
            BMinimizar.Image = Properties.Resources.minimazar;
            BMinimizar.Location = new Point(1060, 7);
            BMinimizar.Name = "BMinimizar";
            BMinimizar.Size = new Size(20, 20);
            BMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BMinimizar.TabIndex = 9;
            BMinimizar.TabStop = false;
            BMinimizar.Click += BMinimizar_Click;
            // 
            // BMaximizar
            // 
            BMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMaximizar.Cursor = Cursors.Hand;
            BMaximizar.Image = Properties.Resources.maxi;
            BMaximizar.Location = new Point(1090, 7);
            BMaximizar.Name = "BMaximizar";
            BMaximizar.Size = new Size(20, 20);
            BMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            BMaximizar.TabIndex = 8;
            BMaximizar.TabStop = false;
            BMaximizar.Click += BMaximizar_Click;
            // 
            // BCerrar
            // 
            BCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrar.Cursor = Cursors.Hand;
            BCerrar.Image = Properties.Resources.cerrar;
            BCerrar.Location = new Point(1120, 7);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(20, 20);
            BCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BCerrar.TabIndex = 7;
            BCerrar.TabStop = false;
            BCerrar.Click += BCerrar_Click;
            // 
            // iconoUsuario
            // 
            iconoUsuario.BackColor = Color.FromArgb(245, 145, 73);
            iconoUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            iconoUsuario.IconColor = Color.White;
            iconoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoUsuario.IconSize = 25;
            iconoUsuario.Location = new Point(669, 28);
            iconoUsuario.Name = "iconoUsuario";
            iconoUsuario.Size = new Size(25, 25);
            iconoUsuario.TabIndex = 6;
            iconoUsuario.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(245, 145, 73);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShieldDog;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 50;
            iconPictureBox1.Location = new Point(24, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(50, 50);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // LUsuario
            // 
            LUsuario.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LUsuario.ForeColor = Color.White;
            LUsuario.Location = new Point(760, 29);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(185, 19);
            LUsuario.TabIndex = 4;
            LUsuario.Text = "LUsuario";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(692, 29);
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
            LTitulo.Location = new Point(70, 18);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(121, 31);
            LTitulo.TabIndex = 2;
            LTitulo.Text = "PetCare";
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
            ClientSize = new Size(1150, 550);
            Controls.Add(container);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema PetCare";
            Load += inicio_Load;
            container.ResumeLayout(false);
            menu.ResumeLayout(false);
            panelSubMenuReportes.ResumeLayout(false);
            panelSubMenuCompras.ResumeLayout(false);
            panelSubMenuVentas.ResumeLayout(false);
            panelSubMenuReabastecedor.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel container;
        private Panel panel1;
        private Panel panel2;
        private Label LTitulo;
        private Label LUsuario;
        private Label label1;
        private Panel contenedor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel menu;
        private FontAwesome.Sharp.IconButton menuUsuario;
        private Panel panelSubMenuReabastecedor;
        private Button subMenuCatego;
        private FontAwesome.Sharp.IconButton menuReabastecedor;
        private FontAwesome.Sharp.IconButton menuVentas;
        private Panel panelSubMenuReportes;
        private FontAwesome.Sharp.IconButton menuReportes;
        private FontAwesome.Sharp.IconButton menuProveedores;
        private FontAwesome.Sharp.IconButton menuClientes;
        private Panel panelSubMenuCompras;
        private FontAwesome.Sharp.IconButton menuCompras;
        private Panel panelSubMenuVentas;
        private FontAwesome.Sharp.IconButton menuBackup;
        private FontAwesome.Sharp.IconButton menuAcercaDe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton subMenuCategorias;
        private FontAwesome.Sharp.IconButton subMenuVerDetalleVenta;
        private FontAwesome.Sharp.IconButton subMenuReportesCompras;
        private FontAwesome.Sharp.IconButton subMenuReportesVentas;
        private FontAwesome.Sharp.IconButton subMenuVerDetalleCompra;
        private FontAwesome.Sharp.IconButton subMenuRegistrarCompra;
        private FontAwesome.Sharp.IconButton subMenuRegistrarVenta;
        private FontAwesome.Sharp.IconButton subMenuProductos;
        private FontAwesome.Sharp.IconPictureBox iconoUsuario;
        private PictureBox BMinimizar;
        private PictureBox BMaximizar;
        private PictureBox BCerrar;
        private PictureBox BRestaurar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}
